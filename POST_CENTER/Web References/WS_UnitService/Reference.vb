﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
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
'This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
'
Namespace WS_UnitService
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="UnitServiceSoap", [Namespace]:="http://tempuri.org/")>  _
    Partial Public Class UnitService
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        Private UnitDetailOperationCompleted As System.Threading.SendOrPostCallback
        
        Private UnitListOperationCompleted As System.Threading.SendOrPostCallback
        
        Private UnitListByUnitCatalogOperationCompleted As System.Threading.SendOrPostCallback
        
        Private UnitListByUnitLevelOperationCompleted As System.Threading.SendOrPostCallback
        
        Private UnitListByOriginsOperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = Global.POST_CENTER.My.MySettings.Default.POST_CENTER_WS_UnitService_UnitService
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
        Public Event UnitDetailCompleted As UnitDetailCompletedEventHandler
        
        '''<remarks/>
        Public Event UnitListCompleted As UnitListCompletedEventHandler
        
        '''<remarks/>
        Public Event UnitListByUnitCatalogCompleted As UnitListByUnitCatalogCompletedEventHandler
        
        '''<remarks/>
        Public Event UnitListByUnitLevelCompleted As UnitListByUnitLevelCompletedEventHandler
        
        '''<remarks/>
        Public Event UnitListByOriginsCompleted As UnitListByOriginsCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/UnitDetail", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function UnitDetail(ByVal UnitID As Integer) As UnitXML
            Dim results() As Object = Me.Invoke("UnitDetail", New Object() {UnitID})
            Return CType(results(0),UnitXML)
        End Function
        
        '''<remarks/>
        Public Overloads Sub UnitDetailAsync(ByVal UnitID As Integer)
            Me.UnitDetailAsync(UnitID, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub UnitDetailAsync(ByVal UnitID As Integer, ByVal userState As Object)
            If (Me.UnitDetailOperationCompleted Is Nothing) Then
                Me.UnitDetailOperationCompleted = AddressOf Me.OnUnitDetailOperationCompleted
            End If
            Me.InvokeAsync("UnitDetail", New Object() {UnitID}, Me.UnitDetailOperationCompleted, userState)
        End Sub
        
        Private Sub OnUnitDetailOperationCompleted(ByVal arg As Object)
            If (Not (Me.UnitDetailCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent UnitDetailCompleted(Me, New UnitDetailCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/UnitList", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function UnitList() As UnitXML()
            Dim results() As Object = Me.Invoke("UnitList", New Object(-1) {})
            Return CType(results(0),UnitXML())
        End Function
        
        '''<remarks/>
        Public Overloads Sub UnitListAsync()
            Me.UnitListAsync(Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub UnitListAsync(ByVal userState As Object)
            If (Me.UnitListOperationCompleted Is Nothing) Then
                Me.UnitListOperationCompleted = AddressOf Me.OnUnitListOperationCompleted
            End If
            Me.InvokeAsync("UnitList", New Object(-1) {}, Me.UnitListOperationCompleted, userState)
        End Sub
        
        Private Sub OnUnitListOperationCompleted(ByVal arg As Object)
            If (Not (Me.UnitListCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent UnitListCompleted(Me, New UnitListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/UnitListByUnitCatalog", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function UnitListByUnitCatalog(ByVal UnitCatalog As Integer) As UnitXML()
            Dim results() As Object = Me.Invoke("UnitListByUnitCatalog", New Object() {UnitCatalog})
            Return CType(results(0),UnitXML())
        End Function
        
        '''<remarks/>
        Public Overloads Sub UnitListByUnitCatalogAsync(ByVal UnitCatalog As Integer)
            Me.UnitListByUnitCatalogAsync(UnitCatalog, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub UnitListByUnitCatalogAsync(ByVal UnitCatalog As Integer, ByVal userState As Object)
            If (Me.UnitListByUnitCatalogOperationCompleted Is Nothing) Then
                Me.UnitListByUnitCatalogOperationCompleted = AddressOf Me.OnUnitListByUnitCatalogOperationCompleted
            End If
            Me.InvokeAsync("UnitListByUnitCatalog", New Object() {UnitCatalog}, Me.UnitListByUnitCatalogOperationCompleted, userState)
        End Sub
        
        Private Sub OnUnitListByUnitCatalogOperationCompleted(ByVal arg As Object)
            If (Not (Me.UnitListByUnitCatalogCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent UnitListByUnitCatalogCompleted(Me, New UnitListByUnitCatalogCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/UnitListByUnitLevel", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function UnitListByUnitLevel(ByVal UnitLevel As Integer) As UnitXML()
            Dim results() As Object = Me.Invoke("UnitListByUnitLevel", New Object() {UnitLevel})
            Return CType(results(0),UnitXML())
        End Function
        
        '''<remarks/>
        Public Overloads Sub UnitListByUnitLevelAsync(ByVal UnitLevel As Integer)
            Me.UnitListByUnitLevelAsync(UnitLevel, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub UnitListByUnitLevelAsync(ByVal UnitLevel As Integer, ByVal userState As Object)
            If (Me.UnitListByUnitLevelOperationCompleted Is Nothing) Then
                Me.UnitListByUnitLevelOperationCompleted = AddressOf Me.OnUnitListByUnitLevelOperationCompleted
            End If
            Me.InvokeAsync("UnitListByUnitLevel", New Object() {UnitLevel}, Me.UnitListByUnitLevelOperationCompleted, userState)
        End Sub
        
        Private Sub OnUnitListByUnitLevelOperationCompleted(ByVal arg As Object)
            If (Not (Me.UnitListByUnitLevelCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent UnitListByUnitLevelCompleted(Me, New UnitListByUnitLevelCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/UnitListByOrigins", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function UnitListByOrigins() As UnitXML()
            Dim results() As Object = Me.Invoke("UnitListByOrigins", New Object(-1) {})
            Return CType(results(0),UnitXML())
        End Function
        
        '''<remarks/>
        Public Overloads Sub UnitListByOriginsAsync()
            Me.UnitListByOriginsAsync(Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub UnitListByOriginsAsync(ByVal userState As Object)
            If (Me.UnitListByOriginsOperationCompleted Is Nothing) Then
                Me.UnitListByOriginsOperationCompleted = AddressOf Me.OnUnitListByOriginsOperationCompleted
            End If
            Me.InvokeAsync("UnitListByOrigins", New Object(-1) {}, Me.UnitListByOriginsOperationCompleted, userState)
        End Sub
        
        Private Sub OnUnitListByOriginsOperationCompleted(ByVal arg As Object)
            If (Not (Me.UnitListByOriginsCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent UnitListByOriginsCompleted(Me, New UnitListByOriginsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
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
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3190.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class UnitXML
        
        Private unitIDField As Integer
        
        Private unitNameField As String
        
        Private unitFullNameField As String
        
        Private unitTHFullNameField As String
        
        Private unitENFullNameField As String
        
        Private unitCatalogField() As Integer
        
        Private unitOriginField As Integer
        
        Private uninLevelField As Integer
        
        '''<remarks/>
        Public Property UnitID() As Integer
            Get
                Return Me.unitIDField
            End Get
            Set
                Me.unitIDField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property UnitName() As String
            Get
                Return Me.unitNameField
            End Get
            Set
                Me.unitNameField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property UnitFullName() As String
            Get
                Return Me.unitFullNameField
            End Get
            Set
                Me.unitFullNameField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property UnitTHFullName() As String
            Get
                Return Me.unitTHFullNameField
            End Get
            Set
                Me.unitTHFullNameField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property UnitENFullName() As String
            Get
                Return Me.unitENFullNameField
            End Get
            Set
                Me.unitENFullNameField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property UnitCatalog() As Integer()
            Get
                Return Me.unitCatalogField
            End Get
            Set
                Me.unitCatalogField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property UnitOrigin() As Integer
            Get
                Return Me.unitOriginField
            End Get
            Set
                Me.unitOriginField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property UninLevel() As Integer
            Get
                Return Me.uninLevelField
            End Get
            Set
                Me.uninLevelField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")>  _
    Public Delegate Sub UnitDetailCompletedEventHandler(ByVal sender As Object, ByVal e As UnitDetailCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class UnitDetailCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As UnitXML
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),UnitXML)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")>  _
    Public Delegate Sub UnitListCompletedEventHandler(ByVal sender As Object, ByVal e As UnitListCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class UnitListCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As UnitXML()
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),UnitXML())
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")>  _
    Public Delegate Sub UnitListByUnitCatalogCompletedEventHandler(ByVal sender As Object, ByVal e As UnitListByUnitCatalogCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class UnitListByUnitCatalogCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As UnitXML()
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),UnitXML())
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")>  _
    Public Delegate Sub UnitListByUnitLevelCompletedEventHandler(ByVal sender As Object, ByVal e As UnitListByUnitLevelCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class UnitListByUnitLevelCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As UnitXML()
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),UnitXML())
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")>  _
    Public Delegate Sub UnitListByOriginsCompletedEventHandler(ByVal sender As Object, ByVal e As UnitListByOriginsCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class UnitListByOriginsCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As UnitXML()
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),UnitXML())
            End Get
        End Property
    End Class
End Namespace
