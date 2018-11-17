Public Class frm_login
    Public usuario As New Usuario

    Function checarCampos()
        If txt_nome.Text = "" Or txt_senha.Text = "" Then
            MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation, "ATENÇÃO")

            Return False
        Else
            Return True
        End If
    End Function

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectarDb()

    End Sub

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click

        If checarCampos() Then
            usuario = validarUsuario(txt_nome.Text, txt_senha.Text)
        End If

        If usuario.id <> -1 Then
            Me.Close()

        Else
            lbl_erros.Text = "Senha ou nome invalidos!"
        End If
    End Sub
End Class