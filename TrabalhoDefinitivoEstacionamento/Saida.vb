Imports System.Drawing.Printing
Public Class Saida
    Dim Sql As String
    Dim Tabela As New ADODB.Recordset
    Dim QtdPag As New List(Of String)
    Dim Valores As New List(Of Double)
    Dim cont As Integer = 1



    Function ConverteTempoEmDinDinnoMeuBolso(ByVal inicio As DateTime) As Double
        Dim permanencia As Double
        Dim final As DateTime = DateTime.Now()
        permanencia = (final - inicio).TotalMinutes

        Return permanencia


    End Function

    Private Sub Apagar()
        TxtCodigo.Text = ""
        TxtNome.Text = ""
        MskCPF.Text = ""
        MskCelular.Text = ""
        TxtPlaca.Text = ""
        TxtVeiculo.Text = ""
        TxtCor.Text = ""
        TxtEntrada.Text = ""
        TxtSaida.Text = ""
        TxtTotal.Text = ""
        TxtPagar.Text = ""
        TxtPagamento.Text = ""
        TxtTroco.Text = ""
        CbBandeira.Text = ""
        RbCartCred.Checked = False
        RbCartDeb.Checked = False
        RbDin.Checked = False
        RbPix.Checked = False

    End Sub



    Private Sub Lancamento()
        Sql = "Insert into TbSaida(CPF, CodEntrada, tempo, Saida, Valor, Ativo) Values('" & MskCPF.Text & "', " & TxtCodigo.Text & ", '" & TxtPermanencia.Text & "', '" & TxtSaida.Text & "', '" & TxtTotal.Text & "', 1)"
        Tabela = ABRIR_E_SETAR_TABELA(Sql)
        Sql = "Update TbVaga Set Ativo = 1 where Vaga = '" & txtVaga.Text & "'"
        Tabela = ABRIR_E_SETAR_TABELA(Sql)
        Sql = "Update TbEntrada Set Ativo = 0 where Id = " & TxtCodigo.Text & ""
        Tabela = ABRIR_E_SETAR_TABELA(Sql)

        For Each Formas In QtdPag
            Sql = " insert into TbPagamentos(CPf, CodEntry, Descricao, Ativo) Values('" & MskCPF.Text & "', " & TxtCodigo.Text & ", '" & Formas & "', 1)"
            Tabela = ABRIR_E_SETAR_TABELA(Sql)
        Next
    End Sub



    Private Sub CamposBlock()
        TxtNome.ReadOnly = True
        MskCPF.ReadOnly = True
        MskCelular.ReadOnly = True
        TxtPlaca.ReadOnly = True
        TxtVeiculo.ReadOnly = True
        TxtCor.ReadOnly = True
        TxtEntrada.ReadOnly = True
        TxtEntrada.ReadOnly = True
        TxtSaida.ReadOnly = True
        TxtTotal.ReadOnly = True
        TxtPermanencia.ReadOnly = True
        txtVaga.ReadOnly = True

    End Sub


    Private Sub Modelos(ByVal escopo As Integer)
        Select Case escopo
            Case 0 'Cartão Débito
                GbForma.Text = "Pagamento em Débito"
                LblPagar.Visible = True
                LblPagamento.Visible = True
                LblTroco.Visible = False
                LblChavePix.Visible = False
                LblBandeira.Visible = True
                TxtPagar.Visible = True
                TxtPagamento.Visible = True
                TxtTroco.Visible = False
                LinkEmail.Visible = False
                LinkCel.Visible = False
                CbBandeira.Visible = True

            Case 1 'Cartão Crédito
                GbForma.Text = "Pagamento em Crédito"
                LblPagar.Visible = True
                LblPagamento.Visible = True
                LblTroco.Visible = False
                LblChavePix.Visible = False
                LblBandeira.Visible = True
                TxtPagar.Visible = True
                TxtPagamento.Visible = True
                TxtTroco.Visible = False
                LinkEmail.Visible = False
                LinkCel.Visible = False
                CbBandeira.Visible = True

            Case 2 'Dinheiro
                GbForma.Text = "Pagamento em Dinheiro"
                LblPagar.Visible = True
                LblPagamento.Visible = True
                LblTroco.Visible = True
                LblChavePix.Visible = False
                LblBandeira.Visible = False
                TxtPagar.Visible = True
                TxtPagamento.Visible = True
                TxtTroco.Visible = True
                LinkEmail.Visible = False
                LinkCel.Visible = False
                CbBandeira.Visible = False

            Case 3 'Pix
                GbForma.Text = "Pagamento em Pix"
                LblPagar.Visible = True
                LblPagamento.Visible = True
                LblTroco.Visible = False
                LblChavePix.Visible = True
                LblBandeira.Visible = False
                TxtPagar.Visible = True
                TxtPagamento.Visible = True
                TxtTroco.Visible = False
                LinkEmail.Visible = True
                LinkCel.Visible = True
                CbBandeira.Visible = False
        End Select
    End Sub

    Private Sub Pagamento(ByVal cond As Integer)
        Dim dinheiro As Double = (Convert.ToDouble(TxtPagar.Text.Replace("R$", "")) - Convert.ToDouble(TxtPagamento.Text)).ToString("0.00")

        Select Case cond
            Case 0
                If dinheiro < 0 Then
                    MsgBox("Valor Passado no cartão não pode ser maior que o valor a pagar em questão!")
                ElseIf dinheiro >= 0 Then
                    TxtPagar.Text = "R$ " & dinheiro
                    QtdPag.Add("" & cont & "° Pagamento no valor de R$ " & TxtPagamento.Text & " no Débito bandeira " & CbBandeira.Text)
                    Valores.Add(Convert.ToDouble(TxtPagamento.Text))
                    cont += 1
                    TxtPagamento.Text = ""
                    CbBandeira.Text = ""
                    If dinheiro = 0 Then
                        RbCartDeb.Enabled = False
                        RbCartCred.Enabled = False
                        RbDin.Enabled = False
                        RbPix.Enabled = False
                        TxtPagamento.Enabled = False
                        TxtTroco.Enabled = False
                        TxtPagar.Enabled = False
                        TxtCodigo.Enabled = False
                        BtnPesquisa.Enabled = False
                    End If
                End If

            Case 1
                If dinheiro < 0 Then
                    MsgBox("Valor Passado no cartão não pode ser maior que o valor a pagar em questão!")
                ElseIf dinheiro >= 0 Then
                    TxtPagar.Text = "R$ " & dinheiro
                    QtdPag.Add("" & cont & "° Pagamento no valor de R$ " & TxtPagamento.Text & " no Crédito bandeira " & CbBandeira.Text)
                    Valores.Add(Convert.ToDouble(TxtPagamento.Text))
                    cont += 1
                    TxtPagamento.Text = ""
                    CbBandeira.Text = ""
                    If dinheiro = 0 Then
                        RbCartDeb.Enabled = False
                        RbCartCred.Enabled = False
                        RbDin.Enabled = False
                        RbPix.Enabled = False
                        TxtPagamento.Enabled = False
                        TxtTroco.Enabled = False
                        TxtPagar.Enabled = False
                        TxtCodigo.Enabled = False
                        BtnPesquisa.Enabled = False
                    End If
                End If


            Case 2
                If dinheiro <= 0 Then
                    dinheiro = dinheiro * (-1)
                    TxtTroco.Text = "R$ " & dinheiro
                    QtdPag.Add("" & cont & "° Pagamento no valor de R$" & TxtPagamento.Text & " no Dinheiro com troco de " & TxtTroco.Text)
                    Valores.Add(Convert.ToDouble(TxtPagamento.Text))
                    cont += 1
                    RbCartDeb.Enabled = False
                    RbCartCred.Enabled = False
                    RbDin.Enabled = False
                    RbPix.Enabled = False
                    TxtPagamento.Enabled = False
                    TxtTroco.Enabled = False
                    TxtPagar.Enabled = False
                    TxtCodigo.Enabled = False
                    BtnPesquisa.Enabled = False
                ElseIf dinheiro > 0 Then
                    TxtPagar.Text = "R$ " & dinheiro
                    QtdPag.Add("" & cont & "° Pagamento no valor de R$ " & TxtPagamento.Text & " no Dinheiro")
                    Valores.Add(Convert.ToDouble(TxtPagamento.Text))
                    TxtPagamento.Text = ""

                End If


            Case 3
                If dinheiro < 0 Then
                    MsgBox("Valor Passado no PIX não pode ser maior que o valor a pagar em questão!")
                ElseIf dinheiro >= 0 Then
                    TxtPagar.Text = "R$ " & dinheiro
                    QtdPag.Add("" & cont & "° Pagamento no valor de R$ " & TxtPagamento.Text & " no PIX")
                    Valores.Add(Convert.ToDouble(TxtPagamento.Text))
                    cont += 1
                    TxtPagamento.Text = ""
                    CbBandeira.Text = ""
                    If dinheiro = 0 Then
                        RbCartDeb.Enabled = False
                        RbCartCred.Enabled = False
                        RbDin.Enabled = False
                        RbPix.Enabled = False
                        TxtPagamento.Enabled = False
                        TxtTroco.Enabled = False
                        TxtPagar.Enabled = False
                        TxtCodigo.Enabled = False
                        BtnPesquisa.Enabled = False
                    End If
                End If
        End Select

    End Sub

    Private Sub Pesquisar()
        Sql = "Select T0.Id, T0.Placa, T0.Modelo, T0.Cor, T0.Cpf, T0.Entrada, T0.Vaga, T0.Ativo, T1.Nome, T1.Celular From TbEntrada T0 INNER JOIN TbCadastro T1 ON T0.Cpf = T1.CPf WHERE T0.Id = " & TxtCodigo.Text & " and T0.Ativo = 1"
        Tabela = ABRIR_E_SETAR_TABELA(Sql)
        If Not Tabela.EOF And Not Tabela.BOF Then
            TxtNome.Text = Tabela.Fields("Nome").Value.ToString
            MskCPF.Text = Tabela.Fields("Cpf").Value.ToString
            MskCelular.Text = Tabela.Fields("Celular").Value.ToString
            TxtPlaca.Text = Tabela.Fields("Placa").Value.ToString
            TxtVeiculo.Text = Tabela.Fields("Modelo").Value.ToString
            TxtCor.Text = Tabela.Fields("Cor").Value.ToString
            TxtEntrada.Text = Tabela.Fields("Entrada").Value.ToString
            txtVaga.Text = Tabela.Fields("Vaga").Value.ToString
            TxtSaida.Text = Convert.ToString(DateTime.Now())
            Dim tempo As Double = ConverteTempoEmDinDinnoMeuBolso(Convert.ToDateTime(TxtEntrada.Text))
            TxtPermanencia.Text = "" & tempo.ToString("0.00") & " minutos"
            TxtTotal.Text = "R$ " & (tempo * 0.15).ToString("0.00")
            TxtPagar.Text = TxtTotal.Text
        End If
    End Sub

    '/////////////////////////////////////////////////////////////////////////////Impressora////////////////////////////////////////////////////////////////////////////////////

    Private WithEvents printDocument As New PrintDocument
    Private printPreviewDialog As New PrintPreviewDialog

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        printDocument.DefaultPageSettings.Margins = New Printing.Margins(0, 0, 0, 0)
        printDocument.DefaultPageSettings.PaperSize = New Printing.PaperSize("Custom", 200, 200)

        AddHandler printDocument.PrintPage, AddressOf PrintDocument_PrintPage
    End Sub


    Private Sub PrintDocument_PrintPage(sender As Object, e As PrintPageEventArgs)
        Dim font As New Font("Arial", 5)
        Dim brush As New SolidBrush(Color.Black)
        Dim xPos As Integer = 10
        Dim yPos As Integer = 10

        Dim Dados As String = "Trabalho Estacionamento " & vbCrLf & " CEP: 36363-350 - Rio Branco" & vbCrLf & "Juiz de Fora     MG" & vbCrLf & " CNPJ:03.985.655/0001-23" & vbCrLf
        Dim Informacoes As String = "COMPROVANTE CLIENTE" & vbCrLf & " Dia e Hora:" & TxtSaida.Text & "" & vbCrLf & " Comprovante:" & TxtCodigo.Text & " CPF:" & MskCPF.Text & "" & vbCrLf & "Placa:" & TxtPlaca.Text & " Tempo:" & TxtPermanencia.Text & "" & vbCrLf & " DESCRIÇÃO" & vbCrLf
        Dim pg As String = ""
        Dim x As Integer = 0
        Dim total As Double = 0
        For Each y In QtdPag
            pg += "" & y & "" & vbCrLf
            total += Valores.Item(x)
            x += 1
        Next
        If TxtTroco.Text = "" Then
            TxtTroco.Text = 0
        End If
        Dim Final As String = "Valor Total:R$" & total & " Troco:" & TxtTroco.Text

        Dim texto As String = Dados + Informacoes + pg + Final
        e.Graphics.DrawString(texto, font, brush, xPos, yPos)
    End Sub











    '//////////////////////////////////////////////////////////////////////////Impressora///////////////////////////////////////////////////////////////////////////////////////
    Private Sub Saida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GbForma.Visible = False
        CamposBlock()
    End Sub

    Private Sub RbCartDeb_CheckedChanged(sender As Object, e As EventArgs) Handles RbCartDeb.CheckedChanged
        GbForma.Visible = True
        Modelos(0)
    End Sub

    Private Sub RbDin_CheckedChanged(sender As Object, e As EventArgs) Handles RbDin.CheckedChanged
        GbForma.Visible = True
        Modelos(2)
    End Sub

    Private Sub RbCartCred_CheckedChanged(sender As Object, e As EventArgs) Handles RbCartCred.CheckedChanged
        GbForma.Visible = True
        Modelos(1)
    End Sub


    Private Sub RbPix_CheckedChanged(sender As Object, e As EventArgs) Handles RbPix.CheckedChanged
        GbForma.Visible = True
        Modelos(3)
    End Sub

    Private Sub BtnPesquisa_Click(sender As Object, e As EventArgs) Handles BtnPesquisa.Click
        Pesquisar()
    End Sub

    Private Sub TxtPagamento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPagamento.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            Dim valor As Integer
            If RbCartDeb.Checked Then
                valor = 0
            ElseIf RbCartCred.Checked Then
                valor = 1
            ElseIf RbDin.Checked Then
                valor = 2
            ElseIf RbPix.Checked Then
                valor = 3
            End If

            Pagamento(valor)
        End If

    End Sub

    Private Sub BtnLancar_Click(sender As Object, e As EventArgs) Handles BtnLancar.Click
        printPreviewDialog.Document = printDocument
        printPreviewDialog.ShowDialog()
        Lancamento()
        Apagar()
        GbForma.Visible = False
        RbCartDeb.Enabled = True
        RbCartCred.Enabled = True
        RbDin.Enabled = True
        RbPix.Enabled = True
        TxtPagamento.Enabled = True
        TxtTroco.Enabled = True
        TxtPagar.Enabled = True
        TxtCodigo.Enabled = True
        BtnPesquisa.Enabled = True
        cont = 0
        QtdPag.Clear()
        Valores.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        printPreviewDialog.Document = printDocument
        printPreviewDialog.ShowDialog()
    End Sub
End Class