Public Class Form1

    Dim dewords As New List(Of String)()
    Dim attempts As New List(Of String)()
    Dim totalAmountOfWords As Integer
    Dim wordhidden As String
    Dim stage As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Startt.TextBox1.Text = "
" + Startt.TextBox1.Text
        load_game()
    End Sub

    Sub load_game()
        GroupBox3.Enabled = True
        dewords.Clear()
        totalAmountOfWords = 0
        wordhidden = ""
        stage = 0
        triesLeft.Text = "You have " & 10 - stage & " attempts left"
        trys.Text = "You have no tries"
        attempts.Clear()
        word = 0
        resize_window()
        For i = 0 To Startt.TextBox1.Lines.Length - 1
            dewords.Add(Startt.TextBox1.Lines(i))
            'MsgBox(i)
            'MsgBox(dewords(i))
            totalAmountOfWords = i

        Next
        Randomize()
        wordsel()
        siz_check()
    End Sub

    Dim word As Integer

    Sub wordsel()
        word = CInt(Math.Ceiling(Rnd() * totalAmountOfWords))
        Label1.Text = ""
        'MessageBox.Show(dewords(word))
        'MessageBox.Show(dewords(word).Length)
        For x = 0 To dewords(word).Length - 1
            Label1.Text = Label1.Text + "_ "
            wordhidden = wordhidden + "_"
        Next
    End Sub

    Sub resize_window()
        'If Me.WindowState.Maximized = False Then
        'Me.Height = Me.Height - Me.ClientSize.Height - 2
        'End If


        ' Button 1
        Button1.Top = 15
        Button1.Width = GroupBox3.Width * 0.75 - 10
        Button1.Left = GroupBox3.Width * 0.25 + 6

        ' Textbox 1
        TextBox1.Top = 12
        TextBox1.Width = GroupBox3.Width * 0.25
        TextBox1.Left = +2

        ' Label 1
        Label1.Top = 100
        Label1.Top = 40
        Label1.Left = +2

    End Sub

    Sub siz_check()
        If Label1.Width > 303 Then
            Me.MaximumSize = New Size(Label1.Width + 10, Me.Height)
            Me.MinimumSize = New Size(Label1.Width + 10, Me.Height)
            Me.Width = Label1.Width + 10
        End If
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        resize_window()
        siz_check()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" Then
            tryLetter(TextBox1.Text.ToLower)
            TextBox1.Focus()
        End If
    End Sub

    Sub tryLetter(letter As String)
        TextBox1.Text = ""
        Dim letterhceck = dewords(word)
        Dim IsAttemptAlreadyUsed As String = attempts.IndexOf(letter)
        If IsAttemptAlreadyUsed >= 0 Then
            Message.Text = "You have already tried this."
        Else
            attempts.Add(letter)
            If trys.Text = "You have no tries" Then
                trys.Text = ""
            End If
            trys.Text = letter + ", " + trys.Text
            If letterhceck.IndexOf(letter) >= 0 Then
                For i = 0 To dewords(word).Length - 1
                    Dim testword As String = dewords(word)
                    If testword(i) = letter Then
                        wordhidden = wordhidden.Remove(i, 1).Insert(i, letter)
                    Else
                    End If

                Next
                Label1.Text = ""
                For i = 0 To dewords(word).Length - 1
                    Label1.Text = Label1.Text + wordhidden(i) + " "
                Next
                'MsgBox(wordhidden)
                Message.Text = "A correct letter was selected"
                If wordhidden = dewords(word) Then
                    'Win.Show()
                    'Me.Hide()
                    Message.Text = "You got the word correct it was: " & dewords(word)
                    GroupBox3.Enabled = False
                End If
            Else
                Message.Text = "An incorrect letter was selected"
                stage = stage + 1
                Me.Invalidate()
            End If


        End If
        siz_check()
    End Sub

    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        If stage >= 1 Then
            e.Graphics.DrawLine(New Pen(Color.Black, 2), 85, 190, 210, 190)
        End If
        If stage >= 2 Then
            e.Graphics.DrawLine(New Pen(Color.Black, 2), 148, 190, 148, 50)
        End If
        If stage >= 3 Then
            e.Graphics.DrawLine(New Pen(Color.Black, 2), 148, 50, 198, 50)
        End If
        If stage >= 4 Then
            e.Graphics.DrawLine(New Pen(Color.Black, 2), 198, 50, 198, 70)
        End If
        If stage >= 5 Then
            e.Graphics.DrawEllipse(New Pen(Color.Black, 2), New Rectangle(188, 70, 20, 20))
        End If
        If stage >= 6 Then
            e.Graphics.DrawLine(New Pen(Color.Black, 2), 198, 90, 198, 130)
        End If
        If stage >= 7 Then
            e.Graphics.DrawLine(New Pen(Color.Black, 2), 198, 95, 183, 115)
        End If
        If stage >= 8 Then
            e.Graphics.DrawLine(New Pen(Color.Black, 2), 198, 95, 213, 115)
        End If
        If stage >= 9 Then
            e.Graphics.DrawLine(New Pen(Color.Black, 2), 198, 130, 183, 170)
        End If
        If stage >= 10 Then
            e.Graphics.DrawLine(New Pen(Color.Black, 2), 198, 130, 213, 170)
            Message.Text = "You lose. The word was: " & dewords(word)
            'lose.Show()
            'Me.Hide()
            GroupBox3.Enabled = False
        End If
        triesLeft.Text = "You have " & 10 - stage & " attempts left"
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TextBox1.Text <> "" Then
                tryLetter(TextBox1.Text.ToLower)
                TextBox1.Focus()
            End If
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub Message_Click(sender As Object, e As EventArgs) Handles Message.Click
        MessageBox.Show("Your message reads: " + Message.Text, Message.Text)
    End Sub

    Private Sub ToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Application.Exit()
    End Sub

    Private Sub NewWordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewWordsToolStripMenuItem.Click
        Startt.Show()
        Me.Close()
    End Sub

    Private Sub SameWordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SameWordsToolStripMenuItem.Click
        load_game()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub
End Class
