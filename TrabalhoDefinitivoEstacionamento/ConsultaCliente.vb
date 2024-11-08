Public Class ConsultaCliente
    Dim Sql As String
    Dim Tabela As ADODB.Recordset

    Private Sub ApagarTudo()
        MskCPF.Text = ""
        MskData.Text = ""
        RbAtivo.Checked = False
        RbCPF.Checked = False
        RbCriacao.Checked = False

    End Sub
    Private Sub Apagar()
        MskCPF.Text = ""
        MskData.Text = ""
    End Sub
    Private Sub PesquisaCPF()
        Sql = " Select * From TbCadastro Where CPF = '" & MskCPF.Text & "'"
        Tabela = ABRIR_E_SETAR_TABELA(Sql)
        Dim x As Integer = 0
        With GradeCliente
            GradeCliente.Rows.Clear()
            If Tabela.RecordCount <> 0 Then
                Tabela.MoveFirst()
                While Tabela.EOF = False
                    .Rows.Add(False)
                    .Item(0, x).Value = Tabela.Fields("Id").Value.ToString
                    .Item(1, x).Value = Tabela.Fields("Nome").Value.ToString
                    .Item(2, x).Value = Tabela.Fields("CPF").Value.ToString
                    .Item(3, x).Value = Tabela.Fields("Celular").Value.ToString
                    .Item(4, x).Value = Tabela.Fields("CEP").Value.ToString
                    .Item(5, x).Value = Tabela.Fields("DtCriacao").Value.ToString
                    .Item(6, x).Value = Convert.ToBoolean(Tabela.Fields("Ativo").Value.ToString)

                    x = x + 1
                    Tabela.MoveNext()
                End While
            End If
        End With
    End Sub

    Private Sub PesquisaData()
        Sql = "Select * From TbCadastro Where DtCriacao = '" & MskData.Text & "'"
        Tabela = ABRIR_E_SETAR_TABELA(Sql)
        Dim x As Integer = 0
        With GradeCliente
            GradeCliente.Rows.Clear()
            If Tabela.RecordCount <> 0 Then
                Tabela.MoveFirst()
                While Tabela.EOF = False
                    .Rows.Add(False)
                    .Item(0, x).Value = Tabela.Fields("Id").Value.ToString
                    .Item(1, x).Value = Tabela.Fields("Nome").Value.ToString
                    .Item(2, x).Value = Tabela.Fields("CPF").Value.ToString
                    .Item(3, x).Value = Tabela.Fields("Celular").Value.ToString
                    .Item(4, x).Value = Tabela.Fields("CEP").Value.ToString
                    .Item(5, x).Value = Tabela.Fields("DtCriacao").Value.ToString
                    .Item(6, x).Value = Convert.ToBoolean(Tabela.Fields("Ativo").Value.ToString)

                    x = x + 1
                    Tabela.MoveNext()
                End While
            End If
        End With
    End Sub

    Private Sub PesquisaAtivo()
        Sql = "Select * From TbCadastro Where Ativo = 1"
        Tabela = ABRIR_E_SETAR_TABELA(Sql)
        Dim x As Integer = 0
        With GradeCliente
            GradeCliente.Rows.Clear()
            If Tabela.RecordCount <> 0 Then
                Tabela.MoveFirst()
                While Tabela.EOF = False
                    .Rows.Add(False)
                    .Item(0, x).Value = Tabela.Fields("Id").Value.ToString
                    .Item(1, x).Value = Tabela.Fields("Nome").Value.ToString
                    .Item(2, x).Value = Tabela.Fields("CPF").Value.ToString
                    .Item(3, x).Value = Tabela.Fields("Celular").Value.ToString
                    .Item(4, x).Value = Tabela.Fields("CEP").Value.ToString
                    .Item(5, x).Value = Tabela.Fields("DtCriacao").Value.ToString
                    .Item(6, x).Value = Convert.ToBoolean(Tabela.Fields("Ativo").Value.ToString)

                    x = x + 1
                    Tabela.MoveNext()
                End While
            End If
        End With
    End Sub


    Private Sub GerarGrade()
        Sql = "Select * From TbCadastro"
        Tabela = ABRIR_E_SETAR_TABELA(Sql)
        Dim x = 0
        With GradeCliente
            If Tabela.RecordCount <> 0 Then
                Tabela.MoveFirst()
                While Tabela.EOF = False
                    .Rows.Add(False)
                    .Item(0, x).Value = Tabela.Fields("Id").Value.ToString
                    .Item(1, x).Value = Tabela.Fields("Nome").Value.ToString
                    .Item(2, x).Value = Tabela.Fields("CPF").Value.ToString
                    .Item(3, x).Value = Tabela.Fields("Celular").Value.ToString
                    .Item(4, x).Value = Tabela.Fields("CEP").Value.ToString
                    .Item(5, x).Value = Tabela.Fields("DtCriacao").Value.ToString
                    .Item(6, x).Value = Convert.ToBoolean(Tabela.Fields("Ativo").Value.ToString)

                    x = x + 1
                    Tabela.MoveNext()
                End While
            End If
        End With
    End Sub


    Private Sub ConsultaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GerarGrade()
    End Sub






    Private Sub BtnGerar_Click(sender As Object, e As EventArgs) Handles BtnGerar.Click
        If GbPesquisa.Visible = True Then
            GbPesquisa.Visible = False
            ApagarTudo()
            GerarGrade()
        Else
            GbPesquisa.Visible = True
        End If
    End Sub

    Private Sub RbCriacao_CheckedChanged(sender As Object, e As EventArgs) Handles RbCriacao.CheckedChanged
        LblDescricao.Visible = True
        LblDescricao.Text = "Digite a Data:"
        MskCPF.Visible = False
        MskData.Visible = True
        Apagar()
    End Sub

    Private Sub RbCPF_CheckedChanged(sender As Object, e As EventArgs) Handles RbCPF.CheckedChanged
        Apagar()
        LblDescricao.Visible = True
        LblDescricao.Text = "Digite o CPF:"
        MskCPF.Visible = True
        MskData.Visible = False
    End Sub

    Private Sub RbAtivo_CheckedChanged(sender As Object, e As EventArgs) Handles RbAtivo.CheckedChanged
        Apagar()
        LblDescricao.Visible = False
        MskCPF.Visible = False
        MskData.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RbAtivo.Checked Then
            PesquisaAtivo()
        ElseIf RbCPF.Checked Then
            PesquisaCPF()
        ElseIf RbCriacao.Checked Then
            PesquisaData()
        Else
            GerarGrade()

        End If
    End Sub

  
    Private Sub GradeCliente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GradeCliente.CellContentClick
        If e.ColumnIndex = GradeCliente.Columns("Cl_Alterar").Index AndAlso e.RowIndex >= 0 Then
            Dim AlterarDados As New AlterarDados()
            AlterarDados.Dado = GradeCliente.Rows(e.RowIndex).Cells(0).Value.ToString
            AlterarDados.Show()
        End If
    End Sub

    Private Sub ConsultaCliente_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        GradeCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        GradeCliente.Dock = DockStyle.Fill
    End Sub
End Class