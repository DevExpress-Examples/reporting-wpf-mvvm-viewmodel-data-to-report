Imports DevExpress.XtraReports.UI
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Namespace PassDataFromViewModelToReport
	Partial Public Class EmployeeReport
		Inherits DevExpress.XtraReports.UI.XtraReport

		Public Sub New()
			InitializeComponent()
		End Sub

		Public Sub New(ByVal dataSource As Object)
			Me.New()
			objectDataSource1.DataSource = dataSource
		End Sub
	End Class
End Namespace
