<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lottery
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
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.lblSecond = New System.Windows.Forms.Label()
        Me.lblThird = New System.Windows.Forms.Label()
        Me.lblFourth = New System.Windows.Forms.Label()
        Me.lblFith = New System.Windows.Forms.Label()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblFirst
        '
        Me.lblFirst.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblFirst.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFirst.Location = New System.Drawing.Point(12, 27)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(43, 30)
        Me.lblFirst.TabIndex = 0
        Me.lblFirst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSecond
        '
        Me.lblSecond.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblSecond.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSecond.Location = New System.Drawing.Point(86, 27)
        Me.lblSecond.Name = "lblSecond"
        Me.lblSecond.Size = New System.Drawing.Size(43, 30)
        Me.lblSecond.TabIndex = 1
        Me.lblSecond.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblThird
        '
        Me.lblThird.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblThird.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblThird.Location = New System.Drawing.Point(160, 27)
        Me.lblThird.Name = "lblThird"
        Me.lblThird.Size = New System.Drawing.Size(43, 30)
        Me.lblThird.TabIndex = 2
        Me.lblThird.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFourth
        '
        Me.lblFourth.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblFourth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFourth.Location = New System.Drawing.Point(235, 27)
        Me.lblFourth.Name = "lblFourth"
        Me.lblFourth.Size = New System.Drawing.Size(43, 30)
        Me.lblFourth.TabIndex = 3
        Me.lblFourth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFith
        '
        Me.lblFith.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblFith.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFith.Location = New System.Drawing.Point(310, 27)
        Me.lblFith.Name = "lblFith"
        Me.lblFith.Size = New System.Drawing.Size(43, 30)
        Me.lblFith.TabIndex = 4
        Me.lblFith.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(86, 84)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(68, 34)
        Me.btnGenerate.TabIndex = 5
        Me.btnGenerate.Text = "Generate Numbers"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(214, 84)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(68, 34)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "•"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(134, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "•"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(209, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 25)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "•"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(284, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 25)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "•"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(381, 141)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.lblFith)
        Me.Controls.Add(Me.lblFourth)
        Me.Controls.Add(Me.lblThird)
        Me.Controls.Add(Me.lblSecond)
        Me.Controls.Add(Me.lblFirst)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Lottery"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFirst As System.Windows.Forms.Label
    Friend WithEvents lblSecond As System.Windows.Forms.Label
    Friend WithEvents lblThird As System.Windows.Forms.Label
    Friend WithEvents lblFourth As System.Windows.Forms.Label
    Friend WithEvents lblFith As System.Windows.Forms.Label
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
