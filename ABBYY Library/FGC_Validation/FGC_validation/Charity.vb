'Imports Oracle.ManagedDataAccess.Client
Imports System.IO
'Imports Oracle.DataAccess.Client
Imports System.Linq
Imports System.Net
Imports System.Xml.Serialization

Friend Class CharityItem

    Private _Name As String
    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
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

    Private _CharityID As String
    Public Property CharityID() As String
        Get
            Return _CharityID
        End Get
        Set(ByVal value As String)
            _CharityID = value
        End Set
    End Property

    Private _CharityAddressID As String
    Public Property CharityAddressID() As String
        Get
            Return _CharityAddressID
        End Get
        Set(ByVal value As String)
            _CharityAddressID = value
        End Set
    End Property

    Public Function Validate(ByVal CheckOnly As Boolean) As Boolean

        Dim items As List(Of Charity) = Search(Me.Name, Me.Number)

        Using objForm As New CharitySelection

            If items.Count.Equals(1) Then
                ' Exact match found
                With items.First
                    Me.Name = .Name
                    Me.Number = .Number
                    Me.CharityID = .CharityID
                    Me.CharityAddressID = .CharityAddressID
                End With
                Return True

            ElseIf Not CheckOnly Then
                ' There are either no matches or many

                If items.Count.Equals(0) Then
                    ' Widen the search
                    items = Search(Me.Name, Me.Number, False)
                End If

                objForm.CharityName = Me.Name
                objForm.Number = Me.Number

                objForm.DataSource = items
                objForm.ShowDialog()

                If objForm.DialogResult.Equals(Windows.Forms.DialogResult.OK) Then
                    If Not IsNothing(objForm.DataItem) Then

                        With objForm.DataItem
                            Me.Name = .Name
                            Me.Number = .Number
                            Me.CharityID = .CharityID
                            Me.CharityAddressID = .CharityAddressID
                        End With

                        Return True
                    End If
                End If

            End If

        End Using

        Return False

    End Function

    Friend Shared Function Search(ByVal Name As String,
                                  ByVal Number As String,
                                  Optional ByVal Exact As Boolean = True) As List(Of Charity)

        Dim results As New List(Of Charity)

        'Null Checks
        Dim _name As String
        Dim _number As String


        If String.IsNullOrEmpty(Name) Then
            _name = ""
        Else
            _name = Uri.EscapeDataString(Name)
        End If

        If String.IsNullOrEmpty(Number) Then
            _number = ""
        Else
            _number = Uri.EscapeDataString(Number)
        End If


        'CreateObject Request
        Dim requestString As String = String.Format(New Abbyy().OracleLookupBaseUrl + "Charity?apikey={0}&name={1}&number={2}&exact={3}&xml=True", New Abbyy().OracleLookupApiKey, _name, _number, Exact)

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
        Dim serializer As New XmlSerializer(GetType(List(Of Charity)))

        Try
            results = serializer.Deserialize(reader)
        Catch ex As Exception

        End Try

        ' Cleanup
        reader.Close()
        dataStream.Close()
        response.Close()

        Return results
    End Function


End Class

