Imports System.Drawing.Printing

Public Class FR_PENGATURAN

    Sub ISI_LIST_PRINTER()
        CBPRINTER.Items.Clear()
        For Each NAMA_PRINTER As String In PrinterSettings.InstalledPrinters
            CBPRINTER.Items.Add(NAMA_PRINTER)
        Next
    End Sub


    Private Sub FR_PENGATURAN_Load(sender As Object, e As EventArgs) Handles Me.Load
        ISI_LIST_PRINTER()
        AMBIL_DATA()
        TXTCAFE.Text = NAMA_CAFE
        TXTALAMAT.Text = ALAMAT_CAFE
        TXTNO.Text = NO_CAFE
        CBPRINTER.Text = PRINTER_NOTA

    End Sub

    Private Sub BTNSIMPAN_Click(sender As Object, e As EventArgs) Handles BTNSIMPAN.Click
        MASUK_DATA(TXTCAFE.Text, TXTALAMAT.Text, TXTNO.Text, CBPRINTER.Text)
        MsgBox("DATA SUDAH TERSIMPAN...")


    End Sub
End Class