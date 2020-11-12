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
        Me.autorunbtn = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AutoRunCMDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'autorunbtn
        '
        Me.autorunbtn.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.autorunbtn.Location = New System.Drawing.Point(27, 33)
        Me.autorunbtn.Name = "autorunbtn"
        Me.autorunbtn.Size = New System.Drawing.Size(113, 70)
        Me.autorunbtn.TabIndex = 0
        Me.autorunbtn.Text = "Auto Run CMD"
        Me.autorunbtn.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AutoRunCMDToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(168, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AutoRunCMDToolStripMenuItem
        '
        Me.AutoRunCMDToolStripMenuItem.Name = "AutoRunCMDToolStripMenuItem"
        Me.AutoRunCMDToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.AutoRunCMDToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.AutoRunCMDToolStripMenuItem.Text = "Auto Run CMD"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(168, 124)
        Me.Controls.Add(Me.autorunbtn)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Auto Runnig CMD"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents autorunbtn As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AutoRunCMDToolStripMenuItem As ToolStripMenuItem
End Class
