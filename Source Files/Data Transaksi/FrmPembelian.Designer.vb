<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPembelian
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGV_Pembelian = New System.Windows.Forms.DataGridView()
        Me.TxtPencarian = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnHapusPencarian = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnSupplier = New System.Windows.Forms.Button()
        Me.TxtNmSupplier = New System.Windows.Forms.TextBox()
        Me.TxtKdSupplier = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnBarang = New System.Windows.Forms.Button()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.TxtJlhBeli = New System.Windows.Forms.TextBox()
        Me.TxtStok = New System.Windows.Forms.TextBox()
        Me.TxtHarga = New System.Windows.Forms.TextBox()
        Me.TxtNmBarang = New System.Windows.Forms.TextBox()
        Me.TxtKdBarang = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtNoFakturBeli = New System.Windows.Forms.TextBox()
        Me.DTP_Pembelian = New System.Windows.Forms.DateTimePicker()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.BtnTutup = New System.Windows.Forms.Button()
        Me.TxtGrandTotal = New System.Windows.Forms.TextBox()
        Me.DGV_Detail = New System.Windows.Forms.DataGridView()
        Me.BtnBaru = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV_Pembelian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGV_Detail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Transaksi Pembelian"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DGV_Pembelian)
        Me.GroupBox1.Controls.Add(Me.TxtPencarian)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(377, 527)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Pembelian"
        '
        'DGV_Pembelian
        '
        Me.DGV_Pembelian.AllowUserToAddRows = False
        Me.DGV_Pembelian.BackgroundColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Pembelian.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_Pembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Pembelian.GridColor = System.Drawing.Color.Gray
        Me.DGV_Pembelian.Location = New System.Drawing.Point(6, 49)
        Me.DGV_Pembelian.Name = "DGV_Pembelian"
        Me.DGV_Pembelian.ReadOnly = True
        Me.DGV_Pembelian.RowHeadersVisible = False
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Pembelian.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_Pembelian.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Pembelian.Size = New System.Drawing.Size(365, 472)
        Me.DGV_Pembelian.TabIndex = 9
        '
        'TxtPencarian
        '
        Me.TxtPencarian.BackColor = System.Drawing.Color.White
        Me.TxtPencarian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPencarian.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPencarian.ForeColor = System.Drawing.Color.Black
        Me.TxtPencarian.Location = New System.Drawing.Point(88, 18)
        Me.TxtPencarian.Name = "TxtPencarian"
        Me.TxtPencarian.Size = New System.Drawing.Size(244, 25)
        Me.TxtPencarian.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Pencarian"
        '
        'BtnHapusPencarian
        '
        Me.BtnHapusPencarian.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.BtnHapusPencarian.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHapusPencarian.ForeColor = System.Drawing.Color.Red
        Me.BtnHapusPencarian.Location = New System.Drawing.Point(350, 68)
        Me.BtnHapusPencarian.Name = "BtnHapusPencarian"
        Me.BtnHapusPencarian.Size = New System.Drawing.Size(33, 25)
        Me.BtnHapusPencarian.TabIndex = 8
        Me.BtnHapusPencarian.Text = "×"
        Me.BtnHapusPencarian.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnSupplier)
        Me.GroupBox2.Controls.Add(Me.TxtNmSupplier)
        Me.GroupBox2.Controls.Add(Me.TxtKdSupplier)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(395, 140)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(601, 50)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Supplier"
        '
        'BtnSupplier
        '
        Me.BtnSupplier.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.BtnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSupplier.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSupplier.ForeColor = System.Drawing.Color.Blue
        Me.BtnSupplier.Location = New System.Drawing.Point(562, 18)
        Me.BtnSupplier.Name = "BtnSupplier"
        Me.BtnSupplier.Size = New System.Drawing.Size(33, 25)
        Me.BtnSupplier.TabIndex = 9
        Me.BtnSupplier.Text = "..."
        Me.BtnSupplier.UseVisualStyleBackColor = True
        '
        'TxtNmSupplier
        '
        Me.TxtNmSupplier.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.TxtNmSupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNmSupplier.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNmSupplier.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.TxtNmSupplier.Location = New System.Drawing.Point(285, 18)
        Me.TxtNmSupplier.Name = "TxtNmSupplier"
        Me.TxtNmSupplier.ReadOnly = True
        Me.TxtNmSupplier.Size = New System.Drawing.Size(271, 25)
        Me.TxtNmSupplier.TabIndex = 8
        '
        'TxtKdSupplier
        '
        Me.TxtKdSupplier.BackColor = System.Drawing.Color.White
        Me.TxtKdSupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtKdSupplier.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtKdSupplier.ForeColor = System.Drawing.Color.Black
        Me.TxtKdSupplier.Location = New System.Drawing.Point(144, 18)
        Me.TxtKdSupplier.MaxLength = 10
        Me.TxtKdSupplier.Name = "TxtKdSupplier"
        Me.TxtKdSupplier.Size = New System.Drawing.Size(135, 25)
        Me.TxtKdSupplier.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Supplier"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnBarang)
        Me.GroupBox3.Controls.Add(Me.TxtTotal)
        Me.GroupBox3.Controls.Add(Me.TxtJlhBeli)
        Me.GroupBox3.Controls.Add(Me.TxtStok)
        Me.GroupBox3.Controls.Add(Me.TxtHarga)
        Me.GroupBox3.Controls.Add(Me.TxtNmBarang)
        Me.GroupBox3.Controls.Add(Me.TxtKdBarang)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(395, 196)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(601, 113)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Data Barang"
        '
        'BtnBarang
        '
        Me.BtnBarang.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.BtnBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBarang.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBarang.ForeColor = System.Drawing.Color.Blue
        Me.BtnBarang.Location = New System.Drawing.Point(562, 18)
        Me.BtnBarang.Name = "BtnBarang"
        Me.BtnBarang.Size = New System.Drawing.Size(33, 25)
        Me.BtnBarang.TabIndex = 11
        Me.BtnBarang.Text = "..."
        Me.BtnBarang.UseVisualStyleBackColor = True
        '
        'TxtTotal
        '
        Me.TxtTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.TxtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTotal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.TxtTotal.Location = New System.Drawing.Point(460, 81)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(135, 25)
        Me.TxtTotal.TabIndex = 10
        '
        'TxtJlhBeli
        '
        Me.TxtJlhBeli.BackColor = System.Drawing.Color.White
        Me.TxtJlhBeli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtJlhBeli.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtJlhBeli.ForeColor = System.Drawing.Color.Black
        Me.TxtJlhBeli.Location = New System.Drawing.Point(460, 49)
        Me.TxtJlhBeli.Name = "TxtJlhBeli"
        Me.TxtJlhBeli.Size = New System.Drawing.Size(135, 25)
        Me.TxtJlhBeli.TabIndex = 9
        '
        'TxtStok
        '
        Me.TxtStok.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.TxtStok.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtStok.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStok.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.TxtStok.Location = New System.Drawing.Point(144, 80)
        Me.TxtStok.Name = "TxtStok"
        Me.TxtStok.ReadOnly = True
        Me.TxtStok.Size = New System.Drawing.Size(135, 25)
        Me.TxtStok.TabIndex = 8
        '
        'TxtHarga
        '
        Me.TxtHarga.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.TxtHarga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtHarga.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHarga.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.TxtHarga.Location = New System.Drawing.Point(144, 49)
        Me.TxtHarga.Name = "TxtHarga"
        Me.TxtHarga.ReadOnly = True
        Me.TxtHarga.Size = New System.Drawing.Size(135, 25)
        Me.TxtHarga.TabIndex = 7
        '
        'TxtNmBarang
        '
        Me.TxtNmBarang.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.TxtNmBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNmBarang.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNmBarang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.TxtNmBarang.Location = New System.Drawing.Point(285, 18)
        Me.TxtNmBarang.Name = "TxtNmBarang"
        Me.TxtNmBarang.ReadOnly = True
        Me.TxtNmBarang.Size = New System.Drawing.Size(271, 25)
        Me.TxtNmBarang.TabIndex = 6
        '
        'TxtKdBarang
        '
        Me.TxtKdBarang.BackColor = System.Drawing.Color.White
        Me.TxtKdBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtKdBarang.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtKdBarang.ForeColor = System.Drawing.Color.Black
        Me.TxtKdBarang.Location = New System.Drawing.Point(144, 18)
        Me.TxtKdBarang.MaxLength = 10
        Me.TxtKdBarang.Name = "TxtKdBarang"
        Me.TxtKdBarang.Size = New System.Drawing.Size(135, 25)
        Me.TxtKdBarang.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(347, 84)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 17)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Total"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(347, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 17)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Jumlah Beli"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 17)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Stok"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 17)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Harga Beli"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Kode Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(401, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "No. Faktur Pembelian"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(401, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tanggal Pembelian"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(677, 555)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(129, 17)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Total Bayar        Rp."
        '
        'TxtNoFakturBeli
        '
        Me.TxtNoFakturBeli.BackColor = System.Drawing.Color.White
        Me.TxtNoFakturBeli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNoFakturBeli.ForeColor = System.Drawing.Color.Black
        Me.TxtNoFakturBeli.Location = New System.Drawing.Point(539, 68)
        Me.TxtNoFakturBeli.MaxLength = 20
        Me.TxtNoFakturBeli.Name = "TxtNoFakturBeli"
        Me.TxtNoFakturBeli.Size = New System.Drawing.Size(200, 25)
        Me.TxtNoFakturBeli.TabIndex = 6
        '
        'DTP_Pembelian
        '
        Me.DTP_Pembelian.CalendarForeColor = System.Drawing.Color.Black
        Me.DTP_Pembelian.CalendarMonthBackground = System.Drawing.Color.White
        Me.DTP_Pembelian.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DTP_Pembelian.CalendarTitleForeColor = System.Drawing.Color.Black
        Me.DTP_Pembelian.CalendarTrailingForeColor = System.Drawing.Color.Gray
        Me.DTP_Pembelian.Location = New System.Drawing.Point(539, 99)
        Me.DTP_Pembelian.Name = "DTP_Pembelian"
        Me.DTP_Pembelian.Size = New System.Drawing.Size(200, 25)
        Me.DTP_Pembelian.TabIndex = 7
        '
        'BtnSimpan
        '
        Me.BtnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSimpan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSimpan.ForeColor = System.Drawing.Color.White
        Me.BtnSimpan.Location = New System.Drawing.Point(618, 315)
        Me.BtnSimpan.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(90, 30)
        Me.BtnSimpan.TabIndex = 8
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = False
        '
        'BtnHapus
        '
        Me.BtnHapus.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.BtnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHapus.ForeColor = System.Drawing.Color.Red
        Me.BtnHapus.Location = New System.Drawing.Point(714, 315)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(90, 30)
        Me.BtnHapus.TabIndex = 9
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnBatal
        '
        Me.BtnBatal.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.BtnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBatal.ForeColor = System.Drawing.Color.Blue
        Me.BtnBatal.Location = New System.Drawing.Point(810, 315)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(90, 30)
        Me.BtnBatal.TabIndex = 10
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'BtnTutup
        '
        Me.BtnTutup.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.BtnTutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTutup.ForeColor = System.Drawing.Color.Blue
        Me.BtnTutup.Location = New System.Drawing.Point(906, 315)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(90, 30)
        Me.BtnTutup.TabIndex = 11
        Me.BtnTutup.Text = "Tutup"
        Me.BtnTutup.UseVisualStyleBackColor = True
        '
        'TxtGrandTotal
        '
        Me.TxtGrandTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TxtGrandTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtGrandTotal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGrandTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TxtGrandTotal.Location = New System.Drawing.Point(810, 552)
        Me.TxtGrandTotal.Name = "TxtGrandTotal"
        Me.TxtGrandTotal.ReadOnly = True
        Me.TxtGrandTotal.Size = New System.Drawing.Size(186, 25)
        Me.TxtGrandTotal.TabIndex = 12
        Me.TxtGrandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DGV_Detail
        '
        Me.DGV_Detail.AllowUserToAddRows = False
        Me.DGV_Detail.BackgroundColor = System.Drawing.Color.LightGray
        Me.DGV_Detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Detail.GridColor = System.Drawing.Color.Gray
        Me.DGV_Detail.Location = New System.Drawing.Point(395, 351)
        Me.DGV_Detail.Name = "DGV_Detail"
        Me.DGV_Detail.ReadOnly = True
        Me.DGV_Detail.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Detail.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_Detail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Detail.Size = New System.Drawing.Size(601, 195)
        Me.DGV_Detail.TabIndex = 13
        '
        'BtnBaru
        '
        Me.BtnBaru.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.BtnBaru.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBaru.ForeColor = System.Drawing.Color.Blue
        Me.BtnBaru.Location = New System.Drawing.Point(745, 68)
        Me.BtnBaru.Name = "BtnBaru"
        Me.BtnBaru.Size = New System.Drawing.Size(33, 25)
        Me.BtnBaru.TabIndex = 14
        Me.BtnBaru.Text = "+"
        Me.BtnBaru.UseVisualStyleBackColor = True
        '
        'FrmPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1008, 589)
        Me.Controls.Add(Me.BtnBaru)
        Me.Controls.Add(Me.DGV_Detail)
        Me.Controls.Add(Me.BtnHapusPencarian)
        Me.Controls.Add(Me.TxtGrandTotal)
        Me.Controls.Add(Me.BtnTutup)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.DTP_Pembelian)
        Me.Controls.Add(Me.TxtNoFakturBeli)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "FrmPembelian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaksi Pembelian"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV_Pembelian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DGV_Detail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DGV_Pembelian As DataGridView
    Friend WithEvents BtnHapusPencarian As Button
    Friend WithEvents TxtPencarian As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnSupplier As Button
    Friend WithEvents TxtNmSupplier As TextBox
    Friend WithEvents TxtKdSupplier As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents BtnBarang As Button
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents TxtJlhBeli As TextBox
    Friend WithEvents TxtStok As TextBox
    Friend WithEvents TxtHarga As TextBox
    Friend WithEvents TxtNmBarang As TextBox
    Friend WithEvents TxtKdBarang As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtNoFakturBeli As TextBox
    Friend WithEvents DTP_Pembelian As DateTimePicker
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnBatal As Button
    Friend WithEvents BtnTutup As Button
    Friend WithEvents TxtGrandTotal As TextBox
    Friend WithEvents DGV_Detail As DataGridView
    Friend WithEvents BtnBaru As Button
End Class
