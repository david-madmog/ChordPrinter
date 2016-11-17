<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlaybackSettings
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbVolume = New System.Windows.Forms.TrackBar()
        Me.txtVolume = New System.Windows.Forms.TextBox()
        Me.tbChordSpeed = New System.Windows.Forms.TrackBar()
        Me.txtChordSpeed = New System.Windows.Forms.TextBox()
        Me.txtStrumSpeed = New System.Windows.Forms.TextBox()
        Me.tbStrumSpeed = New System.Windows.Forms.TrackBar()
        Me.Voice = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblSpeed = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.tbVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbChordSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbStrumSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(163, 256)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel1, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.tbVolume, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtVolume, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.tbChordSpeed, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtStrumSpeed, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.tbStrumSpeed, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Voice, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(298, 233)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Voice"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Strum interval"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 26)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Chord Speed" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(BPM)"
        '
        'tbVolume
        '
        Me.tbVolume.LargeChange = 10
        Me.tbVolume.Location = New System.Drawing.Point(80, 3)
        Me.tbVolume.Maximum = 127
        Me.tbVolume.Name = "tbVolume"
        Me.tbVolume.Size = New System.Drawing.Size(104, 45)
        Me.tbVolume.TabIndex = 2
        Me.tbVolume.TickFrequency = 10
        Me.tbVolume.Value = 127
        '
        'txtVolume
        '
        Me.txtVolume.Location = New System.Drawing.Point(190, 3)
        Me.txtVolume.Name = "txtVolume"
        Me.txtVolume.Size = New System.Drawing.Size(100, 20)
        Me.txtVolume.TabIndex = 3
        '
        'tbChordSpeed
        '
        Me.tbChordSpeed.LargeChange = 500
        Me.tbChordSpeed.Location = New System.Drawing.Point(80, 54)
        Me.tbChordSpeed.Maximum = 212
        Me.tbChordSpeed.Minimum = 13
        Me.tbChordSpeed.Name = "tbChordSpeed"
        Me.tbChordSpeed.Size = New System.Drawing.Size(104, 45)
        Me.tbChordSpeed.SmallChange = 100
        Me.tbChordSpeed.TabIndex = 4
        Me.tbChordSpeed.TickFrequency = 500
        Me.tbChordSpeed.Value = 13
        '
        'txtChordSpeed
        '
        Me.txtChordSpeed.Location = New System.Drawing.Point(3, 6)
        Me.txtChordSpeed.Name = "txtChordSpeed"
        Me.txtChordSpeed.Size = New System.Drawing.Size(100, 20)
        Me.txtChordSpeed.TabIndex = 5
        '
        'txtStrumSpeed
        '
        Me.txtStrumSpeed.Location = New System.Drawing.Point(190, 105)
        Me.txtStrumSpeed.Name = "txtStrumSpeed"
        Me.txtStrumSpeed.Size = New System.Drawing.Size(100, 20)
        Me.txtStrumSpeed.TabIndex = 7
        '
        'tbStrumSpeed
        '
        Me.tbStrumSpeed.LargeChange = 10
        Me.tbStrumSpeed.Location = New System.Drawing.Point(80, 105)
        Me.tbStrumSpeed.Maximum = 100
        Me.tbStrumSpeed.Name = "tbStrumSpeed"
        Me.tbStrumSpeed.Size = New System.Drawing.Size(104, 45)
        Me.tbStrumSpeed.TabIndex = 6
        Me.tbStrumSpeed.TickFrequency = 10
        '
        'Voice
        '
        Me.Voice.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TableLayoutPanel2.SetColumnSpan(Me.Voice, 2)
        Me.Voice.FormattingEnabled = True
        Me.Voice.Items.AddRange(New Object() {"AcousticGuitarNylon", "AcousticGuitarSteel", "ElectricGuitarJazz", "ElectricGuitarClean", "ElectricGuitarMuted", "OverdrivenGuitar", "DistortionGuitar", "GuitarHarmonics", "AcousticBass", "ElectricBassFinger", "ElectricBassPick", "FretlessBas", "SlapBass1", "SlapBass2", "SynthBass1", "SynthBass2"})
        Me.Voice.Location = New System.Drawing.Point(80, 182)
        Me.Voice.Name = "Voice"
        Me.Voice.Size = New System.Drawing.Size(210, 21)
        Me.Voice.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Volume"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.lblSpeed)
        Me.Panel1.Controls.Add(Me.txtChordSpeed)
        Me.Panel1.Location = New System.Drawing.Point(187, 51)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(111, 51)
        Me.Panel1.TabIndex = 4
        '
        'lblSpeed
        '
        Me.lblSpeed.AutoSize = True
        Me.lblSpeed.Location = New System.Drawing.Point(3, 29)
        Me.lblSpeed.Name = "lblSpeed"
        Me.lblSpeed.Size = New System.Drawing.Size(47, 13)
        Me.lblSpeed.TabIndex = 6
        Me.lblSpeed.Text = "Andante"
        '
        'PlaybackSettings
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(321, 297)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PlaybackSettings"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Playback Settings"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.tbVolume, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbChordSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbStrumSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbVolume As System.Windows.Forms.TrackBar
    Friend WithEvents txtVolume As System.Windows.Forms.TextBox
    Friend WithEvents tbChordSpeed As System.Windows.Forms.TrackBar
    Friend WithEvents txtChordSpeed As System.Windows.Forms.TextBox
    Friend WithEvents txtStrumSpeed As System.Windows.Forms.TextBox
    Friend WithEvents tbStrumSpeed As System.Windows.Forms.TrackBar
    Friend WithEvents Voice As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblSpeed As System.Windows.Forms.Label

End Class
