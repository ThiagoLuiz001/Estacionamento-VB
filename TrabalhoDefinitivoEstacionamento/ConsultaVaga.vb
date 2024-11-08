Public Class ConsultaVaga
    Dim Sql As String
    Dim Tabela As ADODB.Recordset
    Private Sub Apagar()
        Txtvaga.Text = ""
        MskAndar.Text = ""
        RbAndar.Checked = False
        RbDisponivel.Checked = False
        RbVaga.Checked = False
        MskAndar.Visible = False
        Txtvaga.Visible = False
        LblAndar.Visible = False
        LblDescricao.Visible = False
    End Sub

    Private Sub Pesquisa()
        If RbVaga.Checked Then
            Sql = "Select * From TbVaga where vaga = '" & Txtvaga.Text & "'"
            Tabela = ABRIR_E_SETAR_TABELA(Sql)
            If Not Tabela.EOF And Not Tabela.BOF Then
                GradeVaga.Rows.Clear()
                If Tabela.Fields("Ativo").Value.ToString = True Then
                    GradeVaga.Rows.Add(Tabela.Fields("Vaga").Value.ToString, Tabela.Fields("Andar").Value.ToString, My.Resources.Livre)
                Else
                    GradeVaga.Rows.Add(Tabela.Fields("Vaga").Value.ToString, Tabela.Fields("Andar").Value.ToString, My.Resources.Ocupado)
                End If
            Else
                MsgBox("Vaga não Existe na Tabela!")
            End If

        ElseIf RbAndar.Checked Then
            Sql = "Select * From TbVaga where Andar Like '" & MskAndar.Text & "%'"
            Tabela = ABRIR_E_SETAR_TABELA(Sql)
            Dim linha As Integer = 0
            With GradeVaga
                GradeVaga.Rows.Clear()
                If Tabela.RecordCount <> 0 Then
                    Tabela.MoveFirst()
                    While Tabela.EOF = False
                        .Rows.Add(False)
                        .Item(0, linha).Value = Tabela.Fields("Vaga").Value.ToString
                        .Item(1, linha).Value = Tabela.Fields("Andar").Value.ToString
                        If Tabela.Fields("Ativo").Value.ToString = True Then
                            .Item(2, linha).Value = My.Resources.Livre
                        Else
                            .Item(2, linha).Value = My.Resources.Ocupado
                        End If

                        linha += 1
                        Tabela.MoveNext()
                    End While
                End If
            End With

        ElseIf RbDisponivel.Checked Then
            Sql = "Select * From TbVaga Where Ativo = 1"
            Tabela = ABRIR_E_SETAR_TABELA(Sql)
            Dim linha As Integer = 0
            With GradeVaga
                GradeVaga.Rows.Clear()
                If Tabela.RecordCount <> 0 Then
                    Tabela.MoveFirst()
                    While Tabela.EOF = False
                        .Rows.Add(False)
                        .Item(0, linha).Value = Tabela.Fields("Vaga").Value.ToString
                        .Item(1, linha).Value = Tabela.Fields("Andar").Value.ToString
                        If Tabela.Fields("Ativo").Value.ToString = True Then
                            .Item(2, linha).Value = My.Resources.Livre
                        Else
                            .Item(2, linha).Value = My.Resources.Ocupado
                        End If

                        linha += 1
                        Tabela.MoveNext()
                    End While
                End If
            End With

        Else
            MsgBox("Não Era suposto vc cometer esse erro! Parabens pelo mérito!")
        End If
    End Sub

    Private Sub GerarGrade()
        Dim x As Integer = 1
        Dim linha As Integer = 0
        'Sql = "Select Vaga, Andar, Ativo, count_Vg from (Select Distinct * ,Count(*)over(order by Vaga) count_vg From TbVaga Where Ativo = 1)Tab Where Ativo = 1"
        Sql = "Select * From TbVaga"
        Tabela = ABRIR_E_SETAR_TABELA(Sql)
        With GradeVaga
            GradeVaga.Rows.Clear()
            If Tabela.RecordCount <> 0 Then
                Tabela.MoveFirst()
                While Tabela.EOF = False
                    .Rows.Add(False)
                    .Item(0, linha).Value = Tabela.Fields("Vaga").Value.ToString
                    .Item(1, linha).Value = Tabela.Fields("Andar").Value.ToString
                    If Tabela.Fields("Ativo").Value.ToString = True Then
                        .Item(2, linha).Value = My.Resources.Livre
                    Else
                        .Item(2, linha).Value = My.Resources.Ocupado
                    End If

                    linha += 1
                    Tabela.MoveNext()
                End While
            End If
        End With

    End Sub

    Private Sub ConsultaVaga_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GerarGrade()
        GbPesquisa.Visible = False
    End Sub

    Private Sub BtnPesquisar_Click(sender As Object, e As EventArgs) Handles BtnPesquisar.Click
        If GbPesquisa.Visible And RbAndar.Checked = False And RbVaga.Checked = False And RbDisponivel.Checked = False Then
            Apagar()
            GerarGrade()
            GbPesquisa.Visible = False

        ElseIf GbPesquisa.Visible And RbAndar.Checked Or RbDisponivel.Checked Or RbVaga.Checked Then
            Pesquisa()
            Apagar()
        Else
            GbPesquisa.Visible = True
        End If
    End Sub

    Private Sub RbVaga_CheckedChanged(sender As Object, e As EventArgs) Handles RbVaga.CheckedChanged
        MskAndar.Enabled = False
        MskAndar.Visible = True
        Txtvaga.Enabled = True
        Txtvaga.Visible = True
        LblAndar.Visible = True
        LblDescricao.Visible = True
    End Sub

    Private Sub RbAndar_CheckedChanged(sender As Object, e As EventArgs) Handles RbAndar.CheckedChanged
        MskAndar.Enabled = True
        MskAndar.Visible = True
        Txtvaga.Enabled = False
        Txtvaga.Visible = True
        LblAndar.Visible = True
        LblDescricao.Visible = True
    End Sub

    Private Sub RbDisponivel_CheckedChanged(sender As Object, e As EventArgs) Handles RbDisponivel.CheckedChanged
        MskAndar.Visible = False
        Txtvaga.Visible = False
        LblAndar.Visible = False
        LblDescricao.Visible = False
    End Sub

    Private Sub ConsultaVaga_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        GradeVaga.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        GradeVaga.Dock = DockStyle.Fill
    End Sub
End Class