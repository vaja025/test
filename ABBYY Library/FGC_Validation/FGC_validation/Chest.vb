'Imports Oracle.ManagedDataAccess.Client
Imports System.IO
'Imports Oracle.DataAccess.Client
Imports System.Linq
Imports System.Net
Imports System.Xml.Serialization

Friend Class ChestItem

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

    Private _Province As String
    Public Property Province() As String
        Get
            Return _Province
        End Get
        Set(ByVal value As String)
            _Province = value
        End Set
    End Property

    Public Function Validate(ByVal CheckOnly As Boolean) As Boolean

        Dim items As List(Of Chest) = Search(Me.Name, Me.Number, Me.Province)

        Using objForm As New ChestSelection
            If items.Count.Equals(1) Then
                ' Exact match found
                With items.First
                    Me.Name = .Name
                    Me.Number = .Number
                    Me.Province = .Province
                End With
                Return True
            ElseIf Not CheckOnly Then
                ' There are either no matches or many

                If items.Count.Equals(0) Then
                    ' Widen the search
                    items = Search(Me.Name, Me.Number, Me.Province, False)
                End If

                objForm.ChestName = Me.Name
                objForm.Number = Me.Number
                objForm.Province = Me.Province

                objForm.DataSource = items
                objForm.ShowDialog()

                If objForm.DialogResult.Equals(Windows.Forms.DialogResult.OK) Then
                    If Not IsNothing(objForm.DataItem) Then

                        With objForm.DataItem
                            Me.Name = .Name
                            Me.Number = .Number
                            Me.Province = .Province
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
                                  ByVal Province As String,
                                  Optional ByVal Exact As Boolean = True) As List(Of Chest)

        Dim results As New List(Of Chest)

        'Null Checks
        Dim _name As String
        Dim _number As String
        Dim _province As String


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

        If String.IsNullOrEmpty(Province) Then
            _province = ""
        Else
            _province = Uri.EscapeDataString(Province)
        End If


        'CreateObject Request
        Dim requestString As String = String.Format(New Abbyy().OracleLookupBaseUrl + "Chest?apikey={0}&name={1}&number={2}&province={3}&exact={4}&xml=True", New Abbyy().OracleLookupApiKey, _name, _number, _province, Exact)
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
        Dim serializer As New XmlSerializer(GetType(List(Of Chest)))

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

