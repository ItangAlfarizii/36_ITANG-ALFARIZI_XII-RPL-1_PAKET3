<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FR_PENGATURAN
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
        Me.CBPRINTER = New System.Windows.Forms.ComboBox()
        Me.TXTNO = New System.Windows.Forms.TextBox()
        Me.TXTALAMAT = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTCAFE = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BTNSIMPAN)
        Me.GroupBox1.Controls.Add(Me.CBPRINTER)
        Me.GroupBox1.Controls.Add(Me.TXTNO)
        Me.GroupBox1.Controls.Add(Me.TXTALAMAT)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TXTCAFE)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(548, 249)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATA CAFE"
        '
        'BTNSIMPAN
        '
        Me.BTNSIMPAN.Location = New System.Drawing.Point(158, 177)
        Me.BTNSIMPAN.Name = "BTNSIMPAN"
        Me.BTNSIMPAN.Size = New System.Drawing.Size(75, 23)
        Me.BTNSIMPAN.TabIndex = 9
        Me.BTNSIMPAN.Text = "SIMPAN"
        Me.BTNSIMPAN.UseVisualStyleBackColor = True
        '
        'CBPRINTER
        '
        Me.CBPRINTER.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBPRINTER.FormattingEnabled = True
        Me.CBPRINTER.Location = New System.Drawing.Point(158, 123)
        Me.CBPRINTER.Name = "CBPRINTER"
        Me.CBPRINTER.Size = New System.Drawing.Size(357, 21)
        Me.CBPRINTER.TabIndex = 8
        '
        'TXTNO
        '
        Me.TXTNO.Location = New System.Drawing.Point(158, 95)
        Me.TXTNO.Name = "TXTNO"
        Me.TXTNO.Size = New System.Drawing.Size(357, 20)
        Me.TXTNO.TabIndex = 7
        '
        'TXTALAMAT
        '
        Me.TXTALAMAT.Location = New System.Drawing.Point(158, 64)
        Me.TXTALAMAT.Name = "TXTALAMAT"
        Me.TXTALAMAT.Size = New System.Drawing.Size(357, 20)
        Me.TXTALAMAT.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "PRINTER NOTA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "TELP CAFE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ALAMAT CAFE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NAMA CAFE"
        '
        'TXTCAFE
        '
        Me.TXTCAFE.Location = New System.Drawing.Point(158, 36)
        Me.TXTCAFE.Name = "TXTCAFE"
        Me.TXTCAFE.Size = New System.Drawing.Size(357, 20)
        Me.TXTCAFE.TabIndex = 2
        '
        'FR_PENGATURAN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 318)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FR_PENGATURAN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FR_PENGATURAN"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CBPRINTER As System.Windows.Forms.ComboBox
    Friend WithEvents TXTNO As System.Windows.Forms.TextBox
    Friend WithEvents TXTALAMAT As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXTCAFE As System.Windows.Forms.TextBox
    Friend WithEvents BTNSIMPAN As System.Windows.Forms.Button
End Class
