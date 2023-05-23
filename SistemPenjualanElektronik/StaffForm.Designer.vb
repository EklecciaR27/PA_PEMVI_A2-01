<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StaffForm
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
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblSelectedManageBarang = New System.Windows.Forms.Label()
        Me.btnMenuManageBarang = New System.Windows.Forms.Button()
        Me.lblSelectedLogout = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblSelectedManagePem = New System.Windows.Forms.Label()
        Me.btnMenuManagePem = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.pnlControl = New System.Windows.Forms.Panel()
        Me.btnMin = New System.Windows.Forms.Button()
        Me.btnMax = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.pnlManageDataBarang = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnCancelBarang = New System.Windows.Forms.Button()
        Me.btnAddBarang = New System.Windows.Forms.Button()
        Me.btnDelBarang = New System.Windows.Forms.Button()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.cbCariBarang = New System.Windows.Forms.ComboBox()
        Me.txtNamaBarang = New System.Windows.Forms.TextBox()
        Me.cmbSupplier = New System.Windows.Forms.ComboBox()
        Me.cmbJenisBarang = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtCariBarang = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtStokBarang = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtIDBarang = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnUpdateBarang = New System.Windows.Forms.Button()
        Me.dgvBarang = New System.Windows.Forms.DataGridView()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnlManagePembelian = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.bKonfirmasi = New System.Windows.Forms.Button()
        Me.dgvPesanan = New System.Windows.Forms.DataGridView()
        Me.dgvPembelian = New System.Windows.Forms.DataGridView()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pnlLeft.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        Me.pnlControl.SuspendLayout()
        Me.pnlManageDataBarang.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        CType(Me.dgvBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlManagePembelian.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvPesanan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPembelian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlLeft
        '
        Me.pnlLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.pnlLeft.Controls.Add(Me.Panel1)
        Me.pnlLeft.Controls.Add(Me.Label1)
        Me.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeft.Location = New System.Drawing.Point(0, 0)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(261, 776)
        Me.pnlLeft.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblSelectedManageBarang)
        Me.Panel1.Controls.Add(Me.btnMenuManageBarang)
        Me.Panel1.Controls.Add(Me.lblSelectedLogout)
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.lblSelectedManagePem)
        Me.Panel1.Controls.Add(Me.btnMenuManagePem)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(261, 776)
        Me.Panel1.TabIndex = 3
        '
        'lblSelectedManageBarang
        '
        Me.lblSelectedManageBarang.BackColor = System.Drawing.Color.DimGray
        Me.lblSelectedManageBarang.Location = New System.Drawing.Point(-5, 181)
        Me.lblSelectedManageBarang.Name = "lblSelectedManageBarang"
        Me.lblSelectedManageBarang.Size = New System.Drawing.Size(10, 30)
        Me.lblSelectedManageBarang.TabIndex = 29
        Me.lblSelectedManageBarang.Text = " "
        Me.lblSelectedManageBarang.Visible = False
        '
        'btnMenuManageBarang
        '
        Me.btnMenuManageBarang.BackColor = System.Drawing.Color.Transparent
        Me.btnMenuManageBarang.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenuManageBarang.FlatAppearance.BorderSize = 0
        Me.btnMenuManageBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuManageBarang.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnMenuManageBarang.ForeColor = System.Drawing.Color.DimGray
        Me.btnMenuManageBarang.Image = Global.SistemPenjualanElektronik.My.Resources.Resources.troli
        Me.btnMenuManageBarang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMenuManageBarang.Location = New System.Drawing.Point(-1, 174)
        Me.btnMenuManageBarang.Name = "btnMenuManageBarang"
        Me.btnMenuManageBarang.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnMenuManageBarang.Size = New System.Drawing.Size(262, 43)
        Me.btnMenuManageBarang.TabIndex = 28
        Me.btnMenuManageBarang.Text = "       Manage Data Barang"
        Me.btnMenuManageBarang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMenuManageBarang.UseVisualStyleBackColor = False
        '
        'lblSelectedLogout
        '
        Me.lblSelectedLogout.BackColor = System.Drawing.Color.DimGray
        Me.lblSelectedLogout.Location = New System.Drawing.Point(-5, 718)
        Me.lblSelectedLogout.Name = "lblSelectedLogout"
        Me.lblSelectedLogout.Size = New System.Drawing.Size(10, 30)
        Me.lblSelectedLogout.TabIndex = 23
        Me.lblSelectedLogout.Text = " "
        Me.lblSelectedLogout.Visible = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Transparent
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Calibri", 12.5!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.ForeColor = System.Drawing.Color.DimGray
        Me.btnLogout.Image = Global.SistemPenjualanElektronik.My.Resources.Resources.logout2
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(-1, 711)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnLogout.Size = New System.Drawing.Size(262, 43)
        Me.btnLogout.TabIndex = 22
        Me.btnLogout.Text = "       Logout"
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'lblSelectedManagePem
        '
        Me.lblSelectedManagePem.BackColor = System.Drawing.Color.DimGray
        Me.lblSelectedManagePem.Location = New System.Drawing.Point(-5, 112)
        Me.lblSelectedManagePem.Name = "lblSelectedManagePem"
        Me.lblSelectedManagePem.Size = New System.Drawing.Size(10, 30)
        Me.lblSelectedManagePem.TabIndex = 19
        Me.lblSelectedManagePem.Text = " "
        '
        'btnMenuManagePem
        '
        Me.btnMenuManagePem.BackColor = System.Drawing.Color.Transparent
        Me.btnMenuManagePem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenuManagePem.FlatAppearance.BorderSize = 0
        Me.btnMenuManagePem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuManagePem.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnMenuManagePem.ForeColor = System.Drawing.Color.DimGray
        Me.btnMenuManagePem.Image = Global.SistemPenjualanElektronik.My.Resources.Resources.list
        Me.btnMenuManagePem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMenuManagePem.Location = New System.Drawing.Point(-1, 105)
        Me.btnMenuManagePem.Name = "btnMenuManagePem"
        Me.btnMenuManagePem.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnMenuManagePem.Size = New System.Drawing.Size(262, 43)
        Me.btnMenuManagePem.TabIndex = 18
        Me.btnMenuManagePem.Text = "       Manage Pembelian"
        Me.btnMenuManagePem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMenuManagePem.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Image = Global.SistemPenjualanElektronik.My.Resources.Resources.logo_landing1
        Me.Label2.Location = New System.Drawing.Point(62, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 55)
        Me.Label2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Image = Global.SistemPenjualanElektronik.My.Resources.Resources.logo_landing1
        Me.Label1.Location = New System.Drawing.Point(62, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 55)
        Me.Label1.TabIndex = 1
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.Silver
        Me.pnlTop.Controls.Add(Me.pnlControl)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(261, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1099, 51)
        Me.pnlTop.TabIndex = 1
        '
        'pnlControl
        '
        Me.pnlControl.Controls.Add(Me.btnMin)
        Me.pnlControl.Controls.Add(Me.btnMax)
        Me.pnlControl.Controls.Add(Me.btnExit)
        Me.pnlControl.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlControl.Location = New System.Drawing.Point(974, 0)
        Me.pnlControl.Name = "pnlControl"
        Me.pnlControl.Size = New System.Drawing.Size(125, 51)
        Me.pnlControl.TabIndex = 1
        '
        'btnMin
        '
        Me.btnMin.FlatAppearance.BorderSize = 0
        Me.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMin.Image = Global.SistemPenjualanElektronik.My.Resources.Resources.minimize
        Me.btnMin.Location = New System.Drawing.Point(21, 13)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(25, 25)
        Me.btnMin.TabIndex = 2
        Me.btnMin.UseVisualStyleBackColor = True
        '
        'btnMax
        '
        Me.btnMax.FlatAppearance.BorderSize = 0
        Me.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMax.Image = Global.SistemPenjualanElektronik.My.Resources.Resources.maximize
        Me.btnMax.Location = New System.Drawing.Point(52, 13)
        Me.btnMax.Name = "btnMax"
        Me.btnMax.Size = New System.Drawing.Size(25, 25)
        Me.btnMax.TabIndex = 1
        Me.btnMax.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Image = Global.SistemPenjualanElektronik.My.Resources.Resources.close1
        Me.btnExit.Location = New System.Drawing.Point(83, 13)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(25, 25)
        Me.btnExit.TabIndex = 0
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'pnlManageDataBarang
        '
        Me.pnlManageDataBarang.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.pnlManageDataBarang.Controls.Add(Me.GroupBox4)
        Me.pnlManageDataBarang.Controls.Add(Me.Label3)
        Me.pnlManageDataBarang.Controls.Add(Me.Label4)
        Me.pnlManageDataBarang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlManageDataBarang.Location = New System.Drawing.Point(261, 51)
        Me.pnlManageDataBarang.Name = "pnlManageDataBarang"
        Me.pnlManageDataBarang.Size = New System.Drawing.Size(1099, 725)
        Me.pnlManageDataBarang.TabIndex = 3
        Me.pnlManageDataBarang.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.btnCancelBarang)
        Me.GroupBox4.Controls.Add(Me.btnAddBarang)
        Me.GroupBox4.Controls.Add(Me.btnDelBarang)
        Me.GroupBox4.Controls.Add(Me.GroupBox10)
        Me.GroupBox4.Controls.Add(Me.btnUpdateBarang)
        Me.GroupBox4.Controls.Add(Me.dgvBarang)
        Me.GroupBox4.Controls.Add(Me.TextBox7)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox4.Location = New System.Drawing.Point(35, 74)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1027, 613)
        Me.GroupBox4.TabIndex = 26
        Me.GroupBox4.TabStop = False
        '
        'btnCancelBarang
        '
        Me.btnCancelBarang.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btnCancelBarang.FlatAppearance.BorderSize = 0
        Me.btnCancelBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelBarang.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancelBarang.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCancelBarang.Location = New System.Drawing.Point(917, 304)
        Me.btnCancelBarang.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelBarang.Name = "btnCancelBarang"
        Me.btnCancelBarang.Size = New System.Drawing.Size(91, 41)
        Me.btnCancelBarang.TabIndex = 101
        Me.btnCancelBarang.Text = "Cancel"
        Me.btnCancelBarang.UseVisualStyleBackColor = False
        '
        'btnAddBarang
        '
        Me.btnAddBarang.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btnAddBarang.FlatAppearance.BorderSize = 0
        Me.btnAddBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddBarang.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddBarang.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAddBarang.Location = New System.Drawing.Point(917, 102)
        Me.btnAddBarang.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddBarang.Name = "btnAddBarang"
        Me.btnAddBarang.Size = New System.Drawing.Size(91, 41)
        Me.btnAddBarang.TabIndex = 102
        Me.btnAddBarang.Text = "Tambah"
        Me.btnAddBarang.UseVisualStyleBackColor = False
        '
        'btnDelBarang
        '
        Me.btnDelBarang.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btnDelBarang.FlatAppearance.BorderSize = 0
        Me.btnDelBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelBarang.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold)
        Me.btnDelBarang.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDelBarang.Location = New System.Drawing.Point(917, 236)
        Me.btnDelBarang.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelBarang.Name = "btnDelBarang"
        Me.btnDelBarang.Size = New System.Drawing.Size(91, 41)
        Me.btnDelBarang.TabIndex = 92
        Me.btnDelBarang.Text = "Hapus"
        Me.btnDelBarang.UseVisualStyleBackColor = False
        '
        'GroupBox10
        '
        Me.GroupBox10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.GroupBox10.Controls.Add(Me.RadioButton3)
        Me.GroupBox10.Controls.Add(Me.RadioButton2)
        Me.GroupBox10.Controls.Add(Me.RadioButton1)
        Me.GroupBox10.Controls.Add(Me.cbCariBarang)
        Me.GroupBox10.Controls.Add(Me.txtNamaBarang)
        Me.GroupBox10.Controls.Add(Me.cmbSupplier)
        Me.GroupBox10.Controls.Add(Me.cmbJenisBarang)
        Me.GroupBox10.Controls.Add(Me.Label25)
        Me.GroupBox10.Controls.Add(Me.txtCariBarang)
        Me.GroupBox10.Controls.Add(Me.Label23)
        Me.GroupBox10.Controls.Add(Me.txtHarga)
        Me.GroupBox10.Controls.Add(Me.Label24)
        Me.GroupBox10.Controls.Add(Me.txtStokBarang)
        Me.GroupBox10.Controls.Add(Me.Label14)
        Me.GroupBox10.Controls.Add(Me.Label9)
        Me.GroupBox10.Controls.Add(Me.Label10)
        Me.GroupBox10.Controls.Add(Me.txtIDBarang)
        Me.GroupBox10.Controls.Add(Me.Label13)
        Me.GroupBox10.Location = New System.Drawing.Point(29, 69)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(870, 302)
        Me.GroupBox10.TabIndex = 101
        Me.GroupBox10.TabStop = False
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.RadioButton3.Location = New System.Drawing.Point(419, 249)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(62, 20)
        Me.RadioButton3.TabIndex = 115
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Listrik"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.RadioButton2.Location = New System.Drawing.Point(273, 249)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(121, 20)
        Me.RadioButton2.TabIndex = 114
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Baterai Charge"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.RadioButton1.Location = New System.Drawing.Point(174, 249)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(70, 20)
        Me.RadioButton1.TabIndex = 113
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Baterai"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'cbCariBarang
        '
        Me.cbCariBarang.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cbCariBarang.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.cbCariBarang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cbCariBarang.FormattingEnabled = True
        Me.cbCariBarang.Items.AddRange(New Object() {"ID Barang", "Nama Barang", "Supplier"})
        Me.cbCariBarang.Location = New System.Drawing.Point(463, 26)
        Me.cbCariBarang.Name = "cbCariBarang"
        Me.cbCariBarang.Size = New System.Drawing.Size(308, 27)
        Me.cbCariBarang.TabIndex = 112
        '
        'txtNamaBarang
        '
        Me.txtNamaBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNamaBarang.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtNamaBarang.Location = New System.Drawing.Point(174, 140)
        Me.txtNamaBarang.Name = "txtNamaBarang"
        Me.txtNamaBarang.Size = New System.Drawing.Size(246, 26)
        Me.txtNamaBarang.TabIndex = 111
        '
        'cmbSupplier
        '
        Me.cmbSupplier.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmbSupplier.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.cmbSupplier.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbSupplier.FormattingEnabled = True
        Me.cmbSupplier.Location = New System.Drawing.Point(600, 140)
        Me.cmbSupplier.Name = "cmbSupplier"
        Me.cmbSupplier.Size = New System.Drawing.Size(246, 27)
        Me.cmbSupplier.TabIndex = 110
        '
        'cmbJenisBarang
        '
        Me.cmbJenisBarang.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmbJenisBarang.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.cmbJenisBarang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cmbJenisBarang.FormattingEnabled = True
        Me.cmbJenisBarang.Items.AddRange(New Object() {"Televisi", "Kulkas", "Freezer", "Blender", "Audio Speaker", "Air Conditioner", "Kipas Angin"})
        Me.cmbJenisBarang.Location = New System.Drawing.Point(174, 193)
        Me.cmbJenisBarang.Name = "cmbJenisBarang"
        Me.cmbJenisBarang.Size = New System.Drawing.Size(246, 27)
        Me.cmbJenisBarang.TabIndex = 99
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.Label25.Location = New System.Drawing.Point(481, 193)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(59, 21)
        Me.Label25.TabIndex = 109
        Me.Label25.Text = "Harga"
        '
        'txtCariBarang
        '
        Me.txtCariBarang.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.txtCariBarang.ForeColor = System.Drawing.Color.DarkGray
        Me.txtCariBarang.Location = New System.Drawing.Point(94, 26)
        Me.txtCariBarang.Name = "txtCariBarang"
        Me.txtCariBarang.Size = New System.Drawing.Size(349, 27)
        Me.txtCariBarang.TabIndex = 98
        Me.txtCariBarang.Text = "Cari..."
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.Label23.Location = New System.Drawing.Point(481, 140)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(76, 21)
        Me.Label23.TabIndex = 108
        Me.Label23.Text = "Supplier"
        '
        'txtHarga
        '
        Me.txtHarga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHarga.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtHarga.Location = New System.Drawing.Point(600, 193)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(246, 26)
        Me.txtHarga.TabIndex = 107
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.Label24.Location = New System.Drawing.Point(481, 86)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(46, 21)
        Me.Label24.TabIndex = 106
        Me.Label24.Text = "Stok"
        '
        'txtStokBarang
        '
        Me.txtStokBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStokBarang.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtStokBarang.Location = New System.Drawing.Point(600, 86)
        Me.txtStokBarang.Name = "txtStokBarang"
        Me.txtStokBarang.Size = New System.Drawing.Size(246, 26)
        Me.txtStokBarang.TabIndex = 105
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.Label14.Location = New System.Drawing.Point(26, 248)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(101, 21)
        Me.Label14.TabIndex = 100
        Me.Label14.Text = "Asal Energi"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.Label9.Location = New System.Drawing.Point(26, 140)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 21)
        Me.Label9.TabIndex = 93
        Me.Label9.Text = "Nama Barang"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.Label10.Location = New System.Drawing.Point(26, 86)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 21)
        Me.Label10.TabIndex = 99
        Me.Label10.Text = "ID Barang"
        '
        'txtIDBarang
        '
        Me.txtIDBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIDBarang.Enabled = False
        Me.txtIDBarang.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtIDBarang.Location = New System.Drawing.Point(174, 86)
        Me.txtIDBarang.Name = "txtIDBarang"
        Me.txtIDBarang.Size = New System.Drawing.Size(246, 26)
        Me.txtIDBarang.TabIndex = 94
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.Label13.Location = New System.Drawing.Point(26, 193)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(115, 21)
        Me.Label13.TabIndex = 95
        Me.Label13.Text = "Jenis Barang"
        '
        'btnUpdateBarang
        '
        Me.btnUpdateBarang.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btnUpdateBarang.FlatAppearance.BorderSize = 0
        Me.btnUpdateBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateBarang.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold)
        Me.btnUpdateBarang.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnUpdateBarang.Location = New System.Drawing.Point(917, 167)
        Me.btnUpdateBarang.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdateBarang.Name = "btnUpdateBarang"
        Me.btnUpdateBarang.Size = New System.Drawing.Size(91, 41)
        Me.btnUpdateBarang.TabIndex = 91
        Me.btnUpdateBarang.Text = "Ubah"
        Me.btnUpdateBarang.UseVisualStyleBackColor = False
        '
        'dgvBarang
        '
        Me.dgvBarang.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.dgvBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBarang.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dgvBarang.Location = New System.Drawing.Point(29, 386)
        Me.dgvBarang.Name = "dgvBarang"
        Me.dgvBarang.RowHeadersWidth = 51
        Me.dgvBarang.RowTemplate.Height = 24
        Me.dgvBarang.Size = New System.Drawing.Size(969, 202)
        Me.dgvBarang.TabIndex = 90
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox7.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.TextBox7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.TextBox7.Location = New System.Drawing.Point(29, 26)
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(771, 31)
        Me.TextBox7.TabIndex = 61
        Me.TextBox7.Text = "*Data yang dapat dikelola oleh staff merupakan data barang yang terdapat di datab" &
    "ase sistem."
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(33, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(204, 3)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = " "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(29, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(212, 24)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "MANAGE DATA BARANG"
        '
        'pnlManagePembelian
        '
        Me.pnlManagePembelian.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.pnlManagePembelian.Controls.Add(Me.GroupBox3)
        Me.pnlManagePembelian.Controls.Add(Me.Label7)
        Me.pnlManagePembelian.Controls.Add(Me.Label8)
        Me.pnlManagePembelian.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlManagePembelian.Location = New System.Drawing.Point(261, 51)
        Me.pnlManagePembelian.Name = "pnlManagePembelian"
        Me.pnlManagePembelian.Size = New System.Drawing.Size(1099, 725)
        Me.pnlManagePembelian.TabIndex = 5
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.bKonfirmasi)
        Me.GroupBox3.Controls.Add(Me.dgvPesanan)
        Me.GroupBox3.Controls.Add(Me.dgvPembelian)
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Controls.Add(Me.TextBox3)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox3.Location = New System.Drawing.Point(35, 74)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1027, 613)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        '
        'bKonfirmasi
        '
        Me.bKonfirmasi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bKonfirmasi.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.bKonfirmasi.FlatAppearance.BorderSize = 0
        Me.bKonfirmasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bKonfirmasi.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold)
        Me.bKonfirmasi.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bKonfirmasi.Location = New System.Drawing.Point(159, 570)
        Me.bKonfirmasi.Margin = New System.Windows.Forms.Padding(5)
        Me.bKonfirmasi.Name = "bKonfirmasi"
        Me.bKonfirmasi.Size = New System.Drawing.Size(699, 33)
        Me.bKonfirmasi.TabIndex = 122
        Me.bKonfirmasi.Text = "KONFIRMASI PESANAN"
        Me.bKonfirmasi.UseVisualStyleBackColor = False
        '
        'dgvPesanan
        '
        Me.dgvPesanan.AllowUserToAddRows = False
        Me.dgvPesanan.AllowUserToDeleteRows = False
        Me.dgvPesanan.AllowUserToOrderColumns = True
        Me.dgvPesanan.AllowUserToResizeColumns = False
        Me.dgvPesanan.AllowUserToResizeRows = False
        Me.dgvPesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPesanan.Location = New System.Drawing.Point(499, 61)
        Me.dgvPesanan.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvPesanan.Name = "dgvPesanan"
        Me.dgvPesanan.RowHeadersWidth = 51
        Me.dgvPesanan.Size = New System.Drawing.Size(498, 500)
        Me.dgvPesanan.TabIndex = 68
        '
        'dgvPembelian
        '
        Me.dgvPembelian.AllowUserToAddRows = False
        Me.dgvPembelian.AllowUserToDeleteRows = False
        Me.dgvPembelian.AllowUserToOrderColumns = True
        Me.dgvPembelian.AllowUserToResizeColumns = False
        Me.dgvPembelian.AllowUserToResizeRows = False
        Me.dgvPembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPembelian.Location = New System.Drawing.Point(28, 61)
        Me.dgvPembelian.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvPembelian.Name = "dgvPembelian"
        Me.dgvPembelian.RowHeadersWidth = 51
        Me.dgvPembelian.Size = New System.Drawing.Size(446, 500)
        Me.dgvPembelian.TabIndex = 67
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.TextBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.TextBox2.Location = New System.Drawing.Point(28, 31)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(446, 31)
        Me.TextBox2.TabIndex = 66
        Me.TextBox2.Text = "Data Pembelian"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.TextBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.TextBox3.Location = New System.Drawing.Point(499, 31)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(446, 31)
        Me.TextBox3.TabIndex = 69
        Me.TextBox3.Text = "Detail Pembelian"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(33, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(179, 3)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = " "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(29, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(189, 24)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "MANAGE PEMBELIAN"
        '
        'StaffForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1360, 776)
        Me.Controls.Add(Me.pnlManageDataBarang)
        Me.Controls.Add(Me.pnlManagePembelian)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlLeft)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StaffForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StaffForm"
        Me.pnlLeft.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.pnlTop.ResumeLayout(False)
        Me.pnlControl.ResumeLayout(False)
        Me.pnlManageDataBarang.ResumeLayout(False)
        Me.pnlManageDataBarang.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        CType(Me.dgvBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlManagePembelian.ResumeLayout(False)
        Me.pnlManagePembelian.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvPesanan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPembelian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlLeft As Panel
    Friend WithEvents pnlTop As Panel
    Friend WithEvents pnlManageDataProduk As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlControl As Panel
    Friend WithEvents btnMin As Button
    Friend WithEvents btnMax As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents pnlHistori As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents pnlPembelian As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblSelectedManageBarang As Label
    Friend WithEvents btnMenuManageBarang As Button
    Friend WithEvents lblSelectedLogout As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblSelectedManagePem As Label
    Friend WithEvents btnMenuManagePem As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlManageDataBarang As Panel
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnCancelBarang As Button
    Friend WithEvents btnAddBarang As Button
    Friend WithEvents btnDelBarang As Button
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents cbCariBarang As ComboBox
    Friend WithEvents txtNamaBarang As TextBox
    Friend WithEvents cmbSupplier As ComboBox
    Friend WithEvents cmbJenisBarang As ComboBox
    Friend WithEvents Label25 As Label
    Friend WithEvents txtCariBarang As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtStokBarang As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtIDBarang As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents btnUpdateBarang As Button
    Friend WithEvents dgvBarang As DataGridView
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents pnlManagePembelian As Panel
    Friend WithEvents dgvPesanan As DataGridView
    Friend WithEvents dgvPembelian As DataGridView
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents bKonfirmasi As Button
End Class
