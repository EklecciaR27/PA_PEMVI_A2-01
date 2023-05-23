Imports MySql.Data.MySqlClient

Public Class StaffForm
    Private Sub StaffForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call TampilBarang()
        Call TampilPembelian()
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
    'Klik pilih Menu Manage Pembelian
    Private Sub btnMenuManagePem_Click(sender As Object, e As EventArgs) Handles btnMenuManagePem.Click
        lblSelectedManagePem.Visible = True
        pnlManagePembelian.Visible = True

        lblSelectedManageBarang.Visible = False
        pnlManageDataBarang.Visible = False

        lblSelectedLogout.Visible = False
        Call TampilPembelian()
    End Sub

    'Klik pilih Menu Data Barang
    Private Sub btnMenuManageBarang_Click(sender As Object, e As EventArgs) Handles btnMenuManageBarang.Click
        lblSelectedManagePem.Visible = False
        pnlManagePembelian.Visible = False

        lblSelectedManageBarang.Visible = True
        pnlManageDataBarang.Visible = True

        lblSelectedLogout.Visible = False
    End Sub


    'Klik pilih Menu Logout
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        lblSelectedManagePem.Visible = False
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
        StaffAddBar.Show()
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
            Energi = RadioButton1.Text.ToUpper
        ElseIf RadioButton2.Checked = True Then
            Energi = RadioButton2.Text.ToUpper
        Else
            Energi = RadioButton3.Text.ToUpper
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




    'CARI SUPPLIER
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






    '------------------ PANEL MANAGE PEMBELIAN ------------------

    Dim idPembelian As Integer

    Sub TampilPembelian()
        Dim cmd As New MySqlCommand("SELECT idPembelian, totalJumlah, totalharga, status FROM pembelian WHERE status = 'diproses'", CONN)
        DA = New MySqlDataAdapter(cmd)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "pembelian")
        dgvPembelian.DataSource = DS.Tables("pembelian")

        If dgvPembelian.Columns.Count <> 5 And dgvPembelian.Columns.Count <> 0 Then
            Call AksiPembelian()
            Call AturGridpembelian()
        End If

        dgvPembelian.Refresh()
    End Sub

    Sub TampilDetail(ByVal idPembelian As Integer)

        dgvPesanan.Columns.Clear()
        Dim cmd As New MySqlCommand("SELECT b.namaBarang, b.jenisBarang, b.asalEnergi, s.namaSupplier, p.jumlah, p.subTotalHarga FROM pesanan p JOIN db_barang b ON p.idBarang = b.idBarang JOIN db_supplier s ON b.idSupplier = s.idSupplier WHERE p.idPembelian = '" & idPembelian & "'", CONN)
        DA = New MySqlDataAdapter(cmd)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "pesanan")
        dgvPesanan.DataSource = DS.Tables("pesanan")

        If dgvPesanan.Columns.Count <> 0 Then
            Call AturGridPesanan()
        End If

        dgvPesanan.Refresh()
    End Sub

    'Atur grid tabel riwayat
    Sub AturGridpembelian()
        'mengatur lebar kolom
        dgvPembelian.Columns(0).Width = 60
        dgvPembelian.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgvPembelian.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgvPembelian.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

        If dgvPembelian.ColumnCount = 5 Then
            dgvPembelian.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        End If

        'mengatur header kolom
        dgvPembelian.Columns(0).HeaderText = "KODE"
        dgvPembelian.Columns(1).HeaderText = "TOTAL JUMLAH"
        dgvPembelian.Columns(2).HeaderText = "TOTAL HARGA"
        dgvPembelian.Columns(3).HeaderText = "STATUS"

        If dgvPembelian.ColumnCount = 5 Then
            dgvPembelian.Columns(4).HeaderText = "AKSI"
        End If

        'mengatur warna header kolom
        dgvPembelian.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(224, 237, 244)
        dgvPembelian.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvPembelian.ColumnHeadersDefaultCellStyle.Font = New Font("Calibri", 12, FontStyle.Bold)

        'mengatur warna latar belakang grid
        dgvPembelian.DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240)

        'mengatur warna teks pada sel yang dipilih
        dgvPembelian.DefaultCellStyle.SelectionBackColor = Color.FromArgb(224, 237, 244)
        dgvPembelian.DefaultCellStyle.SelectionForeColor = Color.FromArgb(74, 74, 74)

        'mengatur font pada grid
        dgvPembelian.DefaultCellStyle.Font = New Font("Calibri", 11)

        'mengatur border pada grid
        dgvPembelian.BorderStyle = BorderStyle.Fixed3D
        dgvPembelian.CellBorderStyle = DataGridViewCellBorderStyle.Single
        dgvPembelian.GridColor = Color.Black
    End Sub

    'Button liat detail pembelian
    Private Sub AksiPembelian()
        Dim btn1 As New DataGridViewButtonColumn

        btn1.Text = "Lihat"
        btn1.Name = "bLht"
        btn1.UseColumnTextForButtonValue = True
        dgvPembelian.Columns.Insert(4, btn1)
    End Sub

    Sub AturGridPesanan()
        'mengatur lebar kolom
        dgvPesanan.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgvPesanan.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgvPesanan.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgvPesanan.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgvPesanan.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgvPesanan.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

        'mengatur header kolom
        dgvPesanan.Columns(0).HeaderText = "NAMA BARANG"
        dgvPesanan.Columns(1).HeaderText = "JENIS"
        dgvPesanan.Columns(2).HeaderText = "ENERGI"
        dgvPesanan.Columns(3).HeaderText = "SUPPLIER"
        dgvPesanan.Columns(4).HeaderText = "JUMLAH"
        dgvPesanan.Columns(5).HeaderText = "SUBTOTAL"

        'mengatur warna header kolom
        dgvPesanan.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(224, 237, 244)
        dgvPesanan.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvPesanan.ColumnHeadersDefaultCellStyle.Font = New Font("Calibri", 12, FontStyle.Bold)

        'mengatur warna latar belakang grid
        dgvPesanan.DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240)

        'mengatur warna teks pada sel yang dipilih
        dgvPesanan.DefaultCellStyle.SelectionBackColor = Color.FromArgb(224, 237, 244)
        dgvPesanan.DefaultCellStyle.SelectionForeColor = Color.FromArgb(74, 74, 74)

        'mengatur font pada grid
        dgvPesanan.DefaultCellStyle.Font = New Font("Calibri", 11)

        'mengatur border pada grid
        dgvPesanan.BorderStyle = BorderStyle.Fixed3D
        dgvPesanan.CellBorderStyle = DataGridViewCellBorderStyle.Single
        dgvPesanan.GridColor = Color.Black
    End Sub

    'KLIK DGV RIWAYAT
    Private Sub dgvPembelian_CellContentClick(sender As System.Object, e As DataGridViewCellEventArgs) _
                                            Handles dgvPembelian.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)

        If (TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn And
            senderGrid.Columns(e.ColumnIndex).Name = "bLht") AndAlso
            e.RowIndex >= 0 Then

            idPembelian = Val(dgvPembelian.Rows(e.RowIndex).Cells("idPembelian").Value)

            TampilDetail(idPembelian)
        End If
    End Sub

    Private Sub bKonfirmasi_Click(sender As Object, e As EventArgs) Handles bKonfirmasi.Click

        If idPembelian <> -1 Then
            CMD = New MySqlCommand("UPDATE pembelian set status = 'selesai' WHERE idPembelian = '" & idPembelian & "'", CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Data telah selesai diproses.")
        End If

        idPembelian = -1
        dgvPesanan.Columns.Clear()
        Call StaffForm_Load(sender, e)
    End Sub

End Class