Public Class frm_quartos

    Public quarto As Quarto

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub frm_quartos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        With cmb_status
            .Items.Add("Livre")
            .Items.Add("Ocupado")
            .Items.Add("Manutenção")
            .Items.Add("Reforma")
            .Items.Add("Limpesa")
        End With
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        If txt_numero.Text = "" Then
            MsgBox("Preencha o número do quarto antes.", MsgBoxStyle.Exclamation, "ATENÇÃO")
            txt_numero.Select()
        Else
            quarto = buscarQuarto(txt_numero.Text)
            If quarto.id <> -1 Then
                txt_andar.Text = quarto.andar

                cmb_categoria.Text = quarto.categoria
                cmb_status.Text = quarto.status

                txt_cama_solteiro.Text = quarto.camasSolteiro
                txt_cama_casal.Text = quarto.camasCasal
                txt_cama_ks.Text = quarto.camasKs
            End If
        End If
    End Sub

    Private Sub btn_consultar_cliente_Click(sender As Object, e As EventArgs) Handles btn_consultar_cliente.Click
        If cmb_status.Text <> "Ocupado" Then
            MsgBox("Não há ninguém hospedado neste quarto.", MsgBoxStyle.Exclamation, "ATENÇÃO")
        Else
            'chamar formulário de clientes para consulta
        End If
    End Sub
End Class