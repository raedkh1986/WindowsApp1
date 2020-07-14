Imports Telerik.WinControls.UI

Public Class Frm_Inv_ItemSreachAr
    Private Sub Frm_Inv_ItemSreachAr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        makeconnection()

        Dim da As New SqlClient.SqlDataAdapter("SELECT Item_id ,Item_NameAr,Item_BarCode from Tbl_Inv_Items ", con)
        Dim dt As New DataTable
        da.Fill(dt)
        RadGridView1.DataSource = dt

    End Sub

    Private Sub RadGridView1_Click(sender As Object, e As EventArgs) Handles RadGridView1.Click

    End Sub

    Private Sub RadGridView1_CellDoubleClick(sender As Object, e As GridViewCellEventArgs) Handles RadGridView1.CellDoubleClick
        If e.RowIndex > -1 Then

            Frm_Inv_UpdatePriceAr.RadTextBox1.Text = RadGridView1.CurrentRow.Cells("Item_id").Value

        End If
        Me.Close()
    End Sub
End Class