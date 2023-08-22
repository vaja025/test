Imports System.IO
Imports System.Linq

Friend Class SettingsManager

    Private _Settings As New Settings
    Private _Filename As String

    Public Sub New(ByVal filename As String)
        _Filename = filename

        ' Check that the config file exists
        If File.Exists(_Filename) Then
            _Settings.ReadXml(_Filename)
        End If

    End Sub

    Public Function GetSetting(ByVal key As String) As String

        key = key.ToLower

        Try
            Dim results = From s In _Settings.SettingsTable Where s.Key.Equals(key)

            If results.Count = 0 Then
                ' The setting does not yet exist
                Try
                    Dim newSetting As String = PromptForNewSetting(key, 3)
                    PutSetting(key, newSetting)
                    Return newSetting

                Catch ex As Exception
                    Throw New Exception("Could not save a new setting for: " & key, ex)
                End Try

            Else
                Return results.First.Data

            End If

        Catch ex As Exception
            Throw New Exception("Could not return value for: " & key, ex)
        End Try

    End Function

    Private Function PromptForNewSetting(ByVal key As String, ByVal maxTries As Integer) As String
        ' Gets a new setting from the user
        Dim setting As String = String.Empty
        Dim tries As Integer = 0

        Do Until Not String.IsNullOrEmpty(setting)
            If tries > maxTries Then Throw New Exception("User exceeded the maximum number requests for the setting value")
            setting = InputBox("Please supply the missing setting value for: " & key, "Setting is missing", String.Empty)
            tries += 1
        Loop

        Return setting

    End Function

    Public Sub PutSetting(ByVal key As String, ByVal value As String)

        key = key.ToLower

        Dim setting = From s In _Settings.SettingsTable Where s.Key.Equals(key)

        Try
            If setting.Count.Equals(1) Then
                setting.First.Data = value
            Else
                Dim s As Settings.SettingsTableRow = _Settings.SettingsTable.NewRow
                s.Key = key
                s.Data = value
                _Settings.SettingsTable.AddSettingsTableRow(s)
            End If

            Me.Save()

        Catch ex As Exception
            Throw New Exception("Could not seve setting for: " & key, ex)
        End Try

    End Sub

    Private Sub Save()

        ' Check that the config file exists
        If Not File.Exists(_Filename) Then
            Dim myFile As FileStream = File.Create(_Filename)
            myFile.Close()
        End If

        ' Saves changes back to the settings file
        _Settings.WriteXml(_Filename)

    End Sub

End Class
