Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
<System.Web.Script.Services.ScriptService()>
Public Class Service1
    Inherits System.Web.Services.WebService

    <WebMethod()> _
    Public Function addDoctor(ByVal name As String, ByVal cnic As String, ByVal phoneNumber As String, _
        ByVal address As String, ByVal email As String) As String

        Try

            DoctorDAO.addDoctor(name, cnic, phoneNumber, address, email)

            Return "PASS"
        Catch ex As Exception
            Return "FAIL: " + ex.Message + "   ," + ex.StackTrace
        End Try

    End Function


    <WebMethod()> _
    Public Function addPatient(ByVal name As String, ByVal cnic As String, ByVal phoneNumber As String, ByVal address As String _
        , ByVal email As String, ByVal password As String)

        Try

            PatientDAO.addPatient(name, cnic, phoneNumber, address, email, password)

            Return "PASS"
        Catch ex As Exception
            Return "FAIL: " & ex.Message
        End Try

    End Function

    <WebMethod()> _
    Public Function login(ByVal phoneNumber As String, ByVal password As String)
        Try

            If PatientDAO.login(phoneNumber, password).Equals("PASS") Then
                Return "PASS"
            Else
                Return "FAIL"
            End If

        Catch ex As Exception
            Return "FAIL: " & ex.Message
        End Try

    End Function


    <WebMethod()>
    Public Function changePassword(ByVal phoneNumber As String, ByVal newPassword As String, ByVal password As String)

        Try
            PatientDAO.changePassword(phoneNumber, newPassword, password)

            Return "PASS"
        Catch ex As Exception
            Return "FAIL"
        End Try

    End Function


    <WebMethod()>
    Public Function getDoctors()

        Return DoctorDAO.getDoctors()

    End Function

End Class