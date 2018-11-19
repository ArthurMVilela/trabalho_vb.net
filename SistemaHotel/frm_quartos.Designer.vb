<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_quartos
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_cadastrar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_consultar_cliente = New System.Windows.Forms.Button()
        Me.txt_nome_cliente = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_acompanhantes = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_cod_cliente = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmb_status = New System.Windows.Forms.ComboBox()
        Me.cmb_categoria = New System.Windows.Forms.ComboBox()
        Me.Camas = New System.Windows.Forms.GroupBox()
        Me.txt_cama_casal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_cama_ks = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_cama_solteiro = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgv_itens = New System.Windows.Forms.DataGridView()
        Me.cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.desc_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qtde = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_andar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.txt_numero = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Camas.SuspendLayout()
        CType(Me.dgv_itens, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 54)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(947, 574)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.btn_cadastrar)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.cmb_status)
        Me.TabPage1.Controls.Add(Me.cmb_categoria)
        Me.TabPage1.Controls.Add(Me.Camas)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.dgv_itens)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txt_andar)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.btn_buscar)
        Me.TabPage1.Controls.Add(Me.txt_numero)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(939, 548)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Consultar Quarto"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(189, 436)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 30)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Excluir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btn_cadastrar
        '
        Me.btn_cadastrar.Location = New System.Drawing.Point(275, 436)
        Me.btn_cadastrar.Name = "btn_cadastrar"
        Me.btn_cadastrar.Size = New System.Drawing.Size(128, 30)
        Me.btn_cadastrar.TabIndex = 23
        Me.btn_cadastrar.Text = "Cadastrar/Atualizar"
        Me.btn_cadastrar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_consultar_cliente)
        Me.GroupBox1.Controls.Add(Me.txt_nome_cliente)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txt_acompanhantes)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txt_cod_cliente)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 294)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 119)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ocupantes"
        '
        'btn_consultar_cliente
        '
        Me.btn_consultar_cliente.Location = New System.Drawing.Point(310, 78)
        Me.btn_consultar_cliente.Name = "btn_consultar_cliente"
        Me.btn_consultar_cliente.Size = New System.Drawing.Size(80, 30)
        Me.btn_consultar_cliente.TabIndex = 23
        Me.btn_consultar_cliente.Text = "Consultar"
        Me.btn_consultar_cliente.UseVisualStyleBackColor = True
        '
        'txt_nome_cliente
        '
        Me.txt_nome_cliente.Enabled = False
        Me.txt_nome_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome_cliente.Location = New System.Drawing.Point(80, 46)
        Me.txt_nome_cliente.Name = "txt_nome_cliente"
        Me.txt_nome_cliente.Size = New System.Drawing.Size(310, 26)
        Me.txt_nome_cliente.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(9, 49)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 20)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Nome"
        '
        'txt_acompanhantes
        '
        Me.txt_acompanhantes.Enabled = False
        Me.txt_acompanhantes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_acompanhantes.Location = New System.Drawing.Point(304, 14)
        Me.txt_acompanhantes.Name = "txt_acompanhantes"
        Me.txt_acompanhantes.Size = New System.Drawing.Size(86, 26)
        Me.txt_acompanhantes.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(172, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(126, 20)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Acompanhantes"
        '
        'txt_cod_cliente
        '
        Me.txt_cod_cliente.Enabled = False
        Me.txt_cod_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cod_cliente.Location = New System.Drawing.Point(80, 14)
        Me.txt_cod_cliente.Name = "txt_cod_cliente"
        Me.txt_cod_cliente.Size = New System.Drawing.Size(86, 26)
        Me.txt_cod_cliente.TabIndex = 16
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(9, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 20)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Código"
        '
        'cmb_status
        '
        Me.cmb_status.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_status.FormattingEnabled = True
        Me.cmb_status.Location = New System.Drawing.Point(93, 121)
        Me.cmb_status.Name = "cmb_status"
        Me.cmb_status.Size = New System.Drawing.Size(238, 28)
        Me.cmb_status.TabIndex = 17
        '
        'cmb_categoria
        '
        Me.cmb_categoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_categoria.FormattingEnabled = True
        Me.cmb_categoria.Location = New System.Drawing.Point(93, 89)
        Me.cmb_categoria.Name = "cmb_categoria"
        Me.cmb_categoria.Size = New System.Drawing.Size(238, 28)
        Me.cmb_categoria.TabIndex = 16
        '
        'Camas
        '
        Me.Camas.Controls.Add(Me.txt_cama_casal)
        Me.Camas.Controls.Add(Me.Label8)
        Me.Camas.Controls.Add(Me.txt_cama_ks)
        Me.Camas.Controls.Add(Me.Label7)
        Me.Camas.Controls.Add(Me.txt_cama_solteiro)
        Me.Camas.Controls.Add(Me.Label6)
        Me.Camas.Location = New System.Drawing.Point(13, 169)
        Me.Camas.Name = "Camas"
        Me.Camas.Size = New System.Drawing.Size(318, 119)
        Me.Camas.TabIndex = 15
        Me.Camas.TabStop = False
        Me.Camas.Text = "Camas"
        '
        'txt_cama_casal
        '
        Me.txt_cama_casal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cama_casal.Location = New System.Drawing.Point(80, 46)
        Me.txt_cama_casal.Name = "txt_cama_casal"
        Me.txt_cama_casal.Size = New System.Drawing.Size(86, 26)
        Me.txt_cama_casal.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 20)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Casal"
        '
        'txt_cama_ks
        '
        Me.txt_cama_ks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cama_ks.Location = New System.Drawing.Point(80, 78)
        Me.txt_cama_ks.Name = "txt_cama_ks"
        Me.txt_cama_ks.Size = New System.Drawing.Size(86, 26)
        Me.txt_cama_ks.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 20)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Kingsize"
        '
        'txt_cama_solteiro
        '
        Me.txt_cama_solteiro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cama_solteiro.Location = New System.Drawing.Point(80, 14)
        Me.txt_cama_solteiro.Name = "txt_cama_solteiro"
        Me.txt_cama_solteiro.Size = New System.Drawing.Size(86, 26)
        Me.txt_cama_solteiro.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 20)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Solteiro"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(421, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Itens"
        '
        'dgv_itens
        '
        Me.dgv_itens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_itens.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cod, Me.desc_item, Me.qtde})
        Me.dgv_itens.Location = New System.Drawing.Point(425, 34)
        Me.dgv_itens.Name = "dgv_itens"
        Me.dgv_itens.Size = New System.Drawing.Size(451, 254)
        Me.dgv_itens.TabIndex = 13
        '
        'cod
        '
        Me.cod.HeaderText = "código"
        Me.cod.Name = "cod"
        '
        'desc_item
        '
        Me.desc_item.HeaderText = "descrição"
        Me.desc_item.Name = "desc_item"
        Me.desc_item.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.desc_item.Width = 200
        '
        'qtde
        '
        Me.qtde.HeaderText = "quantidade"
        Me.qtde.Name = "qtde"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Status"
        '
        'txt_andar
        '
        Me.txt_andar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_andar.Location = New System.Drawing.Point(80, 40)
        Me.txt_andar.Name = "txt_andar"
        Me.txt_andar.Size = New System.Drawing.Size(86, 26)
        Me.txt_andar.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Andar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Categoria"
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(174, 6)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(80, 30)
        Me.btn_buscar.TabIndex = 6
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'txt_numero
        '
        Me.txt_numero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_numero.Location = New System.Drawing.Point(80, 8)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(86, 26)
        Me.txt_numero.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Número"
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(939, 548)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Cadastrar Quartos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(939, 548)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Administrar Quartos"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'frm_quartos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(963, 640)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frm_quartos"
        Me.Text = "frm_quartos"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Camas.ResumeLayout(False)
        Me.Camas.PerformLayout()
        CType(Me.dgv_itens, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgv_itens As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_andar As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_buscar As Button
    Friend WithEvents txt_numero As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Camas As GroupBox
    Friend WithEvents txt_cama_solteiro As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_cama_casal As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_cama_ks As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmb_status As ComboBox
    Friend WithEvents cmb_categoria As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_nome_cliente As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_acompanhantes As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_cod_cliente As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cod As DataGridViewTextBoxColumn
    Friend WithEvents desc_item As DataGridViewTextBoxColumn
    Friend WithEvents qtde As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents btn_cadastrar As Button
    Friend WithEvents btn_consultar_cliente As Button
End Class
