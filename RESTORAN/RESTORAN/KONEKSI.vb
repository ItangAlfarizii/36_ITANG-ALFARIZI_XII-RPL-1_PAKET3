Imports System.Data.SqlClient
Module KONEKSI

    Public CONN As SqlConnection
    Public NAMA_CAFE As String
    Public ALAMAT_CAFE As String
    Public NO_CAFE As String
    Public PRINTER_NOTA As String
    Public NIKADMIN As String


    Public Sub MASUK_DATA(ByVal CAFE As String, ByVal ALAMAT As String, ByVal NO As String, ByVal PRINTS As String)
        Call SaveSetting("CAFE", "SETTING", "NAMA_CAFE", CAFE)
        Call SaveSetting("CAFE", "SETTING", "ALAMAT_CAFE", ALAMAT)
        Call SaveSetting("CAFE", "SETTING", "NO_CAFE", NO)
        Call SaveSetting("CAFE", "SETTING", "PRINTER_NOTA", PRINTS)
        AMBIL_DATA()

    End Sub

    Public Sub AMBIL_DATA()
        NAMA_CAFE = GetSetting("CAFE", "SETTING", "NAMA_CAFE", "")
        ALAMAT_CAFE = GetSetting("CAFE", "SETTING", "ALAMAT_CAFE", "")
        NO_CAFE = GetSetting("CAFE", "SETTING", "NO_CAFE", "")
        PRINTER_NOTA = GetSetting("CAFE", "SETTING", "PRINTER_NOTA", "")

    End Sub



    Public Sub KONEKAN()
        'SERVER=NAMA SERVER;USER ID=USERID;PASSWORD;DATABASE=DATABASE;'
        Dim STR As String = "SERVER=" & My.Settings.SERVER & ";USER ID=" & My.Settings.USER & ";PASSWORD=" & My.Settings.PASSWORD & ";DATABASE=" & My.Settings.DATABASE & ";"
        Try
            CONN = New SqlConnection(STR)
            If CONN.State = ConnectionState.Closed Then
                CONN.Open()
            End If
        Catch ex As Exception
            MsgBox("KONEKSI GAGAL")
            With My.Settings
                .SERVER = ""
                .USER = ""
                .PASSWORD = ""
                .DATABASE = ""
                .Save()
            End With
            End
        End Try
    End Sub


End Module
