<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FR_KONEKSI
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
        Me.TXTSERVER = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXTDATA = New System.Windows.Forms.TextBox()
        Me.TXTPASSWORD = New System.Windows.Forms.TextBox()
        Me.TXTUSER = New System.Windows.Forms.TextBox()
        Me.BTNKONEK = New System.Windows.Forms.Button()
        Me.BTNKELUAR = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SERVER"
        '
        'TXTSERVER
        '
        Me.TXTSERVER.Location = New System.Drawing.Point(134, 45)
        Me.TXTSERVER.Name = "TXTSERVER"
        Me.TXTSERVER.Size = New System.Drawing.Size(220, 20)
        Me.TXTSERVER.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "DATABASE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "PASSWORD"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "USER"
        '
        'TXTDATA
        '
        Me.TXTDATA.Location = New System.Drawing.Point(134, 158)
        Me.TXTDATA.Name = "TXTDATA"
        Me.TXTDATA.Size = New System.Drawing.Size(220, 20)
        Me.TXTDATA.TabIndex = 5
        '
        'TXTPASSWORD
        '
        Me.TXTPASSWORD.Location = New System.Drawing.Point(134, 119)
        Me.TXTPASSWORD.Name = "TXTPASSWORD"
        Me.TXTPASSWORD.Size = New System.Drawing.Size(220, 20)
        Me.TXTPASSWORD.TabIndex = 6
        '
        'TXTUSER
        '
        Me.TXTUSER.Location = New System.Drawing.Point(134, 87)
        Me.TXTUSER.Name = "TXTUSER"
        Me.TXTUSER.Size = New System.Drawing.Size(220, 20)
        Me.TXTUSER.TabIndex = 7
        '
        'BTNKONEK
        '
        Me.BTNKONEK.Location = New System.Drawing.Point(53, 217)
        Me.BTNKONEK.Name = "BTNKONEK"
        Me.BTNKONEK.Size = New System.Drawing.Size(75, 23)
        Me.BTNKONEK.TabIndex = 8
        Me.BTNKONEK.Text = "KONEK"
        Me.BTNKONEK.UseVisualStyleBackColor = True
        '
        'BTNKELUAR
        '
        Me.BTNKELUAR.Location = New System.Drawing.Point(202, 217)
        Me.BTNKELUAR.Name = "BTNKELUAR"
        Me.BTNKELUAR.Size = New System.Drawing.Size(75, 23)
        Me.BTNKELUAR.TabIndex = 9
        Me.BTNKELUAR.Text = "KELUAR"
        Me.BTNKELUAR.UseVisualStyleBackColor = True
        '
        'FR_KONEKSI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 270)
        Me.Controls.Add(Me.BTNKELUAR)
        Me.Controls.Add(Me.BTNKONEK)
        Me.Controls.Add(Me.TXTUSER)
        Me.Controls.Add(Me.TXTPASSWORD)
        Me.Controls.Add(Me.TXTDATA)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXTSERVER)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FR_KONEKSI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FR_KONEKSI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXTSERVER As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TXTDATA As System.Windows.Forms.TextBox
    Friend WithEvents TXTPASSWORD As System.Windows.Forms.TextBox
    Friend WithEvents TXTUSER As System.Windows.Forms.TextBox
    Friend WithEvents BTNKONEK As System.Windows.Forms.Button
    Friend WithEvents BTNKELUAR As System.Windows.Forms.Button
End Class
