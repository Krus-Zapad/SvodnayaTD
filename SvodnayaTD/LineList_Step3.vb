Imports OfficeOpenXml
Imports System.IO

Public Class LineList_Step3
    Public Function Parse(path As String,
                     sheet As String,
                     jbs As List(Of JBRef)) As List(Of TDRef)

        Dim result As New List(Of TDRef)

        ' Создаем словарь для быстрого поиска JB -> список SHS
        Dim jbToShsDict = jbs.GroupBy(Function(x) x.JB).
                          ToDictionary(Function(g) g.Key,
                                       Function(g) g.Select(Function(x) x.SHS).Distinct().ToList())

        ' Множество для отслеживания уже обработанных связей (SHS + TD)
        Dim processedTD As New HashSet(Of String)

        Using pack As New ExcelPackage(New FileInfo(path))
            Dim ws = pack.Workbook.Worksheets(sheet)

            ' Построение графа связей для рекурсивного поиска
            Dim graph As New Dictionary(Of String, List(Of String))

            ' Сначала проходим по всем строкам для построения графа
            For r = 1 To ws.Dimension.Rows
                Dim startNode = Read(ws, r, 4) ' JB в 4-м столбце
                Dim endNode = Read(ws, r, 5)   ' TD или RMO в 5-м столбце

                If Not String.IsNullOrEmpty(startNode) AndAlso Not String.IsNullOrEmpty(endNode) Then
                    If Not graph.ContainsKey(startNode) Then
                        graph(startNode) = New List(Of String)
                    End If
                    graph(startNode).Add(endNode)
                End If
            Next

            ' Для каждого JB из списка ищем все связанные TD
            For Each kvp In jbToShsDict
                Dim jb = kvp.Key
                Dim shsList = kvp.Value

                ' Множество для отслеживания посещенных узлов (защита от циклов)
                Dim visited As New HashSet(Of String)

                ' Ищем все TD для этого JB
                Dim foundTDs As New HashSet(Of String)
                FindAllTD(jb, graph, visited, foundTDs)

                ' Для каждого найденного TD создаем записи для всех SHS
                For Each td In foundTDs
                    For Each shs In shsList
                        Dim tdKey = shs & "|" & td
                        If Not processedTD.Contains(tdKey) Then
                            result.Add(New TDRef With {
                            .SHS = shs,
                            .TD = td
                        })
                            processedTD.Add(tdKey)
                        End If
                    Next
                Next
            Next

            ' Дополнительный проход для прямых связей JB -> TD (без RMO цепочек)
            For r = 1 To ws.Dimension.Rows
                Dim jb = Read(ws, r, 4)
                Dim td = Read(ws, r, 5)

                If Not String.IsNullOrEmpty(jb) AndAlso Not String.IsNullOrEmpty(td) Then
                    ' Проверяем, есть ли такой JB в нашем словаре
                    If jbToShsDict.ContainsKey(jb) Then
                        ' Проверяем, что это действительно TD (может быть дополнительная проверка)
                        If td.Contains("TD") Then
                            For Each shs In jbToShsDict(jb)
                                Dim tdKey = shs & "|" & td
                                If Not processedTD.Contains(tdKey) Then
                                    result.Add(New TDRef With {
                                    .SHS = shs,
                                    .TD = td
                                })
                                    processedTD.Add(tdKey)
                                End If
                            Next
                        End If
                    End If
                End If
            Next

        End Using

        ' Возвращаем уникальные результаты
        Return result.Distinct().ToList()
    End Function

    Private Sub FindAllTD(currentNode As String,
                     graph As Dictionary(Of String, List(Of String)),
                     ByRef visited As HashSet(Of String),
                     ByRef foundTDs As HashSet(Of String))

        ' Защита от циклов
        If visited.Contains(currentNode) Then
            Return
        End If

        visited.Add(currentNode)

        ' Проверяем, является ли текущий узел TD

        If currentNode.Contains("TD") Then
            foundTDs.Add(currentNode)
        End If

        ' Рекурсивно обходим все связи от текущего узла
        If graph.ContainsKey(currentNode) Then
            For Each nextNode In graph(currentNode)
                FindAllTD(nextNode, graph, visited, foundTDs)
            Next
        End If

        ' Удаляем узел из посещенных для возможности других путей
        visited.Remove(currentNode)
    End Sub

End Class
