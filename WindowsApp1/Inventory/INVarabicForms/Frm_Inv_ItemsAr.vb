Imports Telerik.WinControls.UI

Public Class Frm_Inv_ItemsAr
    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        Frm_Inv_NewItemAr.Show()

    End Sub
    Private Sub Frm_Inv_ItemsAr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        makeconnection()

        Dim da As New SqlClient.SqlDataAdapter("SELECT        Tbl_Inv_Items.Item_id, Tbl_Inv_Items.Item_NameAr, Tbl_Inv_Items.Item_Cost, Tbl_Inv_Items.Item_Price, Tbl_Inv_Items.Item_Profit, Tbl_Inv_Items.Item_BarCode, Tbl_Inv_Units.Unit_NameAr, Tbl_Inv_Taxs.Tax_NameAr,                            Tbl_Inv_Spplier.Sup_NameAr, Tbl_Inv_Groups.Fam_NameAr  FROM            Tbl_Inv_Items INNER JOIN                           Tbl_Inv_Units ON Tbl_Inv_Items.Unit_id = Tbl_Inv_Units.Unit_Id INNER JOIN                           Tbl_Inv_Taxs ON Tbl_Inv_Items.Tax_id = Tbl_Inv_Taxs.Tax_Id INNER JOIN                           Tbl_Inv_Spplier ON Tbl_Inv_Items.Sup_id = Tbl_Inv_Spplier.Sup_Id INNER JOIN                           Tbl_Inv_Groups ON Tbl_Inv_Items.Fam_id = Tbl_Inv_Groups.Fam_Id INNER JOIN                           Tbl_Inv_Category ON Tbl_Inv_Items.Cat_id = Tbl_Inv_Category.Cat_Id  ", con)
        Dim dt As New DataTable
        da.Fill(dt)
        RadGridView1.DataSource = dt

    End Sub

    Private Sub RadButton3_Click(sender As Object, e As EventArgs) Handles RadButton3.Click
        makeconnection()

        Dim da As New SqlClient.SqlDataAdapter("SELECT        Tbl_Inv_Items.Item_id, Tbl_Inv_Items.Item_NameAr, Tbl_Inv_Items.Item_Cost, Tbl_Inv_Items.Item_Price, Tbl_Inv_Items.Item_Profit, Tbl_Inv_Items.Item_BarCode, Tbl_Inv_Units.Unit_NameAr, Tbl_Inv_Taxs.Tax_NameAr,                            Tbl_Inv_Spplier.Sup_NameAr, Tbl_Inv_Groups.Fam_NameAr  FROM            Tbl_Inv_Items INNER JOIN                           Tbl_Inv_Units ON Tbl_Inv_Items.Unit_id = Tbl_Inv_Units.Unit_Id INNER JOIN                           Tbl_Inv_Taxs ON Tbl_Inv_Items.Tax_id = Tbl_Inv_Taxs.Tax_Id INNER JOIN                           Tbl_Inv_Spplier ON Tbl_Inv_Items.Sup_id = Tbl_Inv_Spplier.Sup_Id INNER JOIN                           Tbl_Inv_Groups ON Tbl_Inv_Items.Fam_id = Tbl_Inv_Groups.Fam_Id INNER JOIN                           Tbl_Inv_Category ON Tbl_Inv_Items.Cat_id = Tbl_Inv_Category.Cat_Id  ", con)
        Dim dt As New DataTable
        da.Fill(dt)
        RadGridView1.DataSource = dt
    End Sub

    Private Sub RadGridView1_CellClick(sender As Object, e As GridViewCellEventArgs) Handles RadGridView1.CellClick
        If e.RowIndex > -1 Then

            Frm_Inv_NewItemAr.Label4.Text = RadGridView1.CurrentRow.Cells("Item_id").Value
            Frm_Inv_UpdatePriceAr.RadTextBox1.Text = RadGridView1.CurrentRow.Cells("Item_id").Value
            Frm_Inv_ItemCardAr.Label1.Text = RadGridView1.CurrentRow.Cells("Item_id").Value
        End If
    End Sub

    Private Sub RadButton2_Click(sender As Object, e As EventArgs) Handles RadButton2.Click
        Frm_Inv_NewItemAr.Show()
        Frm_Inv_NewItemAr.RadButton2.Enabled = False
        Frm_Inv_NewItemAr.RadButton1.Enabled = False
    End Sub

    Private Sub RadButton4_Click(sender As Object, e As EventArgs) Handles RadButton4.Click
        Frm_Inv_UpdatePriceAr.Show()

    End Sub

    Private Sub RadGridView1_Click(sender As Object, e As EventArgs) Handles RadGridView1.Click

    End Sub

    Private Sub RadGridView1_CellDoubleClick(sender As Object, e As GridViewCellEventArgs) Handles RadGridView1.CellDoubleClick
        If e.RowIndex > -1 Then

            Frm_Inv_NewItemAr.Label4.Text = RadGridView1.CurrentRow.Cells("Item_id").Value
            Frm_Inv_UpdatePriceAr.RadTextBox1.Text = RadGridView1.CurrentRow.Cells("Item_id").Value
        End If
    End Sub

    Private Sub RadButton5_Click(sender As Object, e As EventArgs) Handles RadButton5.Click
        Frm_Inv_ItemCardAr.Show()

    End Sub
End Class