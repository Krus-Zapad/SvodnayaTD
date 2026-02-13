Public Class MainCore

    Public Sub Run(kjPath As String,
                   kjSheet As String,
                   rasprPath As String,
                   rasprSheet As String,
                   llPath As String,
                   llSheet As String,
                   savePath As String)

        Dim step1 = New KJ_Step1().Parse(kjPath, kjSheet)

        Dim step2 = New Raspr_Step2().Parse(rasprPath, rasprSheet, step1)

        Dim step3 = New LineList_Step3().Parse(llPath, llSheet, step2)

        'New Exporter().Save(savePath, step3)

        Dim Exporter As New Exporter
        Exporter.Save(savePath, step3)
    End Sub

End Class
