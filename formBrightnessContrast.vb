Imports Emgu.CV
Imports Emgu.CV.Structure

Public Class formBrightnessContrast

    Public Property ImgInput As Image(Of Bgr, Byte)
    Private imgOutput As Image(Of Bgr, Byte)
    Public Event ImageUpdated As Action(Of Image(Of Bgr, Byte))

    Private Sub formBrightnessContrast_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ImgInput IsNot Nothing Then
            PictureBox1.Image = ImgInput.AsBitmap
        End If

        TrackBar1.Value = 90

        lblCurrentBrightness.Text = TrackBar2.Value.ToString()
        lblMinBrightness.Text = TrackBar2.Minimum.ToString()
        lblMaxBrightness.Text = TrackBar2.Maximum.ToString()

        lblCurrentContrast.Text = (TrackBar1.Value / 100.0).ToString("F2")
        lblMinContrast.Text = (TrackBar1.Minimum / 100.0).ToString("F2")
        lblMaxContrast.Text = (TrackBar1.Maximum / 100.0).ToString("F2")
    End Sub

    Private Sub ContrastAdjust()
        lblCurrentContrast.Text = (TrackBar1.Value / 100.0).ToString("F2")

        Dim contrast As Single = (TrackBar1.Value - 50) / 50.0F

        imgOutput = ImgInput.Convert(Of Bgr, Byte)().Mul(contrast)
        PictureBox1.Image = imgOutput.ToBitmap()
    End Sub

    Private Sub BrightnessAdjust()
        lblCurrentBrightness.Text = TrackBar2.Value.ToString()

        Dim brightness As Integer = TrackBar2.Value
        brightness = Math.Max(Math.Min(brightness, 255), -255)

        imgOutput = ImgInput.Convert(Of Bgr, Byte)().Add(New Bgr(brightness, brightness, brightness))
        PictureBox1.Image = imgOutput.ToBitmap()
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Try
            ContrastAdjust()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TrackBar2_Scroll(sender As Object, e As EventArgs) Handles TrackBar2.Scroll
        Try
            BrightnessAdjust()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim dialog As New SaveFileDialog()
        dialog.Filter = "Images (*.jpg;)|*.jpg;| Images (*.png;)|*.png;| Images (*.bmp)|*.bmp;"

        If dialog.ShowDialog() = DialogResult.OK Then
            imgOutput.Save(dialog.FileName)
            MessageBox.Show("Image saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ApplyChangesAndClose()
        RaiseEvent ImageUpdated(imgOutput)
    End Sub

    Private Sub formBrightnessContrast_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ApplyChangesAndClose()
    End Sub

End Class