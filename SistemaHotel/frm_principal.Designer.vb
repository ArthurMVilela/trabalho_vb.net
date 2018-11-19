<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_principal
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
        Me.barra_status = New System.Windows.Forms.StatusStrip()
        Me.lbl_usuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArquivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_btn_sair = New System.Windows.Forms.ToolStripMenuItem()
        Me.AtendimentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReservasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckinCheckoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuartosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_btn_gerenciar_quarto = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatóriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.barra_status.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'barra_status
        '
        Me.barra_status.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbl_usuario})
        Me.barra_status.Location = New System.Drawing.Point(0, 428)
        Me.barra_status.Name = "barra_status"
        Me.barra_status.Size = New System.Drawing.Size(800, 22)
        Me.barra_status.TabIndex = 0
        Me.barra_status.Text = "StatusStrip1"
        '
        'lbl_usuario
        '
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(127, 17)
        Me.lbl_usuario.Text = "USUÁRIO: Não Logado"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArquivoToolStripMenuItem, Me.AtendimentoToolStripMenuItem, Me.QuartosToolStripMenuItem, Me.RelatóriosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArquivoToolStripMenuItem
        '
        Me.ArquivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_btn_sair})
        Me.ArquivoToolStripMenuItem.Name = "ArquivoToolStripMenuItem"
        Me.ArquivoToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ArquivoToolStripMenuItem.Text = "Aplicação"
        '
        'menu_btn_sair
        '
        Me.menu_btn_sair.Name = "menu_btn_sair"
        Me.menu_btn_sair.Size = New System.Drawing.Size(180, 22)
        Me.menu_btn_sair.Text = "Sair"
        '
        'AtendimentoToolStripMenuItem
        '
        Me.AtendimentoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReservasToolStripMenuItem, Me.CheckinCheckoutToolStripMenuItem})
        Me.AtendimentoToolStripMenuItem.Name = "AtendimentoToolStripMenuItem"
        Me.AtendimentoToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.AtendimentoToolStripMenuItem.Text = "Atendimento"
        '
        'ReservasToolStripMenuItem
        '
        Me.ReservasToolStripMenuItem.Name = "ReservasToolStripMenuItem"
        Me.ReservasToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.ReservasToolStripMenuItem.Text = "Reservas"
        '
        'CheckinCheckoutToolStripMenuItem
        '
        Me.CheckinCheckoutToolStripMenuItem.Name = "CheckinCheckoutToolStripMenuItem"
        Me.CheckinCheckoutToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.CheckinCheckoutToolStripMenuItem.Text = "Check-in/Check-out"
        '
        'QuartosToolStripMenuItem
        '
        Me.QuartosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_btn_gerenciar_quarto})
        Me.QuartosToolStripMenuItem.Name = "QuartosToolStripMenuItem"
        Me.QuartosToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.QuartosToolStripMenuItem.Text = "Quartos"
        '
        'menu_btn_gerenciar_quarto
        '
        Me.menu_btn_gerenciar_quarto.Name = "menu_btn_gerenciar_quarto"
        Me.menu_btn_gerenciar_quarto.Size = New System.Drawing.Size(180, 22)
        Me.menu_btn_gerenciar_quarto.Text = "Gerenciar Quartos"
        '
        'RelatóriosToolStripMenuItem
        '
        Me.RelatóriosToolStripMenuItem.Name = "RelatóriosToolStripMenuItem"
        Me.RelatóriosToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.RelatóriosToolStripMenuItem.Text = "Relatórios"
        '
        'frm_principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.barra_status)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Sistema Hotel"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.barra_status.ResumeLayout(False)
        Me.barra_status.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents barra_status As StatusStrip
    Friend WithEvents lbl_usuario As ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArquivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menu_btn_sair As ToolStripMenuItem
    Friend WithEvents AtendimentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReservasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckinCheckoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuartosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menu_btn_gerenciar_quarto As ToolStripMenuItem
    Friend WithEvents RelatóriosToolStripMenuItem As ToolStripMenuItem
End Class
