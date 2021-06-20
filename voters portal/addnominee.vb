Imports MySql.Data.MySqlClient
Public Class addnominee
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n = TextBox1.Text
        Dim c = ComboBox1.Text
        Dim conn As New MySqlConnection("host = 127.0.0.1; user = root ; password = ; database = test;")
        Dim cmd As MySqlCommand


        Try
            conn.Open()

        Catch ex As Exception
            MessageBox.Show("cannot connect...")

        End Try

        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into nomnies values('" + c + "','" + n + "','" + 0.ToString + "')"
        Dim a = cmd.ExecuteNonQuery()
        MessageBox.Show("Nominee Added Successfully...")


    End Sub
End Class