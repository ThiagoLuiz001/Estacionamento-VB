<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MdiMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MdiMenu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CadastroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstacionamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntradaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarVagasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroToolStripMenuItem, Me.EstacionamentoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(584, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CadastroToolStripMenuItem
        '
        Me.CadastroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClienteToolStripMenuItem, Me.ConsultaToolStripMenuItem})
        Me.CadastroToolStripMenuItem.Name = "CadastroToolStripMenuItem"
        Me.CadastroToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.CadastroToolStripMenuItem.Text = "&Cadastro"
        '
        'ClienteToolStripMenuItem
        '
        Me.ClienteToolStripMenuItem.Image = CType(resources.GetObject("ClienteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ClienteToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ClienteToolStripMenuItem.Text = "Cliente"
        '
        'ConsultaToolStripMenuItem
        '
        Me.ConsultaToolStripMenuItem.Name = "ConsultaToolStripMenuItem"
        Me.ConsultaToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ConsultaToolStripMenuItem.Text = "Consultar"
        '
        'EstacionamentoToolStripMenuItem
        '
        Me.EstacionamentoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EntradaToolStripMenuItem, Me.ConsultarVagasToolStripMenuItem, Me.SaidaToolStripMenuItem})
        Me.EstacionamentoToolStripMenuItem.Name = "EstacionamentoToolStripMenuItem"
        Me.EstacionamentoToolStripMenuItem.Size = New System.Drawing.Size(104, 20)
        Me.EstacionamentoToolStripMenuItem.Text = "&Estacionamento"
        '
        'EntradaToolStripMenuItem
        '
        Me.EntradaToolStripMenuItem.Image = CType(resources.GetObject("EntradaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EntradaToolStripMenuItem.Name = "EntradaToolStripMenuItem"
        Me.EntradaToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.EntradaToolStripMenuItem.Text = "Entrada"
        '
        'ConsultarVagasToolStripMenuItem
        '
        Me.ConsultarVagasToolStripMenuItem.Name = "ConsultarVagasToolStripMenuItem"
        Me.ConsultarVagasToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.ConsultarVagasToolStripMenuItem.Text = "Consultar Vagas"
        '
        'SaidaToolStripMenuItem
        '
        Me.SaidaToolStripMenuItem.Name = "SaidaToolStripMenuItem"
        Me.SaidaToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.SaidaToolStripMenuItem.Text = "Saida"
        '
        'MdiMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 400)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MdiMenu"
        Me.Text = "Menu Estacionamento"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CadastroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstacionamentoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EntradaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarVagasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaidaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
