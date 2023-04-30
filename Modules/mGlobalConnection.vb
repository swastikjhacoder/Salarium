#Region "Imports..."
Imports System
Imports System.Data
Imports System.Data.SqlClient
#End Region
#Region "mGlobalConnection..."
Module mGlobalConnection
#Region "Declarations..."
    Public conn As New SqlConnection
    Public cmd As New SqlCommand
    Public dr As SqlDataReader
#End Region
#Region "Methods..."
    Public Sub Connect()
        Try
            conn.ConnectionString = "Data Source=.;Initial Catalog=Salarium;Persist Security Info=True;User ID=sa;Password=123"
            cmd.Connection = conn
            conn.Open()
            If My.Settings.SalariumConnectionString = "" Then
                My.Settings.SalariumConnectionString = conn.ConnectionString
                My.Settings.Save()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Public Sub Disconnect()
        conn.Close()
    End Sub
#End Region
End Module
#End Region