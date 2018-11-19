Module conexao
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public sql As String
    Public conexao = Application.StartupPath & "\db\db.mdb"

    Sub conectarDb()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & conexao)

        Catch ex As Exception
            MsgBox("Conexão com banco de dados falhou.", MsgBoxStyle.Information, "AVISO")
        End Try
    End Sub

    Sub consultarDb(query As String)
        sql = query
        rs = db.Execute(sql)
    End Sub

    Sub fecharConexao()
        Try
            db.Close()

        Catch ex As Exception
            MsgBox("Falha ao fechar conexão com banco de dado.", MsgBoxStyle.Information, "AVISO")
        End Try
    End Sub
End Module
