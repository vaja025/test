<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LodgeSelection
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
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.txtProvince = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblProvince = New System.Windows.Forms.Label()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.binName = New System.Windows.Forms.PictureBox()
        Me.binNumber = New System.Windows.Forms.PictureBox()
        Me.binProvince = New System.Windows.Forms.PictureBox()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(697, 439)
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
        Me.gvData.Size = New System.Drawing.Size(830, 321)
        Me.gvData.TabIndex = 0
        '
        'grpFilter
        '
        Me.grpFilter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFilter.Controls.Add(Me.binProvince)
        Me.grpFilter.Controls.Add(Me.binName)
        Me.grpFilter.Controls.Add(Me.binNumber)
        Me.grpFilter.Controls.Add(Me.txtNumber)
        Me.grpFilter.Controls.Add(Me.txtProvince)
        Me.grpFilter.Controls.Add(Me.txtName)
        Me.grpFilter.Controls.Add(Me.lblProvince)
        Me.grpFilter.Controls.Add(Me.lblNumber)
        Me.grpFilter.Controls.Add(Me.lblName)
        Me.grpFilter.Location = New System.Drawing.Point(13, 13)
        Me.grpFilter.Name = "grpFilter"
        Me.grpFilter.Size = New System.Drawing.Size(830, 93)
        Me.grpFilter.TabIndex = 2
        Me.grpFilter.TabStop = False
        Me.grpFilter.Text = "Filter and Search"
        '
        'txtNumber
        '
        Me.txtNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumber.Location = New System.Drawing.Point(125, 19)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(165, 26)
        Me.txtNumber.TabIndex = 0
        '
        'txtProvince
        '
        Me.txtProvince.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProvince.Location = New System.Drawing.Point(460, 19)
        Me.txtProvince.Name = "txtProvince"
        Me.txtProvince.Size = New System.Drawing.Size(165, 26)
        Me.txtProvince.TabIndex = 1
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(125, 56)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(165, 26)
        Me.txtName.TabIndex = 1
        '
        'lblProvince
        '
        Me.lblProvince.AutoSize = True
        Me.lblProvince.Location = New System.Drawing.Point(362, 26)
        Me.lblProvince.Name = "lblProvince"
        Me.lblProvince.Size = New System.Drawing.Size(49, 13)
        Me.lblProvince.TabIndex = 0
        Me.lblProvince.Text = "Province"
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Location = New System.Drawing.Point(27, 26)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(44, 13)
        Me.lblNumber.TabIndex = 1
        Me.lblNumber.Text = "Number"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(27, 60)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        '
        'binName
        '
        Me.binName.Image = Global.FGC_validation.My.Resources.Resources.bin
        Me.binName.Location = New System.Drawing.Point(296, 60)
        Me.binName.Name = "binName"
        Me.binName.Size = New System.Drawing.Size(16, 16)
        Me.binName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.binName.TabIndex = 7
        Me.binName.TabStop = False
        '
        'binNumber
        '
        Me.binNumber.Image = Global.FGC_validation.My.Resources.Resources.bin
        Me.binNumber.Location = New System.Drawing.Point(296, 26)
        Me.binNumber.Name = "binNumber"
        Me.binNumber.Size = New System.Drawing.Size(16, 16)
        Me.binNumber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.binNumber.TabIndex = 6
        Me.binNumber.TabStop = False
        '
        'binProvince
        '
        Me.binProvince.Image = Global.FGC_validation.My.Resources.Resources.bin
        Me.binProvince.Location = New System.Drawing.Point(631, 26)
        Me.binProvince.Name = "binProvince"
        Me.binProvince.Size = New System.Drawing.Size(16, 16)
        Me.binProvince.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.binProvince.TabIndex = 7
        Me.binProvince.TabStop = False
        '
        'LodgeSelection
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(855, 480)
        Me.Controls.Add(Me.grpFilter)
        Me.Controls.Add(Me.gvData)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LodgeSelection"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Lodge Search"
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
    Friend WithEvents txtProvince As System.Windows.Forms.TextBox
    Friend WithEvents lblProvince As System.Windows.Forms.Label
    Friend WithEvents binProvince As System.Windows.Forms.PictureBox
    Friend WithEvents binName As System.Windows.Forms.PictureBox
    Friend WithEvents binNumber As System.Windows.Forms.PictureBox

End Class
