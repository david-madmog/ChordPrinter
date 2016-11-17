<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChordPrinter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChordPrinter))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Sizer = New System.Windows.Forms.TrackBar()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txtSliderVal = New System.Windows.Forms.ToolStripTextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintDoc = New System.Drawing.Printing.PrintDocument()
        Me.OpenDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SaveDialog = New System.Windows.Forms.SaveFileDialog()
        Me.PlayTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.BodyArea = New System.Windows.Forms.FlowLayoutPanel()
        Me.RhythmArea = New System.Windows.Forms.FlowLayoutPanel()
        Me.PrintChordsOnlyToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintSummaryChordsAndRhythmToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintRhythmOnlyToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdAdd = New System.Windows.Forms.ToolStripButton()
        Me.cmdDup = New System.Windows.Forms.ToolStripButton()
        Me.cmdDelete = New System.Windows.Forms.ToolStripButton()
        Me.cmdEdit = New System.Windows.Forms.ToolStripButton()
        Me.cmdBarline = New System.Windows.Forms.ToolStripButton()
        Me.cmdTitle = New System.Windows.Forms.ToolStripButton()
        Me.cmdPrint = New System.Windows.Forms.ToolStripSplitButton()
        Me.PrintChordsOnlyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintSummaryChordsAndRhythmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintRhythmOnlyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdSave = New System.Windows.Forms.ToolStripButton()
        Me.cmdOpen = New System.Windows.Forms.ToolStripButton()
        Me.cmdPlay = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddChordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        CType(Me.Sizer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Sizer)
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(694, 66)
        Me.Panel1.TabIndex = 3
        '
        'Sizer
        '
        Me.Sizer.BackColor = System.Drawing.SystemColors.Control
        Me.Sizer.LargeChange = 60
        Me.Sizer.Location = New System.Drawing.Point(570, 24)
        Me.Sizer.Maximum = 510
        Me.Sizer.Minimum = 10
        Me.Sizer.Name = "Sizer"
        Me.Sizer.Size = New System.Drawing.Size(122, 45)
        Me.Sizer.TabIndex = 3
        Me.Sizer.TickFrequency = 20
        Me.Sizer.Value = 100
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAdd, Me.cmdDup, Me.cmdDelete, Me.cmdEdit, Me.ToolStripSeparator4, Me.cmdBarline, Me.ToolStripSeparator1, Me.cmdTitle, Me.ToolStripSeparator5, Me.cmdPrint, Me.cmdSave, Me.cmdOpen, Me.ToolStripSeparator2, Me.cmdPlay, Me.ToolStripButton1, Me.ToolStripSeparator3, Me.ToolStripLabel1, Me.txtSliderVal})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(690, 38)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 38)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 38)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 38)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 38)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(66, 35)
        Me.ToolStripLabel1.Text = "Chord Size:"
        '
        'txtSliderVal
        '
        Me.txtSliderVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSliderVal.Name = "txtSliderVal"
        Me.txtSliderVal.Size = New System.Drawing.Size(40, 38)
        Me.txtSliderVal.ToolTipText = "Size of the chord diagram"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(690, 24)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.ToolStripMenuItem3, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.ToolStripMenuItem1, Me.PrintToolStripMenuItem, Me.PrintChordsOnlyToolStripMenuItem1, Me.PrintSummaryChordsAndRhythmToolStripMenuItem1, Me.PrintRhythmOnlyToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(262, 22)
        Me.NewToolStripMenuItem.Text = "&New"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(259, 6)
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(262, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save &As..."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(259, 6)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(259, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(262, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddChordToolStripMenuItem, Me.EditToolStripMenuItem1, Me.ToolStripMenuItem4, Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.ToolStripMenuItem5, Me.DeleteToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(186, 6)
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(186, 6)
        '
        'PrintDoc
        '
        '
        'OpenDialog
        '
        Me.OpenDialog.FileName = "OpenFileDialog1"
        '
        'PlayTimer
        '
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 66)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.BodyArea)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.RhythmArea)
        Me.SplitContainer1.Size = New System.Drawing.Size(694, 368)
        Me.SplitContainer1.SplitterDistance = 231
        Me.SplitContainer1.TabIndex = 4
        '
        'BodyArea
        '
        Me.BodyArea.AutoScroll = True
        Me.BodyArea.BackColor = System.Drawing.SystemColors.Control
        Me.BodyArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BodyArea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BodyArea.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.BodyArea.Location = New System.Drawing.Point(0, 0)
        Me.BodyArea.Name = "BodyArea"
        Me.BodyArea.Size = New System.Drawing.Size(694, 231)
        Me.BodyArea.TabIndex = 2
        '
        'RhythmArea
        '
        Me.RhythmArea.AutoScroll = True
        Me.RhythmArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.RhythmArea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RhythmArea.Location = New System.Drawing.Point(0, 0)
        Me.RhythmArea.Name = "RhythmArea"
        Me.RhythmArea.Size = New System.Drawing.Size(694, 133)
        Me.RhythmArea.TabIndex = 3
        '
        'PrintChordsOnlyToolStripMenuItem1
        '
        Me.PrintChordsOnlyToolStripMenuItem1.Name = "PrintChordsOnlyToolStripMenuItem1"
        Me.PrintChordsOnlyToolStripMenuItem1.Size = New System.Drawing.Size(262, 22)
        Me.PrintChordsOnlyToolStripMenuItem1.Text = "Print Chords Only"
        '
        'PrintSummaryChordsAndRhythmToolStripMenuItem1
        '
        Me.PrintSummaryChordsAndRhythmToolStripMenuItem1.Name = "PrintSummaryChordsAndRhythmToolStripMenuItem1"
        Me.PrintSummaryChordsAndRhythmToolStripMenuItem1.Size = New System.Drawing.Size(262, 22)
        Me.PrintSummaryChordsAndRhythmToolStripMenuItem1.Text = "Print Summary Chords and Rhythm"
        '
        'PrintRhythmOnlyToolStripMenuItem1
        '
        Me.PrintRhythmOnlyToolStripMenuItem1.Name = "PrintRhythmOnlyToolStripMenuItem1"
        Me.PrintRhythmOnlyToolStripMenuItem1.Size = New System.Drawing.Size(262, 22)
        Me.PrintRhythmOnlyToolStripMenuItem1.Text = "Print Rhythm Only"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 38)
        '
        'cmdAdd
        '
        Me.cmdAdd.Image = Global.ChordPrinter.My.Resources.Resources.add
        Me.cmdAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(33, 35)
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdAdd.ToolTipText = "Add a new chord"
        '
        'cmdDup
        '
        Me.cmdDup.Image = Global.ChordPrinter.My.Resources.Resources.page_copy
        Me.cmdDup.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDup.Name = "cmdDup"
        Me.cmdDup.Size = New System.Drawing.Size(33, 35)
        Me.cmdDup.Text = "Dup"
        Me.cmdDup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdDup.ToolTipText = "Duplicate the current chord"
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = Global.ChordPrinter.My.Resources.Resources.cross
        Me.cmdDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(44, 35)
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdDelete.ToolTipText = "Delete the current chord"
        '
        'cmdEdit
        '
        Me.cmdEdit.Image = Global.ChordPrinter.My.Resources.Resources.page_edit
        Me.cmdEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(31, 35)
        Me.cmdEdit.Text = "Edit"
        Me.cmdEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdEdit.ToolTipText = "Edit the current chord"
        '
        'cmdBarline
        '
        Me.cmdBarline.Image = Global.ChordPrinter.My.Resources.Resources.Barline
        Me.cmdBarline.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdBarline.Name = "cmdBarline"
        Me.cmdBarline.Size = New System.Drawing.Size(47, 35)
        Me.cmdBarline.Text = "Barline"
        Me.cmdBarline.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmdTitle
        '
        Me.cmdTitle.Image = Global.ChordPrinter.My.Resources.Resources.textfield_rename
        Me.cmdTitle.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdTitle.Name = "cmdTitle"
        Me.cmdTitle.Size = New System.Drawing.Size(34, 35)
        Me.cmdTitle.Text = "Title"
        Me.cmdTitle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmdPrint
        '
        Me.cmdPrint.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintChordsOnlyToolStripMenuItem, Me.PrintSummaryChordsAndRhythmToolStripMenuItem, Me.PrintRhythmOnlyToolStripMenuItem})
        Me.cmdPrint.Image = Global.ChordPrinter.My.Resources.Resources.printer
        Me.cmdPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(48, 35)
        Me.cmdPrint.Text = "Print"
        Me.cmdPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'PrintChordsOnlyToolStripMenuItem
        '
        Me.PrintChordsOnlyToolStripMenuItem.Name = "PrintChordsOnlyToolStripMenuItem"
        Me.PrintChordsOnlyToolStripMenuItem.Size = New System.Drawing.Size(262, 22)
        Me.PrintChordsOnlyToolStripMenuItem.Text = "Print Chords Only"
        '
        'PrintSummaryChordsAndRhythmToolStripMenuItem
        '
        Me.PrintSummaryChordsAndRhythmToolStripMenuItem.Name = "PrintSummaryChordsAndRhythmToolStripMenuItem"
        Me.PrintSummaryChordsAndRhythmToolStripMenuItem.Size = New System.Drawing.Size(262, 22)
        Me.PrintSummaryChordsAndRhythmToolStripMenuItem.Text = "Print Summary Chords and Rhythm"
        '
        'PrintRhythmOnlyToolStripMenuItem
        '
        Me.PrintRhythmOnlyToolStripMenuItem.Name = "PrintRhythmOnlyToolStripMenuItem"
        Me.PrintRhythmOnlyToolStripMenuItem.Size = New System.Drawing.Size(262, 22)
        Me.PrintRhythmOnlyToolStripMenuItem.Text = "Print Rhythm Only"
        '
        'cmdSave
        '
        Me.cmdSave.Image = Global.ChordPrinter.My.Resources.Resources.disk
        Me.cmdSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(35, 35)
        Me.cmdSave.Text = "Save"
        Me.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdSave.ToolTipText = "Save the chord sequence"
        '
        'cmdOpen
        '
        Me.cmdOpen.Image = Global.ChordPrinter.My.Resources.Resources.folder_page
        Me.cmdOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdOpen.Name = "cmdOpen"
        Me.cmdOpen.Size = New System.Drawing.Size(40, 35)
        Me.cmdOpen.Text = "Open"
        Me.cmdOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdOpen.ToolTipText = "Open a saved chord sequence"
        '
        'cmdPlay
        '
        Me.cmdPlay.Image = Global.ChordPrinter.My.Resources.Resources.control_play
        Me.cmdPlay.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPlay.Name = "cmdPlay"
        Me.cmdPlay.Size = New System.Drawing.Size(33, 35)
        Me.cmdPlay.Text = "Play"
        Me.cmdPlay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdPlay.ToolTipText = "Play the chords"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.ChordPrinter.My.Resources.Resources.cog
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(53, 35)
        Me.ToolStripButton1.Text = "Settings"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolStripButton1.ToolTipText = "Playback Settings"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Image = Global.ChordPrinter.My.Resources.Resources.folder_page
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(262, 22)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = Global.ChordPrinter.My.Resources.Resources.disk
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(262, 22)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Image = Global.ChordPrinter.My.Resources.Resources.printer
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(262, 22)
        Me.PrintToolStripMenuItem.Text = "&Print"
        '
        'AddChordToolStripMenuItem
        '
        Me.AddChordToolStripMenuItem.Image = Global.ChordPrinter.My.Resources.Resources.add
        Me.AddChordToolStripMenuItem.Name = "AddChordToolStripMenuItem"
        Me.AddChordToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AddChordToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.AddChordToolStripMenuItem.Text = "&Add Chord"
        '
        'EditToolStripMenuItem1
        '
        Me.EditToolStripMenuItem1.Image = Global.ChordPrinter.My.Resources.Resources.page_edit
        Me.EditToolStripMenuItem1.Name = "EditToolStripMenuItem1"
        Me.EditToolStripMenuItem1.ShortcutKeyDisplayString = "Enter"
        Me.EditToolStripMenuItem1.Size = New System.Drawing.Size(189, 22)
        Me.EditToolStripMenuItem1.Text = "&Modify chord..."
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Image = Global.ChordPrinter.My.Resources.Resources.cut
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.CutToolStripMenuItem.Text = "Cu&t"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Image = Global.ChordPrinter.My.Resources.Resources.page_copy
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.CopyToolStripMenuItem.Text = "&Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Image = Global.ChordPrinter.My.Resources.Resources.page_paste
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.PasteToolStripMenuItem.Text = "&Paste"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Image = Global.ChordPrinter.My.Resources.Resources.cross
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.DeleteToolStripMenuItem.Text = "&Delete"
        '
        'frmChordPrinter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 434)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmChordPrinter"
        Me.Text = "Chord Printer"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Sizer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Sizer As System.Windows.Forms.TrackBar
    Friend WithEvents PrintDoc As System.Drawing.Printing.PrintDocument
    Friend WithEvents OpenDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdDup As System.Windows.Forms.ToolStripButton
    Friend WithEvents AddChordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdOpen As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtSliderVal As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents cmdPlay As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PlayTimer As System.Windows.Forms.Timer
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents BodyArea As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents RhythmArea As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdBarline As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdPrint As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents PrintChordsOnlyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintSummaryChordsAndRhythmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintRhythmOnlyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintChordsOnlyToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintSummaryChordsAndRhythmToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintRhythmOnlyToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdTitle As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator

End Class
