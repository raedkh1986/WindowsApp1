Public Class Frm_Inv_ItemCardAr
    Private Sub Frm_Inv_ItemCardAr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try


            makeconnection()

        Dim da As New SqlClient.SqlDataAdapter(" Select  TBL_Inv_Batches.B_Barcode, TBL_Inv_Batches.B_Name, TBL_Inv_Batches.B_INQTY, TBL_Inv_Batches.B_OQTY, TBL_Inv_Batches.B_Source, Tbl_Inv_Items.Item_id, Tbl_Inv_Items.Item_Cost, Tbl_Inv_Items.Item_Price FROM            TBL_Inv_Batches INNER JOIN                          Tbl_Inv_Items On TBL_Inv_Batches.B_Barcode = Tbl_Inv_Items.Item_BarCode WHERE        (Tbl_Inv_Items.Item_id = N'" & Label1.Text & "')", con)
        Dim dt As New DataTable
        da.Fill(dt)
        RadGridView1.DataSource = dt


        Catch ex As Exception

        End Try

    End Sub


    Private Sub Label1_TextChanged(sender As Object, e As EventArgs) Handles Label1.TextChanged
        Try


            makeconnection()

            Dim da As New SqlClient.SqlDataAdapter(" Select  TBL_Inv_Batches.B_Barcode, TBL_Inv_Batches.B_Name, TBL_Inv_Batches.B_INQTY, TBL_Inv_Batches.B_OQTY, TBL_Inv_Batches.B_Source, Tbl_Inv_Items.Item_id, Tbl_Inv_Items.Item_Cost, Tbl_Inv_Items.Item_Price FROM            TBL_Inv_Batches INNER JOIN                          Tbl_Inv_Items On TBL_Inv_Batches.B_Barcode = Tbl_Inv_Items.Item_BarCode WHERE        (Tbl_Inv_Items.Item_id = N'" & Label1.Text & "')", con)
            Dim dt As New DataTable
            da.Fill(dt)
            RadGridView1.DataSource = dt
        Catch ex As Exception

        End Try
    End Sub
End Class