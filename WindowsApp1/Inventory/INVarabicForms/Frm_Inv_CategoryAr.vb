Public Class Frm_Inv_CategoryAr
    Private Sub Frm_Inv_CategoryAr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        makeconnection()
        Dim da As New SqlClient.SqlDataAdapter("SELECT    isnull(max(Cat_Id),0) + 1 as Cat_Id     FROM          Tbl_Inv_Category", con)
        Dim dt As New DataTable
        da.Fill(dt)
        UserControl11.RadTextBox1.Text = dt.Rows(0).Item("Cat_Id")


    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        makeconnection()
        Dim da As New SqlClient.SqlDataAdapter("INSERT        INTO              Tbl_Inv_Category(Cat_Id, Cat_NameAr, Cat_NameEn, Cat_Status)  VALUES        (N'" & UserControl11.RadTextBox1.Text & "', N'" & UserControl11.RadTextBox2.Text & "', N'" & UserControl11.RadTextBox3.Text & "', N'" & UserControl11.ComboBox1.SelectedIndex & "')  ", con)
        Dim dt As New DataTable
        da.Fill(dt)
        MsgBox("تم الحفظ بنجاح")
        UserControl11.RadTextBox1.Text = UserControl11.RadTextBox1.Text + 1
        UserControl11.RadTextBox3.Text = ""
        UserControl11.RadTextBox2.Text = ""
    End Sub
End Class