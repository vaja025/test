<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MemberSelection
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.gvData = New System.Windows.Forms.DataGridView()
        Me.grpFilter = New System.Windows.Forms.GroupBox()
        Me.lblHits = New System.Windows.Forms.Label()
        Me.binFirstname = New System.Windows.Forms.PictureBox()
        Me.binPostcode = New System.Windows.Forms.PictureBox()
        Me.binSurname = New System.Windows.Forms.PictureBox()
        Me.txtPostcode = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.lblPostcode = New System.Windows.Forms.Label()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.lblFirstname = New System.Windows.Forms.Label()
        Me.tmrTrigger = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFilter.SuspendLayout()
        CType(Me.binFirstname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.binPostcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.binSurname, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(836, 531)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'gvData
        '
        Me.gvData.AllowUserToAddRows = False
        Me.gvData.AllowUserToDeleteRows = False
        Me.gvData.AllowUserToResizeRows = False
        Me.gvData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvData.Location = New System.Drawing.Point(13, 112)
        Me.gvData.MultiSelect = False
        Me.gvData.Name = "gvData"
        Me.gvData.ReadOnly = True
        Me.gvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvData.Size = New System.Drawing.Size(969, 413)
        Me.gvData.TabIndex = 0
        '
        'grpFilter
        '
        Me.grpFilter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFilter.Controls.Add(Me.lblHits)
        Me.grpFilter.Controls.Add(Me.binFirstname)
        Me.grpFilter.Controls.Add(Me.binPostcode)
        Me.grpFilter.Controls.Add(Me.binSurname)
        Me.grpFilter.Controls.Add(Me.txtPostcode)
        Me.grpFilter.Controls.Add(Me.txtSurname)
        Me.grpFilter.Controls.Add(Me.lblPostcode)
        Me.grpFilter.Controls.Add(Me.txtFirstname)
        Me.grpFilter.Controls.Add(Me.lblSurname)
        Me.grpFilter.Controls.Add(Me.lblFirstname)
        Me.grpFilter.Location = New System.Drawing.Point(13, 13)
        Me.grpFilter.Name = "grpFilter"
        Me.grpFilter.Size = New System.Drawing.Size(969, 93)
        Me.grpFilter.TabIndex = 2
        Me.grpFilter.TabStop = False
        Me.grpFilter.Text = "Filter and Search"
        '
        'lblHits
        '
        Me.lblHits.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHits.AutoSize = True
        Me.lblHits.Location = New System.Drawing.Point(924, 68)
        Me.lblHits.Name = "lblHits"
        Me.lblHits.Size = New System.Drawing.Size(0, 13)
        Me.lblHits.TabIndex = 8
        '
        'binFirstname
        '
        Me.binFirstname.Image = Global.FGC_validation.My.Resources.Resources.bin
        Me.binFirstname.Location = New System.Drawing.Point(296, 60)
        Me.binFirstname.Name = "binFirstname"
        Me.binFirstname.Size = New System.Drawing.Size(16, 16)
        Me.binFirstname.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.binFirstname.TabIndex = 7
        Me.binFirstname.TabStop = False
        '
        'binPostcode
        '
        Me.binPostcode.Image = Global.FGC_validation.My.Resources.Resources.bin
        Me.binPostcode.Location = New System.Drawing.Point(651, 26)
        Me.binPostcode.Name = "binPostcode"
        Me.binPostcode.Size = New System.Drawing.Size(16, 16)
        Me.binPostcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.binPostcode.TabIndex = 6
        Me.binPostcode.TabStop = False
        '
        'binSurname
        '
        Me.binSurname.Image = Global.FGC_validation.My.Resources.Resources.bin
        Me.binSurname.Location = New System.Drawing.Point(296, 26)
        Me.binSurname.Name = "binSurname"
        Me.binSurname.Size = New System.Drawing.Size(16, 16)
        Me.binSurname.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.binSurname.TabIndex = 6
        Me.binSurname.TabStop = False
        '
        'txtPostcode
        '
        Me.txtPostcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPostcode.Location = New System.Drawing.Point(480, 22)
        Me.txtPostcode.Name = "txtPostcode"
        Me.txtPostcode.Size = New System.Drawing.Size(165, 26)
        Me.txtPostcode.TabIndex = 0
        '
        'txtSurname
        '
        Me.txtSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSurname.Location = New System.Drawing.Point(125, 22)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(165, 26)
        Me.txtSurname.TabIndex = 0
        '
        'lblPostcode
        '
        Me.lblPostcode.AutoSize = True
        Me.lblPostcode.Location = New System.Drawing.Point(382, 26)
        Me.lblPostcode.Name = "lblPostcode"
        Me.lblPostcode.Size = New System.Drawing.Size(52, 13)
        Me.lblPostcode.TabIndex = 1
        Me.lblPostcode.Text = "Postcode"
        '
        'txtFirstname
        '
        Me.txtFirstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstname.Location = New System.Drawing.Point(125, 56)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(165, 26)
        Me.txtFirstname.TabIndex = 1
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Location = New System.Drawing.Point(27, 26)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(49, 13)
        Me.lblSurname.TabIndex = 1
        Me.lblSurname.Text = "Surname"
        '
        'lblFirstname
        '
        Me.lblFirstname.AutoSize = True
        Me.lblFirstname.Location = New System.Drawing.Point(27, 60)
        Me.lblFirstname.Name = "lblFirstname"
        Me.lblFirstname.Size = New System.Drawing.Size(75, 13)
        Me.lblFirstname.TabIndex = 0
        Me.lblFirstname.Text = "Given name(s)"
        '
        'tmrTrigger
        '
        Me.tmrTrigger.Interval = 1000
        '
        'MemberSelection
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(994, 572)
        Me.Controls.Add(Me.grpFilter)
        Me.Controls.Add(Me.gvData)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MemberSelection"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Member Search"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFilter.ResumeLayout(False)
        Me.grpFilter.PerformLayout()
        CType(Me.binFirstname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.binPostcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.binSurname, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents gvData As System.Windows.Forms.DataGridView
    Friend WithEvents grpFilter As System.Windows.Forms.GroupBox
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstname As System.Windows.Forms.TextBox
    Friend WithEvents lblSurname As System.Windows.Forms.Label
    Friend WithEvents lblFirstname As System.Windows.Forms.Label
    Friend WithEvents binFirstname As System.Windows.Forms.PictureBox
    Friend WithEvents binSurname As System.Windows.Forms.PictureBox
    Friend WithEvents tmrTrigger As System.Windows.Forms.Timer
    Friend WithEvents binPostcode As System.Windows.Forms.PictureBox
    Friend WithEvents txtPostcode As System.Windows.Forms.TextBox
    Friend WithEvents lblPostcode As System.Windows.Forms.Label
    Friend WithEvents lblHits As System.Windows.Forms.Label

End Class
