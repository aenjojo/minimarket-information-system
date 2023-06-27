<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenuUtama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MsiAkses = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsiAkses_ManajemenPengguna = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsiAkses_Keluar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsiDataMaster = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsiMaster_Supplier = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsiMaster_JenisBarang = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsiMaster_Barang = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsiMaster_Konsumen = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsiDataTransaksi = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsiTransaksi_Pembelian = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsiTransaksi_Penjualan = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsiLaporan = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsiLaporan_StokBarang = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsiLaporan_Pembelian = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsiLaporan_Penjualan = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsiHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsiHelp_TentangProgram = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.White
        Me.MenuStrip.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MsiAkses, Me.MsiDataMaster, Me.MsiDataTransaksi, Me.MsiLaporan, Me.MsiHelp})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip.Size = New System.Drawing.Size(830, 25)
        Me.MenuStrip.TabIndex = 1
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'MsiAkses
        '
        Me.MsiAkses.BackColor = System.Drawing.Color.White
        Me.MsiAkses.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MsiAkses_ManajemenPengguna, Me.MsiAkses_Keluar})
        Me.MsiAkses.ForeColor = System.Drawing.Color.Blue
        Me.MsiAkses.Name = "MsiAkses"
        Me.MsiAkses.Size = New System.Drawing.Size(53, 21)
        Me.MsiAkses.Text = "&Akses"
        '
        'MsiAkses_ManajemenPengguna
        '
        Me.MsiAkses_ManajemenPengguna.BackColor = System.Drawing.SystemColors.Control
        Me.MsiAkses_ManajemenPengguna.ForeColor = System.Drawing.Color.Black
        Me.MsiAkses_ManajemenPengguna.Name = "MsiAkses_ManajemenPengguna"
        Me.MsiAkses_ManajemenPengguna.Size = New System.Drawing.Size(206, 22)
        Me.MsiAkses_ManajemenPengguna.Text = "Manajemen Pengguna"
        '
        'MsiAkses_Keluar
        '
        Me.MsiAkses_Keluar.BackColor = System.Drawing.SystemColors.Control
        Me.MsiAkses_Keluar.ForeColor = System.Drawing.Color.Black
        Me.MsiAkses_Keluar.Name = "MsiAkses_Keluar"
        Me.MsiAkses_Keluar.Size = New System.Drawing.Size(206, 22)
        Me.MsiAkses_Keluar.Text = "Keluar"
        '
        'MsiDataMaster
        '
        Me.MsiDataMaster.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MsiMaster_Supplier, Me.MsiMaster_JenisBarang, Me.MsiMaster_Barang, Me.MsiMaster_Konsumen})
        Me.MsiDataMaster.ForeColor = System.Drawing.Color.Blue
        Me.MsiDataMaster.Name = "MsiDataMaster"
        Me.MsiDataMaster.Size = New System.Drawing.Size(92, 21)
        Me.MsiDataMaster.Text = "Data &Master"
        '
        'MsiMaster_Supplier
        '
        Me.MsiMaster_Supplier.ForeColor = System.Drawing.Color.Black
        Me.MsiMaster_Supplier.Name = "MsiMaster_Supplier"
        Me.MsiMaster_Supplier.Size = New System.Drawing.Size(180, 22)
        Me.MsiMaster_Supplier.Text = "Data Supplier"
        '
        'MsiMaster_JenisBarang
        '
        Me.MsiMaster_JenisBarang.ForeColor = System.Drawing.Color.Black
        Me.MsiMaster_JenisBarang.Name = "MsiMaster_JenisBarang"
        Me.MsiMaster_JenisBarang.Size = New System.Drawing.Size(180, 22)
        Me.MsiMaster_JenisBarang.Text = "Data Jenis Barang"
        '
        'MsiMaster_Barang
        '
        Me.MsiMaster_Barang.ForeColor = System.Drawing.Color.Black
        Me.MsiMaster_Barang.Name = "MsiMaster_Barang"
        Me.MsiMaster_Barang.Size = New System.Drawing.Size(180, 22)
        Me.MsiMaster_Barang.Text = "Data Barang"
        '
        'MsiMaster_Konsumen
        '
        Me.MsiMaster_Konsumen.ForeColor = System.Drawing.Color.Black
        Me.MsiMaster_Konsumen.Name = "MsiMaster_Konsumen"
        Me.MsiMaster_Konsumen.Size = New System.Drawing.Size(180, 22)
        Me.MsiMaster_Konsumen.Text = "Data Konsumen"
        '
        'MsiDataTransaksi
        '
        Me.MsiDataTransaksi.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MsiTransaksi_Pembelian, Me.MsiTransaksi_Penjualan})
        Me.MsiDataTransaksi.ForeColor = System.Drawing.Color.Blue
        Me.MsiDataTransaksi.Name = "MsiDataTransaksi"
        Me.MsiDataTransaksi.Size = New System.Drawing.Size(104, 21)
        Me.MsiDataTransaksi.Text = "Data &Transaksi"
        '
        'MsiTransaksi_Pembelian
        '
        Me.MsiTransaksi_Pembelian.ForeColor = System.Drawing.Color.Black
        Me.MsiTransaksi_Pembelian.Name = "MsiTransaksi_Pembelian"
        Me.MsiTransaksi_Pembelian.Size = New System.Drawing.Size(193, 22)
        Me.MsiTransaksi_Pembelian.Text = "Transaksi Pembelian"
        '
        'MsiTransaksi_Penjualan
        '
        Me.MsiTransaksi_Penjualan.ForeColor = System.Drawing.Color.Black
        Me.MsiTransaksi_Penjualan.Name = "MsiTransaksi_Penjualan"
        Me.MsiTransaksi_Penjualan.Size = New System.Drawing.Size(193, 22)
        Me.MsiTransaksi_Penjualan.Text = "Transaksi Penjualan"
        '
        'MsiLaporan
        '
        Me.MsiLaporan.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MsiLaporan_StokBarang, Me.MsiLaporan_Pembelian, Me.MsiLaporan_Penjualan})
        Me.MsiLaporan.ForeColor = System.Drawing.Color.Blue
        Me.MsiLaporan.Name = "MsiLaporan"
        Me.MsiLaporan.Size = New System.Drawing.Size(68, 21)
        Me.MsiLaporan.Text = "&Laporan"
        '
        'MsiLaporan_StokBarang
        '
        Me.MsiLaporan_StokBarang.ForeColor = System.Drawing.Color.Black
        Me.MsiLaporan_StokBarang.Name = "MsiLaporan_StokBarang"
        Me.MsiLaporan_StokBarang.Size = New System.Drawing.Size(198, 22)
        Me.MsiLaporan_StokBarang.Text = "Laporan Stok Barang"
        '
        'MsiLaporan_Pembelian
        '
        Me.MsiLaporan_Pembelian.ForeColor = System.Drawing.Color.Black
        Me.MsiLaporan_Pembelian.Name = "MsiLaporan_Pembelian"
        Me.MsiLaporan_Pembelian.Size = New System.Drawing.Size(198, 22)
        Me.MsiLaporan_Pembelian.Text = "Laporan Pembelian"
        '
        'MsiLaporan_Penjualan
        '
        Me.MsiLaporan_Penjualan.ForeColor = System.Drawing.Color.Black
        Me.MsiLaporan_Penjualan.Name = "MsiLaporan_Penjualan"
        Me.MsiLaporan_Penjualan.Size = New System.Drawing.Size(198, 22)
        Me.MsiLaporan_Penjualan.Text = "Laporan Penjualan"
        '
        'MsiHelp
        '
        Me.MsiHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MsiHelp_TentangProgram})
        Me.MsiHelp.ForeColor = System.Drawing.Color.Blue
        Me.MsiHelp.Name = "MsiHelp"
        Me.MsiHelp.Size = New System.Drawing.Size(47, 21)
        Me.MsiHelp.Text = "&Help"
        '
        'MsiHelp_TentangProgram
        '
        Me.MsiHelp_TentangProgram.ForeColor = System.Drawing.Color.Black
        Me.MsiHelp_TentangProgram.Name = "MsiHelp_TentangProgram"
        Me.MsiHelp_TentangProgram.Size = New System.Drawing.Size(177, 22)
        Me.MsiHelp_TentangProgram.Text = "Tentang Program"
        '
        'FrmMenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(830, 338)
        Me.Controls.Add(Me.MenuStrip)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "FrmMenuUtama"
        Me.Text = "Sistem Informasi Minimarket"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents MsiAkses As ToolStripMenuItem
    Friend WithEvents MsiAkses_ManajemenPengguna As ToolStripMenuItem
    Friend WithEvents MsiAkses_Keluar As ToolStripMenuItem
    Friend WithEvents MsiDataMaster As ToolStripMenuItem
    Friend WithEvents MsiMaster_Supplier As ToolStripMenuItem
    Friend WithEvents MsiMaster_JenisBarang As ToolStripMenuItem
    Friend WithEvents MsiMaster_Barang As ToolStripMenuItem
    Friend WithEvents MsiMaster_Konsumen As ToolStripMenuItem
    Friend WithEvents MsiDataTransaksi As ToolStripMenuItem
    Friend WithEvents MsiTransaksi_Pembelian As ToolStripMenuItem
    Friend WithEvents MsiTransaksi_Penjualan As ToolStripMenuItem
    Friend WithEvents MsiLaporan As ToolStripMenuItem
    Friend WithEvents MsiLaporan_StokBarang As ToolStripMenuItem
    Friend WithEvents MsiLaporan_Pembelian As ToolStripMenuItem
    Friend WithEvents MsiLaporan_Penjualan As ToolStripMenuItem
    Friend WithEvents MsiHelp As ToolStripMenuItem
    Friend WithEvents MsiHelp_TentangProgram As ToolStripMenuItem
End Class
