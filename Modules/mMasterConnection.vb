#Region "Imports..."
Imports System
Imports System.Data
Imports System.Data.SqlClient
#End Region
#Region "Module mMasterConnection..."
Module mMasterConnection
#Region "Methods..."
    Public Sub MasterConnect()
        Try
            conn.ConnectionString = "Data Source=.;Initial Catalog=master;Persist Security Info=True;User ID=sa;Password=123"
            cmd.Connection = conn
            conn.Open()
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Public Sub MasterDisconnect()
        conn.Close()
    End Sub
#End Region
End Module
#End Region