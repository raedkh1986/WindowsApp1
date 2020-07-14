Public Class Frm_Inv_NewItemAr
    Private Sub Frm_Inv_NewItemAr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = Now
        Label3.Text = Form1.Label1.Text
        FillInv_Category()
        FillInv_Groups()
        FillInv_Spplier()
        FillInv_Taxs()
        FillInv_Units()
        makeconnection()
        Dim da As New SqlClient.SqlDataAdapter("SELECT    isnull(max(Item_id),0) + 1 as Item_id     FROM          Tbl_Inv_Items", con)
        Dim dt As New DataTable
        da.Fill(dt)
        RadTextBox1.Text = dt.Rows(0).Item("Item_id")
        Label1.Text = dt.Rows(0).Item("Item_id")
        RadButton6.Enabled = False
        If Label4.Text > 0 Then
            RadTextBox1.Text = Label4.Text

        End If
        Try

            RadTextBox11.Text = ((RadTextBox5.Text - RadTextBox4.Text) / RadTextBox4.Text) * 100
        Catch ex As Exception

        End Try
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
    Sub FillInv_Groups()
        makeconnection()
        Dim da As New SqlClient.SqlDataAdapter("Select * from Tbl_Inv_Groups where Fam_Status = 0 ", con)
        Dim dt As New DataTable
        da.Fill(dt)
        ComboBox2.DisplayMember = "Fam_NAmeAr"
        ComboBox2.ValueMember = "Fam_Id"
        ComboBox2.DataSource = dt
    End Sub
    Sub FillInv_Taxs()

        makeconnection()
        Dim da As New SqlClient.SqlDataAdapter("Select * from Tbl_Inv_Taxs  where Tax_Status = 0", con)
        Dim dt As New DataTable
        da.Fill(dt)
        ComboBox4.DisplayMember = "tax_NAmeAr"
        ComboBox4.ValueMember = "tax_Id"
        ComboBox4.DataSource = dt
    End Sub
    Sub FillInv_Units()
        makeconnection()
        Dim da As New SqlClient.SqlDataAdapter("Select * from Tbl_Inv_Units where Unit_Status = 0 ", con)
        Dim dt As New DataTable
        da.Fill(dt)
        ComboBox5.DisplayMember = "Unit_NAmeAr"
        ComboBox5.ValueMember = "Unit_Id"
        ComboBox5.DataSource = dt
    End Sub
    Sub FillInv_Category()
        makeconnection()
        Dim da As New SqlClient.SqlDataAdapter("Select * from Tbl_Inv_Category where Cat_Status=0", con)
        Dim dt As New DataTable
        da.Fill(dt)
        ComboBox3.DisplayMember = "cat_NAmeAr"
        ComboBox3.ValueMember = "cat_Id"
        ComboBox3.DataSource = dt
    End Sub
    Private Sub RadButton2_Click(sender As Object, e As EventArgs) Handles RadButton2.Click
        makeconnection()
        Dim da As New SqlClient.SqlDataAdapter("SELECT    isnull(max(Item_id),0) + 1 as Item_id     FROM          Tbl_Inv_Items", con)
        Dim dt As New DataTable
        da.Fill(dt)
        RadTextBox1.Text = dt.Rows(0).Item("Item_id")
        Label1.Text = dt.Rows(0).Item("Item_id")
        Dim da1 As New SqlClient.SqlDataAdapter("INSERT        INTO              Tbl_Inv_Items(Item_id, Item_NameAr, Item_NameEn, Sup_id, Fam_id, Cat_id, Tax_id, Unit_id, Item_lowQty, Item_UpQty, Item_Cost, Item_Price, Item_Profit, Item_BarCode, Item_serialNo, Item_Des, Item_IsChangePrise, Item_IsNotPos, Item_IsService, Item_IsRawmaterial, Item_IsManufactured,Item_Adddate,user_id) VALUES        (N'" & RadTextBox1.Text & "', N'" & RadTextBox2.Text & "', N'" & RadTextBox3.Text & "', N'" & ComboBox1.SelectedIndex + 1 & "', N'" & ComboBox2.SelectedIndex + 1 & "', N'" & ComboBox3.SelectedIndex + 1 & "', N'" & ComboBox4.SelectedIndex + 1 & "', N'" & ComboBox5.SelectedIndex + 1 & "',                           N'" & RadTextBox9.Text & "', N'" & RadTextBox10.Text & "', N'" & RadTextBox4.Text & "', N'" & RadTextBox5.Text & "', N'" & RadTextBox11.Text & "', N'" & RadTextBox6.Text & "', N'" & RadTextBox7.Text & "', N'" & RadTextBox8.Text & "',                           N'" & RadCheckBox1.CheckState & "', N'" & RadCheckBox2.CheckState & "', N'" & RadCheckBox3.CheckState & "', N'" & RadCheckBox4.CheckState & "', N'" & RadCheckBox5.CheckState & "',N'" & Label2.Text & "',N'" & Label3.Text & "')  ", con)
        Dim dt1 As New DataTable
        da1.Fill(dt1)


        Dim da2 As New SqlClient.SqlDataAdapter("  INSERT       INTO              TBL_Inv_Batches(B_Barcode, B_Name, B_INQTY, B_OQTY, B_Source, Item_id)  VALUES        (N'" & RadTextBox6.Text & "', N'" & RadTextBox2.Text & "', 0, 0, N'ماده جديده', N'" & RadTextBox1.Text & "')   ", con)
        Dim dt2 As New DataTable
        da2.Fill(dt2)

        Dim da3 As New SqlClient.SqlDataAdapter("INSERT        INTO              Tbl_Inv_QtyBalance(Item_id, Item_BarCode, Qty)  VALUES        (N'" & RadTextBox1.Text & "', N'" & RadTextBox6.Text & "', 0)", con)
        Dim dt3 As New DataTable
        da3.Fill(dt3)


        MsgBox("تم الحفظ بنجاح")
        RadButton4.PerformClick()

        Frm_Inv_ItemsAr.RadButton3.PerformClick()
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click

        makeconnection()
        Dim da As New SqlClient.SqlDataAdapter("SELECT    isnull(max(Item_id),0) + 1 as Item_id     FROM          Tbl_Inv_Items  ", con)
        Dim dt As New DataTable
        da.Fill(dt)
        RadTextBox6.Text = ComboBox2.SelectedIndex + 1 & "0000" & dt.Rows(0).Item("Item_id")
    End Sub

    Private Sub RadButton4_Click(sender As Object, e As EventArgs) Handles RadButton4.Click
        Dim da As New SqlClient.SqlDataAdapter("SELECT    isnull(max(Item_id),0) + 1 as Item_id     FROM          Tbl_Inv_Items", con)
        Dim dt As New DataTable
        da.Fill(dt)
        RadTextBox1.Text = dt.Rows(0).Item("Item_id")
        Label1.Text = dt.Rows(0).Item("Item_id")
        RadTextBox2.Text = ""
        RadTextBox3.Text = ""
        RadTextBox4.Text = ""
        RadTextBox5.Text = ""
        RadTextBox6.Text = ""
        RadTextBox7.Text = ""
        RadTextBox8.Text = ""
        RadTextBox9.Text = ""
        RadTextBox10.Text = ""
        RadTextBox11.Text = ""
        FillInv_Category()
        FillInv_Groups()
        FillInv_Spplier()
        FillInv_Taxs()
        FillInv_Units()
        RadCheckBox1.Checked = False
        RadCheckBox2.Checked = False
        RadCheckBox3.Checked = False
        RadCheckBox4.Checked = False
        RadCheckBox5.Checked = False
        RadButton2.Enabled = True
        RadButton1.Enabled = True
    End Sub

    Private Sub RadButton6_Click(sender As Object, e As EventArgs) Handles RadButton6.Click
        Frm_Inv_ItemsMinAr.Show()

    End Sub

    Private Sub RadCheckBox5_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles RadCheckBox5.ToggleStateChanged
        If RadCheckBox5.Checked = True Then
            RadButton6.Enabled = True
        ElseIf RadCheckBox5.Checked = False Then
            RadButton6.Enabled = False
        End If
    End Sub

    Private Sub RadTextBox5_TextChanged(sender As Object, e As EventArgs) Handles RadTextBox5.TextChanged
        Try
            RadTextBox11.Text = ((RadTextBox5.Text - RadTextBox4.Text) / RadTextBox4.Text) * 100
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadTextBox4_TextChanged(sender As Object, e As EventArgs) Handles RadTextBox4.TextChanged
        Try
            RadTextBox11.Text = ((RadTextBox5.Text - RadTextBox4.Text) / RadTextBox4.Text) * 100
        Catch ex As Exception

        End Try


    End Sub

    Private Sub RadTextBox11_TextChanged(sender As Object, e As EventArgs) Handles RadTextBox11.TextChanged
        Try


            If RadTextBox11.Text > 0 Then
                RadTextBox11.BackColor = Color.Green
            ElseIf RadTextBox11.Text < 0 Then
                RadTextBox11.BackColor = Color.Red
            ElseIf RadTextBox11.Text = 0 Then
                RadTextBox11.BackColor = Color.Aqua
            End If
        Catch ex As Exception
            RadTextBox11.Text = 0
        End Try
    End Sub

    Private Sub RadTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RadTextBox1.TextChanged

        Try



            makeconnection()
            Dim da As New SqlClient.SqlDataAdapter("SELECT        Tbl_Inv_Items.Item_NameAr, Tbl_Inv_Items.Item_NameEn, Tbl_Inv_Items.Item_lowQty, Tbl_Inv_Items.Item_UpQty, Tbl_Inv_Items.Item_Cost, Tbl_Inv_Items.Item_Price,Tbl_Inv_Items.Item_BarCode, Tbl_Inv_Items.Item_serialNo, Tbl_Inv_Items.Item_Des, Tbl_Inv_Items.Item_IsChangePrise, Tbl_Inv_Items.Item_IsNotPos, Tbl_Inv_Items.Item_IsService, Tbl_Inv_Items.Item_IsRawmaterial,                           Tbl_Inv_Items.Item_IsManufactured, Tbl_Inv_Category.Cat_NameAr, Tbl_Inv_Taxs.Tax_NameAr, Tbl_Inv_Units.Unit_NameAr, Tbl_Inv_Spplier.Sup_NameAr, Tbl_Inv_Groups.Fam_NameAr FROM            Tbl_Inv_Items INNER JOIN                          Tbl_Inv_Units ON Tbl_Inv_Items.Unit_id = Tbl_Inv_Units.Unit_Id INNER JOIN                          Tbl_Inv_Taxs ON Tbl_Inv_Items.Tax_id = Tbl_Inv_Taxs.Tax_Id INNER JOIN                           Tbl_Inv_Spplier ON Tbl_Inv_Items.Sup_id = Tbl_Inv_Spplier.Sup_Id INNER JOIN                          Tbl_Inv_Groups ON Tbl_Inv_Items.Fam_id = Tbl_Inv_Groups.Fam_Id INNER JOIN                          Tbl_Inv_Category ON Tbl_Inv_Items.Cat_id = Tbl_Inv_Category.Cat_Id  where Tbl_Inv_Items.item_id =N'" & Label4.Text & "'", con)
            Dim dt As New DataTable
            da.Fill(dt)

            RadTextBox2.Text = dt.Rows(0).Item("Item_NameAr")
            RadTextBox3.Text = dt.Rows(0).Item("Item_NameEn")
            RadTextBox9.Text = dt.Rows(0).Item("Item_lowQty")
            RadTextBox10.Text = dt.Rows(0).Item("Item_UpQty")
            RadTextBox4.Text = dt.Rows(0).Item("Item_Cost")
            RadTextBox5.Text = dt.Rows(0).Item("Item_Price")
            RadTextBox6.Text = dt.Rows(0).Item("Item_BarCode")
            RadTextBox7.Text = dt.Rows(0).Item("Item_serialNo")
            RadTextBox8.Text = dt.Rows(0).Item("Item_Des")
            RadCheckBox1.CheckState = dt.Rows(0).Item("Item_IsChangePrise")
            RadCheckBox3.CheckState = dt.Rows(0).Item("Item_IsNotPos")
            RadCheckBox4.CheckState = dt.Rows(0).Item("Item_IsService")
            RadCheckBox2.CheckState = dt.Rows(0).Item("Item_IsRawmaterial")
            RadCheckBox5.CheckState = dt.Rows(0).Item("Item_IsManufactured")
            ComboBox3.Text = dt.Rows(0).Item("Cat_NameAr")
            ComboBox4.Text = dt.Rows(0).Item("Tax_NameAr")
            ComboBox5.Text = dt.Rows(0).Item("Unit_NameAr")
            ComboBox1.Text = dt.Rows(0).Item("Sup_NameAr")
            ComboBox2.Text = dt.Rows(0).Item("Fam_NameAr")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadButton3_Click(sender As Object, e As EventArgs) Handles RadButton3.Click
        makeconnection()
        Dim da3 As New SqlClient.SqlDataAdapter("delete from Tbl_Inv_Items where Item_id = N'" & RadTextBox1.Text & "'", con)
        Dim dt3 As New DataTable
        da3.Fill(dt3)



        Dim da1 As New SqlClient.SqlDataAdapter("INSERT        INTO              Tbl_Inv_Items(Item_id, Item_NameAr, Item_NameEn, Sup_id, Fam_id, Cat_id, Tax_id, Unit_id, Item_lowQty, Item_UpQty, Item_Cost, Item_Price, Item_Profit, Item_BarCode, Item_serialNo, Item_Des, Item_IsChangePrise, Item_IsNotPos, Item_IsService, Item_IsRawmaterial, Item_IsManufactured,Item_Adddate,user_id) VALUES        (N'" & RadTextBox1.Text & "', N'" & RadTextBox2.Text & "', N'" & RadTextBox3.Text & "', N'" & ComboBox1.SelectedIndex + 1 & "', N'" & ComboBox2.SelectedIndex + 1 & "', N'" & ComboBox3.SelectedIndex + 1 & "', N'" & ComboBox4.SelectedIndex + 1 & "', N'" & ComboBox5.SelectedIndex + 1 & "',                           N'" & RadTextBox9.Text & "', N'" & RadTextBox10.Text & "', N'" & RadTextBox4.Text & "', N'" & RadTextBox5.Text & "', N'" & RadTextBox11.Text & "', N'" & RadTextBox6.Text & "', N'" & RadTextBox7.Text & "', N'" & RadTextBox8.Text & "',                           N'" & RadCheckBox1.CheckState & "', N'" & RadCheckBox2.CheckState & "', N'" & RadCheckBox3.CheckState & "', N'" & RadCheckBox4.CheckState & "', N'" & RadCheckBox5.CheckState & "',N'" & Label2.Text & "',N'" & Label3.Text & "')  ", con)
        Dim dt1 As New DataTable
        da1.Fill(dt1)

        Dim da4 As New SqlClient.SqlDataAdapter("delete from TBL_Inv_Batches where Item_id = N'" & RadTextBox1.Text & "'", con)
        Dim dt4 As New DataTable
        da4.Fill(dt4)
        Dim da2 As New SqlClient.SqlDataAdapter("  INSERT       INTO              TBL_Inv_Batches(B_Barcode, B_Name, B_INQTY, B_OQTY, B_Source, Item_id)  VALUES        (N'" & RadTextBox6.Text & "', N'" & RadTextBox2.Text & "', 0, 0, N'ماده جديده', N'" & RadTextBox1.Text & "')   ", con)
        Dim dt2 As New DataTable
        da2.Fill(dt2)

        MsgBox("تم التعديل بنجاح")
        RadButton4.PerformClick()

        Frm_Inv_ItemsAr.RadButton3.PerformClick()
    End Sub

    Private Sub RadButton7_Click(sender As Object, e As EventArgs) Handles RadButton7.Click
        Frm_Inv_UnitsAr.Show()
        FillInv_Units()


    End Sub

    Private Sub RadButton8_Click(sender As Object, e As EventArgs) Handles RadButton8.Click
        Frm_Inv_TaxsAr.Show()
        FillInv_Taxs()



    End Sub

    Private Sub RadButton10_Click(sender As Object, e As EventArgs) Handles RadButton10.Click
        Frm_Inv_GroupsAr.Show()
        FillInv_Groups()

    End Sub
End Class