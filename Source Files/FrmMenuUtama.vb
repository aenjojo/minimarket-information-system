Public Class FrmMenuUtama
    Private Sub FrmMenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    '
    ' Akses
    '
    Private Sub MsiAkses_ManajemenPengguna_Click(sender As Object, e As EventArgs) Handles MsiAkses_ManajemenPengguna.Click
        FrmManajemenPengguna.MdiParent = Me
        FrmManajemenPengguna.Show()
    End Sub

    Private Sub MsiAkses_Keluar_Click(sender As Object, e As EventArgs) Handles MsiAkses_Keluar.Click
        FrmLogin.Show()
        Close()
    End Sub

    '
    ' Data Master
    '
    Private Sub MsiMaster_Supplier_Click(sender As Object, e As EventArgs) Handles MsiMaster_Supplier.Click
        FrmSupplier.MdiParent = Me
        FrmSupplier.Show()
    End Sub

    Private Sub MsiMaster_JenisBarang_Click(sender As Object, e As EventArgs) Handles MsiMaster_JenisBarang.Click
        FrmJenis.MdiParent = Me
        FrmJenis.Show()
    End Sub

    Private Sub MsiMaster_Barang_Click(sender As Object, e As EventArgs) Handles MsiMaster_Barang.Click
        FrmBarang.MdiParent = Me
        FrmBarang.Show()
    End Sub

    Private Sub MsiMaster_Konsumen_Click(sender As Object, e As EventArgs) Handles MsiMaster_Konsumen.Click
        FrmKonsumen.MdiParent = Me
        FrmKonsumen.Show()
    End Sub

    '
    ' Data Transaksi
    '
    Private Sub MsiTransaksi_Pembelian_Click(sender As Object, e As EventArgs) Handles MsiTransaksi_Pembelian.Click
        FrmPembelian.MdiParent = Me
        FrmPembelian.Show()
    End Sub

    Private Sub MsiTransaksi_Penjualan_Click(sender As Object, e As EventArgs) Handles MsiTransaksi_Penjualan.Click
        FrmPenjualan.MdiParent = Me
        FrmPenjualan.Show()
    End Sub

    '
    ' Laporan
    '
    Private Sub MsiLaporan_StokBarang_Click(sender As Object, e As EventArgs) Handles MsiLaporan_StokBarang.Click
        FrmLapStokBarang.MdiParent = Me
        FrmLapStokBarang.Show()
    End Sub

    Private Sub MsiLaporan_Pembelian_Click(sender As Object, e As EventArgs) Handles MsiLaporan_Pembelian.Click
        FrmLapPembelian.MdiParent = Me
        FrmLapPembelian.Show()
    End Sub

    Private Sub MsiLaporan_Penjualan_Click(sender As Object, e As EventArgs) Handles MsiLaporan_Penjualan.Click
        FrmLapPenjualan.MdiParent = Me
        FrmLapPenjualan.Show()
    End Sub

    '
    ' Help
    '
    Private Sub MsiHelp_TentangProgram_Click(sender As Object, e As EventArgs) Handles MsiHelp_TentangProgram.Click
        FrmTentangProgam.MdiParent = Me
        FrmTentangProgam.Show()
    End Sub
End Class
