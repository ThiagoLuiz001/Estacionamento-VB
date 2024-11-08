<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaCliente
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultaCliente))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GradeCliente = New System.Windows.Forms.DataGridView()
        Me.Cl_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cl_Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cl_CPF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cl_Celular = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cl_CEP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cl_Criacao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cl_Ativo = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Cl_Alterar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GbPesquisa = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LblDescricao = New System.Windows.Forms.Label()
        Me.MskCPF = New System.Windows.Forms.MaskedTextBox()
        Me.MskData = New System.Windows.Forms.MaskedTextBox()
        Me.RbAtivo = New System.Windows.Forms.RadioButton()
        Me.RbCriacao = New System.Windows.Forms.RadioButton()
        Me.RbCPF = New System.Windows.Forms.RadioButton()
        Me.BtnGerar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GradeCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbPesquisa.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.GradeCliente)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 133)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(618, 305)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GradeCliente
        '
        Me.GradeCliente.AllowUserToAddRows = False
        Me.GradeCliente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GradeCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GradeCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cl_ID, Me.Cl_Cliente, Me.Cl_CPF, Me.Cl_Celular, Me.Cl_CEP, Me.Cl_Criacao, Me.Cl_Ativo, Me.Cl_Alterar})
        Me.GradeCliente.Location = New System.Drawing.Point(7, 20)
        Me.GradeCliente.Name = "GradeCliente"
        Me.GradeCliente.Size = New System.Drawing.Size(605, 279)
        Me.GradeCliente.TabIndex = 0
        '
        'Cl_ID
        '
        Me.Cl_ID.HeaderText = "ID"
        Me.Cl_ID.Name = "Cl_ID"
        Me.Cl_ID.ReadOnly = True
        Me.Cl_ID.Width = 40
        '
        'Cl_Cliente
        '
        Me.Cl_Cliente.HeaderText = "Cliente"
        Me.Cl_Cliente.Name = "Cl_Cliente"
        Me.Cl_Cliente.ReadOnly = True
        Me.Cl_Cliente.Width = 140
        '
        'Cl_CPF
        '
        Me.Cl_CPF.HeaderText = "CPF"
        Me.Cl_CPF.Name = "Cl_CPF"
        Me.Cl_CPF.ReadOnly = True
        Me.Cl_CPF.Width = 60
        '
        'Cl_Celular
        '
        Me.Cl_Celular.HeaderText = "Celular"
        Me.Cl_Celular.Name = "Cl_Celular"
        Me.Cl_Celular.ReadOnly = True
        Me.Cl_Celular.Width = 60
        '
        'Cl_CEP
        '
        Me.Cl_CEP.HeaderText = "CEP"
        Me.Cl_CEP.Name = "Cl_CEP"
        Me.Cl_CEP.ReadOnly = True
        Me.Cl_CEP.Width = 60
        '
        'Cl_Criacao
        '
        Me.Cl_Criacao.HeaderText = "Criação"
        Me.Cl_Criacao.Name = "Cl_Criacao"
        Me.Cl_Criacao.ReadOnly = True
        Me.Cl_Criacao.Width = 60
        '
        'Cl_Ativo
        '
        Me.Cl_Ativo.HeaderText = "Ativo"
        Me.Cl_Ativo.Name = "Cl_Ativo"
        Me.Cl_Ativo.ReadOnly = True
        Me.Cl_Ativo.Width = 40
        '
        'Cl_Alterar
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGoldenrod
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.Cl_Alterar.DefaultCellStyle = DataGridViewCellStyle1
        Me.Cl_Alterar.HeaderText = "Alterar"
        Me.Cl_Alterar.Name = "Cl_Alterar"
        Me.Cl_Alterar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Cl_Alterar.Text = "&ALTERAR"
        '
        'GbPesquisa
        '
        Me.GbPesquisa.Controls.Add(Me.Button1)
        Me.GbPesquisa.Controls.Add(Me.LblDescricao)
        Me.GbPesquisa.Controls.Add(Me.MskCPF)
        Me.GbPesquisa.Controls.Add(Me.MskData)
        Me.GbPesquisa.Controls.Add(Me.RbAtivo)
        Me.GbPesquisa.Controls.Add(Me.RbCriacao)
        Me.GbPesquisa.Controls.Add(Me.RbCPF)
        Me.GbPesquisa.Location = New System.Drawing.Point(19, 13)
        Me.GbPesquisa.Name = "GbPesquisa"
        Me.GbPesquisa.Size = New System.Drawing.Size(232, 114)
        Me.GbPesquisa.TabIndex = 1
        Me.GbPesquisa.TabStop = False
        Me.GbPesquisa.Text = "Seleção de Pesquisa:"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(177, 57)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(38, 32)
        Me.Button1.TabIndex = 6
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LblDescricao
        '
        Me.LblDescricao.AutoSize = True
        Me.LblDescricao.Location = New System.Drawing.Point(4, 67)
        Me.LblDescricao.Name = "LblDescricao"
        Me.LblDescricao.Size = New System.Drawing.Size(55, 13)
        Me.LblDescricao.TabIndex = 5
        Me.LblDescricao.Text = "Descrição"
        '
        'MskCPF
        '
        Me.MskCPF.Location = New System.Drawing.Point(91, 64)
        Me.MskCPF.Mask = "000,000,000-00"
        Me.MskCPF.Name = "MskCPF"
        Me.MskCPF.Size = New System.Drawing.Size(80, 20)
        Me.MskCPF.TabIndex = 4
        '
        'MskData
        '
        Me.MskData.Location = New System.Drawing.Point(91, 64)
        Me.MskData.Mask = "00/00/0000"
        Me.MskData.Name = "MskData"
        Me.MskData.Size = New System.Drawing.Size(66, 20)
        Me.MskData.TabIndex = 3
        Me.MskData.ValidatingType = GetType(Date)
        '
        'RbAtivo
        '
        Me.RbAtivo.AutoSize = True
        Me.RbAtivo.Location = New System.Drawing.Point(166, 20)
        Me.RbAtivo.Name = "RbAtivo"
        Me.RbAtivo.Size = New System.Drawing.Size(49, 17)
        Me.RbAtivo.TabIndex = 2
        Me.RbAtivo.TabStop = True
        Me.RbAtivo.Text = "Ativo"
        Me.RbAtivo.UseVisualStyleBackColor = True
        '
        'RbCriacao
        '
        Me.RbCriacao.AutoSize = True
        Me.RbCriacao.Location = New System.Drawing.Point(58, 20)
        Me.RbCriacao.Name = "RbCriacao"
        Me.RbCriacao.Size = New System.Drawing.Size(102, 17)
        Me.RbCriacao.TabIndex = 1
        Me.RbCriacao.TabStop = True
        Me.RbCriacao.Text = "Data de Criação"
        Me.RbCriacao.UseVisualStyleBackColor = True
        '
        'RbCPF
        '
        Me.RbCPF.AutoSize = True
        Me.RbCPF.Location = New System.Drawing.Point(7, 20)
        Me.RbCPF.Name = "RbCPF"
        Me.RbCPF.Size = New System.Drawing.Size(45, 17)
        Me.RbCPF.TabIndex = 0
        Me.RbCPF.TabStop = True
        Me.RbCPF.Text = "CPF"
        Me.RbCPF.UseVisualStyleBackColor = True
        '
        'BtnGerar
        '
        Me.BtnGerar.Location = New System.Drawing.Point(257, 13)
        Me.BtnGerar.Name = "BtnGerar"
        Me.BtnGerar.Size = New System.Drawing.Size(75, 23)
        Me.BtnGerar.TabIndex = 7
        Me.BtnGerar.Text = "Pesquisa"
        Me.BtnGerar.UseVisualStyleBackColor = True
        '
        'ConsultaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 450)
        Me.Controls.Add(Me.BtnGerar)
        Me.Controls.Add(Me.GbPesquisa)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ConsultaCliente"
        Me.Text = "ConsultaCliente"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GradeCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbPesquisa.ResumeLayout(False)
        Me.GbPesquisa.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GradeCliente As DataGridView
    Friend WithEvents GbPesquisa As GroupBox
    Friend WithEvents Cl_ID As DataGridViewTextBoxColumn
    Friend WithEvents Cl_Cliente As DataGridViewTextBoxColumn
    Friend WithEvents Cl_CPF As DataGridViewTextBoxColumn
    Friend WithEvents Cl_Celular As DataGridViewTextBoxColumn
    Friend WithEvents Cl_CEP As DataGridViewTextBoxColumn
    Friend WithEvents Cl_Criacao As DataGridViewTextBoxColumn
    Friend WithEvents Cl_Ativo As DataGridViewCheckBoxColumn
    Friend WithEvents Cl_Alterar As DataGridViewButtonColumn
    Friend WithEvents MskData As MaskedTextBox
    Friend WithEvents RbAtivo As RadioButton
    Friend WithEvents RbCriacao As RadioButton
    Friend WithEvents RbCPF As RadioButton
    Friend WithEvents MskCPF As MaskedTextBox
    Friend WithEvents LblDescricao As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnGerar As System.Windows.Forms.Button
End Class
