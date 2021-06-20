Imports MySql.Data.MySqlClient





Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String

        Dim password As String
        Dim type As String
        Dim conn As New MySqlConnection("host = 127.0.0.1; user = root ; password = ;database = test ;")
        Dim cmd As MySqlCommand

        username = unamebox.Text
        password = passwordbox.Text
        type = ComboBox1.SelectedItem


        Try
            conn.Open()
            MessageBox.Show("Connected")
        Catch ex As Exception
            MessageBox.Show("cannot connect...")

        End Try

        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from users where name = '" + username + "'"
        Dim a = cmd.ExecuteReader()


        While a.Read()
            If a(0) = username And a(1) = password And a(2) = type.ToLower() Then

                MessageBox.Show("login success...")
                If a(2) = "admin" Then
                    form4.id = a(3)
                    Me.Hide()
                    Form4.Show()
                Else
                    Form3.voterId = a(3)
                    Me.Hide()
                    Form3.Show()

                End If


            Else
                MessageBox.Show("login failed...")

            End If

        End While









    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        signup.Show()

    End Sub
End Class