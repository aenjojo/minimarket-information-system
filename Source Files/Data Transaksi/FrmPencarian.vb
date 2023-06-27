Imports MySql.Data.MySqlClient

Public Class FrmPencarian
    Private Sub TampilGridBarang()
        ConnDB()

        CSQL = "select kdbarang `Kode Barang`, nmbarang `Nama Barang` from barang " &
            "where kdbarang like '%" & TxtPencarian.Text & "%' " &
            "or nmbarang like '%" & TxtPencarian.Text & "%' " &
            "order by kdbarang asc"
        DA = New MySqlDataAdapter(CSQL, Conn)
        DT = New DataTable

        DA.Fill(DT)
        DGV.DataSource = DT
    End Sub

    Private Sub TampilGridSupplier()
        ConnDB()

        CSQL = "select kdsupplier `Kode Supplier`, nmsupplier `Nama Supplier` from supplier " &
            "where kdsupplier like '%" & TxtPencarian.Text & "%' " &
            "or nmsupplier like '%" & TxtPencarian.Text & "%' " &
            "order by kdsupplier asc"
        DA = New MySqlDataAdapter(CSQL, Conn)
        DT = New DataTable

        DA.Fill(DT)
        DGV.DataSource = DT
    End Sub

    Private Sub TampilGridKonsumen()
        ConnDB()

        CSQL = "select kdkonsumen `Kode Konsumen`, nmkonsumen `Nama Konsumen` from konsumen " &
            "where kdkonsumen like '%" & TxtPencarian.Text & "%' " &
            "or nmkonsumen like '%" & TxtPencarian.Text & "%' " &
            "order by kdkonsumen asc"
        DA = New MySqlDataAdapter(CSQL, Conn)
        DT = New DataTable

        DA.Fill(DT)
        DGV.DataSource = DT
    End Sub

    Private Sub AturTabel()
        DGV.Columns(0).Width = 120
        DGV.Columns(1).Width = 150
    End Sub

    Private Sub FrmPencarian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call FormKeTengah(FrmMenuUtama, Me)

        If Strings.Left(Cari, 6) = "Barang" Then
            Call TampilGridBarang()
        ElseIf Cari = "Supplier" Then
            Call TampilGridSupplier()
        ElseIf Cari = "Konsumen" Then
            Call TampilGridKonsumen()
        End If

        LblTitle.Text = "Pencarian " & Split(Cari, "-")(0)
        Call AturTabel()
    End Sub

    Private Sub DGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellClick
        On Error Resume Next

        If Strings.Right(Cari, 9) = "Pembelian" Then
            FrmPembelian.TxtKdBarang.Text = DGV.SelectedCells(0).Value
            FrmPembelian.TxtJlhBeli.Focus()
        ElseIf Cari = "Supplier" Then
            FrmPembelian.TxtKdSupplier.Text = DGV.SelectedCells(0).Value
            FrmPembelian.BtnBarang.Focus()
        ElseIf Strings.Right(Cari, 9) = "Penjualan" Then
            FrmPenjualan.TxtKdBarang.Text = DGV.SelectedCells(0).Value
            FrmPenjualan.TxtJlhJual.Focus()
        ElseIf Cari = "Konsumen" Then
            FrmPenjualan.TxtKdKonsumen.Text = DGV.SelectedCells(0).Value
            FrmPenjualan.BtnBarang.Focus()
        End If
    End Sub

    Private Sub DGV_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellDoubleClick
        Close()
    End Sub

    Private Sub TxtPencarian_TextChanged(sender As Object, e As EventArgs) Handles TxtPencarian.TextChanged
        If Strings.Left(Cari, 6) = "Barang" Then
            Call TampilGridBarang()
        ElseIf Cari = "Supplier" Then
            Call TampilGridSupplier()
        ElseIf Cari = "Konsumen" Then
            Call TampilGridKonsumen()
        End If
    End Sub

    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        Close()
    End Sub
End Class