Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try


            makeconnection()
            Dim da As New SqlClient.SqlDataAdapter("SELECT         User_id  FROM            Tbl_gen_Users  WHERE        (User_IName = N'" & RadTextBox1.Text & "')", con)
            Dim dt As New DataTable
            da.Fill(dt)

            Label1.Text = dt.Rows(0).Item("User_id")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        Frm_Gen_MainAr.Show()

    End Sub

    Private Sub RadTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RadTextBox1.TextChanged
        Try

            makeconnection()
            Dim da As New SqlClient.SqlDataAdapter("SELECT         User_id  FROM            Tbl_gen_Users  WHERE        (User_IName = N'" & RadTextBox1.Text & "')", con)
            Dim dt As New DataTable
            da.Fill(dt)
            Label1.Text = dt.Rows(0).Item("User_id")
        Catch ex As Exception

        End Try
    End Sub
End Class
