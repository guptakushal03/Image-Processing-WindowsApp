<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formBrightnessContrast
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblMaxContrast = New System.Windows.Forms.Label()
        Me.lblCurrentContrast = New System.Windows.Forms.Label()
        Me.lblMinContrast = New System.Windows.Forms.Label()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblMaxBrightness = New System.Windows.Forms.Label()
        Me.lblCurrentBrightness = New System.Windows.Forms.Label()
        Me.lblMinBrightness = New System.Windows.Forms.Label()
        Me.TrackBar2 = New System.Windows.Forms.TrackBar()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 27)
        Me.Panel1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblMaxContrast)
        Me.GroupBox1.Controls.Add(Me.lblCurrentContrast)
        Me.GroupBox1.Controls.Add(Me.lblMinContrast)
        Me.GroupBox1.Controls.Add(Me.TrackBar1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(0, 350)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(800, 100)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Contrast"
        '
        'lblMaxContrast
        '
        Me.lblMaxContrast.AutoSize = True
        Me.lblMaxContrast.Location = New System.Drawing.Point(747, 62)
        Me.lblMaxContrast.Name = "lblMaxContrast"
        Me.lblMaxContrast.Size = New System.Drawing.Size(41, 15)
        Me.lblMaxContrast.TabIndex = 3
        Me.lblMaxContrast.Text = "Label3"
        '
        'lblCurrentContrast
        '
        Me.lblCurrentContrast.AutoSize = True
        Me.lblCurrentContrast.Location = New System.Drawing.Point(378, 62)
        Me.lblCurrentContrast.Name = "lblCurrentContrast"
        Me.lblCurrentContrast.Size = New System.Drawing.Size(41, 15)
        Me.lblCurrentContrast.TabIndex = 2
        Me.lblCurrentContrast.Text = "Label2"
        '
        'lblMinContrast
        '
        Me.lblMinContrast.AutoSize = True
        Me.lblMinContrast.Location = New System.Drawing.Point(13, 62)
        Me.lblMinContrast.Name = "lblMinContrast"
        Me.lblMinContrast.Size = New System.Drawing.Size(41, 15)
        Me.lblMinContrast.TabIndex = 1
        Me.lblMinContrast.Text = "Label1"
        '
        'TrackBar1
        '
        Me.TrackBar1.AutoSize = False
        Me.TrackBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TrackBar1.Location = New System.Drawing.Point(3, 19)
        Me.TrackBar1.Maximum = 500
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(794, 36)
        Me.TrackBar1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblMaxBrightness)
        Me.GroupBox2.Controls.Add(Me.lblCurrentBrightness)
        Me.GroupBox2.Controls.Add(Me.lblMinBrightness)
        Me.GroupBox2.Controls.Add(Me.TrackBar2)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox2.Location = New System.Drawing.Point(711, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(89, 323)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Brightness"
        '
        'lblMaxBrightness
        '
        Me.lblMaxBrightness.AutoSize = True
        Me.lblMaxBrightness.Location = New System.Drawing.Point(36, 28)
        Me.lblMaxBrightness.Name = "lblMaxBrightness"
        Me.lblMaxBrightness.Size = New System.Drawing.Size(41, 15)
        Me.lblMaxBrightness.TabIndex = 6
        Me.lblMaxBrightness.Text = "Label6"
        '
        'lblCurrentBrightness
        '
        Me.lblCurrentBrightness.AutoSize = True
        Me.lblCurrentBrightness.Location = New System.Drawing.Point(36, 157)
        Me.lblCurrentBrightness.Name = "lblCurrentBrightness"
        Me.lblCurrentBrightness.Size = New System.Drawing.Size(41, 15)
        Me.lblCurrentBrightness.TabIndex = 5
        Me.lblCurrentBrightness.Text = "Label5"
        '
        'lblMinBrightness
        '
        Me.lblMinBrightness.AutoSize = True
        Me.lblMinBrightness.Location = New System.Drawing.Point(36, 295)
        Me.lblMinBrightness.Name = "lblMinBrightness"
        Me.lblMinBrightness.Size = New System.Drawing.Size(41, 15)
        Me.lblMinBrightness.TabIndex = 4
        Me.lblMinBrightness.Text = "Label4"
        '
        'TrackBar2
        '
        Me.TrackBar2.AutoSize = False
        Me.TrackBar2.Dock = System.Windows.Forms.DockStyle.Left
        Me.TrackBar2.Location = New System.Drawing.Point(3, 19)
        Me.TrackBar2.Maximum = 100
        Me.TrackBar2.Name = "TrackBar2"
        Me.TrackBar2.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TrackBar2.Size = New System.Drawing.Size(39, 301)
        Me.TrackBar2.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 27)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(711, 323)
        Me.Panel2.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(711, 323)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'formBrightnessContrast
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "formBrightnessContrast"
        Me.Text = "formBrightnessContrast"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents TrackBar2 As TrackBar
    Friend WithEvents lblMaxContrast As Label
    Friend WithEvents lblCurrentContrast As Label
    Friend WithEvents lblMinContrast As Label
    Friend WithEvents lblMaxBrightness As Label
    Friend WithEvents lblCurrentBrightness As Label
    Friend WithEvents lblMinBrightness As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
