Imports OfficeOpenXml
Imports System.IO
Public Class Koords_Step4
    Public Function Parse(path As String,
                     sheet As String,
                     tdRefs As List(Of TDRef)) As List(Of Koords)

        Dim result As New List(Of Koords)

        ' Словарь для быстрого поиска координат по TD
        Dim tdCoordinates As New Dictionary(Of String, (X As String, Y As String, Z As String))

        Using pack As New ExcelPackage(New FileInfo(path))
            Dim ws = pack.Workbook.Worksheets(sheet)

            ' Сначала собираем все координаты из книги
            For r = 1 To ws.Dimension.Rows
                Dim tdName = Read(ws, r, 1)  ' Наименование TD в первом столбце
                If String.IsNullOrEmpty(tdName) Then Continue For

                Dim xCoord = Read(ws, r, 2)  ' X координата
                Dim yCoord = Read(ws, r, 3)  ' Y координата
                Dim zCoord = Read(ws, r, 4)  ' Z координата

                ' Сохраняем координаты для этого TD
                If Not tdCoordinates.ContainsKey(tdName) Then
                    tdCoordinates(tdName) = (xCoord, yCoord, zCoord)
                End If
            Next

            ' Множество для отслеживания уже добавленных записей (SHS + TD)
            Dim processedEntries As New HashSet(Of String)

            ' Для каждого TD из предыдущего этапа ищем координаты
            For Each tdRef In tdRefs
                Dim td = tdRef.TD
                Dim shs = tdRef.SHS

                ' Ключ для проверки дубликатов
                Dim entryKey = shs & "|" & td

                ' Пропускаем, если уже обработали
                If processedEntries.Contains(entryKey) Then Continue For

                ' Ищем координаты для этого TD
                If tdCoordinates.ContainsKey(td) Then
                    Dim coords = tdCoordinates(td)

                    result.Add(New Koords With {
                    .SHS = shs,
                    .TD = td,
                    .X = coords.X,
                    .Y = coords.Y,
                    .Z = coords.Z
                })

                    processedEntries.Add(entryKey)
                Else
                    ' Если точное совпадение не найдено, пробуем частичное совпадение
                    Dim foundMatch = False
                    For Each kvp In tdCoordinates
                        ' Проверяем, содержится ли искомый TD в ключе или ключ в искомом TD
                        If kvp.Key.Contains(td) OrElse td.Contains(kvp.Key) Then
                            result.Add(New Koords With {
                            .SHS = shs,
                            .TD = td,
                            .X = kvp.Value.X,
                            .Y = kvp.Value.Y,
                            .Z = kvp.Value.Z
                        })

                            processedEntries.Add(entryKey)
                            foundMatch = True
                            Exit For
                        End If
                    Next

                    ' Если даже частичное совпадение не найдено, добавляем запись с пустыми координатами
                    If Not foundMatch Then
                        result.Add(New Koords With {
                        .SHS = shs,
                        .TD = td,
                        .X = "",
                        .Y = "",
                        .Z = ""
                    })
                        processedEntries.Add(entryKey)
                    End If
                End If
            Next
        End Using

        Return result
    End Function

End Class

