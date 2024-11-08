Public Class Cadastro
    Dim Sql As String
    Dim Tabela As ADODB.Recordset
    Private Sub Apagar()
        TxtNome.Text = ""
        MskCPF.Text = ""
        TxtEmail.Text = ""
        MskCelular.Text = ""
        MskNasc.Text = ""
        MskCEP.Text = ""
        TxtUF.Text = ""
        TxtRua.Text = ""
        TxtNumero.Text = ""
        TxtBairro.Text = ""
        TxtCompl.Text = ""
    End Sub
    Private Sub Salvar()
        Dim Data As Date = Date.Now()
        Sql = "Insert into TbCadastro(Nome, CPF, Nascimento, Email, Celular, Cep, UF, Rua, Número, Bairro, Complemento, DtCriacao, Ativo) Values('" & TxtNome.Text & "','" & MskCPF.Text & "','" & MskNasc.Text & "', '" & TxtEmail.Text & "', '" & MskCelular.Text & "', '" & MskCEP.Text & "', '" & TxtUF.Text & "', '" & TxtRua.Text & "', '" & TxtNumero.Text & "', '" & TxtBairro.Text & "', '" & TxtCompl.Text & "', '" & Data & "', 1)"
        Tabela = ABRIR_E_SETAR_TABELA(Sql)
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        Salvar()
        Apagar()
    End Sub



    Private Sub Cadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class