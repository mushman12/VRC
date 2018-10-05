<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DepartmentsForm
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
        Me.VRCTestDBDataSet = New VikingDrekkar.VRCTestDBDataSet()
        Me.DepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartmentTableAdapter = New VikingDrekkar.VRCTestDBDataSetTableAdapters.DepartmentTableAdapter()
        Me.TableAdapterManager = New VikingDrekkar.VRCTestDBDataSetTableAdapters.TableAdapterManager()
        Me.DepartmentDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeptsGroupBox = New System.Windows.Forms.GroupBox()
        CType(Me.VRCTestDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DeptsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'VRCTestDBDataSet
        '
        Me.VRCTestDBDataSet.DataSetName = "VRCTestDBDataSet"
        Me.VRCTestDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DepartmentBindingSource
        '
        Me.DepartmentBindingSource.DataMember = "Department"
        Me.DepartmentBindingSource.DataSource = Me.VRCTestDBDataSet
        '
        'DepartmentTableAdapter
        '
        Me.DepartmentTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DepartmentTableAdapter = Me.DepartmentTableAdapter
        Me.TableAdapterManager.EmployeeTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = VikingDrekkar.VRCTestDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DepartmentDataGridView
        '
        Me.DepartmentDataGridView.AllowUserToAddRows = False
        Me.DepartmentDataGridView.AllowUserToDeleteRows = False
        Me.DepartmentDataGridView.AutoGenerateColumns = False
        Me.DepartmentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DepartmentDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DepartmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DepartmentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.DepartmentDataGridView.DataSource = Me.DepartmentBindingSource
        Me.DepartmentDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DepartmentDataGridView.Location = New System.Drawing.Point(3, 18)
        Me.DepartmentDataGridView.Name = "DepartmentDataGridView"
        Me.DepartmentDataGridView.ReadOnly = True
        Me.DepartmentDataGridView.RowHeadersVisible = False
        Me.DepartmentDataGridView.RowTemplate.Height = 24
        Me.DepartmentDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DepartmentDataGridView.Size = New System.Drawing.Size(275, 128)
        Me.DepartmentDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 48
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 74
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Location"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Location"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 91
        '
        'DeptsGroupBox
        '
        Me.DeptsGroupBox.AutoSize = True
        Me.DeptsGroupBox.Controls.Add(Me.DepartmentDataGridView)
        Me.DeptsGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.DeptsGroupBox.Name = "DeptsGroupBox"
        Me.DeptsGroupBox.Size = New System.Drawing.Size(281, 149)
        Me.DeptsGroupBox.TabIndex = 2
        Me.DeptsGroupBox.TabStop = False
        Me.DeptsGroupBox.Text = "Departments"
        '
        'DepartmentsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(305, 173)
        Me.Controls.Add(Me.DeptsGroupBox)
        Me.Name = "DepartmentsForm"
        Me.Text = "VRC"
        CType(Me.VRCTestDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DeptsGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents VRCTestDBDataSet As VRCTestDBDataSet
    Friend WithEvents DepartmentBindingSource As BindingSource
    Friend WithEvents DepartmentTableAdapter As VRCTestDBDataSetTableAdapters.DepartmentTableAdapter
    Friend WithEvents TableAdapterManager As VRCTestDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DepartmentDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DeptsGroupBox As GroupBox
End Class
