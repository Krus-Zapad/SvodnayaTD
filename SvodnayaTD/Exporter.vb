Imports OfficeOpenXml
Imports System.IO

Public Class Exporter

    Public Sub Save(path As String, list As List(Of TDRef))

        Using pack As New ExcelPackage
            Dim ws = pack.Workbook.Worksheets.Add("result")

            ws.Cells(1, 1).Value = "ЩС"
            ws.Cells(1, 2).Value = "TD"

            Dim r = 2

            For Each x In list
                ws.Cells(r, 1).Value = x.SHS
                ws.Cells(r, 2).Value = x.TD
                r += 1
            Next

            pack.SaveAs(New FileInfo(path))
        End Using

    End Sub

    Public Sub Save(path As String, list As List(Of Koords))

        Using pack As New ExcelPackage
            Dim ws = pack.Workbook.Worksheets.Add("result")

            ws.Cells(1, 1).Value = "ЩС"
            ws.Cells(1, 2).Value = "TD"
            ws.Cells(1, 3).Value = "X"
            ws.Cells(1, 4).Value = "Y"
            ws.Cells(1, 5).Value = "Z"

            Dim r = 2

            For Each x In list
                ws.Cells(r, 1).Value = x.SHS
                ws.Cells(r, 2).Value = x.TD
                ws.Cells(r, 3).Value = x.X
                ws.Cells(r, 4).Value = x.Y
                ws.Cells(r, 5).Value = x.Z
                r += 1
            Next

            pack.SaveAs(New FileInfo(path))
        End Using

    End Sub

End Class
