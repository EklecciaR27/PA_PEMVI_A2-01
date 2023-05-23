Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class FormLogin
    '------------------ PANEL LANDING PAGE ------------------
    'Exit
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    'Sign In
    Private Sub btnKlikLogin_Click(sender As Object, e As EventArgs) Handles btnKlikLogin.Click
        lblSelectedKlikLogin.Visible = True
        lblSelectedKlikRegis.Visible = False

        pnlRegister.Visible = False
        pnlLogin.Visible = True
        pnlLanding.Visible = False
    End Sub

    Private Sub btnKlikLogin_MouseMove(sender As Object, e As MouseEventArgs) Handles btnKlikLogin.MouseMove
        lblSelectedKlikLogin.Visible = True
        lblSelectedKlikRegis.Visible = False
    End Sub

    Private Sub btnKlikLogin_MouseLeave(sender As Object, e As EventArgs) Handles btnKlikLogin.MouseLeave
        lblSelectedKlikLogin.Visible = False
        lblSelectedKlikRegis.Visible = False
    End Sub

    'Sign Up
    Private Sub btnKlikRegis_Click(sender As Object, e As EventArgs) Handles btnKlikRegis.Click
        pnlRegister.Visible = True
        pnlLogin.Visible = False
        pnlLanding.Visible = False
    End Sub

    Private Sub btnKlikRegis_MouseMove(sender As Object, e As MouseEventArgs) Handles btnKlikRegis.MouseMove
        lblSelectedKlikLogin.Visible = False
        lblSelectedKlikRegis.Visible = True
    End Sub

    Private Sub btnKlikRegis_MouseLeave(sender As Object, e As EventArgs) Handles btnKlikRegis.MouseLeave
        lblSelectedKlikLogin.Visible = False
        lblSelectedKlikRegis.Visible = False
    End Sub



    'Klik shop now
    Private Sub btnShopNow_Click(sender As Object, e As EventArgs) Handles btnShopNow.Click
        'Message box login terlebih dahulu
        Dim info As String
        info = MessageBox.Show("Silahkan login terlebih dahulu!", "Pemberitahuan",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Warning)
        If info = MsgBoxResult.Ok Then
            'Muncul form login
            pnlRegister.Visible = False
            pnlLogin.Visible = True
            pnlLanding.Visible = False
        Else
            Exit Sub
        End If
    End Sub




    '------------------ PANEL LOGIN ------------------
    'Exit
    Private Sub btnExitLogin_Click(sender As Object, e As EventArgs) Handles btnExitLogin.Click
        pnlRegister.Visible = False
        pnlLogin.Visible = False
        pnlLanding.Visible = True
    End Sub

    'Klik belum punya akun
    Private Sub btnKlikSignUp_Click(sender As Object, e As EventArgs) Handles btnKlikSignUp.Click
        pnlRegister.Visible = True
        pnlLogin.Visible = False
        pnlLanding.Visible = False
    End Sub


    'Tampilan teks Username waktu diklik
    Private Sub txtUsernameLogin_MouseClick(sender As Object, e As MouseEventArgs) Handles txtUsernameLogin.MouseClick
        If txtUsernameLogin.Text = "Username" Then
            txtUsernameLogin.Clear()
            txtUsernameLogin.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtUsernameLogin_MouseLeave(sender As Object, e As EventArgs) Handles txtUsernameLogin.MouseLeave
        If txtUsernameLogin.Text = "Username" Or txtUsernameLogin.Text = "" Then
            txtUsernameLogin.ForeColor = Color.DarkGray
            txtUsernameLogin.Text = "Username"
        End If
    End Sub

    'Tampilan teks Password waktu diklik
    Private Sub cekShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles cekShowPass.CheckedChanged
        If cekShowPass.Checked Then
            txtPasswordLogin.PasswordChar = ControlChars.NullChar
        Else
            txtPasswordLogin.PasswordChar = "*"
        End If
    End Sub

    Private Sub txtPasswordLogin_MouseClick(sender As Object, e As MouseEventArgs) Handles txtPasswordLogin.MouseClick
        If txtPasswordLogin.Text = "Password" Then
            txtPasswordLogin.Clear()
            txtPasswordLogin.ForeColor = Color.Black
            txtPasswordLogin.PasswordChar = "*"
        End If
    End Sub

    Private Sub txtPasswordLogin_Leave(sender As Object, e As EventArgs) Handles txtPasswordLogin.Leave
        If txtPasswordLogin.Text = "" Then
            txtPasswordLogin.Text = "Password"
            txtPasswordLogin.PasswordChar = ControlChars.NullChar
            txtPasswordLogin.ForeColor = Color.DarkGray
        End If
    End Sub








    'Klik Sign In
    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        Call Koneksi()
        CMD = New MySqlCommand("Select * From db_akun where username='" & txtUsernameLogin.Text & "' and password='" & txtPasswordLogin.Text & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then

            UN = txtUsernameLogin.Text

            If RD("status").ToString = "Admin" Then
                Me.Hide()
                AdminForm.Show()
            ElseIf RD("status").ToString = "Manager" Then
                Me.Hide()
                ManagerForm.Show()
            ElseIf RD("status").ToString = "Staff" Then
                Me.Hide()
                StaffForm.Show()
            Else
                Me.Hide()
                UserForm.Show()

            End If


            txtUsernameLogin.ForeColor = Color.DarkGray
            txtPasswordLogin.ForeColor = Color.DarkGray
            txtUsernameLogin.Text = "Username"
            txtPasswordLogin.Text = "Password"
            Me.Visible = False
            RD.Close()



        ElseIf Not RD.HasRows Then
            MessageBox.Show("Kombinasi Username dan password yang Anda masukkan salah!", "Perhatian",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning)
            txtUsernameLogin.Focus()
            txtUsernameLogin.Text = ""
            txtPasswordLogin.Text = ""

        End If

    End Sub




    '------------------ PANEL REGISTER ------------------
    'Exit
    Private Sub btnExitRegister_Click(sender As Object, e As EventArgs) Handles btnExitRegister.Click
        pnlRegister.Visible = False
        pnlLogin.Visible = False
        pnlLanding.Visible = True
    End Sub

    'Klik sudah punya akun
    Private Sub btnKlikSignIn_Click(sender As Object, e As EventArgs) Handles btnKlikSignIn.Click
        pnlRegister.Visible = False
        pnlLogin.Visible = True
        pnlLanding.Visible = False
    End Sub

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
    Private Sub txtUsernameRegister_MouseClick(sender As Object, e As MouseEventArgs) Handles txtUsernameRegister.MouseClick
        If txtUsernameRegister.Text = "Username" Then
            txtUsernameRegister.Clear()
            txtUsernameRegister.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtUsernameRegister_MouseLeave(sender As Object, e As EventArgs) Handles txtUsernameRegister.MouseLeave
        If txtUsernameRegister.Text = "Username" Or txtUsernameRegister.Text = "" Then
            txtUsernameRegister.ForeColor = Color.DarkGray
            txtUsernameRegister.Text = "Username"
        End If
    End Sub




    'Tampilan teks Password waktu diklik
    Private Sub cekShowPassRegis_CheckedChanged(sender As Object, e As EventArgs) Handles cekShowPassRegis.CheckedChanged
        If cekShowPassRegis.Checked Then
            txtPasswordRegister.PasswordChar = ControlChars.NullChar
            txtConPasswordRegister.PasswordChar = ControlChars.NullChar
        Else
            txtPasswordRegister.PasswordChar = "*"
            txtConPasswordRegister.PasswordChar = "*"
        End If
    End Sub

    Private Sub txtPasswordRegister_MouseClick(sender As Object, e As MouseEventArgs) Handles txtPasswordRegister.MouseClick
        If txtPasswordRegister.Text = "Password" Then
            txtPasswordRegister.Clear()
            txtPasswordRegister.ForeColor = Color.Black
            txtPasswordRegister.PasswordChar = "*"
        End If
    End Sub
    Private Sub txtPasswordRegister_MouseLeave(sender As Object, e As EventArgs) Handles txtPasswordRegister.MouseLeave
        If txtPasswordRegister.Text = "Password" Or txtPasswordRegister.Text = "" Then
            txtPasswordRegister.ForeColor = Color.DarkGray
            txtPasswordRegister.Text = "Password"
            txtPasswordRegister.PasswordChar = ControlChars.NullChar
        End If
    End Sub

    'Tampilan teks Confirm Password waktu diklik
    Private Sub txtConPasswordRegister_MouseClick(sender As Object, e As MouseEventArgs) Handles txtConPasswordRegister.MouseClick
        If txtConPasswordRegister.Text = "Confirm Password" Then
            txtConPasswordRegister.Clear()
            txtConPasswordRegister.ForeColor = Color.Black
            txtConPasswordRegister.PasswordChar = "*"
        End If
    End Sub
    Private Sub txtConPasswordRegister_MouseLeave(sender As Object, e As EventArgs) Handles txtConPasswordRegister.MouseLeave
        If txtConPasswordRegister.Text = "Confirm Password" Or txtConPasswordRegister.Text = "" Then
            txtConPasswordRegister.ForeColor = Color.DarkGray
            txtConPasswordRegister.Text = "Confirm Password"
            txtConPasswordRegister.PasswordChar = ControlChars.NullChar
        End If
    End Sub



    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        ' Check if any field is empty
        If txtUsernameRegister.Text = "" Or txtPasswordRegister.Text = "" Or txtConPasswordRegister.Text = "" Or
            txtFullName.Text = "" Then
            MessageBox.Show("Mohon isi semua field terlebih dahulu.", "Perhatian",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Check if password matches confirm password
        If txtPasswordRegister.Text <> txtConPasswordRegister.Text Then
            MessageBox.Show("Password dan Confirm Password tidak sama.", "Perhatian",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Call Koneksi()
        CMD = New MySqlCommand("Select * From db_akun where username='" & txtUsernameRegister.Text & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        RD.Close()

        If Not RD.HasRows Then
            Dim Daftar As String = "insert into db_akun
                                (username, password, status, fullname)
                                 values ('" &
                                    txtUsernameRegister.Text & "','" &
                                    txtPasswordRegister.Text & "','Pembeli','" &
                                    txtFullName.Text & "')"



            CMD = New MySqlCommand(Daftar, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Registration Success!", MsgBoxStyle.Information, "Pemberitahuan")
            pnlRegister.Visible = False
            pnlLogin.Visible = True


            txtFullName.ForeColor = Color.DarkGray
            txtUsernameRegister.ForeColor = Color.DarkGray
            txtPasswordRegister.ForeColor = Color.DarkGray
            txtConPasswordRegister.ForeColor = Color.DarkGray
            txtFullName.Text = "Full Name"
            txtUsernameRegister.Text = "Username"
            txtPasswordRegister.Text = "Password"
            txtConPasswordRegister.Text = "Confirm Password"

        Else
            MessageBox.Show("Username yang Anda masukkan telah terdaftar, silahkan menuju menu login", "Perhatian",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If
    End Sub
End Class
