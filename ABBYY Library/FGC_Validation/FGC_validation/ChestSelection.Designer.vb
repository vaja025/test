<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChestSelection
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.gvData = New System.Windows.Forms.DataGridView()
        Me.grpFilter = New System.Windows.Forms.GroupBox()
        Me.binName = New System.Windows.Forms.PictureBox()
        Me.binNumber = New System.Windows.Forms.PictureBox()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.binProvince = New System.Windows.Forms.PictureBox()
        Me.provinceText = New System.Windows.Forms.TextBox()
        Me.provinceLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFilter.SuspendLayout()
        CType(Me.binName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.binNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.binProvince, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(1394, 844)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(292, 56)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(6, 6)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(134, 44)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(152, 6)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(134, 44)
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
        Me.gvData.Location = New System.Drawing.Point(26, 215)
        Me.gvData.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.gvData.MultiSelect = False
        Me.gvData.Name = "gvData"
        Me.gvData.ReadOnly = True
        Me.gvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvData.Size = New System.Drawing.Size(1660, 617)
        Me.gvData.TabIndex = 0
        '
        'grpFilter
        '
        Me.grpFilter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFilter.Controls.Add(Me.binProvince)
        Me.grpFilter.Controls.Add(Me.provinceText)
        Me.grpFilter.Controls.Add(Me.provinceLabel)
        Me.grpFilter.Controls.Add(Me.binName)
        Me.grpFilter.Controls.Add(Me.binNumber)
        Me.grpFilter.Controls.Add(Me.txtNumber)
        Me.grpFilter.Controls.Add(Me.txtName)
        Me.grpFilter.Controls.Add(Me.lblNumber)
        Me.grpFilter.Controls.Add(Me.lblName)
        Me.grpFilter.Location = New System.Drawing.Point(26, 25)
        Me.grpFilter.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.grpFilter.Name = "grpFilter"
        Me.grpFilter.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.grpFilter.Size = New System.Drawing.Size(1660, 179)
        Me.grpFilter.TabIndex = 2
        Me.grpFilter.TabStop = False
        Me.grpFilter.Text = "Filter and Search"
        '
        'binName
        '
        Me.binName.Image = Global.FGC_validation.My.Resources.Resources.bin
        Me.binName.Location = New System.Drawing.Point(592, 115)
        Me.binName.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.binName.Name = "binName"
        Me.binName.Size = New System.Drawing.Size(16, 16)
        Me.binName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.binName.TabIndex = 7
        Me.binName.TabStop = False
        '
        'binNumber
        '
        Me.binNumber.Image = Global.FGC_validation.My.Resources.Resources.bin
        Me.binNumber.Location = New System.Drawing.Point(592, 50)
        Me.binNumber.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.binNumber.Name = "binNumber"
        Me.binNumber.Size = New System.Drawing.Size(16, 16)
        Me.binNumber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.binNumber.TabIndex = 6
        Me.binNumber.TabStop = False
        '
        'txtNumber
        '
        Me.txtNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumber.Location = New System.Drawing.Point(250, 37)
        Me.txtNumber.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(326, 44)
        Me.txtNumber.TabIndex = 0
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(250, 108)
        Me.txtName.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(326, 44)
        Me.txtName.TabIndex = 1
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Location = New System.Drawing.Point(54, 50)
        Me.lblNumber.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(87, 25)
        Me.lblNumber.TabIndex = 1
        Me.lblNumber.Text = "Number"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(54, 115)
        Me.lblName.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(68, 25)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        '
        'binProvince
        '
        Me.binProvince.Image = Global.FGC_validation.My.Resources.Resources.bin
        Me.binProvince.Location = New System.Drawing.Point(1341, 51)
        Me.binProvince.Margin = New System.Windows.Forms.Padding(6)
        Me.binProvince.Name = "binProvince"
        Me.binProvince.Size = New System.Drawing.Size(16, 16)
        Me.binProvince.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.binProvince.TabIndex = 10
        Me.binProvince.TabStop = False
        '
        'provinceText
        '
        Me.provinceText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.provinceText.Location = New System.Drawing.Point(999, 38)
        Me.provinceText.Margin = New System.Windows.Forms.Padding(6)
        Me.provinceText.Name = "provinceText"
        Me.provinceText.Size = New System.Drawing.Size(326, 44)
        Me.provinceText.TabIndex = 8
        '
        'provinceLabel
        '
        Me.provinceLabel.AutoSize = True
        Me.provinceLabel.Location = New System.Drawing.Point(803, 51)
        Me.provinceLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.provinceLabel.Name = "provinceLabel"
        Me.provinceLabel.Size = New System.Drawing.Size(96, 25)
        Me.provinceLabel.TabIndex = 9
        Me.provinceLabel.Text = "Province"
        '
        'ChestSelection
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(1710, 923)
        Me.Controls.Add(Me.grpFilter)
        Me.Controls.Add(Me.gvData)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ChestSelection"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Relief Chest Search"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFilter.ResumeLayout(False)
        Me.grpFilter.PerformLayout()
        CType(Me.binName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.binNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.binProvince, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents gvData As System.Windows.Forms.DataGridView
    Friend WithEvents grpFilter As System.Windows.Forms.GroupBox
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblNumber As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents binName As System.Windows.Forms.PictureBox
    Friend WithEvents binNumber As System.Windows.Forms.PictureBox
    Friend WithEvents binProvince As Windows.Forms.PictureBox
    Friend WithEvents provinceText As Windows.Forms.TextBox
    Friend WithEvents provinceLabel As Windows.Forms.Label
End Class
