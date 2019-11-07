Imports DevExpress.Data.PivotGrid
Imports DevExpress.XtraPivotGrid
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace Pivot_Aggr_Examples
    Friend NotInheritable Class CodeExample

        Private Sub New()
        End Sub

        Public Shared Property pivotGrid() As PivotGridControl
        Public Shared Sub SalesByYearByCountryExample()
            '			#Region "Filter Sales by Year and Country"
            Dim salesByYearByCountry As New PivotGridField()
            salesByYearByCountry.Name = "fldSalesByYearByCountry"
            salesByYearByCountry.Area = PivotArea.FilterArea
            salesByYearByCountry.Caption = "Sales By Year By Country"
            salesByYearByCountry.Visible = False
            salesByYearByCountry.FieldName = "SalesByYearByCountry"
            salesByYearByCountry.DataBinding = New ExpressionDataBinding("Aggr(Sum([Extended Price]), GetYear([OrderDate]), [Country])")
            pivotGrid.Fields.Add(salesByYearByCountry)
            pivotGrid.ActiveFilter.CriteriaString = "[SalesByYearByCountry] > 300000"
            '			#End Region
            pivotGrid.BestFit()
        End Sub

        Public Shared Sub SalesByYearByCountryExample_Clear()
            pivotGrid.ActiveFilter.Clear()
            Dim fld As PivotGridField = pivotGrid.Fields.GetFieldByName("fldSalesByYearByCountry")
            If fld IsNot Nothing Then
                pivotGrid.Fields.Remove(fld)
            End If
        End Sub

        Public Shared Sub AverageSalesByYearExample()
            '			#Region "Average Sales by Year"
            Dim salesByYearByCountry As New PivotGridField()
            salesByYearByCountry.Name = "fldSalesByYearByCountry"
            salesByYearByCountry.Area = PivotArea.DataArea
            salesByYearByCountry.Caption = "Average Sales by Year"
            salesByYearByCountry.SummaryType = PivotSummaryType.Average
            salesByYearByCountry.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
            salesByYearByCountry.CellFormat.FormatString = "c"
            salesByYearByCountry.DataBinding = New ExpressionDataBinding("Aggr(Sum([Extended Price]), GetYear([OrderDate]), [Country])")
            salesByYearByCountry.Options.ShowValues = False
            pivotGrid.Fields.Add(salesByYearByCountry)
            '			#End Region
            pivotGrid.BestFit()
        End Sub

        Public Shared Sub AverageSalesByYearExample_Clear()
            Dim fld As PivotGridField = pivotGrid.Fields.GetFieldByName("fldSalesByYearByCountry")
            If fld IsNot Nothing Then
                pivotGrid.Fields.Remove(fld)
            End If
        End Sub

        Public Shared Sub YearOfFirstSaleExample()
            '			#Region "Grouping by Year of First Sale"
            Dim yearOfFirstSale As New PivotGridField()
            yearOfFirstSale.Name = "fldYearOfFirstSale"
            yearOfFirstSale.Area = PivotArea.RowArea
            yearOfFirstSale.AreaIndex = 0
            yearOfFirstSale.Caption = "Year of first sale"
            yearOfFirstSale.DataBinding = New ExpressionDataBinding("Aggr(Min(GetYear([OrderDate])), [Country])")
            yearOfFirstSale.Options.ShowTotals = False
            pivotGrid.Fields.Add(yearOfFirstSale)
            '			#End Region
            pivotGrid.BestFit()
        End Sub

        Public Shared Sub YearOfFirstSaleExample_Clear()
            Dim fld As PivotGridField = pivotGrid.Fields.GetFieldByName("fldYearOfFirstSale")
            If fld IsNot Nothing Then
                pivotGrid.Fields.Remove(fld)
            End If
        End Sub

        Public Shared Sub PercentOfTotalExample()
            '			#Region "Percent of Total"
            ' Calculates the percentage of the grand total column. 
            ' You can also use the PivotGridField.SummaryDisplayType property to display summaries, 
            ' but the Aggr expression allows you to sort by the summary column and use the values in subsequent calculations.

            Dim percentOfTotal As New PivotGridField()
            percentOfTotal.Name = "fldPercentOfTotal"
            percentOfTotal.Area = PivotArea.DataArea
            percentOfTotal.AreaIndex = 0
            percentOfTotal.Caption = "% of Total"
            percentOfTotal.DataBinding = New ExpressionDataBinding("Sum([Extended Price]) / Min(Aggr(Sum([Extended Price]), [Country]))")
            percentOfTotal.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
            percentOfTotal.CellFormat.FormatString = "P"
            percentOfTotal.Options.ShowTotals = False
            percentOfTotal.Options.ShowGrandTotal = False
            pivotGrid.Fields.Add(percentOfTotal)
            pivotGrid.OptionsView.ShowRowGrandTotals = False
            '			#End Region
            pivotGrid.BestFit()
        End Sub

        Public Shared Sub PercentOfTotalExample_Clear()
            Dim fld As PivotGridField = pivotGrid.Fields.GetFieldByName("fldPercentOfTotal")
            If fld IsNot Nothing Then
                pivotGrid.Fields.Remove(fld)
            End If
        End Sub

        Public Shared Sub ShowTotalsInRowAreaExample()

            Dim fieldOrderMonth1 As PivotGridField = New PivotGridField()
            fieldOrderMonth1.Area = PivotArea.ColumnArea
            fieldOrderMonth1.AreaIndex = 1
            fieldOrderMonth1.Caption = "Month"
            fieldOrderMonth1.FieldName = "OrderDate"
            fieldOrderMonth1.GroupInterval = PivotGroupInterval.DateMonth
            fieldOrderMonth1.Name = "fieldOrderMonth1"
            pivotGrid.Fields.Add(fieldOrderMonth1)

            pivotGrid.Fields.GetFieldByName("fieldCountry1").Area = PivotArea.FilterArea
            pivotGrid.Fields.GetFieldByName("fieldCategoryName1").Area = PivotArea.RowArea
            '			#Region "Show Totals in Row Area"
            ' Displays total values in the Row Area, as a "standalone column".

            Dim amountMax As New PivotGridField()
            amountMax.Name = "fldAmountMax"
            amountMax.Area = PivotArea.RowArea
            amountMax.AreaIndex = 1
            amountMax.Caption = "Max Amount per Month"
            amountMax.DataBinding = New ExpressionDataBinding("Aggr(Max(Aggr(Sum([Extended Price]), [fieldCategoryName1], [fieldOrderDate1], [fieldOrderMonth1])), [fieldCategoryName1])")
            amountMax.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
            amountMax.ValueFormat.FormatString = "C2"
            pivotGrid.Fields.Add(amountMax)
            '			#End Region
            pivotGrid.BestFit()
        End Sub

        Public Shared Sub ShowTotalsInRowAreaExample_Clear()
            Dim fld As PivotGridField = pivotGrid.Fields.GetFieldByName("fldAmountMax")
            If fld IsNot Nothing Then
                pivotGrid.Fields.Remove(fld)
            End If
            Dim fld1 As PivotGridField = pivotGrid.Fields.GetFieldByName("fieldOrderMonth1")
            If fld1 IsNot Nothing Then
                pivotGrid.Fields.Remove(fld1)
            End If
            pivotGrid.Fields.GetFieldByName("fieldCountry1").Area = PivotArea.RowArea
            pivotGrid.Fields.GetFieldByName("fieldCategoryName1").Area = PivotArea.FilterArea
        End Sub
    End Class
End Namespace
