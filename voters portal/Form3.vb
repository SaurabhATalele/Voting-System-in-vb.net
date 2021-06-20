Imports MySql.Data.MySqlClient

Public Class Form3

    Public voterId As Integer
    Dim conn As New MySqlConnection("host = 127.0.0.1; user = root ; password = ;database = test ;")
    Dim cmd As MySqlCommand
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Try
            conn.Open()

        Catch ex As Exception
            MessageBox.Show("cannot connect...")

        End Try

        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from voters where id = " + voterId.ToString() + ""
        Dim a = cmd.ExecuteReader()

        While a.Read()
            labelname.Text = a(0)
            labeladdr.Text = a(1)
            labelcity.Text = a(2)
            labelage.Text = a(3)
            labelgender.Text = a(4)
            labelid.Text = a(5)


        End While

        a.Close()
        conn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            conn.Open()

        Catch ex As Exception
            MessageBox.Show("cannot connect...")

        End Try

        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from voted where id = " + voterId.ToString() + ""
        Dim a = cmd.ExecuteReader()

        If a.HasRows Then
            MessageBox.Show("You have already voted...")
        Else
            voterform.Show()
            voterform.voter = voterId

        End If
        a.Close()
        conn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class