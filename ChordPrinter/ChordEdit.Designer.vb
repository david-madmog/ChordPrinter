<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChordEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChordEdit))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.pnlChordPic = New System.Windows.Forms.Panel()
        Me.txtBase = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbDuration6 = New System.Windows.Forms.RadioButton()
        Me.rbDuration12 = New System.Windows.Forms.RadioButton()
        Me.rbDuration3 = New System.Windows.Forms.RadioButton()
        Me.rbDuration24 = New System.Windows.Forms.RadioButton()
        Me.rbDuration4 = New System.Windows.Forms.RadioButton()
        Me.rbDuration1 = New System.Windows.Forms.RadioButton()
        Me.rbDuration8 = New System.Windows.Forms.RadioButton()
        Me.rbDuration2 = New System.Windows.Forms.RadioButton()
        Me.rbDuration16 = New System.Windows.Forms.RadioButton()
        Me.bLeft = New System.Windows.Forms.Button()
        Me.bRight = New System.Windows.Forms.Button()
        Me.pnlRhythm = New System.Windows.Forms.Panel()
        Me.bAddStrum = New System.Windows.Forms.Button()
        Me.bDeleteStrum = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rbStrokeDown = New System.Windows.Forms.RadioButton()
        Me.rbStrokeUp = New System.Windows.Forms.RadioButton()
        Me.rbStrumNone = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.pnlChordPic.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(352, 359)
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
        'pnlChordPic
        '
        Me.pnlChordPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlChordPic.Controls.Add(Me.txtBase)
        Me.pnlChordPic.Controls.Add(Me.txtTitle)
        Me.pnlChordPic.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlChordPic.Location = New System.Drawing.Point(0, 0)
        Me.pnlChordPic.Name = "pnlChordPic"
        Me.pnlChordPic.Size = New System.Drawing.Size(200, 400)
        Me.pnlChordPic.TabIndex = 1
        '
        'txtBase
        '
        Me.txtBase.Location = New System.Drawing.Point(3, 75)
        Me.txtBase.Name = "txtBase"
        Me.txtBase.Size = New System.Drawing.Size(44, 20)
        Me.txtBase.TabIndex = 1
        Me.txtBase.Visible = False
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(50, 3)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(100, 20)
        Me.txtTitle.TabIndex = 0
        Me.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTitle.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.rbDuration6)
        Me.Panel1.Controls.Add(Me.rbDuration12)
        Me.Panel1.Controls.Add(Me.rbDuration3)
        Me.Panel1.Controls.Add(Me.rbDuration24)
        Me.Panel1.Controls.Add(Me.rbDuration4)
        Me.Panel1.Controls.Add(Me.rbDuration1)
        Me.Panel1.Controls.Add(Me.rbDuration8)
        Me.Panel1.Controls.Add(Me.rbDuration2)
        Me.Panel1.Controls.Add(Me.rbDuration16)
        Me.Panel1.Location = New System.Drawing.Point(255, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 84)
        Me.Panel1.TabIndex = 16
        '
        'rbDuration6
        '
        Me.rbDuration6.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbDuration6.AutoSize = True
        Me.rbDuration6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.rbDuration6.Image = Global.ChordPrinter.My.Resources.Resources.quarternotedot
        Me.rbDuration6.Location = New System.Drawing.Point(79, 44)
        Me.rbDuration6.Name = "rbDuration6"
        Me.rbDuration6.Size = New System.Drawing.Size(32, 35)
        Me.rbDuration6.TabIndex = 24
        Me.rbDuration6.TabStop = True
        Me.rbDuration6.UseVisualStyleBackColor = True
        '
        'rbDuration12
        '
        Me.rbDuration12.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbDuration12.AutoSize = True
        Me.rbDuration12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.rbDuration12.Image = Global.ChordPrinter.My.Resources.Resources.halfnotedot
        Me.rbDuration12.Location = New System.Drawing.Point(41, 44)
        Me.rbDuration12.Name = "rbDuration12"
        Me.rbDuration12.Size = New System.Drawing.Size(32, 35)
        Me.rbDuration12.TabIndex = 23
        Me.rbDuration12.TabStop = True
        Me.rbDuration12.UseVisualStyleBackColor = True
        '
        'rbDuration3
        '
        Me.rbDuration3.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbDuration3.AutoSize = True
        Me.rbDuration3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.rbDuration3.Image = Global.ChordPrinter.My.Resources.Resources.eightnotedot
        Me.rbDuration3.Location = New System.Drawing.Point(117, 44)
        Me.rbDuration3.Name = "rbDuration3"
        Me.rbDuration3.Size = New System.Drawing.Size(32, 35)
        Me.rbDuration3.TabIndex = 22
        Me.rbDuration3.TabStop = True
        Me.rbDuration3.UseVisualStyleBackColor = True
        '
        'rbDuration24
        '
        Me.rbDuration24.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbDuration24.AutoSize = True
        Me.rbDuration24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.rbDuration24.Image = Global.ChordPrinter.My.Resources.Resources.fullnotedot
        Me.rbDuration24.Location = New System.Drawing.Point(3, 44)
        Me.rbDuration24.Name = "rbDuration24"
        Me.rbDuration24.Size = New System.Drawing.Size(32, 35)
        Me.rbDuration24.TabIndex = 21
        Me.rbDuration24.TabStop = True
        Me.rbDuration24.UseVisualStyleBackColor = True
        '
        'rbDuration4
        '
        Me.rbDuration4.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbDuration4.AutoSize = True
        Me.rbDuration4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.rbDuration4.Image = CType(resources.GetObject("rbDuration4.Image"), System.Drawing.Image)
        Me.rbDuration4.Location = New System.Drawing.Point(79, 3)
        Me.rbDuration4.Name = "rbDuration4"
        Me.rbDuration4.Size = New System.Drawing.Size(32, 35)
        Me.rbDuration4.TabIndex = 20
        Me.rbDuration4.TabStop = True
        Me.rbDuration4.UseVisualStyleBackColor = True
        '
        'rbDuration1
        '
        Me.rbDuration1.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbDuration1.AutoSize = True
        Me.rbDuration1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.rbDuration1.Image = CType(resources.GetObject("rbDuration1.Image"), System.Drawing.Image)
        Me.rbDuration1.Location = New System.Drawing.Point(155, 3)
        Me.rbDuration1.Name = "rbDuration1"
        Me.rbDuration1.Size = New System.Drawing.Size(32, 35)
        Me.rbDuration1.TabIndex = 19
        Me.rbDuration1.TabStop = True
        Me.rbDuration1.UseVisualStyleBackColor = True
        '
        'rbDuration8
        '
        Me.rbDuration8.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbDuration8.AutoSize = True
        Me.rbDuration8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.rbDuration8.Image = CType(resources.GetObject("rbDuration8.Image"), System.Drawing.Image)
        Me.rbDuration8.Location = New System.Drawing.Point(41, 3)
        Me.rbDuration8.Name = "rbDuration8"
        Me.rbDuration8.Size = New System.Drawing.Size(32, 35)
        Me.rbDuration8.TabIndex = 18
        Me.rbDuration8.TabStop = True
        Me.rbDuration8.UseVisualStyleBackColor = True
        '
        'rbDuration2
        '
        Me.rbDuration2.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbDuration2.AutoSize = True
        Me.rbDuration2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.rbDuration2.Image = CType(resources.GetObject("rbDuration2.Image"), System.Drawing.Image)
        Me.rbDuration2.Location = New System.Drawing.Point(117, 3)
        Me.rbDuration2.Name = "rbDuration2"
        Me.rbDuration2.Size = New System.Drawing.Size(32, 35)
        Me.rbDuration2.TabIndex = 17
        Me.rbDuration2.TabStop = True
        Me.rbDuration2.UseVisualStyleBackColor = True
        '
        'rbDuration16
        '
        Me.rbDuration16.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbDuration16.AutoSize = True
        Me.rbDuration16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.rbDuration16.Image = CType(resources.GetObject("rbDuration16.Image"), System.Drawing.Image)
        Me.rbDuration16.Location = New System.Drawing.Point(3, 3)
        Me.rbDuration16.Name = "rbDuration16"
        Me.rbDuration16.Size = New System.Drawing.Size(32, 35)
        Me.rbDuration16.TabIndex = 16
        Me.rbDuration16.TabStop = True
        Me.rbDuration16.UseVisualStyleBackColor = True
        '
        'bLeft
        '
        Me.bLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bLeft.Location = New System.Drawing.Point(207, 12)
        Me.bLeft.Name = "bLeft"
        Me.bLeft.Size = New System.Drawing.Size(42, 135)
        Me.bLeft.TabIndex = 17
        Me.bLeft.Text = "<"
        Me.bLeft.UseVisualStyleBackColor = True
        '
        'bRight
        '
        Me.bRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bRight.Location = New System.Drawing.Point(461, 12)
        Me.bRight.Name = "bRight"
        Me.bRight.Size = New System.Drawing.Size(42, 135)
        Me.bRight.TabIndex = 18
        Me.bRight.Text = ">"
        Me.bRight.UseVisualStyleBackColor = True
        '
        'pnlRhythm
        '
        Me.pnlRhythm.Location = New System.Drawing.Point(208, 189)
        Me.pnlRhythm.Name = "pnlRhythm"
        Me.pnlRhythm.Size = New System.Drawing.Size(295, 63)
        Me.pnlRhythm.TabIndex = 19
        '
        'bAddStrum
        '
        Me.bAddStrum.Location = New System.Drawing.Point(255, 153)
        Me.bAddStrum.Name = "bAddStrum"
        Me.bAddStrum.Size = New System.Drawing.Size(100, 30)
        Me.bAddStrum.TabIndex = 20
        Me.bAddStrum.Text = "Add Strum"
        Me.bAddStrum.UseVisualStyleBackColor = True
        '
        'bDeleteStrum
        '
        Me.bDeleteStrum.Location = New System.Drawing.Point(355, 153)
        Me.bDeleteStrum.Name = "bDeleteStrum"
        Me.bDeleteStrum.Size = New System.Drawing.Size(100, 30)
        Me.bDeleteStrum.TabIndex = 21
        Me.bDeleteStrum.Text = "Delete Strum"
        Me.bDeleteStrum.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.rbStrokeDown)
        Me.Panel2.Controls.Add(Me.rbStrokeUp)
        Me.Panel2.Controls.Add(Me.rbStrumNone)
        Me.Panel2.Location = New System.Drawing.Point(255, 102)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 45)
        Me.Panel2.TabIndex = 22
        '
        'rbStrokeDown
        '
        Me.rbStrokeDown.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbStrokeDown.AutoSize = True
        Me.rbStrokeDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.rbStrokeDown.Image = Global.ChordPrinter.My.Resources.Resources.strokedown
        Me.rbStrokeDown.Location = New System.Drawing.Point(50, 3)
        Me.rbStrokeDown.Name = "rbStrokeDown"
        Me.rbStrokeDown.Size = New System.Drawing.Size(32, 35)
        Me.rbStrokeDown.TabIndex = 19
        Me.rbStrokeDown.TabStop = True
        Me.rbStrokeDown.UseVisualStyleBackColor = True
        '
        'rbStrokeUp
        '
        Me.rbStrokeUp.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbStrokeUp.AutoSize = True
        Me.rbStrokeUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.rbStrokeUp.Image = Global.ChordPrinter.My.Resources.Resources.strokeup
        Me.rbStrokeUp.Location = New System.Drawing.Point(88, 3)
        Me.rbStrokeUp.Name = "rbStrokeUp"
        Me.rbStrokeUp.Size = New System.Drawing.Size(32, 35)
        Me.rbStrokeUp.TabIndex = 18
        Me.rbStrokeUp.TabStop = True
        Me.rbStrokeUp.UseVisualStyleBackColor = True
        '
        'rbStrumNone
        '
        Me.rbStrumNone.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbStrumNone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.rbStrumNone.Location = New System.Drawing.Point(3, 3)
        Me.rbStrumNone.Name = "rbStrumNone"
        Me.rbStrumNone.Size = New System.Drawing.Size(41, 35)
        Me.rbStrumNone.TabIndex = 17
        Me.rbStrumNone.TabStop = True
        Me.rbStrumNone.Text = "N/S"
        Me.rbStrumNone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbStrumNone.UseVisualStyleBackColor = True
        '
        'ChordEdit
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(510, 400)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.bDeleteStrum)
        Me.Controls.Add(Me.bAddStrum)
        Me.Controls.Add(Me.pnlRhythm)
        Me.Controls.Add(Me.bRight)
        Me.Controls.Add(Me.bLeft)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlChordPic)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ChordEdit"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Edit Chord"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.pnlChordPic.ResumeLayout(False)
        Me.pnlChordPic.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents pnlChordPic As System.Windows.Forms.Panel
    Friend WithEvents txtBase As System.Windows.Forms.TextBox
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rbDuration6 As System.Windows.Forms.RadioButton
    Friend WithEvents rbDuration12 As System.Windows.Forms.RadioButton
    Friend WithEvents rbDuration3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbDuration24 As System.Windows.Forms.RadioButton
    Friend WithEvents rbDuration4 As System.Windows.Forms.RadioButton
    Friend WithEvents rbDuration1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbDuration8 As System.Windows.Forms.RadioButton
    Friend WithEvents rbDuration2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbDuration16 As System.Windows.Forms.RadioButton
    Friend WithEvents bLeft As System.Windows.Forms.Button
    Friend WithEvents bRight As System.Windows.Forms.Button
    Friend WithEvents pnlRhythm As System.Windows.Forms.Panel
    Friend WithEvents bAddStrum As System.Windows.Forms.Button
    Friend WithEvents bDeleteStrum As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents rbStrokeDown As System.Windows.Forms.RadioButton
    Friend WithEvents rbStrokeUp As System.Windows.Forms.RadioButton
    Friend WithEvents rbStrumNone As System.Windows.Forms.RadioButton

End Class
