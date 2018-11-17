Module controleLogin
    Dim usuario As New Usuario 'por default todo usuario inicializado com nenhum parametro é invalido (id = -1)

    Public Function validarUsuario(nome As String, senha As String)
        consultarDb("SELECT * FROM usuarios WHERE nome ='" & nome & "'")

        If rs.EOF Then
            MsgBox("Não existe um usuário com este nome")
        Else
            If rs.Fields("senha").Value = senha Then
                'MsgBox("Logado com sucesso")

                usuario.id = rs.Fields("id").Value
                usuario.nome = rs.Fields("nome").Value
                usuario.role = "ADMIN" 'temporário
            Else
                MsgBox("Senha inválida")
            End If
        End If

        Return usuario
    End Function
End Module
