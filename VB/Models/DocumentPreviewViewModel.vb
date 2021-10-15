Imports DevExpress.Mvvm
Imports DevExpress.XtraReports.UI

Namespace PassDataFromViewModelToReport.Models
	Public Class DocumentPreviewViewModel
		Inherits BindableBase

		Public ReadOnly Property Report() As XtraReport
		Public Sub New(ByVal report As XtraReport)
			Me.Report = report
		End Sub
	End Class
End Namespace
