Public Class frm_login
    Public usuario As New Usuario

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectarDb()

    End Sub

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        usuario = validarUsuario(txt_nome.Text, txt_senha.Text)

        If usuario.id <> -1 Then
            Me.Close()
        End If
    End Sub
End Class