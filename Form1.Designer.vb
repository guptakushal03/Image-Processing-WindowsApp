<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.FaceLandmarkDetectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EyesDetectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FaceDetectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlackHatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TopHatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GradiantToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClosingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpeningToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DilationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ErosionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BrightnessAndContrastToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContoursToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BinarizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveOutputToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseOutputImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MorphologicalProcessingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProjectsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Covid19TestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QRCodeGeneratorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QRCodeReaderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpticalCharacterRecognizerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pbOutput = New System.Windows.Forms.PictureBox()
        Me.pbInput = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.MenuStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.pbOutput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'FaceLandmarkDetectionToolStripMenuItem
        '
        Me.FaceLandmarkDetectionToolStripMenuItem.Name = "FaceLandmarkDetectionToolStripMenuItem"
        Me.FaceLandmarkDetectionToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.FaceLandmarkDetectionToolStripMenuItem.Text = "Face Landmark Detection"
        '
        'EyesDetectionToolStripMenuItem
        '
        Me.EyesDetectionToolStripMenuItem.Name = "EyesDetectionToolStripMenuItem"
        Me.EyesDetectionToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.EyesDetectionToolStripMenuItem.Text = "Eyes Detection"
        '
        'FaceDetectionToolStripMenuItem
        '
        Me.FaceDetectionToolStripMenuItem.Name = "FaceDetectionToolStripMenuItem"
        Me.FaceDetectionToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.FaceDetectionToolStripMenuItem.Text = "Face Detection"
        '
        'DetectionToolStripMenuItem
        '
        Me.DetectionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FaceDetectionToolStripMenuItem, Me.EyesDetectionToolStripMenuItem, Me.FaceLandmarkDetectionToolStripMenuItem})
        Me.DetectionToolStripMenuItem.Name = "DetectionToolStripMenuItem"
        Me.DetectionToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.DetectionToolStripMenuItem.Text = "Detection"
        '
        'BlackHatToolStripMenuItem
        '
        Me.BlackHatToolStripMenuItem.Name = "BlackHatToolStripMenuItem"
        Me.BlackHatToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.BlackHatToolStripMenuItem.Text = "Black Hat"
        '
        'TopHatToolStripMenuItem
        '
        Me.TopHatToolStripMenuItem.Name = "TopHatToolStripMenuItem"
        Me.TopHatToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.TopHatToolStripMenuItem.Text = "Top Hat"
        '
        'GradiantToolStripMenuItem
        '
        Me.GradiantToolStripMenuItem.Name = "GradiantToolStripMenuItem"
        Me.GradiantToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.GradiantToolStripMenuItem.Text = "Gradient"
        '
        'ClosingToolStripMenuItem
        '
        Me.ClosingToolStripMenuItem.Name = "ClosingToolStripMenuItem"
        Me.ClosingToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.ClosingToolStripMenuItem.Text = "Closing"
        '
        'OpeningToolStripMenuItem
        '
        Me.OpeningToolStripMenuItem.Name = "OpeningToolStripMenuItem"
        Me.OpeningToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.OpeningToolStripMenuItem.Text = "Opening"
        '
        'DilationToolStripMenuItem
        '
        Me.DilationToolStripMenuItem.Name = "DilationToolStripMenuItem"
        Me.DilationToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.DilationToolStripMenuItem.Text = "Dilation"
        '
        'ErosionToolStripMenuItem
        '
        Me.ErosionToolStripMenuItem.Name = "ErosionToolStripMenuItem"
        Me.ErosionToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.ErosionToolStripMenuItem.Text = "Erosion"
        '
        'BrightnessAndContrastToolStripMenuItem
        '
        Me.BrightnessAndContrastToolStripMenuItem.Name = "BrightnessAndContrastToolStripMenuItem"
        Me.BrightnessAndContrastToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.BrightnessAndContrastToolStripMenuItem.Text = "Brightness And Contrast"
        '
        'ContoursToolStripMenuItem
        '
        Me.ContoursToolStripMenuItem.Name = "ContoursToolStripMenuItem"
        Me.ContoursToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.ContoursToolStripMenuItem.Text = "Contours"
        '
        'BinarizeToolStripMenuItem
        '
        Me.BinarizeToolStripMenuItem.Name = "BinarizeToolStripMenuItem"
        Me.BinarizeToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.BinarizeToolStripMenuItem.Text = "Binarize"
        '
        'GrayToolStripMenuItem
        '
        Me.GrayToolStripMenuItem.Name = "GrayToolStripMenuItem"
        Me.GrayToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.GrayToolStripMenuItem.Text = "Gray"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GrayToolStripMenuItem, Me.BinarizeToolStripMenuItem, Me.ContoursToolStripMenuItem, Me.BrightnessAndContrastToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'SaveOutputToolStripMenuItem
        '
        Me.SaveOutputToolStripMenuItem.Name = "SaveOutputToolStripMenuItem"
        Me.SaveOutputToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SaveOutputToolStripMenuItem.Text = "Save Output"
        '
        'CloseOutputImageToolStripMenuItem
        '
        Me.CloseOutputImageToolStripMenuItem.Name = "CloseOutputImageToolStripMenuItem"
        Me.CloseOutputImageToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CloseOutputImageToolStripMenuItem.Text = "Close Output Image"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.CloseToolStripMenuItem, Me.CloseOutputImageToolStripMenuItem, Me.SaveOutputToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'MorphologicalProcessingToolStripMenuItem
        '
        Me.MorphologicalProcessingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ErosionToolStripMenuItem, Me.DilationToolStripMenuItem, Me.OpeningToolStripMenuItem, Me.ClosingToolStripMenuItem, Me.GradiantToolStripMenuItem, Me.TopHatToolStripMenuItem, Me.BlackHatToolStripMenuItem})
        Me.MorphologicalProcessingToolStripMenuItem.Name = "MorphologicalProcessingToolStripMenuItem"
        Me.MorphologicalProcessingToolStripMenuItem.Size = New System.Drawing.Size(157, 20)
        Me.MorphologicalProcessingToolStripMenuItem.Text = "Morphological Processing"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.MorphologicalProcessingToolStripMenuItem, Me.DetectionToolStripMenuItem, Me.ProjectsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProjectsToolStripMenuItem
        '
        Me.ProjectsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Covid19TestToolStripMenuItem, Me.QRCodeGeneratorToolStripMenuItem, Me.QRCodeReaderToolStripMenuItem, Me.OpticalCharacterRecognizerToolStripMenuItem})
        Me.ProjectsToolStripMenuItem.Name = "ProjectsToolStripMenuItem"
        Me.ProjectsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ProjectsToolStripMenuItem.Text = "Projects"
        '
        'Covid19TestToolStripMenuItem
        '
        Me.Covid19TestToolStripMenuItem.Name = "Covid19TestToolStripMenuItem"
        Me.Covid19TestToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.Covid19TestToolStripMenuItem.Text = "Covid 19 Test"
        '
        'QRCodeGeneratorToolStripMenuItem
        '
        Me.QRCodeGeneratorToolStripMenuItem.Name = "QRCodeGeneratorToolStripMenuItem"
        Me.QRCodeGeneratorToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.QRCodeGeneratorToolStripMenuItem.Text = "QR Code Generator"
        '
        'QRCodeReaderToolStripMenuItem
        '
        Me.QRCodeReaderToolStripMenuItem.Name = "QRCodeReaderToolStripMenuItem"
        Me.QRCodeReaderToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.QRCodeReaderToolStripMenuItem.Text = "QR Code Reader"
        '
        'OpticalCharacterRecognizerToolStripMenuItem
        '
        Me.OpticalCharacterRecognizerToolStripMenuItem.Name = "OpticalCharacterRecognizerToolStripMenuItem"
        Me.OpticalCharacterRecognizerToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.OpticalCharacterRecognizerToolStripMenuItem.Text = "Optical Character Recognition"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.875!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.125!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 24)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 426)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pbOutput)
        Me.Panel1.Controls.Add(Me.pbInput)
        Me.Panel1.Location = New System.Drawing.Point(178, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(619, 420)
        Me.Panel1.TabIndex = 4
        '
        'pbOutput
        '
        Me.pbOutput.Location = New System.Drawing.Point(312, 0)
        Me.pbOutput.Margin = New System.Windows.Forms.Padding(8)
        Me.pbOutput.Name = "pbOutput"
        Me.pbOutput.Size = New System.Drawing.Size(307, 420)
        Me.pbOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbOutput.TabIndex = 1
        Me.pbOutput.TabStop = False
        '
        'pbInput
        '
        Me.pbInput.Location = New System.Drawing.Point(0, 0)
        Me.pbInput.Margin = New System.Windows.Forms.Padding(8)
        Me.pbInput.Name = "pbInput"
        Me.pbInput.Size = New System.Drawing.Size(307, 420)
        Me.pbInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbInput.TabIndex = 0
        Me.pbInput.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(169, 420)
        Me.Panel2.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.TreeView1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(169, 299)
        Me.Panel3.TabIndex = 0
        '
        'TreeView1
        '
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(169, 299)
        Me.TreeView1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        Me.Text = "Image Processing Window"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.pbOutput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbInput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FaceLandmarkDetectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EyesDetectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FaceDetectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DetectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BlackHatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TopHatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GradiantToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClosingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpeningToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DilationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ErosionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BrightnessAndContrastToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContoursToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BinarizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GrayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveOutputToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseOutputImageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MorphologicalProcessingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ProjectsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Covid19TestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QRCodeGeneratorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QRCodeReaderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpticalCharacterRecognizerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pbOutput As PictureBox
    Friend WithEvents pbInput As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TreeView1 As TreeView
End Class
