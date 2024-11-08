Imports System.Data.SqlClient
Public Class Entrada
    '______________________________________________Variaveis_____________________________________________________
    Dim sql As String
    Dim Tabela As ADODB.Recordset


    '___________________________________Métodos Lógigos_______________________
    Private Sub Atualizar_Relogio()
        MskDataTempo.Text = DateTime.Now()
    End Sub

    Private Sub Validar(ByVal vdd As Boolean)
        TxtNome.ReadOnly = vdd
        MskCPFCLIENTE.ReadOnly = vdd
        TxtEmail.ReadOnly = vdd
        MskCelular.ReadOnly = vdd
        MskNasc.ReadOnly = vdd

    End Sub

    Private Sub StatusPlaca()
        If RbBrasil.Checked Then
            TxtMercosul.Visible = False
            MskBrasil.Visible = True
            MskBrasil.Text = ""

        ElseIf RbMercosul.Checked Then
            TxtMercosul.Visible = True
            TxtMercosul.Text = ""
            MskBrasil.Visible = False
        Else
            TxtMercosul.Visible = False
            MskBrasil.Visible = False

        End If
    End Sub

    Private Sub Busca()
        sql = "Select * From TbCadastro Where Cpf = '" & MskCPFCONSULTA.Text & "'"
        Tabela = ABRIR_E_SETAR_TABELA(sql)
        If Not Tabela.EOF And Not Tabela.BOF Then
            If Tabela.Fields("Ativo").Value.ToString = True Then
                Validar(True)
                ChkStatus.Checked = True
                ChkStatus.Text = "Cliente Ativo no Sistema"
                GbDadosDoCliente.Visible = True
                GBDadosdoVeiculo.Visible = True
                TxtNome.Text = Tabela.Fields("Nome").Value.ToString
                MskCPFCLIENTE.Text = MskCPFCONSULTA.Text
                TxtEmail.Text = Tabela.Fields("Email").Value.ToString
                MskCelular.Text = Tabela.Fields("Celular").Value.ToString
                MskNasc.Text = Tabela.Fields("Nascimento").Value.ToString

            ElseIf Tabela.Fields("Ativo").Value.ToString = "0" Then
                Validar(True)
                ChkStatus.Checked = True
                ChkStatus.Text = "Cliente Desativado no Sistema"
                GbDadosDoCliente.Visible = True
                GBDadosdoVeiculo.Visible = True
                TxtNome.Text = Tabela.Fields("Nome").Value.ToString
                MskCPFCLIENTE.Text = MskCPFCONSULTA.Text
                TxtEmail.Text = Tabela.Fields("Email").Value.ToString
                MskCelular.Text = Tabela.Fields("Celular").Value.ToString
                MskNasc.Text = Tabela.Fields("Nascimento").Value.ToString
            Else
                Validar(False)
                ChkStatus.Checked = False
                ChkStatus.Text = "Cliente não cadastrado"
                GbDadosDoCliente.Visible = True
                GBDadosdoVeiculo.Visible = True
                TxtNome.Text = ""
                MskCPFCLIENTE.Text = MskCPFCONSULTA.Text
                TxtEmail.Text = ""
                MskCelular.Text = ""
                MskNasc.Text = ""


            End If
        Else
            Validar(False)
            ChkStatus.Checked = False
            ChkStatus.Text = "Cliente não cadastrado"
            GbDadosDoCliente.Visible = True
            GBDadosdoVeiculo.Visible = True
            TxtNome.Text = ""
            MskCPFCLIENTE.Text = MskCPFCONSULTA.Text
            TxtEmail.Text = ""
            MskCelular.Text = ""
            MskNasc.Text = ""
        End If
        BuscarVagas()
    End Sub


    Private Sub Salvar()
        If TxtNome.Text <> "" And MskCPFCLIENTE.Text <> "" And TxtEmail.Text <> "" And MskCelular.Text <> "" And MskNasc.Text <> "" And TxtModelo.Text <> "" And TxtCor.Text <> "" And MskBrasil.Text <> "" Or TxtMercosul.Text <> "" Then
            If RbBrasil.Checked And ChkStatus.Checked Then
                sql = "Insert into TbEntrada(Placa, Modelo, Cor, CPF, Vaga, Entrada, Ativo) Values ('" & MskBrasil.Text & "', '" & TxtModelo.Text & "', '" & TxtCor.Text & "', '" & MskCPFCLIENTE.Text & "', '" & CBVaga.Text & "', '" & MskDataTempo.Text & "', 1)"
                Tabela = ABRIR_E_SETAR_TABELA(sql)
                sql = "Update TbVaga Set Ativo = 0 Where Vaga = '" & CBVaga.Text & "'"
                Tabela = ABRIR_E_SETAR_TABELA(sql)
            ElseIf RbBrasil.Checked And ChkStatus.Checked = False Then
                sql = "Insert into TbCliente(Nome, CPF, Email, Celular, Nascimento, DtCriacao, Ativo) Values('" & TxtNome.Text & "', '" & MskCPFCLIENTE.Text & "', '" & TxtEmail.Text & "', '" & MskCelular.Text & "', '" & MskNasc.Text & "', '" & MskDataTempo.Text & "', 1)"
                Tabela = ABRIR_E_SETAR_TABELA(sql)
                sql = "Insert into TbEntrada(Placa, Modelo, Cor, CPF, Vaga, Entrada, Ativo) Values ('" & MskBrasil.Text & "', '" & TxtModelo.Text & "', '" & TxtCor.Text & "', '" & MskCPFCLIENTE.Text & "', '" & CBVaga.Text & "', '" & MskDataTempo.Text & "', 1)"
                Tabela = ABRIR_E_SETAR_TABELA(sql)
                sql = "Update TbVaga Set Ativo = 0 Where Vaga = '" & CBVaga.Text & "'"
                Tabela = ABRIR_E_SETAR_TABELA(sql)

            ElseIf RbMercosul.Checked And ChkStatus.Checked Then
                sql = "Insert into TbEntrada(Placa, Modelo, Cor, CPF, Vaga, Entrada, Ativo) Values ('" & TxtMercosul.Text & "', '" & TxtModelo.Text & "', '" & TxtCor.Text & "', '" & MskCPFCLIENTE.Text & "', '" & CBVaga.Text & "', '" & MskDataTempo.Text & "', 1)"
                Tabela = ABRIR_E_SETAR_TABELA(sql)
                sql = "Update TbVaga Set Ativo = 0 Where Vaga = '" & CBVaga.Text & "'"
                Tabela = ABRIR_E_SETAR_TABELA(sql)
            ElseIf RbMercosul.Checked And ChkStatus.Checked = False Then
                sql = "Insert into TbCliente(Nome, CPF, Email, Celular, Nascimento, DtCriacao, Ativo) Values('" & TxtNome.Text & "', '" & MskCPFCLIENTE.Text & "', '" & TxtEmail.Text & "', '" & MskCelular.Text & "', '" & MskNasc.Text & "', '" & MskDataTempo.Text & "', 1)"
                Tabela = ABRIR_E_SETAR_TABELA(sql)
                sql = "Insert into TbEntrada(Placa, Modelo, Cor, CPF, Vaga, Entrada, Ativo) Values ('" & TxtMercosul.Text & "', '" & TxtModelo.Text & "', '" & TxtCor.Text & "', '" & MskCPFCLIENTE.Text & "', '" & CBVaga.Text & "', '" & MskDataTempo.Text & "', 1)"
                Tabela = ABRIR_E_SETAR_TABELA(sql)
                sql = "Update TbVaga Set Ativo = 0 Where Vaga = '" & CBVaga.Text & "'"
                Tabela = ABRIR_E_SETAR_TABELA(sql)
            Else
                MsgBox("Não foi Selecionado o Tipo de Placa!")

            End If

        Else
            MsgBox("Algum Campo não foi preenchido!")
        End If

    End Sub

    Private Sub ApagarCampos()
        CBVaga.Items.Clear()
        CBVaga.Text = ""
        MskCPFCONSULTA.Text = ""
        TxtNome.Text = ""
        MskCPFCLIENTE.Text = ""
        TxtEmail.Text = ""
        MskCelular.Text = ""
        MskNasc.Text = ""
        TxtMercosul.Text = ""
        MskBrasil.Text = ""
        TxtModelo.Text = ""
        TxtCor.Text = ""
        ChkStatus.Text = "Digite o CPF"
        ChkStatus.Checked = False
        RbBrasil.Checked = False
        RbMercosul.Checked = False
        GbDadosDoCliente.Visible = False
        GBDadosdoVeiculo.Visible = False
    End Sub


    Private Sub BuscarVagas()
        Dim x As Integer = 0
        sql = " Select Vaga From TbVaga Where Ativo = 1"
        Tabela = ABRIR_E_SETAR_TABELA(sql)
        With CBVaga
            CBVaga.Items.Clear()
            If Tabela.RecordCount <> 0 Then
                Tabela.MoveFirst()
                While Tabela.EOF = False
                    .Items.Add(Tabela.Fields("Vaga").Value.ToString)
                    x += 1
                    Tabela.MoveNext()
                End While
            End If
        End With

    End Sub
    '___________________________________________________Eventos_______________________________________________________
    Private Sub Entrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApagarCampos()
        MskDataTempo.Enabled = False
        Timer1.Start()
        StatusPlaca()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Atualizar_Relogio()
    End Sub

    Private Sub RbBrasil_CheckedChanged(sender As Object, e As EventArgs) Handles RbBrasil.CheckedChanged
        StatusPlaca()
    End Sub

    Private Sub RbMercosul_CheckedChanged(sender As Object, e As EventArgs) Handles RbMercosul.CheckedChanged
        StatusPlaca()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Salvar()
        ApagarCampos()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Busca()
        BuscarVagas()
    End Sub
End Class