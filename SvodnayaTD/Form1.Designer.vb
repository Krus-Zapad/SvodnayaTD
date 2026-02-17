<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTD_SHP
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.f_tb_SCHS = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.f_tb_SCHIT = New System.Windows.Forms.TextBox()
        Me.f_tb_TD = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.f_tb_JB = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.f_tb_RasprPath = New System.Windows.Forms.TextBox()
        Me.f_b_Raspr_Path = New System.Windows.Forms.Button()
        Me.f_cb_Raspr_Sheets = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.f_tb_KJPath = New System.Windows.Forms.TextBox()
        Me.f_b_KJ_Path = New System.Windows.Forms.Button()
        Me.f_cb_KJ_Sheets = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.f_tb_LLPath = New System.Windows.Forms.TextBox()
        Me.f_b_LL_Path = New System.Windows.Forms.Button()
        Me.f_cb_LL_Sheets = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.f_tb_Messages = New System.Windows.Forms.TextBox()
        Me.f_b_Create = New System.Windows.Forms.Button()
        Me.f_tb_OutPath = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.f_tb_KoordsPath = New System.Windows.Forms.TextBox()
        Me.f_b_Koords_Path = New System.Windows.Forms.Button()
        Me.f_cb_Koords_Sheets = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.f_tb_SCHS)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.f_tb_SCHIT)
        Me.GroupBox4.Controls.Add(Me.f_tb_TD)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.f_tb_JB)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 381)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(767, 74)
        Me.GroupBox4.TabIndex = 1025
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Соответствие понятий"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(6, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 1008
        Me.Label6.Text = "Щит связи"
        '
        'f_tb_SCHS
        '
        Me.f_tb_SCHS.AllowDrop = True
        Me.f_tb_SCHS.BackColor = System.Drawing.SystemColors.Window
        Me.f_tb_SCHS.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.f_tb_SCHS.Location = New System.Drawing.Point(9, 42)
        Me.f_tb_SCHS.Name = "f_tb_SCHS"
        Me.f_tb_SCHS.Size = New System.Drawing.Size(64, 20)
        Me.f_tb_SCHS.TabIndex = 1007
        Me.f_tb_SCHS.Text = "ЩС"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(91, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 1010
        Me.Label7.Text = "ЩУЭ"
        '
        'f_tb_SCHIT
        '
        Me.f_tb_SCHIT.AllowDrop = True
        Me.f_tb_SCHIT.BackColor = System.Drawing.SystemColors.Window
        Me.f_tb_SCHIT.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.f_tb_SCHIT.Location = New System.Drawing.Point(94, 42)
        Me.f_tb_SCHIT.Name = "f_tb_SCHIT"
        Me.f_tb_SCHIT.Size = New System.Drawing.Size(64, 20)
        Me.f_tb_SCHIT.TabIndex = 1009
        Me.f_tb_SCHIT.Text = "ЩУЭ"
        '
        'f_tb_TD
        '
        Me.f_tb_TD.AllowDrop = True
        Me.f_tb_TD.BackColor = System.Drawing.SystemColors.Window
        Me.f_tb_TD.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.f_tb_TD.Location = New System.Drawing.Point(284, 42)
        Me.f_tb_TD.Name = "f_tb_TD"
        Me.f_tb_TD.Size = New System.Drawing.Size(64, 20)
        Me.f_tb_TD.TabIndex = 1013
        Me.f_tb_TD.Text = "TD"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(185, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 13)
        Me.Label8.TabIndex = 1012
        Me.Label8.Text = "JB"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(281, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(22, 13)
        Me.Label9.TabIndex = 1014
        Me.Label9.Text = "TD"
        '
        'f_tb_JB
        '
        Me.f_tb_JB.AllowDrop = True
        Me.f_tb_JB.BackColor = System.Drawing.SystemColors.Window
        Me.f_tb_JB.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.f_tb_JB.Location = New System.Drawing.Point(188, 42)
        Me.f_tb_JB.Name = "f_tb_JB"
        Me.f_tb_JB.Size = New System.Drawing.Size(64, 20)
        Me.f_tb_JB.TabIndex = 1011
        Me.f_tb_JB.Text = "JB"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.f_tb_RasprPath)
        Me.GroupBox3.Controls.Add(Me.f_b_Raspr_Path)
        Me.GroupBox3.Controls.Add(Me.f_cb_Raspr_Sheets)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 195)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(767, 87)
        Me.GroupBox3.TabIndex = 1024
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Распределение"
        '
        'f_tb_RasprPath
        '
        Me.f_tb_RasprPath.AllowDrop = True
        Me.f_tb_RasprPath.BackColor = System.Drawing.SystemColors.Window
        Me.f_tb_RasprPath.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.f_tb_RasprPath.Location = New System.Drawing.Point(9, 19)
        Me.f_tb_RasprPath.Name = "f_tb_RasprPath"
        Me.f_tb_RasprPath.Size = New System.Drawing.Size(662, 20)
        Me.f_tb_RasprPath.TabIndex = 10
        '
        'f_b_Raspr_Path
        '
        Me.f_b_Raspr_Path.Location = New System.Drawing.Point(677, 17)
        Me.f_b_Raspr_Path.Name = "f_b_Raspr_Path"
        Me.f_b_Raspr_Path.Size = New System.Drawing.Size(75, 23)
        Me.f_b_Raspr_Path.TabIndex = 11
        Me.f_b_Raspr_Path.Text = "Обзор"
        Me.f_b_Raspr_Path.UseVisualStyleBackColor = True
        '
        'f_cb_Raspr_Sheets
        '
        Me.f_cb_Raspr_Sheets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.f_cb_Raspr_Sheets.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.f_cb_Raspr_Sheets.FormattingEnabled = True
        Me.f_cb_Raspr_Sheets.Location = New System.Drawing.Point(8, 58)
        Me.f_cb_Raspr_Sheets.Name = "f_cb_Raspr_Sheets"
        Me.f_cb_Raspr_Sheets.Size = New System.Drawing.Size(288, 21)
        Me.f_cb_Raspr_Sheets.TabIndex = 1001
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Location = New System.Drawing.Point(5, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 1002
        Me.Label1.Text = "Лист"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.f_tb_KJPath)
        Me.GroupBox2.Controls.Add(Me.f_b_KJ_Path)
        Me.GroupBox2.Controls.Add(Me.f_cb_KJ_Sheets)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 104)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(767, 85)
        Me.GroupBox2.TabIndex = 1023
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "КЖ"
        '
        'f_tb_KJPath
        '
        Me.f_tb_KJPath.AllowDrop = True
        Me.f_tb_KJPath.BackColor = System.Drawing.SystemColors.Window
        Me.f_tb_KJPath.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.f_tb_KJPath.Location = New System.Drawing.Point(9, 19)
        Me.f_tb_KJPath.Name = "f_tb_KJPath"
        Me.f_tb_KJPath.Size = New System.Drawing.Size(662, 20)
        Me.f_tb_KJPath.TabIndex = 10
        '
        'f_b_KJ_Path
        '
        Me.f_b_KJ_Path.Location = New System.Drawing.Point(677, 17)
        Me.f_b_KJ_Path.Name = "f_b_KJ_Path"
        Me.f_b_KJ_Path.Size = New System.Drawing.Size(75, 23)
        Me.f_b_KJ_Path.TabIndex = 11
        Me.f_b_KJ_Path.Text = "Обзор"
        Me.f_b_KJ_Path.UseVisualStyleBackColor = True
        '
        'f_cb_KJ_Sheets
        '
        Me.f_cb_KJ_Sheets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.f_cb_KJ_Sheets.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.f_cb_KJ_Sheets.FormattingEnabled = True
        Me.f_cb_KJ_Sheets.Location = New System.Drawing.Point(9, 58)
        Me.f_cb_KJ_Sheets.Name = "f_cb_KJ_Sheets"
        Me.f_cb_KJ_Sheets.Size = New System.Drawing.Size(288, 21)
        Me.f_cb_KJ_Sheets.TabIndex = 1001
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Enabled = False
        Me.Label11.Location = New System.Drawing.Point(6, 42)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 13)
        Me.Label11.TabIndex = 1002
        Me.Label11.Text = "Лист"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.f_tb_LLPath)
        Me.GroupBox1.Controls.Add(Me.f_b_LL_Path)
        Me.GroupBox1.Controls.Add(Me.f_cb_LL_Sheets)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(767, 86)
        Me.GroupBox1.TabIndex = 1022
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Лайнлист"
        '
        'f_tb_LLPath
        '
        Me.f_tb_LLPath.AllowDrop = True
        Me.f_tb_LLPath.BackColor = System.Drawing.SystemColors.Window
        Me.f_tb_LLPath.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.f_tb_LLPath.Location = New System.Drawing.Point(9, 19)
        Me.f_tb_LLPath.Name = "f_tb_LLPath"
        Me.f_tb_LLPath.Size = New System.Drawing.Size(662, 20)
        Me.f_tb_LLPath.TabIndex = 10
        '
        'f_b_LL_Path
        '
        Me.f_b_LL_Path.Location = New System.Drawing.Point(677, 17)
        Me.f_b_LL_Path.Name = "f_b_LL_Path"
        Me.f_b_LL_Path.Size = New System.Drawing.Size(75, 23)
        Me.f_b_LL_Path.TabIndex = 11
        Me.f_b_LL_Path.Text = "Обзор"
        Me.f_b_LL_Path.UseVisualStyleBackColor = True
        '
        'f_cb_LL_Sheets
        '
        Me.f_cb_LL_Sheets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.f_cb_LL_Sheets.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.f_cb_LL_Sheets.FormattingEnabled = True
        Me.f_cb_LL_Sheets.Location = New System.Drawing.Point(9, 58)
        Me.f_cb_LL_Sheets.Name = "f_cb_LL_Sheets"
        Me.f_cb_LL_Sheets.Size = New System.Drawing.Size(288, 21)
        Me.f_cb_LL_Sheets.TabIndex = 1001
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Location = New System.Drawing.Point(6, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 1002
        Me.Label3.Text = "Лист"
        '
        'f_tb_Messages
        '
        Me.f_tb_Messages.Enabled = False
        Me.f_tb_Messages.Location = New System.Drawing.Point(12, 519)
        Me.f_tb_Messages.Multiline = True
        Me.f_tb_Messages.Name = "f_tb_Messages"
        Me.f_tb_Messages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.f_tb_Messages.Size = New System.Drawing.Size(767, 109)
        Me.f_tb_Messages.TabIndex = 1021
        Me.f_tb_Messages.TabStop = False
        '
        'f_b_Create
        '
        Me.f_b_Create.Location = New System.Drawing.Point(677, 17)
        Me.f_b_Create.Name = "f_b_Create"
        Me.f_b_Create.Size = New System.Drawing.Size(74, 23)
        Me.f_b_Create.TabIndex = 1020
        Me.f_b_Create.Text = "Запуск"
        Me.f_b_Create.UseVisualStyleBackColor = True
        '
        'f_tb_OutPath
        '
        Me.f_tb_OutPath.AllowDrop = True
        Me.f_tb_OutPath.BackColor = System.Drawing.SystemColors.Window
        Me.f_tb_OutPath.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.f_tb_OutPath.Location = New System.Drawing.Point(9, 19)
        Me.f_tb_OutPath.Name = "f_tb_OutPath"
        Me.f_tb_OutPath.Size = New System.Drawing.Size(661, 20)
        Me.f_tb_OutPath.TabIndex = 1026
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.f_tb_KoordsPath)
        Me.GroupBox5.Controls.Add(Me.f_b_Koords_Path)
        Me.GroupBox5.Controls.Add(Me.f_cb_Koords_Sheets)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Location = New System.Drawing.Point(11, 288)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(767, 87)
        Me.GroupBox5.TabIndex = 1027
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Координаты"
        '
        'f_tb_KoordsPath
        '
        Me.f_tb_KoordsPath.AllowDrop = True
        Me.f_tb_KoordsPath.BackColor = System.Drawing.SystemColors.Window
        Me.f_tb_KoordsPath.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.f_tb_KoordsPath.Location = New System.Drawing.Point(9, 19)
        Me.f_tb_KoordsPath.Name = "f_tb_KoordsPath"
        Me.f_tb_KoordsPath.Size = New System.Drawing.Size(662, 20)
        Me.f_tb_KoordsPath.TabIndex = 10
        '
        'f_b_Koords_Path
        '
        Me.f_b_Koords_Path.Location = New System.Drawing.Point(677, 17)
        Me.f_b_Koords_Path.Name = "f_b_Koords_Path"
        Me.f_b_Koords_Path.Size = New System.Drawing.Size(75, 23)
        Me.f_b_Koords_Path.TabIndex = 11
        Me.f_b_Koords_Path.Text = "Обзор"
        Me.f_b_Koords_Path.UseVisualStyleBackColor = True
        '
        'f_cb_Koords_Sheets
        '
        Me.f_cb_Koords_Sheets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.f_cb_Koords_Sheets.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.f_cb_Koords_Sheets.FormattingEnabled = True
        Me.f_cb_Koords_Sheets.Location = New System.Drawing.Point(8, 58)
        Me.f_cb_Koords_Sheets.Name = "f_cb_Koords_Sheets"
        Me.f_cb_Koords_Sheets.Size = New System.Drawing.Size(288, 21)
        Me.f_cb_Koords_Sheets.TabIndex = 1001
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Enabled = False
        Me.Label4.Location = New System.Drawing.Point(5, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 1002
        Me.Label4.Text = "Лист"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.f_tb_OutPath)
        Me.GroupBox6.Controls.Add(Me.f_b_Create)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 461)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(767, 52)
        Me.GroupBox6.TabIndex = 1028
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Путь к выходному файлу"
        '
        'frmTD_SHP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 637)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.f_tb_Messages)
        Me.Name = "frmTD_SHP"
        Me.Text = "Form1"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents f_tb_SCHS As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents f_tb_SCHIT As TextBox
    Friend WithEvents f_tb_TD As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents f_tb_JB As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents f_tb_RasprPath As TextBox
    Friend WithEvents f_b_Raspr_Path As Button
    Friend WithEvents f_cb_Raspr_Sheets As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents f_tb_KJPath As TextBox
    Friend WithEvents f_b_KJ_Path As Button
    Friend WithEvents f_cb_KJ_Sheets As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents f_tb_LLPath As TextBox
    Friend WithEvents f_b_LL_Path As Button
    Friend WithEvents f_cb_LL_Sheets As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents f_tb_Messages As TextBox
    Friend WithEvents f_b_Create As Button
    Friend WithEvents f_tb_OutPath As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents f_tb_KoordsPath As TextBox
    Friend WithEvents f_b_Koords_Path As Button
    Friend WithEvents f_cb_Koords_Sheets As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox6 As GroupBox
End Class
