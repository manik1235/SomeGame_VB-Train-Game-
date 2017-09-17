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
        Me.ToySettingsPanel = New System.Windows.Forms.Panel()
        Me.GreenToySettingsGroupBox = New System.Windows.Forms.GroupBox()
        Me.GreenToyVSpeedNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.GreenToyEnabledCheckBox = New System.Windows.Forms.CheckBox()
        Me.GreenToyHSpeedNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.ToySettingsGroupBox = New System.Windows.Forms.GroupBox()
        Me.ToyVSpeedNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.ToyEnabledCheckBox = New System.Windows.Forms.CheckBox()
        Me.ToyHSpeedNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.PlayAreaPanel = New System.Windows.Forms.Panel()
        Me.GreenToyPanel = New System.Windows.Forms.Panel()
        Me.GreenToyPictureBox = New System.Windows.Forms.PictureBox()
        Me.ToyPanel = New System.Windows.Forms.Panel()
        Me.ToyPictureBox = New System.Windows.Forms.PictureBox()
        Me.TickTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ToySettingsPanel.SuspendLayout()
        Me.GreenToySettingsGroupBox.SuspendLayout()
        CType(Me.GreenToyVSpeedNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GreenToyHSpeedNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToySettingsGroupBox.SuspendLayout()
        CType(Me.ToyVSpeedNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToyHSpeedNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PlayAreaPanel.SuspendLayout()
        Me.GreenToyPanel.SuspendLayout()
        CType(Me.GreenToyPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToyPanel.SuspendLayout()
        CType(Me.ToyPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'ToySettingsPanel
        '
        Me.ToySettingsPanel.Controls.Add(Me.GreenToySettingsGroupBox)
        Me.ToySettingsPanel.Controls.Add(Me.ToySettingsGroupBox)
        Me.ToySettingsPanel.Location = New System.Drawing.Point(12, 21)
        Me.ToySettingsPanel.Name = "ToySettingsPanel"
        Me.ToySettingsPanel.Size = New System.Drawing.Size(142, 238)
        Me.ToySettingsPanel.TabIndex = 0
        '
        'GreenToySettingsGroupBox
        '
        Me.GreenToySettingsGroupBox.Controls.Add(Me.GreenToyVSpeedNumericUpDown)
        Me.GreenToySettingsGroupBox.Controls.Add(Me.GreenToyEnabledCheckBox)
        Me.GreenToySettingsGroupBox.Controls.Add(Me.GreenToyHSpeedNumericUpDown)
        Me.GreenToySettingsGroupBox.Location = New System.Drawing.Point(21, 116)
        Me.GreenToySettingsGroupBox.Name = "GreenToySettingsGroupBox"
        Me.GreenToySettingsGroupBox.Size = New System.Drawing.Size(118, 97)
        Me.GreenToySettingsGroupBox.TabIndex = 1
        Me.GreenToySettingsGroupBox.TabStop = False
        Me.GreenToySettingsGroupBox.Text = "Green Train Car"
        '
        'GreenToyVSpeedNumericUpDown
        '
        Me.GreenToyVSpeedNumericUpDown.Location = New System.Drawing.Point(12, 44)
        Me.GreenToyVSpeedNumericUpDown.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.GreenToyVSpeedNumericUpDown.Minimum = New Decimal(New Integer() {20, 0, 0, -2147483648})
        Me.GreenToyVSpeedNumericUpDown.Name = "GreenToyVSpeedNumericUpDown"
        Me.GreenToyVSpeedNumericUpDown.Size = New System.Drawing.Size(105, 20)
        Me.GreenToyVSpeedNumericUpDown.TabIndex = 2
        '
        'GreenToyEnabledCheckBox
        '
        Me.GreenToyEnabledCheckBox.AutoSize = True
        Me.GreenToyEnabledCheckBox.Checked = True
        Me.GreenToyEnabledCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.GreenToyEnabledCheckBox.Location = New System.Drawing.Point(12, 70)
        Me.GreenToyEnabledCheckBox.Name = "GreenToyEnabledCheckBox"
        Me.GreenToyEnabledCheckBox.Size = New System.Drawing.Size(43, 17)
        Me.GreenToyEnabledCheckBox.TabIndex = 1
        Me.GreenToyEnabledCheckBox.Text = "Go!"
        Me.GreenToyEnabledCheckBox.UseVisualStyleBackColor = True
        '
        'GreenToyHSpeedNumericUpDown
        '
        Me.GreenToyHSpeedNumericUpDown.Location = New System.Drawing.Point(12, 21)
        Me.GreenToyHSpeedNumericUpDown.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.GreenToyHSpeedNumericUpDown.Minimum = New Decimal(New Integer() {20, 0, 0, -2147483648})
        Me.GreenToyHSpeedNumericUpDown.Name = "GreenToyHSpeedNumericUpDown"
        Me.GreenToyHSpeedNumericUpDown.Size = New System.Drawing.Size(105, 20)
        Me.GreenToyHSpeedNumericUpDown.TabIndex = 0
        '
        'ToySettingsGroupBox
        '
        Me.ToySettingsGroupBox.Controls.Add(Me.ToyVSpeedNumericUpDown)
        Me.ToySettingsGroupBox.Controls.Add(Me.ToyEnabledCheckBox)
        Me.ToySettingsGroupBox.Controls.Add(Me.ToyHSpeedNumericUpDown)
        Me.ToySettingsGroupBox.Location = New System.Drawing.Point(21, 13)
        Me.ToySettingsGroupBox.Name = "ToySettingsGroupBox"
        Me.ToySettingsGroupBox.Size = New System.Drawing.Size(118, 97)
        Me.ToySettingsGroupBox.TabIndex = 0
        Me.ToySettingsGroupBox.TabStop = False
        Me.ToySettingsGroupBox.Text = "Purple Train Car"
        '
        'ToyVSpeedNumericUpDown
        '
        Me.ToyVSpeedNumericUpDown.Location = New System.Drawing.Point(12, 44)
        Me.ToyVSpeedNumericUpDown.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.ToyVSpeedNumericUpDown.Minimum = New Decimal(New Integer() {20, 0, 0, -2147483648})
        Me.ToyVSpeedNumericUpDown.Name = "ToyVSpeedNumericUpDown"
        Me.ToyVSpeedNumericUpDown.Size = New System.Drawing.Size(105, 20)
        Me.ToyVSpeedNumericUpDown.TabIndex = 2
        '
        'ToyEnabledCheckBox
        '
        Me.ToyEnabledCheckBox.AutoSize = True
        Me.ToyEnabledCheckBox.Checked = True
        Me.ToyEnabledCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToyEnabledCheckBox.Location = New System.Drawing.Point(12, 70)
        Me.ToyEnabledCheckBox.Name = "ToyEnabledCheckBox"
        Me.ToyEnabledCheckBox.Size = New System.Drawing.Size(43, 17)
        Me.ToyEnabledCheckBox.TabIndex = 1
        Me.ToyEnabledCheckBox.Text = "Go!"
        Me.ToyEnabledCheckBox.UseVisualStyleBackColor = True
        '
        'ToyHSpeedNumericUpDown
        '
        Me.ToyHSpeedNumericUpDown.Location = New System.Drawing.Point(12, 21)
        Me.ToyHSpeedNumericUpDown.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.ToyHSpeedNumericUpDown.Minimum = New Decimal(New Integer() {20, 0, 0, -2147483648})
        Me.ToyHSpeedNumericUpDown.Name = "ToyHSpeedNumericUpDown"
        Me.ToyHSpeedNumericUpDown.Size = New System.Drawing.Size(105, 20)
        Me.ToyHSpeedNumericUpDown.TabIndex = 0
        '
        'PlayAreaPanel
        '
        Me.PlayAreaPanel.Controls.Add(Me.GreenToyPanel)
        Me.PlayAreaPanel.Controls.Add(Me.ToyPanel)
        Me.PlayAreaPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PlayAreaPanel.Location = New System.Drawing.Point(0, 0)
        Me.PlayAreaPanel.Name = "PlayAreaPanel"
        Me.PlayAreaPanel.Size = New System.Drawing.Size(405, 334)
        Me.PlayAreaPanel.TabIndex = 0
        '
        'GreenToyPanel
        '
        Me.GreenToyPanel.Controls.Add(Me.GreenToyPictureBox)
        Me.GreenToyPanel.Location = New System.Drawing.Point(22, 75)
        Me.GreenToyPanel.Name = "GreenToyPanel"
        Me.GreenToyPanel.Size = New System.Drawing.Size(66, 35)
        Me.GreenToyPanel.TabIndex = 1
        '
        'GreenToyPictureBox
        '
        Me.GreenToyPictureBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GreenToyPictureBox.Image = Global.SomeGame_VB.My.Resources.Resources.Train_Car_Cattle_Car_Trimmed_
        Me.GreenToyPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.GreenToyPictureBox.Name = "GreenToyPictureBox"
        Me.GreenToyPictureBox.Size = New System.Drawing.Size(66, 35)
        Me.GreenToyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GreenToyPictureBox.TabIndex = 0
        Me.GreenToyPictureBox.TabStop = False
        '
        'ToyPanel
        '
        Me.ToyPanel.Controls.Add(Me.ToyPictureBox)
        Me.ToyPanel.Location = New System.Drawing.Point(119, 75)
        Me.ToyPanel.Name = "ToyPanel"
        Me.ToyPanel.Size = New System.Drawing.Size(65, 35)
        Me.ToyPanel.TabIndex = 0
        '
        'ToyPictureBox
        '
        Me.ToyPictureBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToyPictureBox.Image = Global.SomeGame_VB.My.Resources.Resources.Train_Car_Box_Car_Trimmed_Blue
        Me.ToyPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.ToyPictureBox.Name = "ToyPictureBox"
        Me.ToyPictureBox.Size = New System.Drawing.Size(65, 35)
        Me.ToyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ToyPictureBox.TabIndex = 0
        Me.ToyPictureBox.TabStop = False
        '
        'TickTimer
        '
        Me.TickTimer.Enabled = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 334)
        Me.Controls.Add(Me.SplitContainer1)
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ToySettingsPanel.ResumeLayout(False)
        Me.GreenToySettingsGroupBox.ResumeLayout(False)
        Me.GreenToySettingsGroupBox.PerformLayout()
        CType(Me.GreenToyVSpeedNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GreenToyHSpeedNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToySettingsGroupBox.ResumeLayout(False)
        Me.ToySettingsGroupBox.PerformLayout()
        CType(Me.ToyVSpeedNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToyHSpeedNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PlayAreaPanel.ResumeLayout(False)
        Me.GreenToyPanel.ResumeLayout(False)
        CType(Me.GreenToyPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToyPanel.ResumeLayout(False)
        CType(Me.ToyPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents PlayAreaPanel As Panel
    Friend WithEvents ToyPanel As Panel
    Friend WithEvents ToyPictureBox As PictureBox
    Friend WithEvents TickTimer As Timer
    Friend WithEvents ToySettingsPanel As Panel
    Friend WithEvents ToySettingsGroupBox As GroupBox
    Friend WithEvents ToyHSpeedNumericUpDown As NumericUpDown
    Friend WithEvents ToyEnabledCheckBox As CheckBox
    Friend WithEvents ToyVSpeedNumericUpDown As NumericUpDown
    Friend WithEvents GreenToySettingsGroupBox As GroupBox
    Friend WithEvents GreenToyVSpeedNumericUpDown As NumericUpDown
    Friend WithEvents GreenToyEnabledCheckBox As CheckBox
    Friend WithEvents GreenToyHSpeedNumericUpDown As NumericUpDown
    Friend WithEvents GreenToyPanel As Panel
    Friend WithEvents GreenToyPictureBox As PictureBox
End Class
