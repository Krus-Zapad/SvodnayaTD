Public Class Link
    Public Property SHS As String
    Public Property SHUE As String
End Class

Public Class JBRef
    Public Property SHS As String
    Public Property JB As String
End Class

Public Class TDRef
    Public Property SHS As String
    Public Property TD As String
End Class

Public Class Koords
    Public Property SHS As String
    Public Property TD As String
    Public Property X As String
    Public Property Y As String
    Public Property Z As String

    ' Для удобства отладки и вывода
    Public Overrides Function ToString() As String
        Return $"SHS: {SHS}, TD: {TD}, X: {X}, Y: {Y}, Z: {Z}"
    End Function
End Class