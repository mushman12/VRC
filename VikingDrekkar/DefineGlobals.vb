Imports System.Data.SqlClient
Imports System.Collections.Generic

Public Class DefineGlobals
    Public Shared WithEvents SqlConn As SqlConnection
    Public Shared MySqlConnectionString As String

    Public Shared CurrentDepartmentId As Int16
    Public Shared CurrentDepartmentName As String
    Public Shared CurrentDepartmentLocation As String

    Public Shared CurrentEmployeeDepartmentName As String

    Public Shared CurrentEmployeeId As Int16
    Public Shared CurrentEmployeeName As String
    Public Shared CurrentEmployeeTitle As String
    Public Shared CurrentEmployeeManager As Int16
    Public Shared CurrentEmployeeManagerName As String
    Public Shared CurrentEmployeeHireDate As String
    Public Shared CurrentEmployeeSalary As String
    Public Shared CurrentEmployeeSalaryFormatted As String

    Public Shared DepartmentCache As Dictionary(Of Int16, String)
    Public Shared ManagerCache As Dictionary(Of Int16, Int16) 'Managed employee managed by Manager (Employee, Manager)
    Public Shared NameCache As Dictionary(Of Int16, String)
End Class
