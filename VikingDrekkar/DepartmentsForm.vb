Imports System.Data.SqlClient

Public Class DepartmentsForm
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DefineGlobals.NameCache = New Dictionary(Of Short, String)
        DefineGlobals.ManagerCache = New Dictionary(Of Short, Short)
        DefineGlobals.DepartmentCache = New Dictionary(Of Short, String)

        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText("..\..\connect.txt")

        DefineGlobals.MySqlConnectionString = fileReader
        DefineGlobals.SqlConn = New SqlConnection(DefineGlobals.MySqlConnectionString)

        Dim cmd As New SqlCommand()

        cmd.CommandText = "SELECT * FROM Dbo.Department"
        cmd.Connection = DefineGlobals.SqlConn

        Try
            DefineGlobals.SqlConn.Open()
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet

            da.Fill(ds, "Department")

            DepartmentDataGridView.DataSource = ds.Tables("Department")
        Finally
            DefineGlobals.SqlConn.Close()
        End Try

        'TODO: This line of code loads data into the 'VRCTestDBDataSet.Department' table. You can move, or remove it, as needed.
        Me.DepartmentTableAdapter.Fill(Me.VRCTestDBDataSet.Department)

        Dim x As Int16
        x = 0
        Dim tempDeptId As Int16
        Dim tempDeptName As String

        For Each row As DataGridViewRow In Me.DepartmentDataGridView.Rows
            If Not row.IsNewRow Then
                tempDeptId = row.Cells(0).Value
                tempDeptName = row.Cells(1).Value
                DefineGlobals.DepartmentCache.Add(tempDeptId, tempDeptName)
                x += 1
            End If
        Next
    End Sub

    Private Sub DepartmentDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DepartmentDataGridView.CellClick
        Dim colIndex = e.ColumnIndex
        Dim rowIndex = e.RowIndex
        Dim idClicked = Me.DepartmentDataGridView.Item(0, rowIndex).Value.ToString()
        Dim deptNameClicked = Me.DepartmentDataGridView.Item(1, rowIndex).Value.ToString()
        Dim deptLocationClicked = Me.DepartmentDataGridView.Item(2, rowIndex).Value.ToString()
        DefineGlobals.CurrentDepartmentId = idClicked
        DefineGlobals.CurrentDepartmentName = deptNameClicked
        DefineGlobals.CurrentDepartmentLocation = deptLocationClicked
        DeptDetailsForm.ShowDialog()
    End Sub
End Class
