Module ACONEXAO
    Private CONECTANDO As New ADODB.Connection
    Dim ACESSAR_SERVIDOR, ACESSAR_BASE_DE_DADOS, ACESSAR_USUARIO, ACESSAR_SENHA
    Public Function ABRIR_E_SETAR_TABELA(ByVal sqlquery As String)

        Dim MOSTRAR_RESULTADO As New ADODB.Recordset

        ACESSAR_BASE_DE_DADOS = "BdEstacionamento"
        ACESSAR_USUARIO = ""
        ACESSAR_SENHA = ""
        ACESSAR_SERVIDOR = "DESKTOP-8EN8GTK"

        If CONECTANDO.State = 0 Then
            CONECTANDO.ConnectionString = "driver={sql server};" & _
                                            "server=" + ACESSAR_SERVIDOR + ";" & _
                                            "Database=" + ACESSAR_BASE_DE_DADOS + ";" & _
                                            "PWD=" + ACESSAR_SENHA + ";" & _
                                            "UID=" + ACESSAR_USUARIO + ";"
            CONECTANDO.ConnectionTimeout = 30
            CONECTANDO.CommandTimeout = 180
            CONECTANDO.Open()
        End If

        MOSTRAR_RESULTADO.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        MOSTRAR_RESULTADO.Open(sqlquery, CONECTANDO, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        ABRIR_E_SETAR_TABELA = MOSTRAR_RESULTADO
        MOSTRAR_RESULTADO = Nothing
    End Function
End Module

