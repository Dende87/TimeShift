Public Class clsErrorHandler

	Shared Sub ErrorMessage(strErrorMessage As String)
		MessageBox.Show("Sage dem Dende bescheid!" + vbNewLine + vbNewLine + strErrorMessage, "Meldung", MessageBoxButtons.OK, MessageBoxIcon.Information)
	End Sub

End Class
