Imports MySql.Data.MySqlClient

Public Class AdminAddSup
    Private Sub AdminAddSup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MANAGE SUPPLIER
        Call Koneksi()
        Call ClearSup()
    End Sub


    'ADD SUPPLIER
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

    Sub ClearSup()
        txtCPSupplier.Clear()
        txtIDSupplier.Clear()
        txtNamaSupplier.Clear()
    End Sub

    Private Sub btnTambahSup_Click(sender As Object, e As EventArgs) Handles btnTambahSup.Click
        Call CekDataKosongSup()
        Dim IDSupplier As String = txtIDSupplier.Text.ToUpper
        Dim NamaSupplier As String = txtNamaSupplier.Text.ToUpper
        Dim CPSupplier As String = txtNamaSupplier.Text.ToUpper

        CMD = New MySqlCommand("Select * From db_supplier where idSupplier ='" & txtIDSupplier.Text & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        RD.Close()

        If Not RD.HasRows Then
            Dim Simpan As String = "insert into db_supplier(idSupplier,NamaSupplier,CPSupplier)
                                    values('" & txtIDSupplier.Text.ToUpper & "',
                                           '" & txtNamaSupplier.Text.ToUpper & "',
                                           '" & txtCPSupplier.Text.ToUpper & "')"
            CMD = New MySqlCommand(Simpan, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Berhasil Menambahkan Data Supplier Baru..", MsgBoxStyle.Information, "Perhatian")
        End If
        Call ClearSup()

    End Sub

    'CANCEL
    Private Sub btnCancelSup_Click(sender As Object, e As EventArgs) Handles btnCancelSup.Click
        Call ClearSup()
    End Sub

    'EXIT / BACK
    Private Sub btnExitAdd_Click(sender As Object, e As EventArgs) Handles btnExitAdd.Click
        Me.Hide()
        AdminForm.Show()
        AdminForm.TampilSup()
    End Sub

    Private Sub AdminAddSup_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        AdminForm.TampilSup()
    End Sub

    'CP ANGKA ONLY
    Private Sub txtCPSupplier_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCPSupplier.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
            MessageBox.Show("Masukkan inputan berupa angka!")
            txtCPSupplier.Focus()
        End If
    End Sub


End Class