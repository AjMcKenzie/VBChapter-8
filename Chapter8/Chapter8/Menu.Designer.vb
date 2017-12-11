<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnLottery = New System.Windows.Forms.Button()
        Me.btnFriends = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(74, 41)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Seating Chart"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnLottery
        '
        Me.btnLottery.Location = New System.Drawing.Point(12, 59)
        Me.btnLottery.Name = "btnLottery"
        Me.btnLottery.Size = New System.Drawing.Size(74, 41)
        Me.btnLottery.TabIndex = 1
        Me.btnLottery.Text = "Lottery"
        Me.btnLottery.UseVisualStyleBackColor = True
        '
        'btnFriends
        '
        Me.btnFriends.Location = New System.Drawing.Point(92, 12)
        Me.btnFriends.Name = "btnFriends"
        Me.btnFriends.Size = New System.Drawing.Size(74, 41)
        Me.btnFriends.TabIndex = 2
        Me.btnFriends.Text = "Friends"
        Me.btnFriends.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(223, 225)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(49, 25)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnFriends)
        Me.Controls.Add(Me.btnLottery)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnLottery As System.Windows.Forms.Button
    Friend WithEvents btnFriends As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
