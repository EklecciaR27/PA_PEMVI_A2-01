Imports MySql.Data.MySqlClient

Public Class AdminForm
    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MANAGE AKUN
        Call Koneksi()
        Call Tampil()
        Call AturGrid()
        Call KosongView()

        txtvStatus.Enabled = False
        txtvUsername.Enabled = False
        dgvAkun.ReadOnly = True

        'MANAGE SUPP
        Call TampilSup()
        Call AturGridSup()
        Call ClearSup()
        dgvSup.ReadOnly = True

        txtIDSupplier.Enabled = False

        'MANAGE BARANG
        Call TampilBarang()
        Call TampilDBSupplier()
        Call ClearBarang()
        Call AturGridBarang()
        dgvBarang.ReadOnly = True

        txtIDBarang.Enabled = False
    End Sub




    '------------------ PANEL TOP ------------------
    'Button Exit
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim Tutup As String
        Tutup = MessageBox.Show("Yakin ingin menutup form ini?", "Konfirmasi",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Asterisk)
        If Tutup = MsgBoxResult.Ok Then
            End
        Else
            Exit Sub
        End If
    End Sub

    'Button Maximize
    Private Sub btnMax_Click(sender As Object, e As EventArgs) Handles btnMax.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    'Button Minimize
    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        WindowState = FormWindowState.Minimized
    End Sub



    '------------------ PANEL LEFT ------------------
    Private Sub btnMenuRegistrasi_Click(sender As Object, e As EventArgs) Handles btnMenuRegistrasi.Click
        'Klik pilih Menu yang dimau
        lblSelectedReg.Visible = True
        lblSelectedManageAkun.Visible = False
        lblSelectedManageSup.Visible = False
        lblSelectedManageBarang.Visible = False
        lblSelectedLogout.Visible = False

        pnlRegister.Visible = True
        pnlManage.Visible = False
        pnlManageSup.Visible = False
        pnlManageBarang.Visible = False
    End Sub
    Private Sub btnMenuManageAkun_Click(sender As Object, e As EventArgs) Handles btnMenuManageAkun.Click
        'Klik pilih Menu yang dimau
        lblSelectedReg.Visible = False
        lblSelectedManageAkun.Visible = True
        lblSelectedManageSup.Visible = False
        lblSelectedManageBarang.Visible = False
        lblSelectedLogout.Visible = False

        pnlRegister.Visible = False
        pnlManage.Visible = True
        pnlManageSup.Visible = False
        pnlManageBarang.Visible = False
    End Sub
    Private Sub btnMenuManageSup_Click(sender As Object, e As EventArgs) Handles btnMenuManageSup.Click
        'Klik pilih Menu yang dimau
        lblSelectedReg.Visible = False
        lblSelectedManageAkun.Visible = False
        lblSelectedManageSup.Visible = True
        lblSelectedManageBarang.Visible = False
        lblSelectedLogout.Visible = False

        pnlRegister.Visible = False
        pnlManage.Visible = False
        pnlManageSup.Visible = True
        pnlManageBarang.Visible = False
    End Sub
    Private Sub btnMenuManageBarang_Click(sender As Object, e As EventArgs) Handles btnMenuManageBarang.Click
        'Klik pilih Menu yang dimau
        lblSelectedReg.Visible = False
        lblSelectedManageAkun.Visible = False
        lblSelectedManageSup.Visible = False
        lblSelectedManageBarang.Visible = True
        lblSelectedLogout.Visible = False

        pnlRegister.Visible = False
        pnlManage.Visible = False
        pnlManageSup.Visible = False
        pnlManageBarang.Visible = True
    End Sub
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        lblSelectedReg.Visible = False
        lblSelectedManageAkun.Visible = False
        lblSelectedManageSup.Visible = False
        lblSelectedManageBarang.Visible = False
        lblSelectedLogout.Visible = True

        Dim Keluar As String
        Keluar = MessageBox.Show("Yakin ingin logout?", "Konfirmasi",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Asterisk)
        If Keluar = MsgBoxResult.Ok Then
            UN = ""
            FormLogin.Show()
            Me.Hide()
        Else
            Exit Sub
        End If
    End Sub


    '------------------ PANEL REGIST AKUN ------------------
    'Tampilan teks Full Name waktu diklik
    Private Sub txtFullName_MouseClick(sender As Object, e As MouseEventArgs) Handles txtFullName.MouseClick
        If txtFullName.Text = "Full Name" Then
            txtFullName.Clear()
            txtFullName.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtFullName_MouseLeave(sender As Object, e As EventArgs) Handles txtFullName.MouseLeave
        If txtFullName.Text = "Full Name" Or txtFullName.Text = "" Then
            txtFullName.ForeColor = Color.DarkGray
            txtFullName.Text = "Full Name"
        End If
    End Sub

    'Tampilan teks Username waktu diklik
    Private Sub txtUsername_MouseClick(sender As Object, e As MouseEventArgs) Handles txtUsername.MouseClick
        If txtUsername.Text = "Username" Then
            txtUsername.Clear()
            txtUsername.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtUsername_MouseLeave(sender As Object, e As EventArgs) Handles txtUsername.MouseLeave
        If txtUsername.Text = "Username" Or txtUsername.Text = "" Then
            txtUsername.ForeColor = Color.DarkGray
            txtUsername.Text = "Username"
        End If
    End Sub

    'Tampilan teks Password waktu diklik
    Private Sub txtPassword_MouseClick(sender As Object, e As MouseEventArgs) Handles txtPassword.MouseClick
        If txtPassword.Text = "Password" Then
            txtPassword.Clear()
            txtPassword.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtPassword_MouseLeave(sender As Object, e As EventArgs) Handles txtPassword.MouseLeave
        If txtPassword.Text = "Password" Or txtPassword.Text = "" Then
            txtPassword.ForeColor = Color.DarkGray
            txtPassword.Text = "Password"
        End If
    End Sub

    'Tampilan teks Confirm Password waktu diklik
    Private Sub txtConPasswordr_MouseClick(sender As Object, e As MouseEventArgs) Handles txtConPassword.MouseClick
        If txtConPassword.Text = "Confirm Password" Then
            txtConPassword.Clear()
            txtConPassword.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtConPassword_MouseLeave(sender As Object, e As EventArgs) Handles txtConPassword.MouseLeave
        If txtConPassword.Text = "Confirm Password" Or txtConPassword.Text = "" Then
            txtConPassword.ForeColor = Color.DarkGray
            txtConPassword.Text = "Confirm Password"
        End If
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        ' Untuk cek field yang diisi kosong atau tidak
        If txtFullName.Text = "" OrElse txtFullName.Text = "Full Name" Then
            MsgBox("Full Name harus diisi.", MsgBoxStyle.Exclamation, "Peringatan")
            txtFullName.Focus()
            Exit Sub
        End If

        If txtUsername.Text = "" OrElse txtUsername.Text = "Username" Then
            MsgBox("Username harus diisi.", MsgBoxStyle.Exclamation, "Peringatan")
            txtUsername.Focus()
            Exit Sub
        End If

        If txtPassword.Text = "" OrElse txtPassword.Text = "Password" Then
            MsgBox("Password harus diisi.", MsgBoxStyle.Exclamation, "Peringatan")
            txtPassword.Focus()
            Exit Sub
        End If

        If txtConPassword.Text = "" OrElse txtConPassword.Text = "Confirm Password" Then
            MsgBox("Konfirmasi Password harus diisi.", MsgBoxStyle.Exclamation, "Peringatan")
            txtConPassword.Focus()
            Exit Sub
        End If

        If cbStatus.Text = "" Then
            MsgBox("Status harus dipilih.", MsgBoxStyle.Exclamation, "Peringatan")
            cbStatus.Focus()
            Exit Sub
        End If


        'EKSEKUSI GAN
        Call Koneksi()
        CMD = New MySqlCommand("Select * From db_akun where username='" & txtUsername.Text & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()

        If RD.HasRows Then
            MsgBox("Username telah terdaftar. Silahkan masukkan username lain.", MsgBoxStyle.Exclamation, "Peringatan")
            RD.Close()
            Exit Sub
        End If

        RD.Close()

        If txtPassword.Text = txtConPassword.Text Then
            Dim Daftar As String = "insert into db_akun
                                    (username, password, status, fullname)
                                     values ('" &
                                    txtUsername.Text.ToLower & "','" &
                                    txtPassword.Text.ToLower & "','" &
                                    cbStatus.Text & "','" &
                                    txtFullName.Text.ToUpper & "')"

            CMD = New MySqlCommand(Daftar, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Registration Success!", MsgBoxStyle.Information, "Pemberitahuan")


            txtFullName.ForeColor = Color.DarkGray
            txtUsername.ForeColor = Color.DarkGray
            txtPassword.ForeColor = Color.DarkGray
            txtConPassword.ForeColor = Color.DarkGray
            txtFullName.Text = "Full Name"
            txtUsername.Text = "Username"
            txtPassword.Text = "Password"
            txtConPassword.Text = "Confirm Password"
            cbStatus.Text = ""
        Else
            MessageBox.Show("Password dan konfirmasi password tidak sama", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        Call Tampil()
    End Sub







    '------------------ PANEL MANAGE AKUN ------------------
    'Kosong view
    Sub KosongView()
        txtvFn.Clear()
        txtvUsername.Clear()
        txtvPassword.Clear()
        txtvStatus.Clear()
    End Sub



    'Tampil dulu ke dgv
    Sub Tampil()
        DA = New MySqlDataAdapter("SELECT status, fullname, username, password FROM db_akun WHERE status IN ('Staff', 'Manager')", CONN)
        DS = New DataSet
        DS.Clear()

        DA.Fill(DS, "db_akun")
        dgvAkun.DataSource = DS.Tables("db_akun")
        dgvAkun.Refresh()
    End Sub


    'Atur grid di dgvAkun
    Sub AturGrid()
        'mengatur lebar kolom
        dgvAkun.Columns(0).Width = 100
        dgvAkun.Columns(1).Width = 180
        dgvAkun.Columns(2).Width = 100
        dgvAkun.Columns(3).Width = 100

        'mengatur header kolom
        dgvAkun.Columns(0).HeaderText = "STATUS"
        dgvAkun.Columns(1).HeaderText = "FULL NAME"
        dgvAkun.Columns(2).HeaderText = "USERNAME"
        dgvAkun.Columns(3).HeaderText = "PASSWORD"

        'mengatur warna header kolom
        dgvAkun.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(224, 237, 244)
        dgvAkun.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvAkun.ColumnHeadersDefaultCellStyle.Font = New Font("Calibri", 12, FontStyle.Bold)

        'mengatur warna latar belakang grid
        dgvAkun.DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240)

        'mengatur warna teks pada sel yang dipilih
        dgvAkun.DefaultCellStyle.SelectionBackColor = Color.FromArgb(224, 237, 244)
        dgvAkun.DefaultCellStyle.SelectionForeColor = Color.FromArgb(74, 74, 74)

        'mengatur font pada grid
        dgvAkun.DefaultCellStyle.Font = New Font("Calibri", 11)

        'mengatur border pada grid
        dgvAkun.BorderStyle = BorderStyle.Fixed3D
        dgvAkun.CellBorderStyle = DataGridViewCellBorderStyle.Single
        dgvAkun.GridColor = Color.Black
    End Sub


    Private Sub dgvAkun_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAkun.CellClick
        ' Jika baris atau sel kosong tidak di klik maka tampilkan data di TextBox
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim row As DataGridViewRow = dgvAkun.Rows(e.RowIndex)
            txtvStatus.Text = row.Cells("status").Value.ToString()
            txtvFn.Text = row.Cells("fullname").Value.ToString()
            txtvUsername.Text = row.Cells("username").Value.ToString()
            txtvPassword.Text = row.Cells("password").Value.ToString()
        End If
    End Sub

    'UPDATE
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtvUsername.Text = "" Then
            MsgBox("Data Kosong")
        Else
            Dim Ubah As String = "Update db_akun set 
                          password = '" & txtvPassword.Text.ToLower & "', 
                          fullname = '" & txtvFn.Text.ToUpper & "'
                          
                          where username = '" & txtvUsername.Text & "'"
            CMD = New MySqlCommand(Ubah, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data berhasil diupdate", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call Tampil()
            Call KosongView()

            DS.Clear()
            DA.Fill(DS, "db_akun")
            dgvAkun.DataSource = DS.Tables("db_akun")
            dgvAkun.Refresh()

        End If
    End Sub

    'HAPUS
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtvUsername.Text = "" Then
            MsgBox("Data Kosong")
            dgvAkun.Focus()
        Else
            If MessageBox.Show("Yakin akan menghapus data dengan Username: " & txtvUsername.Text.ToLower & " ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                CMD = New MySqlCommand("Delete from db_akun where username = '" & txtvUsername.Text & "'", CONN)
                CMD.ExecuteNonQuery()
                Call Tampil()
                Call KosongView()
            Else
                Call KosongView()
            End If
        End If
    End Sub



    'CARI
    Private Sub txtCariAkun_MouseClick(sender As Object, e As EventArgs) Handles txtCariAkun.MouseClick
        If txtCariAkun.Text = "Cari..." Then
            txtCariAkun.Clear()
            txtCariAkun.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtCariAkun_Leave(sender As Object, e As EventArgs) Handles txtCariAkun.Leave
        If txtCariAkun.Text = "Cari..." Or txtCariAkun.Text = "" Then
            txtCariAkun.ForeColor = Color.DarkGray
            txtCariAkun.Text = "Cari..."
        End If
    End Sub
    Private Sub txtCariAkun_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCariAkun.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim columnName As String = "username"
            If cbCariAkun.SelectedItem = "Full Name" Then
                columnName = "fullname"
            End If

            CMD = New MySqlCommand("SELECT status, fullname, username, password FROM db_akun WHERE status IN ('Staff', 'Manager') AND " & columnName & " LIKE '%" & txtCariAkun.Text & "%'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()

            If RD.HasRows Then
                RD.Close()
                DA = New MySqlDataAdapter("SELECT status, fullname, username, password FROM db_akun WHERE status IN ('Staff', 'Manager') AND " & columnName & " LIKE '%" & txtCariAkun.Text & "%'", CONN)
                DS = New DataSet
                DA.Fill(DS, "Dapat")
                dgvAkun.DataSource = DS.Tables("Dapat")
                dgvAkun.ReadOnly = True

                AturGrid()
            Else
                RD.Close()
                MsgBox("Data Akun Tidak Ditemukan")
            End If
        End If
    End Sub

    Private Sub cbCariAkun_TextChanged(sender As Object, e As EventArgs) Handles cbCariAkun.TextChanged
        ' Reset hasil pencarian dan tampilkan semua data saat combobox diubah
        txtCariAkun.Text = "Cari..."
        dgvAkun.DataSource = Nothing
        Call Tampil()
    End Sub

    Private Sub btnCancelAkun_Click(sender As Object, e As EventArgs) Handles btnCancelAkun.Click
        Call KosongView()
    End Sub







    '------------------ PANEL MANAGE DATA SUPPLIER ------------------
    'Sub TampilSup()
    '    DA = New MySqlDataAdapter("SELECT * FROM db_supplier", CONN)
    '    DS = New DataSet
    '    DS.Clear()

    '    DA.Fill(DS, "db_supplier")
    '    dgvSup.DataSource = DS.Tables("db_supplier")
    'End Sub
    Sub TampilSup()
        DA = New MySqlDataAdapter("SELECT * FROM db_supplier", CONN)
        DS = New DataSet
        DS.Clear()

        DA.Fill(DS, "db_supplier")
        dgvSup.DataSource = DS.Tables("db_supplier")
    End Sub


    'Sub TampilBarang()
    '    DA = New MySqlDataAdapter("SELECT b.idBarang, b.namaBarang, b.jenisBarang, b.asalEnergi, b.stokBarang, s.namaSupplier, b.hargaBarang FROM db_barang b JOIN db_supplier s ON b.idSupplier = s.idSupplier", CONN)
    '    DS = New DataSet
    '    DS.Clear()
    '    DA.Fill(DS, "barang")
    '    dgvBarang.DataSource = DS.Tables("barang")
    '    Call AturGridBarang()
    '    Call TampilDBSupplier()
    '    dgvBarang.Refresh()
    'End Sub

    Sub ClearSup()
        txtCPSupplier.Clear()
        txtIDSupplier.Clear()
        txtNamaSupplier.Clear()
    End Sub



    Function CekDataKosongSup()
        If txtNamaSupplier.Text = "" Then
            MessageBox.Show("Nama Supplier Harus DiIsi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNamaSupplier.Focus()
        ElseIf txtIDSupplier.Text = "" Then
            MessageBox.Show("ID Supplier Harus DiIsi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtIDSupplier.Focus()
        ElseIf txtCPSupplier.Text = "" Then
            MessageBox.Show("CP Supplier Musik Harus DiIsi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCPSupplier.Focus()
        Else
            Return True
        End If
        Return False
    End Function



    'Atur grid di dgvSup
    Sub AturGridSup()
        'mengatur lebar kolom
        dgvSup.Columns(0).Width = 110
        dgvSup.Columns(1).Width = 200
        dgvSup.Columns(2).Width = 150

        'mengatur header kolom
        dgvSup.Columns(0).HeaderText = "ID SUPPLIER"
        dgvSup.Columns(1).HeaderText = "NAMA SUPPLIER"
        dgvSup.Columns(2).HeaderText = "CP SUPPLIER"

        'mengatur warna header kolom
        dgvSup.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(224, 237, 244)
        dgvSup.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvSup.ColumnHeadersDefaultCellStyle.Font = New Font("Calibri", 12, FontStyle.Bold)

        'mengatur warna latar belakang grid
        dgvSup.DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240)

        'mengatur warna teks pada sel yang dipilih
        dgvSup.DefaultCellStyle.SelectionBackColor = Color.FromArgb(224, 237, 244)
        dgvSup.DefaultCellStyle.SelectionForeColor = Color.FromArgb(74, 74, 74)

        'mengatur font pada grid
        dgvSup.DefaultCellStyle.Font = New Font("Calibri", 11)

        'mengatur border pada grid
        dgvSup.BorderStyle = BorderStyle.Fixed3D
        dgvSup.CellBorderStyle = DataGridViewCellBorderStyle.Single
        dgvSup.GridColor = Color.Black
    End Sub


    'KLIK CELL DGV SUP
    Private Sub dgvSup_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSup.CellClick
        ' Jika baris atau sel kosong tidak di klik maka tampilkan data di TextBox
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim row As DataGridViewRow = dgvSup.Rows(e.RowIndex)
            txtIDSupplier.Text = row.Cells("idSupplier").Value.ToString()
            txtNamaSupplier.Text = row.Cells("namaSupplier").Value.ToString()
            txtCPSupplier.Text = row.Cells("cpSupplier").Value.ToString()
        End If
    End Sub


    'CP ANGKA ONLY
    Private Sub txtCPSupplier_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCPSupplier.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
            MessageBox.Show("Masukkan inputan berupa angka!")
            txtCPSupplier.Focus()
        End If
    End Sub


    'ADD SUPPLIER - PINDAH FORM 
    Private Sub btnTambahSup_Click(sender As Object, e As EventArgs) Handles btnTambahSup.Click
        AdminAddSup.Show()
        'Me.Hide()
        Call TampilSup()
    End Sub



    'CANCEL
    Private Sub btnCancelSup_Click(sender As Object, e As EventArgs) Handles btnCancelSup.Click
        Call ClearSup()
    End Sub




    'UPDATE DGV SUPP
    Private Sub btnUpdateSup_Click(sender As Object, e As EventArgs) Handles btnUpdateSup.Click
        If txtIDSupplier.Text = "" Then
            MsgBox("Data Kosong")
        Else
            Dim Ubah As String = "UPDATE db_supplier SET 
                          namaSupplier = '" & txtNamaSupplier.Text.ToUpper & "', 
                          cpSupplier = '" & txtCPSupplier.Text & "'
                          
                          WHERE idSupplier = '" & txtIDSupplier.Text.ToUpper & "'"
            CMD = New MySqlCommand(Ubah, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data berhasil diupdate", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call TampilSup()
            Call ClearSup()

            DS.Clear()
            DA.Fill(DS, "db_supplier")
            dgvSup.DataSource = DS.Tables("db_supplier")

        End If
    End Sub


    'DELETE DGV SUPP
    Private Sub btnDelSup_Click(sender As Object, e As EventArgs) Handles btnDelSup.Click
        If txtIDSupplier.Text = "" Then
            MsgBox("Data Kosong")
            dgvSup.Focus()
        Else
            If MessageBox.Show("Yakin akan menghapus data Supplier dengan ID: " & txtIDSupplier.Text.ToUpper & " ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Try
                    CMD = New MySqlCommand("Delete from db_supplier where idSupplier = '" & txtIDSupplier.Text & "'", CONN)
                    CMD.ExecuteNonQuery()
                    Call ClearSup()
                    Call TampilSup()
                Catch ex As Exception
                    MessageBox.Show("Data tidak dapat dihapus, karena data sudah pernah dibeli dan terdapat di riwayat pembelian.", "ERROR", MessageBoxButtons.OKCancel)
                Finally
                End Try
            Else
                Call ClearSup()
            End If
        End If
    End Sub



    'CARI SUPPLIER
    Private Sub txtCariSup_MouseClick(sender As Object, e As EventArgs) Handles txtCariSup.MouseClick
        If txtCariSup.Text = "Cari..." Then
            txtCariSup.Clear()
            txtCariSup.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtCariSup_Leave(sender As Object, e As EventArgs) Handles txtCariSup.Leave
        If txtCariSup.Text = "Cari..." Or txtCariSup.Text = "" Then
            txtCariSup.ForeColor = Color.DarkGray
            txtCariSup.Text = "Cari..."
        End If
    End Sub
    Private Sub txtCariSup_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCariSup.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim columnName As String = "idSupplier"
            If cbCariSup.SelectedItem = "Nama Supplier" Then
                columnName = "namaSupplier"
            End If

            CMD = New MySqlCommand("Select * From db_supplier where " & columnName & " like '%" & txtCariSup.Text & "%'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()

            If RD.HasRows Then
                RD.Close()
                DA = New MySqlDataAdapter("Select * From db_supplier where " & columnName & " like '%" & txtCariSup.Text & "%'", CONN)
                DS = New DataSet
                DA.Fill(DS, "Dapat")
                dgvSup.DataSource = DS.Tables("Dapat")
                dgvSup.ReadOnly = True

                AturGridSup()
            Else
                RD.Close()
                MsgBox("Data Supplier Tidak Ditemukan")
            End If
        End If
    End Sub

    Private Sub cbCariSup_TextChanged(sender As Object, e As EventArgs) Handles cbCariSup.TextChanged
        ' Reset hasil pencarian dan tampilkan semua data saat combobox diubah
        txtCariSup.Text = "Cari..."
        dgvSup.DataSource = Nothing
        Call TampilSup()
        Call ClearSup()
    End Sub







    '------------------ PANEL MANAGE DATA BARANG ------------------
    Sub ClearBarang()
        txtIDBarang.Clear()
        txtNamaBarang.Clear()
        txtStokBarang.Clear()
        cmbJenisBarang.Text = ""
        cmbSupplier.Text = ""
        txtHarga.Clear()
        txtIDBarang.Focus()

        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
    End Sub

    Sub TampilBarang()
        DA = New MySqlDataAdapter("SELECT b.idBarang, b.namaBarang, b.jenisBarang, b.asalEnergi, b.stokBarang, s.namaSupplier, b.hargaBarang FROM db_barang b JOIN db_supplier s ON b.idSupplier = s.idSupplier", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "barang")
        dgvBarang.DataSource = DS.Tables("barang")
        Call AturGridBarang()
        'Call TampilDBSupplier()
        dgvBarang.Refresh()
    End Sub

    Sub TampilDBSupplier()
        CMD = New MySqlCommand("SELECT namaSupplier From db_supplier", CONN)
        RD = CMD.ExecuteReader
        Do While RD.Read
            cmbSupplier.Items.Add(RD.Item(0))
        Loop
        RD.Close()
    End Sub

    Private Function supplierNameToId(ByVal nama As String) As String
        CMD = New MySqlCommand("SELECT idSupplier From db_supplier WHERE namaSupplier = '" & nama & "'", CONN)
        RD = CMD.ExecuteReader
        If RD.Read() Then
            Dim id As String = RD.Item(0)
            RD.Close()
            Return id
        End If
        RD.Close()
        Return -1
    End Function

    'STOK ANGKA ONLY
    Private Sub txtStokBarang_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStokBarang.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
            MessageBox.Show("Masukkan inputan berupa angka!")
        End If
    End Sub

    'HARGA ANGKA ONLY
    Private Sub txtHarga_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHarga.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
            MessageBox.Show("Masukkan inputan berupa angka!")
        End If
    End Sub


    'Atur grid di dgvBarang
    Sub AturGridBarang()
        'mengatur lebar kolom
        dgvBarang.Columns(0).Width = 110
        dgvBarang.Columns(1).Width = 200
        dgvBarang.Columns(2).Width = 150
        dgvBarang.Columns(3).Width = 150
        dgvBarang.Columns(4).Width = 150
        dgvBarang.Columns(5).Width = 150
        dgvBarang.Columns(6).Width = 150

        'mengatur header kolom
        dgvBarang.Columns(0).HeaderText = "ID BARANG"
        dgvBarang.Columns(1).HeaderText = "NAMA BARANG"
        dgvBarang.Columns(2).HeaderText = "JENIS BARANG"
        dgvBarang.Columns(3).HeaderText = "ENERGI"
        dgvBarang.Columns(4).HeaderText = "STOK"
        dgvBarang.Columns(5).HeaderText = "SUPPLIER"
        dgvBarang.Columns(6).HeaderText = "HARGA"

        'mengatur warna header kolom
        dgvBarang.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(224, 237, 244)
        dgvBarang.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvBarang.ColumnHeadersDefaultCellStyle.Font = New Font("Calibri", 12, FontStyle.Bold)

        'mengatur warna latar belakang grid
        dgvBarang.DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240)

        'mengatur warna teks pada sel yang dipilih
        dgvBarang.DefaultCellStyle.SelectionBackColor = Color.FromArgb(224, 237, 244)
        dgvBarang.DefaultCellStyle.SelectionForeColor = Color.FromArgb(74, 74, 74)

        'mengatur font pada grid
        dgvBarang.DefaultCellStyle.Font = New Font("Calibri", 11)

        'mengatur border pada grid
        dgvBarang.BorderStyle = BorderStyle.Fixed3D
        dgvBarang.CellBorderStyle = DataGridViewCellBorderStyle.Single
        dgvBarang.GridColor = Color.Black
    End Sub


    'KLIK CELL DGV BARANG
    Private Sub dgvBarang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBarang.CellClick
        ' Jika baris atau sel kosong tidak di klik maka tampilkan data di TextBox
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim row As DataGridViewRow = dgvBarang.Rows(e.RowIndex)
            txtIDBarang.Text = row.Cells("idBarang").Value.ToString()
            txtNamaBarang.Text = row.Cells("namaBarang").Value.ToString()
            cmbJenisBarang.Text = row.Cells("jenisBarang").Value.ToString()

            If row.Cells("asalEnergi").Value.ToString().Equals(RadioButton1.Text) Then
                RadioButton1.Checked = True
            ElseIf row.Cells("asalEnergi").Value.ToString().Equals(RadioButton2.Text) Then
                RadioButton2.Checked = True
            Else
                RadioButton3.Checked = True
            End If

            txtStokBarang.Text = row.Cells("stokBarang").Value.ToString()
            cmbSupplier.Text = row.Cells("namaSupplier").Value.ToString()
            txtHarga.Text = row.Cells("hargaBarang").Value.ToString()
        End If
    End Sub

    'CANCEL
    Private Sub btnCancelBarang_Click(sender As Object, e As EventArgs) Handles btnCancelBarang.Click
        Call ClearBarang()
    End Sub

    'ADD BARANG - PINDAH FORM 
    Private Sub btnAddBarang_Click(sender As Object, e As EventArgs) Handles btnAddBarang.Click
        AdminAddBar.Show()
        'Me.Hide()
        Call TampilBarang()
    End Sub



    'DELETE BARANG
    Private Sub btnDelBarang_Click(sender As Object, e As EventArgs) Handles btnDelBarang.Click
        If txtIDBarang.Text = "" Then
            MsgBox("Data Kosong")
            dgvBarang.Focus()
        Else
            If MessageBox.Show("Yakin akan menghapus data barang dengan ID: " & txtIDBarang.Text & " ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Try
                    CMD = New MySqlCommand("Delete from db_barang where idBarang = '" & txtIDBarang.Text & "'", CONN)
                    CMD.ExecuteNonQuery()
                    Call TampilBarang()
                    Call ClearBarang()
                Catch ex As Exception
                    MessageBox.Show("Data tidak dapat dihapus, karena data sudah pernah dibeli dan terdapat di riwayat pembelian.", "ERROR", MessageBoxButtons.OKCancel)
                Finally
                End Try
            Else
                Call ClearBarang()
            End If
        End If
    End Sub


    'UPDATE BARANG
    Private Sub btnUpdateBarang_Click(sender As Object, e As EventArgs) Handles btnUpdateBarang.Click

        Dim IDBarang As String = txtIDBarang.Text.ToUpper
        Dim NamaBarang As String = txtNamaBarang.Text.ToUpper
        Dim JenisBarang As String = cmbJenisBarang.Text.ToUpper
        Dim StokBarang As Integer = txtStokBarang.Text
        Dim Supplier As String = cmbSupplier.Text.ToUpper
        Dim HargaBarang As String = txtHarga.Text
        Dim Energi As String

        If RadioButton1.Checked = True Then
            Energi = RadioButton1.Text
        ElseIf RadioButton2.Checked = True Then
            Energi = RadioButton2.Text
        Else
            Energi = RadioButton3.Text
        End If

        If txtIDBarang.Text = "" Or txtNamaBarang.Text = "" Or txtStokBarang.Text = "" Or cmbJenisBarang.Text = "" Or txtIDBarang.Text = "" Or
                cmbSupplier.Text = "" Or txtHarga.Text = "" Or (RadioButton1.Checked = False And RadioButton2.Checked = False And RadioButton3.Checked = False) Then
            MsgBox("Data Belum Lengkap, Silakan Lengkapi Semua Data")
        Else
            Dim Update As String = "Update db_barang set namaBarang = '" & NamaBarang & "', jenisBarang = '" & JenisBarang & "', asalEnergi = '" & Energi & "', stokBarang = '" & StokBarang & "',
                                    idSupplier = '" & supplierNameToId(Supplier) & "', hargaBarang = '" & HargaBarang & "' where idBarang = '" & IDBarang & "'"
            CMD = New MySqlCommand(Update, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Data berhasil di Update..", MsgBoxStyle.Information, "Informasi")
            Call TampilBarang()
            Call ClearBarang()
        End If
    End Sub




    'CARI BARANG
    Private Sub txtCariBarang_MouseClick(sender As Object, e As EventArgs) Handles txtCariBarang.MouseClick
        If txtCariBarang.Text = "Cari..." Then
            txtCariBarang.Clear()
            txtCariBarang.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtCariBarang_Leave(sender As Object, e As EventArgs) Handles txtCariBarang.Leave
        If txtCariBarang.Text = "Cari..." Or txtCariBarang.Text = "" Then
            txtCariBarang.ForeColor = Color.DarkGray
            txtCariBarang.Text = "Cari..."
        End If
    End Sub
    Private Sub txtCariBarang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCariBarang.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim columnName As String = "idBarang"
            If cbCariBarang.SelectedItem = "Nama Barang" Then
                columnName = "namaBarang"
            ElseIf cbCariBarang.SelectedItem = "Supplier" Then
                columnName = "namaSupplier"
            End If

            Dim cmdBarang As String = "SELECT b.idBarang, b.namaBarang, b.jenisBarang, b.asalEnergi, b.stokBarang, s.namaSupplier, b.hargaBarang FROM db_barang b JOIN db_supplier s ON b.idSupplier = s.idSupplier WHERE "

            CMD = New MySqlCommand(cmdBarang & columnName & " like '%" & txtCariBarang.Text & "%'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()

            If RD.HasRows Then
                RD.Close()
                DA = New MySqlDataAdapter(cmdBarang & columnName & " like '%" & txtCariBarang.Text & "%'", CONN)
                DS = New DataSet
                DA.Fill(DS, "Dapat")
                dgvBarang.DataSource = DS.Tables("Dapat")
                dgvBarang.ReadOnly = True
            Else
                RD.Close()
                MsgBox("Data Tidak Ditemukan")
            End If
        End If
    End Sub

    Private Sub cbCariBarang_TextChanged(sender As Object, e As EventArgs) Handles cbCariBarang.TextChanged
        ' Reset hasil pencarian dan tampilkan semua data saat combobox diubah
        txtCariBarang.Text = "Cari..."
        dgvBarang.DataSource = Nothing
        Call TampilBarang()
        Call ClearBarang()
    End Sub
End Class