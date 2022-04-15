Imports System.Data.SqlClient
Public Class FR_LAPORAN
    Dim TBL As New DataTable
    Dim TBL2 As New DataTable
    Sub TAMPIL()

        Dim STR As String = "SELECT TGL,KODE,(SELECT RTRIM (MENU) FROM TBL_DATA_MENU WHERE KODE=TBL_TRANSAKSI.KODE ) AS MENU, JUMLAH,HARGA FROM TBL_TRANSAKSI WHERE STATUS = TBL_TRANSAKSI.STATUS AND TGL >= '" & Format(TGLMULAI.Value, "MM/dd/yyyy") & "' AND TGL <= '" & Format(TGLSAMPAI.Value, "MM/dd/yyyy") & "' "

        Dim DA As New SqlDataAdapter(STR, CONN)
        TBL.Clear()
        DA.Fill(TBL)
        DGTAMPIL.DataSource = TBL
        DGTAMPIL.Columns("HARGA").DefaultCellStyle.Format = "N0"
        DGTAMPIL.Columns("HARGA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub




    Private Sub BTNTAMPIL_Click(sender As Object, e As EventArgs) Handles BTNTAMPIL.Click
        TAMPIL()

    End Sub

    Private Sub BTNCETAK_Click(sender As Object, e As EventArgs) Handles BTNCETAK.Click
        If DGTAMPIL.Rows.Count > 0 Then
            Dim RPT As New RPT_MASUK
            With RPT
                .SetDataSource(TBL)
                .SetParameterValue("TGL_MULAI", TGLMULAI.Value)
                .SetParameterValue("TGL_SAMPAI", TGLSAMPAI.Value)
            End With


            Dim FR As New FR_PRIVIEW
            With FR
                .CRV.ReportSource = RPT
                .ShowDialog()

            End With
        End If
    End Sub

    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str As String = "SELECT TBL_ADMIN.USERNAME AS NAMA, TBL_TRANSAKSI.TGL, TBL_TRANSAKSI.KODE, TBL_DATA_MENU.MENU, TBL_TRANSAKSI.JUMLAH, TBL_TRANSAKSI.HARGA FROM TBL_ADMIN INNER JOIN TBL_TRANSAKSI ON TBL_ADMIN.NIK = TBL_TRANSAKSI.KASIR INNER JOIN TBL_DATA_MENU ON TBL_TRANSAKSI.KODE = TBL_DATA_MENU.KODE WHERE USERNAME LIKE '%" & txtnama.Text & "%'"
        Dim da As New SqlDataAdapter(str, CONN)
        TBL2.Clear()
        da.Fill(TBL2)
        DGTAMPIL.DataSource = TBL2
    End Sub
End Class