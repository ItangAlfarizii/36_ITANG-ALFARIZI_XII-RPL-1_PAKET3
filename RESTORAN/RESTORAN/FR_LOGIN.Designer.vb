<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FR_LOGIN
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTUSER = New System.Windows.Forms.TextBox()
        Me.TXTPASSWORD = New System.Windows.Forms.TextBox()
        Me.BTNMASUK = New System.Windows.Forms.Button()
        Me.BTNKELUAR = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(139, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LOGIN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "USER"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "PASSWORD"
        '
        'TXTUSER
        '
        Me.TXTUSER.Location = New System.Drawing.Point(159, 97)
        Me.TXTUSER.Name = "TXTUSER"
        Me.TXTUSER.Size = New System.Drawing.Size(167, 20)
        Me.TXTUSER.TabIndex = 3
        '
        'TXTPASSWORD
        '
        Me.TXTPASSWORD.Location = New System.Drawing.Point(159, 164)
        Me.TXTPASSWORD.Name = "TXTPASSWORD"
        Me.TXTPASSWORD.Size = New System.Drawing.Size(167, 20)
        Me.TXTPASSWORD.TabIndex = 4
        Me.TXTPASSWORD.UseSystemPasswordChar = True
        '
        'BTNMASUK
        '
        Me.BTNMASUK.Location = New System.Drawing.Point(50, 242)
        Me.BTNMASUK.Name = "BTNMASUK"
        Me.BTNMASUK.Size = New System.Drawing.Size(75, 23)
        Me.BTNMASUK.TabIndex = 5
        Me.BTNMASUK.Text = "MASUK"
        Me.BTNMASUK.UseVisualStyleBackColor = True
        '
        'BTNKELUAR
        '
        Me.BTNKELUAR.Location = New System.Drawing.Point(197, 242)
        Me.BTNKELUAR.Name = "BTNKELUAR"
        Me.BTNKELUAR.Size = New System.Drawing.Size(75, 23)
        Me.BTNKELUAR.TabIndex = 6
        Me.BTNKELUAR.Text = "KELUAR"
        Me.BTNKELUAR.UseVisualStyleBackColor = True
        '
        'FR_LOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(338, 310)
        Me.Controls.Add(Me.BTNKELUAR)
        Me.Controls.Add(Me.BTNMASUK)
        Me.Controls.Add(Me.TXTPASSWORD)
        Me.Controls.Add(Me.TXTUSER)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FR_LOGIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FR_LOGIN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TXTUSER As System.Windows.Forms.TextBox
    Friend WithEvents TXTPASSWORD As System.Windows.Forms.TextBox
    Friend WithEvents BTNMASUK As System.Windows.Forms.Button
    Friend WithEvents BTNKELUAR As System.Windows.Forms.Button
End Class
