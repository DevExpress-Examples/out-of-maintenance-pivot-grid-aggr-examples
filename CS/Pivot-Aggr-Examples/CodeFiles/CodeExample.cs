using DevExpress.Data.PivotGrid;
using DevExpress.XtraPivotGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pivot_Aggr_Examples
{
    static class CodeExample
    {
        public static PivotGridControl pivotGrid { get; set; }
        public static void SalesByYearByCountryExample()
        {
            #region Filter Sales by Year and Country
            PivotGridField salesByYearByCountry = new PivotGridField()
            {
                Name = "fldSalesByYearByCountry",
                Area = PivotArea.FilterArea,
                Caption = "Sales By Year By Country",
                Visible = false,
                FieldName = "SalesByYearByCountry"
            };
            salesByYearByCountry.DataBinding = new ExpressionDataBinding("Aggr(Sum([Extended Price]), GetYear([OrderDate]), [Country])");
            pivotGrid.Fields.Add(salesByYearByCountry);
            pivotGrid.ActiveFilter.CriteriaString = "[SalesByYearByCountry] > 300000";
            #endregion
            pivotGrid.BestFit();
        }

        public static void SalesByYearByCountryExample_Clear()
        {
            pivotGrid.ActiveFilter.Clear();
            PivotGridField fld = pivotGrid.Fields.GetFieldByName("fldSalesByYearByCountry");
            if (fld != null)
                pivotGrid.Fields.Remove(fld);                
        }

        public static void AverageSalesByYearExample()
        {
            #region Average Sales by Year
            PivotGridField salesByYearByCountry = new PivotGridField() {
                Name = "fldSalesByYearByCountry",
                Area = PivotArea.DataArea,
                Caption = "Average Sales by Year",
                SummaryType = PivotSummaryType.Average
            };
            salesByYearByCountry.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            salesByYearByCountry.CellFormat.FormatString = "c";
            salesByYearByCountry.DataBinding = new ExpressionDataBinding("Aggr(Sum([Extended Price]), GetYear([OrderDate]), [Country])");
            salesByYearByCountry.Options.ShowValues = false;
            pivotGrid.Fields.Add(salesByYearByCountry);
            #endregion
            pivotGrid.BestFit();
        }

        public static void AverageSalesByYearExample_Clear()
        {
            PivotGridField fld = pivotGrid.Fields.GetFieldByName("fldSalesByYearByCountry");
            if (fld != null)
                pivotGrid.Fields.Remove(fld);
        }

        public static void YearOfFirstSaleExample()
        {
            #region Grouping by Year of First Sale
            PivotGridField yearOfFirstSale = new PivotGridField() {
                Name = "fldYearOfFirstSale",
                Area = PivotArea.RowArea,
                AreaIndex = 0,
                Caption = "Year of first sale" };
            yearOfFirstSale.DataBinding = new ExpressionDataBinding("Aggr(Min(GetYear([OrderDate])), [Country])");
            yearOfFirstSale.Options.ShowTotals = false;
            pivotGrid.Fields.Add(yearOfFirstSale);
            #endregion
            pivotGrid.BestFit();
        }

        public static void YearOfFirstSaleExample_Clear()
        {
            PivotGridField fld = pivotGrid.Fields.GetFieldByName("fldYearOfFirstSale");
            if (fld != null)
                pivotGrid.Fields.Remove(fld);
        }

        public static void PercentOfTotalExample()
        {
            #region Percent of Total
            // Calculates the percentage of the grand total column. 
            // You can also use the PivotGridField.SummaryDisplayType property to display summaries, 
            // but the Aggr expression allows you to sort by the summary column and use the values in subsequent calculations.

            PivotGridField percentOfTotal = new PivotGridField()
            {
                Name = "fldPercentOfTotal",
                Area = PivotArea.DataArea,
                AreaIndex = 0,
                Caption = "% of Total"
            };
            percentOfTotal.DataBinding = new ExpressionDataBinding("Sum([Extended Price]) / Min(Aggr(Sum([Extended Price]), [Country]))");
            percentOfTotal.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            percentOfTotal.CellFormat.FormatString = "P";
            percentOfTotal.Options.ShowTotals = false;
            percentOfTotal.Options.ShowGrandTotal = false;
            pivotGrid.Fields.Add(percentOfTotal);
            pivotGrid.OptionsView.ShowRowGrandTotals = false;
            #endregion
            pivotGrid.BestFit();
        }

        public static void PercentOfTotalExample_Clear()
        {
            PivotGridField fld = pivotGrid.Fields.GetFieldByName("fldPercentOfTotal");
            if (fld != null)
                pivotGrid.Fields.Remove(fld);
        }

        public static void ShowTotalsInRowAreaExample()
        {

            PivotGridField fieldOrderMonth1 = new PivotGridField
            {
                Area = PivotArea.ColumnArea,
                AreaIndex = 1,
                Caption = "Month",
                FieldName = "OrderDate",
                GroupInterval = PivotGroupInterval.DateMonth,
                Name = "fieldOrderMonth1",
            };
            pivotGrid.Fields.Add(fieldOrderMonth1);

            pivotGrid.Fields.GetFieldByName("fieldCountry1").Area = PivotArea.FilterArea;
            pivotGrid.Fields.GetFieldByName("fieldCategoryName1").Area = PivotArea.RowArea;
            #region Show Totals in Row Area
            // Displays total values in the Row Area, as a "standalone column".

            PivotGridField amountMax = new PivotGridField()
            {
                Name = "fldAmountMax",
                Area = PivotArea.RowArea,
                AreaIndex = 1,
                Caption = "Max Amount per Month"
            };
            amountMax.DataBinding = new ExpressionDataBinding("Aggr(Max(Aggr(Sum([Extended Price]), [fieldCategoryName1], [fieldOrderDate1], [fieldOrderMonth1])), [fieldCategoryName1])");
            amountMax.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            amountMax.ValueFormat.FormatString = "C2";
            pivotGrid.Fields.Add(amountMax);
            #endregion
            pivotGrid.BestFit();
        }

        public static void ShowTotalsInRowAreaExample_Clear()
        {
            PivotGridField fld = pivotGrid.Fields.GetFieldByName("fldAmountMax");
            if (fld != null)
                pivotGrid.Fields.Remove(fld);
            PivotGridField fld1 = pivotGrid.Fields.GetFieldByName("fieldOrderMonth1");
            if (fld1 != null)
                pivotGrid.Fields.Remove(fld1);
            pivotGrid.Fields.GetFieldByName("fieldCountry1").Area = PivotArea.RowArea;
            pivotGrid.Fields.GetFieldByName("fieldCategoryName1").Area = PivotArea.FilterArea;
        }
    }
}
