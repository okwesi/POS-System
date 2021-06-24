Imports System.Data.SQLite

Public Class change_password

    Public connectionstring As String = String.Format("Datasource = " & Application.StartupPath & "\databases\database1.db ")

    Private Sub change_password_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtoldpassword.Select()
    End Sub

    Private Sub txtoldpassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtoldpassword.KeyDown
        If e.KeyCode = Keys.Down Then
            txtnewpassword.Select()
        End If
    End Sub

    Private Sub txtnewpassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnewpassword.KeyDown
        If e.KeyCode = Keys.Down Then
            txtrepeatpassword.Select()
        ElseIf e.KeyCode = Keys.Up Then
            txtoldpassword.Select()
        End If
    End Sub

    Private Sub txtrepeatpassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtrepeatpassword.KeyDown
        If e.KeyCode = Keys.Up Then
            txtnewpassword.Select()
        End If
        If e.KeyCode = Keys.Enter Then
            change_password()
        End If
    End Sub


    Public Sub change_password()
        Dim password As String = Nothing

        If txtnewpassword.Text = txtrepeatpassword.Text Then
            password = txtrepeatpassword.Text
        Else
            lblpassword.Text = "new password and repeat password doesnt match"
        End If
        Try
            Using con As New SQLiteConnection(connectionstring)
                Dim getpassword As String = "Select * from logintable where name = '" & txtoldpassword.Text & "' "
                Dim command As New SQLiteCommand(getpassword, con)
                con.Open()
                Dim reader As SQLiteDataReader = command.ExecuteReader

                If reader.Read() Then

                    Using conn As New SQLiteConnection(connectionstring)
                        Dim updatepassword As String = "Update logintable Set name = @newname where name = '" & txtoldpassword.Text & "' "
                        Dim command1 As New SQLiteCommand(updatepassword, con)
                        command1.Parameters.AddWithValue("@newname", password)
                        conn.Open()
                        command1.ExecuteNonQuery()

                        lblpassword.Text = "Password Updated !!"
                    End Using
                End If

            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnchange_Click(sender As Object, e As EventArgs) Handles btnchange.Click
        change_password()
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
        LOGIN.Show()
    End Sub

    Private Sub cbshowpassword_CheckedChanged(sender As Object, e As EventArgs) Handles cbshowpassword.CheckedChanged
        If cbshowpassword.Checked = True Then
            txtoldpassword.PasswordChar = ""
            txtnewpassword.PasswordChar = ""
            txtrepeatpassword.PasswordChar = ""
        End If
    End Sub


End Class

