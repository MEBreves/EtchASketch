<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EtchASketchForm
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
        Me.components = New System.ComponentModel.Container()
        Me.SelectColorButton = New System.Windows.Forms.Button()
        Me.DisplayPictureBox = New System.Windows.Forms.PictureBox()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrawWaveformsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrawWaveformsButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ColorBox1 = New System.Windows.Forms.PictureBox()
        Me.ColorBox2 = New System.Windows.Forms.PictureBox()
        Me.ColorBox3 = New System.Windows.Forms.PictureBox()
        Me.ColorBox6 = New System.Windows.Forms.PictureBox()
        Me.ColorBox5 = New System.Windows.Forms.PictureBox()
        Me.ColorBox4 = New System.Windows.Forms.PictureBox()
        Me.ColorBox9 = New System.Windows.Forms.PictureBox()
        Me.ColorBox8 = New System.Windows.Forms.PictureBox()
        Me.ColorBox7 = New System.Windows.Forms.PictureBox()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.ThicknessSlider = New System.Windows.Forms.TrackBar()
        Me.ThicknessLabel = New System.Windows.Forms.Label()
        Me.ThicknessValueLabel = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BackgroundColorContextToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenColorContextToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrawWaveformsContextToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearDrawingContextToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DisplayPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        CType(Me.ColorBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ThicknessSlider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SelectColorButton
        '
        Me.SelectColorButton.Location = New System.Drawing.Point(1571, 58)
        Me.SelectColorButton.Name = "SelectColorButton"
        Me.SelectColorButton.Size = New System.Drawing.Size(220, 46)
        Me.SelectColorButton.TabIndex = 0
        Me.SelectColorButton.Text = "&Select Color"
        Me.SelectColorButton.UseVisualStyleBackColor = True
        '
        'DisplayPictureBox
        '
        Me.DisplayPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DisplayPictureBox.Location = New System.Drawing.Point(12, 56)
        Me.DisplayPictureBox.Name = "DisplayPictureBox"
        Me.DisplayPictureBox.Size = New System.Drawing.Size(1539, 820)
        Me.DisplayPictureBox.TabIndex = 1
        Me.DisplayPictureBox.TabStop = False
        '
        'MenuStrip
        '
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1800, 42)
        Me.MenuStrip.TabIndex = 2
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(71, 38)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(359, 44)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectColorToolStripMenuItem, Me.DrawWaveformsToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(74, 38)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'SelectColorToolStripMenuItem
        '
        Me.SelectColorToolStripMenuItem.Name = "SelectColorToolStripMenuItem"
        Me.SelectColorToolStripMenuItem.Size = New System.Drawing.Size(359, 44)
        Me.SelectColorToolStripMenuItem.Text = "&Select Color"
        '
        'DrawWaveformsToolStripMenuItem
        '
        Me.DrawWaveformsToolStripMenuItem.Name = "DrawWaveformsToolStripMenuItem"
        Me.DrawWaveformsToolStripMenuItem.Size = New System.Drawing.Size(359, 44)
        Me.DrawWaveformsToolStripMenuItem.Text = "&Draw Waveforms"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(359, 44)
        Me.ClearToolStripMenuItem.Text = "&Clear"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(84, 38)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(359, 44)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'DrawWaveformsButton
        '
        Me.DrawWaveformsButton.Location = New System.Drawing.Point(1571, 540)
        Me.DrawWaveformsButton.Name = "DrawWaveformsButton"
        Me.DrawWaveformsButton.Size = New System.Drawing.Size(220, 46)
        Me.DrawWaveformsButton.TabIndex = 1
        Me.DrawWaveformsButton.Text = "&Draw Waveforms"
        Me.DrawWaveformsButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(1571, 830)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(220, 46)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(1571, 608)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(220, 46)
        Me.ClearButton.TabIndex = 2
        Me.ClearButton.Text = "&Clear Box"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ColorBox1
        '
        Me.ColorBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ColorBox1.Location = New System.Drawing.Point(1571, 120)
        Me.ColorBox1.Name = "ColorBox1"
        Me.ColorBox1.Size = New System.Drawing.Size(61, 56)
        Me.ColorBox1.TabIndex = 6
        Me.ColorBox1.TabStop = False
        '
        'ColorBox2
        '
        Me.ColorBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ColorBox2.Location = New System.Drawing.Point(1651, 120)
        Me.ColorBox2.Name = "ColorBox2"
        Me.ColorBox2.Size = New System.Drawing.Size(61, 56)
        Me.ColorBox2.TabIndex = 7
        Me.ColorBox2.TabStop = False
        '
        'ColorBox3
        '
        Me.ColorBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ColorBox3.Location = New System.Drawing.Point(1730, 120)
        Me.ColorBox3.Name = "ColorBox3"
        Me.ColorBox3.Size = New System.Drawing.Size(61, 56)
        Me.ColorBox3.TabIndex = 8
        Me.ColorBox3.TabStop = False
        '
        'ColorBox6
        '
        Me.ColorBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ColorBox6.Location = New System.Drawing.Point(1730, 199)
        Me.ColorBox6.Name = "ColorBox6"
        Me.ColorBox6.Size = New System.Drawing.Size(61, 56)
        Me.ColorBox6.TabIndex = 11
        Me.ColorBox6.TabStop = False
        '
        'ColorBox5
        '
        Me.ColorBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ColorBox5.Location = New System.Drawing.Point(1651, 199)
        Me.ColorBox5.Name = "ColorBox5"
        Me.ColorBox5.Size = New System.Drawing.Size(61, 56)
        Me.ColorBox5.TabIndex = 10
        Me.ColorBox5.TabStop = False
        '
        'ColorBox4
        '
        Me.ColorBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ColorBox4.Location = New System.Drawing.Point(1571, 199)
        Me.ColorBox4.Name = "ColorBox4"
        Me.ColorBox4.Size = New System.Drawing.Size(61, 56)
        Me.ColorBox4.TabIndex = 9
        Me.ColorBox4.TabStop = False
        '
        'ColorBox9
        '
        Me.ColorBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ColorBox9.Location = New System.Drawing.Point(1730, 279)
        Me.ColorBox9.Name = "ColorBox9"
        Me.ColorBox9.Size = New System.Drawing.Size(61, 56)
        Me.ColorBox9.TabIndex = 14
        Me.ColorBox9.TabStop = False
        '
        'ColorBox8
        '
        Me.ColorBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ColorBox8.Location = New System.Drawing.Point(1651, 279)
        Me.ColorBox8.Name = "ColorBox8"
        Me.ColorBox8.Size = New System.Drawing.Size(61, 56)
        Me.ColorBox8.TabIndex = 13
        Me.ColorBox8.TabStop = False
        '
        'ColorBox7
        '
        Me.ColorBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ColorBox7.Location = New System.Drawing.Point(1571, 279)
        Me.ColorBox7.Name = "ColorBox7"
        Me.ColorBox7.Size = New System.Drawing.Size(61, 56)
        Me.ColorBox7.TabIndex = 12
        Me.ColorBox7.TabStop = False
        '
        'ThicknessSlider
        '
        Me.ThicknessSlider.Location = New System.Drawing.Point(1571, 403)
        Me.ThicknessSlider.Name = "ThicknessSlider"
        Me.ThicknessSlider.Size = New System.Drawing.Size(220, 90)
        Me.ThicknessSlider.TabIndex = 15
        Me.ThicknessSlider.TabStop = False
        '
        'ThicknessLabel
        '
        Me.ThicknessLabel.AutoSize = True
        Me.ThicknessLabel.Location = New System.Drawing.Point(1571, 368)
        Me.ThicknessLabel.Name = "ThicknessLabel"
        Me.ThicknessLabel.Size = New System.Drawing.Size(168, 32)
        Me.ThicknessLabel.TabIndex = 16
        Me.ThicknessLabel.Text = "Line Thickness"
        '
        'ThicknessValueLabel
        '
        Me.ThicknessValueLabel.Location = New System.Drawing.Point(1741, 368)
        Me.ThicknessValueLabel.Name = "ThicknessValueLabel"
        Me.ThicknessValueLabel.Size = New System.Drawing.Size(50, 32)
        Me.ThicknessValueLabel.TabIndex = 17
        Me.ThicknessValueLabel.Text = "0"
        Me.ThicknessValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackgroundColorContextToolStrip, Me.PenColorContextToolStrip, Me.DrawWaveformsContextToolStrip, Me.ClearDrawingContextToolStrip})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(321, 156)
        '
        'BackgroundColorContextToolStrip
        '
        Me.BackgroundColorContextToolStrip.Name = "BackgroundColorContextToolStrip"
        Me.BackgroundColorContextToolStrip.Size = New System.Drawing.Size(320, 38)
        Me.BackgroundColorContextToolStrip.Text = "Set Background Color"
        '
        'PenColorContextToolStrip
        '
        Me.PenColorContextToolStrip.Name = "PenColorContextToolStrip"
        Me.PenColorContextToolStrip.Size = New System.Drawing.Size(320, 38)
        Me.PenColorContextToolStrip.Text = "Set Pen Color"
        '
        'DrawWaveformsContextToolStrip
        '
        Me.DrawWaveformsContextToolStrip.Name = "DrawWaveformsContextToolStrip"
        Me.DrawWaveformsContextToolStrip.Size = New System.Drawing.Size(320, 38)
        Me.DrawWaveformsContextToolStrip.Text = "Draw Waveforms"
        '
        'ClearDrawingContextToolStrip
        '
        Me.ClearDrawingContextToolStrip.Name = "ClearDrawingContextToolStrip"
        Me.ClearDrawingContextToolStrip.Size = New System.Drawing.Size(320, 38)
        Me.ClearDrawingContextToolStrip.Text = "Clear Drawing"
        '
        'EtchASketchForm
        '
        Me.AcceptButton = Me.DrawWaveformsButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.CancelButton = Me.ClearButton
        Me.ClientSize = New System.Drawing.Size(1810, 903)
        Me.Controls.Add(Me.ThicknessValueLabel)
        Me.Controls.Add(Me.ThicknessLabel)
        Me.Controls.Add(Me.ThicknessSlider)
        Me.Controls.Add(Me.ColorBox9)
        Me.Controls.Add(Me.ColorBox8)
        Me.Controls.Add(Me.ColorBox7)
        Me.Controls.Add(Me.ColorBox6)
        Me.Controls.Add(Me.ColorBox5)
        Me.Controls.Add(Me.ColorBox4)
        Me.Controls.Add(Me.ColorBox3)
        Me.Controls.Add(Me.ColorBox2)
        Me.Controls.Add(Me.ColorBox1)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.DrawWaveformsButton)
        Me.Controls.Add(Me.DisplayPictureBox)
        Me.Controls.Add(Me.SelectColorButton)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "EtchASketchForm"
        Me.Padding = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Etch-A-Sketch"
        CType(Me.DisplayPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        CType(Me.ColorBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ThicknessSlider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SelectColorButton As Button
    Friend WithEvents DisplayPictureBox As PictureBox
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DrawWaveformsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DrawWaveformsButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ColorBox1 As PictureBox
    Friend WithEvents ColorBox2 As PictureBox
    Friend WithEvents ColorBox3 As PictureBox
    Friend WithEvents ColorBox6 As PictureBox
    Friend WithEvents ColorBox5 As PictureBox
    Friend WithEvents ColorBox4 As PictureBox
    Friend WithEvents ColorBox9 As PictureBox
    Friend WithEvents ColorBox8 As PictureBox
    Friend WithEvents ColorBox7 As PictureBox
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents ThicknessSlider As TrackBar
    Friend WithEvents ThicknessLabel As Label
    Friend WithEvents ThicknessValueLabel As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents BackgroundColorContextToolStrip As ToolStripMenuItem
    Friend WithEvents PenColorContextToolStrip As ToolStripMenuItem
    Friend WithEvents ClearDrawingContextToolStrip As ToolStripMenuItem
    Friend WithEvents DrawWaveformsContextToolStrip As ToolStripMenuItem
End Class
