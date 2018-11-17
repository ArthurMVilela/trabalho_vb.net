Public Class Usuario
    Public id As Integer
    Public nome As String
    Public role As String

    Public Sub New()
        id = -1
        nome = "INVALIDO"
        role = "BLOQU"
    End Sub

    Public Sub New(_id As Integer, _nome As String, _role As String)
        id = _id
        nome = _nome
        role = _role
    End Sub
End Class
