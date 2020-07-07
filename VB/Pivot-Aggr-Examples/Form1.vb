Imports DevExpress.XtraPivotGrid
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Namespace Pivot_Aggr_Examples
	Partial Public Class Form1
		Inherits DevExpress.XtraEditors.XtraForm

		Private exampleNames() As String = { "Filter Sales by Year and Country", "Average Sales by Year", "Grouping by Year of First Sale", "Percent of Total", "Show Totals in Row Area" }
		Private dictEnter As New Dictionary(Of String, Action)()
		Private dictLeave As New Dictionary(Of String, Action)()
        Private dictCodeSnippets As Dictionary(Of String, List(Of String)) = CodeFileParser.ParseVbFile("CodeFiles/CodeExample.vb")
        Public Sub New()
			InitializeComponent()
			pivotGridControl1.OptionsData.DataProcessingEngine = PivotDataProcessingEngine.Optimized
			' Configure the TreeList control.
			For i As Integer = 0 To exampleNames.Length - 1
				treeList1.AppendNode(New Object() { exampleNames(i) }, -1)
			Next i
			AddHandler treeList1.FocusedNodeChanged, AddressOf treeList1_FocusedNodeChanged
			' Provide data.
			excelDataSource1.FileName = "SalesPerson.xlsx"
			excelDataSource1.Fill()
			' Process code files.
			CodeExample.pivotGrid = pivotGridControl1
			CreateMethodDictionaries()
			richTextBox1.Font = New Font(FontFamily.GenericMonospace, 10)
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			RunSnippet(treeList1.FocusedNode.GetDisplayText(0))
		End Sub

		Private Sub CreateMethodDictionaries()
			dictEnter.Add(exampleNames(0), Sub() CodeExample.SalesByYearByCountryExample())
			dictLeave.Add(exampleNames(0), Sub() CodeExample.SalesByYearByCountryExample_Clear())
			dictEnter.Add(exampleNames(1), Sub() CodeExample.AverageSalesByYearExample())
			dictLeave.Add(exampleNames(1), Sub() CodeExample.AverageSalesByYearExample_Clear())
			dictEnter.Add(exampleNames(2), Sub() CodeExample.YearOfFirstSaleExample())
			dictLeave.Add(exampleNames(2), Sub() CodeExample.YearOfFirstSaleExample_Clear())
			dictEnter.Add(exampleNames(3), Sub() CodeExample.PercentOfTotalExample())
			dictLeave.Add(exampleNames(3), Sub() CodeExample.PercentOfTotalExample_Clear())
			dictEnter.Add(exampleNames(4), Sub() CodeExample.ShowTotalsInRowAreaExample())
			dictLeave.Add(exampleNames(4), Sub() CodeExample.ShowTotalsInRowAreaExample_Clear())
		End Sub

		Private Sub treeList1_FocusedNodeChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs)
			' Reset the previous code snippet. 
			dictLeave(e.OldNode.GetDisplayText(0))()
			RunSnippet(e.Node.GetDisplayText(0))
		End Sub

		Private Sub RunSnippet(ByVal snippetName As String)
			' Run the current code snippet.
			dictEnter(snippetName)()
			' Show the snippet text.
			richTextBox1.Clear()
			richTextBox1.Text = String.Join(Environment.NewLine, dictCodeSnippets(snippetName))
			HighlightText()
		End Sub

		Private Sub HighlightText()
			' Highlight Expression.
			Dim expressionPattern As String = "ExpressionDataBinding\(""(.*?)"""
			Dim regexExpression As New Regex(expressionPattern)
			Dim matchesExpression As MatchCollection = regexExpression.Matches(richTextBox1.Text)
			If matchesExpression.Count > 0 Then
				For Each m As Match In matchesExpression
					richTextBox1.Select(m.Groups(1).Index, m.Groups(1).Length)
					richTextBox1.SelectionColor = Color.DarkRed
					richTextBox1.SelectionBackColor = Color.White
				Next m
			End If

            ' Highlight comments.
            Dim lineCommentsPattern As String = "'(.*?)\r?\n"
            Dim regexComments As New Regex(lineCommentsPattern)
			Dim matchesComments As MatchCollection = regexComments.Matches(richTextBox1.Text)

			If matchesComments.Count > 0 Then
				For Each m As Match In matchesComments
					richTextBox1.Select(m.Index, m.Length)
					richTextBox1.SelectionColor = Color.Green
					richTextBox1.SelectionBackColor = Color.White
				Next m
			End If

		End Sub
	End Class
End Namespace
