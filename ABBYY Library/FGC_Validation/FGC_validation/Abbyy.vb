Imports System
Imports System.Runtime.InteropServices

<ComClass(Abbyy.ClassId, Abbyy.InterfaceId, Abbyy.EventsId)> _
Public Class Abbyy
    Implements IDisposable

#Region "COM GUIDs"
    ' These  GUIDs provide the COM identity for this class 
    ' and its COM interfaces. If you change them, existing 
    ' clients will no longer be able to access the class.
    Public Const ClassId As String = "119fbba5-961e-43f1-ac61-da2247be1466"
    Public Const InterfaceId As String = "0b97565c-aa85-4fed-bef0-0323cca030a8"
    Public Const EventsId As String = "e5d14377-8128-4376-8947-92d86ed64d49"
#End Region

#Region "Settings"
    Private _filename As String = "c:\Click2Scan\FGC-Validation_Settings.xml"

    Public OracleLookupBaseUrl As String = "http://MCFFD-APP:10000/OracleLookup/" 'Include / at the end of any adjustments
    Public OracleLookupApiKey As String = "060077b8-596a-11eb-ae93-0242ac130002" 'Include / at the end of any adjustments

    Public Function GetSetting(ByVal key As String) As String
        Dim s As New SettingsManager(_filename)
        Return s.GetSetting(key)
    End Function

    Public Sub PutSetting(ByVal key As String, ByVal value As String)
        Dim s As New SettingsManager(_filename)
        s.PutSetting(key, value)
    End Sub

#End Region

#Region "Member"
    Private _Member As New MemberItem

    Public ReadOnly Property mFirstname As String
        Get
            Return _Member.Firstname
        End Get
    End Property

    Public ReadOnly Property mSurname As String
        Get
            Return _Member.Surname
        End Get
    End Property

    Public ReadOnly Property mPostcode As String
        Get
            Return _Member.Postcode
        End Get
    End Property

    Public ReadOnly Property mPostcode1 As String
        Get

            Dim Postcode As String = _Member.Postcode.Trim.Replace("  ", " ")
            Return If(Not String.IsNullOrEmpty(Postcode), Postcode.Split(" ")(0), String.Empty)
        End Get
    End Property

    Public ReadOnly Property mPostcode2 As String
        Get
            Dim Postcode As String = _Member.Postcode.Trim.Replace("  ", " ")
            Return If(Not String.IsNullOrEmpty(Postcode) AndAlso Postcode.Contains(" "), Postcode.Split(" ")(1), String.Empty)
        End Get
    End Property

    Public ReadOnly Property mMemberNumber As String
        Get
            Return _Member.Number
        End Get
    End Property

    Public ReadOnly Property mBlanket As String
        Get
            Return _Member.Blanket
        End Get
    End Property

    Public Function ValidateMember(ByVal Firstname As String, ByVal Surname As String, ByVal PostCode As String, Optional ByVal Silent As Boolean = True) As Boolean

        Dim m As New MemberItem
        Dim Result As Boolean

        Result = m.Validate(Firstname.Trim, Surname.Trim, PostCode.Trim, Silent)

        ' Retain the data item
        _Member = m

        Return Result

    End Function

#End Region

#Region "Lodge"
    Private _Lodge As New LodgeItem

    Public ReadOnly Property lNumber As String
        Get
            Return _Lodge.Number
        End Get
    End Property

    Public ReadOnly Property lName As String
        Get
            Return _Lodge.Name
        End Get
    End Property

    Public ReadOnly Property lProvince As String
        Get
            Return _Lodge.Province
        End Get
    End Property

    Public Function ValidateLodge(ByVal Name As String, ByVal Number As String, Optional ByVal CheckOnly As Boolean = True) As Boolean

        Dim l As New LodgeItem
        Dim Result As Boolean

        Result = l.Validate(Name, Number, CheckOnly)

        ' Retain the data item
        _Lodge = l

        Return Result

    End Function
#End Region

#Region "Chest"
    Private _Chest As New ChestItem

    Public ReadOnly Property cNumber As String
        Get
            Return _Chest.Number
        End Get
    End Property

    Public ReadOnly Property cName As String
        Get
            Return _Chest.Name
        End Get
    End Property

    Public ReadOnly Property cProvince As String
        Get
            Return _Chest.Province
        End Get
    End Property

    Public Function ValidateChest(ByVal Name As String, ByVal Number As String, Optional ByVal CheckOnly As Boolean = True) As Boolean

        Dim Result As Boolean
        Dim c As New ChestItem

        c.Name = Name
        c.Number = Number
        Result = c.Validate(CheckOnly)

        ' Retain the data item
        _Chest = c

        Return Result

    End Function
#End Region

#Region "Charity"
    Private _Charity As New CharityItem

    Public ReadOnly Property chaName As String
        Get
            Return _Charity.Name
        End Get
    End Property

    Public ReadOnly Property chaNumber As String
        Get
            Return _Charity.Number
        End Get
    End Property

    Public ReadOnly Property chaID As String
        Get
            Return _Charity.CharityID
        End Get
    End Property

    Public ReadOnly Property chaAddID As String
        Get
            Return _Charity.CharityAddressID
        End Get
    End Property

    Public Function ValidateCharity(ByVal Name As String, ByVal Number As String, Optional ByVal CheckOnly As Boolean = True) As Boolean

        Dim Result As Boolean
        Dim c As New CharityItem

        c.Name = Name
        c.Number = Number
        Result = c.Validate(CheckOnly)

        ' Retain the data item
        _Charity = c

        Return Result

    End Function

#End Region

    Public Sub New()
        MyBase.New()
    End Sub

    Public Function Echo(ByVal input As String) As String
        Return String.Format("Echo: {0}, the time now is {1}", input, Now.ToString("HH:mm:ss"))
    End Function

    Public Function GenerateURN(ByVal Seed As String) As String
        Return String.Format("{0}_{1}_{2}", Seed, Environment.UserName, (System.Guid.NewGuid).ToString)
    End Function

    Public Property ConnectionString As String
        Get
            Return My.Settings.FGCConnectionString
        End Get
        Set(ByVal value As String)
            My.Settings.SetUserOverride("FGCConnectionString", value)
            My.Settings.Save()
        End Set
    End Property

#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                _Member = Nothing
                _Lodge = Nothing
                _Chest = Nothing
                _Charity = Nothing
            End If
        End If
        Me.disposedValue = True
    End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class
