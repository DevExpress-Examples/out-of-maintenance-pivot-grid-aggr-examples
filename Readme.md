<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/220214828/19.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T830923)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:
* [CodeExample.cs](./CS/Pivot-Aggr-Examples/CodeFiles/CodeExample.cs) (VB: [CodeExample.vb](./VB/Pivot-Aggr-Examples/CodeFiles/CodeExample.vb))
<!-- default file list end -->

# Use Aggr Function in Pivot Grid Field Expressions

This example demonstrates the advantages of the [Aggr function](https://docs.devexpress.com/CoreLibraries/401198) in different usage scenarios. The PivotGridControl should use the [Optimized calculation engine](https://docs.devexpress.com/CoreLibraries/401367).

A PivotGrid field obtains its values from the [ExpressionDataBinding](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.ExpressionDataBinding) object with the [Expression](https://docs.devexpress.com/CoreLibraries/DevExpress.PivotGrid.DataBinding.ExpressionBindingBase.Expression) property set to an expression with the **Aggr** function.

![](/images/screenshot.png)
