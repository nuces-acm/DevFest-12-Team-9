Module DoctorDAO

    Public Sub addDoctor(ByVal name As String, ByVal cnic As String, ByVal phoneNumber As String, _
                         ByVal address As String, ByVal email As String)

        Dim conn = DBConnection.connection


        Dim sql = "INSERT INTO DOCTOR(name,cnic,phoneNumber,address,email) VALUES " _
        & " ('" & name & "','" & cnic & "','" & phoneNumber & "','" & address & "','" & email & "') "

        Dim dbCommand As New OleDb.OleDbCommand(sql, conn)

        dbCommand.ExecuteNonQuery()

    End Sub

    Public Function getDoctors()

        Dim conn = DBConnection.connection

        Dim sql = "Select * from Doctor"

        Dim command As New OleDb.OleDbCommand(sql, conn)

        Dim rs = command.ExecuteReader

        rs.Read()

        Return rs(0)
        
    End Function

End Module
