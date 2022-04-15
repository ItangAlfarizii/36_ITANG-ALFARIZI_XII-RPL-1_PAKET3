<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FR_LAPORAN
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BTNCETAK = New System.Windows.Forms.Button()
        Me.BTNTAMPIL = New System.Windows.Forms.Button()
        Me.TGLSAMPAI = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TGLMULAI = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DGTAMPIL = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGTAMPIL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1082, 128)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.BTNCETAK)
        Me.GroupBox1.Controls.Add(Me.TGLMULAI)
        Me.GroupBox1.Controls.Add(Me.BTNTAMPIL)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TGLSAMPAI)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(466, 119)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'BTNCETAK
        '
        Me.BTNCETAK.Location = New System.Drawing.Point(232, 75)
        Me.BTNCETAK.Name = "BTNCETAK"
        Me.BTNCETAK.Size = New System.Drawing.Size(75, 23)
        Me.BTNCETAK.TabIndex = 8
        Me.BTNCETAK.Text = "CETAK"
        Me.BTNCETAK.UseVisualStyleBackColor = True
        '
        'BTNTAMPIL
        '
        Me.BTNTAMPIL.Location = New System.Drawing.Point(137, 75)
        Me.BTNTAMPIL.Name = "BTNTAMPIL"
        Me.BTNTAMPIL.Size = New System.Drawing.Size(75, 23)
        Me.BTNTAMPIL.TabIndex = 7
        Me.BTNTAMPIL.Text = "TAMPIL"
        Me.BTNTAMPIL.UseVisualStyleBackColor = True
        '
        'TGLSAMPAI
        '
        Me.TGLSAMPAI.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TGLSAMPAI.Location = New System.Drawing.Point(331, 29)
        Me.TGLSAMPAI.Name = "TGLSAMPAI"
        Me.TGLSAMPAI.Size = New System.Drawing.Size(123, 20)
        Me.TGLSAMPAI.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(252, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "MULAI TGL"
        '
        'TGLMULAI
        '
        Me.TGLMULAI.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TGLMULAI.Location = New System.Drawing.Point(89, 30)
        Me.TGLMULAI.Name = "TGLMULAI"
        Me.TGLMULAI.Size = New System.Drawing.Size(123, 20)
        Me.TGLMULAI.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "MULAI TGL"
        '
        'DGTAMPIL
        '
        Me.DGTAMPIL.AllowUserToAddRows = False
        Me.DGTAMPIL.AllowUserToDeleteRows = False
        Me.DGTAMPIL.AllowUserToResizeColumns = False
        Me.DGTAMPIL.AllowUserToResizeRows = False
        Me.DGTAMPIL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGTAMPIL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGTAMPIL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGTAMPIL.Location = New System.Drawing.Point(0, 128)
        Me.DGTAMPIL.Name = "DGTAMPIL"
        Me.DGTAMPIL.ReadOnly = True
        Me.DGTAMPIL.RowHeadersVisible = False
        Me.DGTAMPIL.Size = New System.Drawing.Size(1082, 376)
        Me.DGTAMPIL.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.txtnama)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(554, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(506, 119)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama"
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(86, 27)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(270, 20)
        Me.txtnama.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(192, 75)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Tampil"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FR_LAPORAN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1082, 504)
        Me.Controls.Add(Me.DGTAMPIL)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FR_LAPORAN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FR_LAPORAN"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGTAMPIL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BTNCETAK As System.Windows.Forms.Button
    Friend WithEvents BTNTAMPIL As System.Windows.Forms.Button
    Friend WithEvents TGLSAMPAI As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TGLMULAI As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DGTAMPIL As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
