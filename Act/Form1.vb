Public Class Form1
    Dim x, ctr As Integer
    Private Sub txtUN_Keypress(sender As Object, e As KeyPressEventArgs) Handles txtUN.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtPass.Focus()
        End If
    End Sub

    Private Sub txtPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPass.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If txtUN.Text = "admin" And txtPass.Text = "admin" Then
                MsgBox("Password Accepted!", vbOKOnly + vbInformation, "Password")
                Form2.Show()
                Me.Hide()
            Else
                x = MsgBox("Incorrect Password!", vbCritical + vbRetryCancel, "Password")
                If x = vbRetry Then 'or 4
                    txtPass.Clear()
                    txtUN.Clear()
                    txtUN.Focus()
                    ctr = ctr + 1
                    If ctr = 3 Then
                        MsgBox("System Locked!" + Chr(13) + "Program will be terminated", vbOKOnly + vbCritical, "Password")
                        Application.Exit()
                    End If
                ElseIf x = vbCancel Then 'or 2
                    Application.Exit()
                End If
            End If
        End If
    End Sub

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        If txtUN.Text = "admin" And txtPass.Text = "admin" Then
            MsgBox("Password Accepted!", vbOKOnly + vbInformation, "Password")
            Form2.Show()
            Me.Hide()
        Else
            x = MsgBox("Incorrect Password!", vbCritical + vbRetryCancel, "Password")
            If x = vbRetry Then 'or 4
                txtPass.Clear()
                txtUN.Focus()
                ctr = ctr + 1
                If ctr = 3 Then
                    MsgBox("System Locked!" + Chr(13) + "Program will be terminated", vbOKOnly + vbCritical, "Password")
                    Application.Exit()
                End If
            ElseIf x = vbCancel Then 'or 2
                Application.Exit()
            End If
        End If
    End Sub
End Class
