<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EmployeeDetailsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IdLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim TitleLabel As System.Windows.Forms.Label
        Dim ManagerLabel As System.Windows.Forms.Label
        Dim HireDateLabel As System.Windows.Forms.Label
        Dim SalaryLabel As System.Windows.Forms.Label
        Dim DepartmentLabel As System.Windows.Forms.Label
        Me.VRCTestDBDataSet = New VikingDrekkar.VRCTestDBDataSet()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeTableAdapter = New VikingDrekkar.VRCTestDBDataSetTableAdapters.EmployeeTableAdapter()
        Me.TableAdapterManager = New VikingDrekkar.VRCTestDBDataSetTableAdapters.TableAdapterManager()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.HireDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SalaryTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ManagerTextLabel = New System.Windows.Forms.Label()
        Me.DepartmentTextLabel = New System.Windows.Forms.Label()
        Me.EmployeeIdTextLabel = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        TitleLabel = New System.Windows.Forms.Label()
        ManagerLabel = New System.Windows.Forms.Label()
        HireDateLabel = New System.Windows.Forms.Label()
        SalaryLabel = New System.Windows.Forms.Label()
        DepartmentLabel = New System.Windows.Forms.Label()
        CType(Me.VRCTestDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(27, 129)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(89, 17)
        IdLabel.TabIndex = 1
        IdLabel.Text = "Employee Id:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(27, 57)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(49, 17)
        NameLabel.TabIndex = 3
        NameLabel.Text = "Name:"
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.Location = New System.Drawing.Point(27, 93)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(66, 17)
        TitleLabel.TabIndex = 5
        TitleLabel.Text = "Job Title:"
        '
        'ManagerLabel
        '
        ManagerLabel.AutoSize = True
        ManagerLabel.Location = New System.Drawing.Point(27, 279)
        ManagerLabel.Name = "ManagerLabel"
        ManagerLabel.Size = New System.Drawing.Size(68, 17)
        ManagerLabel.TabIndex = 7
        ManagerLabel.Text = "Manager:"
        '
        'HireDateLabel
        '
        HireDateLabel.AutoSize = True
        HireDateLabel.Location = New System.Drawing.Point(27, 174)
        HireDateLabel.Name = "HireDateLabel"
        HireDateLabel.Size = New System.Drawing.Size(72, 17)
        HireDateLabel.TabIndex = 9
        HireDateLabel.Text = "Hire Date:"
        '
        'SalaryLabel
        '
        SalaryLabel.AutoSize = True
        SalaryLabel.Location = New System.Drawing.Point(27, 209)
        SalaryLabel.Name = "SalaryLabel"
        SalaryLabel.Size = New System.Drawing.Size(52, 17)
        SalaryLabel.TabIndex = 11
        SalaryLabel.Text = "Salary:"
        '
        'DepartmentLabel
        '
        DepartmentLabel.AutoSize = True
        DepartmentLabel.Location = New System.Drawing.Point(27, 250)
        DepartmentLabel.Name = "DepartmentLabel"
        DepartmentLabel.Size = New System.Drawing.Size(86, 17)
        DepartmentLabel.TabIndex = 13
        DepartmentLabel.Text = "Department:"
        '
        'VRCTestDBDataSet
        '
        Me.VRCTestDBDataSet.DataSetName = "VRCTestDBDataSet"
        Me.VRCTestDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "Employee"
        Me.EmployeeBindingSource.DataSource = Me.VRCTestDBDataSet
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DepartmentTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeTableAdapter = Me.EmployeeTableAdapter
        Me.TableAdapterManager.UpdateOrder = VikingDrekkar.VRCTestDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(134, 54)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(269, 22)
        Me.NameTextBox.TabIndex = 4
        '
        'TitleTextBox
        '
        Me.TitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Title", True))
        Me.TitleTextBox.Location = New System.Drawing.Point(134, 90)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(269, 22)
        Me.TitleTextBox.TabIndex = 6
        '
        'HireDateDateTimePicker
        '
        Me.HireDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmployeeBindingSource, "HireDate", True))
        Me.HireDateDateTimePicker.Location = New System.Drawing.Point(134, 174)
        Me.HireDateDateTimePicker.Name = "HireDateDateTimePicker"
        Me.HireDateDateTimePicker.Size = New System.Drawing.Size(269, 22)
        Me.HireDateDateTimePicker.TabIndex = 10
        '
        'SalaryTextBox
        '
        Me.SalaryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Salary", True))
        Me.SalaryTextBox.Location = New System.Drawing.Point(134, 209)
        Me.SalaryTextBox.Name = "SalaryTextBox"
        Me.SalaryTextBox.Size = New System.Drawing.Size(269, 22)
        Me.SalaryTextBox.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 17)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "View / Edit Employee Details"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(46, 324)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(178, 36)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Save Employee Data"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Tomato
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(252, 324)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 36)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ManagerTextLabel
        '
        Me.ManagerTextLabel.AutoSize = True
        Me.ManagerTextLabel.Location = New System.Drawing.Point(131, 279)
        Me.ManagerTextLabel.Name = "ManagerTextLabel"
        Me.ManagerTextLabel.Size = New System.Drawing.Size(0, 17)
        Me.ManagerTextLabel.TabIndex = 20
        '
        'DepartmentTextLabel
        '
        Me.DepartmentTextLabel.AutoSize = True
        Me.DepartmentTextLabel.Location = New System.Drawing.Point(131, 250)
        Me.DepartmentTextLabel.Name = "DepartmentTextLabel"
        Me.DepartmentTextLabel.Size = New System.Drawing.Size(0, 17)
        Me.DepartmentTextLabel.TabIndex = 21
        '
        'EmployeeIdTextLabel
        '
        Me.EmployeeIdTextLabel.AutoSize = True
        Me.EmployeeIdTextLabel.Location = New System.Drawing.Point(134, 129)
        Me.EmployeeIdTextLabel.Name = "EmployeeIdTextLabel"
        Me.EmployeeIdTextLabel.Size = New System.Drawing.Size(0, 17)
        Me.EmployeeIdTextLabel.TabIndex = 22
        '
        'EmployeeDetailsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 381)
        Me.Controls.Add(Me.EmployeeIdTextLabel)
        Me.Controls.Add(Me.DepartmentTextLabel)
        Me.Controls.Add(Me.ManagerTextLabel)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(TitleLabel)
        Me.Controls.Add(Me.TitleTextBox)
        Me.Controls.Add(ManagerLabel)
        Me.Controls.Add(HireDateLabel)
        Me.Controls.Add(Me.HireDateDateTimePicker)
        Me.Controls.Add(SalaryLabel)
        Me.Controls.Add(Me.SalaryTextBox)
        Me.Controls.Add(DepartmentLabel)
        Me.Name = "EmployeeDetailsForm"
        Me.Text = "Employee Details"
        CType(Me.VRCTestDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents VRCTestDBDataSet As VRCTestDBDataSet
    Friend WithEvents EmployeeBindingSource As BindingSource
    Friend WithEvents EmployeeTableAdapter As VRCTestDBDataSetTableAdapters.EmployeeTableAdapter
    Friend WithEvents TableAdapterManager As VRCTestDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents TitleTextBox As TextBox
    Friend WithEvents HireDateDateTimePicker As DateTimePicker
    Friend WithEvents SalaryTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ManagerTextLabel As Label
    Friend WithEvents DepartmentTextLabel As Label
    Friend WithEvents EmployeeIdTextLabel As Label
End Class
