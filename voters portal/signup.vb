Imports MySql.Data.MySqlClient

Public Class signup


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim user As String
        Dim pass = pwd.Text
        Dim id = voterid.Text
        user = textbox1.Text

        Dim conn As New MySqlConnection("host = 127.0.0.1; user = root ; password = ;database = test ;")
        Dim cmd As MySqlCommand


        Try
            conn.Open()

        Catch ex As Exception
            MessageBox.Show("cannot connect...")

        End Try

        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from voters where id = " + id
        Dim a = cmd.ExecuteReader()

        If a.HasRows Then

            a.Read()
            If a(5) Then
                    a.Close()

                    cmd.CommandText = "select * from users where id = " + id
                    a = cmd.ExecuteReader()
                    If a.HasRows Then
                        MessageBox.Show("User already exists....")
                        a.Close()

                    Else
                        a.Close()
                        cmd = conn.CreateCommand()
                        cmd.CommandType = CommandType.Text
                        cmd.CommandText = "insert into users values('" + user + "','" + pass + "','user'," + id + ")"
                        cmd.ExecuteNonQuery()

                        MessageBox.Show("User created...")

                    End If

                Else

                End If


        Else
            MessageBox.Show("No voter at this id")
            Form2.Show()
            a.Close()

        End If










        conn.Close()
    End Sub
End Class