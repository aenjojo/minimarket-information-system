Imports MySql.Data.MySqlClient

Public Class FrmPenjualan
    Private Sub TampilGrid()
        ConnDB()

        CSQL = "select nofakturjual, tgljual, nmkonsumen from penjualan join konsumen " &
            "on penjualan.kdkonsumen = konsumen.kdkonsumen order by nofakturjual desc"
        DA = New MySqlDataAdapter(CSQL, Conn)
        DT = New DataTable

        DA.Fill(DT)
        DGV_Penjualan.DataSource = DT
    End Sub

    Private Sub AturTabel()
        DGV_Penjualan.Columns(0).Width = 150
        DGV_Penjualan.Columns(1).Width = 110
        DGV_Penjualan.Columns(2).Width = 120

        DGV_Penjualan.Columns(0).HeaderText = "No. Faktur Jual"
        DGV_Penjualan.Columns(1).HeaderText = "Tanggal"
        DGV_Penjualan.Columns(2).HeaderText = "Konsumen"
    End Sub

    Private Sub TampilDetail()
        ConnDB()

        CSQL = "select nofakturjual, penjualan_detail.kdbarang, nmbarang, jumlahjual, " &
            "penjualan_detail.hargajual, subtotal from penjualan_detail join barang " &
            "on penjualan_detail.kdbarang = barang.kdbarang " &
            "where nofakturjual = '" & TxtNoFakturJual.Text & "' order by nmbarang asc"
        DA = New MySqlDataAdapter(CSQL, Conn)
        DT = New DataTable

        DA.Fill(DT)
        DGV_Detail.DataSource = DT
    End Sub

    Private Sub AturDetail()
        DGV_Detail.Columns(0).Width = 150
        DGV_Detail.Columns(1).Width = 120
        DGV_Detail.Columns(2).Width = 170
        DGV_Detail.Columns(3).Width = 130
        DGV_Detail.Columns(4).Width = 130
        DGV_Detail.Columns(5).Width = 130

        DGV_Detail.Columns(0).HeaderText = "No. Faktur Jual"
        DGV_Detail.Columns(1).HeaderText = "Kode Barang"
        DGV_Detail.Columns(2).HeaderText = "Nama Barang"
        DGV_Detail.Columns(3).HeaderText = "Jumlah"
        DGV_Detail.Columns(4).HeaderText = "Harga"
        DGV_Detail.Columns(5).HeaderText = "Sub Total"
    End Sub

    Private Sub FrmPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call TampilGrid()
        Call AturTabel()
        Call TampilDetail()
        Call AturDetail()
    End Sub

    Private Sub BtnBaru_Click(sender As Object, e As EventArgs) Handles BtnBaru.Click
        ConnDB()

        CSQL = "select nofakturjual from penjualan order by nofakturjual desc"
        CMD = New MySqlCommand(CSQL, Conn)
        DR = CMD.ExecuteReader(CommandBehavior.CloseConnection)

        If DR.Read Then
            TxtNoFakturJual.Text = "FJ-" & Format(Strings.Right(DR("nofakturjual"), 6) + 1, "000000")
        Else
            TxtNoFakturJual.Text = "FJ-000001"
        End If

        DTP_Penjualan.Focus()
    End Sub

    Private Sub TxtKdKonsumen_TextChanged(sender As Object, e As EventArgs) Handles TxtKdKonsumen.TextChanged
        ConnDB()

        CSQL = "select * from konsumen where kdkonsumen='" & TxtKdKonsumen.Text & "'"
        CMD = New MySqlCommand(CSQL, Conn)
        DR = CMD.ExecuteReader(CommandBehavior.CloseConnection)

        If DR.Read Then
            TxtNmKonsumen.Text = DR("nmkonsumen")
        Else
            TxtNmKonsumen.Text = ""
        End If
    End Sub

    Private Sub CekBarang()
        ConnDB()

        CSQL = "select * from penjualan_detail where nofakturjual='" & TxtNoFakturJual.Text &
            "' and kdbarang='" & TxtKdBarang.Text & "'"
        CMD = New MySqlCommand(CSQL, Conn)
        DR = CMD.ExecuteReader(CommandBehavior.CloseConnection)

        If DR.Read Then
            TxtJlhJual.Text = DR("jumlahjual")
            VStok = DR("jumlahjual")
        Else
            TxtJlhJual.Text = ""
            VStok = 0
        End If
    End Sub

    Private Sub KosongkanBarang()
        TxtNmBarang.Text = ""
        TxtHarga.Text = ""
        TxtStok.Text = ""
        TxtJlhJual.Text = ""
        VStok = 0
        VTotal = 0
    End Sub

    Private Sub TxtKdBarang_TextChanged(sender As Object, e As EventArgs) Handles TxtKdBarang.TextChanged
        ConnDB()

        CSQL = "select * from barang where kdbarang='" & TxtKdBarang.Text & "'"
        CMD = New MySqlCommand(CSQL, Conn)
        DR = CMD.ExecuteReader(CommandBehavior.CloseConnection)

        If DR.Read Then
            TxtNmBarang.Text = DR("nmbarang")
            TxtHarga.Text = DR("hargajual")
            TxtStok.Text = DR("stok")

            Call CekBarang()
        Else
            Call KosongkanBarang()
        End If
    End Sub

    Private Sub TxtJlhJual_TextChanged(sender As Object, e As EventArgs) Handles TxtJlhJual.TextChanged
        TxtTotal.Text = Val(TxtHarga.Text) * Val(TxtJlhJual.Text)
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If ValidasiTextKosong({
            New String() {TxtNoFakturJual.Text, "No. Faktur Penjualan"},
            New String() {TxtNmKonsumen.Text, "Kode Barang"},
            New String() {TxtNmBarang.Text, "Kode Barang"},
            New String() {TxtJlhJual.Text, "Jumlah Jual"}
        }) Then Exit Sub

        If MsgBox("Apakah data ini akan disimpan?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.No Then Exit Sub

        Try
            ConnDB()

            CSQL = "select nofakturjual from penjualan where nofakturjual='" & TxtNoFakturJual.Text & "'"
            CMD = New MySqlCommand(CSQL, Conn)
            DR = CMD.ExecuteReader(CommandBehavior.CloseConnection)

            If DR.Read Then
                CSQL = "update penjualan set tgljual='" & Format(DTP_Penjualan.Value, "yyyy-MM-dd") &
                    "', kdkonsumen='" & TxtKdKonsumen.Text &
                    "', grandtotal='" & VGrand + Val(TxtTotal.Text) - VTotal &
                    "' where nofakturjual='" & TxtNoFakturJual.Text & "'"
            Else
                CSQL = "insert into penjualan values ('" & TxtNoFakturJual.Text &
                    "','" & Format(DTP_Penjualan.Value, "yyyy-MM-dd") &
                    "','" & TxtKdKonsumen.Text &
                    "','" & TxtTotal.Text & "')"
            End If

            ConnDB()
            CMD = New MySqlCommand(CSQL, Conn)
            CMD.ExecuteNonQuery()

            Call SimpanDetail()
            Call SimpanStok()

            MsgBox("Penyimpanan data telah berhasil dilakukan.", MsgBoxStyle.Information, "Sukses disimpan")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conn.Close()
            Call TampilGrid()
            Call TampilDetail()
            Call HitungGrand()

            TxtKdBarang.Text = ""
        End Try
    End Sub

    Private Sub SimpanDetail()
        ConnDB()

        CSQL = "select * from penjualan_detail where nofakturjual='" & TxtNoFakturJual.Text & "' and kdbarang='" & TxtKdBarang.Text & "'"
        CMD = New MySqlCommand(CSQL, Conn)
        DR = CMD.ExecuteReader(CommandBehavior.CloseConnection)

        If DR.Read Then
            CSQL = "update penjualan_detail set hargajual='" & Val(TxtHarga.Text) &
                "', jumlahjual='" & Val(TxtJlhJual.Text) &
                "', subtotal='" & Val(TxtTotal.Text) &
                "' where nofakturjual='" & TxtNoFakturJual.Text &
                "' and kdbarang='" & TxtKdBarang.Text & "'"
        Else
            CSQL = "insert into penjualan_detail values ('" & TxtNoFakturJual.Text &
                "','" & TxtKdBarang.Text &
                "','" & Val(TxtHarga.Text) &
                "','" & Val(TxtJlhJual.Text) &
                "','" & Val(TxtTotal.Text) & "')"
        End If

        ConnDB()
        CMD = New MySqlCommand(CSQL, Conn)
        CMD.ExecuteNonQuery()
    End Sub

    Private Sub SimpanStok()
        ConnDB()

        CSQL = "update barang set stok=" & Val(TxtStok.Text) - Val(TxtJlhJual.Text) + VStok &
            " where kdbarang='" & TxtKdBarang.Text & "'"
        CMD = New MySqlCommand(CSQL, Conn)
        CMD.ExecuteNonQuery()
    End Sub

    Private Sub HitungGrand()
        ConnDB()

        CSQL = "select sum(grandtotal) as grand from penjualan where nofakturjual='" & TxtNoFakturJual.Text & "'"
        CMD = New MySqlCommand(CSQL, Conn)
        DR = CMD.ExecuteReader(CommandBehavior.CloseConnection)

        If DR.Read Then
            TxtGrandTotal.Text = DR("grand").ToString
        Else
            TxtGrandTotal.Text = 0
        End If

        VGrand = Val(TxtGrandTotal.Text)
    End Sub

    Private Sub DGV_Detail_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Detail.CellClick
        On Error Resume Next
        TxtKdBarang.Text = DGV_Detail.SelectedCells(1).Value.ToString
        TxtJlhJual.Text = DGV_Detail.SelectedCells(3).Value
        VStok = Val(TxtJlhJual.Text)
        VTotal = Val(TxtTotal.Text)
    End Sub

    Private Sub DGV_Penjualan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Penjualan.CellClick
        TxtNoFakturJual.Text = DGV_Penjualan.SelectedCells(0).Value.ToString
        TxtKdBarang.Text = ""
        TxtJlhJual.Text = ""
    End Sub

    Private Sub KosongkanData()
        DTP_Penjualan.Value = Date.Now
        TxtKdKonsumen.Text = ""
        TxtKdBarang.Text = ""
        TxtGrandTotal.Text = 0
        TxtJlhJual.Text = ""
        TxtPencarian.Text = ""

        Call TampilDetail()
    End Sub

    Private Sub TxtNoFakturJual_TextChanged(sender As Object, e As EventArgs) Handles TxtNoFakturJual.TextChanged
        ConnDB()

        CSQL = "select * from penjualan where nofakturjual='" & TxtNoFakturJual.Text & "'"
        CMD = New MySqlCommand(CSQL, Conn)
        DR = CMD.ExecuteReader(CommandBehavior.CloseConnection)

        If DR.Read Then
            DTP_Penjualan.Value = DR("tgljual").ToString
            TxtKdKonsumen.Text = DR("kdkonsumen").ToString
            TxtKdBarang.Text = ""
            TxtJlhJual.Text = ""

            Call HitungGrand()
            Call TampilDetail()
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

            CSQL = "delete from penjualan_detail where nofakturjual='" & TxtNoFakturJual.Text &
                "' and kdbarang='" & TxtKdBarang.Text & "'"
            CMD = New MySqlCommand(CSQL, Conn)
            CMD.ExecuteNonQuery()

            Call HapusStok()
            Call UpdateGrand()

            MsgBox("Data berhasil dihapus.", MsgBoxStyle.Information, "Sukses menghapus")
        Catch ex As Exception
            MsgBox("Maaf, data tidak bisa dihapus...", MsgBoxStyle.Exclamation, "Kesalahan")
        Finally
            Conn.Close()

            Call TampilGrid()
            Call TampilDetail()
            Call HitungGrand()
            Call CekDetail()

            TxtKdBarang.Text = ""
        End Try
    End Sub

    Private Sub HapusStok()
        ConnDB()

        CSQL = "update barang set stok=" & Val(TxtStok.Text) + Val(TxtJlhJual.Text) & " where kdbarang='" & TxtKdBarang.Text & "'"
        CMD = New MySqlCommand(CSQL, Conn)
        CMD.ExecuteNonQuery()
    End Sub

    Private Sub UpdateGrand()
        ConnDB()

        CSQL = "update penjualan set grandtotal=grandtotal-" & Val(TxtTotal.Text) & " where nofakturjual='" & TxtNoFakturJual.Text & "'"
        CMD = New MySqlCommand(CSQL, Conn)
        CMD.ExecuteNonQuery()
    End Sub

    Private Sub CekDetail()
        ConnDB()

        CSQL = "select nofakturjual from penjualan_detail where nofakturjual='" & TxtNoFakturJual.Text & "'"
        CMD = New MySqlCommand(CSQL, Conn)
        DR = CMD.ExecuteReader(CommandBehavior.CloseConnection)

        If DR.Read = False Then
            ConnDB()

            CSQL = "delete from penjualan where nofakturjual='" & TxtNoFakturJual.Text & "'"
            CMD = New MySqlCommand(CSQL, Conn)
            CMD.ExecuteNonQuery()
        End If

        Call TampilGrid()
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        TxtNoFakturJual.Text = ""
        TxtPencarian.Text = ""

        Call KosongkanData()
    End Sub

    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        Close()
    End Sub

    Private Sub BtnKonsumen_Click(sender As Object, e As EventArgs) Handles BtnKonsumen.Click
        Cari = "Konsumen"

        FrmPencarian.MdiParent = FrmMenuUtama
        FrmPencarian.Show()
    End Sub

    Private Sub BtnBarang_Click(sender As Object, e As EventArgs) Handles BtnBarang.Click
        Cari = "Barang-Penjualan"

        FrmPencarian.MdiParent = FrmMenuUtama
        FrmPencarian.Show()
    End Sub

    Private Sub TxtPencarian_TextChanged(sender As Object, e As EventArgs) Handles TxtPencarian.TextChanged
        ConnDB()

        CSQL = "select nofakturjual, tgljual, nmkonsumen from penjualan join konsumen " &
            "on penjualan.kdkonsumen = konsumen.kdkonsumen " &
            "where nofakturjual like '%" & TxtPencarian.Text &
            "%' or nmkonsumen like '%" & TxtPencarian.Text &
            "%' order by nofakturjual asc"
        DA = New MySqlDataAdapter(CSQL, Conn)
        DT = New DataTable

        DA.Fill(DT)
        DGV_Penjualan.DataSource = DT
    End Sub

    Private Sub BtnHapusPencarian_Click(sender As Object, e As EventArgs) Handles BtnHapusPencarian.Click
        TxtPencarian.Text = ""
    End Sub

    Private Sub TxtJlhJual_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtJlhJual.KeyPress
        ValidasiAngka(e)
    End Sub
End Class