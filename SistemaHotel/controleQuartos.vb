Module controleQuartos
    Dim quarto As New Quarto
    Dim erro = 0

    Public Function buscarQuarto(numero As String)
        consultarDb("SELECT * FROM quartos WHERE numero = " & numero & "")

        If rs.EOF Then
            MsgBox("Não existe um quarto cadastrado com este Nnúmero", MsgBoxStyle.Exclamation, "ATENÇÃO")
            erro = 1 'quarto não existe
        Else
            quarto.id = rs.Fields("id").Value
            quarto.numero = rs.Fields("numero").Value
            quarto.andar = rs.Fields("andar").Value
            quarto.camasSolteiro = rs.Fields("camas_solteiro").Value
            quarto.camasCasal = rs.Fields("camas_casal").Value
            quarto.camasKs = rs.Fields("camas_solteiro").Value
            quarto.categoria = rs.Fields("categoria").Value
            quarto.status = rs.Fields("status").Value

        End If

        Return quarto
    End Function

    Public Function getErroQuarto()
        Return erro
    End Function
End Module
