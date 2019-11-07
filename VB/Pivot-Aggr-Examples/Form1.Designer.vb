Namespace Pivot_Aggr_Examples
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim fieldInfo49 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo50 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo51 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo52 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo53 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo54 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo55 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo56 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo57 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo58 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo59 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo60 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim excelWorksheetSettings5 As New DevExpress.DataAccess.Excel.ExcelWorksheetSettings()
			Dim excelSourceOptions5 As New DevExpress.DataAccess.Excel.ExcelSourceOptions(excelWorksheetSettings5)
			Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
			Me.treeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.excelDataSource1 = New DevExpress.DataAccess.Excel.ExcelDataSource()
			Me.fieldCategoryName1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldCountry1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldFirstName1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldLastName1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldProductName1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldSalesPerson1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldOrderDate1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldOrderID1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldQuantity1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldDiscount1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldExtendedPrice1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldUnitPrice1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.richTextBox1 = New System.Windows.Forms.RichTextBox()
			DirectCast(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' treeList1
			' 
			Me.treeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { Me.treeListColumn1})
			Me.treeList1.Dock = System.Windows.Forms.DockStyle.Left
			Me.treeList1.Location = New System.Drawing.Point(0, 0)
			Me.treeList1.Name = "treeList1"
			Me.treeList1.OptionsBehavior.Editable = False
			Me.treeList1.OptionsView.ShowColumns = False
			Me.treeList1.OptionsView.ShowFirstLines = False
			Me.treeList1.OptionsView.ShowHorzLines = False
			Me.treeList1.OptionsView.ShowRoot = False
			Me.treeList1.OptionsView.ShowTreeLines = DevExpress.Utils.DefaultBoolean.False
			Me.treeList1.OptionsView.ShowVertLines = False
			Me.treeList1.OptionsView.TreeLineStyle = DevExpress.XtraTreeList.LineStyle.None
			Me.treeList1.Size = New System.Drawing.Size(198, 600)
			Me.treeList1.TabIndex = 0
			' 
			' treeListColumn1
			' 
			Me.treeListColumn1.Caption = "treeListColumn1"
			Me.treeListColumn1.FieldName = "treeListColumn1"
			Me.treeListColumn1.Name = "treeListColumn1"
			Me.treeListColumn1.Visible = True
			Me.treeListColumn1.VisibleIndex = 0
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.DataSource = Me.excelDataSource1
			Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldCategoryName1, Me.fieldCountry1, Me.fieldFirstName1, Me.fieldLastName1, Me.fieldProductName1, Me.fieldSalesPerson1, Me.fieldOrderDate1, Me.fieldOrderID1, Me.fieldQuantity1, Me.fieldDiscount1, Me.fieldExtendedPrice1, Me.fieldUnitPrice1})
			Me.pivotGridControl1.Location = New System.Drawing.Point(198, 0)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.Size = New System.Drawing.Size(856, 258)
			Me.pivotGridControl1.TabIndex = 1
			' 
			' excelDataSource1
			' 
			Me.excelDataSource1.FileName = "C:\Data\SalesPerson.xlsx"
			Me.excelDataSource1.Name = "excelDataSource1"
			Me.excelDataSource1.ResultSchemaSerializable = resources.GetString("excelDataSource1.ResultSchemaSerializable")
			fieldInfo49.Name = "CategoryName"
			fieldInfo49.Type = GetType(String)
			fieldInfo50.Name = "Country"
			fieldInfo50.Type = GetType(String)
			fieldInfo51.Name = "FirstName"
			fieldInfo51.Type = GetType(String)
			fieldInfo52.Name = "LastName"
			fieldInfo52.Type = GetType(String)
			fieldInfo53.Name = "ProductName"
			fieldInfo53.Type = GetType(String)
			fieldInfo54.Name = "Sales Person"
			fieldInfo54.Type = GetType(String)
			fieldInfo55.Name = "OrderDate"
			fieldInfo55.Type = GetType(Date)
			fieldInfo56.Name = "OrderID"
			fieldInfo56.Type = GetType(Double)
			fieldInfo57.Name = "Quantity"
			fieldInfo57.Type = GetType(Double)
			fieldInfo58.Name = "Discount"
			fieldInfo58.Type = GetType(Double)
			fieldInfo59.Name = "Extended Price"
			fieldInfo59.Type = GetType(Double)
			fieldInfo60.Name = "UnitPrice"
			fieldInfo60.Type = GetType(Double)
			Me.excelDataSource1.Schema.AddRange(New DevExpress.DataAccess.Excel.FieldInfo() { fieldInfo49, fieldInfo50, fieldInfo51, fieldInfo52, fieldInfo53, fieldInfo54, fieldInfo55, fieldInfo56, fieldInfo57, fieldInfo58, fieldInfo59, fieldInfo60})
			excelWorksheetSettings5.CellRange = Nothing
			excelWorksheetSettings5.WorksheetName = "Data"
			excelSourceOptions5.ImportSettings = excelWorksheetSettings5
			Me.excelDataSource1.SourceOptions = excelSourceOptions5
			' 
			' fieldCategoryName1
			' 
			Me.fieldCategoryName1.AreaIndex = 0
			Me.fieldCategoryName1.Caption = "Category Name"
			Me.fieldCategoryName1.FieldName = "CategoryName"
			Me.fieldCategoryName1.Name = "fieldCategoryName1"
			' 
			' fieldCountry1
			' 
			Me.fieldCountry1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldCountry1.AreaIndex = 0
			Me.fieldCountry1.Caption = "Country"
			Me.fieldCountry1.FieldName = "Country"
			Me.fieldCountry1.Name = "fieldCountry1"
			' 
			' fieldFirstName1
			' 
			Me.fieldFirstName1.AreaIndex = 1
			Me.fieldFirstName1.Caption = "First Name"
			Me.fieldFirstName1.FieldName = "FirstName"
			Me.fieldFirstName1.Name = "fieldFirstName1"
			' 
			' fieldLastName1
			' 
			Me.fieldLastName1.AreaIndex = 2
			Me.fieldLastName1.Caption = "Last Name"
			Me.fieldLastName1.FieldName = "LastName"
			Me.fieldLastName1.Name = "fieldLastName1"
			' 
			' fieldProductName1
			' 
			Me.fieldProductName1.AreaIndex = 3
			Me.fieldProductName1.Caption = "Product Name"
			Me.fieldProductName1.FieldName = "ProductName"
			Me.fieldProductName1.Name = "fieldProductName1"
			' 
			' fieldSalesPerson1
			' 
			Me.fieldSalesPerson1.AreaIndex = 4
			Me.fieldSalesPerson1.Caption = "Sales Person"
			Me.fieldSalesPerson1.FieldName = "Sales Person"
			Me.fieldSalesPerson1.Name = "fieldSalesPerson1"
			' 
			' fieldOrderDate1
			' 
			Me.fieldOrderDate1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldOrderDate1.AreaIndex = 0
			Me.fieldOrderDate1.Caption = "Year"
			Me.fieldOrderDate1.FieldName = "OrderDate"
			Me.fieldOrderDate1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
			Me.fieldOrderDate1.Name = "fieldOrderDate1"
			Me.fieldOrderDate1.UnboundFieldName = "fieldOrderDate1"
			' 
			' fieldOrderID1
			' 
			Me.fieldOrderID1.AreaIndex = 5
			Me.fieldOrderID1.Caption = "Order ID"
			Me.fieldOrderID1.FieldName = "OrderID"
			Me.fieldOrderID1.Name = "fieldOrderID1"
			' 
			' fieldQuantity1
			' 
			Me.fieldQuantity1.AreaIndex = 6
			Me.fieldQuantity1.Caption = "Quantity"
			Me.fieldQuantity1.FieldName = "Quantity"
			Me.fieldQuantity1.Name = "fieldQuantity1"
			' 
			' fieldDiscount1
			' 
			Me.fieldDiscount1.AreaIndex = 7
			Me.fieldDiscount1.Caption = "Discount"
			Me.fieldDiscount1.FieldName = "Discount"
			Me.fieldDiscount1.Name = "fieldDiscount1"
			' 
			' fieldExtendedPrice1
			' 
			Me.fieldExtendedPrice1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldExtendedPrice1.AreaIndex = 0
			Me.fieldExtendedPrice1.Caption = "Extended Price"
			Me.fieldExtendedPrice1.CellFormat.FormatString = "c"
			Me.fieldExtendedPrice1.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
			Me.fieldExtendedPrice1.FieldName = "Extended Price"
			Me.fieldExtendedPrice1.Name = "fieldExtendedPrice1"
			Me.fieldExtendedPrice1.ValueFormat.FormatString = "c"
			Me.fieldExtendedPrice1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
			' 
			' fieldUnitPrice1
			' 
			Me.fieldUnitPrice1.AreaIndex = 8
			Me.fieldUnitPrice1.Caption = "Unit Price"
			Me.fieldUnitPrice1.FieldName = "UnitPrice"
			Me.fieldUnitPrice1.Name = "fieldUnitPrice1"
			' 
			' richTextBox1
			' 
			Me.richTextBox1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.richTextBox1.Font = New System.Drawing.Font("Segoe UI", 10F)
			Me.richTextBox1.ForeColor = System.Drawing.Color.DarkBlue
			Me.richTextBox1.Location = New System.Drawing.Point(198, 258)
			Me.richTextBox1.Name = "richTextBox1"
			Me.richTextBox1.ReadOnly = True
			Me.richTextBox1.Size = New System.Drawing.Size(856, 342)
			Me.richTextBox1.TabIndex = 2
			Me.richTextBox1.Text = ""
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1054, 600)
			Me.Controls.Add(Me.pivotGridControl1)
			Me.Controls.Add(Me.richTextBox1)
			Me.Controls.Add(Me.treeList1)
			Me.Name = "Form1"
			Me.Text = "Aggr Examples"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.Load += new System.EventHandler(this.Form1_Load);
			DirectCast(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private treeList1 As DevExpress.XtraTreeList.TreeList
		Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private excelDataSource1 As DevExpress.DataAccess.Excel.ExcelDataSource
		Private fieldCategoryName1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldCountry1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldFirstName1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldLastName1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldProductName1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldSalesPerson1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldOrderDate1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldOrderID1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldQuantity1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldDiscount1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldExtendedPrice1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldUnitPrice1 As DevExpress.XtraPivotGrid.PivotGridField
		Private treeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private richTextBox1 As System.Windows.Forms.RichTextBox
	End Class
End Namespace

