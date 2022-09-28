Public Class studentGradingSystemForm

    'Student grading system form.
    Private Sub studentGradingSystemForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'To center the form.
        Me.CenterToScreen()

    End Sub

    'Exit Button 1
    Private Sub exitBtn1_Click(sender As Object, e As EventArgs) Handles exitBtn1.Click
        'To exit the form.
        Me.Hide()



    End Sub

    'Submit Button
    Private Sub submitBtn_Click(sender As Object, e As EventArgs) Handles submitBtn.Click

        'Call result form
        Dim form2 As New resultForm



        form2.nameResult.Text = nameTextBox.Text
        form2.sectionResult.Text = sectionComboBox.Text

        If maleRadioBtn1.Checked = True And femaleRadioBtn2.Checked = False Then
            form2.sexResult.Text = maleRadioBtn1.Text
        ElseIf maleRadioBtn1.Checked = False And femaleRadioBtn2.Checked = True Then
            form2.sexResult.Text = femaleRadioBtn2.Text
        End If

        form2.studNoResult.Text = studNoTextBox.Text

        If nameTextBox.Text = String.Empty Or sectionComboBox.Text = String.Empty Or studNoTextBox.Text = String.Empty Or midGradeTextBox.Text = String.Empty Or finalGradeTextBox.Text = String.Empty Then
            MsgBox("PLEASE, DO NOT LEAVE EACH TEXTBOX BLANK!", vbOKOnly)
        Else
            form2.Show()
            Me.Hide()
        End If





        'Initialize midter and final grade.
        Dim midtermgrade = Val(midGradeTextBox.Text)
        Dim finalgrade = Val(finalGradeTextBox.Text)

        'Formula to get the GWA
        Dim gwa = (midtermgrade + finalgrade) / 2


        If gwa > 100 Then
            form2.gwaResult.Text = "INVALID"
            form2.gwaResult2.Text = "GRADES!"
            form2.gwaResult.ForeColor = Color.Red
            form2.gwaResult2.ForeColor = Color.Red
            form2.statusResult.Text = "INVALID STATUS!"
            form2.statusResult.ForeColor = Color.Red

        ElseIf gwa <= 100 And gwa >= 98 Then
            form2.gwaResult.Text = gwa
            form2.gwaResult2.Text = " or      1.00"
            form2.gwaResult.ForeColor = Color.Green
            form2.gwaResult2.ForeColor = Color.Green
            form2.statusResult.Text = "PASSED!"
            form2.statusResult.ForeColor = Color.Green

        ElseIf gwa <= 97.9 And gwa >= 95 Then
            form2.gwaResult.Text = gwa
            form2.gwaResult2.Text = " or      1.25"
            form2.gwaResult.ForeColor = Color.Green
            form2.gwaResult2.ForeColor = Color.Green
            form2.statusResult.Text = "PASSED!"
            form2.statusResult.ForeColor = Color.Green

        ElseIf gwa <= 94.9 And gwa >= 92 Then
            form2.gwaResult.Text = gwa
            form2.gwaResult2.Text = " or      1.50"
            form2.gwaResult.ForeColor = Color.Green
            form2.gwaResult2.ForeColor = Color.Green
            form2.statusResult.Text = "PASSED!"
            form2.statusResult.ForeColor = Color.Green

        ElseIf gwa <= 91.9 And gwa >= 89 Then
            form2.gwaResult.Text = gwa
            form2.gwaResult2.Text = " or      1.75"
            form2.gwaResult.ForeColor = Color.Green
            form2.gwaResult2.ForeColor = Color.Green
            form2.statusResult.Text = "PASSED!"
            form2.statusResult.ForeColor = Color.Green

        ElseIf gwa <= 88.9 And gwa >= 86 Then
            form2.gwaResult.Text = gwa
            form2.gwaResult2.Text = " or      2.00"
            form2.gwaResult.ForeColor = Color.Green
            form2.gwaResult2.ForeColor = Color.Green
            form2.statusResult.Text = "PASSED!"
            form2.statusResult.ForeColor = Color.Green

        ElseIf gwa <= 85.9 And gwa >= 83 Then
            form2.gwaResult.Text = gwa
            form2.gwaResult2.Text = " or      2.25"
            form2.gwaResult.ForeColor = Color.Green
            form2.gwaResult2.ForeColor = Color.Green
            form2.statusResult.Text = "PASSED!"
            form2.statusResult.ForeColor = Color.Green

        ElseIf gwa <= 82.9 And gwa >= 80 Then
            form2.gwaResult.Text = gwa
            form2.gwaResult2.Text = " or      2.50"
            form2.gwaResult.ForeColor = Color.Green
            form2.gwaResult2.ForeColor = Color.Green
            form2.statusResult.Text = "PASSED!"
            form2.statusResult.ForeColor = Color.Green

        ElseIf gwa <= 79.9 And gwa >= 77 Then
            form2.gwaResult.Text = gwa
            form2.gwaResult2.Text = " or      2.75"
            form2.gwaResult.ForeColor = Color.Green
            form2.gwaResult2.ForeColor = Color.Green
            form2.statusResult.Text = "PASSED!"
            form2.statusResult.ForeColor = Color.Green

        ElseIf gwa <= 76.9 And gwa >= 75 Then
            form2.gwaResult.Text = gwa
            form2.gwaResult2.Text = " or      3.00"
            form2.gwaResult.ForeColor = Color.Green
            form2.gwaResult2.ForeColor = Color.Green
            form2.statusResult.Text = "PASSED!"
            form2.statusResult.ForeColor = Color.Green
        Else
            form2.gwaResult.Text = gwa
            form2.gwaResult2.Text = " or      5.00"
            form2.gwaResult.ForeColor = Color.Red
            form2.gwaResult2.ForeColor = Color.Red
            form2.statusResult.Text = "FAILED!"
            form2.statusResult.ForeColor = Color.Red

        End If



    End Sub

    'Clear Button
    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        'To clear the value
        nameTextBox.Text = ""
        sectionComboBox.Text = ""
        studNoTextBox.Text = ""
        midGradeTextBox.Text = ""
        finalGradeTextBox.Text = ""

    End Sub


End Class