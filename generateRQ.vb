Imports QRCoder

Public Class generateRQ

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If pbQROutput.Image Is Nothing Then
            MessageBox.Show("No image selected. Please load an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim dialog As New SaveFileDialog()
        dialog.Filter = "Images (*.jpg;)|*.jpg;| Images (*.png;)|*.png;| Images (*.bmp)|*.bmp;"

        If dialog.ShowDialog() = DialogResult.OK Then
            pbQROutput.Image.Save(dialog.FileName)
            MessageBox.Show("Image saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        pbQROutput.Image = Nothing
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            Dim gen As New QRCodeGenerator()
            Dim dataString As String = txtbxQRString.Text
            Dim data = gen.CreateQrCode(dataString, QRCodeGenerator.ECCLevel.Q)
            Dim code As New QRCode(data)
            pbQROutput.Image = code.GetGraphic(10)
        Catch ex As Exception
            MessageBox.Show("Error generating QR " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class