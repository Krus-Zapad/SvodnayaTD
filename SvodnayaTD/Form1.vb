Imports OfficeOpenXml
Imports System.IO

Public Class frmTD_SHP
    Private Sub frmTD_SHP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ExcelPackage.License.SetNonCommercialPersonal("Salavat")
    End Sub

    Private Sub f_b_LL_Path_Click(sender As Object, e As EventArgs) Handles f_b_LL_Path.Click
        Dim ofd As New OpenFileDialog With {
                                              .DefaultExt = "xls",
                                              .Filter = "Excel files|*.xls*|All files|*.*"
                                              }

        ofd.Title = "Выбор Лайнлиста"
        If ofd.ShowDialog() <> DialogResult.Cancel Then
            f_tb_LLPath.Text = ofd.FileName
            If Not File.Exists(f_tb_LLPath.Text) Then
                f_tb_Messages.Text = f_tb_Messages.Text & vbNewLine & "Файл " & f_tb_LLPath.Text & " Excel не найден!"
            End If

            Dim exPackage As New ExcelPackage(New FileInfo(f_tb_LLPath.Text))
            Dim worksheets As ExcelWorksheets = exPackage.Workbook.Worksheets
            f_cb_LL_Sheets.Items.Clear()

            For Each ws In worksheets
                f_cb_LL_Sheets.Items.Add(ws.Name)
            Next
            f_cb_LL_Sheets.SelectedIndex = 0
            f_tb_Messages.Text = f_tb_Messages.Text & vbNewLine & "Файл лайнлиста загружен. Укажите наименование листа."
            f_cb_LL_Sheets.Select()
            f_tb_OutPath.Text = Replace(ofd.FileName, exPackage.File.Name, "") & "СводнаяTD_" & Replace(DateTime.Now, ":", "_") & ".xlsx"
        End If
    End Sub

    Private Sub f_b_KJ_Path_Click(sender As Object, e As EventArgs) Handles f_b_KJ_Path.Click
        Dim ofd As New OpenFileDialog With {
                                              .DefaultExt = "xls",
                                              .Filter = "Excel files|*.xls*|All files|*.*"
                                              }

        ofd.Title = "Выбор файла с КЖ"
        If ofd.ShowDialog() <> DialogResult.Cancel Then
            f_tb_KJPath.Text = ofd.FileName
            If Not File.Exists(f_tb_KJPath.Text) Then
                f_tb_Messages.Text = f_tb_Messages.Text & vbNewLine & "Файл " & f_tb_KJPath.Text & " Excel не найден!"
            End If

            Dim exPackage As New ExcelPackage(New FileInfo(f_tb_KJPath.Text))
            Dim worksheets As ExcelWorksheets = exPackage.Workbook.Worksheets
            f_cb_KJ_Sheets.Items.Clear()

            For Each ws In worksheets
                f_cb_KJ_Sheets.Items.Add(ws.Name)
            Next
            f_cb_KJ_Sheets.SelectedIndex = 0
            f_tb_Messages.Text = f_tb_Messages.Text & vbNewLine & "Файл КЖ загружен. Укажите наименование листа."
            f_cb_KJ_Sheets.Select()
        End If
    End Sub

    Private Sub f_b_Raspr_Path_Click(sender As Object, e As EventArgs) Handles f_b_Raspr_Path.Click
        Dim ofd As New OpenFileDialog With {
                                               .DefaultExt = "xls",
                                               .Filter = "Excel files|*.xls*|All files|*.*"
                                               }

        ofd.Title = "Выбор файла с рапределением"
        If ofd.ShowDialog() <> DialogResult.Cancel Then
            f_tb_RasprPath.Text = ofd.FileName
            If Not File.Exists(f_tb_RasprPath.Text) Then
                f_tb_Messages.Text = f_tb_Messages.Text & vbNewLine & "Файл " & f_tb_RasprPath.Text & " Excel не найден!"
            End If

            Dim exPackage As New ExcelPackage(New FileInfo(f_tb_RasprPath.Text))
            Dim worksheets As ExcelWorksheets = exPackage.Workbook.Worksheets
            f_cb_Raspr_Sheets.Items.Clear()

            For Each ws In worksheets
                f_cb_Raspr_Sheets.Items.Add(ws.Name)
            Next
            f_cb_Raspr_Sheets.SelectedIndex = 0
            f_tb_Messages.Text = f_tb_Messages.Text & vbNewLine & "Файл распределения загружен. Укажите наименование листа."
            f_cb_Raspr_Sheets.Select()
        End If
    End Sub

    Private Sub f_b_Create_Click(sender As Object, e As EventArgs) Handles f_b_Create.Click

        'читаем из КЖ связь ЩС->ЩУЭ
        Dim step1 = New KJ_Step1().Parse(f_tb_KJPath.Text, f_cb_KJ_Sheets.Text)

        'читаем из распределения связь ЩУЭ->JB
        Dim step2 = New Raspr_Step2().Parse(f_tb_RasprPath.Text, f_cb_Raspr_Sheets.Text, step1)

        'читаем из лайна связь JB->TD
        Dim step3 = New LineList_Step3().Parse(f_tb_LLPath.Text, f_cb_LL_Sheets.Text, step2)

        'подтягиваем координаты, если они указаны
        If f_tb_KoordsPath.Text <> "" Then
            Dim step4 = New Koords_Step4().Parse(f_tb_KoordsPath.Text, f_cb_Koords_Sheets.Text, step3)
            Dim ex As New Exporter
            ex.Save(f_tb_OutPath.Text, step4)
        Else
            Dim ex As New Exporter
            ex.Save(f_tb_OutPath.Text, step3)
        End If



        f_tb_Messages.AppendText(vbCrLf & "Готово: " & f_tb_OutPath.Text & vbCrLf)


    End Sub

    Private Sub f_b_Koords_Path_Click(sender As Object, e As EventArgs) Handles f_b_Koords_Path.Click
        Dim ofd As New OpenFileDialog With {
                                              .DefaultExt = "xls",
                                              .Filter = "Excel files|*.xls*|All files|*.*"
                                              }

        ofd.Title = "Выбор файла с координатами"
        If ofd.ShowDialog() <> DialogResult.Cancel Then
            f_tb_KoordsPath.Text = ofd.FileName
            If Not File.Exists(f_tb_KoordsPath.Text) Then
                f_tb_Messages.Text = f_tb_Messages.Text & vbNewLine & "Файл " & f_tb_KoordsPath.Text & " Excel не найден!"
            End If

            Dim exPackage As New ExcelPackage(New FileInfo(f_tb_KoordsPath.Text))
            Dim worksheets As ExcelWorksheets = exPackage.Workbook.Worksheets
            f_cb_Koords_Sheets.Items.Clear()

            For Each ws In worksheets
                f_cb_Koords_Sheets.Items.Add(ws.Name)
            Next
            f_cb_Koords_Sheets.SelectedIndex = 0
            f_tb_Messages.Text = f_tb_Messages.Text & vbNewLine & "Файл координат загружен. Укажите наименование листа."
            f_cb_Koords_Sheets.Select()
        End If
    End Sub
End Class
