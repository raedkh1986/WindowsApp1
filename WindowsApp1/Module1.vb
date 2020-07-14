Module Module1
    Public con As New SqlClient.SqlConnection
    Sub makeconnection()

        Try
            If con.State = ConnectionState.Open Then con.Close()
            con.ConnectionString = "Data Source='" & Form1.RadTextBox3.Text & "';Initial Catalog='" & Form1.RadTextBox4.Text & "';User ID='" & Form1.RadTextBox5.Text & "';Password='" & Form1.RadTextBox6.Text & "'"
            con.Open()
        Catch ex As Exception
            MsgBox("ارجو التأكد من الاعدادات ")
        End Try


    End Sub
End Module