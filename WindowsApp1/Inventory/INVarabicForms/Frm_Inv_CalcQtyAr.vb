Public Class Frm_Inv_CalcQtyAr
    Private Sub Frm_Inv_CalcQtyAr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        makeconnection()

        Dim da As New SqlClient.SqlDataAdapter("SELECT B_Barcode, B_Name, SUM(B_INQTY) AS 'B_INQTY', SUM(B_OQTY) AS 'B_OQTY', SUM(B_INQTY) - SUM(B_OQTY) AS 'B_Balance'  FROM TBL_Inv_Batches GROUP BY   B_Barcode, B_Name ", con)
        Dim dt As New DataTable
        da.Fill(dt)
        RadGridView1.DataSource = dt
        For i = 0 To RadGridView1.Rows.Count - 1
            Dim da2 As New SqlClient.SqlDataAdapter("Update       Tbl_Inv_QtyBalance  SET                QTY = '" & RadGridView1.Rows(i).Cells("B_Balance").Value & "' WHERE        ( Item_BarCode='" & RadGridView1.Rows(i).Cells("B_Barcode").Value & "')", con)
            Dim dt2 As New DataTable
            da2.Fill(dt2)
        Next

        MsgBox("تم احتساب الكميات بنجاح")


    End Sub
End Class