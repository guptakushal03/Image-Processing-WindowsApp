Imports Emgu.CV
Imports Emgu.CV.CvEnum
Imports Emgu.CV.Structure

Public Class formBinarization

    Public Property imgInput As Image(Of Bgr, Byte)
    Public Property pbOutput As PictureBox

    Private Sub formBinarization_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCurrent.Text = TrackBar1.Value.ToString()
        lblMin.Text = TrackBar1.Minimum.ToString()
        lblMax.Text = TrackBar1.Maximum.ToString()
    End Sub

    Private Sub BrightnessAdjust()
        lblCurrent.Text = TrackBar1.Value.ToString()
        UpdateBinarizedImage()
    End Sub

    Private Sub UpdateBinarizedImage()
        If imgInput IsNot Nothing Then
            Dim grayImage As New Image(Of Gray, Byte)(imgInput.Width, imgInput.Height)
            CvInvoke.CvtColor(imgInput, grayImage, ColorConversion.Bgr2Gray)

            Dim thresholdValue As Integer = TrackBar1.Value
            Dim imgBinarize As New Image(Of Gray, Byte)(grayImage.Width, grayImage.Height)
            CvInvoke.Threshold(grayImage, imgBinarize, thresholdValue, 255, ThresholdType.Binary)

            pbOutput.Image = imgBinarize.AsBitmap
        End If
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Try
            BrightnessAdjust()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class