<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserForm
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
        Me.lblSelectedLogout = New System.Windows.Forms.Label()
        Me.lblSelectedRiwayat = New System.Windows.Forms.Label()
        Me.lblSelectedPembelian = New System.Windows.Forms.Label()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.pnlControl = New System.Windows.Forms.Panel()
        Me.pnlRiwayat = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvRiwayatPsn = New System.Windows.Forms.DataGridView()
        Me.dgvRiwayatPbl = New System.Windows.Forms.DataGridView()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pnlPembelian = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.AddPanel = New System.Windows.Forms.Panel()
        Me.AddJenis = New System.Windows.Forms.Label()
        Me.AddEnergi = New System.Windows.Forms.Label()
        Me.AddSupllier = New System.Windows.Forms.Label()
        Me.AddNama = New System.Windows.Forms.Label()
        Me.AddId = New System.Windows.Forms.Label()
        Me.AddHarga = New System.Windows.Forms.Label()
        Me.AddStok = New System.Windows.Forms.Label()
        Me.txtAdd = New System.Windows.Forms.TextBox()
        Me.bAddCancel = New System.Windows.Forms.Button()
        Me.bAddDone = New System.Windows.Forms.Button()
        Me.bAddMin = New System.Windows.Forms.Button()
        Me.bAddPlus = New System.Windows.Forms.Button()
        Me.dgvBarang = New System.Windows.Forms.DataGridView()
        Me.dgvPesanan = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bReset = New System.Windows.Forms.Button()
        Me.btnPesan = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.cbCariBarang = New System.Windows.Forms.ComboBox()
        Me.txtCariBarang = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.btnMin = New System.Windows.Forms.Button()
        Me.btnMax = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnMenuRiwayat = New System.Windows.Forms.Button()
        Me.btnMenuPembelian = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlLeft.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        Me.pnlControl.SuspendLayout()
        Me.pnlRiwayat.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvRiwayatPsn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRiwayatPbl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPembelian.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.AddPanel.SuspendLayout()
        CType(Me.dgvBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPesanan, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnlLeft.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblSelectedLogout)
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.lblSelectedRiwayat)
        Me.Panel1.Controls.Add(Me.btnMenuRiwayat)
        Me.Panel1.Controls.Add(Me.lblSelectedPembelian)
        Me.Panel1.Controls.Add(Me.btnMenuPembelian)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(261, 776)
        Me.Panel1.TabIndex = 27
        '
        'lblSelectedLogout
        '
        Me.lblSelectedLogout.BackColor = System.Drawing.Color.DimGray
        Me.lblSelectedLogout.Location = New System.Drawing.Point(-5, 718)
        Me.lblSelectedLogout.Name = "lblSelectedLogout"
        Me.lblSelectedLogout.Size = New System.Drawing.Size(10, 30)
        Me.lblSelectedLogout.TabIndex = 31
        Me.lblSelectedLogout.Text = " "
        Me.lblSelectedLogout.Visible = False
        '
        'lblSelectedRiwayat
        '
        Me.lblSelectedRiwayat.BackColor = System.Drawing.Color.DimGray
        Me.lblSelectedRiwayat.Location = New System.Drawing.Point(-5, 181)
        Me.lblSelectedRiwayat.Name = "lblSelectedRiwayat"
        Me.lblSelectedRiwayat.Size = New System.Drawing.Size(10, 30)
        Me.lblSelectedRiwayat.TabIndex = 29
        Me.lblSelectedRiwayat.Text = " "
        Me.lblSelectedRiwayat.Visible = False
        '
        'lblSelectedPembelian
        '
        Me.lblSelectedPembelian.BackColor = System.Drawing.Color.DimGray
        Me.lblSelectedPembelian.Location = New System.Drawing.Point(-5, 112)
        Me.lblSelectedPembelian.Name = "lblSelectedPembelian"
        Me.lblSelectedPembelian.Size = New System.Drawing.Size(10, 30)
        Me.lblSelectedPembelian.TabIndex = 19
        Me.lblSelectedPembelian.Text = " "
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.Silver
        Me.pnlTop.Controls.Add(Me.pnlControl)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(261, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1099, 51)
        Me.pnlTop.TabIndex = 2
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
        'pnlRiwayat
        '
        Me.pnlRiwayat.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.pnlRiwayat.Controls.Add(Me.GroupBox3)
        Me.pnlRiwayat.Controls.Add(Me.Label7)
        Me.pnlRiwayat.Controls.Add(Me.Label8)
        Me.pnlRiwayat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlRiwayat.Location = New System.Drawing.Point(261, 51)
        Me.pnlRiwayat.Name = "pnlRiwayat"
        Me.pnlRiwayat.Size = New System.Drawing.Size(1099, 725)
        Me.pnlRiwayat.TabIndex = 6
        Me.pnlRiwayat.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.dgvRiwayatPsn)
        Me.GroupBox3.Controls.Add(Me.dgvRiwayatPbl)
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Controls.Add(Me.TextBox3)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox3.Location = New System.Drawing.Point(35, 74)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1027, 613)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        '
        'dgvRiwayatPsn
        '
        Me.dgvRiwayatPsn.AllowUserToAddRows = False
        Me.dgvRiwayatPsn.AllowUserToDeleteRows = False
        Me.dgvRiwayatPsn.AllowUserToOrderColumns = True
        Me.dgvRiwayatPsn.AllowUserToResizeColumns = False
        Me.dgvRiwayatPsn.AllowUserToResizeRows = False
        Me.dgvRiwayatPsn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRiwayatPsn.Location = New System.Drawing.Point(500, 56)
        Me.dgvRiwayatPsn.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvRiwayatPsn.Name = "dgvRiwayatPsn"
        Me.dgvRiwayatPsn.RowHeadersWidth = 51
        Me.dgvRiwayatPsn.Size = New System.Drawing.Size(498, 519)
        Me.dgvRiwayatPsn.TabIndex = 64
        '
        'dgvRiwayatPbl
        '
        Me.dgvRiwayatPbl.AllowUserToAddRows = False
        Me.dgvRiwayatPbl.AllowUserToDeleteRows = False
        Me.dgvRiwayatPbl.AllowUserToOrderColumns = True
        Me.dgvRiwayatPbl.AllowUserToResizeColumns = False
        Me.dgvRiwayatPbl.AllowUserToResizeRows = False
        Me.dgvRiwayatPbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRiwayatPbl.Location = New System.Drawing.Point(29, 56)
        Me.dgvRiwayatPbl.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvRiwayatPbl.Name = "dgvRiwayatPbl"
        Me.dgvRiwayatPbl.RowHeadersWidth = 51
        Me.dgvRiwayatPbl.Size = New System.Drawing.Size(446, 519)
        Me.dgvRiwayatPbl.TabIndex = 63
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.TextBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.TextBox2.Location = New System.Drawing.Point(29, 26)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(446, 31)
        Me.TextBox2.TabIndex = 61
        Me.TextBox2.Text = "Data Pembelian"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(33, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(174, 3)
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
        Me.Label8.Size = New System.Drawing.Size(183, 24)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "RIWAYAT PEMBELIAN"
        '
        'pnlPembelian
        '
        Me.pnlPembelian.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.pnlPembelian.Controls.Add(Me.GroupBox2)
        Me.pnlPembelian.Controls.Add(Me.Label2)
        Me.pnlPembelian.Controls.Add(Me.Label3)
        Me.pnlPembelian.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlPembelian.Location = New System.Drawing.Point(261, 51)
        Me.pnlPembelian.Name = "pnlPembelian"
        Me.pnlPembelian.Size = New System.Drawing.Size(1099, 725)
        Me.pnlPembelian.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.AddPanel)
        Me.GroupBox2.Controls.Add(Me.dgvBarang)
        Me.GroupBox2.Controls.Add(Me.dgvPesanan)
        Me.GroupBox2.Controls.Add(Me.bReset)
        Me.GroupBox2.Controls.Add(Me.btnPesan)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.txtTotal)
        Me.GroupBox2.Controls.Add(Me.TextBox7)
        Me.GroupBox2.Controls.Add(Me.cbCariBarang)
        Me.GroupBox2.Controls.Add(Me.txtCariBarang)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(35, 74)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1027, 613)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        '
        'AddPanel
        '
        Me.AddPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.AddPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AddPanel.Controls.Add(Me.AddJenis)
        Me.AddPanel.Controls.Add(Me.AddEnergi)
        Me.AddPanel.Controls.Add(Me.AddSupllier)
        Me.AddPanel.Controls.Add(Me.AddNama)
        Me.AddPanel.Controls.Add(Me.AddId)
        Me.AddPanel.Controls.Add(Me.AddHarga)
        Me.AddPanel.Controls.Add(Me.AddStok)
        Me.AddPanel.Controls.Add(Me.txtAdd)
        Me.AddPanel.Controls.Add(Me.bAddCancel)
        Me.AddPanel.Controls.Add(Me.bAddDone)
        Me.AddPanel.Controls.Add(Me.bAddMin)
        Me.AddPanel.Controls.Add(Me.bAddPlus)
        Me.AddPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddPanel.Location = New System.Drawing.Point(732, 95)
        Me.AddPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.AddPanel.Name = "AddPanel"
        Me.AddPanel.Size = New System.Drawing.Size(266, 247)
        Me.AddPanel.TabIndex = 124
        Me.AddPanel.Visible = False
        '
        'AddJenis
        '
        Me.AddJenis.AutoSize = True
        Me.AddJenis.Location = New System.Drawing.Point(179, 21)
        Me.AddJenis.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AddJenis.Name = "AddJenis"
        Me.AddJenis.Size = New System.Drawing.Size(64, 14)
        Me.AddJenis.TabIndex = 130
        Me.AddJenis.Text = "placeHolder"
        Me.AddJenis.Visible = False
        '
        'AddEnergi
        '
        Me.AddEnergi.AutoSize = True
        Me.AddEnergi.Location = New System.Drawing.Point(4, 37)
        Me.AddEnergi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AddEnergi.Name = "AddEnergi"
        Me.AddEnergi.Size = New System.Drawing.Size(64, 14)
        Me.AddEnergi.TabIndex = 129
        Me.AddEnergi.Text = "placeHolder"
        Me.AddEnergi.Visible = False
        '
        'AddSupllier
        '
        Me.AddSupllier.AutoSize = True
        Me.AddSupllier.Location = New System.Drawing.Point(93, 20)
        Me.AddSupllier.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AddSupllier.Name = "AddSupllier"
        Me.AddSupllier.Size = New System.Drawing.Size(64, 14)
        Me.AddSupllier.TabIndex = 128
        Me.AddSupllier.Text = "placeHolder"
        Me.AddSupllier.Visible = False
        '
        'AddNama
        '
        Me.AddNama.AutoSize = True
        Me.AddNama.Location = New System.Drawing.Point(4, 20)
        Me.AddNama.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AddNama.Name = "AddNama"
        Me.AddNama.Size = New System.Drawing.Size(64, 14)
        Me.AddNama.TabIndex = 127
        Me.AddNama.Text = "placeHolder"
        Me.AddNama.Visible = False
        '
        'AddId
        '
        Me.AddId.AutoSize = True
        Me.AddId.Location = New System.Drawing.Point(177, 4)
        Me.AddId.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AddId.Name = "AddId"
        Me.AddId.Size = New System.Drawing.Size(64, 14)
        Me.AddId.TabIndex = 126
        Me.AddId.Text = "placeHolder"
        Me.AddId.Visible = False
        '
        'AddHarga
        '
        Me.AddHarga.AutoSize = True
        Me.AddHarga.Location = New System.Drawing.Point(93, 4)
        Me.AddHarga.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AddHarga.Name = "AddHarga"
        Me.AddHarga.Size = New System.Drawing.Size(64, 14)
        Me.AddHarga.TabIndex = 125
        Me.AddHarga.Text = "placeHolder"
        Me.AddHarga.Visible = False
        '
        'AddStok
        '
        Me.AddStok.AutoSize = True
        Me.AddStok.Location = New System.Drawing.Point(4, 4)
        Me.AddStok.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AddStok.Name = "AddStok"
        Me.AddStok.Size = New System.Drawing.Size(64, 14)
        Me.AddStok.TabIndex = 124
        Me.AddStok.Text = "placeHolder"
        Me.AddStok.Visible = False
        '
        'txtAdd
        '
        Me.txtAdd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAdd.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.txtAdd.ForeColor = System.Drawing.Color.DarkGray
        Me.txtAdd.Location = New System.Drawing.Point(91, 101)
        Me.txtAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAdd.Name = "txtAdd"
        Me.txtAdd.Size = New System.Drawing.Size(84, 27)
        Me.txtAdd.TabIndex = 121
        Me.txtAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'bAddCancel
        '
        Me.bAddCancel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bAddCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.bAddCancel.FlatAppearance.BorderSize = 0
        Me.bAddCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAddCancel.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold)
        Me.bAddCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bAddCancel.Location = New System.Drawing.Point(30, 191)
        Me.bAddCancel.Margin = New System.Windows.Forms.Padding(5)
        Me.bAddCancel.Name = "bAddCancel"
        Me.bAddCancel.Size = New System.Drawing.Size(51, 37)
        Me.bAddCancel.TabIndex = 123
        Me.bAddCancel.Text = "X"
        Me.bAddCancel.UseVisualStyleBackColor = False
        '
        'bAddDone
        '
        Me.bAddDone.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bAddDone.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.bAddDone.FlatAppearance.BorderSize = 0
        Me.bAddDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAddDone.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold)
        Me.bAddDone.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bAddDone.Location = New System.Drawing.Point(91, 191)
        Me.bAddDone.Margin = New System.Windows.Forms.Padding(5)
        Me.bAddDone.Name = "bAddDone"
        Me.bAddDone.Size = New System.Drawing.Size(145, 37)
        Me.bAddDone.TabIndex = 122
        Me.bAddDone.Text = "Tambah"
        Me.bAddDone.UseVisualStyleBackColor = False
        '
        'bAddMin
        '
        Me.bAddMin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bAddMin.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.bAddMin.FlatAppearance.BorderSize = 0
        Me.bAddMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAddMin.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold)
        Me.bAddMin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bAddMin.Location = New System.Drawing.Point(0, 95)
        Me.bAddMin.Margin = New System.Windows.Forms.Padding(5)
        Me.bAddMin.Name = "bAddMin"
        Me.bAddMin.Size = New System.Drawing.Size(55, 45)
        Me.bAddMin.TabIndex = 121
        Me.bAddMin.Text = "-"
        Me.bAddMin.UseVisualStyleBackColor = False
        '
        'bAddPlus
        '
        Me.bAddPlus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bAddPlus.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.bAddPlus.FlatAppearance.BorderSize = 0
        Me.bAddPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAddPlus.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold)
        Me.bAddPlus.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bAddPlus.Location = New System.Drawing.Point(209, 95)
        Me.bAddPlus.Margin = New System.Windows.Forms.Padding(5)
        Me.bAddPlus.Name = "bAddPlus"
        Me.bAddPlus.Size = New System.Drawing.Size(53, 45)
        Me.bAddPlus.TabIndex = 120
        Me.bAddPlus.Text = "+"
        Me.bAddPlus.UseVisualStyleBackColor = False
        '
        'dgvBarang
        '
        Me.dgvBarang.AllowUserToAddRows = False
        Me.dgvBarang.AllowUserToDeleteRows = False
        Me.dgvBarang.AllowUserToOrderColumns = True
        Me.dgvBarang.AllowUserToResizeColumns = False
        Me.dgvBarang.AllowUserToResizeRows = False
        Me.dgvBarang.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvBarang.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.dgvBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBarang.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvBarang.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dgvBarang.Location = New System.Drawing.Point(29, 95)
        Me.dgvBarang.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvBarang.MultiSelect = False
        Me.dgvBarang.Name = "dgvBarang"
        Me.dgvBarang.ReadOnly = True
        Me.dgvBarang.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgvBarang.RowTemplate.Height = 24
        Me.dgvBarang.Size = New System.Drawing.Size(969, 187)
        Me.dgvBarang.TabIndex = 123
        '
        'dgvPesanan
        '
        Me.dgvPesanan.AllowUserToAddRows = False
        Me.dgvPesanan.AllowUserToDeleteRows = False
        Me.dgvPesanan.AllowUserToOrderColumns = True
        Me.dgvPesanan.AllowUserToResizeColumns = False
        Me.dgvPesanan.AllowUserToResizeRows = False
        Me.dgvPesanan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPesanan.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.dgvPesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPesanan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.Column8, Me.Column9, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.Column7})
        Me.dgvPesanan.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dgvPesanan.Location = New System.Drawing.Point(29, 353)
        Me.dgvPesanan.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvPesanan.Name = "dgvPesanan"
        Me.dgvPesanan.RowHeadersWidth = 51
        Me.dgvPesanan.RowTemplate.Height = 24
        Me.dgvPesanan.Size = New System.Drawing.Size(969, 187)
        Me.dgvPesanan.TabIndex = 122
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "KODE"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "NAMA"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'Column8
        '
        Me.Column8.HeaderText = "JENIS"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 125
        '
        'Column9
        '
        Me.Column9.HeaderText = "ENERGI"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "SUPPLIER"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "JUMLAH"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "SUBTOTAL"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Column6"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Visible = False
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'Column7
        '
        Me.Column7.HeaderText = "Column7"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.Visible = False
        Me.Column7.Width = 125
        '
        'bReset
        '
        Me.bReset.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.bReset.FlatAppearance.BorderSize = 0
        Me.bReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bReset.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold)
        Me.bReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bReset.Location = New System.Drawing.Point(29, 21)
        Me.bReset.Margin = New System.Windows.Forms.Padding(5)
        Me.bReset.Name = "bReset"
        Me.bReset.Size = New System.Drawing.Size(104, 38)
        Me.bReset.TabIndex = 121
        Me.bReset.Text = "RESET"
        Me.bReset.UseVisualStyleBackColor = False
        '
        'btnPesan
        '
        Me.btnPesan.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btnPesan.FlatAppearance.BorderSize = 0
        Me.btnPesan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPesan.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold)
        Me.btnPesan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPesan.Location = New System.Drawing.Point(903, 556)
        Me.btnPesan.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPesan.Name = "btnPesan"
        Me.btnPesan.Size = New System.Drawing.Size(91, 38)
        Me.btnPesan.TabIndex = 119
        Me.btnPesan.Text = "PESAN"
        Me.btnPesan.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(640, 316)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(182, 20)
        Me.TextBox1.TabIndex = 118
        Me.TextBox1.Text = "TOTAL PEMBAYARAN"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.txtTotal.ForeColor = System.Drawing.Color.DarkGray
        Me.txtTotal.Location = New System.Drawing.Point(839, 312)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(159, 27)
        Me.txtTotal.TabIndex = 117
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox7.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.TextBox7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.TextBox7.Location = New System.Drawing.Point(29, 315)
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(120, 31)
        Me.TextBox7.TabIndex = 116
        Me.TextBox7.Text = "KERANJANG"
        '
        'cbCariBarang
        '
        Me.cbCariBarang.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cbCariBarang.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.cbCariBarang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.cbCariBarang.FormattingEnabled = True
        Me.cbCariBarang.Items.AddRange(New Object() {"ID Barang", "Nama Barang", "Supplier"})
        Me.cbCariBarang.Location = New System.Drawing.Point(799, 26)
        Me.cbCariBarang.Name = "cbCariBarang"
        Me.cbCariBarang.Size = New System.Drawing.Size(192, 27)
        Me.cbCariBarang.TabIndex = 114
        '
        'txtCariBarang
        '
        Me.txtCariBarang.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.txtCariBarang.ForeColor = System.Drawing.Color.DarkGray
        Me.txtCariBarang.Location = New System.Drawing.Point(481, 26)
        Me.txtCariBarang.Name = "txtCariBarang"
        Me.txtCariBarang.Size = New System.Drawing.Size(301, 27)
        Me.txtCariBarang.TabIndex = 113
        Me.txtCariBarang.Text = "Cari..."
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(33, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 3)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = " "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(29, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 24)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "PEMBELIAN"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.TextBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.TextBox3.Location = New System.Drawing.Point(500, 26)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(446, 31)
        Me.TextBox3.TabIndex = 65
        Me.TextBox3.Text = "Detail Pembelian"
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
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Transparent
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.ForeColor = System.Drawing.Color.DimGray
        Me.btnLogout.Image = Global.SistemPenjualanElektronik.My.Resources.Resources.logout2
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(-1, 711)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnLogout.Size = New System.Drawing.Size(262, 43)
        Me.btnLogout.TabIndex = 30
        Me.btnLogout.Text = "       Logout"
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnMenuRiwayat
        '
        Me.btnMenuRiwayat.BackColor = System.Drawing.Color.Transparent
        Me.btnMenuRiwayat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenuRiwayat.FlatAppearance.BorderSize = 0
        Me.btnMenuRiwayat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuRiwayat.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnMenuRiwayat.ForeColor = System.Drawing.Color.DimGray
        Me.btnMenuRiwayat.Image = Global.SistemPenjualanElektronik.My.Resources.Resources.histori
        Me.btnMenuRiwayat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMenuRiwayat.Location = New System.Drawing.Point(-1, 174)
        Me.btnMenuRiwayat.Name = "btnMenuRiwayat"
        Me.btnMenuRiwayat.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnMenuRiwayat.Size = New System.Drawing.Size(262, 43)
        Me.btnMenuRiwayat.TabIndex = 28
        Me.btnMenuRiwayat.Text = "       Riwayat"
        Me.btnMenuRiwayat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMenuRiwayat.UseVisualStyleBackColor = False
        '
        'btnMenuPembelian
        '
        Me.btnMenuPembelian.BackColor = System.Drawing.Color.Transparent
        Me.btnMenuPembelian.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenuPembelian.FlatAppearance.BorderSize = 0
        Me.btnMenuPembelian.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuPembelian.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnMenuPembelian.ForeColor = System.Drawing.Color.DimGray
        Me.btnMenuPembelian.Image = Global.SistemPenjualanElektronik.My.Resources.Resources.pembelian
        Me.btnMenuPembelian.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMenuPembelian.Location = New System.Drawing.Point(-1, 105)
        Me.btnMenuPembelian.Name = "btnMenuPembelian"
        Me.btnMenuPembelian.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnMenuPembelian.Size = New System.Drawing.Size(262, 43)
        Me.btnMenuPembelian.TabIndex = 18
        Me.btnMenuPembelian.Text = "       Pembelian"
        Me.btnMenuPembelian.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMenuPembelian.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.Image = Global.SistemPenjualanElektronik.My.Resources.Resources.logo_landing1
        Me.Label5.Location = New System.Drawing.Point(62, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 55)
        Me.Label5.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Image = Global.SistemPenjualanElektronik.My.Resources.Resources.logo_landing1
        Me.Label1.Location = New System.Drawing.Point(62, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 55)
        Me.Label1.TabIndex = 0
        '
        'UserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1360, 776)
        Me.Controls.Add(Me.pnlPembelian)
        Me.Controls.Add(Me.pnlRiwayat)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlLeft)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UserForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UserForm"
        Me.pnlLeft.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.pnlTop.ResumeLayout(False)
        Me.pnlControl.ResumeLayout(False)
        Me.pnlRiwayat.ResumeLayout(False)
        Me.pnlRiwayat.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvRiwayatPsn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRiwayatPbl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPembelian.ResumeLayout(False)
        Me.pnlPembelian.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.AddPanel.ResumeLayout(False)
        Me.AddPanel.PerformLayout()
        CType(Me.dgvBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPesanan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlLeft As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlTop As Panel
    Friend WithEvents pnlControl As Panel
    Friend WithEvents btnMin As Button
    Friend WithEvents btnMax As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents pnlRiwayat As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents pnlPembelian As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnPesan As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents cbCariBarang As ComboBox
    Friend WithEvents txtCariBarang As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblSelectedRiwayat As Label
    Friend WithEvents btnMenuRiwayat As Button
    Friend WithEvents lblSelectedPembelian As Label
    Friend WithEvents btnMenuPembelian As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents lblSelectedLogout As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents bReset As Button
    Friend WithEvents AddPanel As Panel
    Friend WithEvents AddJenis As Label
    Friend WithEvents AddEnergi As Label
    Friend WithEvents AddSupllier As Label
    Friend WithEvents AddNama As Label
    Friend WithEvents AddId As Label
    Friend WithEvents AddHarga As Label
    Friend WithEvents AddStok As Label
    Friend WithEvents txtAdd As TextBox
    Friend WithEvents bAddCancel As Button
    Friend WithEvents bAddDone As Button
    Friend WithEvents bAddMin As Button
    Friend WithEvents bAddPlus As Button
    Friend WithEvents dgvBarang As DataGridView
    Friend WithEvents dgvPesanan As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents dgvRiwayatPsn As DataGridView
    Friend WithEvents dgvRiwayatPbl As DataGridView
    Friend WithEvents TextBox3 As TextBox
End Class
