<!-- default file list -->
*Files to look at*:
* [CodeExample.cs](./CS/Pivot-Aggr-Examples/CodeFiles/CodeExample.cs) (VB: [CodeExample.vb](./VB/Pivot-Aggr-Examples/CodeFiles/CodeExample.vb))
<!-- default file list end -->

# Use Aggr Function in Pivot Grid Field Expressions

This example demonstrates the advantages of [Aggr function](https://docs.devexpress.com/CoreLibraries/401198) in different usage scenarios. The PivotGridControl should use the [Optimized calculation engine](https://docs.devexpress.com/CoreLibraries/401367).

A PivotGrid field obtains its values from the [ExpressionDataBinding](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.ExpressionDataBinding) object with the [Expression](https://docs.devexpress.com/CoreLibraries/DevExpress.PivotGrid.DataBinding.ExpressionBindingBase.Expression) property set to an expression with the **Aggr** function.

![](/images/screenshot.png)