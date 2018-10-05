Imports System.Data.SqlClient

Public Class DeptDetailsForm
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd As New SqlCommand()

        Me.IdTextBox.Text = DefineGlobals.CurrentDepartmentId
        Me.IdTextBox.TabStop = False 'removeannoying blue tab selection
        Me.NameTextBox.Text = DefineGlobals.CurrentDepartmentName
        Me.NameTextBox.TabStop = False
        Me.LocationTextBox.Text = DefineGlobals.CurrentDepartmentLocation
        Me.LocationTextBox.TabStop = False

        cmd.CommandText = "SELECT emp.Id, emp.Name, emp.Title, emp.Manager, (SELECT man.Name FROM Employee man WHERE emp.Manager = man.Id) As ManagerName, emp.HireDate, emp.Salary, FORMAT(emp.Salary, 'C', 'en-us') AS SalaryFormatted FROM Dbo.Employee emp WHERE DepartmentId = '" + DefineGlobals.CurrentDepartmentId.ToString() + "'"
        cmd.Connection = DefineGlobals.SqlConn

        Try
            DefineGlobals.SqlConn.Open()
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet

            da.Fill(ds, "Employees")

            EmployeeDataGridView.DataSource = ds.Tables("Employees")
            EmployeeDataGridView.Columns(0).HeaderText = "Employee Id" 'Change header text of Id
            EmployeeDataGridView.Columns(3).HeaderText = "Manager Id" 'Change header text of Id
            EmployeeDataGridView.Columns(4).HeaderText = "Hire Date" 'Change header text of Id
            EmployeeDataGridView.ClearSelection() 'Remove cell blue selection background
        Finally
            DefineGlobals.SqlConn.Close()
        End Try

        Dim x As Int16
        x = 0
        Dim tempId As Int16
        Dim tempName As String
        Dim tempManagerId As Int16

        For Each row As DataGridViewRow In Me.EmployeeDataGridView.Rows
            If Not row.IsNewRow Then
                tempId = row.Cells(0).Value
                tempName = row.Cells(1).Value.ToString()

                If Not row.Cells(3).Value Is Nothing Then
                    Try
                        tempManagerId = Integer.Parse(row.Cells(3).Value)
                    Catch
                        tempManagerId = 0
                    End Try

                    If Not DefineGlobals.NameCache.ContainsKey(tempId) Then
                        ' Write values to the cache.
                        DefineGlobals.NameCache.Add(tempId, tempName)
                    End If

                    If Not DefineGlobals.ManagerCache.ContainsKey(tempId) Then
                        ' Write values to the cache.
                        DefineGlobals.ManagerCache.Add(tempId, tempManagerId)
                    End If

                    x += 1
                End If
            End If
        Next
    End Sub

    Private Sub EmployeeDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles EmployeeDataGridView.CellClick
        Dim _colIndex = e.ColumnIndex
        Dim _rowIndex = e.RowIndex

        Dim _currentEmployeeId = Me.EmployeeDataGridView.Item(0, _rowIndex).Value.ToString()
        Dim _currentEmployeeName = Me.EmployeeDataGridView.Item(1, _rowIndex).Value.ToString()
        Dim _currentEmployeeTitle = Me.EmployeeDataGridView.Item(2, _rowIndex).Value.ToString()

        Dim _currentEmployeeManager As Int16
        If Me.EmployeeDataGridView.Item(3, _rowIndex).Value Is Nothing Or String.IsNullOrWhiteSpace(Me.EmployeeDataGridView.Item(3, _rowIndex).Value.ToString()) Then
            _currentEmployeeManager = 0
        Else
            _currentEmployeeManager = Me.EmployeeDataGridView.Item(3, _rowIndex).Value
        End If

        Dim _currentEmployeeManagerName As String
        _currentEmployeeManagerName = "N/A"
        If DefineGlobals.ManagerCache.ContainsKey(_currentEmployeeId) Then
            If DefineGlobals.NameCache.ContainsKey(DefineGlobals.ManagerCache.Item(_currentEmployeeId)) Then
                _currentEmployeeManagerName = DefineGlobals.NameCache.Item(DefineGlobals.ManagerCache.Item(_currentEmployeeId))
            ElseIf DefineGlobals.ManagerCache.Item(_currentEmployeeId).ToString().Equals("0") Then
                _currentEmployeeManagerName = "N/A"
            Else
                _currentEmployeeManagerName = "Emp ID #" & DefineGlobals.ManagerCache.Item(_currentEmployeeId).ToString()
            End If
        End If

        Dim _currentEmployeeHireDate = Me.EmployeeDataGridView.Item(4, _rowIndex).Value.ToString()
        Dim _currentEmployeeSalary = Me.EmployeeDataGridView.Item(5, _rowIndex).Value
        Dim _currentEmployeeSalaryFormatted = FormatCurrency(_currentEmployeeSalary, , TriState.True, TriState.True)

        DefineGlobals.CurrentEmployeeId = _currentEmployeeId
        DefineGlobals.CurrentEmployeeName = _currentEmployeeName
        DefineGlobals.CurrentEmployeeTitle = _currentEmployeeTitle
        DefineGlobals.CurrentEmployeeManager = _currentEmployeeManager
        DefineGlobals.CurrentEmployeeManagerName = _currentEmployeeManagerName
        DefineGlobals.CurrentEmployeeHireDate = _currentEmployeeHireDate
        DefineGlobals.CurrentEmployeeSalary = _currentEmployeeSalary
        DefineGlobals.CurrentEmployeeSalaryFormatted = _currentEmployeeSalaryFormatted

        DefineGlobals.CurrentEmployeeDepartmentName = DefineGlobals.CurrentDepartmentName
        EmployeeDetailsForm.ShowDialog()
    End Sub
End Class