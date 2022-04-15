<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FR_KELUAR
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PNATAS = New System.Windows.Forms.Panel()
        Me.PNCARI = New System.Windows.Forms.Panel()
        Me.DGCARI = New System.Windows.Forms.DataGridView()
        Me.TXTCARI = New System.Windows.Forms.TextBox()
        Me.BTNKELUAR = New System.Windows.Forms.Button()
        Me.BTNMENU = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LBTOTAL = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BTNCARI = New System.Windows.Forms.Button()
        Me.TXTHARGA = New System.Windows.Forms.TextBox()
        Me.TXTSTATUS = New System.Windows.Forms.TextBox()
        Me.TXTMENU = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTKODE = New System.Windows.Forms.TextBox()
        Me.BTNMINIMIZE = New System.Windows.Forms.Button()
        Me.PNBAWAH = New System.Windows.Forms.Panel()
        Me.BTNBAYAR = New System.Windows.Forms.Button()
        Me.DGTAMPIL = New System.Windows.Forms.DataGridView()
        Me.KODE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MENU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STATUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HARGA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNBAYAR = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BTNTUTUP = New System.Windows.Forms.Button()
        Me.TXTKEMBALIAN = New System.Windows.Forms.TextBox()
        Me.TXTTUNAI = New System.Windows.Forms.TextBox()
        Me.TXTBAYAR = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.KLIK_KANAN = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.HAPUSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NOTA = New System.Drawing.Printing.PrintDocument()
        Me.PNATAS.SuspendLayout()
        Me.PNCARI.SuspendLayout()
        CType(Me.DGCARI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.PNBAWAH.SuspendLayout()
        CType(Me.DGTAMPIL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PNBAYAR.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.KLIK_KANAN.SuspendLayout()
        Me.SuspendLayout()
        '
        'PNATAS
        '
        Me.PNATAS.Controls.Add(Me.PNCARI)
        Me.PNATAS.Controls.Add(Me.BTNMENU)
        Me.PNATAS.Controls.Add(Me.GroupBox2)
        Me.PNATAS.Controls.Add(Me.GroupBox1)
        Me.PNATAS.Controls.Add(Me.BTNMINIMIZE)
        Me.PNATAS.Dock = System.Windows.Forms.DockStyle.Top
        Me.PNATAS.Location = New System.Drawing.Point(0, 0)
        Me.PNATAS.Name = "PNATAS"
        Me.PNATAS.Size = New System.Drawing.Size(1106, 179)
        Me.PNATAS.TabIndex = 0
        '
        'PNCARI
        '
        Me.PNCARI.Controls.Add(Me.DGCARI)
        Me.PNCARI.Controls.Add(Me.TXTCARI)
        Me.PNCARI.Controls.Add(Me.BTNKELUAR)
        Me.PNCARI.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PNCARI.Location = New System.Drawing.Point(0, 0)
        Me.PNCARI.Name = "PNCARI"
        Me.PNCARI.Size = New System.Drawing.Size(1106, 179)
        Me.PNCARI.TabIndex = 12
        Me.PNCARI.Visible = False
        '
        'DGCARI
        '
        Me.DGCARI.AllowUserToAddRows = False
        Me.DGCARI.AllowUserToDeleteRows = False
        Me.DGCARI.AllowUserToResizeColumns = False
        Me.DGCARI.AllowUserToResizeRows = False
        Me.DGCARI.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGCARI.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGCARI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGCARI.Location = New System.Drawing.Point(0, 26)
        Me.DGCARI.Name = "DGCARI"
        Me.DGCARI.ReadOnly = True
        Me.DGCARI.RowHeadersVisible = False
        Me.DGCARI.Size = New System.Drawing.Size(1103, 169)
        Me.DGCARI.TabIndex = 13
        '
        'TXTCARI
        '
        Me.TXTCARI.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTCARI.Location = New System.Drawing.Point(0, 3)
        Me.TXTCARI.Name = "TXTCARI"
        Me.TXTCARI.Size = New System.Drawing.Size(1050, 20)
        Me.TXTCARI.TabIndex = 0
        '
        'BTNKELUAR
        '
        Me.BTNKELUAR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNKELUAR.BackColor = System.Drawing.Color.Red
        Me.BTNKELUAR.Location = New System.Drawing.Point(1056, 3)
        Me.BTNKELUAR.Name = "BTNKELUAR"
        Me.BTNKELUAR.Size = New System.Drawing.Size(47, 23)
        Me.BTNKELUAR.TabIndex = 11
        Me.BTNKELUAR.Text = "X"
        Me.BTNKELUAR.UseVisualStyleBackColor = False
        '
        'BTNMENU
        '
        Me.BTNMENU.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNMENU.BackColor = System.Drawing.Color.Red
        Me.BTNMENU.Location = New System.Drawing.Point(1034, 3)
        Me.BTNMENU.Name = "BTNMENU"
        Me.BTNMENU.Size = New System.Drawing.Size(60, 30)
        Me.BTNMENU.TabIndex = 13
        Me.BTNMENU.Text = "X"
        Me.BTNMENU.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.LBTOTAL)
        Me.GroupBox2.Location = New System.Drawing.Point(487, 35)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(607, 161)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "TOTAL  HARGA"
        '
        'LBTOTAL
        '
        Me.LBTOTAL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBTOTAL.Font = New System.Drawing.Font("Arial Black", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBTOTAL.Location = New System.Drawing.Point(22, 42)
        Me.LBTOTAL.Name = "LBTOTAL"
        Me.LBTOTAL.Size = New System.Drawing.Size(579, 102)
        Me.LBTOTAL.TabIndex = 11
        Me.LBTOTAL.Text = "0"
        Me.LBTOTAL.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BTNCARI)
        Me.GroupBox1.Controls.Add(Me.TXTHARGA)
        Me.GroupBox1.Controls.Add(Me.TXTSTATUS)
        Me.GroupBox1.Controls.Add(Me.TXTMENU)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TXTKODE)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(459, 161)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATA MENU"
        '
        'BTNCARI
        '
        Me.BTNCARI.Location = New System.Drawing.Point(328, 35)
        Me.BTNCARI.Name = "BTNCARI"
        Me.BTNCARI.Size = New System.Drawing.Size(101, 20)
        Me.BTNCARI.TabIndex = 10
        Me.BTNCARI.Text = "CARI (F1)"
        Me.BTNCARI.UseVisualStyleBackColor = True
        '
        'TXTHARGA
        '
        Me.TXTHARGA.Location = New System.Drawing.Point(164, 124)
        Me.TXTHARGA.Name = "TXTHARGA"
        Me.TXTHARGA.ReadOnly = True
        Me.TXTHARGA.Size = New System.Drawing.Size(265, 20)
        Me.TXTHARGA.TabIndex = 9
        '
        'TXTSTATUS
        '
        Me.TXTSTATUS.Location = New System.Drawing.Point(164, 96)
        Me.TXTSTATUS.Name = "TXTSTATUS"
        Me.TXTSTATUS.ReadOnly = True
        Me.TXTSTATUS.Size = New System.Drawing.Size(265, 20)
        Me.TXTSTATUS.TabIndex = 8
        '
        'TXTMENU
        '
        Me.TXTMENU.Location = New System.Drawing.Point(164, 66)
        Me.TXTMENU.Name = "TXTMENU"
        Me.TXTMENU.ReadOnly = True
        Me.TXTMENU.Size = New System.Drawing.Size(265, 20)
        Me.TXTMENU.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(61, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "HARGA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "STATUS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "MENU"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "KODE"
        '
        'TXTKODE
        '
        Me.TXTKODE.Location = New System.Drawing.Point(164, 35)
        Me.TXTKODE.Name = "TXTKODE"
        Me.TXTKODE.Size = New System.Drawing.Size(158, 20)
        Me.TXTKODE.TabIndex = 3
        '
        'BTNMINIMIZE
        '
        Me.BTNMINIMIZE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNMINIMIZE.Location = New System.Drawing.Point(969, 3)
        Me.BTNMINIMIZE.Name = "BTNMINIMIZE"
        Me.BTNMINIMIZE.Size = New System.Drawing.Size(59, 30)
        Me.BTNMINIMIZE.TabIndex = 12
        Me.BTNMINIMIZE.Text = "-"
        Me.BTNMINIMIZE.UseVisualStyleBackColor = True
        '
        'PNBAWAH
        '
        Me.PNBAWAH.Controls.Add(Me.BTNBAYAR)
        Me.PNBAWAH.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PNBAWAH.Location = New System.Drawing.Point(0, 506)
        Me.PNBAWAH.Name = "PNBAWAH"
        Me.PNBAWAH.Size = New System.Drawing.Size(1106, 61)
        Me.PNBAWAH.TabIndex = 1
        '
        'BTNBAYAR
        '
        Me.BTNBAYAR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNBAYAR.Location = New System.Drawing.Point(22, 19)
        Me.BTNBAYAR.Name = "BTNBAYAR"
        Me.BTNBAYAR.Size = New System.Drawing.Size(101, 30)
        Me.BTNBAYAR.TabIndex = 11
        Me.BTNBAYAR.Text = "BAYAR (F2)"
        Me.BTNBAYAR.UseVisualStyleBackColor = True
        '
        'DGTAMPIL
        '
        Me.DGTAMPIL.AllowUserToAddRows = False
        Me.DGTAMPIL.AllowUserToDeleteRows = False
        Me.DGTAMPIL.AllowUserToResizeColumns = False
        Me.DGTAMPIL.AllowUserToResizeRows = False
        Me.DGTAMPIL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGTAMPIL.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGTAMPIL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGTAMPIL.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KODE, Me.MENU, Me.STATUS, Me.HARGA, Me.QTY, Me.TOTAL})
        Me.DGTAMPIL.Location = New System.Drawing.Point(0, 212)
        Me.DGTAMPIL.Name = "DGTAMPIL"
        Me.DGTAMPIL.RowHeadersVisible = False
        Me.DGTAMPIL.Size = New System.Drawing.Size(1106, 294)
        Me.DGTAMPIL.TabIndex = 0
        '
        'KODE
        '
        Me.KODE.HeaderText = "KODE"
        Me.KODE.Name = "KODE"
        Me.KODE.ReadOnly = True
        Me.KODE.Width = 150
        '
        'MENU
        '
        Me.MENU.HeaderText = "MENU"
        Me.MENU.Name = "MENU"
        Me.MENU.ReadOnly = True
        Me.MENU.Width = 400
        '
        'STATUS
        '
        Me.STATUS.HeaderText = "STATUS"
        Me.STATUS.Name = "STATUS"
        Me.STATUS.ReadOnly = True
        '
        'HARGA
        '
        Me.HARGA.HeaderText = "HARGA"
        Me.HARGA.Name = "HARGA"
        Me.HARGA.ReadOnly = True
        '
        'QTY
        '
        Me.QTY.HeaderText = "QTY"
        Me.QTY.Name = "QTY"
        Me.QTY.Width = 80
        '
        'TOTAL
        '
        Me.TOTAL.HeaderText = "TOTAL"
        Me.TOTAL.Name = "TOTAL"
        Me.TOTAL.ReadOnly = True
        '
        'PNBAYAR
        '
        Me.PNBAYAR.Controls.Add(Me.GroupBox3)
        Me.PNBAYAR.Location = New System.Drawing.Point(331, 305)
        Me.PNBAYAR.Name = "PNBAYAR"
        Me.PNBAYAR.Size = New System.Drawing.Size(518, 195)
        Me.PNBAYAR.TabIndex = 14
        Me.PNBAYAR.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.BTNTUTUP)
        Me.GroupBox3.Controls.Add(Me.TXTKEMBALIAN)
        Me.GroupBox3.Controls.Add(Me.TXTTUNAI)
        Me.GroupBox3.Controls.Add(Me.TXTBAYAR)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(20, 23)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(476, 150)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "PEMBAYARAN"
        '
        'BTNTUTUP
        '
        Me.BTNTUTUP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNTUTUP.BackColor = System.Drawing.Color.Red
        Me.BTNTUTUP.Location = New System.Drawing.Point(439, 19)
        Me.BTNTUTUP.Name = "BTNTUTUP"
        Me.BTNTUTUP.Size = New System.Drawing.Size(31, 30)
        Me.BTNTUTUP.TabIndex = 15
        Me.BTNTUTUP.Text = "X"
        Me.BTNTUTUP.UseVisualStyleBackColor = False
        '
        'TXTKEMBALIAN
        '
        Me.TXTKEMBALIAN.Location = New System.Drawing.Point(132, 101)
        Me.TXTKEMBALIAN.Name = "TXTKEMBALIAN"
        Me.TXTKEMBALIAN.ReadOnly = True
        Me.TXTKEMBALIAN.Size = New System.Drawing.Size(200, 20)
        Me.TXTKEMBALIAN.TabIndex = 15
        Me.TXTKEMBALIAN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXTTUNAI
        '
        Me.TXTTUNAI.Location = New System.Drawing.Point(132, 68)
        Me.TXTTUNAI.Name = "TXTTUNAI"
        Me.TXTTUNAI.Size = New System.Drawing.Size(200, 20)
        Me.TXTTUNAI.TabIndex = 14
        Me.TXTTUNAI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXTBAYAR
        '
        Me.TXTBAYAR.Location = New System.Drawing.Point(132, 34)
        Me.TXTBAYAR.Name = "TXTBAYAR"
        Me.TXTBAYAR.ReadOnly = True
        Me.TXTBAYAR.Size = New System.Drawing.Size(200, 20)
        Me.TXTBAYAR.TabIndex = 11
        Me.TXTBAYAR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(35, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "KEMMBALIAN"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "TUNAI"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "TOTAL BAYAR"
        '
        'KLIK_KANAN
        '
        Me.KLIK_KANAN.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HAPUSToolStripMenuItem})
        Me.KLIK_KANAN.Name = "KLIK_KANAN"
        Me.KLIK_KANAN.Size = New System.Drawing.Size(113, 26)
        '
        'HAPUSToolStripMenuItem
        '
        Me.HAPUSToolStripMenuItem.Name = "HAPUSToolStripMenuItem"
        Me.HAPUSToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.HAPUSToolStripMenuItem.Text = "HAPUS"
        '
        'NOTA
        '
        '
        'FR_KELUAR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1106, 567)
        Me.Controls.Add(Me.PNBAYAR)
        Me.Controls.Add(Me.PNBAWAH)
        Me.Controls.Add(Me.PNATAS)
        Me.Controls.Add(Me.DGTAMPIL)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "FR_KELUAR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FR_KELUAR"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PNATAS.ResumeLayout(False)
        Me.PNCARI.ResumeLayout(False)
        Me.PNCARI.PerformLayout()
        CType(Me.DGCARI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PNBAWAH.ResumeLayout(False)
        CType(Me.DGTAMPIL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PNBAYAR.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.KLIK_KANAN.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PNATAS As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PNBAWAH As System.Windows.Forms.Panel
    Friend WithEvents DGTAMPIL As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXTKODE As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXTHARGA As System.Windows.Forms.TextBox
    Friend WithEvents TXTSTATUS As System.Windows.Forms.TextBox
    Friend WithEvents TXTMENU As System.Windows.Forms.TextBox
    Friend WithEvents BTNCARI As System.Windows.Forms.Button
    Friend WithEvents LBTOTAL As System.Windows.Forms.Label
    Friend WithEvents BTNBAYAR As System.Windows.Forms.Button
    Friend WithEvents BTNMENU As System.Windows.Forms.Button
    Friend WithEvents BTNMINIMIZE As System.Windows.Forms.Button
    Friend WithEvents PNCARI As System.Windows.Forms.Panel
    Friend WithEvents TXTCARI As System.Windows.Forms.TextBox
    Friend WithEvents BTNKELUAR As System.Windows.Forms.Button
    Friend WithEvents DGCARI As System.Windows.Forms.DataGridView
    Friend WithEvents PNBAYAR As System.Windows.Forms.Panel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TXTKEMBALIAN As System.Windows.Forms.TextBox
    Friend WithEvents TXTTUNAI As System.Windows.Forms.TextBox
    Friend WithEvents TXTBAYAR As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BTNTUTUP As System.Windows.Forms.Button
    Friend WithEvents KLIK_KANAN As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents HAPUSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KODE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MENU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STATUS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HARGA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QTY As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOTA As System.Drawing.Printing.PrintDocument
End Class
