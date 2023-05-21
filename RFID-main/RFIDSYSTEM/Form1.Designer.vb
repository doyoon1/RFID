<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.panelmenu = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBoxSelect = New System.Windows.Forms.PictureBox()
        Me.ButtonRegistration = New System.Windows.Forms.Button()
        Me.ButtonUserData = New System.Windows.Forms.Button()
        Me.ButtonConnection = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelRegistrationEditUserData = New System.Windows.Forms.Panel()
        Me.GroupBoxRecordView = New System.Windows.Forms.GroupBox()
        Me.DBTABLE = New System.Windows.Forms.DataGridView()
        Me.RFIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LRNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GRADEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DEPARTMENTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IMAGEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RFIDdatabaseDataSet = New RFIDSYSTEM.RFIDdatabaseDataSet()
        Me.ButtonBrowseImage = New System.Windows.Forms.Button()
        Me.ButtonRemove = New System.Windows.Forms.Button()
        Me.ButtonNew = New System.Windows.Forms.Button()
        Me.ButtonClearForm = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PictureBoxImageInput = New System.Windows.Forms.PictureBox()
        Me.TextBoxImage = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxDepartment = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxGrade = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxLRN = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxRFID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.StudentInfoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RFIDdatabaseDataSet1 = New RFIDSYSTEM.RFIDdatabaseDataSet1()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PanelUserData = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelLRN = New System.Windows.Forms.Label()
        Me.LabelGrade = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LabelDepartment = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBoxImage = New System.Windows.Forms.GroupBox()
        Me.LabelID = New System.Windows.Forms.Label()
        Me.PictureBoxUserImage = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PanelConnection = New System.Windows.Forms.Panel()
        Me.ComboBoxBaudRate = New System.Windows.Forms.ComboBox()
        Me.ButtonConnect = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ComboBoxPort = New System.Windows.Forms.ComboBox()
        Me.ButtonScanPort = New System.Windows.Forms.Button()
        Me.PanelTopHeader = New System.Windows.Forms.Panel()
        Me.StudentInfoTableAdapter1 = New RFIDSYSTEM.RFIDdatabaseDataSet1TableAdapters.StudentInfoTableAdapter()
        Me.StudentInfoTableAdapter = New RFIDSYSTEM.RFIDdatabaseDataSetTableAdapters.StudentInfoTableAdapter()
        Me.PanelMasterlist = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.DBTABLE2 = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.PictureBoxImageInput2 = New System.Windows.Forms.PictureBox()
        Me.TextBoxImage2 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TextBoxDepartment2 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TextBoxGrade2 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TextBoxLRN2 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TextBoxName2 = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TextBoxRFID2 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.panelmenu.SuspendLayout()
        CType(Me.PictureBoxSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelRegistrationEditUserData.SuspendLayout()
        Me.GroupBoxRecordView.SuspendLayout()
        CType(Me.DBTABLE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RFIDdatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBoxImageInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentInfoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RFIDdatabaseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelUserData.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBoxImage.SuspendLayout()
        CType(Me.PictureBoxUserImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelConnection.SuspendLayout()
        Me.PanelMasterlist.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DBTABLE2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBoxImageInput2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelmenu
        '
        Me.panelmenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.panelmenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.panelmenu.Controls.Add(Me.Button1)
        Me.panelmenu.Controls.Add(Me.PictureBoxSelect)
        Me.panelmenu.Controls.Add(Me.ButtonRegistration)
        Me.panelmenu.Controls.Add(Me.ButtonUserData)
        Me.panelmenu.Controls.Add(Me.ButtonConnection)
        Me.panelmenu.Controls.Add(Me.PictureBox1)
        Me.panelmenu.Location = New System.Drawing.Point(0, 0)
        Me.panelmenu.Name = "panelmenu"
        Me.panelmenu.Size = New System.Drawing.Size(324, 579)
        Me.panelmenu.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(28, 372)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(302, 36)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "MASTER LIST "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBoxSelect
        '
        Me.PictureBoxSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBoxSelect.ErrorImage = CType(resources.GetObject("PictureBoxSelect.ErrorImage"), System.Drawing.Image)
        Me.PictureBoxSelect.Image = CType(resources.GetObject("PictureBoxSelect.Image"), System.Drawing.Image)
        Me.PictureBoxSelect.Location = New System.Drawing.Point(-2, 250)
        Me.PictureBoxSelect.Name = "PictureBoxSelect"
        Me.PictureBoxSelect.Size = New System.Drawing.Size(24, 23)
        Me.PictureBoxSelect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxSelect.TabIndex = 1
        Me.PictureBoxSelect.TabStop = False
        '
        'ButtonRegistration
        '
        Me.ButtonRegistration.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.ButtonRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRegistration.ForeColor = System.Drawing.Color.Transparent
        Me.ButtonRegistration.Image = CType(resources.GetObject("ButtonRegistration.Image"), System.Drawing.Image)
        Me.ButtonRegistration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonRegistration.Location = New System.Drawing.Point(28, 330)
        Me.ButtonRegistration.Name = "ButtonRegistration"
        Me.ButtonRegistration.Size = New System.Drawing.Size(302, 36)
        Me.ButtonRegistration.TabIndex = 3
        Me.ButtonRegistration.Text = "Registration/ Edit User Data"
        Me.ButtonRegistration.UseVisualStyleBackColor = True
        '
        'ButtonUserData
        '
        Me.ButtonUserData.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.ButtonUserData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonUserData.ForeColor = System.Drawing.Color.Transparent
        Me.ButtonUserData.Image = CType(resources.GetObject("ButtonUserData.Image"), System.Drawing.Image)
        Me.ButtonUserData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonUserData.Location = New System.Drawing.Point(28, 288)
        Me.ButtonUserData.Name = "ButtonUserData"
        Me.ButtonUserData.Size = New System.Drawing.Size(302, 36)
        Me.ButtonUserData.TabIndex = 2
        Me.ButtonUserData.Text = "User Data"
        Me.ButtonUserData.UseVisualStyleBackColor = True
        '
        'ButtonConnection
        '
        Me.ButtonConnection.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.ButtonConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonConnection.ForeColor = System.Drawing.Color.Transparent
        Me.ButtonConnection.Image = CType(resources.GetObject("ButtonConnection.Image"), System.Drawing.Image)
        Me.ButtonConnection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonConnection.Location = New System.Drawing.Point(28, 246)
        Me.ButtonConnection.Name = "ButtonConnection"
        Me.ButtonConnection.Size = New System.Drawing.Size(302, 36)
        Me.ButtonConnection.TabIndex = 1
        Me.ButtonConnection.Text = "Connection"
        Me.ButtonConnection.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(23, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(277, 176)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PanelRegistrationEditUserData
        '
        Me.PanelRegistrationEditUserData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelRegistrationEditUserData.Controls.Add(Me.GroupBoxRecordView)
        Me.PanelRegistrationEditUserData.Controls.Add(Me.ButtonBrowseImage)
        Me.PanelRegistrationEditUserData.Controls.Add(Me.ButtonRemove)
        Me.PanelRegistrationEditUserData.Controls.Add(Me.ButtonNew)
        Me.PanelRegistrationEditUserData.Controls.Add(Me.ButtonClearForm)
        Me.PanelRegistrationEditUserData.Controls.Add(Me.ButtonSave)
        Me.PanelRegistrationEditUserData.Controls.Add(Me.GroupBox3)
        Me.PanelRegistrationEditUserData.Controls.Add(Me.TextBoxImage)
        Me.PanelRegistrationEditUserData.Controls.Add(Me.Label5)
        Me.PanelRegistrationEditUserData.Controls.Add(Me.TextBoxDepartment)
        Me.PanelRegistrationEditUserData.Controls.Add(Me.Label4)
        Me.PanelRegistrationEditUserData.Controls.Add(Me.TextBoxGrade)
        Me.PanelRegistrationEditUserData.Controls.Add(Me.Label3)
        Me.PanelRegistrationEditUserData.Controls.Add(Me.TextBoxLRN)
        Me.PanelRegistrationEditUserData.Controls.Add(Me.Label2)
        Me.PanelRegistrationEditUserData.Controls.Add(Me.TextBoxName)
        Me.PanelRegistrationEditUserData.Controls.Add(Me.Label1)
        Me.PanelRegistrationEditUserData.Controls.Add(Me.TextBoxRFID)
        Me.PanelRegistrationEditUserData.Controls.Add(Me.Label6)
        Me.PanelRegistrationEditUserData.Controls.Add(Me.Panel3)
        Me.PanelRegistrationEditUserData.Location = New System.Drawing.Point(332, 10)
        Me.PanelRegistrationEditUserData.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PanelRegistrationEditUserData.Name = "PanelRegistrationEditUserData"
        Me.PanelRegistrationEditUserData.Size = New System.Drawing.Size(592, 557)
        Me.PanelRegistrationEditUserData.TabIndex = 6
        '
        'GroupBoxRecordView
        '
        Me.GroupBoxRecordView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxRecordView.Controls.Add(Me.DBTABLE)
        Me.GroupBoxRecordView.Location = New System.Drawing.Point(258, 161)
        Me.GroupBoxRecordView.Name = "GroupBoxRecordView"
        Me.GroupBoxRecordView.Size = New System.Drawing.Size(329, 387)
        Me.GroupBoxRecordView.TabIndex = 17
        Me.GroupBoxRecordView.TabStop = False
        Me.GroupBoxRecordView.Text = "Revord View"
        '
        'DBTABLE
        '
        Me.DBTABLE.AllowDrop = True
        Me.DBTABLE.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DBTABLE.AutoGenerateColumns = False
        Me.DBTABLE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DBTABLE.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RFIDDataGridViewTextBoxColumn, Me.NAMEDataGridViewTextBoxColumn, Me.LRNDataGridViewTextBoxColumn, Me.GRADEDataGridViewTextBoxColumn, Me.DEPARTMENTDataGridViewTextBoxColumn, Me.IMAGEDataGridViewTextBoxColumn})
        Me.DBTABLE.DataSource = Me.StudentInfoBindingSource
        Me.DBTABLE.Location = New System.Drawing.Point(6, 22)
        Me.DBTABLE.Name = "DBTABLE"
        Me.DBTABLE.RowHeadersWidth = 51
        Me.DBTABLE.RowTemplate.Height = 24
        Me.DBTABLE.Size = New System.Drawing.Size(317, 357)
        Me.DBTABLE.TabIndex = 23
        '
        'RFIDDataGridViewTextBoxColumn
        '
        Me.RFIDDataGridViewTextBoxColumn.DataPropertyName = "RFID"
        Me.RFIDDataGridViewTextBoxColumn.HeaderText = "RFID"
        Me.RFIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RFIDDataGridViewTextBoxColumn.Name = "RFIDDataGridViewTextBoxColumn"
        Me.RFIDDataGridViewTextBoxColumn.Width = 125
        '
        'NAMEDataGridViewTextBoxColumn
        '
        Me.NAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME"
        Me.NAMEDataGridViewTextBoxColumn.HeaderText = "NAME"
        Me.NAMEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NAMEDataGridViewTextBoxColumn.Name = "NAMEDataGridViewTextBoxColumn"
        Me.NAMEDataGridViewTextBoxColumn.Width = 125
        '
        'LRNDataGridViewTextBoxColumn
        '
        Me.LRNDataGridViewTextBoxColumn.DataPropertyName = "LRN"
        Me.LRNDataGridViewTextBoxColumn.HeaderText = "LRN"
        Me.LRNDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LRNDataGridViewTextBoxColumn.Name = "LRNDataGridViewTextBoxColumn"
        Me.LRNDataGridViewTextBoxColumn.Width = 125
        '
        'GRADEDataGridViewTextBoxColumn
        '
        Me.GRADEDataGridViewTextBoxColumn.DataPropertyName = "GRADE"
        Me.GRADEDataGridViewTextBoxColumn.HeaderText = "GRADE"
        Me.GRADEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.GRADEDataGridViewTextBoxColumn.Name = "GRADEDataGridViewTextBoxColumn"
        Me.GRADEDataGridViewTextBoxColumn.Width = 125
        '
        'DEPARTMENTDataGridViewTextBoxColumn
        '
        Me.DEPARTMENTDataGridViewTextBoxColumn.DataPropertyName = "DEPARTMENT"
        Me.DEPARTMENTDataGridViewTextBoxColumn.HeaderText = "DEPARTMENT"
        Me.DEPARTMENTDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DEPARTMENTDataGridViewTextBoxColumn.Name = "DEPARTMENTDataGridViewTextBoxColumn"
        Me.DEPARTMENTDataGridViewTextBoxColumn.Width = 125
        '
        'IMAGEDataGridViewTextBoxColumn
        '
        Me.IMAGEDataGridViewTextBoxColumn.DataPropertyName = "IMAGE"
        Me.IMAGEDataGridViewTextBoxColumn.HeaderText = "IMAGE"
        Me.IMAGEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IMAGEDataGridViewTextBoxColumn.Name = "IMAGEDataGridViewTextBoxColumn"
        Me.IMAGEDataGridViewTextBoxColumn.Width = 125
        '
        'StudentInfoBindingSource
        '
        Me.StudentInfoBindingSource.DataMember = "StudentInfo"
        Me.StudentInfoBindingSource.DataSource = Me.RFIDdatabaseDataSet
        '
        'RFIDdatabaseDataSet
        '
        Me.RFIDdatabaseDataSet.DataSetName = "RFIDdatabaseDataSet"
        Me.RFIDdatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ButtonBrowseImage
        '
        Me.ButtonBrowseImage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonBrowseImage.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonBrowseImage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.ButtonBrowseImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ButtonBrowseImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.ButtonBrowseImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBrowseImage.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBrowseImage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.ButtonBrowseImage.Location = New System.Drawing.Point(420, 110)
        Me.ButtonBrowseImage.Name = "ButtonBrowseImage"
        Me.ButtonBrowseImage.Size = New System.Drawing.Size(169, 41)
        Me.ButtonBrowseImage.TabIndex = 27
        Me.ButtonBrowseImage.Text = "Browse Image"
        Me.ButtonBrowseImage.UseVisualStyleBackColor = False
        '
        'ButtonRemove
        '
        Me.ButtonRemove.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonRemove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.ButtonRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ButtonRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.ButtonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRemove.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRemove.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.ButtonRemove.Location = New System.Drawing.Point(507, 71)
        Me.ButtonRemove.Name = "ButtonRemove"
        Me.ButtonRemove.Size = New System.Drawing.Size(82, 24)
        Me.ButtonRemove.TabIndex = 26
        Me.ButtonRemove.Text = "Remove"
        Me.ButtonRemove.UseVisualStyleBackColor = False
        '
        'ButtonNew
        '
        Me.ButtonNew.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.ButtonNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ButtonNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.ButtonNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonNew.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNew.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.ButtonNew.Location = New System.Drawing.Point(420, 34)
        Me.ButtonNew.Name = "ButtonNew"
        Me.ButtonNew.Size = New System.Drawing.Size(82, 24)
        Me.ButtonNew.TabIndex = 25
        Me.ButtonNew.Text = "New"
        Me.ButtonNew.UseVisualStyleBackColor = False
        '
        'ButtonClearForm
        '
        Me.ButtonClearForm.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonClearForm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.ButtonClearForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ButtonClearForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.ButtonClearForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClearForm.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClearForm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.ButtonClearForm.Location = New System.Drawing.Point(420, 71)
        Me.ButtonClearForm.Name = "ButtonClearForm"
        Me.ButtonClearForm.Size = New System.Drawing.Size(82, 24)
        Me.ButtonClearForm.TabIndex = 24
        Me.ButtonClearForm.Text = "Clear"
        Me.ButtonClearForm.UseVisualStyleBackColor = False
        '
        'ButtonSave
        '
        Me.ButtonSave.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.ButtonSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ButtonSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSave.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.ButtonSave.Location = New System.Drawing.Point(507, 34)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(82, 24)
        Me.ButtonSave.TabIndex = 23
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.PictureBoxImageInput)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 177)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(238, 314)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "IMAGE"
        '
        'PictureBoxImageInput
        '
        Me.PictureBoxImageInput.Location = New System.Drawing.Point(17, 34)
        Me.PictureBoxImageInput.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBoxImageInput.Name = "PictureBoxImageInput"
        Me.PictureBoxImageInput.Size = New System.Drawing.Size(210, 232)
        Me.PictureBoxImageInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBoxImageInput.TabIndex = 0
        Me.PictureBoxImageInput.TabStop = False
        '
        'TextBoxImage
        '
        Me.TextBoxImage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxImage.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxImage.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "IMAGE", True))
        Me.TextBoxImage.Location = New System.Drawing.Point(112, 132)
        Me.TextBoxImage.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxImage.Name = "TextBoxImage"
        Me.TextBoxImage.Size = New System.Drawing.Size(297, 20)
        Me.TextBoxImage.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 14)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "IMAGE"
        '
        'TextBoxDepartment
        '
        Me.TextBoxDepartment.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxDepartment.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxDepartment.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "DEPARTMENT", True))
        Me.TextBoxDepartment.Location = New System.Drawing.Point(112, 110)
        Me.TextBoxDepartment.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxDepartment.Name = "TextBoxDepartment"
        Me.TextBoxDepartment.Size = New System.Drawing.Size(297, 20)
        Me.TextBoxDepartment.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 14)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "DEPARTMENT"
        '
        'TextBoxGrade
        '
        Me.TextBoxGrade.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxGrade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxGrade.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "GRADE", True))
        Me.TextBoxGrade.Location = New System.Drawing.Point(112, 87)
        Me.TextBoxGrade.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxGrade.Name = "TextBoxGrade"
        Me.TextBoxGrade.Size = New System.Drawing.Size(297, 20)
        Me.TextBoxGrade.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 14)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "GRADE"
        '
        'TextBoxLRN
        '
        Me.TextBoxLRN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxLRN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxLRN.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "LRN", True))
        Me.TextBoxLRN.Location = New System.Drawing.Point(112, 64)
        Me.TextBoxLRN.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxLRN.Name = "TextBoxLRN"
        Me.TextBoxLRN.Size = New System.Drawing.Size(297, 20)
        Me.TextBoxLRN.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 14)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "LRN"
        '
        'TextBoxName
        '
        Me.TextBoxName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "NAME", True))
        Me.TextBoxName.Location = New System.Drawing.Point(112, 41)
        Me.TextBoxName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(297, 20)
        Me.TextBoxName.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 14)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "NAME"
        '
        'TextBoxRFID
        '
        Me.TextBoxRFID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxRFID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxRFID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "RFID", True))
        Me.TextBoxRFID.Location = New System.Drawing.Point(112, 19)
        Me.TextBoxRFID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxRFID.Name = "TextBoxRFID"
        Me.TextBoxRFID.Size = New System.Drawing.Size(297, 20)
        Me.TextBoxRFID.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 14)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "RFID"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1209, 10)
        Me.Panel3.TabIndex = 1
        '
        'StudentInfoBindingSource1
        '
        Me.StudentInfoBindingSource1.DataMember = "StudentInfo"
        Me.StudentInfoBindingSource1.DataSource = Me.RFIDdatabaseDataSet1
        '
        'RFIDdatabaseDataSet1
        '
        Me.RFIDdatabaseDataSet1.DataSetName = "RFIDdatabaseDataSet1"
        Me.RFIDdatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PanelUserData
        '
        Me.PanelUserData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelUserData.Controls.Add(Me.GroupBox1)
        Me.PanelUserData.Controls.Add(Me.GroupBoxImage)
        Me.PanelUserData.Controls.Add(Me.Panel2)
        Me.PanelUserData.Location = New System.Drawing.Point(332, 11)
        Me.PanelUserData.Name = "PanelUserData"
        Me.PanelUserData.Size = New System.Drawing.Size(592, 557)
        Me.PanelUserData.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.LabelLRN)
        Me.GroupBox1.Controls.Add(Me.LabelGrade)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.LabelDepartment)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.ButtonClear)
        Me.GroupBox1.Controls.Add(Me.LabelName)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 271)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(555, 270)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detailed Data"
        '
        'LabelLRN
        '
        Me.LabelLRN.AutoSize = True
        Me.LabelLRN.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLRN.Location = New System.Drawing.Point(188, 87)
        Me.LabelLRN.Name = "LabelLRN"
        Me.LabelLRN.Size = New System.Drawing.Size(97, 22)
        Me.LabelLRN.TabIndex = 17
        Me.LabelLRN.Text = "Waiting..."
        '
        'LabelGrade
        '
        Me.LabelGrade.AutoSize = True
        Me.LabelGrade.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGrade.Location = New System.Drawing.Point(188, 144)
        Me.LabelGrade.Name = "LabelGrade"
        Me.LabelGrade.Size = New System.Drawing.Size(97, 22)
        Me.LabelGrade.TabIndex = 16
        Me.LabelGrade.Text = "Waiting..."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(165, 87)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 22)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(165, 144)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 22)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 144)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 22)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "GRADE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 87)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 22)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "LRN"
        '
        'LabelDepartment
        '
        Me.LabelDepartment.AutoSize = True
        Me.LabelDepartment.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDepartment.Location = New System.Drawing.Point(188, 207)
        Me.LabelDepartment.Name = "LabelDepartment"
        Me.LabelDepartment.Size = New System.Drawing.Size(97, 22)
        Me.LabelDepartment.TabIndex = 10
        Me.LabelDepartment.Text = "Waiting..."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(165, 207)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(16, 22)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = ":"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 207)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(145, 22)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "DEPARTMENT"
        '
        'ButtonClear
        '
        Me.ButtonClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonClear.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.ButtonClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ButtonClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.ButtonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClear.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.ButtonClear.Location = New System.Drawing.Point(477, 240)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(68, 21)
        Me.ButtonClear.TabIndex = 7
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.UseVisualStyleBackColor = False
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelName.Location = New System.Drawing.Point(188, 28)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(97, 22)
        Me.LabelName.TabIndex = 6
        Me.LabelName.Text = "Waiting..."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(165, 28)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(16, 22)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = ":"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(6, 28)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 22)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Name"
        '
        'GroupBoxImage
        '
        Me.GroupBoxImage.Controls.Add(Me.LabelID)
        Me.GroupBoxImage.Controls.Add(Me.PictureBoxUserImage)
        Me.GroupBoxImage.Location = New System.Drawing.Point(209, 26)
        Me.GroupBoxImage.Name = "GroupBoxImage"
        Me.GroupBoxImage.Size = New System.Drawing.Size(208, 239)
        Me.GroupBoxImage.TabIndex = 1
        Me.GroupBoxImage.TabStop = False
        Me.GroupBoxImage.Text = "Image and ID"
        '
        'LabelID
        '
        Me.LabelID.AutoSize = True
        Me.LabelID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelID.Location = New System.Drawing.Point(14, 205)
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(106, 22)
        Me.LabelID.TabIndex = 3
        Me.LabelID.Text = "ID : ______"
        '
        'PictureBoxUserImage
        '
        Me.PictureBoxUserImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxUserImage.Location = New System.Drawing.Point(18, 19)
        Me.PictureBoxUserImage.Name = "PictureBoxUserImage"
        Me.PictureBoxUserImage.Size = New System.Drawing.Size(174, 174)
        Me.PictureBoxUserImage.TabIndex = 2
        Me.PictureBoxUserImage.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1109, 10)
        Me.Panel2.TabIndex = 0
        '
        'PanelConnection
        '
        Me.PanelConnection.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelConnection.Controls.Add(Me.ComboBoxBaudRate)
        Me.PanelConnection.Controls.Add(Me.ButtonConnect)
        Me.PanelConnection.Controls.Add(Me.Label16)
        Me.PanelConnection.Controls.Add(Me.ComboBoxPort)
        Me.PanelConnection.Controls.Add(Me.ButtonScanPort)
        Me.PanelConnection.Controls.Add(Me.PanelTopHeader)
        Me.PanelConnection.Location = New System.Drawing.Point(332, 10)
        Me.PanelConnection.Name = "PanelConnection"
        Me.PanelConnection.Size = New System.Drawing.Size(592, 557)
        Me.PanelConnection.TabIndex = 8
        '
        'ComboBoxBaudRate
        '
        Me.ComboBoxBaudRate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxBaudRate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.ComboBoxBaudRate.FormattingEnabled = True
        Me.ComboBoxBaudRate.Items.AddRange(New Object() {"1200", "2400", "4800", "9600", "14400", "19200", "38400", "57600", "115200"})
        Me.ComboBoxBaudRate.Location = New System.Drawing.Point(479, 19)
        Me.ComboBoxBaudRate.Name = "ComboBoxBaudRate"
        Me.ComboBoxBaudRate.Size = New System.Drawing.Size(90, 21)
        Me.ComboBoxBaudRate.TabIndex = 5
        '
        'ButtonConnect
        '
        Me.ButtonConnect.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonConnect.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonConnect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.ButtonConnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ButtonConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.ButtonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonConnect.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonConnect.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.ButtonConnect.Location = New System.Drawing.Point(14, 65)
        Me.ButtonConnect.Name = "ButtonConnect"
        Me.ButtonConnect.Size = New System.Drawing.Size(555, 30)
        Me.ButtonConnect.TabIndex = 4
        Me.ButtonConnect.Text = "Connect"
        Me.ButtonConnect.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(404, 23)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(69, 12)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Baud Rate :"
        '
        'ComboBoxPort
        '
        Me.ComboBoxPort.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxPort.BackColor = System.Drawing.Color.White
        Me.ComboBoxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPort.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.ComboBoxPort.FormattingEnabled = True
        Me.ComboBoxPort.Location = New System.Drawing.Point(133, 20)
        Me.ComboBoxPort.Name = "ComboBoxPort"
        Me.ComboBoxPort.Size = New System.Drawing.Size(265, 21)
        Me.ComboBoxPort.TabIndex = 2
        '
        'ButtonScanPort
        '
        Me.ButtonScanPort.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonScanPort.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.ButtonScanPort.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ButtonScanPort.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.ButtonScanPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonScanPort.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonScanPort.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.ButtonScanPort.Location = New System.Drawing.Point(14, 20)
        Me.ButtonScanPort.Name = "ButtonScanPort"
        Me.ButtonScanPort.Size = New System.Drawing.Size(113, 20)
        Me.ButtonScanPort.TabIndex = 1
        Me.ButtonScanPort.Text = "Scan Port"
        Me.ButtonScanPort.UseVisualStyleBackColor = False
        '
        'PanelTopHeader
        '
        Me.PanelTopHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelTopHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.PanelTopHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelTopHeader.Name = "PanelTopHeader"
        Me.PanelTopHeader.Size = New System.Drawing.Size(1109, 10)
        Me.PanelTopHeader.TabIndex = 0
        '
        'StudentInfoTableAdapter1
        '
        Me.StudentInfoTableAdapter1.ClearBeforeFill = True
        '
        'StudentInfoTableAdapter
        '
        Me.StudentInfoTableAdapter.ClearBeforeFill = True
        '
        'PanelMasterlist
        '
        Me.PanelMasterlist.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelMasterlist.Controls.Add(Me.GroupBox2)
        Me.PanelMasterlist.Controls.Add(Me.GroupBox4)
        Me.PanelMasterlist.Controls.Add(Me.TextBoxImage2)
        Me.PanelMasterlist.Controls.Add(Me.Label18)
        Me.PanelMasterlist.Controls.Add(Me.TextBoxDepartment2)
        Me.PanelMasterlist.Controls.Add(Me.Label19)
        Me.PanelMasterlist.Controls.Add(Me.TextBoxGrade2)
        Me.PanelMasterlist.Controls.Add(Me.Label20)
        Me.PanelMasterlist.Controls.Add(Me.TextBoxLRN2)
        Me.PanelMasterlist.Controls.Add(Me.Label21)
        Me.PanelMasterlist.Controls.Add(Me.TextBoxName2)
        Me.PanelMasterlist.Controls.Add(Me.Label22)
        Me.PanelMasterlist.Controls.Add(Me.TextBoxRFID2)
        Me.PanelMasterlist.Controls.Add(Me.Label23)
        Me.PanelMasterlist.Controls.Add(Me.Panel4)
        Me.PanelMasterlist.Location = New System.Drawing.Point(332, 8)
        Me.PanelMasterlist.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PanelMasterlist.Name = "PanelMasterlist"
        Me.PanelMasterlist.Size = New System.Drawing.Size(592, 557)
        Me.PanelMasterlist.TabIndex = 9
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.DBTABLE2)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 192)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(573, 356)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Revord View"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(98, 20)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(248, 20)
        Me.TextBox1.TabIndex = 25
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(6, 21)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(89, 14)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "Search Here : "
        '
        'DBTABLE2
        '
        Me.DBTABLE2.AllowDrop = True
        Me.DBTABLE2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DBTABLE2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DBTABLE2.Location = New System.Drawing.Point(8, 45)
        Me.DBTABLE2.Name = "DBTABLE2"
        Me.DBTABLE2.RowHeadersWidth = 51
        Me.DBTABLE2.RowTemplate.Height = 24
        Me.DBTABLE2.Size = New System.Drawing.Size(549, 295)
        Me.DBTABLE2.TabIndex = 23
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.PictureBoxImageInput2)
        Me.GroupBox4.Location = New System.Drawing.Point(420, 20)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(169, 161)
        Me.GroupBox4.TabIndex = 16
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "IMAGE"
        '
        'PictureBoxImageInput2
        '
        Me.PictureBoxImageInput2.Location = New System.Drawing.Point(15, 19)
        Me.PictureBoxImageInput2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBoxImageInput2.Name = "PictureBoxImageInput2"
        Me.PictureBoxImageInput2.Size = New System.Drawing.Size(134, 136)
        Me.PictureBoxImageInput2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBoxImageInput2.TabIndex = 0
        Me.PictureBoxImageInput2.TabStop = False
        '
        'TextBoxImage2
        '
        Me.TextBoxImage2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxImage2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxImage2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "IMAGE", True))
        Me.TextBoxImage2.Location = New System.Drawing.Point(112, 161)
        Me.TextBoxImage2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxImage2.Name = "TextBoxImage2"
        Me.TextBoxImage2.Size = New System.Drawing.Size(297, 20)
        Me.TextBoxImage2.TabIndex = 16
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(11, 162)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(48, 14)
        Me.Label18.TabIndex = 15
        Me.Label18.Text = "IMAGE"
        '
        'TextBoxDepartment2
        '
        Me.TextBoxDepartment2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxDepartment2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxDepartment2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "DEPARTMENT", True))
        Me.TextBoxDepartment2.Location = New System.Drawing.Point(112, 136)
        Me.TextBoxDepartment2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxDepartment2.Name = "TextBoxDepartment2"
        Me.TextBoxDepartment2.Size = New System.Drawing.Size(297, 20)
        Me.TextBoxDepartment2.TabIndex = 14
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(11, 137)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(93, 14)
        Me.Label19.TabIndex = 13
        Me.Label19.Text = "DEPARTMENT"
        '
        'TextBoxGrade2
        '
        Me.TextBoxGrade2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxGrade2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxGrade2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "GRADE", True))
        Me.TextBoxGrade2.Location = New System.Drawing.Point(112, 111)
        Me.TextBoxGrade2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxGrade2.Name = "TextBoxGrade2"
        Me.TextBoxGrade2.Size = New System.Drawing.Size(297, 20)
        Me.TextBoxGrade2.TabIndex = 12
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(11, 113)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(52, 14)
        Me.Label20.TabIndex = 11
        Me.Label20.Text = "GRADE"
        '
        'TextBoxLRN2
        '
        Me.TextBoxLRN2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxLRN2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxLRN2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "LRN", True))
        Me.TextBoxLRN2.Location = New System.Drawing.Point(112, 86)
        Me.TextBoxLRN2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxLRN2.Name = "TextBoxLRN2"
        Me.TextBoxLRN2.Size = New System.Drawing.Size(297, 20)
        Me.TextBoxLRN2.TabIndex = 10
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(11, 88)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(32, 14)
        Me.Label21.TabIndex = 9
        Me.Label21.Text = "LRN"
        '
        'TextBoxName2
        '
        Me.TextBoxName2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxName2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxName2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "NAME", True))
        Me.TextBoxName2.Location = New System.Drawing.Point(112, 63)
        Me.TextBoxName2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxName2.Name = "TextBoxName2"
        Me.TextBoxName2.Size = New System.Drawing.Size(297, 20)
        Me.TextBoxName2.TabIndex = 8
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(11, 65)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(43, 14)
        Me.Label22.TabIndex = 7
        Me.Label22.Text = "NAME"
        '
        'TextBoxRFID2
        '
        Me.TextBoxRFID2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxRFID2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxRFID2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInfoBindingSource, "RFID", True))
        Me.TextBoxRFID2.Location = New System.Drawing.Point(112, 39)
        Me.TextBoxRFID2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxRFID2.Name = "TextBoxRFID2"
        Me.TextBoxRFID2.Size = New System.Drawing.Size(297, 20)
        Me.TextBoxRFID2.TabIndex = 6
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(11, 41)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(36, 14)
        Me.Label23.TabIndex = 5
        Me.Label23.Text = "RFID"
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1209, 10)
        Me.Panel4.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 578)
        Me.Controls.Add(Me.panelmenu)
        Me.Controls.Add(Me.PanelRegistrationEditUserData)
        Me.Controls.Add(Me.PanelConnection)
        Me.Controls.Add(Me.PanelUserData)
        Me.Controls.Add(Me.PanelMasterlist)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "RFID SYSTEM"
        Me.panelmenu.ResumeLayout(False)
        CType(Me.PictureBoxSelect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelRegistrationEditUserData.ResumeLayout(False)
        Me.PanelRegistrationEditUserData.PerformLayout()
        Me.GroupBoxRecordView.ResumeLayout(False)
        CType(Me.DBTABLE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RFIDdatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.PictureBoxImageInput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentInfoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RFIDdatabaseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelUserData.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBoxImage.ResumeLayout(False)
        Me.GroupBoxImage.PerformLayout()
        CType(Me.PictureBoxUserImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelConnection.ResumeLayout(False)
        Me.PanelConnection.PerformLayout()
        Me.PanelMasterlist.ResumeLayout(False)
        Me.PanelMasterlist.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DBTABLE2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.PictureBoxImageInput2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelmenu As Panel
    Friend WithEvents PictureBoxSelect As PictureBox
    Friend WithEvents ButtonRegistration As Button
    Friend WithEvents ButtonUserData As Button
    Friend WithEvents ButtonConnection As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelRegistrationEditUserData As Panel
    Friend WithEvents TextBoxGrade As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxLRN As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxRFID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents TextBoxImage As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxDepartment As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonBrowseImage As Button
    Friend WithEvents ButtonRemove As Button
    Friend WithEvents ButtonNew As Button
    Friend WithEvents ButtonClearForm As Button
    Friend WithEvents ButtonSave As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents PictureBoxImageInput As PictureBox
    Friend WithEvents GroupBoxRecordView As GroupBox
    Friend WithEvents DBTABLE As DataGridView
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PanelUserData As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LabelLRN As Label
    Friend WithEvents LabelGrade As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LabelDepartment As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents ButtonClear As Button
    Friend WithEvents LabelName As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents GroupBoxImage As GroupBox
    Friend WithEvents LabelID As Label
    Friend WithEvents PictureBoxUserImage As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PanelConnection As Panel
    Friend WithEvents ComboBoxBaudRate As ComboBox
    Friend WithEvents ButtonConnect As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents ComboBoxPort As ComboBox
    Friend WithEvents ButtonScanPort As Button
    Friend WithEvents PanelTopHeader As Panel
    Friend WithEvents RFIDdatabaseDataSet As RFIDdatabaseDataSet
    Friend WithEvents StudentInfoBindingSource As BindingSource
    Friend WithEvents StudentInfoTableAdapter As RFIDdatabaseDataSetTableAdapters.StudentInfoTableAdapter
    Friend WithEvents RFIDdatabaseDataSet1 As RFIDdatabaseDataSet1
    Friend WithEvents StudentInfoBindingSource1 As BindingSource
    Friend WithEvents StudentInfoTableAdapter1 As RFIDdatabaseDataSet1TableAdapters.StudentInfoTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents PanelMasterlist As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents DBTABLE2 As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents PictureBoxImageInput2 As PictureBox
    Friend WithEvents TextBoxImage2 As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TextBoxDepartment2 As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents TextBoxGrade2 As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents TextBoxLRN2 As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents TextBoxName2 As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents TextBoxRFID2 As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents RFIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LRNDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GRADEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DEPARTMENTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IMAGEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
