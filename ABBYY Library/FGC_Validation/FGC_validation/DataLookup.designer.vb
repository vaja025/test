﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="FGC")>  _
Partial Public Class DataLookupDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.FGC_validation.My.MySettings.Default.FGCConnectionString, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property Charities() As System.Data.Linq.Table(Of Charity)
		Get
			Return Me.GetTable(Of Charity)
		End Get
	End Property
	
	Public ReadOnly Property Lodges() As System.Data.Linq.Table(Of Lodge)
		Get
			Return Me.GetTable(Of Lodge)
		End Get
	End Property
	
	Public ReadOnly Property Members() As System.Data.Linq.Table(Of Member)
		Get
			Return Me.GetTable(Of Member)
		End Get
	End Property
	
	Public ReadOnly Property Chests() As System.Data.Linq.Table(Of Chest)
		Get
			Return Me.GetTable(Of Chest)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.RC_CHARITY_LOOKUP")>  _
Partial Public Class Charity
	
	Private _CHARITY_NAME As String
	
	Private _ADDRESS As String
	
	Private _REGISTERED_CHARITY_NUMBER As String
	
	Private _CHARITY_CODE As String
	
	Private _CharityID As String
	
	Private _CharityAddressID As String
	
	Public Sub New()
		MyBase.New
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="CHARITY_NAME", Storage:="_CHARITY_NAME", DbType:="VarChar(100)")>  _
	Public Property Name() As String
		Get
			Return Me._CHARITY_NAME
		End Get
		Set
			If (String.Equals(Me._CHARITY_NAME, value) = false) Then
				Me._CHARITY_NAME = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="ADDRESS", Storage:="_ADDRESS", DbType:="VarChar(1000)")>  _
	Public Property Address() As String
		Get
			Return Me._ADDRESS
		End Get
		Set
			If (String.Equals(Me._ADDRESS, value) = false) Then
				Me._ADDRESS = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="REGISTERED_CHARITY_NUMBER", Storage:="_REGISTERED_CHARITY_NUMBER", DbType:="VarChar(50)")>  _
	Public Property RegNumber() As String
		Get
			Return Me._REGISTERED_CHARITY_NUMBER
		End Get
		Set
			If (String.Equals(Me._REGISTERED_CHARITY_NUMBER, value) = false) Then
				Me._REGISTERED_CHARITY_NUMBER = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="CHARITY_CODE", Storage:="_CHARITY_CODE", DbType:="VarChar(100)")>  _
	Public Property Number() As String
		Get
			Return Me._CHARITY_CODE
		End Get
		Set
			If (String.Equals(Me._CHARITY_CODE, value) = false) Then
				Me._CHARITY_CODE = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="Charity_Id", Storage:="_CharityID", CanBeNull:=false)>  _
	Public Property CharityID() As String
		Get
			Return Me._CharityID
		End Get
		Set
			If (String.Equals(Me._CharityID, value) = false) Then
				Me._CharityID = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="Charity_Address_Id", Storage:="_CharityAddressID", CanBeNull:=false)>  _
	Public Property CharityAddressID() As String
		Get
			Return Me._CharityAddressID
		End Get
		Set
			If (String.Equals(Me._CharityAddressID, value) = false) Then
				Me._CharityAddressID = value
			End If
		End Set
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.RC_LODGE_LOOKUP")>  _
Partial Public Class Lodge
	
	Private _MASONIC_ORG_CODE As String
	
	Private _ORG_NAME As String
	
	Private _PROVINCE As String
	
	Public Sub New()
		MyBase.New
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="MASONIC_ORG_CODE", Storage:="_MASONIC_ORG_CODE", DbType:="VarChar(100)")>  _
	Public Property Number() As String
		Get
			Return Me._MASONIC_ORG_CODE
		End Get
		Set
			If (String.Equals(Me._MASONIC_ORG_CODE, value) = false) Then
				Me._MASONIC_ORG_CODE = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="ORG_NAME", Storage:="_ORG_NAME", DbType:="VarChar(100)")>  _
	Public Property Name() As String
		Get
			Return Me._ORG_NAME
		End Get
		Set
			If (String.Equals(Me._ORG_NAME, value) = false) Then
				Me._ORG_NAME = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="PROVINCE", Storage:="_PROVINCE", DbType:="VarChar(100)")>  _
	Public Property Province() As String
		Get
			Return Me._PROVINCE
		End Get
		Set
			If (String.Equals(Me._PROVINCE, value) = false) Then
				Me._PROVINCE = value
			End If
		End Set
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.RC_MEMBER_LOOKUP")>  _
Partial Public Class Member
	
	Private _Title As String
	
	Private _Initials As String
	
	Private _Surname As String
	
	Private _Firstname As String
	
	Private _Postcode As String
	
	Private _Address1 As String
	
	Private _Address2 As String
	
	Private _Address3 As String
	
	Private _Address4 As String
	
	Private _Address5 As String
	
	Private _Blanket As String
	
	Private _DOB As String
	
	Private _MemberNumber As String
	
	Private _uSurname As String
	
	Private _uFirstname As String
	
	Public Sub New()
		MyBase.New
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="TITLE", Storage:="_Title", DbType:="VarChar(50)")>  _
	Public Property Title() As String
		Get
			Return Me._Title
		End Get
		Set
			If (String.Equals(Me._Title, value) = false) Then
				Me._Title = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="INITIALS", Storage:="_Initials", DbType:="VarChar(50)")>  _
	Public Property Initials() As String
		Get
			Return Me._Initials
		End Get
		Set
			If (String.Equals(Me._Initials, value) = false) Then
				Me._Initials = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="FAMILY_NAME", Storage:="_Surname", DbType:="VarChar(100)")>  _
	Public Property Surname() As String
		Get
			Return Me._Surname
		End Get
		Set
			If (String.Equals(Me._Surname, value) = false) Then
				Me._Surname = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="GIVEN_NAME", Storage:="_Firstname", DbType:="VarChar(200)")>  _
	Public Property Firstname() As String
		Get
			Return Me._Firstname
		End Get
		Set
			If (String.Equals(Me._Firstname, value) = false) Then
				Me._Firstname = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="POSTCODE", Storage:="_Postcode", DbType:="VarChar(50)")>  _
	Public Property Postcode() As String
		Get
			Return Me._Postcode
		End Get
		Set
			If (String.Equals(Me._Postcode, value) = false) Then
				Me._Postcode = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="ADDRESS1", Storage:="_Address1", DbType:="VarChar(500)")>  _
	Public Property Address1() As String
		Get
			Return Me._Address1
		End Get
		Set
			If (String.Equals(Me._Address1, value) = false) Then
				Me._Address1 = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="ADDRESS2", Storage:="_Address2", DbType:="VarChar(500)")>  _
	Public Property Address2() As String
		Get
			Return Me._Address2
		End Get
		Set
			If (String.Equals(Me._Address2, value) = false) Then
				Me._Address2 = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="ADDRESS3", Storage:="_Address3", DbType:="VarChar(500)")>  _
	Public Property Address3() As String
		Get
			Return Me._Address3
		End Get
		Set
			If (String.Equals(Me._Address3, value) = false) Then
				Me._Address3 = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="ADDRESS4", Storage:="_Address4", DbType:="VarChar(500)")>  _
	Public Property Address4() As String
		Get
			Return Me._Address4
		End Get
		Set
			If (String.Equals(Me._Address4, value) = false) Then
				Me._Address4 = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="ADDRESS5", Storage:="_Address5", DbType:="VarChar(500)")>  _
	Public Property Address5() As String
		Get
			Return Me._Address5
		End Get
		Set
			If (String.Equals(Me._Address5, value) = false) Then
				Me._Address5 = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="blanket_GA_decl_flag", Storage:="_Blanket", DbType:="VarChar(1)", CanBeNull:=false)>  _
	Public Property Blanket() As String
		Get
			Return Me._Blanket
		End Get
		Set
			If (String.Equals(Me._Blanket, value) = false) Then
				Me._Blanket = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_DOB", DbType:="Varchar(50)")>  _
	Public Property DOB() As String
		Get
			Return Me._DOB
		End Get
		Set
			If (String.Equals(Me._DOB, value) = false) Then
				Me._DOB = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="PER_NUM", Storage:="_MemberNumber", DbType:="VarChar(50)")>  _
	Public Property MemberNumber() As String
		Get
			Return Me._MemberNumber
		End Get
		Set
			If (String.Equals(Me._MemberNumber, value) = false) Then
				Me._MemberNumber = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="UPPER_FAMILY_NAME", Storage:="_uSurname", DbType:="VarChar(100)", CanBeNull:=false)>  _
	Public Property uSurname() As String
		Get
			Return Me._uSurname
		End Get
		Set
			If (String.Equals(Me._uSurname, value) = false) Then
				Me._uSurname = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="UPPER_GIVEN_NAME", Storage:="_uFirstname", DbType:="VarChar(200)", CanBeNull:=false)>  _
	Public Property uFirstname() As String
		Get
			Return Me._uFirstname
		End Get
		Set
			If (String.Equals(Me._uFirstname, value) = false) Then
				Me._uFirstname = value
			End If
		End Set
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.RC_CHEST_LOOKUP")>  _
Partial Public Class Chest
	
	Private _CHEST_ID As String
	
	Private _CHEST_NUMBER As String
	
	Private _CHEST_NAME As String
	
	Private _DATE_CREATED As System.Nullable(Of Date)
	
	Private _PROVINCE As String
	
	Public Sub New()
		MyBase.New
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CHEST_ID", DbType:="VarChar(100)")>  _
	Public Property CHEST_ID() As String
		Get
			Return Me._CHEST_ID
		End Get
		Set
			If (String.Equals(Me._CHEST_ID, value) = false) Then
				Me._CHEST_ID = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="CHEST_NUMBER", Storage:="_CHEST_NUMBER", DbType:="VarChar(100)")>  _
	Public Property Number() As String
		Get
			Return Me._CHEST_NUMBER
		End Get
		Set
			If (String.Equals(Me._CHEST_NUMBER, value) = false) Then
				Me._CHEST_NUMBER = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="CHEST_NAME", Storage:="_CHEST_NAME", DbType:="VarChar(100)")>  _
	Public Property Name() As String
		Get
			Return Me._CHEST_NAME
		End Get
		Set
			If (String.Equals(Me._CHEST_NAME, value) = false) Then
				Me._CHEST_NAME = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_DATE_CREATED", DbType:="DateTime")>  _
	Public Property DATE_CREATED() As System.Nullable(Of Date)
		Get
			Return Me._DATE_CREATED
		End Get
		Set
			If (Me._DATE_CREATED.Equals(value) = false) Then
				Me._DATE_CREATED = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="PROVINCE", Storage:="_PROVINCE", DbType:="VarChar(100)")>  _
	Public Property Province() As String
		Get
			Return Me._PROVINCE
		End Get
		Set
			If (String.Equals(Me._PROVINCE, value) = false) Then
				Me._PROVINCE = value
			End If
		End Set
	End Property
End Class
