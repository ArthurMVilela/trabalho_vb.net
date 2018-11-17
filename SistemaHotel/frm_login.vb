Public Class frm_login
    Public usuario As New Usuario

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectarDb()

    End Sub
End Class