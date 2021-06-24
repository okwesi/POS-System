Imports System.Data.SQLite

Public Class LOGIN

    Public connectionstring As String = String.Format("Datasource = " & Application.StartupPath & "\databases\database1.db ")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtpassword.Select()
    End Sub

    Private Sub closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        If MessageBox.Show("Are you sure you want to close this application?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub lbl_changepassword_Click(sender As Object, e As EventArgs) Handles lbl_changepassword.Click
        change_password.Show()
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click

        Try
            Using con As New SQLiteConnection(connectionstring)
                Dim getpassword As String = "Select * from logintable where name = '" & txtpassword.Text & "' "
                Dim command As New SQLiteCommand(getpassword, con)
                con.Open()
                Dim reader As SQLiteDataReader = command.ExecuteReader
                Dim correct As Boolean = reader.Read()
                reader.Close()
                If correct = False Then
                    MsgBox("Wrong Password", MsgBoxStyle.Exclamation, "Warning!!")
                    txtpassword.Text = Nothing
                    txtpassword.Select()
                Else
                    Me.Hide()
                    MainForm.Show()
                    txtpassword.Text = Nothing
                End If
                con.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtpassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnlogin.PerformClick()
        End If
    End Sub

    Private Sub cbshowpassword_CheckedChanged(sender As Object, e As EventArgs) Handles cbshowpassword.CheckedChanged
        If cbshowpassword.Checked = True Then
            txtpassword.PasswordChar = ""
        End If
    End Sub


End Class
