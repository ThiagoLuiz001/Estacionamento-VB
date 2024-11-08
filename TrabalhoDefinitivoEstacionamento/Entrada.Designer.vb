<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Entrada
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Entrada))
        Me.MskDataTempo = New System.Windows.Forms.MaskedTextBox()
        Me.GBDadosdoVeiculo = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CBVaga = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LbCor = New System.Windows.Forms.Label()
        Me.TxtCor = New System.Windows.Forms.TextBox()
        Me.TxtModelo = New System.Windows.Forms.TextBox()
        Me.LbModelo = New System.Windows.Forms.Label()
        Me.GBTipodePlaca = New System.Windows.Forms.GroupBox()
        Me.TxtMercosul = New System.Windows.Forms.TextBox()
        Me.MskBrasil = New System.Windows.Forms.MaskedTextBox()
        Me.RbMercosul = New System.Windows.Forms.RadioButton()
        Me.RbBrasil = New System.Windows.Forms.RadioButton()
        Me.GbDadosDoCliente = New System.Windows.Forms.GroupBox()
        Me.LbCelular = New System.Windows.Forms.Label()
        Me.MskCelular = New System.Windows.Forms.MaskedTextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.LbEmail = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LbNasc = New System.Windows.Forms.Label()
        Me.TxtNome = New System.Windows.Forms.TextBox()
        Me.MskNasc = New System.Windows.Forms.MaskedTextBox()
        Me.LbNome = New System.Windows.Forms.Label()
        Me.MskCPFCLIENTE = New System.Windows.Forms.MaskedTextBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.LbCPF = New System.Windows.Forms.Label()
        Me.MskCPFCONSULTA = New System.Windows.Forms.MaskedTextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ChkStatus = New System.Windows.Forms.CheckBox()
        Me.GBDadosdoVeiculo.SuspendLayout()
        Me.GBTipodePlaca.SuspendLayout()
        Me.GbDadosDoCliente.SuspendLayout()
        Me.SuspendLayout()
        '
        'MskDataTempo
        '
        Me.MskDataTempo.Location = New System.Drawing.Point(316, 2)
        Me.MskDataTempo.Margin = New System.Windows.Forms.Padding(2)
        Me.MskDataTempo.Mask = "00/00/0000 90:00"
        Me.MskDataTempo.Name = "MskDataTempo"
        Me.MskDataTempo.Size = New System.Drawing.Size(96, 20)
        Me.MskDataTempo.TabIndex = 32
        Me.MskDataTempo.ValidatingType = GetType(Date)
        '
        'GBDadosdoVeiculo
        '
        Me.GBDadosdoVeiculo.Controls.Add(Me.Label2)
        Me.GBDadosdoVeiculo.Controls.Add(Me.CBVaga)
        Me.GBDadosdoVeiculo.Controls.Add(Me.Button1)
        Me.GBDadosdoVeiculo.Controls.Add(Me.LbCor)
        Me.GBDadosdoVeiculo.Controls.Add(Me.TxtCor)
        Me.GBDadosdoVeiculo.Controls.Add(Me.TxtModelo)
        Me.GBDadosdoVeiculo.Controls.Add(Me.LbModelo)
        Me.GBDadosdoVeiculo.Controls.Add(Me.GBTipodePlaca)
        Me.GBDadosdoVeiculo.Location = New System.Drawing.Point(14, 162)
        Me.GBDadosdoVeiculo.Margin = New System.Windows.Forms.Padding(2)
        Me.GBDadosdoVeiculo.Name = "GBDadosdoVeiculo"
        Me.GBDadosdoVeiculo.Padding = New System.Windows.Forms.Padding(2)
        Me.GBDadosdoVeiculo.Size = New System.Drawing.Size(398, 147)
        Me.GBDadosdoVeiculo.TabIndex = 31
        Me.GBDadosdoVeiculo.TabStop = False
        Me.GBDadosdoVeiculo.Text = "| Dados do veiculo |"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(251, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Vaga:"
        '
        'CBVaga
        '
        Me.CBVaga.FormattingEnabled = True
        Me.CBVaga.Location = New System.Drawing.Point(252, 81)
        Me.CBVaga.Name = "CBVaga"
        Me.CBVaga.Size = New System.Drawing.Size(58, 21)
        Me.CBVaga.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(302, 107)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 35)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "&SALVAR"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LbCor
        '
        Me.LbCor.AutoSize = True
        Me.LbCor.Location = New System.Drawing.Point(140, 65)
        Me.LbCor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LbCor.Name = "LbCor"
        Me.LbCor.Size = New System.Drawing.Size(26, 13)
        Me.LbCor.TabIndex = 4
        Me.LbCor.Text = "Cor:"
        '
        'TxtCor
        '
        Me.TxtCor.Location = New System.Drawing.Point(142, 81)
        Me.TxtCor.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtCor.Name = "TxtCor"
        Me.TxtCor.Size = New System.Drawing.Size(104, 20)
        Me.TxtCor.TabIndex = 3
        '
        'TxtModelo
        '
        Me.TxtModelo.Location = New System.Drawing.Point(142, 41)
        Me.TxtModelo.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtModelo.Name = "TxtModelo"
        Me.TxtModelo.Size = New System.Drawing.Size(244, 20)
        Me.TxtModelo.TabIndex = 2
        '
        'LbModelo
        '
        Me.LbModelo.AutoSize = True
        Me.LbModelo.Location = New System.Drawing.Point(140, 24)
        Me.LbModelo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LbModelo.Name = "LbModelo"
        Me.LbModelo.Size = New System.Drawing.Size(45, 13)
        Me.LbModelo.TabIndex = 1
        Me.LbModelo.Text = "Modelo:"
        '
        'GBTipodePlaca
        '
        Me.GBTipodePlaca.Controls.Add(Me.TxtMercosul)
        Me.GBTipodePlaca.Controls.Add(Me.MskBrasil)
        Me.GBTipodePlaca.Controls.Add(Me.RbMercosul)
        Me.GBTipodePlaca.Controls.Add(Me.RbBrasil)
        Me.GBTipodePlaca.Location = New System.Drawing.Point(5, 24)
        Me.GBTipodePlaca.Margin = New System.Windows.Forms.Padding(2)
        Me.GBTipodePlaca.Name = "GBTipodePlaca"
        Me.GBTipodePlaca.Padding = New System.Windows.Forms.Padding(2)
        Me.GBTipodePlaca.Size = New System.Drawing.Size(123, 106)
        Me.GBTipodePlaca.TabIndex = 0
        Me.GBTipodePlaca.TabStop = False
        Me.GBTipodePlaca.Text = "| Tipo de Placa: |"
        '
        'TxtMercosul
        '
        Me.TxtMercosul.Location = New System.Drawing.Point(74, 34)
        Me.TxtMercosul.Name = "TxtMercosul"
        Me.TxtMercosul.Size = New System.Drawing.Size(45, 20)
        Me.TxtMercosul.TabIndex = 4
        '
        'MskBrasil
        '
        Me.MskBrasil.Location = New System.Drawing.Point(74, 35)
        Me.MskBrasil.Margin = New System.Windows.Forms.Padding(2)
        Me.MskBrasil.Mask = "aaa-0000"
        Me.MskBrasil.Name = "MskBrasil"
        Me.MskBrasil.Size = New System.Drawing.Size(45, 20)
        Me.MskBrasil.TabIndex = 3
        '
        'RbMercosul
        '
        Me.RbMercosul.AutoSize = True
        Me.RbMercosul.Location = New System.Drawing.Point(4, 57)
        Me.RbMercosul.Margin = New System.Windows.Forms.Padding(2)
        Me.RbMercosul.Name = "RbMercosul"
        Me.RbMercosul.Size = New System.Drawing.Size(68, 17)
        Me.RbMercosul.TabIndex = 1
        Me.RbMercosul.TabStop = True
        Me.RbMercosul.Text = "Mercosul"
        Me.RbMercosul.UseVisualStyleBackColor = True
        '
        'RbBrasil
        '
        Me.RbBrasil.AutoSize = True
        Me.RbBrasil.Location = New System.Drawing.Point(4, 35)
        Me.RbBrasil.Margin = New System.Windows.Forms.Padding(2)
        Me.RbBrasil.Name = "RbBrasil"
        Me.RbBrasil.Size = New System.Drawing.Size(50, 17)
        Me.RbBrasil.TabIndex = 0
        Me.RbBrasil.TabStop = True
        Me.RbBrasil.Text = "Brasil"
        Me.RbBrasil.UseVisualStyleBackColor = True
        '
        'GbDadosDoCliente
        '
        Me.GbDadosDoCliente.Controls.Add(Me.LbCelular)
        Me.GbDadosDoCliente.Controls.Add(Me.MskCelular)
        Me.GbDadosDoCliente.Controls.Add(Me.TxtEmail)
        Me.GbDadosDoCliente.Controls.Add(Me.LbEmail)
        Me.GbDadosDoCliente.Controls.Add(Me.Label1)
        Me.GbDadosDoCliente.Controls.Add(Me.LbNasc)
        Me.GbDadosDoCliente.Controls.Add(Me.TxtNome)
        Me.GbDadosDoCliente.Controls.Add(Me.MskNasc)
        Me.GbDadosDoCliente.Controls.Add(Me.LbNome)
        Me.GbDadosDoCliente.Controls.Add(Me.MskCPFCLIENTE)
        Me.GbDadosDoCliente.Location = New System.Drawing.Point(12, 49)
        Me.GbDadosDoCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.GbDadosDoCliente.Name = "GbDadosDoCliente"
        Me.GbDadosDoCliente.Padding = New System.Windows.Forms.Padding(2)
        Me.GbDadosDoCliente.Size = New System.Drawing.Size(399, 99)
        Me.GbDadosDoCliente.TabIndex = 30
        Me.GbDadosDoCliente.TabStop = False
        Me.GbDadosDoCliente.Text = "| Dados do Cliente |"
        '
        'LbCelular
        '
        Me.LbCelular.AutoSize = True
        Me.LbCelular.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCelular.Location = New System.Drawing.Point(250, 58)
        Me.LbCelular.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LbCelular.Name = "LbCelular"
        Me.LbCelular.Size = New System.Drawing.Size(42, 13)
        Me.LbCelular.TabIndex = 19
        Me.LbCelular.Text = "Celular:"
        '
        'MskCelular
        '
        Me.MskCelular.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskCelular.Location = New System.Drawing.Point(252, 75)
        Me.MskCelular.Margin = New System.Windows.Forms.Padding(2)
        Me.MskCelular.Mask = "(00) 00000-9999"
        Me.MskCelular.Name = "MskCelular"
        Me.MskCelular.Size = New System.Drawing.Size(80, 19)
        Me.MskCelular.TabIndex = 18
        '
        'TxtEmail
        '
        Me.TxtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmail.Location = New System.Drawing.Point(2, 75)
        Me.TxtEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(246, 19)
        Me.TxtEmail.TabIndex = 17
        '
        'LbEmail
        '
        Me.LbEmail.AutoSize = True
        Me.LbEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbEmail.Location = New System.Drawing.Point(5, 58)
        Me.LbEmail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LbEmail.Name = "LbEmail"
        Me.LbEmail.Size = New System.Drawing.Size(35, 13)
        Me.LbEmail.TabIndex = 16
        Me.LbEmail.Text = "Email:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(302, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "CPF:"
        '
        'LbNasc
        '
        Me.LbNasc.AutoSize = True
        Me.LbNasc.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNasc.Location = New System.Drawing.Point(323, 57)
        Me.LbNasc.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LbNasc.Name = "LbNasc"
        Me.LbNasc.Size = New System.Drawing.Size(66, 13)
        Me.LbNasc.TabIndex = 15
        Me.LbNasc.Text = "Nascimento:"
        '
        'TxtNome
        '
        Me.TxtNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNome.Location = New System.Drawing.Point(4, 37)
        Me.TxtNome.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNome.Name = "TxtNome"
        Me.TxtNome.Size = New System.Drawing.Size(288, 19)
        Me.TxtNome.TabIndex = 10
        '
        'MskNasc
        '
        Me.MskNasc.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskNasc.Location = New System.Drawing.Point(334, 75)
        Me.MskNasc.Margin = New System.Windows.Forms.Padding(2)
        Me.MskNasc.Mask = "00/00/0000"
        Me.MskNasc.Name = "MskNasc"
        Me.MskNasc.Size = New System.Drawing.Size(54, 19)
        Me.MskNasc.TabIndex = 14
        Me.MskNasc.ValidatingType = GetType(Date)
        '
        'LbNome
        '
        Me.LbNome.AutoSize = True
        Me.LbNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNome.Location = New System.Drawing.Point(5, 19)
        Me.LbNome.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LbNome.Name = "LbNome"
        Me.LbNome.Size = New System.Drawing.Size(38, 13)
        Me.LbNome.TabIndex = 11
        Me.LbNome.Text = "Nome:"
        '
        'MskCPFCLIENTE
        '
        Me.MskCPFCLIENTE.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskCPFCLIENTE.Location = New System.Drawing.Point(304, 36)
        Me.MskCPFCLIENTE.Margin = New System.Windows.Forms.Padding(2)
        Me.MskCPFCLIENTE.Mask = "000,000,000-00"
        Me.MskCPFCLIENTE.Name = "MskCPFCLIENTE"
        Me.MskCPFCLIENTE.Size = New System.Drawing.Size(85, 19)
        Me.MskCPFCLIENTE.TabIndex = 12
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackgroundImage = CType(resources.GetObject("BtnBuscar.BackgroundImage"), System.Drawing.Image)
        Me.BtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBuscar.Location = New System.Drawing.Point(95, 22)
        Me.BtnBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(29, 27)
        Me.BtnBuscar.TabIndex = 29
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'LbCPF
        '
        Me.LbCPF.AutoSize = True
        Me.LbCPF.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCPF.Location = New System.Drawing.Point(11, 9)
        Me.LbCPF.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LbCPF.Name = "LbCPF"
        Me.LbCPF.Size = New System.Drawing.Size(30, 13)
        Me.LbCPF.TabIndex = 28
        Me.LbCPF.Text = "CPF:"
        '
        'MskCPFCONSULTA
        '
        Me.MskCPFCONSULTA.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskCPFCONSULTA.Location = New System.Drawing.Point(11, 26)
        Me.MskCPFCONSULTA.Margin = New System.Windows.Forms.Padding(2)
        Me.MskCPFCONSULTA.Mask = "000,000,000-00"
        Me.MskCPFCONSULTA.Name = "MskCPFCONSULTA"
        Me.MskCPFCONSULTA.Size = New System.Drawing.Size(80, 19)
        Me.MskCPFCONSULTA.TabIndex = 27
        '
        'Timer1
        '
        '
        'ChkStatus
        '
        Me.ChkStatus.AutoSize = True
        Me.ChkStatus.Location = New System.Drawing.Point(216, 28)
        Me.ChkStatus.Name = "ChkStatus"
        Me.ChkStatus.Size = New System.Drawing.Size(56, 17)
        Me.ChkStatus.TabIndex = 33
        Me.ChkStatus.Text = "Status"
        Me.ChkStatus.UseVisualStyleBackColor = True
        '
        'Entrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 330)
        Me.Controls.Add(Me.ChkStatus)
        Me.Controls.Add(Me.MskDataTempo)
        Me.Controls.Add(Me.GBDadosdoVeiculo)
        Me.Controls.Add(Me.GbDadosDoCliente)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.LbCPF)
        Me.Controls.Add(Me.MskCPFCONSULTA)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Entrada"
        Me.Text = "Entrada"
        Me.GBDadosdoVeiculo.ResumeLayout(False)
        Me.GBDadosdoVeiculo.PerformLayout()
        Me.GBTipodePlaca.ResumeLayout(False)
        Me.GBTipodePlaca.PerformLayout()
        Me.GbDadosDoCliente.ResumeLayout(False)
        Me.GbDadosDoCliente.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MskDataTempo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GBDadosdoVeiculo As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LbCor As System.Windows.Forms.Label
    Friend WithEvents TxtCor As System.Windows.Forms.TextBox
    Friend WithEvents TxtModelo As System.Windows.Forms.TextBox
    Friend WithEvents LbModelo As System.Windows.Forms.Label
    Friend WithEvents GBTipodePlaca As System.Windows.Forms.GroupBox
    Friend WithEvents MskBrasil As System.Windows.Forms.MaskedTextBox
    Friend WithEvents RbMercosul As System.Windows.Forms.RadioButton
    Friend WithEvents RbBrasil As System.Windows.Forms.RadioButton
    Friend WithEvents GbDadosDoCliente As System.Windows.Forms.GroupBox
    Friend WithEvents LbCelular As System.Windows.Forms.Label
    Friend WithEvents MskCelular As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TxtEmail As System.Windows.Forms.TextBox
    Friend WithEvents LbEmail As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LbNasc As System.Windows.Forms.Label
    Friend WithEvents TxtNome As System.Windows.Forms.TextBox
    Friend WithEvents MskNasc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LbNome As System.Windows.Forms.Label
    Friend WithEvents MskCPFCLIENTE As System.Windows.Forms.MaskedTextBox
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents LbCPF As System.Windows.Forms.Label
    Friend WithEvents MskCPFCONSULTA As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TxtMercosul As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ChkStatus As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CBVaga As ComboBox
End Class
