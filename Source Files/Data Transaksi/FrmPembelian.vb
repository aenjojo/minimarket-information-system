Imports MySql.Data.MySqlClient

Public Class FrmPembelian
    Private Sub TampilGrid()
        ConnDB()

        CSQL = "select nofakturbeli, tglbeli, nmsupplier from pembelian join supplier " &
            "on pembelian.kdsupplier = supplier.kdsupplier order by nofakturbeli desc"
        DA = New MySqlDataAdapter(CSQL, Conn)
        DT = New DataTable

        DA.Fill(DT)
        DGV_Pembelian.DataSource = DT
    End Sub

    Private Sub AturTabel()
        DGV_Pembelian.Columns(0).Width = 150
        DGV_Pembelian.Columns(1).Width = 110
        DGV_Pembelian.Columns(2).Width = 120

        DGV_Pembelian.Columns(0).HeaderText = "No. Faktur Beli"
        DGV_Pembelian.Columns(1).HeaderText = "Tanggal"
        DGV_Pembelian.Columns(2).HeaderText = "Supplier"
    End Sub

    Private Sub TampilDetail()
        ConnDB()

        CSQL = "select nofakturbeli, pembelian_detail.kdbarang, nmbarang, jumlahbeli, " &
            "pembelian_detail.hargabeli, subtotal from pembelian_detail join barang " &
            "on pembelian_detail.kdbarang = barang.kdbarang " &
            "where nofakturbeli = '" & TxtNoFakturBeli.Text & "' order by nmbarang asc"
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

        DGV_Detail.Columns(0).HeaderText = "No. Faktur Beli"
        DGV_Detail.Columns(1).HeaderText = "Kode Barang"
        DGV_Detail.Columns(2).HeaderText = "Nama Barang"
        DGV_Detail.Columns(3).HeaderText = "Jumlah"
        DGV_Detail.Columns(4).HeaderText = "Harga"
        DGV_Detail.Columns(5).HeaderText = "Sub Total"
    End Sub

    Private Sub FrmPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call TampilGrid()
        Call AturTabel()
        Call TampilDetail()
        Call AturDetail()
    End Sub

    Private Sub BtnBaru_Click(sender As Object, e As EventArgs) Handles BtnBaru.Click
        ConnDB()

        CSQL = "select nofakturbeli from pembelian order by nofakturbeli desc"
        CMD = New MySqlCommand(CSQL, Conn)
        DR = CMD.ExecuteReader(CommandBehavior.CloseConnection)

        If DR.Read Then
            TxtNoFakturBeli.Text = "FB-" & Format(Strings.Right(DR("nofakturbeli"), 6) + 1, "000000")
        Else
            TxtNoFakturBeli.Text = "FB-000001"
        End If

        DTP_Pembelian.Focus()
    End Sub

    Private Sub TxtKdSupplier_TextChanged(sender As Object, e As EventArgs) Handles TxtKdSupplier.TextChanged
        ConnDB()

        CSQL = "select * from supplier where kdsupplier='" & TxtKdSupplier.Text & "'"
        CMD = New MySqlCommand(CSQL, Conn)
        DR = CMD.ExecuteReader(CommandBehavior.CloseConnection)

        If DR.Read Then
            TxtNmSupplier.Text = DR("nmsupplier")
        Else
            TxtNmSupplier.Text = ""
        End If
    End Sub

    Private Sub CekBarang()
        ConnDB()

        CSQL = "select * from pembelian_detail where nofakturbeli='" & TxtNoFakturBeli.Text &
            "' and kdbarang='" & TxtKdBarang.Text & "'"
        CMD = New MySqlCommand(CSQL, Conn)
        DR = CMD.ExecuteReader(CommandBehavior.CloseConnection)

        If DR.Read Then
            TxtJlhBeli.Text = DR("jumlahbeli")
            VStok = DR("jumlahbeli")
        Else
            TxtJlhBeli.Text = ""
            VStok = 0
        End If
    End Sub

    Private Sub KosongkanBarang()
        TxtNmBarang.Text = ""
        TxtHarga.Text = ""
        TxtStok.Text = ""
        TxtJlhBeli.Text = ""
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
            TxtHarga.Text = DR("hargabeli")
            TxtStok.Text = DR("stok")

            Call CekBarang()
        Else
            Call KosongkanBarang()
        End If
    End Sub

    Private Sub TxtJlhBeli_TextChanged(sender As Object, e As EventArgs) Handles TxtJlhBeli.TextChanged
        TxtTotal.Text = Val(TxtHarga.Text) * Val(TxtJlhBeli.Text)
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If ValidasiTextKosong({
            New String() {TxtNoFakturBeli.Text, "No. Faktur Pembelian"},
            New String() {TxtNmSupplier.Text, "Kode Supplier"},
            New String() {TxtNmBarang.Text, "Kode Barang"},
            New String() {TxtJlhBeli.Text, "Jumlah Beli"}
        }) Then Exit Sub

        If MsgBox("Apakah data ini akan disimpan?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.No Then Exit Sub

        Try
            ConnDB()

            CSQL = "select nofakturbeli from pembelian where nofakturbeli='" & TxtNoFakturBeli.Text & "'"
            CMD = New MySqlCommand(CSQL, Conn)
            DR = CMD.ExecuteReader(CommandBehavior.CloseConnection)

            If DR.Read Then
                CSQL = "update pembelian set tglbeli='" & Format(DTP_Pembelian.Value, "yyyy-MM-dd") &
                    "', kdsupplier='" & TxtKdSupplier.Text &
                    "', grandtotal='" & VGrand + Val(TxtTotal.Text) - VTotal &
                    "' where nofakturbeli='" & TxtNoFakturBeli.Text & "'"
            Else
                CSQL = "insert into pembelian values ('" & TxtNoFakturBeli.Text &
                    "','" & Format(DTP_Pembelian.Value, "yyyy-MM-dd") &
                    "','" & TxtKdSupplier.Text &
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

        CSQL = "select * from pembelian_detail where nofakturbeli='" & TxtNoFakturBeli.Text & "' and kdbarang='" & TxtKdBarang.Text & "'"
        CMD = New MySqlCommand(CSQL, Conn)
        DR = CMD.ExecuteReader(CommandBehavior.CloseConnection)

        If DR.Read Then
            CSQL = "update pembelian_detail set hargabeli='" & Val(TxtHarga.Text) &
                "', jumlahbeli='" & Val(TxtJlhBeli.Text) &
                "', subtotal='" & Val(TxtTotal.Text) &
                "' where nofakturbeli='" & TxtNoFakturBeli.Text &
                "' and kdbarang='" & TxtKdBarang.Text & "'"
        Else
            CSQL = "insert into pembelian_detail values ('" & TxtNoFakturBeli.Text &
                "','" & TxtKdBarang.Text &
                "','" & Val(TxtHarga.Text) &
                "','" & Val(TxtJlhBeli.Text) &
                "','" & Val(TxtTotal.Text) & "')"
        End If

        ConnDB()
        CMD = New MySqlCommand(CSQL, Conn)
        CMD.ExecuteNonQuery()
    End Sub

    Private Sub SimpanStok()
        ConnDB()

        CSQL = "update barang set stok=" & Val(TxtStok.Text) + Val(TxtJlhBeli.Text) - VStok &
            " where kdbarang='" & TxtKdBarang.Text & "'"
        CMD = New MySqlCommand(CSQL, Conn)
        CMD.ExecuteNonQuery()
    End Sub

    Private Sub HitungGrand()
        ConnDB()

        CSQL = "select sum(grandtotal) as grand from pembelian where nofakturbeli='" & TxtNoFakturBeli.Text & "'"
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
        TxtJlhBeli.Text = DGV_Detail.SelectedCells(3).Value
        VStok = Val(TxtJlhBeli.Text)
        VTotal = Val(TxtTotal.Text)
    End Sub

    Private Sub DGV_Pembelian_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Pembelian.CellClick
        TxtNoFakturBeli.Text = DGV_Pembelian.SelectedCells(0).Value.ToString
        TxtKdBarang.Text = ""
        TxtJlhBeli.Text = ""
    End Sub

    Private Sub KosongkanData()
        DTP_Pembelian.Value = Date.Now
        TxtKdSupplier.Text = ""
        TxtKdBarang.Text = ""
        TxtGrandTotal.Text = 0
        TxtJlhBeli.Text = ""
        TxtPencarian.Text = ""

        Call TampilDetail()
    End Sub

    Private Sub TxtNoFakturBeli_TextChanged(sender As Object, e As EventArgs) Handles TxtNoFakturBeli.TextChanged
        ConnDB()

        CSQL = "select * from pembelian where nofakturbeli='" & TxtNoFakturBeli.Text & "'"
        CMD = New MySqlCommand(CSQL, Conn)
        DR = CMD.ExecuteReader(CommandBehavior.CloseConnection)

        If DR.Read Then
            DTP_Pembelian.Value = DR("tglbeli").ToString
            TxtKdSupplier.Text = DR("kdsupplier").ToString
            TxtKdBarang.Text = ""
            TxtJlhBeli.Text = ""

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

            CSQL = "delete from pembelian_detail where nofakturbeli='" & TxtNoFakturBeli.Text &
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

        CSQL = "update barang set stok=" & Val(TxtStok.Text) - Val(TxtJlhBeli.Text) & " where kdbarang='" & TxtKdBarang.Text & "'"
        CMD = New MySqlCommand(CSQL, Conn)
        CMD.ExecuteNonQuery()
    End Sub

    Private Sub UpdateGrand()
        ConnDB()

        CSQL = "update pembelian set grandtotal=grandtotal-" & Val(TxtTotal.Text) & " where nofakturbeli='" & TxtNoFakturBeli.Text & "'"
        CMD = New MySqlCommand(CSQL, Conn)
        CMD.ExecuteNonQuery()
    End Sub

    Private Sub CekDetail()
        ConnDB()

        CSQL = "select nofakturbeli from pembelian_detail where nofakturbeli='" & TxtNoFakturBeli.Text & "'"
        CMD = New MySqlCommand(CSQL, Conn)
        DR = CMD.ExecuteReader(CommandBehavior.CloseConnection)

        If DR.Read = False Then
            ConnDB()

            CSQL = "delete from pembelian where nofakturbeli='" & TxtNoFakturBeli.Text & "'"
            CMD = New MySqlCommand(CSQL, Conn)
            CMD.ExecuteNonQuery()
        End If

        Call TampilGrid()
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        TxtNoFakturBeli.Text = ""
        TxtPencarian.Text = ""

        Call KosongkanData()
    End Sub

    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        Close()
    End Sub

    Private Sub BtnSupplier_Click(sender As Object, e As EventArgs) Handles BtnSupplier.Click
        Cari = "Supplier"

        FrmPencarian.MdiParent = FrmMenuUtama
        FrmPencarian.Show()
    End Sub

    Private Sub BtnBarang_Click(sender As Object, e As EventArgs) Handles BtnBarang.Click
        Cari = "Barang-Pembelian"

        FrmPencarian.MdiParent = FrmMenuUtama
        FrmPencarian.Show()
    End Sub

    Private Sub TxtPencarian_TextChanged(sender As Object, e As EventArgs) Handles TxtPencarian.TextChanged
        ConnDB()

        CSQL = "select nofakturbeli, tglbeli, nmsupplier from pembelian join supplier " &
            "on pembelian.kdsupplier = supplier.kdsupplier " &
            "where nofakturbeli like '%" & TxtPencarian.Text &
            "%' or nmsupplier like '%" & TxtPencarian.Text &
            "%' order by nofakturbeli asc"
        DA = New MySqlDataAdapter(CSQL, Conn)
        DT = New DataTable

        DA.Fill(DT)
        DGV_Pembelian.DataSource = DT
    End Sub

    Private Sub BtnHapusPencarian_Click(sender As Object, e As EventArgs) Handles BtnHapusPencarian.Click
        TxtPencarian.Text = ""
    End Sub

    Private Sub TxtJlhBeli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtJlhBeli.KeyPress
        ValidasiAngka(e)
    End Sub
End Class