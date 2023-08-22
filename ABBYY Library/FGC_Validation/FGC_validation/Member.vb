'Imports Oracle.ManagedDataAccess.Client
Imports System.IO
'Imports Oracle.DataAccess.Client
Imports System.Linq
Imports System.Net
Imports System.Xml.Serialization

Friend Class MemberItem

    Private _Firstname As String
    Public Property Firstname() As String
        Get
            Return _Firstname
        End Get
        Set(ByVal value As String)
            _Firstname = value
        End Set
    End Property

    Private _Surname As String
    Public Property Surname() As String
        Get
            Return _Surname
        End Get
        Set(ByVal value As String)
            _Surname = value
        End Set
    End Property

    Private _Postcode As String
    Public Property Postcode() As String
        Get
            Return _Postcode
        End Get
        Set(ByVal value As String)
            _Postcode = If(IsNothing(value), String.Empty, value)
        End Set
    End Property

    Private _Number As String
    Public Property Number() As String
        Get
            Return _Number
        End Get
        Set(ByVal value As String)
            _Number = value
        End Set
    End Property

    Private _Blanket As String
    Public Property Blanket() As String
        Get
            Return _Blanket
        End Get
        Set(ByVal value As String)
            _Blanket = value
        End Set
    End Property

    Public Function Validate(ByVal Firstname As String, ByVal Surname As String, ByVal Postcode As String, ByVal Silent As Boolean) As Boolean

        Dim result As List(Of Member) = Search(Firstname, Surname, Postcode, Silent)

        Using objForm As New MemberSelection

            If result.Count.Equals(1) Then
                ' Exact match found
                With result.First
                    Me.Firstname = .Firstname
                    Me.Surname = .Surname
                    Me.Postcode = .Postcode
                    Me.Number = .MemberNumber
                    Me.Blanket = .Blanket
                End With

                Return True
            ElseIf Not Silent Then
                ' There are either no matches or too many

                If result.Count.Equals(0) Then
                    ' Widen the search
                    result = Search(Firstname, Surname, Postcode, False)
                End If

                objForm.Firstname = Firstname
                objForm.Surname = Surname
                objForm.Postcode = Postcode

                objForm.DataSource = result
                objForm.ShowDialog()

                If objForm.DialogResult.Equals(Windows.Forms.DialogResult.OK) Then
                    If Not IsNothing(objForm.DataItem) Then
                        With objForm.DataItem
                            Me.Firstname = .Firstname
                            Me.Surname = .Surname
                            Me.Postcode = .Postcode
                            Me.Number = .MemberNumber
                            Me.Blanket = .Blanket
                        End With

                        Return True
                    End If
                Else
                    '2017-12-19 James E commented out for ticket http://support.c2s.co.uk/helpdesk/tickets/4421
                    'MsgBox("User cancelled search", MsgBoxStyle.Exclamation)
                End If
            End If
        End Using

        Return False

    End Function

    Friend Shared Function Search(ByVal Firstname As String,
                                  ByVal Surname As String,
                                  ByVal Postcode As String,
                                  Optional ByVal Exact As Boolean = True) As IEnumerable(Of Member)

        Dim results As New List(Of Member)

        Dim _firstname As String
        Dim _surname As String
        Dim _postcode As String

        If String.IsNullOrEmpty(Firstname) Then
            _firstname = ""
        Else
            _firstname = Uri.EscapeDataString(Firstname)
        End If

        If String.IsNullOrEmpty(Surname) Then
            _surname = ""
        Else
            _surname = Uri.EscapeDataString(Surname)
        End If

        If String.IsNullOrEmpty(Postcode) Then
            _postcode = ""
        Else
            _postcode = Uri.EscapeDataString(Postcode)
        End If


        'CreateObject Request
        Dim requestString As String = String.Format(New Abbyy().OracleLookupBaseUrl + "Member?apikey={0}&firstname={1}&surname={2}&postcode={3}&exact={4}&xml=True", New Abbyy().OracleLookupApiKey, _firstname, _surname, _postcode, Exact)
        Dim request As WebRequest = WebRequest.Create(requestString)
        request.Credentials = CredentialCache.DefaultCredentials

        'Get the response
        Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)

        'Get content returned by the server.
        Dim dataStream As Stream = response.GetResponseStream()
        ' Open the stream using a StreamReader for easy access.
        Dim reader As New StreamReader(dataStream)

        ' Read the content.
        ' Dim responseFromServer As String = reader.ReadToEnd()

        ' Do something with responseFromServer
        Dim serializer As New XmlSerializer(GetType(List(Of Member)))

        Try
            results = serializer.Deserialize(reader)
        Catch ex As Exception
            'System.IO.File.AppendAllText("C:\Click2Scan\OracleLookupRequests.Log", Environment.NewLine + ex.Message)

        End Try

        ' Cleanup
        reader.Close()
        dataStream.Close()
        response.Close()

        Return results
    End Function

End Class

