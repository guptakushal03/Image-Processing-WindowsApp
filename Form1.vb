Imports System.IO
Imports Emgu.CV
Imports Emgu.CV.CvEnum
Imports Emgu.CV.Face
Imports Emgu.CV.OCR
Imports Emgu.CV.Structure
Imports Emgu.CV.Util

Imports IronBarCode

Public Class Form1

    Dim imgInput As Image(Of Bgr, Byte)
    Dim GrayImage As Image(Of Gray, Byte)

#Region "TreeView"

    Dim imgList As New Dictionary(Of String, Image(Of Bgr, Byte))

    Private Sub AddImage(img As Image(Of Bgr, Byte), keyname As String)
        If Not TreeView1.Nodes.ContainsKey(keyname) Then
            Dim node As New TreeNode(keyname)
            node.Name = keyname
            TreeView1.Nodes.Add(node)
            TreeView1.SelectedNode = node
        End If

        If Not imgList.ContainsKey(keyname) Then
            imgList.Add(keyname, img)
        Else
            imgList(keyname) = img
        End If
    End Sub

    Private Sub TreeView1_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick
        Try
            If imgList.ContainsKey(e.Node.Text) Then
                imgInput = imgList(e.Node.Text)
                pbInput.Image = imgInput.ToBitmap()
                pbOutput.Image = Nothing
            Else
                MessageBox.Show("Image not found in list.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Failed Opening Image: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "File Section"

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim dialog As New OpenFileDialog()
        dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;"

        If dialog.ShowDialog() = DialogResult.OK Then
            imgList.Clear()
            TreeView1.Nodes.Clear()
            imgInput = New Image(Of Bgr, Byte)(dialog.FileName)
            pbInput.Image = imgInput.ToBitmap
            AddImage(imgInput, "Input Image")
        End If
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        pbInput.Image = Nothing
        pbOutput.Image = Nothing
        imgInput = Nothing
        imgList.Clear()
        TreeView1.Nodes.Clear()
    End Sub

    Private Sub CloseOutputImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseOutputImageToolStripMenuItem.Click
        pbOutput.Image = Nothing
    End Sub

    Private Sub SaveOutputToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveOutputToolStripMenuItem.Click
        If pbOutput.Image Is Nothing Then
            MessageBox.Show("No image present in Output Box.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim dialog As New SaveFileDialog()
        dialog.Filter = "Images (*.jpg;)|*.jpg;| Images (*.png;)|*.png;| Images (*.bmp)|*.bmp;"

        If dialog.ShowDialog() = DialogResult.OK Then
            pbOutput.Image.Save(dialog.FileName)
            MessageBox.Show("Image saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

#End Region

#Region "Edit Section"

    Private Sub GrayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GrayToolStripMenuItem.Click
        If imgInput Is Nothing Then
            MessageBox.Show("No image selected. Please load an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        GrayImage = New Image(Of Gray, Byte)(imgInput.Width, imgInput.Height)
        pbInput.Image = imgInput.ToBitmap
        GrayImage = imgInput.Convert(Of Gray, Byte)()

        pbOutput.Image = GrayImage.AsBitmap
    End Sub

    Private Sub BinarizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BinarizeToolStripMenuItem.Click
        If imgInput Is Nothing Then
            MessageBox.Show("No image selected. Please load an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim frm As New formBinarization()

        frm.imgInput = imgInput
        frm.pbOutput = pbOutput

        frm.ShowDialog()
    End Sub

    Private Sub ContoursToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContoursToolStripMenuItem.Click
        If imgInput Is Nothing Then
            MessageBox.Show("No image selected. Please load an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim imgOutput As Image(Of Gray, Byte) = imgInput.Convert(Of Gray, Byte)().ThresholdBinary(New Gray(100), New Gray(255))
        Dim contours As New VectorOfVectorOfPoint()
        Dim hier As New Mat()

        CvInvoke.FindContours(imgOutput, contours, hier, RetrType.External, ChainApproxMethod.ChainApproxSimple)
        CvInvoke.DrawContours(imgInput, contours, -1, New MCvScalar(255, 0, 0))

        Dim imgOut As New Image(Of Gray, Byte)(imgInput.Width, imgInput.Height, New Gray(0))
        CvInvoke.DrawContours(imgOut, contours, -1, New MCvScalar(255, 0, 0))

        pbOutput.Image = imgOut.AsBitmap
    End Sub

    Private Sub BrightnessAndContrastToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BrightnessAndContrastToolStripMenuItem.Click
        If imgInput Is Nothing Then
            MessageBox.Show("No image selected. Please load an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Dim frm As New formBrightnessContrast()
            frm.ImgInput = imgInput

            AddHandler frm.ImageUpdated, AddressOf HandleImageUpdated

            frm.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub HandleImageUpdated(updatedImage As Image(Of Bgr, Byte))
        AddImage(updatedImage, "Brightness And Contrast")
    End Sub

#End Region

#Region "Morphological Processing"

    Private Sub ErosionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ErosionToolStripMenuItem.Click
        If imgInput Is Nothing Then
            MessageBox.Show("No image selected. Please load an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        pbOutput.Image = imgInput.Erode(5).AsBitmap
        AddImage(imgInput.Erode(5), "Eroded Image")
    End Sub

    Private Sub DilationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DilationToolStripMenuItem.Click
        If imgInput Is Nothing Then
            MessageBox.Show("No image selected. Please load an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        pbOutput.Image = imgInput.Dilate(5).AsBitmap
        AddImage(imgInput.Dilate(5), "Dilated Image")
    End Sub

    Private Sub OpeningToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpeningToolStripMenuItem.Click
        If imgInput Is Nothing Then
            MessageBox.Show("No image selected. Please load an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim kernel As Mat = CvInvoke.GetStructuringElement(ElementShape.Rectangle, New Size(5, 5), New Point(-1, -1))
        pbOutput.Image = imgInput.MorphologyEx(MorphOp.Open, kernel, New Point(-1, -1), 1, BorderType.Default, New MCvScalar(1.0)).ToBitmap()
        AddImage(imgInput.MorphologyEx(MorphOp.Open, kernel, New Point(-1, -1), 1, BorderType.Default, New MCvScalar(1.0)), "Opened Image")
    End Sub

    Private Sub ClosingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClosingToolStripMenuItem.Click
        If imgInput Is Nothing Then
            MessageBox.Show("No image selected. Please load an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim kernel As Mat = CvInvoke.GetStructuringElement(ElementShape.Rectangle, New Size(5, 5), New Point(-1, -1))
        pbOutput.Image = imgInput.MorphologyEx(MorphOp.Close, kernel, New Point(-1, -1), 1, BorderType.Default, New MCvScalar(1.0)).ToBitmap()
        AddImage(imgInput.MorphologyEx(MorphOp.Close, kernel, New Point(-1, -1), 1, BorderType.Default, New MCvScalar(1.0)), "Closed Image")
    End Sub

    Private Sub GradiantToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GradiantToolStripMenuItem.Click
        If imgInput Is Nothing Then
            MessageBox.Show("No image selected. Please load an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim kernel As Mat = CvInvoke.GetStructuringElement(ElementShape.Rectangle, New Size(5, 5), New Point(-1, -1))
        pbOutput.Image = imgInput.MorphologyEx(MorphOp.Gradient, kernel, New Point(-1, -1), 1, BorderType.Default, New MCvScalar(1.0)).ToBitmap()
        AddImage(imgInput.MorphologyEx(MorphOp.Gradient, kernel, New Point(-1, -1), 1, BorderType.Default, New MCvScalar(1.0)), "Gradient Image")
    End Sub

    Private Sub TopHatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TopHatToolStripMenuItem.Click
        If imgInput Is Nothing Then
            MessageBox.Show("No image selected. Please load an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim kernel As Mat = CvInvoke.GetStructuringElement(ElementShape.Rectangle, New Size(5, 5), New Point(-1, -1))
        pbOutput.Image = imgInput.MorphologyEx(MorphOp.Tophat, kernel, New Point(-1, -1), 1, BorderType.Default, New MCvScalar(1.0)).ToBitmap()
        AddImage(imgInput.MorphologyEx(MorphOp.Tophat, kernel, New Point(-1, -1), 1, BorderType.Default, New MCvScalar(1.0)), "TopHat Image")
    End Sub

    Private Sub BlackHatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlackHatToolStripMenuItem.Click
        If imgInput Is Nothing Then
            MessageBox.Show("No image selected. Please load an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim kernel As Mat = CvInvoke.GetStructuringElement(ElementShape.Rectangle, New Size(5, 5), New Point(-1, -1))
        pbOutput.Image = imgInput.MorphologyEx(MorphOp.Blackhat, kernel, New Point(-1, -1), 1, BorderType.Default, New MCvScalar(1.0)).ToBitmap()
        AddImage(imgInput.MorphologyEx(MorphOp.Blackhat, kernel, New Point(-1, -1), 1, BorderType.Default, New MCvScalar(1.0)), "BlackHat Image")
    End Sub

#End Region

#Region "Face Detection"

    Public Async Sub DetectFaceHaar()
        Try
            pbInput.Enabled = False

            Await Task.Run(Sub()
                               Dim facePath As String = Path.Combine("Data Files", "haarcascade_frontalface_default.xml")
                               Dim classifierFace As New CascadeClassifier(facePath)

                               Dim inputCopy As Image(Of Bgr, Byte) = imgInput.Clone()
                               Dim imgGray As Image(Of Gray, Byte) = inputCopy.Convert(Of Gray, Byte)()
                               Dim faces As Rectangle() = classifierFace.DetectMultiScale(imgGray, 1.1, 4)

                               For Each face As Rectangle In faces
                                   inputCopy.Draw(face, New Bgr(255, 0, 0), 2)
                               Next

                               pbInput.Invoke(Sub()
                                                  pbInput.Image = inputCopy.AsBitmap()
                                                  AddImage(inputCopy, "Face Detected Image")
                                              End Sub)
                           End Sub)

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            pbInput.Enabled = True
        End Try
    End Sub

#End Region

#Region "Eyes Detection"

    Private Sub FaceDetectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FaceDetectionToolStripMenuItem.Click
        If imgInput Is Nothing Then
            MessageBox.Show("No image selected. Please load an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        DetectFaceHaar()
    End Sub

    Public Async Sub DetectEyesHaar()
        Try
            pbInput.Enabled = False

            Await Task.Run(Sub()
                               Dim facePath As String = Path.Combine("Data Files", "haarcascade_frontalface_default.xml")
                               Dim eyePath As String = Path.Combine("Data Files", "haarcascade_eye.xml")

                               Dim classifierFace As New CascadeClassifier(facePath)
                               Dim classifierEye As New CascadeClassifier(eyePath)

                               Dim inputCopy As Image(Of Bgr, Byte) = imgInput.Clone()
                               Dim imgGray As Image(Of Gray, Byte) = inputCopy.Convert(Of Gray, Byte)()
                               Dim faces As Rectangle() = classifierFace.DetectMultiScale(imgGray, 1.1, 4)

                               For Each face As Rectangle In faces
                                   imgGray.ROI = face
                                   Dim eyes As Rectangle() = classifierEye.DetectMultiScale(imgGray, 1.1, 4)
                                   imgGray.ROI = Rectangle.Empty

                                   For Each eye As Rectangle In eyes
                                       Dim e As Rectangle = eye
                                       e.X += face.X
                                       e.Y += face.Y
                                       inputCopy.Draw(e, New Bgr(0, 255, 0), 2)
                                   Next
                               Next

                               pbInput.Invoke(Sub()
                                                  pbInput.Image = inputCopy.AsBitmap()
                                                  AddImage(inputCopy, "Eyes Detected Image")
                                              End Sub)
                           End Sub)

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            pbInput.Enabled = True
        End Try
    End Sub

    Private Sub EyesDetectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EyesDetectionToolStripMenuItem.Click
        If imgInput Is Nothing Then
            MessageBox.Show("No image selected. Please load an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        DetectEyesHaar()
    End Sub

#End Region

#Region "Face Lnadmark Detection"

    Public Class FaceLandmarkDetector
        Implements IDisposable

        Private ReadOnly _lbpFacePath As String
        Private ReadOnly _modelPath As String
        Private ReadOnly _classifier As CascadeClassifier
        Private ReadOnly _facemark As FacemarkLBF
        Private disposedValue As Boolean

        Public Sub New(lbpFacePath As String, modelPath As String)
            _lbpFacePath = lbpFacePath
            _modelPath = modelPath

            _classifier = New CascadeClassifier(lbpFacePath)
            Dim params As New FacemarkLBFParams()
            _facemark = New FacemarkLBF(params)
            _facemark.LoadModel(modelPath)
        End Sub

        Public Function DetectAndDrawLandmarks(image As Image) As Bitmap
            If image Is Nothing Then
                Throw New ArgumentNullException(NameOf(image))
            End If

            Dim bmp As New Bitmap(image)

            Dim grayImage As Image(Of Gray, Byte) = bmp.ToImage(Of Gray, Byte)()
            Dim colorImage As Image(Of Bgr, Byte) = bmp.ToImage(Of Bgr, Byte)()

            Dim faces As Rectangle() = _classifier.DetectMultiScale(grayImage)
            If faces.Length = 0 Then
                Return colorImage.ToBitmap()
            End If

            Dim landmarks As New VectorOfVectorOfPointF()
            Dim rects As New VectorOfRect(faces)

            If _facemark.Fit(grayImage, rects, landmarks) Then
                For i As Integer = 0 To faces.Length - 1
                    For j As Integer = 0 To landmarks(i).Size - 1
                        Dim point As PointF = landmarks(i)(j)
                        CvInvoke.Circle(colorImage, New Point(CInt(point.X), CInt(point.Y)), 2, New MCvScalar(0, 0, 255), -1)
                    Next
                Next
            End If

            Return colorImage.ToBitmap()
        End Function

        Protected Overridable Sub Dispose(disposing As Boolean)
            If Not disposedValue Then
                If disposing Then
                    _classifier.Dispose()
                    _facemark.Dispose()
                End If

                disposedValue = True
            End If
        End Sub

        Public Sub Dispose() Implements IDisposable.Dispose
            Dispose(disposing:=True)
            GC.SuppressFinalize(Me)
        End Sub
    End Class

    Private Async Sub FaceLandmarkDetectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FaceLandmarkDetectionToolStripMenuItem.Click
        If pbInput.Image Is Nothing Then
            MessageBox.Show("No image loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        pbInput.Enabled = False

        Try
            Dim inputImage As Bitmap = CType(pbInput.Image.Clone(), Bitmap)

            Dim resultBitmap As Bitmap = Await Task.Run(Function()
                                                            Using detector As New FaceLandmarkDetector(
                                                    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data Files", "lbpcascade_frontalface_improved.xml"),
                                                    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data Files", "lbfmodel.yaml"))
                                                                Return detector.DetectAndDrawLandmarks(inputImage)
                                                            End Using
                                                        End Function)

            pbInput.Image = resultBitmap

            Dim resultImage As Image(Of Bgr, Byte) = resultBitmap.ToImage(Of Bgr, Byte)()
            AddImage(resultImage, "Face Landmark Image")

        Catch ex As Exception
            MessageBox.Show("Error processing image: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            pbInput.Enabled = True
        End Try
    End Sub

#End Region

#Region "Covid 19"

    Private Function CountContours(ByVal img As Image(Of Gray, Byte)) As Integer
        Dim contours As New VectorOfVectorOfPoint()
        CvInvoke.FindContours(img, contours, Nothing, RetrType.External, ChainApproxMethod.ChainApproxSimple)
        Return contours.Size
    End Function

    Private Sub Covid19TestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Covid19TestToolStripMenuItem.Click
        If imgInput Is Nothing Then
            MessageBox.Show("No image selected. Please load an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim edges = imgInput.Convert(Of Gray, Byte)().Canny(150, 50)

        Dim morphary As New Mat()
        CvInvoke.MorphologyEx(edges, morphary, MorphOp.Close, Mat.Ones(5, 5, DepthType.Cv8U, 1), New Point(-1, -1), 3, BorderType.Default, New MCvScalar(0))

        Dim contours As New VectorOfVectorOfPoint()
        Dim h As New Mat()
        CvInvoke.FindContours(morphary, contours, h, RetrType.Tree, ChainApproxMethod.ChainApproxSimple)

        Dim preprocessed = edges.CopyBlank()
        Dim data = h.GetData()

        For r As Integer = 0 To data.GetLength(0) - 1
            For c As Integer = 0 To data.GetLength(1) - 1
                If CType(data.GetValue(r, c, 2), Integer) = -1 AndAlso CType(data.GetValue(r, c, 3), Integer) > -1 Then
                    Dim bbox = CvInvoke.BoundingRectangle(contours(c))
                    Dim AR = bbox.Width / CType(bbox.Height, Single)
                    If AR <= 2.0F Then
                        CvInvoke.DrawContours(preprocessed, contours, c, New MCvScalar(255), -1)
                    End If
                End If
            Next
        Next

        Dim output1 = edges.CopyBlank()
        CvInvoke.Dilate(preprocessed, output1, Mat.Ones(10, 1, DepthType.Cv8U, 1), New Point(-1, -1), 1, BorderType.Default, New MCvScalar(0))

        contours.Clear()
        CvInvoke.FindContours(output1, contours, h, RetrType.External, ChainApproxMethod.ChainApproxSimple)

        Dim finaloutput = edges.CopyBlank()
        For i As Integer = 0 To contours.Size - 1
            Dim box = CvInvoke.BoundingRectangle(contours(i))
            If box.Height > (box.Width * 3) Then
                CvInvoke.DrawContours(finaloutput, contours, i, New MCvScalar(255), -1)
                preprocessed.ROI = box
                Dim count As Integer = CountContours(preprocessed)
                preprocessed.ROI = Rectangle.Empty

                Dim msg As String = ""
                Dim color As MCvScalar

                If count = 2 Then
                    msg = "Negative"
                    color = New MCvScalar(0, 255, 0)
                Else
                    msg = "Positive"
                    color = New MCvScalar(0, 0, 255)
                End If

                Dim margin = 50
                CvInvoke.PutText(imgInput, msg, New Point(box.X - margin, box.Y - margin), FontFace.HersheyPlain, 2.5, color, 3)
            End If
        Next

        pbInput.Image = imgInput.ToBitmap()
    End Sub

#End Region

#Region "Barcode"

    Dim barcodeResults As BarcodeResults

    Private Sub QRCodeReaderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QRCodeReaderToolStripMenuItem.Click
        If imgInput Is Nothing Then
            MessageBox.Show("No image selected. Please load an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim decodedText As String = DecodeBarcode(imgInput.ToBitmap)

        If decodedText IsNot Nothing Then
            MessageBox.Show("Data: " & vbCrLf & decodedText, "Barcode Detected", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("No Barcode Detected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function DecodeBarcode(barcodeImage As Image) As String
        Try
            barcodeResults = BarcodeReader.Read(barcodeImage)

            If barcodeResults.Count > 0 Then
                Return barcodeResults(0).Text
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("Error reading the barcode: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Private Sub QRCodeGeneratorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QRCodeGeneratorToolStripMenuItem.Click
        Dim frm As New generateRQ()
        frm.ShowDialog()
    End Sub

#End Region

#Region "OCR"

    Private ocr As Tesseract = Nothing
    Private ReadOnly tessDataPath As String = Path.Combine(Application.StartupPath, "Data Files", "tessdata")
    Private ReadOnly language As String = "eng"

    Private Sub OpticalCharacterRecognizerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpticalCharacterRecognizerToolStripMenuItem.Click
        If imgInput Is Nothing Then
            MessageBox.Show("No image selected. Please load an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim extractedText As String = PerformOcr(DirectCast(pbInput.Image, Bitmap))

        If String.IsNullOrWhiteSpace(extractedText) Then
            MessageBox.Show("No Text Detected from the Image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("Data: " & vbCrLf & extractedText, "Text Detected", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Function PerformOcr(ByVal bitmap As Bitmap) As String
        Try
            If ocr Is Nothing Then
                ocr = New Tesseract(tessDataPath, language, OcrEngineMode.TesseractLstmCombined)
            End If

            Using mat As Mat = bitmap.ToMat()
                Using imageOCR As Image(Of Bgr, Byte) = mat.ToImage(Of Bgr, Byte)()
                    ocr.SetImage(imageOCR)
                    Return ocr.GetUTF8Text().Trim()
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("OCR processing failed: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End Try

    End Function

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If ocr IsNot Nothing Then
            ocr.Dispose()
            ocr = Nothing
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IronBarCode.License.LicenseKey = "IRONSUITE.KUSHALGUPTA21.GNU.AC.IN.29676-912EAC22E8-DW6ASZF-TTQ6KQZWIN4G-AU2TKT56QXER-5N62AFQJT4JA-EN6M4BAZQLIM-OUNG663BNYV6-WH6BLYW63NRN-3PDE6Z-TKN46DBQC76PEA-DEPLOYMENT.TRIAL-JVGUJE.TRIAL.EXPIRES.06.JUN.2025"
    End Sub

#End Region

End Class
