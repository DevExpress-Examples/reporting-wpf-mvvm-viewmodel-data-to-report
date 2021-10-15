Imports System
Imports System.Data.Entity

Namespace PassDataFromViewModelToReport.Data
	Public Class NWindDBContext
		Inherits DbContext

		Shared Sub New()
			Database.SetInitializer(New NullDatabaseInitializer(Of NWindDBContext)())
		End Sub
		Public Property Employees() As DbSet(Of Employee)

		Public Sub New()
			MyBase.New("name=NWindConnectionString")
		End Sub
	End Class

	Public Class Employee
		Public Property EmployeeID() As Integer
		Public Property LastName() As String
		Public Property FirstName() As String
		Public Property Title() As String
		Public Property TitleOfCourtesy() As String
		Public Property BirthDate() As Date
		Public Property HireDate() As Date
		Public Property Address() As String
		Public Property City() As String
		Public Property Region() As String
		Public Property PostalCode() As String
		Public Property Country() As String
		Public Property HomePhone() As String
		Public Property Extension() As String
		Public Property Photo() As Byte()
		Public Property Notes() As String
		Public Property ReportsTo() As Integer?
		Public Property PhotoPath() As String
		Public Property GroupName() As String
		Public Property Email() As String
	End Class
End Namespace
