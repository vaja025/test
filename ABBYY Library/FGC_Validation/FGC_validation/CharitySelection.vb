﻿Imports System.Windows.Forms

Public Class CharitySelection

    Property CharityName As String
        Get
            Return txtName.Text
        End Get
        Set(ByVal value As String)
            txtName.Text = value
        End Set
    End Property

    Public Property Number() As String
        Get
            Return txtNumber.Text
        End Get
        Set(ByVal value As String)
            txtNumber.Text = value
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

    Public Property DataSource() As List(Of Charity)
        Get
            Return gvData.DataSource
        End Get
        Set(ByVal value As List(Of Charity))
            gvData.DataSource = New SortableBindingList(Of Charity)(value)
        End Set
    End Property

    Public ReadOnly Property DataItem As Charity
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
                Case "Name"
                    'c.Width = sender.Width * 0.4

                Case "Address"
                    'c.Width = sender.Width * 0.5

                Case "Number"
                    'c.Width = sender.Width * 0.1

                Case Else
                    columnsToRemove.Add(c.Name)

            End Select
        Next

        For Each c In columnsToRemove
            sender.Columns.Remove(c)
        Next

        sender.AutoResizeColumns(DataGridViewAutoSizeColumnMode.DisplayedCells)

    End Sub

    Private Sub gvData_Scroll(ByVal sender As DataGridView, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles gvData.Scroll
        sender.AutoResizeColumns(DataGridViewAutoSizeColumnMode.DisplayedCells)
    End Sub

    Private Sub TextHasChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.KeyUp, txtNumber.KeyUp
        gvData.DataSource = CharityItem.Search(txtName.Text, txtNumber.Text, False)
    End Sub

    Private Sub Selection_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtNumber.Focus()
    End Sub

    Private Sub binNumber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles binNumber.Click
        txtNumber.Text = String.Empty
        TextHasChanged(Nothing, Nothing)
    End Sub

    Private Sub binName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles binName.Click
        txtName.Text = String.Empty
        TextHasChanged(Nothing, Nothing)
    End Sub

End Class
