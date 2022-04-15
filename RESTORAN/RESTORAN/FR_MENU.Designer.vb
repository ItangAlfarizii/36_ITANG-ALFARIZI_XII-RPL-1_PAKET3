<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FR_MENU
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FR_MENU))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOGOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DATABASEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DATAKARYAWANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DATAMASAKANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HAKAKSESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TRANSAKSIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PESANANKELUARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LAPORANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TENTANGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TXTTGL = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TXTJAM = New System.Windows.Forms.ToolStripLabel()
        Me.PEWAKTU = New System.Windows.Forms.Timer(Me.components)
        Me.DATATRANSAKSIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILEToolStripMenuItem, Me.DATABASEToolStripMenuItem, Me.TRANSAKSIToolStripMenuItem, Me.LAPORANToolStripMenuItem, Me.TENTANGToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(863, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FILEToolStripMenuItem
        '
        Me.FILEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LOGOUTToolStripMenuItem, Me.EXITToolStripMenuItem})
        Me.FILEToolStripMenuItem.Name = "FILEToolStripMenuItem"
        Me.FILEToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.FILEToolStripMenuItem.Text = "FILE"
        '
        'LOGOUTToolStripMenuItem
        '
        Me.LOGOUTToolStripMenuItem.Name = "LOGOUTToolStripMenuItem"
        Me.LOGOUTToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.LOGOUTToolStripMenuItem.Text = "LOGOUT"
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.EXITToolStripMenuItem.Text = "EXIT"
        '
        'DATABASEToolStripMenuItem
        '
        Me.DATABASEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DATAKARYAWANToolStripMenuItem, Me.DATAMASAKANToolStripMenuItem, Me.HAKAKSESToolStripMenuItem})
        Me.DATABASEToolStripMenuItem.Name = "DATABASEToolStripMenuItem"
        Me.DATABASEToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.DATABASEToolStripMenuItem.Text = "DATABASE"
        '
        'DATAKARYAWANToolStripMenuItem
        '
        Me.DATAKARYAWANToolStripMenuItem.Name = "DATAKARYAWANToolStripMenuItem"
        Me.DATAKARYAWANToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.DATAKARYAWANToolStripMenuItem.Text = "DATA KARYAWAN"
        '
        'DATAMASAKANToolStripMenuItem
        '
        Me.DATAMASAKANToolStripMenuItem.Name = "DATAMASAKANToolStripMenuItem"
        Me.DATAMASAKANToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.DATAMASAKANToolStripMenuItem.Text = "DATA MENU"
        '
        'HAKAKSESToolStripMenuItem
        '
        Me.HAKAKSESToolStripMenuItem.Name = "HAKAKSESToolStripMenuItem"
        Me.HAKAKSESToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.HAKAKSESToolStripMenuItem.Text = "HAK AKSES"
        '
        'TRANSAKSIToolStripMenuItem
        '
        Me.TRANSAKSIToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PESANANKELUARToolStripMenuItem, Me.DATATRANSAKSIToolStripMenuItem})
        Me.TRANSAKSIToolStripMenuItem.Name = "TRANSAKSIToolStripMenuItem"
        Me.TRANSAKSIToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.TRANSAKSIToolStripMenuItem.Text = "TRANSAKSI"
        '
        'PESANANKELUARToolStripMenuItem
        '
        Me.PESANANKELUARToolStripMenuItem.Name = "PESANANKELUARToolStripMenuItem"
        Me.PESANANKELUARToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.PESANANKELUARToolStripMenuItem.Text = "PESANAN KELUAR"
        '
        'LAPORANToolStripMenuItem
        '
        Me.LAPORANToolStripMenuItem.Name = "LAPORANToolStripMenuItem"
        Me.LAPORANToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.LAPORANToolStripMenuItem.Text = "LAPORAN"
        '
        'TENTANGToolStripMenuItem
        '
        Me.TENTANGToolStripMenuItem.Name = "TENTANGToolStripMenuItem"
        Me.TENTANGToolStripMenuItem.Size = New System.Drawing.Size(94, 20)
        Me.TENTANGToolStripMenuItem.Text = "PENGATURAN"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator1, Me.TXTTGL, Me.ToolStripSeparator2, Me.TXTJAM})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(863, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'TXTTGL
        '
        Me.TXTTGL.Name = "TXTTGL"
        Me.TXTTGL.Size = New System.Drawing.Size(59, 22)
        Me.TXTTGL.Text = "TANGGAL"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TXTJAM
        '
        Me.TXTJAM.Name = "TXTJAM"
        Me.TXTJAM.Size = New System.Drawing.Size(30, 22)
        Me.TXTJAM.Text = "JAM"
        '
        'PEWAKTU
        '
        '
        'DATATRANSAKSIToolStripMenuItem
        '
        Me.DATATRANSAKSIToolStripMenuItem.Name = "DATATRANSAKSIToolStripMenuItem"
        Me.DATATRANSAKSIToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.DATATRANSAKSIToolStripMenuItem.Text = "DATA TRANSAKSI"
        '
        'FR_MENU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 440)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FR_MENU"
        Me.Text = "MENU UTAMA"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FILEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LOGOUTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DATABASEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DATAKARYAWANToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DATAMASAKANToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TRANSAKSIToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PESANANKELUARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LAPORANToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TENTANGToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TXTTGL As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TXTJAM As System.Windows.Forms.ToolStripLabel
    Friend WithEvents PEWAKTU As System.Windows.Forms.Timer
    Friend WithEvents HAKAKSESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DATATRANSAKSIToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
