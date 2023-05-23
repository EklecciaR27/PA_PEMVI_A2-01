<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManagerForm
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
        Me.lblSelectedLogout = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblSelectedLaporan = New System.Windows.Forms.Label()
        Me.btnLaporan = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.pnlControl = New System.Windows.Forms.Panel()
        Me.btnMin = New System.Windows.Forms.Button()
        Me.btnMax = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.pnlLaporan = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvRiwayatPsn = New System.Windows.Forms.DataGridView()
        Me.dgvRiwayatPbl = New System.Windows.Forms.DataGridView()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.pnlLeft.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        Me.pnlControl.SuspendLayout()
        Me.pnlLaporan.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvRiwayatPsn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRiwayatPbl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlLeft
        '
        Me.pnlLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.pnlLeft.Controls.Add(Me.lblSelectedLogout)
        Me.pnlLeft.Controls.Add(Me.btnLogout)
        Me.pnlLeft.Controls.Add(Me.lblSelectedLaporan)
        Me.pnlLeft.Controls.Add(Me.btnLaporan)
        Me.pnlLeft.Controls.Add(Me.Label1)
        Me.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeft.Location = New System.Drawing.Point(0, 0)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(261, 776)
        Me.pnlLeft.TabIndex = 0
        '
        'lblSelectedLogout
        '
        Me.lblSelectedLogout.BackColor = System.Drawing.Color.DimGray
        Me.lblSelectedLogout.Location = New System.Drawing.Point(-5, 718)
        Me.lblSelectedLogout.Name = "lblSelectedLogout"
        Me.lblSelectedLogout.Size = New System.Drawing.Size(10, 30)
        Me.lblSelectedLogout.TabIndex = 25
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
        Me.btnLogout.TabIndex = 24
        Me.btnLogout.Text = "       Logout"
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'lblSelectedLaporan
        '
        Me.lblSelectedLaporan.BackColor = System.Drawing.Color.DimGray
        Me.lblSelectedLaporan.Location = New System.Drawing.Point(-5, 112)
        Me.lblSelectedLaporan.Name = "lblSelectedLaporan"
        Me.lblSelectedLaporan.Size = New System.Drawing.Size(10, 30)
        Me.lblSelectedLaporan.TabIndex = 23
        Me.lblSelectedLaporan.Text = " "
        '
        'btnLaporan
        '
        Me.btnLaporan.BackColor = System.Drawing.Color.Transparent
        Me.btnLaporan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLaporan.FlatAppearance.BorderSize = 0
        Me.btnLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLaporan.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnLaporan.ForeColor = System.Drawing.Color.DimGray
        Me.btnLaporan.Image = Global.SistemPenjualanElektronik.My.Resources.Resources.report
        Me.btnLaporan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLaporan.Location = New System.Drawing.Point(-1, 105)
        Me.btnLaporan.Name = "btnLaporan"
        Me.btnLaporan.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnLaporan.Size = New System.Drawing.Size(262, 43)
        Me.btnLaporan.TabIndex = 22
        Me.btnLaporan.Text = "       Laporan Penjualan"
        Me.btnLaporan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLaporan.UseVisualStyleBackColor = False
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
        'pnlLaporan
        '
        Me.pnlLaporan.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.pnlLaporan.Controls.Add(Me.GroupBox2)
        Me.pnlLaporan.Controls.Add(Me.Label3)
        Me.pnlLaporan.Controls.Add(Me.Label4)
        Me.pnlLaporan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLaporan.Location = New System.Drawing.Point(261, 51)
        Me.pnlLaporan.Name = "pnlLaporan"
        Me.pnlLaporan.Size = New System.Drawing.Size(1099, 725)
        Me.pnlLaporan.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(35, 74)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1027, 613)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.txtTotal)
        Me.GroupBox3.Controls.Add(Me.dgvRiwayatPsn)
        Me.GroupBox3.Controls.Add(Me.dgvRiwayatPbl)
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Controls.Add(Me.TextBox3)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox3.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1027, 613)
        Me.GroupBox3.TabIndex = 26
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
        Me.dgvRiwayatPsn.Size = New System.Drawing.Size(498, 500)
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
        Me.dgvRiwayatPbl.Size = New System.Drawing.Size(446, 500)
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
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(33, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(186, 3)
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
        Me.Label4.Size = New System.Drawing.Size(194, 24)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "LAPORAN PENJUALAN"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(29, 575)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(65, 20)
        Me.TextBox1.TabIndex = 120
        Me.TextBox1.Text = "TOTAL"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.txtTotal.ForeColor = System.Drawing.Color.DarkGray
        Me.txtTotal.Location = New System.Drawing.Point(112, 571)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(253, 27)
        Me.txtTotal.TabIndex = 119
        '
        'ManagerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1360, 776)
        Me.Controls.Add(Me.pnlLaporan)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlLeft)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ManagerForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ManagerForm"
        Me.pnlLeft.ResumeLayout(False)
        Me.pnlTop.ResumeLayout(False)
        Me.pnlControl.ResumeLayout(False)
        Me.pnlLaporan.ResumeLayout(False)
        Me.pnlLaporan.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvRiwayatPsn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRiwayatPbl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlLeft As Panel
    Friend WithEvents pnlTop As Panel
    Friend WithEvents pnlLaporan As Panel
    Friend WithEvents pnlControl As Panel
    Friend WithEvents btnMin As Button
    Friend WithEvents btnMax As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblSelectedLaporan As Label
    Friend WithEvents btnLaporan As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblSelectedLogout As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dgvRiwayatPsn As DataGridView
    Friend WithEvents dgvRiwayatPbl As DataGridView
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtTotal As TextBox
End Class
