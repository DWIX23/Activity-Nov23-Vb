Public Class Form2

    Private Sub cboFacultyrank_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFacultyrank.SelectedIndexChanged
        If rdbA.Checked = True Then
            If cboFacultyrank.SelectedIndex = 0 Then
                txtMS.Text = 20000
            ElseIf cboFacultyrank.SelectedIndex = 1 Then
                txtMS.Text = 25000
            ElseIf cboFacultyrank.SelectedIndex = 2 Then
                txtMS.Text = 30000
            ElseIf cboFacultyrank.SelectedIndex = 3 Then
                txtMS.Text = 35000
            ElseIf cboFacultyrank.SelectedIndex = 4 Then
                txtMS.Text = 40000
            End If
        End If

        If rdbB.Checked = True Then
            If cboFacultyrank.SelectedIndex = 0 Then
                txtMS.Text = 18000
            ElseIf cboFacultyrank.SelectedIndex = 1 Then
                txtMS.Text = 23000
            ElseIf cboFacultyrank.SelectedIndex = 2 Then
                txtMS.Text = 28000
            ElseIf cboFacultyrank.SelectedIndex = 3 Then
                txtMS.Text = 33000
            ElseIf cboFacultyrank.SelectedIndex = 4 Then
                txtMS.Text = 38000
            End If
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboFacultyrank.Items.Add("Instructor")
        cboFacultyrank.Items.Add("Assistant Professor")
        cboFacultyrank.Items.Add("Associate Professor")
        cboFacultyrank.Items.Add("Professor")
        cboFacultyrank.Items.Add("University Professor")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim yes As String
        yes = MsgBox("Do you Really want to exit?", vbQuestion + vbYesNo, "Exit")
        If yes = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub rdbA_CheckedChanged(sender As Object, e As EventArgs) Handles rdbA.CheckedChanged
        If rdbA.Checked = True Then
            If cboFacultyrank.SelectedIndex = 0 Then
                txtMS.Text = 20000
            ElseIf cboFacultyrank.SelectedIndex = 1 Then
                txtMS.Text = 25000
            ElseIf cboFacultyrank.SelectedIndex = 2 Then
                txtMS.Text = 30000
            ElseIf cboFacultyrank.SelectedIndex = 3 Then
                txtMS.Text = 35000
            ElseIf cboFacultyrank.SelectedIndex = 4 Then
                txtMS.Text = 40000
            End If
        End If
    End Sub

    Private Sub rdbB_CheckedChanged(sender As Object, e As EventArgs) Handles rdbB.CheckedChanged
        If rdbB.Checked = True Then
            If cboFacultyrank.SelectedIndex = 0 Then
                txtMS.Text = 18000
            ElseIf cboFacultyrank.SelectedIndex = 1 Then
                txtMS.Text = 23000
            ElseIf cboFacultyrank.SelectedIndex = 2 Then
                txtMS.Text = 28000
            ElseIf cboFacultyrank.SelectedIndex = 3 Then
                txtMS.Text = 33000
            ElseIf cboFacultyrank.SelectedIndex = 4 Then
                txtMS.Text = 38000
            End If
        End If
    End Sub

    Private Sub txtMS_TextChanged(sender As Object, e As EventArgs) Handles txtMS.TextChanged
        If Val(txtMS.Text) <= 25000 Then
            txtTax.Text = Val(txtMS.Text) * 0.1
        ElseIf Val(txtMS.Text) <= 35000 Then
            txtTax.Text = Val(txtMS.Text) * 0.15
        Else
            txtTax.Text = Val(txtMS.Text) * 0.2
        End If

        If Val(txtMS.Text) <= 25000 Then
            txtGSIS.Text = Val(txtMS.Text) * 0.08
        ElseIf Val(txtMS.Text) <= 35000 Then
            txtGSIS.Text = Val(txtMS.Text) * 0.13
        Else
            txtGSIS.Text = Val(txtMS.Text) * 0.18
        End If

        txtPhil.Text = Val(txtMS.Text) * 0.08
        txtNp.Text = Val(txtMS.Text) - (Val(txtPhil.Text) + Val(txtTax.Text) + Val(txtGSIS.Text))
    End Sub

    Private Sub txtNp_TextChanged(sender As Object, e As EventArgs) Handles txtNp.TextChanged

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtName.Clear()
        cboFacultyrank.SelectedIndex = -1
        rdbA.Checked = False
        rdbB.Checked = False
        txtPhil.Text = " "
        txtMS.Clear()
        txtTax.Clear()
        txtGSIS.Clear()
        txtNp.Clear()
        txtName.Focus()
    End Sub
End Class