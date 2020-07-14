Public Class Frm_Inv_PurReturnAr
    Private Sub Frm_Inv_PurReturnAr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillInv_Spplier()
        FillGen_Branchs()
        FillAcc_Paments()
        Label2.Text = Now
        Label3.Text = Form1.Label1.Text
        RadTextBox8.Text = Form1.RadTextBox1.Text
        RadDateTimePicker1.Text = Date.Now
        Dim da As New SqlClient.SqlDataAdapter("SELECT    isnull(max(PUM_Id),0) + 1 as PUM_Id     FROM          TbL_Inv_PurchasesRetunMaster", con)
        Dim dt As New DataTable
        da.Fill(dt)
        RadTextBox1.Text = dt.Rows(0).Item("PUM_Id")
        Label1.Text = dt.Rows(0).Item("PUM_Id")

    End Sub
    Sub FillAcc_Paments()
        makeconnection()
        Dim da As New SqlClient.SqlDataAdapter("Select * from Tbl_Acc_Paments where Branch_Status=0", con)
        Dim dt As New DataTable
        da.Fill(dt)
        ComboBox3.DisplayMember = "Branch_NameAr"
        ComboBox3.ValueMember = "Pament_id"
        ComboBox3.DataSource = dt
    End Sub
    Sub FillGen_Branchs()
        makeconnection()
        Dim da As New SqlClient.SqlDataAdapter("Select * from Tbl_Gen_Branchs", con)
        Dim dt As New DataTable
        da.Fill(dt)
        ComboBox2.DisplayMember = "Branch_NameAr"
        ComboBox2.ValueMember = "Branch_id"
        ComboBox2.DataSource = dt
    End Sub
    Sub FillInv_Spplier()
        makeconnection()
        Dim da As New SqlClient.SqlDataAdapter("Select * from Tbl_Inv_Spplier where Sup_Type = 0 and Sup_Status = 0", con)
        Dim dt As New DataTable
        da.Fill(dt)
        ComboBox1.DisplayMember = "Sup_NAmeAr"
        ComboBox1.ValueMember = "Sup_ID"
        ComboBox1.DataSource = dt
    End Sub
    Private Sub RadButton4_Click(sender As Object, e As EventArgs) Handles RadButton4.Click
        Frm_Inv_SpplierAr.Show()

    End Sub
    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        Frm_Inv_NewItemAr.Show()

    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try


            makeconnection()
            Dim da As New SqlClient.SqlDataAdapter("SELECT         Item_NameAr, Tax_id, Unit_id, Item_Cost, Item_BarCode  FROM            Tbl_Inv_Items  WHERE        (Item_BarCode =N'" & TextBox1.Text & "')", con)
            Dim dt As New DataTable
            da.Fill(dt)
            TextBox2.Text = dt.Rows(0).Item("Item_NameAr")
            TextBox3.Text = dt.Rows(0).Item("Tax_id")
            TextBox5.Text = dt.Rows(0).Item("Unit_id")
        Catch ex As Exception

        End Try
    End Sub
    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        Try


            For i As Integer = 0 To DataGridView1.Rows.Count - 2


                TextBox1.Text = DataGridView1.Rows(i).Cells("Item_BarCode").Value
                DataGridView1.Rows(i).Cells("Unit_id").Value = TextBox5.Text.ToString
                DataGridView1.Rows(i).Cells("Item_NameAr").Value = TextBox2.Text.ToString
                DataGridView1.Rows(i).Cells("Tax_Percentage").Value = TextBox4.Text.ToString
                DataGridView1.Rows(i).Cells("Unit_NameAr").Value = TextBox6.Text.ToString
                DataGridView1.Rows(i).Cells("Sumqty").Value = Double.Parse(DataGridView1.Rows(i).Cells("qty").Value) + Double.Parse(DataGridView1.Rows(i).Cells("Bqty").Value)
                DataGridView1.Rows(i).Cells("total").Value = DataGridView1.Rows(i).Cells("qty").Value * DataGridView1.Rows(i).Cells("Item_Cost").Value
                DataGridView1.Rows(i).Cells("SumTax").Value = DataGridView1.Rows(i).Cells("total").Value * DataGridView1.Rows(i).Cells("Tax_Percentage").Value
                RadTextBox3.Text = "0.000"
                RadTextBox5.Text = "0.000"
                RadTextBox6.Text = "0.000"
                RadTextBox4.Text = "0.000"
                For j As Integer = 0 To DataGridView1.Rows.Count - 2
                    RadTextBox3.Text = Double.Parse(RadTextBox3.Text) + DataGridView1.Rows(j).Cells("total").Value

                    RadTextBox5.Text = Double.Parse(RadTextBox5.Text) + DataGridView1.Rows(j).Cells("Sumtax").Value

                    RadTextBox6.Text = Double.Parse(RadTextBox3.Text - RadTextBox4.Text + RadTextBox5.Text)

                Next
            Next
        Catch ex As Exception

        End Try
    End Sub
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Try


            makeconnection()
            Dim da As New SqlClient.SqlDataAdapter("SELECT          Tax_Percentage  FROM            Tbl_Inv_taxs  WHERE        (Tax_Id =N'" & TextBox3.Text & "')", con)
            Dim dt As New DataTable
            da.Fill(dt)
            TextBox4.Text = dt.Rows(0).Item("Tax_Percentage")

        Catch ex As Exception

        End Try
    End Sub
    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        Try

            makeconnection()
            Dim da As New SqlClient.SqlDataAdapter("SELECT          unit_NameAr  FROM            Tbl_Inv_Units  WHERE        (unit_Id =N'" & TextBox5.Text & "')", con)
            Dim dt As New DataTable
            da.Fill(dt)
            TextBox6.Text = dt.Rows(0).Item("unit_NameAr")
        Catch ex As Exception

        End Try
    End Sub
    Private Sub RadTextBox4_TextChanged(sender As Object, e As EventArgs) Handles RadTextBox4.TextChanged
        Try

            RadTextBox6.Text = Double.Parse(RadTextBox3.Text - RadTextBox4.Text + RadTextBox5.Text)

        Catch ex As Exception


        End Try
    End Sub
    Private Sub RadButton5_Click(sender As Object, e As EventArgs) Handles RadButton5.Click
        If RadTextBox2.Text = String.Empty Then
            MsgBox("الرجاء ادخال رقم المردود")
            RadTextBox2.Focus()

        ElseIf RadTextBox7.Text = String.Empty Then
            MsgBox("الرجاء ادخال المستلم")
            RadTextBox7.Focus()
        ElseIf RadTextBox8.Text = String.Empty Then
            MsgBox("الرجاء ادخال المدخل")
            RadTextBox8.Focus()

        ElseIf IsNothing(DataGridView1.DataSource) Then
            MsgBox("الرجاء ادخال المواد")
        ElseIf RadTextBox3.Text = 0 Then

            MsgBox("لا يسمح بحفظ المردود والقيمه صفرية")
            RadTextBox3.Focus()

        Else


            makeconnection()
            Dim da1 As New SqlClient.SqlDataAdapter("SELECT    isnull(max(PUM_Id),0) + 1 as PUM_Id     FROM          TbL_Inv_PurchasesRetunMaster", con)
            Dim dt1 As New DataTable
            da1.Fill(dt1)
            RadTextBox1.Text = dt1.Rows(0).Item("PUM_Id")
            Dim da As New SqlClient.SqlDataAdapter("INSERT INTO TbL_Inv_PurchasesRetunMaster                           (PUM_Id, SUP_Id, PUM_Date, PUM_InvoceNo, PUM_Note, PUM_SubTotal, PUM_DesAmount, PUM_Total, PUM_TaxAmount, PUM_Post, Pament_id, user_id, AddDate, Branch_Id)  VALUES        (N'" & RadTextBox1.Text & "', N'" & ComboBox1.SelectedIndex + 1 & "', N'" & RadDateTimePicker1.Text & "', N'" & RadTextBox2.Text & "', N'" & RadTextBox9.Text & "', N'" & RadTextBox3.Text & "', N'" & RadTextBox4.Text & "',                           N'" & RadTextBox6.Text & "', N'" & RadTextBox5.Text & "', N'0', N'" & ComboBox3.SelectedIndex + 1 & "', N'" & Label1.Text & "', N'" & Label2.Text & "', N'" & ComboBox2.SelectedIndex + 1 & "')  ", con)
            Dim dt As New DataTable
            da.Fill(dt)


            For i = 0 To DataGridView1.Rows.Count - 2
                Dim da2 As New SqlClient.SqlDataAdapter("INSERT        INTO              TBL_inv_PurchasesReturnDetiles(PUM_ID, PUD_Barcode, PUD_ItemID, PUD_Name, PUD_QTY, PUD_BQTY, PUD_Cost, PUD_Total, UN_ID) VALUES        (N'" & RadTextBox1.Text & "', N'" & DataGridView1.Rows(i).Cells("Item_BarCode").Value & "', N'0', N'" & DataGridView1.Rows(i).Cells("Item_NameAr").Value & "',                           N'" & DataGridView1.Rows(i).Cells("QTY").Value & "', N'" & DataGridView1.Rows(i).Cells("BQTY").Value & "', N'" & DataGridView1.Rows(i).Cells("Item_Cost").Value & "', N'" & DataGridView1.Rows(i).Cells("Total").Value & "',                           N'" & DataGridView1.Rows(i).Cells("Unit_id").Value & "') ", con)
                Dim dt2 As New DataTable
                da2.Fill(dt2)


                Dim da3 As New SqlClient.SqlDataAdapter("INSERT         INTO              TBL_Inv_Batches(B_Barcode, B_Name, B_INQTY, B_OQTY, B_Balance, B_Source, Item_id)  VALUES        (N'" & DataGridView1.Rows(i).Cells("Item_BarCode").Value & "', N'" & DataGridView1.Rows(i).Cells("Item_NameAr").Value & "',0, N'" & DataGridView1.Rows(i).Cells("SumQty").Value & "',  0, N'مردود مشتريات', N'0')  ", con)
                Dim dt3 As New DataTable
                da3.Fill(dt3)




            Next
            MsgBox("تم الحفظ بنجاح")
            RadTextBox1.Text = RadTextBox1.Text + 1
            RadTextBox2.Text = ""
            RadTextBox3.Text = "0.000"
            RadTextBox4.Text = "0.000"
            RadTextBox5.Text = "0.000"
            RadTextBox6.Text = "0.000"
            RadTextBox7.Text = ""
            RadTextBox8.Text = ""
            RadTextBox9.Text = ""

            DataGridView1.Rows.Clear()
        End If
    End Sub
    Private Sub RadButton9_Click(sender As Object, e As EventArgs) Handles RadButton9.Click
        Me.Close()
    End Sub
End Class