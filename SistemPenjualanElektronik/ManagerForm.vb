Imports MySql.Data.MySqlClient

Public Class ManagerForm
    Private Sub ManagerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call TampilRiwayat()
        Call hitungTotal()
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

    'Logout
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        lblSelectedLaporan.Visible = False
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

    Private Sub btnLaporan_Click(sender As Object, e As EventArgs) Handles btnLaporan.Click
        lblSelectedLaporan.Visible = True
        pnlLaporan.Visible = True

        lblSelectedLogout.Visible = False

    End Sub



    '------------------ PANEL RIWAYAT ------------------

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


    Sub TampilRiwayat()
        Dim cmd As New MySqlCommand("SELECT idPembelian, totalJumlah, totalharga, status FROM pembelian WHERE status = '" & "selesai" & "'", CONN)
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

    'HITUNG TOTAL 
    'Hitung total harga seluruh pesanan
    Private Sub hitungTotal()
        If dgvRiwayatPbl.Rows.Count <> 0 Then
            Dim totalHarga As Integer = 0
            For i = 0 To dgvRiwayatPbl.RowCount - 1
                totalHarga += dgvRiwayatPbl.Rows(i).Cells(2).Value
            Next
            txtTotal.Text = totalHarga
        Else
            txtTotal.Text = 0
        End If
    End Sub

End Class