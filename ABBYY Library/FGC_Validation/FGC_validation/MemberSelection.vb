Imports System.Windows.Forms

Public Class MemberSelection

    Property Firstname As String
        Get
            Return txtFirstname.Text
        End Get
        Set(ByVal value As String)
            txtFirstname.Text = value
        End Set
    End Property

    Public Property Surname() As String
        Get
            Return txtSurname.Text
        End Get
        Set(ByVal value As String)
            txtSurname.Text = value
        End Set
    End Property

    Public Property Postcode As String
        Get
            Return txtPostcode.Text
        End Get
        Set(ByVal value As String)
            txtPostcode.Text = value
        End Set
    End Property

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click, gvData.DoubleClick

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click

        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()

    End Sub

    Public WriteOnly Property DataSource() As List(Of Member)
        Set(ByVal value As List(Of Member))
            gvData.DataSource = New SortableBindingList(Of Member)(value)
        End Set
    End Property

    Public ReadOnly Property DataItem As Member
        Get
            If gvData.SelectedRows.Count > 0 Then
                Return gvData.SelectedRows(0).DataBoundItem
            Else
                Return Nothing
            End If
        End Get
    End Property

    Private Sub gvData_DataBindingComplete(ByVal sender As DataGridView, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles gvData.DataBindingComplete

        Dim columnsToRemove As New List(Of String)

        For Each c As DataGridViewColumn In sender.Columns

            Select Case c.Name
                Case "Firstname"
                    'c.Width = sender.Width * 0.25

                Case "Surname"
                    'c.Width = sender.Width * 0.25

                Case "Postcode"
                    'c.Width = sender.Width * 0.2

                Case "MemberNumber"
                    'c.Width = sender.Width * 0.2

                Case "Address1"
                Case "Address2"
                Case "Address3"
                Case "DOB"
                Case "Blanket"
                    '
                Case Else
                    columnsToRemove.Add(c.Name)
            End Select
        Next

        For Each c In columnsToRemove
            sender.Columns.Remove(c)
        Next

        sender.AutoResizeColumns(DataGridViewAutoSizeColumnMode.DisplayedCells)

        lblHits.Text = gvData.Rows.Count

    End Sub

    Private Sub gvData_Scroll(ByVal sender As DataGridView, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles gvData.Scroll

        sender.AutoResizeColumns(DataGridViewAutoSizeColumnMode.DisplayedCells)

    End Sub

    Private Sub Selection_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        txtSurname.Focus()

    End Sub

    Private Sub binSurname_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles binSurname.Click

        txtSurname.Text = String.Empty
        TextHasChanged(Nothing, Nothing)

    End Sub

    Private Sub binFirstname_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles binFirstname.Click

        txtFirstname.Text = String.Empty
        TextHasChanged(Nothing, Nothing)

    End Sub

    Private Sub binPostcode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles binPostcode.Click

        txtPostcode.Text = String.Empty
        TextHasChanged(Nothing, Nothing)

    End Sub

    Private Sub TextHasChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFirstname.KeyUp, txtSurname.KeyUp, txtPostcode.KeyUp

        tmrTrigger.Start()

    End Sub

    Private Sub tmrTrigger_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrTrigger.Tick

        tmrTrigger.Stop()
        Me.DataSource = MemberItem.Search(txtFirstname.Text, txtSurname.Text, txtPostcode.Text, False)

    End Sub

End Class

