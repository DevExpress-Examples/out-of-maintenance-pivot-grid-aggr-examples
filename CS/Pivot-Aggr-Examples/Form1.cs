using DevExpress.XtraPivotGrid;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Pivot_Aggr_Examples
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        string[] exampleNames = {
            "Filter Sales by Year and Country",
            "Average Sales by Year",
            "Grouping by Year of First Sale",
            "Percent of Total",
            "Show Totals in Row Area"
        };
        Dictionary<string, Action> dictEnter = new Dictionary<string, Action>();
        Dictionary<string, Action> dictLeave = new Dictionary<string, Action>();
        Dictionary<string, List<string>> dictCodeSnippets = CodeFileParser.ParseCSharpFile("CodeFiles/CodeExample.cs");
        public Form1()
        {
            InitializeComponent();
            pivotGridControl1.OptionsData.DataProcessingEngine = PivotDataProcessingEngine.Optimized;
            // Configure the TreeList control.
            for (int i = 0; i < exampleNames.Length; i++)
                treeList1.AppendNode(new object[] { exampleNames[i] }, -1);
            treeList1.FocusedNodeChanged += treeList1_FocusedNodeChanged;
            // Provide data.
            excelDataSource1.FileName = @"SalesPerson.xlsx";
            excelDataSource1.Fill();
            // Process code files.
            CodeExample.pivotGrid = pivotGridControl1;
            CreateMethodDictionaries();
            richTextBox1.Font = new Font(FontFamily.GenericMonospace, 10);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RunSnippet(treeList1.FocusedNode.GetDisplayText(0));
        }

        void CreateMethodDictionaries()
        {
            dictEnter.Add(exampleNames[0], () => CodeExample.SalesByYearByCountryExample());
            dictLeave.Add(exampleNames[0], () => CodeExample.SalesByYearByCountryExample_Clear());
            dictEnter.Add(exampleNames[1], () => CodeExample.AverageSalesByYearExample());
            dictLeave.Add(exampleNames[1], () => CodeExample.AverageSalesByYearExample_Clear());
            dictEnter.Add(exampleNames[2], () => CodeExample.YearOfFirstSaleExample());
            dictLeave.Add(exampleNames[2], () => CodeExample.YearOfFirstSaleExample_Clear());
            dictEnter.Add(exampleNames[3], () => CodeExample.PercentOfTotalExample());
            dictLeave.Add(exampleNames[3], () => CodeExample.PercentOfTotalExample_Clear());
            dictEnter.Add(exampleNames[4], () => CodeExample.ShowTotalsInRowAreaExample());
            dictLeave.Add(exampleNames[4], () => CodeExample.ShowTotalsInRowAreaExample_Clear());
        }

        private void treeList1_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            // Reset the previous code snippet. 
            dictLeave[e.OldNode.GetDisplayText(0)]();
            RunSnippet(e.Node.GetDisplayText(0));
        }

        private void RunSnippet(string snippetName)
        {
            // Run the current code snippet.
            dictEnter[snippetName]();
            // Show the snippet text.
            richTextBox1.Clear();
            richTextBox1.Text = String.Join(Environment.NewLine, dictCodeSnippets[snippetName]);
            HighlightText();
        }

        private void HighlightText()
        {
            // Highlight Expression.
            string expressionPattern = @"ExpressionDataBinding\(""(.*?)""";
            Regex regexExpression = new Regex(expressionPattern);
            MatchCollection matchesExpression = regexExpression.Matches(richTextBox1.Text);
            if (matchesExpression.Count > 0)
            {
                foreach (Match m in matchesExpression)
                {
                    richTextBox1.Select(m.Groups[1].Index, m.Groups[1].Length);
                    richTextBox1.SelectionColor = Color.DarkRed;
                    richTextBox1.SelectionBackColor = Color.White;
                }
            }

            // Highlight comments.
            string lineCommentsPattern = @"//(.*?)\r?\n";
            Regex regexComments = new Regex(lineCommentsPattern);
            MatchCollection matchesComments = regexComments.Matches(richTextBox1.Text);

            if (matchesComments.Count > 0)
            {
                foreach (Match m in matchesComments)
                {
                    richTextBox1.Select(m.Index, m.Length);
                    richTextBox1.SelectionColor = Color.Green;
                    richTextBox1.SelectionBackColor = Color.White;
                }
            }

        }
    }
}
