<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.PlayAreaPanel = New System.Windows.Forms.Panel()
        Me.ToyPanel = New System.Windows.Forms.Panel()
        Me.TickTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ToyPictureBox = New System.Windows.Forms.PictureBox()
        Me.ToySettingsPanel = New System.Windows.Forms.Panel()
        Me.ToySettingsGroupBox = New System.Windows.Forms.GroupBox()
        Me.HSpeedNumericUpDown = New System.Windows.Forms.NumericUpDown()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.PlayAreaPanel.SuspendLayout()
        Me.ToyPanel.SuspendLayout()
        CType(Me.ToyPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToySettingsPanel.SuspendLayout()
        Me.ToySettingsGroupBox.SuspendLayout()
        CType(Me.HSpeedNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToySettingsPanel)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.PlayAreaPanel)
        Me.SplitContainer1.Size = New System.Drawing.Size(575, 334)
        Me.SplitContainer1.SplitterDistance = 166
        Me.SplitContainer1.TabIndex = 0
        '
        'PlayAreaPanel
        '
        Me.PlayAreaPanel.Controls.Add(Me.ToyPanel)
        Me.PlayAreaPanel.Location = New System.Drawing.Point(47, 78)
        Me.PlayAreaPanel.Name = "PlayAreaPanel"
        Me.PlayAreaPanel.Size = New System.Drawing.Size(316, 181)
        Me.PlayAreaPanel.TabIndex = 0
        '
        'ToyPanel
        '
        Me.ToyPanel.Controls.Add(Me.ToyPictureBox)
        Me.ToyPanel.Location = New System.Drawing.Point(119, 74)
        Me.ToyPanel.Name = "ToyPanel"
        Me.ToyPanel.Size = New System.Drawing.Size(59, 50)
        Me.ToyPanel.TabIndex = 0
        '
        'ToyPictureBox
        '
        Me.ToyPictureBox.Image = Global.SomeGame_VB.My.Resources.Resources.Train_Car_Box_Car_Trimmed_Blue
        Me.ToyPictureBox.Location = New System.Drawing.Point(13, 12)
        Me.ToyPictureBox.Name = "ToyPictureBox"
        Me.ToyPictureBox.Size = New System.Drawing.Size(45, 37)
        Me.ToyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ToyPictureBox.TabIndex = 0
        Me.ToyPictureBox.TabStop = False
        '
        'ToySettingsPanel
        '
        Me.ToySettingsPanel.Controls.Add(Me.ToySettingsGroupBox)
        Me.ToySettingsPanel.Location = New System.Drawing.Point(12, 21)
        Me.ToySettingsPanel.Name = "ToySettingsPanel"
        Me.ToySettingsPanel.Size = New System.Drawing.Size(142, 148)
        Me.ToySettingsPanel.TabIndex = 0
        '
        'ToySettingsGroupBox
        '
        Me.ToySettingsGroupBox.Controls.Add(Me.HSpeedNumericUpDown)
        Me.ToySettingsGroupBox.Location = New System.Drawing.Point(11, 13)
        Me.ToySettingsGroupBox.Name = "ToySettingsGroupBox"
        Me.ToySettingsGroupBox.Size = New System.Drawing.Size(118, 65)
        Me.ToySettingsGroupBox.TabIndex = 0
        Me.ToySettingsGroupBox.TabStop = False
        Me.ToySettingsGroupBox.Text = "Purple Train Car"
        '
        'HSpeedNumericUpDown
        '
        Me.HSpeedNumericUpDown.Location = New System.Drawing.Point(12, 21)
        Me.HSpeedNumericUpDown.Name = "HSpeedNumericUpDown"
        Me.HSpeedNumericUpDown.Size = New System.Drawing.Size(105, 20)
        Me.HSpeedNumericUpDown.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 334)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.PlayAreaPanel.ResumeLayout(False)
        Me.ToyPanel.ResumeLayout(False)
        CType(Me.ToyPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToySettingsPanel.ResumeLayout(False)
        Me.ToySettingsGroupBox.ResumeLayout(False)
        CType(Me.HSpeedNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents PlayAreaPanel As Panel
    Friend WithEvents ToyPanel As Panel
    Friend WithEvents ToyPictureBox As PictureBox
    Friend WithEvents TickTimer As Timer
    Friend WithEvents ToySettingsPanel As Panel
    Friend WithEvents ToySettingsGroupBox As GroupBox
    Friend WithEvents HSpeedNumericUpDown As NumericUpDown
End Class
