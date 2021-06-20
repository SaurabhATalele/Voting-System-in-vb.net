Imports MySql.Data.MySqlClient

Public Class Addvoter
    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        Dim n = name.Text
        Dim addr = Address.Text
        Dim c = city.Text
        Dim a = age.Text
        Dim g = gender.Text
        Dim d = id.Text
        Dim conn As New MySqlConnection("host = 127.0.0.1; user = root ; password = ;database = test ;")
        Dim cmd As MySqlCommand

        Try
            conn.Open()

        Catch ex As Exception
            MessageBox.Show("cannot connect...")

        End Try

        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into voters values('" + "n" + "','" + a + "','" + c + "'," + a + ",'" + g + "'," + d + ")"
        cmd.ExecuteNonQuery()

        MessageBox.Show("Voter added....")



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form4.Show()
    End Sub

End Class