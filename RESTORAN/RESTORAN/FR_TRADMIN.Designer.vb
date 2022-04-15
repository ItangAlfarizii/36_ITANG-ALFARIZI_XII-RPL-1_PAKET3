<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fr_trAdmin
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
        Me.DGTAMPIL = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTNIK = New System.Windows.Forms.TextBox()
        Me.TXTNAMA = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DTTGL = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTJUMLAH = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DGTAMPIL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGTAMPIL
        '
        Me.DGTAMPIL.AllowUserToAddRows = False
        Me.DGTAMPIL.AllowUserToDeleteRows = False
        Me.DGTAMPIL.AllowUserToOrderColumns = True
        Me.DGTAMPIL.AllowUserToResizeColumns = False
        Me.DGTAMPIL.AllowUserToResizeRows = False
        Me.DGTAMPIL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGTAMPIL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGTAMPIL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGTAMPIL.Location = New System.Drawing.Point(12, 118)
        Me.DGTAMPIL.Name = "DGTAMPIL"
        Me.DGTAMPIL.RowHeadersVisible = False
        Me.DGTAMPIL.Size = New System.Drawing.Size(829, 328)
        Me.DGTAMPIL.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NIK"
        '
        'TXTNIK
        '
        Me.TXTNIK.Enabled = False
        Me.TXTNIK.Location = New System.Drawing.Point(88, 6)
        Me.TXTNIK.Name = "TXTNIK"
        Me.TXTNIK.Size = New System.Drawing.Size(150, 20)
        Me.TXTNIK.TabIndex = 2
        '
        'TXTNAMA
        '
        Me.TXTNAMA.Enabled = False
        Me.TXTNAMA.Location = New System.Drawing.Point(88, 32)
        Me.TXTNAMA.Name = "TXTNAMA"
        Me.TXTNAMA.Size = New System.Drawing.Size(344, 20)
        Me.TXTNAMA.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "NAMA"
        '
        'DTTGL
        '
        Me.DTTGL.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTTGL.Location = New System.Drawing.Point(88, 58)
        Me.DTTGL.Name = "DTTGL"
        Me.DTTGL.Size = New System.Drawing.Size(107, 20)
        Me.DTTGL.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "TANGGAL"
        '
        'TXTJUMLAH
        '
        Me.TXTJUMLAH.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTJUMLAH.Enabled = False
        Me.TXTJUMLAH.Location = New System.Drawing.Point(691, 454)
        Me.TXTJUMLAH.Name = "TXTJUMLAH"
        Me.TXTJUMLAH.Size = New System.Drawing.Size(150, 20)
        Me.TXTJUMLAH.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(557, 461)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "JUMLAH TRANSAKSI"
        '
        'FR_TRADMIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(853, 486)
        Me.Controls.Add(Me.TXTJUMLAH)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DTTGL)
        Me.Controls.Add(Me.TXTNAMA)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXTNIK)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGTAMPIL)
        Me.Name = "FR_TRADMIN"
        Me.Text = "FR_TRADMIN"
        CType(Me.DGTAMPIL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGTAMPIL As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXTNIK As System.Windows.Forms.TextBox
    Friend WithEvents TXTNAMA As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DTTGL As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TXTJUMLAH As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
