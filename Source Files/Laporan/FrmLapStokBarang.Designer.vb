<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLapStokBarang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnPreview = New System.Windows.Forms.Button()
        Me.TxtPencarian = New System.Windows.Forms.TextBox()
        Me.CboKriteria = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CRViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(374, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Laporan Stok Barang"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnClose)
        Me.GroupBox1.Controls.Add(Me.BtnPreview)
        Me.GroupBox1.Controls.Add(Me.TxtPencarian)
        Me.GroupBox1.Controls.Add(Me.CboKriteria)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 38)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(908, 69)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Kriteria"
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BtnClose.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.Blue
        Me.BtnClose.Location = New System.Drawing.Point(812, 30)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(88, 25)
        Me.BtnClose.TabIndex = 4
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnPreview
        '
        Me.BtnPreview.BackColor = System.Drawing.Color.Blue
        Me.BtnPreview.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.BtnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPreview.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPreview.ForeColor = System.Drawing.Color.White
        Me.BtnPreview.Location = New System.Drawing.Point(716, 30)
        Me.BtnPreview.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnPreview.Name = "BtnPreview"
        Me.BtnPreview.Size = New System.Drawing.Size(88, 25)
        Me.BtnPreview.TabIndex = 3
        Me.BtnPreview.Text = "Preview"
        Me.BtnPreview.UseVisualStyleBackColor = False
        '
        'TxtPencarian
        '
        Me.TxtPencarian.BackColor = System.Drawing.Color.White
        Me.TxtPencarian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPencarian.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPencarian.ForeColor = System.Drawing.Color.Black
        Me.TxtPencarian.Location = New System.Drawing.Point(293, 30)
        Me.TxtPencarian.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPencarian.Name = "TxtPencarian"
        Me.TxtPencarian.Size = New System.Drawing.Size(304, 25)
        Me.TxtPencarian.TabIndex = 2
        '
        'CboKriteria
        '
        Me.CboKriteria.BackColor = System.Drawing.Color.White
        Me.CboKriteria.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboKriteria.ForeColor = System.Drawing.Color.Black
        Me.CboKriteria.FormattingEnabled = True
        Me.CboKriteria.Items.AddRange(New Object() {"Kode Barang", "Nama Barang", "Jenis Barang"})
        Me.CboKriteria.Location = New System.Drawing.Point(126, 30)
        Me.CboKriteria.Margin = New System.Windows.Forms.Padding(4)
        Me.CboKriteria.Name = "CboKriteria"
        Me.CboKriteria.Size = New System.Drawing.Size(159, 25)
        Me.CboKriteria.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 33)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Kriteria Pencarian"
        '
        'CRViewer
        '
        Me.CRViewer.ActiveViewIndex = -1
        Me.CRViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRViewer.Location = New System.Drawing.Point(13, 115)
        Me.CRViewer.Margin = New System.Windows.Forms.Padding(4)
        Me.CRViewer.Name = "CRViewer"
        Me.CRViewer.Size = New System.Drawing.Size(908, 381)
        Me.CRViewer.TabIndex = 2
        Me.CRViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CRViewer.ToolPanelWidth = 234
        '
        'FrmLapStokBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(934, 509)
        Me.Controls.Add(Me.CRViewer)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "FrmLapStokBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laporan Stok Barang"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnPreview As Button
    Friend WithEvents TxtPencarian As TextBox
    Friend WithEvents CboKriteria As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CRViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
