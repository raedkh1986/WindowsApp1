Imports Telerik.WinControls.UI

Public Class Frm_Gen_UsersAr
    Private Sub Frm_Gen_UsersAr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        makeconnection()
        Dim da As New SqlClient.SqlDataAdapter("SELECT    isnull(max(User_id),0) + 1 as User_id     FROM          Tbl_gen_Users", con)
        Dim dt As New DataTable
        da.Fill(dt)
        RadTextBox1.Text = dt.Rows(0).Item("User_id")
        Label1.Text = dt.Rows(0).Item("User_id")

        Dim da1 As New SqlClient.SqlDataAdapter("SELECT        User_id, User_nameAr, User_IName, User_Pass, user_lastIntering, User_ExpiryDate, User_IsManager, User_IsPOS, User_IsExpired FROM            Tbl_gen_Users", con)
        Dim dt1 As New DataTable
        da1.Fill(dt1)
        RadGridView1.DataSource = dt1
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        makeconnection()

        Dim da As New SqlClient.SqlDataAdapter("SELECT    isnull(max(User_id),0) + 1 as User_id     FROM          Tbl_gen_Users", con)
        Dim dt As New DataTable
        da.Fill(dt)
        RadTextBox1.Text = dt.Rows(0).Item("User_id")
        Label1.Text = dt.Rows(0).Item("User_id")

        Dim da1 As New SqlClient.SqlDataAdapter("INSERT INTO Tbl_gen_Users                          (User_id, User_nameAr, User_IName, User_Pass, user_lastIntering, User_ExpiryDate, User_IsManager, User_IsPOS, User_IsExpired)  VALUES        (N'" & RadTextBox1.Text & "', N'" & RadTextBox2.Text & "', N'" & RadTextBox3.Text & "', N'" & RadTextBox4.Text & "', N'" & RadTextBox5.Text & "', N'" & RadDateTimePicker1.Text & "', N'" & RadCheckBox1.CheckState & "', N'" & RadCheckBox2.CheckState & "',                           N'" & RadCheckBox3.CheckState & "')  ", con)
        Dim dt1 As New DataTable
        da1.Fill(dt1)
        MsgBox("تم الحفظ")

        Dim da2 As New SqlClient.SqlDataAdapter("SELECT        User_id, User_nameAr, User_IName, User_Pass, user_lastIntering, User_ExpiryDate, User_IsManager, User_IsPOS, User_IsExpired FROM            Tbl_gen_Users", con)
        Dim dt2 As New DataTable
        da2.Fill(dt2)
        RadGridView1.DataSource = dt2
        RadTextBox2.Text = ""
        RadTextBox3.Text = ""
        RadTextBox4.Text = ""
        RadTextBox5.Text = ""
        Dim da3 As New SqlClient.SqlDataAdapter("SELECT    isnull(max(User_id),0) + 1 as User_id     FROM          Tbl_gen_Users", con)
        Dim dt3 As New DataTable
        da3.Fill(dt3)
        RadTextBox1.Text = dt3.Rows(0).Item("User_id")
        Label1.Text = dt3.Rows(0).Item("User_id")
    End Sub

    Private Sub RadButton2_Click(sender As Object, e As EventArgs) Handles RadButton2.Click

        RadTextBox2.Text = ""
        RadTextBox3.Text = ""
        RadTextBox4.Text = ""
        RadTextBox5.Text = ""
        Dim da3 As New SqlClient.SqlDataAdapter("SELECT    isnull(max(User_id),0) + 1 as User_id     FROM          Tbl_gen_Users", con)
        Dim dt3 As New DataTable
        da3.Fill(dt3)
        RadTextBox1.Text = dt3.Rows(0).Item("User_id")
        Label1.Text = dt3.Rows(0).Item("User_id")
        RadButton1.Enabled = True


    End Sub

    Private Sub RadGridView1_Click(sender As Object, e As EventArgs) Handles RadGridView1.Click

    End Sub

    Private Sub RadGridView1_CellDoubleClick(sender As Object, e As GridViewCellEventArgs) Handles RadGridView1.CellDoubleClick
        If e.RowIndex > -1 Then

            RadTextBox1.Text = RadGridView1.CurrentRow.Cells("user_Id").Value
            RadTextBox2.Text = RadGridView1.CurrentRow.Cells("User_nameAr").Value
            RadTextBox3.Text = RadGridView1.CurrentRow.Cells("User_IName").Value
            RadTextBox4.Text = RadGridView1.CurrentRow.Cells("User_Pass").Value
            RadCheckBox1.CheckState = RadGridView1.CurrentRow.Cells("User_IsManager").Value
            RadCheckBox2.CheckState = RadGridView1.CurrentRow.Cells("User_IsPOS").Value
            RadCheckBox3.CheckState = RadGridView1.CurrentRow.Cells("User_IsExpired").Value
            RadDateTimePicker1.Text = RadGridView1.CurrentRow.Cells("User_ExpiryDate").Value

        End If
    End Sub

    Private Sub RadTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RadTextBox1.TextChanged
        If RadTextBox1.Text < Label1.Text Then
            RadButton1.Enabled = False

        End If
    End Sub

    Private Sub RadButton3_Click(sender As Object, e As EventArgs) Handles RadButton3.Click
        makeconnection()
        Dim da1 As New SqlClient.SqlDataAdapter("delete from Tbl_gen_Users where user_id = N'" & RadTextBox1.Text & "'", con)
        Dim dt1 As New DataTable
        da1.Fill(dt1)

        Dim da As New SqlClient.SqlDataAdapter("SELECT    isnull(max(User_id),0) + 1 as User_id     FROM          Tbl_gen_Users", con)
        Dim dt As New DataTable
        da.Fill(dt)
        RadTextBox1.Text = dt.Rows(0).Item("User_id")
        Label1.Text = dt.Rows(0).Item("User_id")

        Dim da4 As New SqlClient.SqlDataAdapter("INSERT INTO Tbl_gen_Users                          (User_id, User_nameAr, User_IName, User_Pass, user_lastIntering, User_ExpiryDate, User_IsManager, User_IsPOS, User_IsExpired)  VALUES        (N'" & RadTextBox1.Text & "', N'" & RadTextBox2.Text & "', N'" & RadTextBox3.Text & "', N'" & RadTextBox4.Text & "', N'" & RadTextBox5.Text & "', N'" & RadDateTimePicker1.Text & "', N'" & RadCheckBox1.CheckState & "', N'" & RadCheckBox2.CheckState & "',                           N'" & RadCheckBox3.CheckState & "')  ", con)
        Dim dt4 As New DataTable
        da4.Fill(dt4)
        MsgBox("تم التعديل")

        Dim da2 As New SqlClient.SqlDataAdapter("SELECT        User_id, User_nameAr, User_IName, User_Pass, user_lastIntering, User_ExpiryDate, User_IsManager, User_IsPOS, User_IsExpired FROM            Tbl_gen_Users", con)
        Dim dt2 As New DataTable
        da2.Fill(dt2)
        RadGridView1.DataSource = dt2
        RadTextBox2.Text = ""
        RadTextBox3.Text = ""
        RadTextBox4.Text = ""
        RadTextBox5.Text = ""
        Dim da3 As New SqlClient.SqlDataAdapter("SELECT    isnull(max(User_id),0) + 1 as User_id     FROM          Tbl_gen_Users", con)
        Dim dt3 As New DataTable
        da3.Fill(dt3)
        RadTextBox1.Text = dt3.Rows(0).Item("User_id")
        Label1.Text = dt3.Rows(0).Item("User_id")
    End Sub
End Class