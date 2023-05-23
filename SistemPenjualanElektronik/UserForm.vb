Imports System.ComponentModel
Imports System.Net.Http.Headers
Imports MySql.Data.MySqlClient

Public Class UserForm
    Private Sub UserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call TampilBarang()
        Call TampilPesanan()
        Call TampilRiwayat()
        cbCariBarang.SelectedIndex = 0
    End Sub

    Private Sub numberInput(e As KeyPressEventArgs)

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
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
    Private Sub btnMenuPembelian_Click(sender As Object, e As EventArgs) Handles btnMenuPembelian.Click
        lblSelectedPembelian.Visible = True
        pnlPembelian.Visible = True

        lblSelectedRiwayat.Visible = False
        pnlRiwayat.Visible = False

        lblSelectedLogout.Visible = False

        Call UserForm_Load(sender, e)
    End Sub

    'Klik pilih Menu Data Barang
    Private Sub btnMenuRiwayat_Click(sender As Object, e As EventArgs) Handles btnMenuRiwayat.Click
        lblSelectedPembelian.Visible = False
        pnlPembelian.Visible = False

        lblSelectedRiwayat.Visible = True
        pnlRiwayat.Visible = True

        lblSelectedLogout.Visible = False

        Call UserForm_Load(sender, e)
    End Sub

    'Klik pilih Menu Logout
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        lblSelectedPembelian.Visible = False
        lblSelectedRiwayat.Visible = False

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

    '------------------ PANEL PEMBELIAN BARANG ------------------
    'DGV BARANG
    Sub TampilBarang()
        DA = New MySqlDataAdapter("SELECT b.idBarang, b.namaBarang, b.jenisBarang, b.asalEnergi, b.stokBarang, s.namaSupplier, b.hargaBarang FROM db_barang b JOIN db_supplier s ON b.idSupplier = s.idSupplier WHERE b.stokBarang > 0", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "db_barang")
        dgvBarang.DataSource = DS.Tables("db_barang")

        If dgvBarang.Columns.Count <> 8 And dgvBarang.Columns.Count <> 0 Then
            Call AksiBarang()
            Call AturGridBarang()
        End If

        dgvBarang.Refresh()
    End Sub

    Sub TampilPesanan()
        If dgvPesanan.Columns.Count <> 12 And dgvPesanan.Columns.Count <> 0 Then
            Call AksiPesanan()
            Call AturGridPesanan()
        End If

        dgvPesanan.Refresh()
    End Sub

    'Atur grid di dgvBarang
    Sub AturGridBarang()
        'mengatur lebar kolom
        dgvBarang.Columns(0).Width = 80
        dgvBarang.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgvBarang.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgvBarang.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgvBarang.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgvBarang.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvBarang.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        If dgvBarang.ColumnCount = 8 Then
            dgvBarang.Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        End If

        'mengatur header kolom
        dgvBarang.Columns(0).HeaderText = "KODE"
        dgvBarang.Columns(1).HeaderText = "NAMA BARANG"
        dgvBarang.Columns(2).HeaderText = "JENIS"
        dgvBarang.Columns(3).HeaderText = "ENERGI"
        dgvBarang.Columns(4).HeaderText = "STOK"
        dgvBarang.Columns(5).HeaderText = "SUPPLIER"
        dgvBarang.Columns(6).HeaderText = "HARGA"
        If dgvBarang.ColumnCount = 8 Then
            dgvBarang.Columns(7).HeaderText = "AKSI"
        End If

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

    'Button Tambah di setiap row barang
    Private Sub AksiBarang()
        Dim btn1 As New DataGridViewButtonColumn

        btn1.Text = "Tambah"
        btn1.Name = "bTbh"
        btn1.UseColumnTextForButtonValue = True
        dgvBarang.Columns.Insert(7, btn1)
    End Sub


    'Atur grid di dgvPesanan (Keranjang)
    Sub AturGridPesanan()
        'mengatur lebar kolom
        dgvPesanan.Columns(0).Width = 80
        dgvPesanan.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvPesanan.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgvPesanan.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgvPesanan.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgvPesanan.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgvPesanan.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgvPesanan.Columns(7).Visible = False
        dgvPesanan.Columns(8).Visible = False
        If dgvPesanan.ColumnCount = 12 Then
            dgvPesanan.Columns(9).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            dgvPesanan.Columns(10).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            dgvPesanan.Columns(11).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        End If

        'mengatur header kolom
        dgvPesanan.Columns(7).HeaderText = "HARGA"
        dgvPesanan.Columns(8).HeaderText = "STOK"
        If dgvPesanan.ColumnCount = 12 Then
            dgvPesanan.Columns(9).HeaderText = "AKSI"
            dgvPesanan.Columns(10).HeaderText = "AKSI"
            dgvPesanan.Columns(11).HeaderText = "AKSI"
        End If

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

    'Button atur jumlah di setiap row pesanan
    Private Sub AksiPesanan()
        Dim btn1 As New DataGridViewButtonColumn
        Dim btn2 As New DataGridViewButtonColumn
        Dim btn3 As New DataGridViewButtonColumn

        btn1.Text = "-"
        btn1.Name = "bMin"
        btn1.UseColumnTextForButtonValue = True
        dgvPesanan.Columns.Insert(9, btn1)

        btn2.Text = "+"
        btn2.Name = "bPlus"
        btn2.UseColumnTextForButtonValue = True
        dgvPesanan.Columns.Insert(10, btn2)

        btn3.Text = "X"
        btn3.Name = "bX"
        btn3.UseColumnTextForButtonValue = True
        dgvPesanan.Columns.Insert(11, btn3)
    End Sub

    'Hitung total harga seluruh pesanan
    Private Sub hitungTotal()
        If dgvPesanan.Rows.Count <> 0 Then
            Dim totalHarga As Integer = 0
            For i = 0 To dgvPesanan.RowCount - 1
                totalHarga += dgvPesanan.Rows(i).Cells(6).Value
            Next
            txtTotal.Text = totalHarga
        Else
            txtTotal.Text = 0
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
            Dim columnName As String
            If cbCariBarang.SelectedItem = "ID Barang" Then
                columnName = "b.idBarang"
            ElseIf cbCariBarang.SelectedItem = "Nama Barang" Then
                columnName = "b.namaBarang"
            Else
                columnName = "s.namaSupplier"
            End If

            CMD = New MySqlCommand("SELECT b.idBarang, b.namaBarang, b.jenisBarang, b.asalEnergi, b.stokBarang, s.namaSupplier, b.hargaBarang FROM db_barang b JOIN db_supplier s ON b.idSupplier = s.idSupplier WHERE b.stokBarang > 0 AND " & columnName & " LIKE '%" & txtCariBarang.Text & "%'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()

            If RD.HasRows Then
                RD.Close()
                DA = New MySqlDataAdapter("SELECT b.idBarang, b.namaBarang, b.jenisBarang, b.asalEnergi, b.stokBarang, s.namaSupplier, b.hargaBarang FROM db_barang b JOIN db_supplier s ON b.idSupplier = s.idSupplier WHERE b.stokBarang > 0 AND " & columnName & " LIKE '%" & txtCariBarang.Text & "%'", CONN)
                DS = New DataSet
                DA.Fill(DS, "Dapat")
                dgvBarang.DataSource = DS.Tables("Dapat")
                dgvBarang.Refresh()
            Else
                RD.Close()
                MsgBox("Data Tidak Ditemukan")
            End If
            If dgvBarang.Columns.Count <> 8 And dgvBarang.Columns.Count <> 0 Then
                Call AksiBarang()
                Call AturGridBarang()
            End If
        Else
            If dgvBarang.Columns.Count <> 8 And dgvBarang.Columns.Count <> 0 Then
                Call AksiBarang()
                Call AturGridBarang()
            End If
        End If
    End Sub

    Private Sub bReset_Click(sender As Object, e As EventArgs) Handles bReset.Click
        txtCariBarang.ForeColor = Color.DarkGray
        txtCariBarang.Text = "Cari..."
        TampilBarang()
    End Sub

    'KLIK DGV BARANG
    Private Sub dgvBarang_CellContentClick(sender As System.Object, e As DataGridViewCellEventArgs) _
                                            Handles dgvBarang.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)

        If (TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn And
            senderGrid.Columns(e.ColumnIndex).Name = "bTbh") AndAlso
            e.RowIndex >= 0 Then

            txtAdd.Text = 1
            AddId.Text = dgvBarang.Rows(e.RowIndex).Cells("idBarang").Value
            AddNama.Text = dgvBarang.Rows(e.RowIndex).Cells("namaBarang").Value
            AddJenis.Text = dgvBarang.Rows(e.RowIndex).Cells("jenisBarang").Value
            AddEnergi.Text = dgvBarang.Rows(e.RowIndex).Cells("asalEnergi").Value
            AddStok.Text = dgvBarang.Rows(e.RowIndex).Cells("stokBarang").Value
            AddSupllier.Text = dgvBarang.Rows(e.RowIndex).Cells("namaSupplier").Value
            AddHarga.Text = dgvBarang.Rows(e.RowIndex).Cells("hargaBarang").Value
            AddPanel.Visible = True
        End If

    End Sub

    Private Sub bAddPlus_Click(sender As Object, e As EventArgs) Handles bAddPlus.Click

        If Val(txtAdd.Text) <> Val(AddStok.Text) Then
            txtAdd.Text = Val(txtAdd.Text) + 1
        End If
    End Sub

    Private Sub bAddMin_Click(sender As Object, e As EventArgs) Handles bAddMin.Click

        If Val(txtAdd.Text) <> 1 Then
            txtAdd.Text = Val(txtAdd.Text) - 1
        End If
    End Sub

    Private Sub bAddCancel_Click(sender As Object, e As EventArgs) Handles bAddCancel.Click
        AddPanel.Visible = False
    End Sub

    Private Sub bAddDone_Click(sender As Object, e As EventArgs) Handles bAddDone.Click

        Dim subtotal As Integer = Val(AddHarga.Text) * Val(txtAdd.Text)
        dgvPesanan.Rows.Add(New String() {AddId.Text, AddNama.Text, AddJenis.Text, AddEnergi.Text, AddSupllier.Text, txtAdd.Text, subtotal, AddHarga.Text, AddStok.Text})
        Call TampilPesanan()
        Call hitungTotal()
        AddPanel.Visible = False
    End Sub

    'KLIK DGV PESANAN
    Private Sub dgvPesanan_CellContentClick(sender As System.Object, e As DataGridViewCellEventArgs) _
                                            Handles dgvPesanan.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)

        If (TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn And
            senderGrid.Columns(e.ColumnIndex).Name = "bMin") AndAlso
            e.RowIndex >= 0 Then

            If Val(dgvPesanan.Rows(e.RowIndex).Cells(5).Value) <> 1 Then

                dgvPesanan.Rows(e.RowIndex).Cells(5).Value = Val(dgvPesanan.Rows(e.RowIndex).Cells(5).Value) - 1
                dgvPesanan.Rows(e.RowIndex).Cells(6).Value = Val(dgvPesanan.Rows(e.RowIndex).Cells(7).Value) * Val(dgvPesanan.Rows(e.RowIndex).Cells(5).Value)
                Call hitungTotal()
            End If

        ElseIf (TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn And
            senderGrid.Columns(e.ColumnIndex).Name = "bPlus") AndAlso
            e.RowIndex >= 0 Then

            If Val(dgvPesanan.Rows(e.RowIndex).Cells(5).Value) <> Val(dgvPesanan.Rows(e.RowIndex).Cells(8).Value) Then

                dgvPesanan.Rows(e.RowIndex).Cells(5).Value = Val(dgvPesanan.Rows(e.RowIndex).Cells(5).Value) + 1
                dgvPesanan.Rows(e.RowIndex).Cells(6).Value = Val(dgvPesanan.Rows(e.RowIndex).Cells(7).Value) * Val(dgvPesanan.Rows(e.RowIndex).Cells(5).Value)
                Call hitungTotal()
            End If

        ElseIf (TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn And
                senderGrid.Columns(e.ColumnIndex).Name = "bX") AndAlso
                e.RowIndex >= 0 Then

            dgvPesanan.Rows.RemoveAt(e.RowIndex)
            Call hitungTotal()

        End If

    End Sub

    Private Function getDbStok(ByVal idBarang As String) As Integer

        CMD = New MySqlCommand("SELECT * FROM db_barang WHERE idBarang = '" & idBarang & "'", CONN)
        RD = CMD.ExecuteReader()
        RD.Read()

        If RD.HasRows Then
            Dim dbStok As Integer = RD.GetValue(RD.GetOrdinal("stokBarang"))
            RD.Close()
            Return dbStok
        End If

        RD.Close()
        Return -1
    End Function

    Private Sub txtAdd_KeyPress(sender As Object, e As EventArgs) Handles txtAdd.KeyPress
        numberInput(e)
    End Sub

    Private Sub txtAdd_TextChanged(sender As Object, e As EventArgs) Handles txtAdd.TextChanged
        If Val(txtAdd.Text) > Val(AddStok.Text) And AddStok.Text <> "placeHolder" Then
            txtAdd.Text = AddStok.Text
        End If
    End Sub

    Private Sub btnPesan_Click(sender As Object, e As EventArgs) Handles btnPesan.Click

        If dgvPesanan.Rows.Count <> 0 Then

            Dim totalJumlah As Integer = 0
            Dim totalHarga As Integer = 0

            For i = 0 To dgvPesanan.RowCount - 1

                Dim dbStok As Integer = getDbStok(dgvPesanan.Rows(i).Cells(0).Value)

                If dbStok - Val(dgvPesanan.Rows(i).Cells(3).Value) < 0 Then
                    MsgBox("Terjadi Kesalahan Mohon Refresh Halaman! " & dbStok & " " & dgvPesanan.Rows(i).Cells(0).Value)
                    Return
                End If

                totalJumlah += dgvPesanan.Rows(i).Cells(5).Value
                totalHarga += dgvPesanan.Rows(i).Cells(6).Value
            Next

            CMD = New MySqlCommand("SELECT AUTO_INCREMENT FROM information_schema.TABLES WHERE TABLE_SCHEMA = database() AND TABLE_NAME = 'pembelian'", CONN)
            RD = CMD.ExecuteReader()

            RD.Read()
            Dim idpembelian As Integer = RD.GetInt64(0)
            RD.Close()

            CMD = New MySqlCommand("INSERT INTO pembelian VALUES (NULL, '" & UN & "', '" & totalJumlah & "', '" & totalHarga & "', 'diproses')", CONN)
            CMD.ExecuteNonQuery()

            For i = 0 To dgvPesanan.RowCount - 1

                Dim dbStok As Integer = getDbStok(dgvPesanan.Rows(i).Cells(0).Value)
                Dim jumlah As Integer = Val(dgvPesanan.Rows(i).Cells(5).Value)

                Dim nowStok As Integer = dbStok - jumlah

                CMD = New MySqlCommand("UPDATE db_barang SET stokBarang = '" & nowStok & "' WHERE idBarang = '" & dgvPesanan.Rows(i).Cells(0).Value & "'", CONN)
                CMD.ExecuteNonQuery()

                CMD = New MySqlCommand("INSERT INTO pesanan VALUES ('" & idpembelian & "', '" & dgvPesanan.Rows(i).Cells(0).Value & "', '" & jumlah & "', '" & dgvPesanan.Rows(i).Cells(6).Value & "')", CONN)
                CMD.ExecuteNonQuery()

            Next

            dgvPesanan.Rows.Clear()
            Call btnMenuRiwayat_Click(sender, e)
        End If
    End Sub


    '------------------ PANEL RIWAYAT PEMBELIAN ------------------

    Sub TampilRiwayat()
        Dim cmd As New MySqlCommand("SELECT idPembelian, totalJumlah, totalharga, status FROM pembelian WHERE idUser = '" & UN & "'", CONN)
        DA = New MySqlDataAdapter(cmd)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "riwayat")
        dgvRiwayatPbl.DataSource = DS.Tables("riwayat")

        If dgvRiwayatPbl.Columns.Count <> 5 And dgvRiwayatPbl.Columns.Count <> 0 Then
            Call AksiRiwayatPbl()
            Call AturGridRiwayat()
        End If

        dgvRiwayatPbl.Refresh()
    End Sub

    Sub TampilDetail(ByVal idPembelian As Integer)

        dgvRiwayatPsn.Columns.Clear()
        Dim cmd As New MySqlCommand("SELECT b.namaBarang, b.jenisBarang, b.asalEnergi, s.namaSupplier, p.jumlah, p.subTotalHarga FROM pesanan p JOIN db_barang b ON p.idBarang = b.idBarang JOIN db_supplier s ON b.idSupplier = s.idSupplier WHERE p.idPembelian = '" & idPembelian & "'", CONN)
        DA = New MySqlDataAdapter(cmd)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "detail")
        dgvRiwayatPsn.DataSource = DS.Tables("detail")

        If dgvRiwayatPsn.Columns.Count <> 0 Then
            Call AturGridDetail()
        End If

        dgvRiwayatPsn.Refresh()
    End Sub

    'Atur grid tabel riwayat
    Sub AturGridRiwayat()
        'mengatur lebar kolom
        dgvRiwayatPbl.Columns(0).Width = 60
        dgvRiwayatPbl.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgvRiwayatPbl.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgvRiwayatPbl.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

        If dgvRiwayatPbl.ColumnCount = 5 Then
            dgvRiwayatPbl.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        End If

        'mengatur header kolom
        dgvRiwayatPbl.Columns(0).HeaderText = "KODE"
        dgvRiwayatPbl.Columns(1).HeaderText = "TOTAL JUMLAH"
        dgvRiwayatPbl.Columns(2).HeaderText = "TOTAL HARGA"
        dgvRiwayatPbl.Columns(3).HeaderText = "STATUS"

        If dgvRiwayatPbl.ColumnCount = 5 Then
            dgvRiwayatPbl.Columns(4).HeaderText = "AKSI"
        End If

        'mengatur warna header kolom
        dgvRiwayatPbl.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(224, 237, 244)
        dgvRiwayatPbl.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvRiwayatPbl.ColumnHeadersDefaultCellStyle.Font = New Font("Calibri", 12, FontStyle.Bold)

        'mengatur warna latar belakang grid
        dgvRiwayatPbl.DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240)

        'mengatur warna teks pada sel yang dipilih
        dgvRiwayatPbl.DefaultCellStyle.SelectionBackColor = Color.FromArgb(224, 237, 244)
        dgvRiwayatPbl.DefaultCellStyle.SelectionForeColor = Color.FromArgb(74, 74, 74)

        'mengatur font pada grid
        dgvRiwayatPbl.DefaultCellStyle.Font = New Font("Calibri", 11)

        'mengatur border pada grid
        dgvRiwayatPbl.BorderStyle = BorderStyle.Fixed3D
        dgvRiwayatPbl.CellBorderStyle = DataGridViewCellBorderStyle.Single
        dgvRiwayatPbl.GridColor = Color.Black
    End Sub

    'Button liat detail pembelian
    Private Sub AksiRiwayatPbl()
        Dim btn1 As New DataGridViewButtonColumn

        btn1.Text = "Lihat"
        btn1.Name = "bLht"
        btn1.UseColumnTextForButtonValue = True
        dgvRiwayatPbl.Columns.Insert(4, btn1)
    End Sub

    Sub AturGridDetail()
        'mengatur lebar kolom
        dgvRiwayatPsn.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgvRiwayatPsn.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgvRiwayatPsn.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgvRiwayatPsn.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgvRiwayatPsn.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgvRiwayatPsn.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

        'mengatur header kolom
        dgvRiwayatPsn.Columns(0).HeaderText = "NAMA BARANG"
        dgvRiwayatPsn.Columns(1).HeaderText = "JENIS"
        dgvRiwayatPsn.Columns(2).HeaderText = "ENERGI"
        dgvRiwayatPsn.Columns(3).HeaderText = "SUPPLIER"
        dgvRiwayatPsn.Columns(4).HeaderText = "JUMLAH"
        dgvRiwayatPsn.Columns(5).HeaderText = "SUBTOTAL"

        'mengatur warna header kolom
        dgvRiwayatPsn.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(224, 237, 244)
        dgvRiwayatPsn.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvRiwayatPsn.ColumnHeadersDefaultCellStyle.Font = New Font("Calibri", 12, FontStyle.Bold)

        'mengatur warna latar belakang grid
        dgvRiwayatPsn.DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240)

        'mengatur warna teks pada sel yang dipilih
        dgvRiwayatPsn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(224, 237, 244)
        dgvRiwayatPsn.DefaultCellStyle.SelectionForeColor = Color.FromArgb(74, 74, 74)

        'mengatur font pada grid
        dgvRiwayatPsn.DefaultCellStyle.Font = New Font("Calibri", 11)

        'mengatur border pada grid
        dgvRiwayatPsn.BorderStyle = BorderStyle.Fixed3D
        dgvRiwayatPsn.CellBorderStyle = DataGridViewCellBorderStyle.Single
        dgvRiwayatPsn.GridColor = Color.Black
    End Sub

    'KLIK DGV RIWAYAT
    Private Sub dgvRiwayatPbl_CellContentClick(sender As System.Object, e As DataGridViewCellEventArgs) _
                                            Handles dgvRiwayatPbl.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)

        If (TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn And
            senderGrid.Columns(e.ColumnIndex).Name = "bLht") AndAlso
            e.RowIndex >= 0 Then

            TampilDetail(Val(dgvRiwayatPbl.Rows(e.RowIndex).Cells("idPembelian").Value))
        End If
    End Sub

End Class