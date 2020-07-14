Public Class Frm_Inv_UpdatePriceAr
    Private Sub RadTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RadTextBox1.TextChanged
        Try


            makeconnection()
            Dim da As New SqlClient.SqlDataAdapter(" Select  Item_NameAr, Item_Cost, Item_Price, Item_Profit, Item_BarCode  FROM            Tbl_Inv_Items  WHERE        (Item_id =N'" & RadTextBox1.Text & "')", con)
            Dim dt As New DataTable
            da.Fill(dt)
            RadTextBox3.Text = dt.Rows(0).Item("Item_NameAr")
            RadTextBox4.Text = dt.Rows(0).Item("Item_Cost")
            RadTextBox7.Text = dt.Rows(0).Item("Item_Profit")
            RadTextBox2.Text = dt.Rows(0).Item("Item_BarCode")
            RadTextBox5.Text = dt.Rows(0).Item("Item_Price")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadTextBox6_TextChanged(sender As Object, e As EventArgs) Handles RadTextBox6.TextChanged
        Try
            RadTextBox7.Text = ((RadTextBox6.Text - RadTextBox4.Text) / RadTextBox4.Text) * 100
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadButton2_Click(sender As Object, e As EventArgs) Handles RadButton2.Click

        makeconnection()
        Dim da As New SqlClient.SqlDataAdapter(" UPDATE       Tbl_Inv_Items  SET                Item_Price = N'" & RadTextBox6.Text & "' , Item_Profit = N'" & RadTextBox7.Text & "'   WHERE        (Item_id =N'" & RadTextBox1.Text & "')", con)
        Dim dt As New DataTable
        da.Fill(dt)
        Dim da1 As New SqlClient.SqlDataAdapter("INSERT      INTO              Tbl_Inv_PriceChange(Item_id, OldPrice, NewPrice, AddDate, User_id)  VALUES        (N'" & RadTextBox1.Text & "', N'" & RadTextBox5.Text & "', N'" & RadTextBox6.Text & "', N'" & Label1.Text & "', N'" & Label2.Text & "') ", con)
        Dim dt1 As New DataTable
        da1.Fill(dt1)
        MsgBox("تم تعديل السعر بنجاح")
        RadTextBox1.Text = ""
        RadTextBox2.Text = ""
        RadTextBox3.Text = ""
        RadTextBox4.Text = ""
        RadTextBox5.Text = ""
        RadTextBox6.Text = ""
        RadTextBox7.Text = ""

    End Sub

    Private Sub Frm_Inv_UpdatePriceAr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = Now
        Label2.Text = Form1.Label1.Text

    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        Frm_Inv_ItemSreachAr.Show()
    End Sub
End Class