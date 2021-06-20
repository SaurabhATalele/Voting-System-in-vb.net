Imports MySql.Data.MySqlClient

Public Class voterform

    Dim conn As New MySqlConnection("host = 127.0.0.1; user = root ; password = ;database = test ;")
    Dim cmd As MySqlCommand
    Dim votes As Integer
    Public voter As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        vote(Label2.Text)
        conn.Close()
    End Sub

    Private Sub voterform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show("Not conneted...")
        End Try

        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from nomnies where  city = 'amravati'"
        Dim a = cmd.ExecuteReader()

        Dim i = 1
        If a.HasRows Then
            While a.Read()
                i = i + 1
                Dim nom = a(1)
                If i = 2 Then
                    Label2.Text = nom
                ElseIf i = 3 Then
                    Label3.Text = nom

                ElseIf i = 4 Then
                    Label4.Text = nom
                ElseIf i = 5 Then
                    Label5.Text = nom
                End If
            End While
        End If
        a.Close()
    End Sub

    Function vote(ByVal name As String)
        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from nomnies where name = '" + name + "'"
        Dim a = cmd.ExecuteReader()

        If a.HasRows Then
            a.Read()
            votes = a(2)
            votes = votes + 1
            a.Close()
        End If

        cmd.CommandText = "update nomnies set votes = " + votes.ToString + " where name = '" + name + "'"
        cmd.ExecuteNonQuery()


        cmd.CommandText = "insert into voted values('" + voter.ToString + "')"
        cmd.ExecuteNonQuery()
        Me.Hide()

        MessageBox.Show("Voted successfully...")

    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        vote(Label3.Text)
        conn.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        vote(Label4.Text)
        conn.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        vote(Label5.Text)
        conn.Close()
    End Sub
End Class