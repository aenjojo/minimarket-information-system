Imports MySql.Data.MySqlClient

Public Class FrmKonsumen
    Private Sub FrmKonsumen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call FormKeTengah(FrmMenuUtama, Me)
        Call TampilGrid()
        Call AturTabel()
    End Sub

    Private Sub TampilGrid()
        ConnDB()

        CSQL = "Select * From konsumen Order By kdkonsumen Asc"
        DA = New MySqlDataAdapter(CSQL, Conn)
        DT = New DataTable

        DA.Fill(DT)
        DGV.DataSource = DT
    End Sub

    Private Sub AturTabel()
        DGV.Columns(0).Width = 150
        DGV.Columns(1).Width = 170
        DGV.Columns(2).Width = 170
        DGV.Columns(3).Width = 100

        DGV.Columns(0).HeaderText = "Kode Konsumen"
        DGV.Columns(1).HeaderText = "Nama Konsumen"
        DGV.Columns(2).HeaderText = "Alamat"
        DGV.Columns(3).HeaderText = "No. Telp"
    End Sub

    Private Sub BtnBaru_Click(sender As Object, e As EventArgs) Handles BtnBaru.Click
        ConnDB()

        CSQL = "Select kdkonsumen From konsumen Order By kdkonsumen Desc"
        CMD = New MySqlCommand(CSQL, Conn)
        DR = CMD.ExecuteReader(CommandBehavior.CloseConnection)

        If DR.Read = True Then
            TxtKdKonsumen.Text = "KN-" & Format(Strings.Right(DR("kdkonsumen"), 3) + 1, "000")
        Else
            TxtKdKonsumen.Text = "KN-001"
        End If

        TxtNmKonsumen.Focus()
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If ValidasiTextKosong({
            New String() {TxtKdKonsumen.Text, "Kode Konsumen"},
            New String() {TxtNmKonsumen.Text, "Nama Konsumen"},
            New String() {TxtAlamat.Text, "Alamat"},
            New String() {TxtNoTelp.Text, "No. Telp"}
        }) Then Exit Sub

        If MsgBox("Apakah data ini akan disimpan?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.No Then Exit Sub

        Try
            ConnDB()

            CSQL = "Select kdkonsumen From konsumen Where kdkonsumen = '" & TxtKdKonsumen.Text & "'"
            CMD = New MySqlCommand(CSQL, Conn)
            DR = CMD.ExecuteReader(CommandBehavior.CloseConnection)

            If DR.Read Then
                CSQL = "Update konsumen Set nmkonsumen = '" & TxtNmKonsumen.Text &
                    "', alamat = '" & TxtAlamat.Text &
                    "', notelp = '" & TxtNoTelp.Text &
                    "' Where kdkonsumen = '" & TxtKdKonsumen.Text & "'"
            Else
                CSQL = "Insert Into konsumen Values ('" & TxtKdKonsumen.Text &
                    "', '" & TxtNmKonsumen.Text &
                    "', '" & TxtAlamat.Text &
                    "', '" & TxtNoTelp.Text & "')"
            End If

            ConnDB()
            CMD = New MySqlCommand(CSQL, Conn)
            CMD.ExecuteNonQuery()

            MsgBox("Penyimpanan data telah berhasil dilakukan.", MsgBoxStyle.Information, "Sukses menyimpan")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conn.Close()
            Call TampilGrid()

            TxtKdKonsumen.Text = ""
            BtnBaru.Focus()
        End Try
    End Sub

    Private Sub DGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellClick
        On Error Resume Next
        TxtKdKonsumen.Text = DGV.SelectedCells(0).Value
    End Sub

    Private Sub KosongkanData()
        TxtNmKonsumen.Text = ""
        TxtAlamat.Text = ""
        TxtNoTelp.Text = ""
    End Sub

    Private Sub TxtKdKonsumen_TextChanged(sender As Object, e As EventArgs) Handles TxtKdKonsumen.TextChanged
        ConnDB()

        CSQL = "Select * From konsumen Where kdkonsumen = '" & TxtKdKonsumen.Text & "'"
        CMD = New MySqlCommand(CSQL, Conn)
        DR = CMD.ExecuteReader(CommandBehavior.CloseConnection)

        If DR.Read = True Then
            TxtNmKonsumen.Text = DR("nmkonsumen")
            TxtAlamat.Text = DR("alamat")
            TxtNoTelp.Text = DR("notelp")
        Else
            Call KosongkanData()
        End If
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        If TxtKdKonsumen.Text = "" Then
            MsgBox("Pilih data yang akan dihapus!", MsgBoxStyle.Critical, "Peringatan")
            Exit Sub
        End If

        If MsgBox("Apakah data ini akan dihapus?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.No Then Exit Sub

        Try
            ConnDB()

            CSQL = "Delete From konsumen Where kdkonsumen = '" & TxtKdKonsumen.Text & "'"
            CMD = New MySqlCommand(CSQL, Conn)
            CMD.ExecuteReader(CommandBehavior.CloseConnection)

            MsgBox("Data berhasil dihapus.", MsgBoxStyle.Information, "Sukses menghapus")
        Catch ex As Exception
            MsgBox("Maaf, data tidak dapat dihapus...", MsgBoxStyle.Exclamation, "Kesalahan")
        Finally
            Conn.Close()
            Call TampilGrid()

            TxtKdKonsumen.Text = ""
            BtnBaru.Focus()
        End Try
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        TxtKdKonsumen.Text = ""
        BtnBaru.Focus()

        Call KosongkanData()
    End Sub

    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        Close()
    End Sub
End Class