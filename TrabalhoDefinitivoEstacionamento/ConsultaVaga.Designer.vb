<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaVaga
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
        Me.GbGrade = New System.Windows.Forms.GroupBox()
        Me.GradeVaga = New System.Windows.Forms.DataGridView()
        Me.RbVaga = New System.Windows.Forms.RadioButton()
        Me.RbAndar = New System.Windows.Forms.RadioButton()
        Me.RbDisponivel = New System.Windows.Forms.RadioButton()
        Me.LblDescricao = New System.Windows.Forms.Label()
        Me.MskAndar = New System.Windows.Forms.MaskedTextBox()
        Me.LblAndar = New System.Windows.Forms.Label()
        Me.BtnPesquisar = New System.Windows.Forms.Button()
        Me.ClVaga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClAndar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClDisponivel = New System.Windows.Forms.DataGridViewImageColumn()
        Me.GbPesquisa = New System.Windows.Forms.GroupBox()
        Me.Txtvaga = New System.Windows.Forms.TextBox()
        Me.GbGrade.SuspendLayout()
        CType(Me.GradeVaga, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbPesquisa.SuspendLayout()
        Me.SuspendLayout()
        '
        'GbGrade
        '
        Me.GbGrade.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GbGrade.Controls.Add(Me.GradeVaga)
        Me.GbGrade.Location = New System.Drawing.Point(2, 98)
        Me.GbGrade.Name = "GbGrade"
        Me.GbGrade.Size = New System.Drawing.Size(382, 216)
        Me.GbGrade.TabIndex = 0
        Me.GbGrade.TabStop = False
        '
        'GradeVaga
        '
        Me.GradeVaga.AllowUserToAddRows = False
        Me.GradeVaga.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GradeVaga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GradeVaga.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClVaga, Me.ClAndar, Me.ClDisponivel})
        Me.GradeVaga.Location = New System.Drawing.Point(6, 14)
        Me.GradeVaga.Name = "GradeVaga"
        Me.GradeVaga.Size = New System.Drawing.Size(370, 196)
        Me.GradeVaga.TabIndex = 0
        '
        'RbVaga
        '
        Me.RbVaga.AutoSize = True
        Me.RbVaga.Location = New System.Drawing.Point(3, 31)
        Me.RbVaga.Name = "RbVaga"
        Me.RbVaga.Size = New System.Drawing.Size(50, 17)
        Me.RbVaga.TabIndex = 1
        Me.RbVaga.TabStop = True
        Me.RbVaga.Text = "Vaga"
        Me.RbVaga.UseVisualStyleBackColor = True
        '
        'RbAndar
        '
        Me.RbAndar.AutoSize = True
        Me.RbAndar.Location = New System.Drawing.Point(59, 31)
        Me.RbAndar.Name = "RbAndar"
        Me.RbAndar.Size = New System.Drawing.Size(53, 17)
        Me.RbAndar.TabIndex = 2
        Me.RbAndar.TabStop = True
        Me.RbAndar.Text = "Andar"
        Me.RbAndar.UseVisualStyleBackColor = True
        '
        'RbDisponivel
        '
        Me.RbDisponivel.AutoSize = True
        Me.RbDisponivel.Location = New System.Drawing.Point(118, 30)
        Me.RbDisponivel.Name = "RbDisponivel"
        Me.RbDisponivel.Size = New System.Drawing.Size(96, 17)
        Me.RbDisponivel.TabIndex = 3
        Me.RbDisponivel.TabStop = True
        Me.RbDisponivel.Text = "Disponibilidade"
        Me.RbDisponivel.UseVisualStyleBackColor = True
        '
        'LblDescricao
        '
        Me.LblDescricao.AutoSize = True
        Me.LblDescricao.Location = New System.Drawing.Point(9, 76)
        Me.LblDescricao.Name = "LblDescricao"
        Me.LblDescricao.Size = New System.Drawing.Size(35, 13)
        Me.LblDescricao.TabIndex = 5
        Me.LblDescricao.Text = "Vaga:"
        '
        'MskAndar
        '
        Me.MskAndar.Location = New System.Drawing.Point(143, 73)
        Me.MskAndar.Mask = "0°"
        Me.MskAndar.Name = "MskAndar"
        Me.MskAndar.Size = New System.Drawing.Size(22, 20)
        Me.MskAndar.TabIndex = 6
        '
        'LblAndar
        '
        Me.LblAndar.AutoSize = True
        Me.LblAndar.Location = New System.Drawing.Point(99, 76)
        Me.LblAndar.Name = "LblAndar"
        Me.LblAndar.Size = New System.Drawing.Size(38, 13)
        Me.LblAndar.TabIndex = 7
        Me.LblAndar.Text = "Andar:"
        '
        'BtnPesquisar
        '
        Me.BtnPesquisar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPesquisar.Location = New System.Drawing.Point(303, 76)
        Me.BtnPesquisar.Name = "BtnPesquisar"
        Me.BtnPesquisar.Size = New System.Drawing.Size(75, 23)
        Me.BtnPesquisar.TabIndex = 9
        Me.BtnPesquisar.Text = "Pesquisa"
        Me.BtnPesquisar.UseVisualStyleBackColor = True
        '
        'ClVaga
        '
        Me.ClVaga.HeaderText = "Vaga"
        Me.ClVaga.Name = "ClVaga"
        Me.ClVaga.ReadOnly = True
        '
        'ClAndar
        '
        Me.ClAndar.HeaderText = "Andar"
        Me.ClAndar.Name = "ClAndar"
        Me.ClAndar.ReadOnly = True
        '
        'ClDisponivel
        '
        Me.ClDisponivel.HeaderText = "Disponibilidade"
        Me.ClDisponivel.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.ClDisponivel.Name = "ClDisponivel"
        Me.ClDisponivel.ReadOnly = True
        '
        'GbPesquisa
        '
        Me.GbPesquisa.Controls.Add(Me.Txtvaga)
        Me.GbPesquisa.Controls.Add(Me.RbVaga)
        Me.GbPesquisa.Controls.Add(Me.RbAndar)
        Me.GbPesquisa.Controls.Add(Me.LblAndar)
        Me.GbPesquisa.Controls.Add(Me.RbDisponivel)
        Me.GbPesquisa.Controls.Add(Me.MskAndar)
        Me.GbPesquisa.Controls.Add(Me.LblDescricao)
        Me.GbPesquisa.Location = New System.Drawing.Point(8, 6)
        Me.GbPesquisa.Name = "GbPesquisa"
        Me.GbPesquisa.Size = New System.Drawing.Size(218, 100)
        Me.GbPesquisa.TabIndex = 10
        Me.GbPesquisa.TabStop = False
        Me.GbPesquisa.Text = "Campo de Pesquisa"
        '
        'Txtvaga
        '
        Me.Txtvaga.Location = New System.Drawing.Point(50, 73)
        Me.Txtvaga.Name = "Txtvaga"
        Me.Txtvaga.Size = New System.Drawing.Size(42, 20)
        Me.Txtvaga.TabIndex = 8
        '
        'ConsultaVaga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 321)
        Me.Controls.Add(Me.GbPesquisa)
        Me.Controls.Add(Me.BtnPesquisar)
        Me.Controls.Add(Me.GbGrade)
        Me.MaximizeBox = False
        Me.Name = "ConsultaVaga"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ConsultaVaga"
        Me.GbGrade.ResumeLayout(False)
        CType(Me.GradeVaga, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbPesquisa.ResumeLayout(False)
        Me.GbPesquisa.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GbGrade As System.Windows.Forms.GroupBox
    Friend WithEvents GradeVaga As System.Windows.Forms.DataGridView
    Friend WithEvents RbVaga As System.Windows.Forms.RadioButton
    Friend WithEvents RbAndar As System.Windows.Forms.RadioButton
    Friend WithEvents RbDisponivel As System.Windows.Forms.RadioButton
    Friend WithEvents LblDescricao As System.Windows.Forms.Label
    Friend WithEvents MskAndar As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LblAndar As System.Windows.Forms.Label
    Friend WithEvents BtnPesquisar As System.Windows.Forms.Button
    Friend WithEvents ClVaga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClAndar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClDisponivel As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents GbPesquisa As System.Windows.Forms.GroupBox
    Friend WithEvents Txtvaga As System.Windows.Forms.TextBox
End Class
