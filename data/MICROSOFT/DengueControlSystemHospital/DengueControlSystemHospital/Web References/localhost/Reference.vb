﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.261
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml.Serialization

'
'This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.261.
'
Namespace localhost
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="Service1Soap", [Namespace]:="http://tempuri.org/")>  _
    Partial Public Class Service1
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        Private addDoctorOperationCompleted As System.Threading.SendOrPostCallback
        
        Private addPatientOperationCompleted As System.Threading.SendOrPostCallback
        
        Private loginOperationCompleted As System.Threading.SendOrPostCallback
        
        Private changePasswordOperationCompleted As System.Threading.SendOrPostCallback
        
        Private getDoctorsOperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = Global.DengueControlSystemHospital.MySettings.Default.DengueControlSystemHospital_localhost_Service1
            If (Me.IsLocalFileSystemWebService(Me.Url) = true) Then
                Me.UseDefaultCredentials = true
                Me.useDefaultCredentialsSetExplicitly = false
            Else
                Me.useDefaultCredentialsSetExplicitly = true
            End If
        End Sub
        
        Public Shadows Property Url() As String
            Get
                Return MyBase.Url
            End Get
            Set
                If (((Me.IsLocalFileSystemWebService(MyBase.Url) = true)  _
                            AndAlso (Me.useDefaultCredentialsSetExplicitly = false))  _
                            AndAlso (Me.IsLocalFileSystemWebService(value) = false)) Then
                    MyBase.UseDefaultCredentials = false
                End If
                MyBase.Url = value
            End Set
        End Property
        
        Public Shadows Property UseDefaultCredentials() As Boolean
            Get
                Return MyBase.UseDefaultCredentials
            End Get
            Set
                MyBase.UseDefaultCredentials = value
                Me.useDefaultCredentialsSetExplicitly = true
            End Set
        End Property
        
        '''<remarks/>
        Public Event addDoctorCompleted As addDoctorCompletedEventHandler
        
        '''<remarks/>
        Public Event addPatientCompleted As addPatientCompletedEventHandler
        
        '''<remarks/>
        Public Event loginCompleted As loginCompletedEventHandler
        
        '''<remarks/>
        Public Event changePasswordCompleted As changePasswordCompletedEventHandler
        
        '''<remarks/>
        Public Event getDoctorsCompleted As getDoctorsCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/addDoctor", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function addDoctor(ByVal name As String, ByVal cnic As String, ByVal phoneNumber As String, ByVal address As String, ByVal email As String) As String
            Dim results() As Object = Me.Invoke("addDoctor", New Object() {name, cnic, phoneNumber, address, email})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub addDoctorAsync(ByVal name As String, ByVal cnic As String, ByVal phoneNumber As String, ByVal address As String, ByVal email As String)
            Me.addDoctorAsync(name, cnic, phoneNumber, address, email, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub addDoctorAsync(ByVal name As String, ByVal cnic As String, ByVal phoneNumber As String, ByVal address As String, ByVal email As String, ByVal userState As Object)
            If (Me.addDoctorOperationCompleted Is Nothing) Then
                Me.addDoctorOperationCompleted = AddressOf Me.OnaddDoctorOperationCompleted
            End If
            Me.InvokeAsync("addDoctor", New Object() {name, cnic, phoneNumber, address, email}, Me.addDoctorOperationCompleted, userState)
        End Sub
        
        Private Sub OnaddDoctorOperationCompleted(ByVal arg As Object)
            If (Not (Me.addDoctorCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent addDoctorCompleted(Me, New addDoctorCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/addPatient", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function addPatient(ByVal name As String, ByVal cnic As String, ByVal phoneNumber As String, ByVal address As String, ByVal email As String, ByVal password As String) As Object
            Dim results() As Object = Me.Invoke("addPatient", New Object() {name, cnic, phoneNumber, address, email, password})
            Return CType(results(0),Object)
        End Function
        
        '''<remarks/>
        Public Overloads Sub addPatientAsync(ByVal name As String, ByVal cnic As String, ByVal phoneNumber As String, ByVal address As String, ByVal email As String, ByVal password As String)
            Me.addPatientAsync(name, cnic, phoneNumber, address, email, password, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub addPatientAsync(ByVal name As String, ByVal cnic As String, ByVal phoneNumber As String, ByVal address As String, ByVal email As String, ByVal password As String, ByVal userState As Object)
            If (Me.addPatientOperationCompleted Is Nothing) Then
                Me.addPatientOperationCompleted = AddressOf Me.OnaddPatientOperationCompleted
            End If
            Me.InvokeAsync("addPatient", New Object() {name, cnic, phoneNumber, address, email, password}, Me.addPatientOperationCompleted, userState)
        End Sub
        
        Private Sub OnaddPatientOperationCompleted(ByVal arg As Object)
            If (Not (Me.addPatientCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent addPatientCompleted(Me, New addPatientCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/login", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function login(ByVal phoneNumber As String, ByVal password As String) As Object
            Dim results() As Object = Me.Invoke("login", New Object() {phoneNumber, password})
            Return CType(results(0),Object)
        End Function
        
        '''<remarks/>
        Public Overloads Sub loginAsync(ByVal phoneNumber As String, ByVal password As String)
            Me.loginAsync(phoneNumber, password, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub loginAsync(ByVal phoneNumber As String, ByVal password As String, ByVal userState As Object)
            If (Me.loginOperationCompleted Is Nothing) Then
                Me.loginOperationCompleted = AddressOf Me.OnloginOperationCompleted
            End If
            Me.InvokeAsync("login", New Object() {phoneNumber, password}, Me.loginOperationCompleted, userState)
        End Sub
        
        Private Sub OnloginOperationCompleted(ByVal arg As Object)
            If (Not (Me.loginCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent loginCompleted(Me, New loginCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/changePassword", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function changePassword(ByVal phoneNumber As String, ByVal newPassword As String, ByVal password As String) As Object
            Dim results() As Object = Me.Invoke("changePassword", New Object() {phoneNumber, newPassword, password})
            Return CType(results(0),Object)
        End Function
        
        '''<remarks/>
        Public Overloads Sub changePasswordAsync(ByVal phoneNumber As String, ByVal newPassword As String, ByVal password As String)
            Me.changePasswordAsync(phoneNumber, newPassword, password, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub changePasswordAsync(ByVal phoneNumber As String, ByVal newPassword As String, ByVal password As String, ByVal userState As Object)
            If (Me.changePasswordOperationCompleted Is Nothing) Then
                Me.changePasswordOperationCompleted = AddressOf Me.OnchangePasswordOperationCompleted
            End If
            Me.InvokeAsync("changePassword", New Object() {phoneNumber, newPassword, password}, Me.changePasswordOperationCompleted, userState)
        End Sub
        
        Private Sub OnchangePasswordOperationCompleted(ByVal arg As Object)
            If (Not (Me.changePasswordCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent changePasswordCompleted(Me, New changePasswordCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getDoctors", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function getDoctors() As Object
            Dim results() As Object = Me.Invoke("getDoctors", New Object(-1) {})
            Return CType(results(0),Object)
        End Function
        
        '''<remarks/>
        Public Overloads Sub getDoctorsAsync()
            Me.getDoctorsAsync(Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub getDoctorsAsync(ByVal userState As Object)
            If (Me.getDoctorsOperationCompleted Is Nothing) Then
                Me.getDoctorsOperationCompleted = AddressOf Me.OngetDoctorsOperationCompleted
            End If
            Me.InvokeAsync("getDoctors", New Object(-1) {}, Me.getDoctorsOperationCompleted, userState)
        End Sub
        
        Private Sub OngetDoctorsOperationCompleted(ByVal arg As Object)
            If (Not (Me.getDoctorsCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent getDoctorsCompleted(Me, New getDoctorsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        Public Shadows Sub CancelAsync(ByVal userState As Object)
            MyBase.CancelAsync(userState)
        End Sub
        
        Private Function IsLocalFileSystemWebService(ByVal url As String) As Boolean
            If ((url Is Nothing)  _
                        OrElse (url Is String.Empty)) Then
                Return false
            End If
            Dim wsUri As System.Uri = New System.Uri(url)
            If ((wsUri.Port >= 1024)  _
                        AndAlso (String.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) = 0)) Then
                Return true
            End If
            Return false
        End Function
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")>  _
    Public Delegate Sub addDoctorCompletedEventHandler(ByVal sender As Object, ByVal e As addDoctorCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class addDoctorCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")>  _
    Public Delegate Sub addPatientCompletedEventHandler(ByVal sender As Object, ByVal e As addPatientCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class addPatientCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As Object
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Object)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")>  _
    Public Delegate Sub loginCompletedEventHandler(ByVal sender As Object, ByVal e As loginCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class loginCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As Object
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Object)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")>  _
    Public Delegate Sub changePasswordCompletedEventHandler(ByVal sender As Object, ByVal e As changePasswordCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class changePasswordCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As Object
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Object)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")>  _
    Public Delegate Sub getDoctorsCompletedEventHandler(ByVal sender As Object, ByVal e As getDoctorsCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class getDoctorsCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As Object
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Object)
            End Get
        End Property
    End Class
End Namespace