using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pivot_Aggr_Examples
{
    class CodeFileParser
    {

        public static Dictionary<string, List<string>> ParseCSharpFile(string fileName)
        {
            FileInfo f = new FileInfo(fileName);
            Dictionary<string, List<String>> snippets = new Dictionary<string, List<string>>();
            string[] originCodeLines = File.ReadAllLines(fileName);
            List<string> codeLines = null;

            for (int i = 0; i < originCodeLines.Length; i++)
            {
                string sLine = originCodeLines[i];
                if (sLine != null)
                {
                    if (sLine.TrimStart().StartsWith("#region", StringComparison.CurrentCultureIgnoreCase))
                    {
                        string key = sLine.TrimStart().Substring("#region".Length).TrimStart();
                        if (snippets.ContainsKey(key))
                        {
                            throw new ArgumentException(string.Format("Duplicate names: {0}", sLine.Trim()));
                        }
                        snippets[key] = new List<string>();
                        codeLines = snippets[key];
                    }
                    else
                    {
                        if (codeLines != null)
                        {
                            if (sLine.TrimStart().StartsWith("#endregion", StringComparison.CurrentCultureIgnoreCase))
                            {
                                codeLines = null;
                            }
                            else
                            {
                                codeLines.Add(sLine.Replace(new string(' ', 12), ""));
                            }
                        }
                    }
                }
            }

            return snippets;
        }
    }
}