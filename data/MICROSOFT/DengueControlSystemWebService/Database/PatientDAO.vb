Module PatientDAO


    Public Sub addPatient(ByVal name As String, ByVal cnic As String, ByVal phoneNumber As String, _
        ByVal address As String, ByVal email As String, ByVal password As String)

        Dim conn = DBConnection.connection

        If String.IsNullOrEmpty(password) Then
            password = "123456"
        End If

        Dim sql = "INSERT INTO Patient(name,cnic,phoneNumber,address,email,password) VALUES " _
        & " ('" & name & "','" & cnic & "','" & phoneNumber & "','" & address & "','" _
        & email & "','" & password & "')"

        Dim dbCommand As New OleDb.OleDbCommand(sql, conn)

        dbCommand.ExecuteNonQuery()


    End Sub


    Public Function login(ByVal username As String, ByVal password As String) As String

        Dim conn = DBConnection.connection

        Dim sql As String = "select password from patient where phoneNumber='" & username & "'"

        Dim dbCommand As New OleDb.OleDbCommand(sql, conn)

        Dim rs = dbCommand.ExecuteReader()

        If rs.Read Then
            Dim dPassword As String = rs(0)
            If dPassword.Equals(password) Then
                Return "PASS"
            Else
                Return "FAIL: Invalid credentials!!!"
            End If
        Else
            Return "FAIL: Invalid credentials!!!"
        End If

    End Function


    Public Sub changePassword(ByVal phoneNumber As String, ByVal newPassword As String, ByVal oldPassword As String)

        Dim conn = DBConnection.connection
        Dim sql = "UPDATE Patient SET password='" & newPassword & "' where phoneNumber='" & phoneNumber & "'"

        Dim dbCommand As New OleDb.OleDbCommand
        dbCommand.ExecuteNonQuery()


    End Sub

End Module
