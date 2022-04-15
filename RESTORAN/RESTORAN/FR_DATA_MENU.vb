Imports System.Data.SqlClient
Public Class FR_DATA_MENU

    Private Sub TXTHARGA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTHARGA.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If

        If e.KeyChar = Chr(13) Then
            BTNSIMPAN.Select()
        End If
    End Sub

    Sub TAMPIL()
        Dim STR As String = "SELECT RTRIM(KODE) AS KODE,RTRIM(MENU) AS MENU," &
            " RTRIM(STATUS) AS STATUS,HARGA_SATUAN FROM TBL_DATA_MENU WHERE MENU LIKE '%" & TXTCARI.Text & "%'"
        Dim DA As SqlDataAdapter
        DA = New SqlDataAdapter(STR, CONN)
        Dim TBL As New DataTable
        DA.Fill(TBL)
        DGTAMMPIL.DataSource = TBL
        DGTAMMPIL.Columns("HARGA_SATUAN").DefaultCellStyle.Format = "N0"
    End Sub

    Private Sub FR_DATA_MENU_Load(sender As Object, e As EventArgs) Handles Me.Load
        TAMPIL()

    End Sub

    Private Sub TXTKODE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTKODE.KeyPress
        If e.KeyChar = Chr(13) Then
            TXTMENU.Select()

        End If
    End Sub

    Private Sub TXTMENU_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTMENU.KeyPress
        If e.KeyChar = Chr(13) Then
            CBSTATUS.Select()
        End If
    End Sub

    Private Sub CBSTATUS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CBSTATUS.KeyPress
        If e.KeyChar = Chr(13) Then
            TXTHARGA.Select()
        End If
    End Sub

    Private Sub TXTKODE_TextChanged(sender As Object, e As EventArgs) Handles TXTKODE.TextChanged
        Dim str As String = "SELECT * FROM TBL_DATA_MENU WHERE RTRIM(KODE) = '" & TXTKODE.Text & "'"
        Dim CMD As New SqlCommand(str, CONN)
        Dim RD As SqlDataReader
        RD = CMD.ExecuteReader
        If RD.HasRows Then
            RD.Read()
            TXTMENU.Text = RD.Item("MENU").ToString.Trim
            CBSTATUS.Text = RD.Item("STATUS").ToString.Trim
            TXTHARGA.Text = CInt(RD.Item("HARGA_SATUAN"))
            RD.Close()
        Else
            RD.Close()
            TXTMENU.Clear()
            TXTHARGA.Clear()

        End If
        RD.Close()

    End Sub

    Private Sub BTNSIMPAN_Click(sender As Object, e As EventArgs) Handles BTNSIMPAN.Click
        If TXTKODE.Text = "" Or TXTMENU.Text = "" Then
            MsgBox("DATA TIDAK LENGKAP..")
        Else
            Dim STR As String
            STR = "SELECT * FROM TBL_DATA_MENU WHERE RTRIM(KODE) = '" & TXTKODE.Text & "'"
            Dim CMD As SqlCommand
            CMD = New SqlCommand(STR, CONN)
            Dim RD As SqlDataReader
            RD = CMD.ExecuteReader
            If RD.HasRows Then
                RD.Close()
                STR = "UPDATE TBL_DATA_MENU SET MENU  = '" & TXTMENU.Text & "', STATUS = '" & CBSTATUS.Text & "', HARGA_SATUAN = '" & TXTHARGA.Text & "' WHERE RTRIM (KODE) = '" & TXTKODE.Text & "' "
            Else
                RD.Close()
                STR = "INSERT INTO TBL_DATA_MENU VALUES ('" & TXTKODE.Text & "', '" & TXTMENU.Text & "', '" & CBSTATUS.Text & "', '" & TXTHARGA.Text & "') "
            End If
            RD.Close()
            CMD = New SqlCommand(STR, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("DATA TERSIPAN..")
            TAMPIL()

        End If
    End Sub

    Private Sub DGTAMMPIL_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGTAMMPIL.CellClick
        On Error Resume Next
        TXTKODE.Text = DGTAMMPIL.Item("KODE", e.RowIndex).Value
    End Sub

    Private Sub TXTCARI_TextChanged(sender As Object, e As EventArgs) Handles TXTCARI.TextChanged
        TAMPIL()

    End Sub

    Private Sub HAPUSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HAPUSToolStripMenuItem.Click
        Dim STR As String = "DELETE FROM TBL_DATA_MENU WHERE RTRIM (KODE) = '" & DGTAMMPIL.Item("KODE", DGTAMMPIL.CurrentRow.Index).Value & "'"
        If MsgBox("YAKIN MENGHAPUS ...???", vbYesNo) = vbYes Then
            Dim CMD As New SqlCommand(STR, CONN)
            CMD.ExecuteNonQuery()
            TAMPIL()

        End If
    End Sub
End Class