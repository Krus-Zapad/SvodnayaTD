Imports OfficeOpenXml
Imports System.IO

Public Class KJ_Step1

    Public Function Parse(path As String, sheet As String) As List(Of Link)
        Dim result As New List(Of Link)

        Using pack As New ExcelPackage(New FileInfo(path))
            Dim ws = pack.Workbook.Worksheets(sheet)

            ' Словарь для хранения всех связей: начало -> список концов
            Dim graph As New Dictionary(Of String, List(Of String))

            ' Строим граф связей
            For r = 1 To ws.Dimension.Rows
                Dim startPoint = Read(ws, r, 3) ' Начало
                Dim endPoint = Read(ws, r, 4)   ' Конец

                If Not String.IsNullOrEmpty(startPoint) AndAlso Not String.IsNullOrEmpty(endPoint) Then
                    If Not graph.ContainsKey(startPoint) Then
                        graph(startPoint) = New List(Of String)
                    End If
                    graph(startPoint).Add(endPoint)
                End If
            Next

            ' Множество для отслеживания уже обработанных связей
            Dim processedLinks As New HashSet(Of String)

            ' Для каждой строки ищем связи ЩС -> ЩУЭ
            For r = 1 To ws.Dimension.Rows
                Dim shs = Read(ws, r, 3) ' ЩС

                ' Проверяем, начинается ли текущая ячейка с ЩС
                If shs.StartsWith("ЩС") Then
                    ' Множество для отслеживания посещенных узлов (чтобы избежать циклов)
                    Dim visited As New HashSet(Of String)
                    ' Ищем все ЩУЭ, достижимые от этого ЩС
                    FindAllShue(shs, shs, graph, visited, result, processedLinks)
                End If
            Next
        End Using

        Return result
    End Function

    Private Sub FindAllShue(originalShs As String, currentNode As String, graph As Dictionary(Of String, List(Of String)),
                       visited As HashSet(Of String), result As List(Of Link), processedLinks As HashSet(Of String))

        ' Если узел уже посещали, выходим (защита от циклов)
        If visited.Contains(currentNode) Then
            Return
        End If

        ' Добавляем текущий узел в посещенные
        visited.Add(currentNode)

        ' Если текущий узел начинается с ЩУЭ и это не исходный ЩС
        If currentNode.StartsWith("ЩУЭ") Then
            Dim linkKey = originalShs & "->" & currentNode
            ' Добавляем связь, если её еще нет
            If Not processedLinks.Contains(linkKey) Then
                result.Add(New Link With {.SHS = originalShs, .SHUE = currentNode})
                processedLinks.Add(linkKey)
            End If
        End If

        ' Рекурсивно обходим все связи от текущего узла
        If graph.ContainsKey(currentNode) Then
            For Each nextNode In graph(currentNode)
                FindAllShue(originalShs, nextNode, graph, visited, result, processedLinks)
            Next
        End If

        ' Удаляем узел из посещенных при возврате (для возможности других путей)
        visited.Remove(currentNode)
    End Sub

End Class
