<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBarang
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtKdBarang = New System.Windows.Forms.TextBox()
        Me.TxtNmBarang = New System.Windows.Forms.TextBox()
        Me.TxtHargaBeli = New System.Windows.Forms.TextBox()
        Me.TxtHargaJual = New System.Windows.Forms.TextBox()
        Me.BtnBaru = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.BtnTutup = New System.Windows.Forms.Button()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.CboJenis = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(230, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Barang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Harga Beli"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Harga Jual"
        '
        'TxtKdBarang
        '
        Me.TxtKdBarang.BackColor = System.Drawing.Color.White
        Me.TxtKdBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtKdBarang.ForeColor = System.Drawing.Color.Black
        Me.TxtKdBarang.Location = New System.Drawing.Point(166, 71)
        Me.TxtKdBarang.MaxLength = 10
        Me.TxtKdBarang.Name = "TxtKdBarang"
        Me.TxtKdBarang.Size = New System.Drawing.Size(332, 25)
        Me.TxtKdBarang.TabIndex = 5
        '
        'TxtNmBarang
        '
        Me.TxtNmBarang.BackColor = System.Drawing.Color.White
        Me.TxtNmBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNmBarang.ForeColor = System.Drawing.Color.Black
        Me.TxtNmBarang.Location = New System.Drawing.Point(166, 133)
        Me.TxtNmBarang.MaxLength = 50
        Me.TxtNmBarang.Name = "TxtNmBarang"
        Me.TxtNmBarang.Size = New System.Drawing.Size(378, 25)
        Me.TxtNmBarang.TabIndex = 6
        '
        'TxtHargaBeli
        '
        Me.TxtHargaBeli.BackColor = System.Drawing.Color.White
        Me.TxtHargaBeli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtHargaBeli.ForeColor = System.Drawing.Color.Black
        Me.TxtHargaBeli.Location = New System.Drawing.Point(166, 164)
        Me.TxtHargaBeli.Name = "TxtHargaBeli"
        Me.TxtHargaBeli.Size = New System.Drawing.Size(378, 25)
        Me.TxtHargaBeli.TabIndex = 7
        '
        'TxtHargaJual
        '
        Me.TxtHargaJual.BackColor = System.Drawing.Color.White
        Me.TxtHargaJual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtHargaJual.ForeColor = System.Drawing.Color.Black
        Me.TxtHargaJual.Location = New System.Drawing.Point(166, 195)
        Me.TxtHargaJual.Name = "TxtHargaJual"
        Me.TxtHargaJual.Size = New System.Drawing.Size(378, 25)
        Me.TxtHargaJual.TabIndex = 8
        '
        'BtnBaru
        '
        Me.BtnBaru.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BtnBaru.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.BtnBaru.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBaru.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBaru.ForeColor = System.Drawing.Color.Blue
        Me.BtnBaru.Location = New System.Drawing.Point(504, 71)
        Me.BtnBaru.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnBaru.Name = "BtnBaru"
        Me.BtnBaru.Size = New System.Drawing.Size(40, 25)
        Me.BtnBaru.TabIndex = 9
        Me.BtnBaru.Text = "+"
        Me.BtnBaru.UseVisualStyleBackColor = False
        '
        'BtnSimpan
        '
        Me.BtnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSimpan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSimpan.ForeColor = System.Drawing.Color.White
        Me.BtnSimpan.Location = New System.Drawing.Point(166, 236)
        Me.BtnSimpan.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(90, 30)
        Me.BtnSimpan.TabIndex = 10
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = False
        '
        'BtnHapus
        '
        Me.BtnHapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BtnHapus.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.BtnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHapus.ForeColor = System.Drawing.Color.Red
        Me.BtnHapus.Location = New System.Drawing.Point(262, 236)
        Me.BtnHapus.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(90, 30)
        Me.BtnHapus.TabIndex = 11
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = False
        '
        'BtnBatal
        '
        Me.BtnBatal.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BtnBatal.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.BtnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBatal.ForeColor = System.Drawing.Color.Blue
        Me.BtnBatal.Location = New System.Drawing.Point(358, 236)
        Me.BtnBatal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(90, 30)
        Me.BtnBatal.TabIndex = 12
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.UseVisualStyleBackColor = False
        '
        'BtnTutup
        '
        Me.BtnTutup.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BtnTutup.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.BtnTutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTutup.ForeColor = System.Drawing.Color.Blue
        Me.BtnTutup.Location = New System.Drawing.Point(454, 236)
        Me.BtnTutup.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(90, 30)
        Me.BtnTutup.TabIndex = 13
        Me.BtnTutup.Text = "Tutup"
        Me.BtnTutup.UseVisualStyleBackColor = False
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.BackgroundColor = System.Drawing.Color.LightGray
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.GridColor = System.Drawing.Color.Gray
        Me.DGV.Location = New System.Drawing.Point(26, 282)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.RowHeadersVisible = False
        Me.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV.Size = New System.Drawing.Size(518, 223)
        Me.DGV.TabIndex = 14
        '
        'CboJenis
        '
        Me.CboJenis.BackColor = System.Drawing.Color.White
        Me.CboJenis.ForeColor = System.Drawing.Color.Black
        Me.CboJenis.FormattingEnabled = True
        Me.CboJenis.Location = New System.Drawing.Point(166, 102)
        Me.CboJenis.Name = "CboJenis"
        Me.CboJenis.Size = New System.Drawing.Size(378, 25)
        Me.CboJenis.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Jenis Barang"
        '
        'FrmBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(570, 532)
        Me.Controls.Add(Me.CboJenis)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.BtnTutup)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.BtnBaru)
        Me.Controls.Add(Me.TxtHargaJual)
        Me.Controls.Add(Me.TxtHargaBeli)
        Me.Controls.Add(Me.TxtNmBarang)
        Me.Controls.Add(Me.TxtKdBarang)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "FrmBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Barang"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtKdBarang As TextBox
    Friend WithEvents TxtNmBarang As TextBox
    Friend WithEvents TxtHargaBeli As TextBox
    Friend WithEvents TxtHargaJual As TextBox
    Friend WithEvents BtnBaru As Button
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnBatal As Button
    Friend WithEvents BtnTutup As Button
    Friend WithEvents DGV As DataGridView
    Friend WithEvents CboJenis As ComboBox
    Friend WithEvents Label6 As Label
End Class
