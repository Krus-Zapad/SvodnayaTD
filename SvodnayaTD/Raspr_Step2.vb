Imports OfficeOpenXml
Imports System.IO

Public Class Raspr_Step2
    Public Function Parse(path As String,
                         sheet As String,
                         links As List(Of Link)) As List(Of JBRef)

        Dim result As New List(Of JBRef)

        ' Создаем словарь для быстрого поиска соответствия ЩУЭ -> ЩС
        Dim shueToShsDict = links.ToDictionary(Function(x) x.SHUE,
                                               Function(x) x.SHS)

        ' Множество для отслеживания уже добавленных JB (чтобы избежать дубликатов)
        Dim processedJB As New HashSet(Of String)

        Using pack As New ExcelPackage(New FileInfo(path))
            Dim ws = pack.Workbook.Worksheets(sheet)

            For r = 1 To ws.Dimension.Rows
                ' Читаем значение из первого столбца (ЩУЭ или RMO или пусто)
                Dim firstColValue = Read(ws, r, 1)

                ' Читаем значение из третьего столбца (может быть RMO или пусто)
                Dim thirdColValue = Read(ws, r, 3)

                ' Читаем значение из четвертого столбца (JB)
                Dim jbValue = Read(ws, r, 4)

                ' Пропускаем, если в четвертом столбце нет JB
                If String.IsNullOrEmpty(jbValue) Then Continue For

                ' Проверяем наличие ЩУЭ в первом столбце
                If firstColValue.Contains("ЩУЭ") Then
                    ' Если в первом столбце ЩУЭ, проверяем третий столбец
                    ' Третий может быть пустым или содержать RMO
                    If String.IsNullOrEmpty(thirdColValue) OrElse thirdColValue.Contains("RMO") Then
                        ' Проверяем, есть ли такое ЩУЭ в словаре
                        If shueToShsDict.ContainsKey(firstColValue) Then
                            Dim shs = shueToShsDict(firstColValue)
                            Dim jbKey = shs & "|" & jbValue

                            ' Добавляем, если еще не добавляли такую пару
                            If Not processedJB.Contains(jbKey) Then
                                result.Add(New JBRef With {
                                    .SHS = shs,
                                    .JB = jbValue
                                })
                                processedJB.Add(jbKey)
                            End If
                        End If
                    End If
                End If

                ' Дополнительная проверка: возможно ЩУЭ в первом столбце, 
                ' а RMO в третьем, но JB все равно относится к этому ЩУЭ
                ' Эта логика уже покрыта предыдущим условием

                ' Также проверяем случай, когда в первом столбце RMO,
                ' но выше по цепочке есть ЩУЭ (это обрабатывается через словарь links)

            Next

            ' Дополнительный проход для поиска JB, которые могут быть связаны с ЩУЭ через RMO
            ' Создаем словарь всех связей для рекурсивного поиска
            Dim rmoLinks As New Dictionary(Of String, List(Of String))
            For r = 1 To ws.Dimension.Rows
                Dim startNode = Read(ws, r, 1)
                Dim endNode = Read(ws, r, 4)

                If Not String.IsNullOrEmpty(startNode) AndAlso
                   Not String.IsNullOrEmpty(endNode) AndAlso
                   (startNode.Contains("RMO") OrElse startNode.Contains("ЩУЭ")) Then

                    If Not rmoLinks.ContainsKey(startNode) Then
                        rmoLinks(startNode) = New List(Of String)
                    End If
                    rmoLinks(startNode).Add(endNode)
                End If
            Next

            ' Ищем все JB для каждого ЩУЭ через RMO цепочки
            For Each kvp In shueToShsDict
                Dim shue = kvp.Key
                Dim shs = kvp.Value
                Dim visited As New HashSet(Of String)
                FindAllJB(shue, shs, rmoLinks, visited, result, processedJB)
            Next

        End Using

        ' Удаляем возможные дубликаты (на всякий случай)
        Return result.Distinct().ToList()
    End Function

    Private Sub FindAllJB(currentNode As String,
                          shs As String,
                          rmoLinks As Dictionary(Of String, List(Of String)),
                          ByRef visited As HashSet(Of String),
                          ByRef result As List(Of JBRef),
                          ByRef processedJB As HashSet(Of String))

        ' Защита от циклов
        If visited.Contains(currentNode) Then Return
        visited.Add(currentNode)

        ' Если у текущего узла есть связи
        If rmoLinks.ContainsKey(currentNode) Then
            For Each nextNode In rmoLinks(currentNode)
                ' Если следующий узел начинается с JB (или содержит JB в названии)
                If nextNode.Contains("JB") OrElse nextNode.Contains("ЯБ") Then
                    Dim jbKey = shs & "|" & nextNode
                    If Not processedJB.Contains(jbKey) Then
                        result.Add(New JBRef With {
                            .SHS = shs,
                            .JB = nextNode
                        })
                        processedJB.Add(jbKey)
                    End If
                Else
                    ' Рекурсивно ищем дальше
                    FindAllJB(nextNode, shs, rmoLinks, visited, result, processedJB)
                End If
            Next
        End If

        visited.Remove(currentNode)
    End Sub
End Class
