Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.XtraReports.UI
Imports System.Collections.Generic
Imports System.Data.Entity

Namespace PassDataFromViewModelToReport.Models
	Public Class MainViewModel
		Inherits ViewModelBase

		Private ReadOnly dbContext As New Data.NWindDBContext()

		Public ReadOnly Property Employees() As IEnumerable(Of Data.Employee)

		Public Property SelectedEmployee As Data.Employee
			Get
				Return GetProperty(Function() SelectedEmployee)
			End Get
			Set(ByVal value As Data.Employee)
				SetProperty(Function() SelectedEmployee, value)
			End Set
		End Property

		Public Sub New()
			dbContext.Employees.Load()
			Employees = dbContext.Employees.Local
		End Sub

		<Command(CanExecuteMethodName := nameof(CanShowPrintPreview))>
		Public Sub ShowPrintPreview()
			Dim report As XtraReport = New EmployeeReport(dbContext)
			report.Parameters("EmployeeId").Value = SelectedEmployee.EmployeeID
			Using report
				GetService(Of IDialogService)().ShowDialog(New MessageButton(), "Print Preview", New DocumentPreviewViewModel(report))
			End Using
		End Sub
		Public Function CanShowPrintPreview() As Boolean
			Return SelectedEmployee IsNot Nothing
		End Function
	End Class
End Namespace
