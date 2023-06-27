Imports MySql.Data.MySqlClient

Public Class FrmSupplier
    Private Sub FrmSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call FormKeTengah(FrmMenuUtama, Me)
        Call TampilGrid()
        Call AturTabel()
    End Sub

    Private Sub TampilGrid()
        ConnDB()

        CSQL = "Select * From supplier Order By kdsupplier Asc"
        DA = New MySqlDataAdapter(CSQL, Conn)
        DT = New DataTable

        DA.Fill(DT)
        DGV.DataSource = DT
    End Sub

    Private Sub AturTabel()
        DGV.Columns(0).Width = 120
        DGV.Columns(1).Width = 170
        DGV.Columns(2).Width = 170
        DGV.Columns(3).Width = 100

        DGV.Columns(0).HeaderText = "Kode Supplier"
        DGV.Columns(1).HeaderText = "Nama Supplier"
        DGV.Columns(2).HeaderText = "Alamat"
        DGV.Columns(3).HeaderText = "No. Telp"
    End Sub

    Private Sub BtnBaru_Click(sender As Object, e As EventArgs) Handles BtnBaru.Click
        ConnDB()

        CSQL = "Select kdsupplier From supplier Order By kdsupplier Desc"
        CMD = New MySqlCommand(CSQL, Conn)
        DR = CMD.ExecuteReader(CommandBehavior.CloseConnection)

        If DR.Read = True Then
            TxtKdSupplier.Text = "SP-" & Format(Strings.Right(DR("kdsupplier"), 3) + 1, "000")
        Else
            TxtKdSupplier.Text = "SP-001"
        End If

        TxtNmSupplier.Focus()
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If ValidasiTextKosong({
            New String() {TxtKdSupplier.Text, "Kode Supplier"},
            New String() {TxtNmSupplier.Text, "Nama Supplier"},
            New String() {TxtAlamat.Text, "Alamat"},
            New String() {TxtNoTelp.Text, "No. Telp"}
        }) Then Exit Sub

        If MsgBox("Apakah data ini akan disimpan?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.No Then Exit Sub

        Try
            ConnDB()

            CSQL = "Select kdsupplier From supplier Where kdsupplier = '" & TxtKdSupplier.Text & "'"
            CMD = New MySqlCommand(CSQL, Conn)
            DR = CMD.ExecuteReader(CommandBehavior.CloseConnection)

            If DR.Read Then
                CSQL = "Update supplier Set nmsupplier = '" & TxtNmSupplier.Text &
                    "', alamat = '" & TxtAlamat.Text &
                    "', notelp = '" & TxtNoTelp.Text &
                    "' Where kdsupplier = '" & TxtKdSupplier.Text & "'"
            Else
                CSQL = "Insert Into supplier Values ('" & TxtKdSupplier.Text &
                    "', '" & TxtNmSupplier.Text &
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

            TxtKdSupplier.Text = ""
            BtnBaru.Focus()
        End Try
    End Sub

    Private Sub DGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellClick
        On Error Resume Next
        TxtKdSupplier.Text = DGV.SelectedCells(0).Value
    End Sub

    Private Sub KosongkanData()
        TxtNmSupplier.Text = ""
        TxtAlamat.Text = ""
        TxtNoTelp.Text = ""
    End Sub

    Private Sub TxtKdSupplier_TextChanged(sender As Object, e As EventArgs) Handles TxtKdSupplier.TextChanged
        ConnDB()

        CSQL = "Select * From supplier Where kdsupplier = '" & TxtKdSupplier.Text & "'"
        CMD = New MySqlCommand(CSQL, Conn)
        DR = CMD.ExecuteReader(CommandBehavior.CloseConnection)

        If DR.Read = True Then
            TxtNmSupplier.Text = DR("nmsupplier")
            TxtAlamat.Text = DR("alamat")
            TxtNoTelp.Text = DR("notelp")
        Else
            Call KosongkanData()
        End If
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        If TxtKdSupplier.Text = "" Then
            MsgBox("Pilih data yang akan dihapus!", MsgBoxStyle.Critical, "Peringatan")
            Exit Sub
        End If

        If MsgBox("Apakah data ini akan dihapus?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.No Then Exit Sub

        Try
            ConnDB()

            CSQL = "Delete From supplier Where kdsupplier = '" & TxtKdSupplier.Text & "'"
            CMD = New MySqlCommand(CSQL, Conn)
            CMD.ExecuteReader(CommandBehavior.CloseConnection)

            MsgBox("Data berhasil dihapus.", MsgBoxStyle.Information, "Sukses menghapus")
        Catch ex As Exception
            MsgBox("Maaf, data tidak dapat dihapus...", MsgBoxStyle.Exclamation, "Kesalahan")
        Finally
            Conn.Close()
            Call TampilGrid()

            TxtKdSupplier.Text = ""
            BtnBaru.Focus()
        End Try
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        TxtKdSupplier.Text = ""
        BtnBaru.Focus()

        Call KosongkanData()
    End Sub

    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        Close()
    End Sub
End Class