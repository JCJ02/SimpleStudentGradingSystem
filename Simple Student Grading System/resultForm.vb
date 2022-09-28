Public Class resultForm
    'Result form
    Private Sub resultForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'To center the form.
        Me.CenterToScreen()


    End Sub

    'Save Button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form1 As New studentGradingSystemForm
        form1.Show()
        Me.Hide()



    End Sub


End Class