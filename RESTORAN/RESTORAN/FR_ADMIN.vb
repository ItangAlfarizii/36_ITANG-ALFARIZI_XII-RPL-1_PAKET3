Imports System.Data.SqlClient
Public Class FR_ADMIN

    Private Sub BTNSIMPAN_Click(sender As Object, e As EventArgs) Handles BTNSIMPAN.Click
        If TXTUSER.Text = "" Or TXTPASS.Text = "" Or TXTPASS.Text = "" Then
            MsgBox("DATA TIDAK LENGKAP...")
        ElseIf TXTPASS.Text <> TXTPASS2.Text Then
            MsgBox("LANGI PENULISAN PASSWORD")
        Else
            Dim STR As String = ""
            STR = "SELECT NIK FROM TBL_ADMIN WHERE NIK = '" & LBNIK.Text & "' "
            Dim cmd As SqlCommand
            Dim rd As SqlDataReader
            cmd = New SqlCommand(STR, CONN)
            rd = cmd.ExecuteReader
            If rd.HasRows Then
                rd.Close()
                cmd = New SqlCommand("update tbl_admin set username'" & TXTUSER.Text & "', password ='" & TXTPASS2.Text & "', type='" & CBTYPE.Text & "' where rtrim(nik)='" & LBNIK.Text & "'", CONN)
                cmd.ExecuteNonQuery()
            Else
                rd.Close()
                cmd = New SqlCommand("insert into tbl_admin values ('" & LBNIK.Text & "','" & TXTUSER.Text & "','" & TXTPASS2.Text & "','" & CBTYPE.Text & "')", CONN)
                cmd.ExecuteNonQuery()
            End If
            MsgBox("DATA TERSIMPAN...")
        End If
    End Sub
End Class