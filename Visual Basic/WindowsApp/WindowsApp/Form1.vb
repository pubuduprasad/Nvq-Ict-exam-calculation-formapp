Public Class VBForm


	Private Sub CalculateBTN_Click(sender As Object, e As EventArgs) Handles CalculateBTN.Click
		Dim test1 As Integer = Integer.Parse(Me.MsWord.Text)
		Dim test2 As Integer = Integer.Parse(Me.MsExcel.Text)
		Dim test3 As Integer = Integer.Parse(Me.MsAccess.Text)
		Dim test4 As Integer = Integer.Parse(Me.MsPowerPoint.Text)
		Dim average As Double = Convert.ToDouble(test1 + test2 + test3 + test4) / 3.0
		Me.AverageResult.Text = average.ToString("n1")
		Dim total As Integer = Integer.Parse(Me.MsWord.Text) + Integer.Parse(Me.MsExcel.Text) + Integer.Parse(Me.MsAccess.Text) + Integer.Parse(Me.MsPowerPoint.Text)
		Me.TotalResult.Text = total.ToString()
		If average >= 75.0 And average <= 85.0 Then
			Me.GradeResult.Text = "A"
		Else
			If average >= 65.0 And average <= 75.0 Then
				Me.GradeResult.Text = "C"
			Else
				If average >= 55.0 And average <= 65.0 Then
					Me.GradeResult.Text = "S"
				Else
					If average <= 55.0 Then
						Me.GradeResult.Text = "Fail"
					End If
				End If
			End If
		End If
		If average >= 50.0 And average <= 85.0 Then
			Me.CompetentResult.Text = "Yes"
		End If
		If average <= 50.0 Then
			Me.CompetentResult.Text = "No"
		End If
	End Sub

	Private Sub ClearBTN_Click(sender As Object, e As EventArgs) Handles ClearBTN.Click
		Me.Name.Text = Nothing
		Me.MsWord.Text = Nothing
		Me.MsExcel.Text = Nothing
		Me.MsAccess.Text = Nothing
		Me.MsPowerPoint.Text = Nothing
		Me.TotalResult.Text = Nothing
		Me.AverageResult.Text = Nothing
		Me.CompetentResult.Text = Nothing
		Me.GradeResult.Text = Nothing
	End Sub

	Private Sub ExitBTN_Click(sender As Object, e As EventArgs) Handles ExitBTN.Click
		Application.[Exit]()
	End Sub

	Private Sub linkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkLabel.LinkClicked
		Process.Start("https://github.com/pubuduprasad")
	End Sub
End Class
