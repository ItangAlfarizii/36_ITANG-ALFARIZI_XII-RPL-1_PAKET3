Imports System.Data.SqlClient
Public Class FR_KELUAR

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGTAMPIL.CellContentClick

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BTNMINIMIZE.Click
        Me.WindowState = FormWindowState.Maximized


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BTNMENU.Click
        Dim FR As New FR_MENU
        FR.Show()
        Me.Hide()

    End Sub

    Private Sub TXTKODE_TextChanged(sender As Object, e As EventArgs) Handles TXTKODE.TextChanged
        Dim STR As String = "SELECT KODE,MENU,STATUS,HARGA_SATUAN FROM TBL_DATA_MENU WHERE RTRIM (KODE) = '" & TXTKODE.Text & "'"
        Dim CMD As New SqlCommand(STR, CONN)
        Dim RD As SqlDataReader
        RD = CMD.ExecuteReader
        If RD.HasRows Then
            RD.Read()
            TXTMENU.Text = RD.Item("MENU").ToString.Trim
            TXTSTATUS.Text = RD.Item("STATUS").ToString.Trim
            TXTHARGA.Text = CInt(RD.Item("HARGA_SATUAN"))
            RD.Close()
            MASUK_DATA()
            TXTKODE.Clear()

        Else
            RD.Close()

        End If
    End Sub


   Sub masuk_data()
        Dim QTY As Integer = 0
        Dim ADA_DATA As Boolean = False
        Dim BARIS_DATA As Integer = 0

        For N = 0 To dgtampil.Rows.Count - 1
            Dim KODE As String = dgtampil.Item("KODE", N).Value
            If KODE = txtkode.Text Then
                ADA_DATA = True
                BARIS_DATA = N
                Exit For
            End If
        Next

        If ADA_DATA = True Then
            dgtampil.Rows(BARIS_DATA).Cells("QTY").Value = dgtampil.Rows(BARIS_DATA).Cells("QTY").Value + 1
            dgtampil.Rows(dgtampil.Rows.Count - 1).Cells("TOTAL").Value = dgtampil.Rows(BARIS_DATA).Cells("QTY").Value * dgtampil.Rows(BARIS_DATA).Cells("HARGA").Value
        Else
            dgtampil.Rows.Add()
            dgtampil.Rows(dgtampil.Rows.Count - 1).Cells("KODE").Value = txtkode.Text
            dgtampil.Rows(dgtampil.Rows.Count - 1).Cells("MENU").Value = txtmenu.Text
            dgtampil.Rows(dgtampil.Rows.Count - 1).Cells("STATUS").Value = txtstatus.Text
            dgtampil.Rows(dgtampil.Rows.Count - 1).Cells("HARGA").Value = txtharga.Text
            dgtampil.Rows(dgtampil.Rows.Count - 1).Cells("QTY").Value = "1"
            dgtampil.Rows(dgtampil.Rows.Count - 1).Cells("TOTAL").Value = txtharga.Text
        End If
        total_harga()

    End Sub

    Private Sub DGTAMPIL_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGTAMPIL.CellEndEdit
        If e.ColumnIndex = 4 Then
            Dim QTY As String = ""
            QTY = DGTAMPIL.Item("QTY", e.RowIndex).Value
            If IsNumeric(QTY) Then
                DGTAMPIL.Item("TOTAL", e.RowIndex).Value = QTY * DGTAMPIL.Item("HARGA", e.RowIndex).Value
                total_harga()

            Else
                MsgBox("NILAI TIDAK VALID..")
                QTY = DGTAMPIL.Item("QTY", e.RowIndex).Value = QTY_LAMA
            End If
        End If
    End Sub

    Dim QTY_LAMA As Integer = 0

    Private Sub DGTAMPIL_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles DGTAMPIL.CellBeginEdit
        If e.ColumnIndex = 4 Then
            QTY_LAMA = DGTAMPIL.Item("QTY", e.RowIndex).Value

        End If
    End Sub

    Sub total_harga()
        Dim TOHARGA As Integer = 0
        For n = 0 To DGTAMPIL.Rows.Count - 1
            TOHARGA = TOHARGA + DGTAMPIL.Item("TOTAL", n).Value

        Next

        LBTOTAL.Text = FormatCurrency(TOHARGA, 0)
    End Sub

    Private Sub BTNCARI_Click(sender As Object, e As EventArgs) Handles BTNCARI.Click
        BUKA_CARI()

    End Sub

    Private Sub TXTCARI_TextChanged(sender As Object, e As EventArgs) Handles TXTCARI.TextChanged
        Dim STR As String = "SELECT TOP 10 RTRIM (KODE) AS KODE,RTRIM (MENU) AS MENU, RTRIM (STATUS) AS STATUS, HARGA_SATUAN FROM TBL_DATA_MENU WHERE MENU LIKE '%" & TXTCARI.Text & "%' "
        Dim DA As New SqlDataAdapter(STR, CONN)
        Dim TBL As New DataTable
        DA.Fill(TBL)
        DGCARI.DataSource = TBL

    End Sub

    Private Sub DGCARI_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGCARI.CellDoubleClick
        TXTKODE.Text = DGCARI.Item("KODE", e.RowIndex).Value
        PNCARI.Visible = False

    End Sub

    Private Sub BTNKELUAR_Click(sender As Object, e As EventArgs) Handles BTNKELUAR.Click
        TUTUP_CARI()


    End Sub


    Private Sub FR_KELUAR_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
                If PNCARI.Visible = False Then
                    BUKA_CARI()
                Else
                    TUTUP_CARI()

                End If
            Case Keys.F2
                BUKA_BAYAR()
                If PNBAYAR.Visible = False Then
                    BUKA_BAYAR()
                Else
                    TUTUP_BAYAR()
                End If
        End Select
    End Sub

    Sub BUKA_CARI()

        PNBAYAR.Visible = False
        PNCARI.Visible = True
        TXTCARI.Clear()
        TXTCARI.Select()
    End Sub

    Sub BUKA_BAYAR()
        If CInt(LBTOTAL.Text) <= 0 Then Exit Sub
        DGTAMPIL.Enabled = False
        PNCARI.Visible = False
        PNBAYAR.Visible = True
        TXTBAYAR.Text = CInt(LBTOTAL.Text)
        TXTTUNAI.Clear()
        TXTTUNAI.Select()


    End Sub

    Sub TUTUP_CARI()
        PNCARI.Visible = False
        TXTKODE.Select()

    End Sub

    Sub TUTUP_BAYAR()
        PNBAYAR.Visible = False
        DGTAMPIL.Enabled = True
        TXTKODE.Select()

    End Sub


    Private Sub BTNBAYAR_Click(sender As Object, e As EventArgs) Handles BTNBAYAR.Click
        BUKA_BAYAR()

    End Sub


    Private Sub BTNTUTUP_Click(sender As Object, e As EventArgs) Handles BTNTUTUP.Click
        TUTUP_BAYAR()

    End Sub

    Private Sub TXTTUNAI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTTUNAI.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If

        If e.KeyChar = Chr(13) Then
            If CInt(TXTKEMBALIAN.Text) >= 0 Then
                MASUK_DATABASE()
            Else
                MsgBox("PEMBAYARAN KURANG ...")

            End If
        End If


    End Sub

    Private Sub TXTTUNAI_TextChanged(sender As Object, e As EventArgs) Handles TXTTUNAI.TextChanged
        If TXTTUNAI.Text = "" Then Exit Sub
        TXTKEMBALIAN.Text = TXTTUNAI.Text - TXTBAYAR.Text
    End Sub

    Private Sub DGTAMPIL_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGTAMPIL.CellMouseClick
        If DGTAMPIL.Rows.Count > 0 AndAlso e.RowIndex > -1 Then
            KLIK_KANAN.Show(Cursor.Position.X, Cursor.Position.Y)

        End If
    End Sub

    Private Sub HAPUSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HAPUSToolStripMenuItem.Click
        For Each ECELL As DataGridViewCell In DGTAMPIL.SelectedCells
            DGTAMPIL.Rows.RemoveAt(ECELL.RowIndex)
        Next
        total_harga()

    End Sub


    Sub MASUK_DATABASE()
        If DGTAMPIL.Rows.Count <= 0 Then Exit Sub
        For Each erow As DataGridViewRow In DGTAMPIL.Rows
            Dim KODE As String = erow.Cells("KODE").Value
            Dim STATUS As String = erow.Cells("STATUS").Value
            Dim JUMLAH As String = erow.Cells("QTY").Value
            Dim HARGA As String = erow.Cells("TOTAL").Value

            Dim STR As String = "INSERT INTO TBL_TRANSAKSI (KODE,JUMLAH,STATUS,HARGA,TGL,KASIR) VALUES ('" & KODE & "', '" & JUMLAH & "', '" & STATUS & "', '" & HARGA & "', '" & Format(Date.Now, "MM/dd/yyyy") & "','" & NIKADMIN & "')"
            Dim CMD As New SqlCommand(STR, CONN)
            CMD.ExecuteNonQuery()

        Next
        PRIN_NOTA()
        TUTUP_BAYAR()
        DGTAMPIL.Rows.Clear()
        total_harga()
        TXTKODE.Select()

    End Sub

    Private Sub NOTA_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles NOTA.PrintPage
        Dim TINGGI As Integer = 10
        e.Graphics.DrawString(NAMA_CAFE, New Drawing.Font("COURIER NEW", 8), Brushes.Black, 2, TINGGI)

        TINGGI = TINGGI + 10
        e.Graphics.DrawString(NO_CAFE, New Drawing.Font("COURIER NEW", 8), Brushes.Black, 2, TINGGI)

        TINGGI = TINGGI + 10
        e.Graphics.DrawString(ALAMAT_CAFE, New Drawing.Font("COURIER NEW", 8), Brushes.Black, 2, TINGGI)

        TINGGI = TINGGI + 10
        e.Graphics.DrawString("------------------------------------", New Drawing.Font("COURIER NEW", 8), Brushes.Black, 2, TINGGI)

        TINGGI = TINGGI + 20
        e.Graphics.DrawString("BARANG" & vbTab & vbTab & "QTY" & vbTab & "TOTAL", New Drawing.Font("COURIER NEW", 8), Brushes.Black, 2, TINGGI)

        TINGGI = TINGGI + 10
        e.Graphics.DrawString("------------------------------------", New Drawing.Font("COURIER NEW", 8), Brushes.Black, 2, TINGGI)


        For Each EROW As DataGridViewRow In DGTAMPIL.Rows
            TINGGI = TINGGI + 10
            e.Graphics.DrawString(EROW.Cells("MENU").Value, New Drawing.Font("COURIER NEW", 8), Brushes.Black, 2, TINGGI)

            TINGGI = TINGGI + 10
            e.Graphics.DrawString(vbTab & vbTab & EROW.Cells("QTY").Value & vbTab & EROW.Cells("TOTAL").Value, New Drawing.Font("COURIER NEW", 8), Brushes.Black, 2, TINGGI)



        Next


        TINGGI = TINGGI + 10
        e.Graphics.DrawString("-------------------------------------", New Drawing.Font("COURIER NEW", 8), Brushes.Black, 2, TINGGI)

        TINGGI = TINGGI + 10
        e.Graphics.DrawString("TOTAL" & vbTab & vbTab & ": " & TXTBAYAR.Text, New Drawing.Font("COURIER NEW", 8), Brushes.Black, 2, TINGGI)

        TINGGI = TINGGI + 10
        e.Graphics.DrawString("TUNAI" & vbTab & vbTab & ": " & TXTTUNAI.Text, New Drawing.Font("COURIER NEW", 8), Brushes.Black, 2, TINGGI)

        TINGGI = TINGGI + 10
        e.Graphics.DrawString("KEMBALI" & vbTab & vbTab & ": " & TXTKEMBALIAN.Text, New Drawing.Font("COURIER NEW", 8), Brushes.Black, 2, TINGGI)

        TINGGI = TINGGI + 10
        e.Graphics.DrawString("--------------------------------------", New Drawing.Font("COURIER NEW", 8), Brushes.Black, 2, TINGGI)

        TINGGI = TINGGI + 10
        e.Graphics.DrawString("TERIMA KASIH ATAS KUNJUNGAN ANDA", New Drawing.Font("COURIER NEW", 8), Brushes.Black, 2, TINGGI)


    End Sub


    Sub PRIN_NOTA()
        NOTA.PrinterSettings.PrinterName = PRINTER_NOTA
        NOTA.Print()

    End Sub

    Private Sub FR_KELUAR_Load(sender As Object, e As EventArgs) Handles Me.Load
        AMBIL_DATA()

    End Sub

    Private Sub BTNTR_Click(sender As Object, e As EventArgs)
        Dim TR As New Fr_trAdmin
        TR.ShowDialog()

    End Sub
End Class