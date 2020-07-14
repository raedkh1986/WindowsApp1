Public Class Frm_Inv_TaxsAr
    Private Sub Frm_Inv_TaxsAr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        makeconnection()
        Dim da As New SqlClient.SqlDataAdapter("SELECT    isnull(max(Tax_Id),0) + 1 as Tax_Id     FROM          Tbl_Inv_Taxs", con)
        Dim dt As New DataTable
        da.Fill(dt)
        UserControl11.RadTextBox1.Text = dt.Rows(0).Item("Tax_Id")


    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        makeconnection()
        Dim da As New SqlClient.SqlDataAdapter("INSERT        INTO              Tbl_Inv_Taxs(Tax_Id, Tax_NameAr, Tax_NameEn, Tax_Status,Tax_Percentage)  VALUES        (N'" & UserControl11.RadTextBox1.Text & "', N'" & UserControl11.RadTextBox2.Text & "', N'" & UserControl11.RadTextBox3.Text & "', N'" & UserControl11.ComboBox1.SelectedIndex & "', N'" & RadTextBox1.Text & "')  ", con)
        Dim dt As New DataTable
        da.Fill(dt)
        MsgBox("تم الحفظ بنجاح")
        UserControl11.RadTextBox1.Text = UserControl11.RadTextBox1.Text + 1
        UserControl11.RadTextBox3.Text = ""
        UserControl11.RadTextBox2.Text = ""
        RadTextBox1.Text = ""
    End Sub
End Class