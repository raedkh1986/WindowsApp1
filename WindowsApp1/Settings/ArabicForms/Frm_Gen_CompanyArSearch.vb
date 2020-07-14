Imports Telerik.WinControls.UI

Public Class Frm_Gen_CompanyArSearch
    Private Sub Frm_Gen_CompanyArSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        makeconnection()

        Dim da As New SqlClient.SqlDataAdapter("SELECT    Company_Id,Company_NameAr     FROM          Tbl_Gen_Company", con)
        Dim dt As New DataTable
        da.Fill(dt)
        RadGridView1.DataSource = dt

    End Sub

    Private Sub RadGridView1_Click(sender As Object, e As EventArgs) Handles RadGridView1.Click

    End Sub

    Private Sub RadGridView1_CellDoubleClick(sender As Object, e As GridViewCellEventArgs) Handles RadGridView1.CellDoubleClick
        If e.RowIndex > -1 Then

            Frm_Gen_CompanyAr.RadTextBox1.Text = RadGridView1.CurrentRow.Cells("Company_Id").Value

        End If
        Me.Close()

    End Sub
End Class