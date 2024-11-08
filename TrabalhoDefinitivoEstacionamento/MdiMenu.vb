Public Class MdiMenu

    Private Sub EntradaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradaToolStripMenuItem.Click
        Entrada.MdiParent = Me
        Entrada.Show()
    End Sub

    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click
        Cadastro.MdiParent = Me
        Cadastro.Show()

    End Sub

    Private Sub ConsultaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaToolStripMenuItem.Click
        ConsultaCliente.Show()
    End Sub



    Private Sub ConsultarVagasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarVagasToolStripMenuItem.Click
        ConsultaVaga.MdiParent = Me
        ConsultaVaga.Show()
    End Sub


    Private Sub SaidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaidaToolStripMenuItem.Click
        Saida.MdiParent = Me
        Saida.Show()
    End Sub


End Class
