Module controleLogin
    Dim usuario As New Usuario 'por default todo usuario inicializado com nenhum parametro é invalido (id = -1)
    Dim erro = 0

    Public Function validarUsuario(nome As String, senha As String)
        consultarDb("SELECT * FROM usuarios WHERE nome ='" & nome & "'")

        If rs.EOF Then
            MsgBox("Não existe um usuário com este nome", MsgBoxStyle.Exclamation, "ATENÇÃO")
            erro = 1 'usuario não existe
        Else
            If rs.Fields("senha").Value = senha Then
                usuario.id = rs.Fields("id").Value
                usuario.nome = rs.Fields("nome").Value
                usuario.role = "ADMIN" 'temporário
            Else
                MsgBox("Senha inválida")
                erro = 2 'senha invalida
            End If
        End If

        Return usuario
    End Function

    Public Function getErroLogin()
        Return erro
    End Function
End Module
