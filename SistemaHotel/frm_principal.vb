Public Class frm_principal
    Private Sub frm_principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim login As New frm_login
        Dim usuario As New Usuario

        Me.Enabled = False
        login.ShowDialog()
        usuario = login.usuario

        If usuario.id <> -1 Then
            Me.Enabled = True
        Else
            Application.Exit()
        End If

        'barra de status
        lbl_usuario.Text = "USUÁRIO: " & usuario.nome
    End Sub

    Private Sub menu_btn_sair_Click(sender As Object, e As EventArgs) Handles menu_btn_sair.Click
        Dim resp As String

        resp = MsgBox("Deseja sair da aplicação?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")

        If resp = vbYes Then
            Application.Exit()
        End If

    End Sub
End Class