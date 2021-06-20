Imports MySql.Data.MySqlClient



Public Class Form4

    Dim conn As New MySqlConnection("host = 127.0.0.1; user = root ; password = ;database = test ;")
    Dim command As MySqlCommand

    Public id As Integer
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show(id)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Addvoter.Show()
        Me.Hide()

    End Sub

    Private Sub selector_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim name As String


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        addnominee.show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        votes.Show()

    End Sub
End Class