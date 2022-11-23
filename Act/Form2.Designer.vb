<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboFacultyrank = New System.Windows.Forms.ComboBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.rdbA = New System.Windows.Forms.RadioButton()
        Me.rdbB = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMS = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.txtGSIS = New System.Windows.Forms.TextBox()
        Me.txtPhil = New System.Windows.Forms.TextBox()
        Me.txtNp = New System.Windows.Forms.TextBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(73, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(73, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Faculty Rank:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Salary Grade (SG)"
        '
        'cboFacultyrank
        '
        Me.cboFacultyrank.FormattingEnabled = True
        Me.cboFacultyrank.Location = New System.Drawing.Point(152, 116)
        Me.cboFacultyrank.Name = "cboFacultyrank"
        Me.cboFacultyrank.Size = New System.Drawing.Size(154, 21)
        Me.cboFacultyrank.TabIndex = 3
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(152, 83)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(154, 20)
        Me.txtName.TabIndex = 3
        '
        'rdbA
        '
        Me.rdbA.AutoSize = True
        Me.rdbA.Location = New System.Drawing.Point(117, 177)
        Me.rdbA.Name = "rdbA"
        Me.rdbA.Size = New System.Drawing.Size(32, 17)
        Me.rdbA.TabIndex = 5
        Me.rdbA.TabStop = True
        Me.rdbA.Text = "A"
        Me.rdbA.UseVisualStyleBackColor = True
        '
        'rdbB
        '
        Me.rdbB.AutoSize = True
        Me.rdbB.Location = New System.Drawing.Point(227, 179)
        Me.rdbB.Name = "rdbB"
        Me.rdbB.Size = New System.Drawing.Size(32, 17)
        Me.rdbB.TabIndex = 6
        Me.rdbB.TabStop = True
        Me.rdbB.Text = "B"
        Me.rdbB.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 225)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Monthly Salary"
        '
        'txtMS
        '
        Me.txtMS.Location = New System.Drawing.Point(117, 222)
        Me.txtMS.Name = "txtMS"
        Me.txtMS.Size = New System.Drawing.Size(100, 20)
        Me.txtMS.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 262)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Tax:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 290)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "GSIS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 316)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "PhilHealth"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 343)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Net Pay:"
        '
        'txtTax
        '
        Me.txtTax.Location = New System.Drawing.Point(80, 259)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(100, 20)
        Me.txtTax.TabIndex = 13
        '
        'txtGSIS
        '
        Me.txtGSIS.Location = New System.Drawing.Point(80, 285)
        Me.txtGSIS.Name = "txtGSIS"
        Me.txtGSIS.Size = New System.Drawing.Size(100, 20)
        Me.txtGSIS.TabIndex = 14
        '
        'txtPhil
        '
        Me.txtPhil.Location = New System.Drawing.Point(80, 316)
        Me.txtPhil.Name = "txtPhil"
        Me.txtPhil.Size = New System.Drawing.Size(100, 20)
        Me.txtPhil.TabIndex = 15
        '
        'txtNp
        '
        Me.txtNp.Location = New System.Drawing.Point(80, 343)
        Me.txtNp.Name = "txtNp"
        Me.txtNp.Size = New System.Drawing.Size(100, 20)
        Me.txtNp.TabIndex = 16
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(334, 222)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 49)
        Me.btnReset.TabIndex = 17
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(334, 298)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 49)
        Me.btnExit.TabIndex = 18
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(182, 50)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 16)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Salary Form"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 374)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.txtNp)
        Me.Controls.Add(Me.txtPhil)
        Me.Controls.Add(Me.txtGSIS)
        Me.Controls.Add(Me.txtTax)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtMS)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.rdbB)
        Me.Controls.Add(Me.rdbA)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.cboFacultyrank)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboFacultyrank As System.Windows.Forms.ComboBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents rdbA As System.Windows.Forms.RadioButton
    Friend WithEvents rdbB As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMS As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTax As System.Windows.Forms.TextBox
    Friend WithEvents txtGSIS As System.Windows.Forms.TextBox
    Friend WithEvents txtPhil As System.Windows.Forms.TextBox
    Friend WithEvents txtNp As System.Windows.Forms.TextBox
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
