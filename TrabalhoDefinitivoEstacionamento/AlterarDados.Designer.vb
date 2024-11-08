<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlterarDados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AlterarDados))
        Me.GBteste = New System.Windows.Forms.GroupBox()
        Me.ChkAtivo = New System.Windows.Forms.CheckBox()
        Me.BtnPesquisa = New System.Windows.Forms.Button()
        Me.TxtUF = New System.Windows.Forms.TextBox()
        Me.BtnAlterar = New System.Windows.Forms.Button()
        Me.LbBairro = New System.Windows.Forms.Label()
        Me.LbCompl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LbNumero = New System.Windows.Forms.Label()
        Me.TxtCompl = New System.Windows.Forms.TextBox()
        Me.TxtBairro = New System.Windows.Forms.TextBox()
        Me.TxtNumero = New System.Windows.Forms.TextBox()
        Me.TxtRua = New System.Windows.Forms.TextBox()
        Me.MskCEP = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LbUF = New System.Windows.Forms.Label()
        Me.LbCelular = New System.Windows.Forms.Label()
        Me.MskCelular = New System.Windows.Forms.MaskedTextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.LbEmail = New System.Windows.Forms.Label()
        Me.LbCPF = New System.Windows.Forms.Label()
        Me.LbNasc = New System.Windows.Forms.Label()
        Me.TxtNome = New System.Windows.Forms.TextBox()
        Me.MskNasc = New System.Windows.Forms.MaskedTextBox()
        Me.LbNome = New System.Windows.Forms.Label()
        Me.MskCPF = New System.Windows.Forms.MaskedTextBox()
        Me.GBteste.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBteste
        '
        Me.GBteste.Controls.Add(Me.ChkAtivo)
        Me.GBteste.Controls.Add(Me.BtnPesquisa)
        Me.GBteste.Controls.Add(Me.TxtUF)
        Me.GBteste.Controls.Add(Me.BtnAlterar)
        Me.GBteste.Controls.Add(Me.LbBairro)
        Me.GBteste.Controls.Add(Me.LbCompl)
        Me.GBteste.Controls.Add(Me.Label1)
        Me.GBteste.Controls.Add(Me.LbNumero)
        Me.GBteste.Controls.Add(Me.TxtCompl)
        Me.GBteste.Controls.Add(Me.TxtBairro)
        Me.GBteste.Controls.Add(Me.TxtNumero)
        Me.GBteste.Controls.Add(Me.TxtRua)
        Me.GBteste.Controls.Add(Me.MskCEP)
        Me.GBteste.Controls.Add(Me.Label2)
        Me.GBteste.Controls.Add(Me.LbUF)
        Me.GBteste.Controls.Add(Me.LbCelular)
        Me.GBteste.Controls.Add(Me.MskCelular)
        Me.GBteste.Controls.Add(Me.TxtEmail)
        Me.GBteste.Controls.Add(Me.LbEmail)
        Me.GBteste.Controls.Add(Me.LbCPF)
        Me.GBteste.Controls.Add(Me.LbNasc)
        Me.GBteste.Controls.Add(Me.TxtNome)
        Me.GBteste.Controls.Add(Me.MskNasc)
        Me.GBteste.Controls.Add(Me.LbNome)
        Me.GBteste.Controls.Add(Me.MskCPF)
        Me.GBteste.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBteste.Location = New System.Drawing.Point(12, 12)
        Me.GBteste.Name = "GBteste"
        Me.GBteste.Size = New System.Drawing.Size(537, 265)
        Me.GBteste.TabIndex = 8
        Me.GBteste.TabStop = False
        Me.GBteste.Text = "Alterar Dados do Cliente:"
        '
        'ChkAtivo
        '
        Me.ChkAtivo.AutoSize = True
        Me.ChkAtivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkAtivo.Location = New System.Drawing.Point(6, 230)
        Me.ChkAtivo.Name = "ChkAtivo"
        Me.ChkAtivo.Size = New System.Drawing.Size(50, 17)
        Me.ChkAtivo.TabIndex = 23
        Me.ChkAtivo.Text = "Ativo"
        Me.ChkAtivo.UseVisualStyleBackColor = True
        '
        'BtnPesquisa
        '
        Me.BtnPesquisa.BackgroundImage = CType(resources.GetObject("BtnPesquisa.BackgroundImage"), System.Drawing.Image)
        Me.BtnPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPesquisa.Location = New System.Drawing.Point(81, 147)
        Me.BtnPesquisa.Name = "BtnPesquisa"
        Me.BtnPesquisa.Size = New System.Drawing.Size(34, 27)
        Me.BtnPesquisa.TabIndex = 6
        Me.BtnPesquisa.UseVisualStyleBackColor = True
        '
        'TxtUF
        '
        Me.TxtUF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUF.Location = New System.Drawing.Point(127, 151)
        Me.TxtUF.Name = "TxtUF"
        Me.TxtUF.Size = New System.Drawing.Size(37, 20)
        Me.TxtUF.TabIndex = 7
        '
        'BtnAlterar
        '
        Me.BtnAlterar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAlterar.Image = CType(resources.GetObject("BtnAlterar.Image"), System.Drawing.Image)
        Me.BtnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAlterar.Location = New System.Drawing.Point(423, 218)
        Me.BtnAlterar.Name = "BtnAlterar"
        Me.BtnAlterar.Size = New System.Drawing.Size(94, 38)
        Me.BtnAlterar.TabIndex = 12
        Me.BtnAlterar.Text = "&ALTERAR"
        Me.BtnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAlterar.UseVisualStyleBackColor = True
        '
        'LbBairro
        '
        Me.LbBairro.AutoSize = True
        Me.LbBairro.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbBairro.Location = New System.Drawing.Point(67, 177)
        Me.LbBairro.Name = "LbBairro"
        Me.LbBairro.Size = New System.Drawing.Size(37, 13)
        Me.LbBairro.TabIndex = 21
        Me.LbBairro.Text = "Bairro:"
        '
        'LbCompl
        '
        Me.LbCompl.AutoSize = True
        Me.LbCompl.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCompl.Location = New System.Drawing.Point(323, 173)
        Me.LbCompl.Name = "LbCompl"
        Me.LbCompl.Size = New System.Drawing.Size(74, 13)
        Me.LbCompl.TabIndex = 20
        Me.LbCompl.Text = "Complemento:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(167, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Rua:"
        '
        'LbNumero
        '
        Me.LbNumero.AutoSize = True
        Me.LbNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNumero.Location = New System.Drawing.Point(3, 177)
        Me.LbNumero.Name = "LbNumero"
        Me.LbNumero.Size = New System.Drawing.Size(47, 13)
        Me.LbNumero.TabIndex = 18
        Me.LbNumero.Text = "Número:"
        '
        'TxtCompl
        '
        Me.TxtCompl.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCompl.Location = New System.Drawing.Point(326, 193)
        Me.TxtCompl.Name = "TxtCompl"
        Me.TxtCompl.Size = New System.Drawing.Size(191, 19)
        Me.TxtCompl.TabIndex = 11
        '
        'TxtBairro
        '
        Me.TxtBairro.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBairro.Location = New System.Drawing.Point(70, 193)
        Me.TxtBairro.Name = "TxtBairro"
        Me.TxtBairro.Size = New System.Drawing.Size(250, 19)
        Me.TxtBairro.TabIndex = 10
        '
        'TxtNumero
        '
        Me.TxtNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumero.Location = New System.Drawing.Point(3, 193)
        Me.TxtNumero.Name = "TxtNumero"
        Me.TxtNumero.Size = New System.Drawing.Size(61, 19)
        Me.TxtNumero.TabIndex = 9
        '
        'TxtRua
        '
        Me.TxtRua.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRua.Location = New System.Drawing.Point(170, 151)
        Me.TxtRua.Name = "TxtRua"
        Me.TxtRua.Size = New System.Drawing.Size(347, 19)
        Me.TxtRua.TabIndex = 8
        '
        'MskCEP
        '
        Me.MskCEP.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskCEP.Location = New System.Drawing.Point(6, 151)
        Me.MskCEP.Mask = "00000-000"
        Me.MskCEP.Name = "MskCEP"
        Me.MskCEP.Size = New System.Drawing.Size(69, 19)
        Me.MskCEP.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "(CEP):"
        '
        'LbUF
        '
        Me.LbUF.AutoSize = True
        Me.LbUF.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbUF.Location = New System.Drawing.Point(124, 128)
        Me.LbUF.Name = "LbUF"
        Me.LbUF.Size = New System.Drawing.Size(24, 13)
        Me.LbUF.TabIndex = 10
        Me.LbUF.Text = "UF:"
        '
        'LbCelular
        '
        Me.LbCelular.AutoSize = True
        Me.LbCelular.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCelular.Location = New System.Drawing.Point(333, 79)
        Me.LbCelular.Name = "LbCelular"
        Me.LbCelular.Size = New System.Drawing.Size(42, 13)
        Me.LbCelular.TabIndex = 9
        Me.LbCelular.Text = "Celular:"
        '
        'MskCelular
        '
        Me.MskCelular.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskCelular.Location = New System.Drawing.Point(336, 100)
        Me.MskCelular.Mask = "(00) 00000-9999"
        Me.MskCelular.Name = "MskCelular"
        Me.MskCelular.Size = New System.Drawing.Size(105, 19)
        Me.MskCelular.TabIndex = 3
        '
        'TxtEmail
        '
        Me.TxtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmail.Location = New System.Drawing.Point(3, 100)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(327, 19)
        Me.TxtEmail.TabIndex = 2
        '
        'LbEmail
        '
        Me.LbEmail.AutoSize = True
        Me.LbEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbEmail.Location = New System.Drawing.Point(7, 79)
        Me.LbEmail.Name = "LbEmail"
        Me.LbEmail.Size = New System.Drawing.Size(35, 13)
        Me.LbEmail.TabIndex = 6
        Me.LbEmail.Text = "Email:"
        '
        'LbCPF
        '
        Me.LbCPF.AutoSize = True
        Me.LbCPF.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCPF.Location = New System.Drawing.Point(420, 31)
        Me.LbCPF.Name = "LbCPF"
        Me.LbCPF.Size = New System.Drawing.Size(30, 13)
        Me.LbCPF.TabIndex = 3
        Me.LbCPF.Text = "CPF:"
        '
        'LbNasc
        '
        Me.LbNasc.AutoSize = True
        Me.LbNasc.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNasc.Location = New System.Drawing.Point(443, 79)
        Me.LbNasc.Name = "LbNasc"
        Me.LbNasc.Size = New System.Drawing.Size(66, 13)
        Me.LbNasc.TabIndex = 5
        Me.LbNasc.Text = "Nascimento:"
        '
        'TxtNome
        '
        Me.TxtNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNome.Location = New System.Drawing.Point(6, 53)
        Me.TxtNome.Name = "TxtNome"
        Me.TxtNome.Size = New System.Drawing.Size(410, 19)
        Me.TxtNome.TabIndex = 0
        '
        'MskNasc
        '
        Me.MskNasc.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskNasc.Location = New System.Drawing.Point(446, 100)
        Me.MskNasc.Mask = "00/00/0000"
        Me.MskNasc.Name = "MskNasc"
        Me.MskNasc.Size = New System.Drawing.Size(71, 19)
        Me.MskNasc.TabIndex = 4
        Me.MskNasc.ValidatingType = GetType(Date)
        '
        'LbNome
        '
        Me.LbNome.AutoSize = True
        Me.LbNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNome.Location = New System.Drawing.Point(7, 31)
        Me.LbNome.Name = "LbNome"
        Me.LbNome.Size = New System.Drawing.Size(38, 13)
        Me.LbNome.TabIndex = 1
        Me.LbNome.Text = "Nome:"
        '
        'MskCPF
        '
        Me.MskCPF.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskCPF.Location = New System.Drawing.Point(423, 52)
        Me.MskCPF.Mask = "000,000,000-00"
        Me.MskCPF.Name = "MskCPF"
        Me.MskCPF.Size = New System.Drawing.Size(94, 19)
        Me.MskCPF.TabIndex = 1
        '
        'AlterarDados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 281)
        Me.Controls.Add(Me.GBteste)
        Me.Name = "AlterarDados"
        Me.Text = "AlterarDados"
        Me.GBteste.ResumeLayout(False)
        Me.GBteste.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GBteste As System.Windows.Forms.GroupBox
    Friend WithEvents BtnPesquisa As System.Windows.Forms.Button
    Friend WithEvents TxtUF As System.Windows.Forms.TextBox
    Friend WithEvents BtnAlterar As System.Windows.Forms.Button
    Friend WithEvents LbBairro As System.Windows.Forms.Label
    Friend WithEvents LbCompl As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LbNumero As System.Windows.Forms.Label
    Friend WithEvents TxtCompl As System.Windows.Forms.TextBox
    Friend WithEvents TxtBairro As System.Windows.Forms.TextBox
    Friend WithEvents TxtNumero As System.Windows.Forms.TextBox
    Friend WithEvents TxtRua As System.Windows.Forms.TextBox
    Friend WithEvents MskCEP As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LbUF As System.Windows.Forms.Label
    Friend WithEvents LbCelular As System.Windows.Forms.Label
    Friend WithEvents MskCelular As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TxtEmail As System.Windows.Forms.TextBox
    Friend WithEvents LbEmail As System.Windows.Forms.Label
    Friend WithEvents LbCPF As System.Windows.Forms.Label
    Friend WithEvents LbNasc As System.Windows.Forms.Label
    Friend WithEvents TxtNome As System.Windows.Forms.TextBox
    Friend WithEvents MskNasc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LbNome As System.Windows.Forms.Label
    Friend WithEvents MskCPF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ChkAtivo As System.Windows.Forms.CheckBox
End Class
