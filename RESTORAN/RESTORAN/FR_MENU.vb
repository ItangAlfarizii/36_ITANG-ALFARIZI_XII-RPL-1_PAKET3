Imports System.Data.SqlClient
Public Class FR_MENU

    Private Sub LOGOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGOUTToolStripMenuItem.Click
        Dim FR As New FR_LOGIN
        FR.Show()
        Me.Close()
    End Sub

    Sub BUKA_FORM(ByVal FR As Form)
        For Each F As Form In Me.MdiChildren
            MsgBox("FORM SUDAH TERBUKA")
            Exit Sub
        Next
        FR.MdiParent = Me
        FR.Show()
    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        End
    End Sub

    Private Sub DATAKARYAWANToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DATAKARYAWANToolStripMenuItem.Click
        BUKA_FORM(FR_KARYAWAN)
    End Sub


    Private Sub DATAMASAKANToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DATAMASAKANToolStripMenuItem.Click
        BUKA_FORM(FR_DATA_MENU)
    End Sub

    Private Sub PESANANMASUKToolStripMenuItem_Click(sender As Object, e As EventArgs)
        BUKA_FORM(FR_MASUK)
    End Sub

    Private Sub PESANANKELUARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PESANANKELUARToolStripMenuItem.Click
        Dim FR As New FR_KELUAR
        FR.Show()
        Me.Hide()

    End Sub

   

    Private Sub FR_MENU_Load(sender As Object, e As EventArgs) Handles Me.Load
        TXTTGL.Text = FormatDateTime(Date.Now, DateFormat.LongDate)
        TXTJAM.Text = TimeOfDay
        PEWAKTU.Enabled = True

        data_menu()
        If NIKADMIN = "SUPERUSER" Then
            Exit Sub

        End If

        Dim CMD As New SqlCommand("SELECT TYPE FROM TBL_ADMIN WHERE RTRIM (NIK)='" & NIKADMIN & "' ", CONN)
        Dim RD As SqlDataReader
        RD = CMD.ExecuteReader
        If RD.HasRows Then
            RD.Read()
            Dim ADM As String = RD.Item("TYPE").ToString.Trim
            RD.Close()

            If ADM = "" Then
                Exit Sub
            End If
        End If
        setAkses(NIKADMIN)

    End Sub

    Private Sub PEWAKTU_Tick(sender As Object, e As EventArgs) Handles PEWAKTU.Tick
        TXTTGL.Text = FormatDateTime(Date.Now, DateFormat.LongDate)
        TXTJAM.Text = TimeOfDay
    End Sub


    Private Sub LAPORANToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LAPORANToolStripMenuItem.Click
        BUKA_FORM(FR_LAPORAN)


    End Sub

    Private Sub TENTANGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TENTANGToolStripMenuItem.Click
        BUKA_FORM(FR_PENGATURAN)
    End Sub

    Sub data_menu()
        Dim cmd As SqlCommand
        cmd = New SqlCommand("delete from tbl_menu", CONN)
        cmd.ExecuteNonQuery()



        For Each menu1 As ToolStripMenuItem In MenuStrip1.Items
            cmd = New SqlCommand("insert into tbl_menu values ('" & menu1.Name & "','" & menu1.Text & "')", CONN)
            cmd.ExecuteNonQuery()
            For Each menu2 In menu1.DropDownItems
                If TypeOf menu2 Is ToolStripSeparator Then Continue For
                cmd = New SqlCommand("insert into tbl_menu values ('" & menu2.Name & "','" & menu2.Text & "')", CONN)
                cmd.ExecuteNonQuery()
                For Each menu3 In menu2.DropDownItems
                    If TypeOf menu3 Is ToolStripSeparator Then Continue For
                    cmd = New SqlCommand("insert into tbl_menu values ('" & menu3.Name & "','" & menu3.Text & "')", CONN)
                    cmd.ExecuteNonQuery()
                    For Each menu4 In menu3.DropDownItems
                        If TypeOf menu4 Is ToolStripSeparator Then Continue For
                        cmd = New SqlCommand("insert into tbl_menu values ('" & menu4.Name & "','" & menu4.Text & "')", CONN)
                        cmd.ExecuteNonQuery()
                        For Each menu5 In menu4.DropDownItems
                            If TypeOf menu5 Is ToolStripSeparator Then Continue For
                            cmd = New SqlCommand("insert into tbl_menu values ('" & menu5.Name & "','" & menu5.Text & "')", CONN)
                            cmd.ExecuteNonQuery()
                        Next
                    Next
                Next
            Next
        Next

        For Each menu As ToolStripItem In ToolStrip1.Items
            If TypeOf menu Is ToolStripSeparator Then Continue For
            cmd = New SqlCommand("insert into TBL_MENU values ('" & menu.Name & "','" & menu.Text & "')", CONN)
            cmd.ExecuteNonQuery()
        Next

        cmd = New SqlCommand(" DELETE FROM TBL_HAKAKSES WHERE id_menu NOT IN (SELECT id_menu FROM_TBL_MENU)", CONN)
        cmd.ExecuteNonQuery()


    End Sub

    Private Sub HAKAKSESToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles HAKAKSESToolStripMenuItem.Click
        BUKA_FORM(FR_HAKAKSES)
    End Sub

    Sub setAkses(ByVal nik As String)
        'jika ada menu baru dengan default Disabled
        Dim tbl_temp As New DataTable
        Dim da As SqlDataAdapter
        da = New SqlDataAdapter("select rtrim(nik) as  nik from tbl_admin", CONN)
        da.Fill(tbl_temp)

        For N = 0 To tbl_temp.Rows.Count - 1
            Dim ADM As String = tbl_temp.Rows(N).Item("nik").ToString()
            Dim cmd As SqlCommand
            cmd = New SqlCommand("insert into tbl_hakakses select '" & ADM & "' as NIK,ID_MENU,'TIDAK AKTIF' AS STATUS from tbl_menu where ID_MENU not in (select ID_MENU from tbl_hakakses where rtrim(nik)='" & ADM & "')", CONN)
            cmd.ExecuteNonQuery()
        Next

        Dim tbl As New DataTable
        da = New SqlDataAdapter("select rtrim(id_menu) as id_menu,rtrim(status) as status from tbl_hakakses where rtrim(nik)='" & nik & "'", CONN)
        da.Fill(tbl)

        If tbl.Rows.Count <= 0 Then
            MenuStrip1.Visible = False
            ToolStrip1.Visible = False
            Exit Sub
        End If

        'set untuk menu strip
        Dim findRow() As DataRow = Nothing
        For Each menu1 As ToolStripMenuItem In MenuStrip1.Items
            findRow = tbl.Select("id_menu='" & menu1.Name & "'")
            menu1.Visible = IIf(findRow(0).Item("status").ToString = "AKTIF", True, False)
            For Each menu2 In menu1.DropDownItems
                If TypeOf menu2 Is ToolStripSeparator Then Continue For
                findRow = tbl.Select("id_menu='" & menu2.Name & "'")
                menu2.Visible = IIf(findRow(0).Item("status").ToString = "AKTIF", True, False)
                For Each menu3 In menu2.DropDownItems
                    If TypeOf menu3 Is ToolStripSeparator Then Continue For
                    findRow = tbl.Select("id_menu='" & menu3.Name & "'")
                    menu3.Visible = IIf(findRow(0).Item("status").ToString = "AKTIF", True, False)
                    For Each menu4 In menu2.DropDownItems
                        If TypeOf menu4 Is ToolStripSeparator Then Continue For
                        findRow = tbl.Select("id_menu='" & menu4.Name & "'")
                        menu4.Visible = IIf(findRow(0).Item("status").ToString = "AKTIF", True, False)
                        For Each menu5 In menu2.DropDownItems
                            If TypeOf menu5 Is ToolStripSeparator Then Continue For
                            findRow = tbl.Select("id_menu='" & menu5.Name & "'")
                            menu5.Visible = IIf(findRow(0).Item("status").ToString = "AKTIF", True, False)
                        Next
                    Next
                Next
            Next
        Next

        'set untuk toolstrip
        For Each MenuItem As ToolStripItem In ToolStrip1.Items
            findRow = tbl.Select("id_menu='" & MenuItem.Name & "'")
            If findRow.Length > 0 Then MenuItem.Visible = IIf(findRow(0).Item("status").ToString = "AKTIF", True, False)
        Next


    End Sub

  
    Private Sub DATATRANSAKSIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DATATRANSAKSIToolStripMenuItem.Click
        BUKA_FORM(Fr_trAdmin)
    End Sub
End Class

