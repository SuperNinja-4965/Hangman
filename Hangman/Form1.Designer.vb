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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.triesLeft = New System.Windows.Forms.Label()
        Me.trys = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SameWordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewWordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Message = New System.Windows.Forms.ToolStripMenuItem()
        Me.Options = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.About = New System.Windows.Forms.ToolStripMenuItem()
        Me.WinLose = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Options.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.triesLeft)
        Me.GroupBox3.Controls.Add(Me.trys)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox3.Location = New System.Drawing.Point(0, 227)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(287, 120)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'triesLeft
        '
        Me.triesLeft.AutoSize = True
        Me.triesLeft.Location = New System.Drawing.Point(3, 104)
        Me.triesLeft.Name = "triesLeft"
        Me.triesLeft.Size = New System.Drawing.Size(100, 13)
        Me.triesLeft.TabIndex = 4
        Me.triesLeft.Text = "You have x tries left"
        '
        'trys
        '
        Me.trys.AutoSize = True
        Me.trys.Location = New System.Drawing.Point(3, 77)
        Me.trys.Name = "trys"
        Me.trys.Size = New System.Drawing.Size(90, 13)
        Me.trys.TabIndex = 3
        Me.trys.Text = "You have no tries"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(0, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "System Error"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(158, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 22)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TextBox1.Location = New System.Drawing.Point(3, 16)
        Me.TextBox1.MaxLength = 1
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(132, 20)
        Me.TextBox1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.Message})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(287, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.FileToolStripMenuItem.Text = "Options"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SameWordsToolStripMenuItem, Me.NewWordsToolStripMenuItem})
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.OpenToolStripMenuItem.Text = "New game"
        '
        'SameWordsToolStripMenuItem
        '
        Me.SameWordsToolStripMenuItem.Name = "SameWordsToolStripMenuItem"
        Me.SameWordsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.SameWordsToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.SameWordsToolStripMenuItem.Text = "Same Words"
        '
        'NewWordsToolStripMenuItem
        '
        Me.NewWordsToolStripMenuItem.Name = "NewWordsToolStripMenuItem"
        Me.NewWordsToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewWordsToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.NewWordsToolStripMenuItem.Text = "Change words"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(134, 22)
        Me.ToolStripMenuItem1.Text = "Exit"
        '
        'Message
        '
        Me.Message.Name = "Message"
        Me.Message.Size = New System.Drawing.Size(12, 20)
        '
        'Options
        '
        Me.Options.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.About})
        Me.Options.Name = "Options"
        Me.Options.Size = New System.Drawing.Size(108, 26)
        '
        'About
        '
        Me.About.Name = "About"
        Me.About.Size = New System.Drawing.Size(107, 22)
        Me.About.Text = "About"
        '
        'WinLose
        '
        Me.WinLose.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WinLose.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WinLose.Location = New System.Drawing.Point(0, 24)
        Me.WinLose.Name = "WinLose"
        Me.WinLose.Size = New System.Drawing.Size(287, 203)
        Me.WinLose.TabIndex = 5
        Me.WinLose.Text = "You Lose. ;("
        Me.WinLose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(287, 347)
        Me.ContextMenuStrip = Me.Options
        Me.Controls.Add(Me.WinLose)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(303, 386)
        Me.MinimumSize = New System.Drawing.Size(303, 386)
        Me.Name = "Form1"
        Me.Text = "Hangman"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Options.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents trys As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Message As ToolStripMenuItem
    Friend WithEvents triesLeft As Label
    Friend WithEvents Options As ContextMenuStrip
    Friend WithEvents About As ToolStripMenuItem
    Friend WithEvents SameWordsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewWordsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WinLose As Label
End Class
