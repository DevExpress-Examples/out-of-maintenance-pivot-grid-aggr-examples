Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Threading.Tasks

Namespace Pivot_Aggr_Examples
    Friend Class CodeFileParser

        Public Shared Function ParseVbFile(ByVal fileName As String) As Dictionary(Of String, List(Of String))
            Dim f As New FileInfo(fileName)
            Dim snippets As New Dictionary(Of String, List(Of String))()
            Dim originCodeLines() As String = File.ReadAllLines(fileName)
            Dim codeLines As List(Of String) = Nothing

            For i As Integer = 0 To originCodeLines.Length - 1
                Dim sLine As String = originCodeLines(i)
                If sLine IsNot Nothing Then
                    Dim sLineTrimmed As String = sLine.TrimStart(" "c, "'"c, Convert.ToChar(vbTab))
                    If sLineTrimmed.StartsWith("#Region", StringComparison.CurrentCultureIgnoreCase) Then
                        Dim key As String = sLineTrimmed.Substring("#Region ".Length).TrimStart(" "c, """"c).TrimEnd(" "c, """"c)
                        If snippets.ContainsKey(key) Then
                            Throw New ArgumentException(String.Format("Duplicate names: {0}", sLine.Trim()))
                        End If
                        snippets(key) = New List(Of String)()
                        codeLines = snippets(key)
                    Else
                        If codeLines IsNot Nothing Then
                            If sLineTrimmed.StartsWith("#End Region", StringComparison.CurrentCultureIgnoreCase) Then
                                codeLines = Nothing
                            Else
                                codeLines.Add(sLine.Replace(vbTab, " "))
                            End If
                        End If
                    End If
                End If
            Next i

            Return snippets
        End Function
    End Class
End Namespace