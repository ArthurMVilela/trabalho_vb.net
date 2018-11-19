Public Class frm_quartos

    Public quarto As Quarto
    Public cliente As Cliente
    Dim resp


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub frm_quartos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        With cmb_status
            .Items.Add("Livre")
            '.Items.Add("Ocupado")
            .Items.Add("Manutenção")
            .Items.Add("Reforma")
            .Items.Add("Limpesa")
        End With

        'preencher o datagrid
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDb.OleDbDataAdapter("SELECT numero,status FROM quartos", db.ConnectionString)
        da.Fill(dt)

        dgv_quartos.DataSource = dt.DefaultView

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

                If cmb_status.Text = "Ocupado" Then
                    cmb_status.Enabled = False
                Else
                    cmb_status.Enabled = True
                End If

                txt_cama_solteiro.Text = quarto.camasSolteiro
                txt_cama_casal.Text = quarto.camasCasal
                txt_cama_ks.Text = quarto.camasKs

                cliente = buscarOcupantes()

                If cliente.id <> -1 Then
                    txt_cod_cliente.Text = cliente.id
                    txt_nome_cliente.Text = cliente.nome
                Else
                    txt_cod_cliente.Text = ""
                    txt_nome_cliente.Text = ""
                    txt_acompanhantes.Text = ""
                End If

                'preencher o datagrid
                Dim ds As New DataSet
                Dim dt As New DataTable
                ds.Tables.Add(dt)
                Dim da As New OleDb.OleDbDataAdapter("SELECT itens_quarto.qtde, itens.desc FROM itens_quarto  
                                                        INNER JOIN itens ON itens_quarto.id_item = itens.id 
                                                        WHERE itens_quarto.id_quarto = " & quarto.id & ";", db.ConnectionString)
                da.Fill(dt)

                dgv_itens.DataSource = dt.DefaultView
            Else 'quarto não exite
                MsgBox("Não existe um quarto cadastrado com este número", MsgBoxStyle.Exclamation, "ATENÇÃO")
                txt_andar.Text = ""
                txt_andar.Select()

                cmb_categoria.Text = ""
                cmb_status.Text = ""

                txt_cama_solteiro.Text = ""
                txt_cama_casal.Text = ""
                txt_cama_ks.Text = ""

                txt_cod_cliente.Text = ""
                txt_nome_cliente.Text = ""
                txt_acompanhantes.Text = ""

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

    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        quarto = buscarQuarto(txt_numero.Text)



        If quarto.id <> -1 Then 'se o quarto já estivar cadastrado

            resp = MsgBox("Deseja alterar as informações deste quarto?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")

            If resp = vbYes Then
                atualizarQuarto(txt_cama_solteiro.Text, txt_cama_casal.Text, txt_cama_ks.Text, cmb_categoria.Text, cmb_status.Text, txt_numero.Text)
            End If


        Else
            resp = MsgBox("Deseja cadastrar um novo quarto com estas informações?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")

            If resp = vbYes Then
                cadastrarQuarto(txt_numero.Text, txt_cama_solteiro.Text, txt_cama_casal.Text, txt_cama_ks.Text, cmb_categoria.Text, cmb_status.Text)
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        quarto = buscarQuarto(txt_numero.Text)
        cliente = buscarOcupantes()

        If cliente.id <> -1 Then
            MsgBox("Este quarto está ocupado!", MsgBoxStyle.Exclamation)

        Else
            resp = MsgBox("Deseja excluir este quarto do banco de dados?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
            If resp = vbYes Then
                deletarQuarto(txt_numero.Text)
            End If
        End If

    End Sub
End Class