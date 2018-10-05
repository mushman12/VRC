Imports System.Data.SqlClient

Public Class EmployeeDetailsForm
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.NameTextBox.Text = DefineGlobals.CurrentEmployeeName
        Me.EmployeeIdTextLabel.Text = DefineGlobals.CurrentEmployeeId
        Me.TitleTextBox.Text = DefineGlobals.CurrentEmployeeTitle
        Me.SalaryTextBox.Text = FormatCurrency(DefineGlobals.CurrentEmployeeSalary, , TriState.True, TriState.True)

        If Not String.IsNullOrWhiteSpace(DefineGlobals.CurrentEmployeeManagerName) Then
            Me.ManagerTextLabel.Text = DefineGlobals.CurrentEmployeeManagerName
        ElseIf DefineGlobals.ManagerCache.ContainsKey(DefineGlobals.CurrentEmployeeId) And DefineGlobals.ManagerCache.ContainsValue(DefineGlobals.CurrentEmployeeManager) Then
            Dim empId As Int16
            empId = DefineGlobals.CurrentEmployeeId
            Dim manId As Int16
            If Not String.IsNullOrWhiteSpace(DefineGlobals.CurrentEmployeeManager) Then
                manId = DefineGlobals.ManagerCache.Item(empId)
                Dim manName As String
                manName = DefineGlobals.NameCache.Item(manId)
                Me.ManagerTextLabel.Text = manName
            Else
                Me.ManagerTextLabel.Text = "N/A"
            End If
        Else
            Me.ManagerTextLabel.Text = "N/A"
        End If

        Me.HireDateDateTimePicker.Value = DefineGlobals.CurrentEmployeeHireDate

        If Not String.IsNullOrWhiteSpace(DefineGlobals.CurrentEmployeeDepartmentName) Then
            Me.DepartmentTextLabel.Text = DefineGlobals.CurrentEmployeeDepartmentName
        ElseIf DefineGlobals.DepartmentCache.ContainsKey(DefineGlobals.CurrentDepartmentId) Then
            Dim deptId As Int16
            deptId = DefineGlobals.CurrentDepartmentId
            Dim deptName As String
            deptName = DefineGlobals.DepartmentCache.Item(deptId)
            Me.DepartmentTextLabel.Text = deptName
        Else
            Me.DepartmentTextLabel.Text = DefineGlobals.CurrentDepartmentId.ToString()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub SaveEmployeeData(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As New SqlCommand()

        Me.Validate()
        Me.EmployeeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.VRCTestDBDataSet)

        DefineGlobals.CurrentEmployeeName = NameTextBox.Text
        DefineGlobals.CurrentEmployeeTitle = TitleTextBox.Text
        DefineGlobals.CurrentEmployeeHireDate = HireDateDateTimePicker.Value
        DefineGlobals.CurrentEmployeeSalary = SalaryTextBox.Text

        Dim updateCommand As String
        updateCommand = "UPDATE Dbo.Employee SET Name = @Name, Title = @Title, HireDate = @HireDate, Salary = @Salary WHERE Id = @EmpId"

        cmd.CommandText = "SELECT * FROM Dbo.Employee WHERE Id = @EmpId"
        cmd.Connection = DefineGlobals.SqlConn

        Try
            DefineGlobals.SqlConn.Open()
            cmd.Parameters.Add(New SqlParameter("@EmpId", SqlDbType.VarChar))
            cmd.Parameters("@EmpId").Value = DefineGlobals.CurrentEmployeeId

            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "Employees")

            cmd.Parameters.Add(New SqlParameter("@Name", SqlDbType.VarChar))
            cmd.Parameters("@Name").Value = DefineGlobals.CurrentEmployeeName
            cmd.Parameters.Add(New SqlParameter("@Title", SqlDbType.VarChar))
            cmd.Parameters("@Title").Value = DefineGlobals.CurrentEmployeeTitle
            cmd.Parameters.Add(New SqlParameter("@HireDate", SqlDbType.Date))
            cmd.Parameters("@HireDate").Value = DefineGlobals.CurrentEmployeeHireDate
            cmd.Parameters.Add(New SqlParameter("@Salary", SqlDbType.VarChar))
            cmd.Parameters("@Salary").Value = DefineGlobals.CurrentEmployeeSalary

            cmd.CommandText = updateCommand

            da.UpdateCommand = cmd
            da.Fill(ds, "Employees")

            'Update the info on form 2
            DeptDetailsForm.EmployeeDataGridView.DataSource = ds.Tables("Employees")
            DeptDetailsForm.EmployeeDataGridView.ClearSelection() 'Remove cell blue selection background
        Finally
            DefineGlobals.SqlConn.Close()
        End Try

        cmd.CommandText = "SELECT emp.Id, emp.Name, emp.Title, emp.Manager, (SELECT man.Name FROM Employee man WHERE emp.Manager = man.Id) As ManagerName, emp.HireDate, emp.Salary, FORMAT(emp.Salary, 'C', 'en-us') AS 'SalaryFormatted' FROM Dbo.Employee emp WHERE DepartmentId = '" + DefineGlobals.CurrentDepartmentId.ToString() + "'"

        Try
            DefineGlobals.SqlConn.Open()
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet

            da.Fill(ds, "Employees")

            'Update the info on form 2
            DeptDetailsForm.EmployeeDataGridView.DataSource = ds.Tables("Employees")
            DeptDetailsForm.EmployeeDataGridView.ClearSelection() 'Remove cell blue selection background
        Finally
            DefineGlobals.SqlConn.Close()
        End Try

        MsgBox("Employee data saved.")
        Me.Close()
    End Sub
End Class