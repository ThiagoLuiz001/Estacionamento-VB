Public Class AlterarDados

    Public Property Dado As Integer
    Dim Sql As String
    Dim Tabela As ADODB.Recordset



    Private Sub Apagar()
        TxtNome.Text = ""
        MskCPF.Text = ""
        MskNasc.Text = ""
        TxtEmail.Text = ""
        MskCelular.Text = ""
        MskCEP.Text = ""
        TxtRua.Text = ""
        TxtBairro.Text = ""
        TxtNumero.Text = ""
        TxtCompl.Text = ""
        ChkAtivo.Checked = False
    End Sub

  
    Private Sub BtnAlterar_Click(sender As Object, e As EventArgs) Handles BtnAlterar.Click
        Sql = "UPDATE TbCadastro SET Nome = '" & TxtNome.Text & "', CPF = '" & MskCPF.Text & "', Nascimento = '" & MskNasc.Text & "', Email = '" & TxtEmail.Text & "', Celular = '" & MskCelular.Text & "', Cep = '" & MskCEP.Text & "', Rua = '" & TxtRua.Text & "', Bairro = '" & TxtBairro.Text & "', Número = '" & TxtNumero.Text & "', Complemento ='" & TxtCompl.Text & "', Ativo = " & Convert.ToInt32(ChkAtivo.Checked) & " WHERE Id = " & Dado & ""

        Tabela = ABRIR_E_SETAR_TABELA(Sql)
        Apagar()
        Me.Close()
    End Sub

    Private Sub AlterarDados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox(" Valor" & Dado)
        Sql = " Select * From TbCadastro where Id = " & Dado & ""
        Tabela = ABRIR_E_SETAR_TABELA(Sql)
        If Not Tabela.BOF AndAlso Not Tabela.EOF Then
            TxtNome.Text = Tabela.Fields("Nome").Value.ToString
            MskCPF.Text = Tabela.Fields("CPF").Value.ToString
            MskNasc.Text = Tabela.Fields("Nascimento").Value.ToString
            TxtEmail.Text = Tabela.Fields("Email").Value.ToString
            MskCelular.Text = Tabela.Fields("Celular").Value.ToString
            MskCEP.Text = Tabela.Fields("Cep").Value.ToString
            TxtRua.Text = Tabela.Fields("Rua").Value.ToString
            TxtBairro.Text = Tabela.Fields("Bairro").Value.ToString
            TxtNumero.Text = Tabela.Fields("Número").Value.ToString
            TxtCompl.Text = Tabela.Fields("Complemento").Value.ToString
            ChkAtivo.Checked = Convert.ToBoolean(Tabela.Fields("Ativo").Value.ToString)
        Else
            MsgBox("Dados Não Encontrados")
        End If
    End Sub

    Private Sub GBteste_Enter(sender As Object, e As EventArgs) Handles GBteste.Enter

    End Sub
End Class