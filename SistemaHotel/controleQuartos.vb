Module controleQuartos
    Dim quarto As New Quarto
    Dim cliente As New Cliente
    Dim erro = 0

    Dim quarto_invalido As New Quarto
    Dim cliente_invalido As New Cliente

    Public Function buscarQuarto(numero As String)
        consultarDb("SELECT * FROM quartos WHERE numero = " & numero & "")

        If rs.EOF Then
            'MsgBox("Não existe um quarto cadastrado com este número", MsgBoxStyle.Exclamation, "ATENÇÃO")
            quarto = quarto_invalido
            cliente = cliente_invalido
            erro = 1 'quarto não existe
        Else
            quarto.id = rs.Fields("id").Value
            quarto.numero = rs.Fields("numero").Value
            quarto.andar = rs.Fields("andar").Value
            quarto.camasSolteiro = rs.Fields("camas_solteiro").Value
            quarto.camasCasal = rs.Fields("camas_casal").Value
            quarto.camasKs = rs.Fields("camas_kingsize").Value
            quarto.categoria = rs.Fields("categoria").Value
            quarto.status = rs.Fields("status").Value

            buscarOcupantes()

        End If

        Return quarto
    End Function

    Public Sub atualizarQuarto(cama_solteiro, cama_casal, cama_ks, categoria, status, numero)
        executarCmdDb("UPDATE quartos SET camas_solteiro = " & cama_solteiro & ", camas_casal = " & cama_casal & "
                            , camas_kingsize = " & cama_ks & ", categoria = '" & categoria & "', status = '" & status & "'
                            WHERE numero = " & numero & "")
    End Sub

    Public Sub cadastrarQuarto(numero, cama_solteiro, cama_casal, cama_ks, categoria, status)
        executarCmdDb("INSERT INTO quartos (numero, camas_solteiro, camas_casal, camas_kingsize, categoria,status ) 
                        VALUES (" & numero & "," & cama_solteiro & "," & cama_casal & "," & cama_ks & ",'" & categoria & "','" & status & "')")
    End Sub

    Public Sub deletarQuarto(numero)
        executarCmdDb("DELETE FROM quartos WHERE numero=" & numero & "")
    End Sub

    Public Function buscarOcupantes()
        consultarDb("SELECT * FROM cliente_quarto WHERE id_quarto =" & quarto.id & " AND check_in IS NOT NULL AND check_out IS NULL")

        If rs.EOF Then
            'MsgBox("Este quarto não tem ocupantes", MsgBoxStyle.Exclamation, "ATENÇÃO")
            cliente = cliente_invalido
            erro = 2 'quarto não tem ocupante
        Else
            cliente.id = rs.Fields("id_cliente").Value

            consultarDb("SELECT * FROM clientes WHERE id = " & cliente.id & "")

            cliente.nome = rs.Fields("nome").Value

        End If

        Return cliente
    End Function

    Public Function getErroQuarto()
        Return erro
    End Function
End Module
