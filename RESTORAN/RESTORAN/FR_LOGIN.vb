Imports System.Data.SqlClient
Public Class FR_LOGIN


    Private Sub BTNKELUAR_Click(sender As Object, e As EventArgs) Handles BTNKELUAR.Click
        End
    End Sub

    Private Sub BTNMASUK_Click(sender As Object, e As EventArgs) Handles BTNMASUK.Click
        If TXTUSER.Text = "" Then
            MsgBox("USER KOSONG..")
        ElseIf TXTPASSWORD.Text = "" Then
            MsgBox("PASSWORD KOSONG..")
        Else
            Dim cmd As SqlCommand
            cmd = New SqlCommand("select * from tbl_admin", CONN)
            Dim rd As SqlDataReader
            rd = cmd.ExecuteReader
            If rd.HasRows Then
                rd.Close()
                cmd = New SqlCommand("select * from tbl_admin where rtrim (username)='" & TXTUSER.Text & "' ", CONN)
                rd = cmd.ExecuteReader
                If rd.HasRows Then
                    rd.Read()
                    NIKADMIN = rd.Item("NIK").ToString.Trim
                    Dim pwd As String = rd.Item("password").ToString.Trim
                    rd.Close()

                    If TXTPASSWORD.Text = pwd Then

                        Dim fr As New FR_MENU
                        fr.Show()
                        Me.Hide()
                    Else
                        MsgBox("PASSWORD SALAH...")
                    End If
                Else
                    rd.Close()
                    MsgBox("USER TIDAK DITEMUKAN...")
                End If
            Else
                If TXTUSER.Text = "USER" And TXTPASSWORD.Text = "123" Then
                    NIKADMIN = "SUPERUSER"
                    Dim fr As New FR_MENU
                    fr.Show()
                    Me.Hide()
                Else
                    MsgBox("PASSWORD ATAU USERNAME SALAH..")
                End If
            End If
        End If

    End Sub


    Private Sub FR_LOGIN_Load(sender As Object, e As EventArgs) Handles Me.Load
        If My.Settings.SERVER = "" Or My.Settings.USER = "" Or My.Settings.PASSWORD = "" Or My.Settings.DATABASE = "" Then
            MsgBox("DATABASE BELUM DI SETTING..")
            Dim FR As New FR_KONEKSI
            FR.ShowDialog()
        Else
            KONEKAN()

        End If
    End Sub

    Private Sub TXTUSER_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTUSER.KeyPress
        If e.KeyChar = Chr(13) Then
            TXTPASSWORD.Select()
        End If
    End Sub

    Private Sub TXTPASSWORD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTPASSWORD.KeyPress
        If e.KeyChar = Chr(13) Then
            BTNMASUK.Select()
        End If
    End Sub
End Class