Imports System.ComponentModel
Imports System.IO

Public Class Startt
    Private Sub Start_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Welcome Beta tester! This program is in beta. This program was made by Joshua Glass (aka SuperNinja_4965). Thank you for playing")
        TextBox1.Text = Replace$(TextBox1.Text, vbCrLf & vbCrLf, vbCrLf)
        TextBox1.Text = Replace$(TextBox1.Text, vbCrLf & vbCrLf, vbCrLf)
        TextBox1.Text = TextBox1.Text.ToLower
        'MsgBox(TextBox1.Text)
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Open.ShowDialog()
        If Open.FileName <> "" Then
            TextBox1.Text = My.Computer.FileSystem.ReadAllText(Open.FileName)
            TextBox1.Text = Replace$(TextBox1.Text, vbCrLf & vbCrLf, vbCrLf)
            TextBox1.Text = Replace$(TextBox1.Text, vbCrLf & vbCrLf, vbCrLf)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
    End Sub

    Private Sub About_Click(sender As Object, e As EventArgs) Handles About.Click

    End Sub

    Private Sub Startt_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub
End Class