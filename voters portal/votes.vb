Imports MySql.Data.MySqlClient



Public Class votes
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub votes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New MySqlConnection("host = 127.0.0.1; user = root ; password = ;database = test ;")
        Dim cmd As MySqlCommand


        Try
            conn.Open()

        Catch ex As Exception


        End Try

        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from nomnies WHERE CITY = 'AMRAVATI'"
        Dim a = cmd.ExecuteReader()
        Dim I = 1
        If a.HasRows Then
            While a.Read()
                I = I + 1
                Dim nom = a(1)
                Dim V = a(2)
                If I = 2 Then
                    Label2.Text = nom
                    Label6.Text = V
                ElseIf I = 3 Then
                    Label3.Text = nom
                    Label7.Text = V
                ElseIf I = 4 Then
                    Label4.Text = nom
                    Label8.Text = V
                ElseIf I = 5 Then
                    Label5.Text = nom
                    Label9.Text = V
                End If
            End While
        End If

    End Sub
End Class