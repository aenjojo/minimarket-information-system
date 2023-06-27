Imports MySql.Data.MySqlClient

Public Class FrmJenis
    Private Sub FrmJenis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call FormKeTengah(FrmMenuUtama, Me)
        Call TampilGrid()
        Call AturTabel()
    End Sub

    Private Sub TampilGrid()
        ConnDB()

        CSQL = "Select * From jenis Order By kdjenis Asc"
        DA = New MySqlDataAdapter(CSQL, Conn)
        DT = New DataTable

        DA.Fill(DT)
        DGV.DataSource = DT
    End Sub

    Private Sub AturTabel()
        DGV.Columns(0).Width = 120
        DGV.Columns(1).Width = 240

        DGV.Columns(0).HeaderText = "Kode Jenis"
        DGV.Columns(1).HeaderText = "Nama Jenis"
    End Sub

    Private Sub BtnBaru_Click(sender As Object, e As EventArgs) Handles BtnBaru.Click
        ConnDB()

        CSQL = "Select kdjenis From jenis Order By kdjenis Desc"
        CMD = New MySqlCommand(CSQL, Conn)
        DR = CMD.ExecuteReader(CommandBehavior.CloseConnection)

        If DR.Read = True Then
            TxtKdJenis.Text = "JN-" & Format(Strings.Right(DR("kdjenis"), 3) + 1, "000")
        Else
            TxtKdJenis.Text = "JN-001"
        End If

        TxtNmJenis.Focus()
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If ValidasiTextKosong({
            New String() {TxtKdJenis.Text, "Kode Jenis"},
            New String() {TxtNmJenis.Text, "Nama Jenis"}
        }) Then Exit Sub

        If MsgBox("Apakah data ini akan disimpan?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.No Then Exit Sub

        Try
            ConnDB()

            CSQL = "Select kdjenis From jenis Where kdjenis = '" & TxtKdJenis.Text & "'"
            CMD = New MySqlCommand(CSQL, Conn)
            DR = CMD.ExecuteReader(CommandBehavior.CloseConnection)

            If DR.Read Then
                CSQL = "Update jenis Set nmjenis = '" & TxtNmJenis.Text & "' Where kdjenis = '" & TxtKdJenis.Text & "'"
            Else
                CSQL = "Insert Into jenis Values ('" & TxtKdJenis.Text & "','" & TxtNmJenis.Text & "')"
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

            TxtKdJenis.Text = ""
            BtnBaru.Focus()
        End Try
    End Sub

    Private Sub DGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellClick
        On Error Resume Next
        TxtKdJenis.Text = DGV.SelectedCells(0).Value
    End Sub

    Private Sub KosongkanData()
        TxtNmJenis.Text = ""
    End Sub

    Private Sub TxtKdJenis_TextChanged(sender As Object, e As EventArgs) Handles TxtKdJenis.TextChanged
        ConnDB()

        CSQL = "Select * From jenis Where kdjenis = '" & TxtKdJenis.Text & "'"
        CMD = New MySqlCommand(CSQL, Conn)
        DR = CMD.ExecuteReader(CommandBehavior.CloseConnection)

        If DR.Read = True Then
            TxtNmJenis.Text = DR("nmjenis")
        Else
            Call KosongkanData()
        End If
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        If TxtKdJenis.Text = "" Then
            MsgBox("Pilih data yang akan dihapus!", MsgBoxStyle.Critical, "Peringatan")
            Exit Sub
        End If

        If MsgBox("Apakah data ini akan dihapus?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.No Then Exit Sub

        Try
            ConnDB()

            CSQL = "Delete From jenis Where kdjenis = '" & TxtKdJenis.Text & "'"
            CMD = New MySqlCommand(CSQL, Conn)
            CMD.ExecuteNonQuery()

            MsgBox("Data berhasil dihapus.", MsgBoxStyle.Information, "Sukses menghapus")
        Catch ex As Exception
            MsgBox("Maaf, data tidak dapat dihapus...", MsgBoxStyle.Exclamation, "Kesalahan")
        Finally
            Conn.Close()
            Call TampilGrid()

            TxtKdJenis.Text = ""
            BtnBaru.Focus()
        End Try
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        TxtKdJenis.Text = ""
        BtnBaru.Focus()

        Call KosongkanData()
    End Sub

    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        Close()
    End Sub
End Class