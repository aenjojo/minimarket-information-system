Imports MySql.Data.MySqlClient

Public Class FrmLogin
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LoginUser()
        If TxtUsername.Text = "" Or TxtPassword.Text = "" Then
            MsgBox("Isi Username dan Password terlebih dahulu.", MsgBoxStyle.Critical, "Kesalahan")
            Exit Sub
        End If

        Try
            Call ConnDB()

            CSQL = "select * from login where username = '" & TxtUsername.Text & "' and password = '" & TxtPassword.Text & "'"
            CMD = New MySqlCommand(CSQL, Conn)
            DR = CMD.ExecuteReader(CommandBehavior.CloseConnection)

            If DR.Read = True Then
                MsgBox("Selamat datang " & DR("nama"), MsgBoxStyle.Information, "Selamat Datang")
                User = DR("username")
                FrmMenuUtama.Show()
                Close()
            Else
                MsgBox("Username dan password Anda salah.", MsgBoxStyle.Critical, "Gagal Login")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Call LoginUser()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Close()
    End Sub
End Class