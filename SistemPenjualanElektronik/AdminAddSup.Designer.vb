<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminAddSup
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
        Me.btnExitAdd = New System.Windows.Forms.Button()
        Me.btnTambahSup = New System.Windows.Forms.Button()
        Me.txtIDSupplier = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtNamaSupplier = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtCPSupplier = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.btnCancelSup = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnExitAdd
        '
        Me.btnExitAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.btnExitAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExitAdd.FlatAppearance.BorderSize = 0
        Me.btnExitAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExitAdd.Image = Global.SistemPenjualanElektronik.My.Resources.Resources.close15px
        Me.btnExitAdd.Location = New System.Drawing.Point(424, 13)
        Me.btnExitAdd.Name = "btnExitAdd"
        Me.btnExitAdd.Size = New System.Drawing.Size(28, 26)
        Me.btnExitAdd.TabIndex = 4
        Me.btnExitAdd.UseVisualStyleBackColor = False
        '
        'btnTambahSup
        '
        Me.btnTambahSup.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btnTambahSup.FlatAppearance.BorderSize = 0
        Me.btnTambahSup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambahSup.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold)
        Me.btnTambahSup.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnTambahSup.Location = New System.Drawing.Point(104, 363)
        Me.btnTambahSup.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTambahSup.Name = "btnTambahSup"
        Me.btnTambahSup.Size = New System.Drawing.Size(91, 41)
        Me.btnTambahSup.TabIndex = 103
        Me.btnTambahSup.Text = "Tambah"
        Me.btnTambahSup.UseVisualStyleBackColor = False
        '
        'txtIDSupplier
        '
        Me.txtIDSupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIDSupplier.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtIDSupplier.Location = New System.Drawing.Point(176, 161)
        Me.txtIDSupplier.Name = "txtIDSupplier"
        Me.txtIDSupplier.Size = New System.Drawing.Size(276, 26)
        Me.txtIDSupplier.TabIndex = 109
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.Label18.Location = New System.Drawing.Point(15, 225)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(128, 21)
        Me.Label18.TabIndex = 104
        Me.Label18.Text = "Nama Supplier"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.Label19.Location = New System.Drawing.Point(16, 162)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(98, 21)
        Me.Label19.TabIndex = 108
        Me.Label19.Text = "ID Supplier"
        '
        'txtNamaSupplier
        '
        Me.txtNamaSupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNamaSupplier.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtNamaSupplier.Location = New System.Drawing.Point(176, 225)
        Me.txtNamaSupplier.Name = "txtNamaSupplier"
        Me.txtNamaSupplier.Size = New System.Drawing.Size(276, 26)
        Me.txtNamaSupplier.TabIndex = 105
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.Label20.Location = New System.Drawing.Point(15, 289)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(106, 21)
        Me.Label20.TabIndex = 106
        Me.Label20.Text = "CP Supplier"
        '
        'txtCPSupplier
        '
        Me.txtCPSupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCPSupplier.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtCPSupplier.Location = New System.Drawing.Point(176, 289)
        Me.txtCPSupplier.Name = "txtCPSupplier"
        Me.txtCPSupplier.Size = New System.Drawing.Size(276, 26)
        Me.txtCPSupplier.TabIndex = 107
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(129, 105)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(210, 3)
        Me.Label21.TabIndex = 111
        Me.Label21.Text = " "
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(125, 77)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(218, 24)
        Me.Label22.TabIndex = 110
        Me.Label22.Text = "MANAGE DATA SUPPLIER"
        '
        'btnCancelSup
        '
        Me.btnCancelSup.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btnCancelSup.FlatAppearance.BorderSize = 0
        Me.btnCancelSup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelSup.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancelSup.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCancelSup.Location = New System.Drawing.Point(252, 363)
        Me.btnCancelSup.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelSup.Name = "btnCancelSup"
        Me.btnCancelSup.Size = New System.Drawing.Size(91, 41)
        Me.btnCancelSup.TabIndex = 112
        Me.btnCancelSup.Text = "Clear"
        Me.btnCancelSup.UseVisualStyleBackColor = False
        '
        'AdminAddSup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(468, 450)
        Me.Controls.Add(Me.btnCancelSup)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.txtIDSupplier)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtNamaSupplier)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txtCPSupplier)
        Me.Controls.Add(Me.btnTambahSup)
        Me.Controls.Add(Me.btnExitAdd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminAddSup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminAddSup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExitAdd As Button
    Friend WithEvents btnTambahSup As Button
    Friend WithEvents txtIDSupplier As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txtNamaSupplier As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtCPSupplier As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents btnCancelSup As Button
End Class
