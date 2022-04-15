<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FR_ADMIN
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BTNSIMPAN = New System.Windows.Forms.Button()
        Me.LBNIK = New System.Windows.Forms.Label()
        Me.LBNAMA = New System.Windows.Forms.Label()
        Me.CBTYPE = New System.Windows.Forms.ComboBox()
        Me.TXTPASS2 = New System.Windows.Forms.TextBox()
        Me.TXTPASS = New System.Windows.Forms.TextBox()
        Me.TXTUSER = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BTNSIMPAN)
        Me.GroupBox1.Controls.Add(Me.LBNIK)
        Me.GroupBox1.Controls.Add(Me.LBNAMA)
        Me.GroupBox1.Controls.Add(Me.CBTYPE)
        Me.GroupBox1.Controls.Add(Me.TXTPASS2)
        Me.GroupBox1.Controls.Add(Me.TXTPASS)
        Me.GroupBox1.Controls.Add(Me.TXTUSER)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(446, 307)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATA USER ADMIN"
        '
        'BTNSIMPAN
        '
        Me.BTNSIMPAN.Location = New System.Drawing.Point(158, 221)
        Me.BTNSIMPAN.Name = "BTNSIMPAN"
        Me.BTNSIMPAN.Size = New System.Drawing.Size(75, 23)
        Me.BTNSIMPAN.TabIndex = 12
        Me.BTNSIMPAN.Text = "SIMPAN"
        Me.BTNSIMPAN.UseVisualStyleBackColor = True
        '
        'LBNIK
        '
        Me.LBNIK.AutoSize = True
        Me.LBNIK.Location = New System.Drawing.Point(155, 44)
        Me.LBNIK.Name = "LBNIK"
        Me.LBNIK.Size = New System.Drawing.Size(25, 13)
        Me.LBNIK.TabIndex = 11
        Me.LBNIK.Text = "NIK"
        '
        'LBNAMA
        '
        Me.LBNAMA.AutoSize = True
        Me.LBNAMA.Location = New System.Drawing.Point(155, 74)
        Me.LBNAMA.Name = "LBNAMA"
        Me.LBNAMA.Size = New System.Drawing.Size(38, 13)
        Me.LBNAMA.TabIndex = 10
        Me.LBNAMA.Text = "NAMA"
        '
        'CBTYPE
        '
        Me.CBTYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBTYPE.FormattingEnabled = True
        Me.CBTYPE.Items.AddRange(New Object() {"ADMIN", "MANAJER", "KASIR", "USER"})
        Me.CBTYPE.Location = New System.Drawing.Point(158, 194)
        Me.CBTYPE.Name = "CBTYPE"
        Me.CBTYPE.Size = New System.Drawing.Size(129, 21)
        Me.CBTYPE.TabIndex = 9
        '
        'TXTPASS2
        '
        Me.TXTPASS2.Location = New System.Drawing.Point(158, 161)
        Me.TXTPASS2.Name = "TXTPASS2"
        Me.TXTPASS2.Size = New System.Drawing.Size(226, 20)
        Me.TXTPASS2.TabIndex = 8
        Me.TXTPASS2.UseSystemPasswordChar = True
        '
        'TXTPASS
        '
        Me.TXTPASS.Location = New System.Drawing.Point(158, 131)
        Me.TXTPASS.Name = "TXTPASS"
        Me.TXTPASS.Size = New System.Drawing.Size(226, 20)
        Me.TXTPASS.TabIndex = 7
        Me.TXTPASS.UseSystemPasswordChar = True
        '
        'TXTUSER
        '
        Me.TXTUSER.Location = New System.Drawing.Point(158, 97)
        Me.TXTUSER.Name = "TXTUSER"
        Me.TXTUSER.Size = New System.Drawing.Size(226, 20)
        Me.TXTUSER.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "TYPE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "RE PASSWORD"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "PASSWORD"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "USERNAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NAMA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIK"
        '
        'FR_ADMIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 319)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FR_ADMIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FR_ADMIN"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXTPASS2 As System.Windows.Forms.TextBox
    Friend WithEvents TXTPASS As System.Windows.Forms.TextBox
    Friend WithEvents TXTUSER As System.Windows.Forms.TextBox
    Friend WithEvents CBTYPE As System.Windows.Forms.ComboBox
    Friend WithEvents LBNIK As System.Windows.Forms.Label
    Friend WithEvents LBNAMA As System.Windows.Forms.Label
    Friend WithEvents BTNSIMPAN As System.Windows.Forms.Button
End Class
