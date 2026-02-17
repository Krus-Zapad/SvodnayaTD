Imports OfficeOpenXml

Public Module ExcelHelper

    Public Function Read(ws As ExcelWorksheet, r As Integer, c As Integer) As String

        Dim cell = ws.Cells(r, c)
        Dim val As Object = Nothing

        If cell.Merge Then
            Dim addr = ws.MergedCells(r, c)
            If addr IsNot Nothing Then
                Dim spl = Split(addr, ":")
                val = Replace(ws.Cells(spl(LBound(spl))).Value, "JBк", "JB")
            End If
        Else
            val = Replace(cell.Value, "JBк", "JB")
        End If

        If val Is Nothing Then Return ""

        Dim s = val.ToString()

        s = s.Replace(" ", "")
        s = s.Replace(vbTab, "")
        s = s.Replace(vbCr, "")
        s = s.Replace(vbLf, "")

        Return s.Trim()
    End Function

End Module
