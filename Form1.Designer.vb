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
        Me.MainApp = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.COMMANDNAME = New System.Windows.Forms.Label()
        Me.ENTER = New System.Windows.Forms.Button()
        Me.OUTPUT = New System.Windows.Forms.Label()
        Me.INPUT = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MultiLine = New System.Windows.Forms.TabPage()
        Me.DocsTab = New System.Windows.Forms.TabPage()
        Me.AboutTab = New System.Windows.Forms.TabPage()
        Me.MainApp.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainApp
        '
        Me.MainApp.Controls.Add(Me.TabPage1)
        Me.MainApp.Controls.Add(Me.MultiLine)
        Me.MainApp.Controls.Add(Me.DocsTab)
        Me.MainApp.Controls.Add(Me.AboutTab)
        Me.MainApp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.MainApp.Location = New System.Drawing.Point(13, 13)
        Me.MainApp.Name = "MainApp"
        Me.MainApp.SelectedIndex = 0
        Me.MainApp.Size = New System.Drawing.Size(382, 200)
        Me.MainApp.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Black
        Me.TabPage1.Controls.Add(Me.COMMANDNAME)
        Me.TabPage1.Controls.Add(Me.ENTER)
        Me.TabPage1.Controls.Add(Me.OUTPUT)
        Me.TabPage1.Controls.Add(Me.INPUT)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(374, 174)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "CLI"
        '
        'COMMANDNAME
        '
        Me.COMMANDNAME.AutoSize = True
        Me.COMMANDNAME.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.COMMANDNAME.Location = New System.Drawing.Point(324, 4)
        Me.COMMANDNAME.Name = "COMMANDNAME"
        Me.COMMANDNAME.Size = New System.Drawing.Size(49, 13)
        Me.COMMANDNAME.TabIndex = 4
        Me.COMMANDNAME.Text = "COMMAND"
        '
        'ENTER
        '
        Me.ENTER.Location = New System.Drawing.Point(337, 148)
        Me.ENTER.Name = "ENTER"
        Me.ENTER.Size = New System.Drawing.Size(31, 20)
        Me.ENTER.TabIndex = 3
        Me.ENTER.Text = "GO"
        Me.ENTER.UseVisualStyleBackColor = True
        '
        'OUTPUT
        '
        Me.OUTPUT.AutoSize = True
        Me.OUTPUT.ForeColor = System.Drawing.Color.GreenYellow
        Me.OUTPUT.Location = New System.Drawing.Point(6, 132)
        Me.OUTPUT.Name = "OUTPUT"
        Me.OUTPUT.Size = New System.Drawing.Size(43, 13)
        Me.OUTPUT.TabIndex = 2
        Me.OUTPUT.Text = "OUTPUT"
        '
        'INPUT
        '
        Me.INPUT.AutoSize = True
        Me.INPUT.ForeColor = System.Drawing.Color.YellowGreen
        Me.INPUT.Location = New System.Drawing.Point(6, 119)
        Me.INPUT.Name = "INPUT"
        Me.INPUT.Size = New System.Drawing.Size(37, 13)
        Me.INPUT.TabIndex = 1
        Me.INPUT.Text = "INPUT"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(7, 148)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(323, 20)
        Me.TextBox1.TabIndex = 0
        '
        'MultiLine
        '
        Me.MultiLine.Location = New System.Drawing.Point(4, 22)
        Me.MultiLine.Name = "MultiLine"
        Me.MultiLine.Padding = New System.Windows.Forms.Padding(3)
        Me.MultiLine.Size = New System.Drawing.Size(374, 174)
        Me.MultiLine.TabIndex = 2
        Me.MultiLine.Text = "MLTab"
        Me.MultiLine.UseVisualStyleBackColor = True
        '
        'DocsTab
        '
        Me.DocsTab.Location = New System.Drawing.Point(4, 22)
        Me.DocsTab.Name = "DocsTab"
        Me.DocsTab.Padding = New System.Windows.Forms.Padding(3)
        Me.DocsTab.Size = New System.Drawing.Size(374, 174)
        Me.DocsTab.TabIndex = 3
        Me.DocsTab.Text = "Docs"
        Me.DocsTab.UseVisualStyleBackColor = True
        '
        'AboutTab
        '
        Me.AboutTab.Location = New System.Drawing.Point(4, 22)
        Me.AboutTab.Name = "AboutTab"
        Me.AboutTab.Padding = New System.Windows.Forms.Padding(3)
        Me.AboutTab.Size = New System.Drawing.Size(374, 174)
        Me.AboutTab.TabIndex = 4
        Me.AboutTab.Text = "About"
        Me.AboutTab.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 225)
        Me.Controls.Add(Me.MainApp)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MainApp.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainApp As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents INPUT As Label
    Friend WithEvents OUTPUT As Label
    Friend WithEvents ENTER As Button
    Friend WithEvents COMMANDNAME As Label
    Friend WithEvents MultiLine As TabPage
    Friend WithEvents DocsTab As TabPage
    Friend WithEvents AboutTab As TabPage
End Class
