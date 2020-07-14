Public Class Frm_Gen_CompanyAr
    Private Sub Frm_Gen_CompanyAr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If RadTextBox11.Text = "" Then
            RadButton8.Enabled = False
            RadButton9.Enabled = False
            RadButton10.Enabled = False
            RadButton7.Enabled = False
            RadButton6.Enabled = False
            RadButton5.Enabled = False
            RadButton11.Enabled = False

        End If
        If RadTextBox22.Text = "" Then
            RadButton12.Enabled = False
            RadButton13.Enabled = False
            RadButton14.Enabled = False
            RadButton15.Enabled = False
        End If
        If RadTextBox25.Text = "" Then
            RadButton16.Enabled = False
            RadButton17.Enabled = False
            RadButton18.Enabled = False
            RadButton19.Enabled = False
        End If
        If RadTextBox29.Text = "" Then
            RadButton20.Enabled = False



        End If
        makeconnection()
        FillCountry()
        FillCity()
        FillCurrency()

        Dim da As New SqlClient.SqlDataAdapter("SELECT    isnull(max(Company_Id),0) + 1 as Company_Id     FROM          Tbl_Gen_Company", con)
        Dim dt As New DataTable
        da.Fill(dt)
        RadTextBox1.Text = dt.Rows(0).Item("Company_Id")
        Label1.Text = dt.Rows(0).Item("Company_Id")
    End Sub
    Sub FillCountry()
        Dim da As New SqlClient.SqlDataAdapter("Select * from Tbl_Gen_Country", con)
        Dim dt As New DataTable
        da.Fill(dt)
        ComboBox1.DisplayMember = "Country_NameAr"
        ComboBox1.ValueMember = "Country_Id"
        ComboBox1.DataSource = dt
    End Sub
    Sub FillCity()
        Dim da As New SqlClient.SqlDataAdapter("Select * from Tbl_Gen_City", con)
        Dim dt As New DataTable
        da.Fill(dt)
        ComboBox3.DisplayMember = "City_NameAr"
        ComboBox3.ValueMember = "City_Id"
        ComboBox3.DataSource = dt

    End Sub
    Sub FillCurrency()
        Dim da As New SqlClient.SqlDataAdapter("Select * from Tbl_Gen_Currency", con)
        Dim dt As New DataTable
        da.Fill(dt)
        ComboBox2.DisplayMember = "Currency_NameAr"
        ComboBox2.ValueMember = "Currency_Id"
        ComboBox2.DataSource = dt

    End Sub

    Private Sub RadButton25_Click(sender As Object, e As EventArgs) Handles RadButton25.Click
        Frm_Gen_CompanyArSearch.Show()

    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        makeconnection()
        Dim da As New SqlClient.SqlDataAdapter("SELECT    isnull(max(Company_Id),0) + 1 as Company_Id     FROM          Tbl_Gen_Company", con)
        Dim dt As New DataTable
        da.Fill(dt)
        RadTextBox1.Text = dt.Rows(0).Item("Company_Id")
        Dim da1 As New SqlClient.SqlDataAdapter("INSERT     INTO              Tbl_Gen_Company(Company_Id, Company_NameAr, Company_NameEn, Country_Id, City_Id, currency_id, Country_PhoneNo, Country_Fax, Country_Email, Country_Box, Country_Tax, Country_Trend, Country_Address)  VALUES        (N'" & RadTextBox1.Text & "', N'" & RadTextBox2.Text & "', N'" & RadTextBox3.Text & "', N'" & ComboBox1.SelectedIndex + 1 & "', N'" & ComboBox3.SelectedIndex + 1 & "', N'" & ComboBox2.SelectedIndex + 1 & "', N'" & RadTextBox4.Text & "', N'" & RadTextBox5.Text & "', N'" & RadTextBox6.Text & "', N'" & RadTextBox7.Text & "', N'" & RadTextBox8.Text & "', N'" & RadTextBox9.Text & "', N'" & RadTextBox10.Text & "') ", con)
        Dim dt1 As New DataTable
        da1.Fill(dt1)
        MsgBox("تم الحفظ بنجاح")
        RadButton2.PerformClick()


    End Sub

    Private Sub RadTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RadTextBox1.TextChanged
        If RadTextBox1.Text < Label1.Text Then
            RadButton1.Enabled = False

        End If


        makeconnection()
        Try

            Dim da As New SqlClient.SqlDataAdapter("SELECT         Tbl_Gen_Company.Company_NameAr, Tbl_Gen_Company.Company_NameEn, Tbl_Gen_Company.Country_PhoneNo, Tbl_Gen_Company.Country_Fax,                           Tbl_Gen_Company.Country_Email, Tbl_Gen_Company.Country_Box, Tbl_Gen_Company.Country_Tax, Tbl_Gen_Company.Country_Trend, Tbl_Gen_Company.Country_Address, Tbl_Gen_currency.currency_NameAr,                           Tbl_Gen_City.City_NameAr, Tbl_Gen_Country.Country_NameAr  FROM            Tbl_Gen_Company INNER JOIN                           Tbl_Gen_currency ON Tbl_Gen_Company.currency_id = Tbl_Gen_currency.currency_Id INNER JOIN                           Tbl_Gen_City ON Tbl_Gen_Company.City_Id = Tbl_Gen_City.City_Id INNER JOIN                           Tbl_Gen_Country ON Tbl_Gen_Company.Country_Id = Tbl_Gen_Country.Country_Id  WHERE        (Tbl_Gen_Company.Company_Id = N'" & RadTextBox1.Text & "')  ", con)
            Dim dt As New DataTable
            da.Fill(dt)
            RadTextBox2.Text = dt.Rows(0).Item("Company_NameAr").ToString
            RadTextBox3.Text = dt.Rows(0).Item("Company_Nameen").ToString
            RadTextBox4.Text = dt.Rows(0).Item("Country_PhoneNo").ToString
            RadTextBox5.Text = dt.Rows(0).Item("Country_Fax").ToString
            RadTextBox6.Text = dt.Rows(0).Item("Country_Email").ToString
            RadTextBox7.Text = dt.Rows(0).Item("Country_Box").ToString
            RadTextBox8.Text = dt.Rows(0).Item("Country_Tax").ToString
            RadTextBox9.Text = dt.Rows(0).Item("Country_Trend").ToString
            RadTextBox10.Text = dt.Rows(0).Item("Country_Address").ToString
            ComboBox2.Text = dt.Rows(0).Item("currency_NameAr").ToString
            ComboBox3.Text = dt.Rows(0).Item("City_NameAr").ToString
            ComboBox1.Text = dt.Rows(0).Item("Country_NameAr").ToString

            Dim da1 As New SqlClient.SqlDataAdapter("SELECT        Tbl_Gen_Branchs.Branch_NameAr, Tbl_Gen_Branchs.Branch_NameEn, Tbl_Gen_Branchs.Branch_PhoneNo, Tbl_Gen_Branchs.Branch_Fax, Tbl_Gen_Branchs.Branch_Address, Tbl_Gen_Branchs.Branch_Emial,                            Tbl_Gen_Branchs.Company_Id, Tbl_Gen_Branchs.Branch_id, Tbl_Gen_City.City_NameAr, Tbl_Gen_Country.Country_NameAr FROM            Tbl_Gen_Branchs INNER JOIN                          Tbl_Gen_City ON Tbl_Gen_Branchs.City_id = Tbl_Gen_City.City_Id INNER JOIN                          Tbl_Gen_Country ON Tbl_Gen_Branchs.Country_id = Tbl_Gen_Country.Country_Id WHERE        (Tbl_Gen_Branchs.Branch_id = N'" & RadTextBox1.Text & "') ", con)
            Dim dt1 As New DataTable
            da1.Fill(dt1)
            RadTextBox11.Text = dt1.Rows(0).Item("Branch_Id").ToString
            RadTextBox12.Text = dt1.Rows(0).Item("Branch_NameAr").ToString
            RadTextBox13.Text = dt1.Rows(0).Item("Branch_NameEn").ToString
            RadTextBox14.Text = dt1.Rows(0).Item("Branch_PhoneNo").ToString
            RadTextBox15.Text = dt1.Rows(0).Item("Branch_Fax").ToString
            RadTextBox16.Text = dt1.Rows(0).Item("Branch_Address").ToString
            RadTextBox17.Text = dt1.Rows(0).Item("Branch_Emial").ToString
            ComboBox4.Text = dt1.Rows(0).Item("Country_NameAr").ToString
            ComboBox5.Text = dt1.Rows(0).Item("city_NameAr").ToString


        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadButton2_Click(sender As Object, e As EventArgs) Handles RadButton2.Click

        RadTextBox1.Text = ""
        RadTextBox2.Text = ""
        RadTextBox3.Text = ""
        RadTextBox4.Text = ""
        RadTextBox5.Text = ""
        RadTextBox6.Text = ""
        RadTextBox7.Text = ""
        RadTextBox8.Text = ""
        RadTextBox9.Text = ""
        RadTextBox10.Text = ""
        FillCity()
        FillCountry()
        FillCurrency()
        Dim da As New SqlClient.SqlDataAdapter("SELECT    isnull(max(Company_Id),0) + 1 as Company_Id     FROM          Tbl_Gen_Company", con)
        Dim dt As New DataTable
        da.Fill(dt)
        RadTextBox1.Text = dt.Rows(0).Item("Company_Id")
        Label1.Text = dt.Rows(0).Item("Company_Id")
        RadButton1.Enabled = True
    End Sub

    Private Sub RadButton3_Click(sender As Object, e As EventArgs) Handles RadButton3.Click
        Dim da As New SqlClient.SqlDataAdapter("delete from tbl_Gen_company where company_id=N'" & RadTextBox1.Text & "'", con)
        Dim dt As New DataTable
        da.Fill(dt)
        Dim da1 As New SqlClient.SqlDataAdapter("INSERT     INTO              Tbl_Gen_Company(Company_Id, Company_NameAr, Company_NameEn, Country_Id, City_Id, currency_id, Country_PhoneNo, Country_Fax, Country_Email, Country_Box, Country_Tax, Country_Trend, Country_Address)  VALUES        (N'" & RadTextBox1.Text & "', N'" & RadTextBox2.Text & "', N'" & RadTextBox3.Text & "', N'" & ComboBox1.SelectedIndex + 1 & "', N'" & ComboBox3.SelectedIndex + 1 & "', N'" & ComboBox2.SelectedIndex + 1 & "', N'" & RadTextBox4.Text & "', N'" & RadTextBox5.Text & "', N'" & RadTextBox6.Text & "', N'" & RadTextBox7.Text & "', N'" & RadTextBox8.Text & "', N'" & RadTextBox9.Text & "', N'" & RadTextBox10.Text & "') ", con)
        Dim dt1 As New DataTable
        da1.Fill(dt1)
        MsgBox("تم التعديل")
        RadButton2.PerformClick()

    End Sub

    Private Sub RadTextBox25_TextChanged(sender As Object, e As EventArgs) Handles RadTextBox25.TextChanged

    End Sub

    Private Sub RadTextBox11_TextChanged(sender As Object, e As EventArgs) Handles RadTextBox11.TextChanged

    End Sub
End Class