Public Class frm_login
    Public usuario As New Usuario

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectarDb()

    End Sub

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click

        If txt_nome.Text = "" Or txt_senha.Text = "" Then
            MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation, "ATENÇÃO")
            Exit Sub
        Else
            usuario = validarUsuario(txt_nome.Text, txt_senha.Text)
        End If


        If usuario.id <> -1 Then
            Me.Close()
        Else
            lbl_info.ForeColor = Color.Red
            If getErroLogin() = 1 Then
                lbl_info.Text = "Este usuário não existe."
                txt_nome.Text = ""
                txt_senha.Text = ""
                txt_nome.Select()

            ElseIf getErroLogin() = 2 Then
                lbl_info.Text = "Senha inválida."
                txt_senha.Text = ""
                txt_senha.Select()

            End If
        End If
    End Sub
End Class