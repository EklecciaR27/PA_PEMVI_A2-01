Imports MySql.Data.MySqlClient

Public Class AdminAddBar
    Private Sub AdminAddBar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MANAGE BARANG
        Call Koneksi()
        Call TampilDBSupplier()
        Call ClearBarang()
    End Sub



    'TAMPIL SUPPLIER
    Sub TampilDBSupplier()
        CMD = New MySqlCommand("Select namaSupplier From db_supplier", CONN)
        RD = CMD.ExecuteReader
        Do While RD.Read
            cmbSupplier.Items.Add(RD.Item(0))
        Loop
        RD.Close()
    End Sub

    'CLEAR
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
    Private Sub btnCancelBarang_Click(sender As Object, e As EventArgs) Handles btnCancelBarang.Click
        Call ClearBarang()
    End Sub

    'Suppname to id
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

    Private Sub btnAddBarang_Click(sender As Object, e As EventArgs) Handles btnAddBarang.Click
        Dim IDBarang As String = txtIDBarang.Text.ToUpper
        Dim NamaBarang As String = txtNamaBarang.Text.ToUpper
        Dim JenisBarang As String = cmbJenisBarang.Text.ToUpper
        Dim StokBarang As Integer = Val(txtStokBarang.Text)
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
            CMD = New MySqlCommand("SELECT * FROM db_barang WHERE idBarang ='" & IDBarang & "'", CONN)
            RD = CMD.ExecuteReader
            'proses lainnya'
            RD.Read()
            If Not RD.HasRows Then
                RD.Close()
                Dim Simpan As String = "Insert into db_barang(idBarang,namaBarang,jenisBarang,asalEnergi,stokBarang,idSupplier,hargaBarang)values
                                        ('" & IDBarang & "', '" & NamaBarang & "', '" & JenisBarang & "',
                                         '" & Energi & "', '" & StokBarang & "','" & supplierNameToId(Supplier) & "', '" & HargaBarang & "'  )"
                CMD = New MySqlCommand(Simpan, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Berhasil Menambah Data Barang..", MsgBoxStyle.Information, "Informasi")
            Else
                MsgBox("ERROR! ID Barang telah digunakan! ", MsgBoxStyle.Exclamation)
            End If
            RD.Close()
            'Call TampilBarang()
            Call ClearBarang()
            txtIDBarang.Focus()
        End If
    End Sub




    'HARGA ANGKA ONLY
    Private Sub txtHarga_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHarga.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
            MessageBox.Show("Masukkan inputan berupa angka!")
        End If
    End Sub

    'STOK ANGKA ONLY
    Private Sub txtStokBarang_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStokBarang.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
            MessageBox.Show("Masukkan inputan berupa angka!")
        End If
    End Sub

    'CEK DATA KOSONG BARANG

    Function CekDataKosongBarang()
        If txtIDBarang.Text = "" Then
            MessageBox.Show("ID Barang Harus DiIsi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtIDBarang.Focus()
        ElseIf txtNamaBarang.Text = "" Then
            MessageBox.Show("Nama Barang Harus DiIsi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNamaBarang.Focus()
        ElseIf txtStokBarang.Text = "" Then
            MessageBox.Show("Stok Barang Harus DiIsi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtStokBarang.Focus()
        ElseIf cmbJenisBarang.Text = "" Then
            MessageBox.Show("Jenis Barang Harus DiIsi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbJenisBarang.Focus()
        ElseIf cmbSupplier.Text = "" Then
            MessageBox.Show("Supplier Harus DiIsi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbSupplier.Focus()
        ElseIf txtHarga.Text = "" Then
            MessageBox.Show("Harga Barang Harus DiIsi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtHarga.Focus()
        Else
            Return True
        End If
        Return False
    End Function


    'EXIT / BACK
    Private Sub btnExitAdd_Click(sender As Object, e As EventArgs) Handles btnExitAdd.Click
        Me.Hide()
        AdminForm.Show()
        AdminForm.TampilBarang()
    End Sub

    Private Sub AdminAddBar_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        AdminForm.TampilBarang()
    End Sub
End Class