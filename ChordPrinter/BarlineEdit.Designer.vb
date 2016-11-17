<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BarlineEdit
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
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.rbSimple = New System.Windows.Forms.RadioButton()
        Me.rbSection = New System.Windows.Forms.RadioButton()
        Me.rbStart = New System.Windows.Forms.RadioButton()
        Me.rbStartDots = New System.Windows.Forms.RadioButton()
        Me.rbFinal = New System.Windows.Forms.RadioButton()
        Me.rbFinalDots = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'cmdCancel
        '
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Location = New System.Drawing.Point(93, 83)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 0
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdOK
        '
        Me.cmdOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmdOK.Location = New System.Drawing.Point(12, 83)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(75, 23)
        Me.cmdOK.TabIndex = 1
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'rbSimple
        '
        Me.rbSimple.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbSimple.AutoSize = True
        Me.rbSimple.Image = Global.ChordPrinter.My.Resources.Resources.barsimple
        Me.rbSimple.Location = New System.Drawing.Point(12, 12)
        Me.rbSimple.Name = "rbSimple"
        Me.rbSimple.Size = New System.Drawing.Size(21, 56)
        Me.rbSimple.TabIndex = 2
        Me.rbSimple.TabStop = True
        Me.rbSimple.UseVisualStyleBackColor = True
        '
        'rbSection
        '
        Me.rbSection.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbSection.AutoSize = True
        Me.rbSection.Image = Global.ChordPrinter.My.Resources.Resources.barsection
        Me.rbSection.Location = New System.Drawing.Point(39, 12)
        Me.rbSection.Name = "rbSection"
        Me.rbSection.Size = New System.Drawing.Size(21, 56)
        Me.rbSection.TabIndex = 3
        Me.rbSection.TabStop = True
        Me.rbSection.UseVisualStyleBackColor = True
        '
        'rbStart
        '
        Me.rbStart.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbStart.AutoSize = True
        Me.rbStart.Image = Global.ChordPrinter.My.Resources.Resources.barstart
        Me.rbStart.Location = New System.Drawing.Point(66, 12)
        Me.rbStart.Name = "rbStart"
        Me.rbStart.Size = New System.Drawing.Size(21, 56)
        Me.rbStart.TabIndex = 4
        Me.rbStart.TabStop = True
        Me.rbStart.UseVisualStyleBackColor = True
        '
        'rbStartDots
        '
        Me.rbStartDots.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbStartDots.AutoSize = True
        Me.rbStartDots.Image = Global.ChordPrinter.My.Resources.Resources.barstartdots
        Me.rbStartDots.Location = New System.Drawing.Point(93, 12)
        Me.rbStartDots.Name = "rbStartDots"
        Me.rbStartDots.Size = New System.Drawing.Size(21, 56)
        Me.rbStartDots.TabIndex = 5
        Me.rbStartDots.TabStop = True
        Me.rbStartDots.UseVisualStyleBackColor = True
        '
        'rbFinal
        '
        Me.rbFinal.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbFinal.AutoSize = True
        Me.rbFinal.Image = Global.ChordPrinter.My.Resources.Resources.barfinal
        Me.rbFinal.Location = New System.Drawing.Point(120, 12)
        Me.rbFinal.Name = "rbFinal"
        Me.rbFinal.Size = New System.Drawing.Size(21, 56)
        Me.rbFinal.TabIndex = 6
        Me.rbFinal.TabStop = True
        Me.rbFinal.UseVisualStyleBackColor = True
        '
        'rbFinalDots
        '
        Me.rbFinalDots.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbFinalDots.AutoSize = True
        Me.rbFinalDots.Image = Global.ChordPrinter.My.Resources.Resources.barfinaldots
        Me.rbFinalDots.Location = New System.Drawing.Point(147, 12)
        Me.rbFinalDots.Name = "rbFinalDots"
        Me.rbFinalDots.Size = New System.Drawing.Size(21, 56)
        Me.rbFinalDots.TabIndex = 7
        Me.rbFinalDots.TabStop = True
        Me.rbFinalDots.UseVisualStyleBackColor = True
        '
        'BarlineEdit
        '
        Me.AcceptButton = Me.cmdOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(179, 114)
        Me.Controls.Add(Me.rbFinalDots)
        Me.Controls.Add(Me.rbFinal)
        Me.Controls.Add(Me.rbStartDots)
        Me.Controls.Add(Me.rbStart)
        Me.Controls.Add(Me.rbSection)
        Me.Controls.Add(Me.rbSimple)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.cmdCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BarlineEdit"
        Me.Text = "Edit Barline"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdOK As System.Windows.Forms.Button
    Friend WithEvents rbSimple As System.Windows.Forms.RadioButton
    Friend WithEvents rbSection As System.Windows.Forms.RadioButton
    Friend WithEvents rbStart As System.Windows.Forms.RadioButton
    Friend WithEvents rbStartDots As System.Windows.Forms.RadioButton
    Friend WithEvents rbFinal As System.Windows.Forms.RadioButton
    Friend WithEvents rbFinalDots As System.Windows.Forms.RadioButton
End Class
