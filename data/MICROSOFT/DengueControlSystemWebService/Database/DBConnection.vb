
Imports System.IO
Imports System.Data.OleDb

Module DBConnection


    Private _connectionString As String
    Public Property ConnectionString() As String
        Get
            Return _connectionString
        End Get
        Set(ByVal value As String)
            _connectionString = value
        End Set
    End Property


    Private _databaseLocation As String
    Public Property DatabaseLocation() As String
        Get
            Return _databaseLocation
        End Get
        Set(ByVal value As String)
            _databaseLocation = value
        End Set
    End Property


    Private _connection As OleDbConnection
    Public Property connection() As OleDbConnection
        Get
            If _connection Is Nothing Then
                connect()
            End If
            Return _connection
        End Get
        Set(ByVal value As OleDbConnection)
            _connection = value
        End Set
    End Property


    Public Sub connect()

        Dim file As New FileInfo("C:\inetpub\wwwroot\DengueControlSystemWebService\App_Data\Dengue Control System.mdb")
        If Not file.Exists Then
            Throw New Exception("Database File not Found!!!" & file.FullName)
        End If

        connection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" _
            & "data source=" & file.FullName)

        connection.Open()



    End Sub



End Module
