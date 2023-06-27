<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmJenis
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
        Me.TxtKdJenis = New System.Windows.Forms.TextBox()
        Me.BtnBaru = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.BtnTutup = New System.Windows.Forms.Button()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.TxtNmJenis = New System.Windows.Forms.TextBox()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(202, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data Jenis Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode Jenis"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Jenis"
        '
        'TxtKdJenis
        '
        Me.TxtKdJenis.BackColor = System.Drawing.Color.White
        Me.TxtKdJenis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtKdJenis.ForeColor = System.Drawing.Color.Black
        Me.TxtKdJenis.Location = New System.Drawing.Point(166, 71)
        Me.TxtKdJenis.MaxLength = 10
        Me.TxtKdJenis.Name = "TxtKdJenis"
        Me.TxtKdJenis.Size = New System.Drawing.Size(332, 25)
        Me.TxtKdJenis.TabIndex = 5
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
        Me.BtnSimpan.Location = New System.Drawing.Point(166, 143)
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
        Me.BtnHapus.Location = New System.Drawing.Point(262, 143)
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
        Me.BtnBatal.Location = New System.Drawing.Point(358, 143)
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
        Me.BtnTutup.Location = New System.Drawing.Point(454, 143)
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
        Me.DGV.Location = New System.Drawing.Point(26, 189)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.RowHeadersVisible = False
        Me.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV.Size = New System.Drawing.Size(518, 223)
        Me.DGV.TabIndex = 14
        '
        'TxtNmJenis
        '
        Me.TxtNmJenis.BackColor = System.Drawing.Color.White
        Me.TxtNmJenis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNmJenis.ForeColor = System.Drawing.Color.Black
        Me.TxtNmJenis.Location = New System.Drawing.Point(166, 102)
        Me.TxtNmJenis.MaxLength = 50
        Me.TxtNmJenis.Name = "TxtNmJenis"
        Me.TxtNmJenis.Size = New System.Drawing.Size(378, 25)
        Me.TxtNmJenis.TabIndex = 6
        '
        'FrmJenis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(570, 437)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.BtnTutup)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.BtnBaru)
        Me.Controls.Add(Me.TxtNmJenis)
        Me.Controls.Add(Me.TxtKdJenis)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "FrmJenis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Jenis Barang"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtKdJenis As TextBox
    Friend WithEvents BtnBaru As Button
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnBatal As Button
    Friend WithEvents BtnTutup As Button
    Friend WithEvents DGV As DataGridView
    Friend WithEvents TxtNmJenis As TextBox
End Class
