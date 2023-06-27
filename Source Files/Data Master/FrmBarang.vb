Imports MySql.Data.MySqlClient

Public Class FrmBarang
    Private Sub FrmBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call FormKeTengah(FrmMenuUtama, Me)
        Call TampilGrid()
        Call AturTabel()
        Call TampilComboJenis()
    End Sub

    Private Sub TampilGrid()
        ConnDB()

        CSQL = "Select kdbarang, nmjenis, nmbarang, stok, hargabeli, hargajual " &
            "From barang Inner Join jenis On barang.kdjenis = jenis.kdjenis Order By kdbarang Asc"

        DA = New MySqlDataAdapter(CSQL, Conn)
        DT = New DataTable

        DA.Fill(DT)
        DGV.DataSource = DT
    End Sub

    Private Sub AturTabel()
        DGV.Columns(0).Width = 120
        DGV.Columns(1).Width = 150
        DGV.Columns(2).Width = 170
        DGV.Columns(3).Width = 100
        DGV.Columns(4).Width = 100
        DGV.Columns(5).Width = 100

        DGV.Columns(0).HeaderText = "Kode Barang"
        DGV.Columns(1).HeaderText = "Jenis Barang"
        DGV.Columns(2).HeaderText = "Nama Barang"
        DGV.Columns(3).HeaderText = "Stok"
        DGV.Columns(4).HeaderText = "Harga Beli"
        DGV.Columns(5).HeaderText = "Harga Jual"
    End Sub

    Private Sub TampilComboJenis()
        ConnDB()

        CSQL = "Select * From jenis Order By kdjenis"
        CMD = New MySqlCommand(CSQL, Conn)
        DR = CMD.ExecuteReader(CommandBehavior.CloseConnection)
        CboJenis.Items.Clear()

        Do While DR.Read
            CboJenis.Items.Add(DR("kdjenis") & " : " & DR("nmjenis"))
        Loop
    End Sub

    Private Sub BtnBaru_Click(sender As Object, e As EventArgs) Handles BtnBaru.Click
        ConnDB()

        CSQL = "Select kdbarang From barang Order By kdbarang Desc"
        CMD = New MySqlCommand(CSQL, Conn)
        DR = CMD.ExecuteReader(CommandBehavior.CloseConnection)

        If DR.Read = True Then
            TxtKdBarang.Text = "BR-" & Format(Strings.Right(DR("kdbarang"), 3) + 1, "000")
        Else
            TxtKdBarang.Text = "BR-001"
        End If

        CboJenis.Focus()
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If ValidasiTextKosong({
            New String() {TxtKdBarang.Text, "Kode Barang"},
            New String() {TxtNmBarang.Text, "Nama Barang"},
            New String() {CboJenis.Text, "Jenis Barang"},
            New String() {TxtHargaBeli.Text, "Harga Beli"},
            New String() {TxtHargaJual.Text, "Harga Jual"}
        }) Then Exit Sub

        If MsgBox("Apakah data ini akan disimpan?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.No Then Exit Sub

        Try
            ConnDB()

            CSQL = "Select kdbarang From barang Where kdbarang='" & TxtKdBarang.Text & "'"
            CMD = New MySqlCommand(CSQL, Conn)
            DR = CMD.ExecuteReader(CommandBehavior.CloseConnection)

            If DR.Read Then
                CSQL = "Update barang Set nmbarang='" & TxtNmBarang.Text &
                    "', kdjenis='" & Strings.Left(CboJenis.Text, 6) &
                    "', hargabeli='" & Val(TxtHargaBeli.Text) &
                    "', hargajual='" & Val(TxtHargaJual.Text) &
                    "' Where kdbarang='" & TxtKdBarang.Text & "'"
            Else
                CSQL = "Insert Into barang Values ('" & TxtKdBarang.Text &
                    "', '" & TxtNmBarang.Text &
                    "', '" & Strings.Left(CboJenis.Text, 6) &
                    "', '" & Val(TxtHargaBeli.Text) &
                    "', '" & Val(TxtHargaJual.Text) &
                    "', '0')"
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

            TxtKdBarang.Text = ""
            BtnBaru.Focus()
        End Try
    End Sub

    Private Sub DGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellClick
        On Error Resume Next
        TxtKdBarang.Text = DGV.SelectedCells(0).Value
    End Sub

    Private Sub KosongkanData()
        TxtNmBarang.Text = ""
        CboJenis.Text = ""
        TxtHargaBeli.Text = ""
        TxtHargaJual.Text = ""
    End Sub

    Private Sub TxtKdBarang_TextChanged(sender As Object, e As EventArgs) Handles TxtKdBarang.TextChanged
        ConnDB()

        CSQL = "Select * From barang Inner Join jenis On barang.kdjenis=jenis.kdjenis Where kdbarang='" & TxtKdBarang.Text & "'"
        CMD = New MySqlCommand(CSQL, Conn)
        DR = CMD.ExecuteReader(CommandBehavior.CloseConnection)

        If DR.Read = True Then
            TxtNmBarang.Text = DR("nmbarang")
            CboJenis.Text = DR("kdjenis") & " : " & DR("nmjenis")
            TxtHargaBeli.Text = DR("hargabeli")
            TxtHargaJual.Text = DR("hargajual")
        Else
            Call KosongkanData()
        End If
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        If TxtKdBarang.Text = "" Then
            MsgBox("Pilih data yang akan dihapus!", MsgBoxStyle.Critical, "Peringatan")
            Exit Sub
        End If

        If MsgBox("Apakah data ini akan dihapus?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.No Then Exit Sub

        Try
            ConnDB()

            CSQL = "Delete From barang Where kdbarang = '" & TxtKdBarang.Text & "'"
            CMD = New MySqlCommand(CSQL, Conn)
            CMD.ExecuteReader(CommandBehavior.CloseConnection)

            MsgBox("Data berhasil dihapus.", MsgBoxStyle.Information, "Sukses menghapus")
        Catch ex As Exception
            MsgBox("Maaf, data tidak dapat dihapus...", MsgBoxStyle.Exclamation, "Kesalahan")
        Finally
            Conn.Close()
            Call TampilGrid()

            TxtKdBarang.Text = ""
            BtnBaru.Focus()
        End Try
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        TxtKdBarang.Text = ""
        Call KosongkanData()
        BtnBaru.Focus()
    End Sub

    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        Close()
    End Sub

    Private Sub TxtHargaBeli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtHargaBeli.KeyPress
        ValidasiAngka(e)
    End Sub

    Private Sub TxtHargaJual_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtHargaJual.KeyPress
        ValidasiAngka(e)
    End Sub
End Class