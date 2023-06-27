Imports MySql.Data.MySqlClient

Public Class FrmLapStokBarang
    Private Function SQLizeKriteria(Data As String) As String
        Dim Text As String = ""

        If Data = "Kode Barang" Then
            Text = "kdbarang"
        ElseIf Data = "Nama Barang" Then
            Text = "nmbarang"
        ElseIf Data = "Jenis Barang" Then
            Text = "nmjenis"
        End If

        Return Text
    End Function

    Private Sub FrmLapStokBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CboKriteria.Text = "Kode Barang"
    End Sub

    Private Sub CboKriteria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboKriteria.SelectedIndexChanged
        TxtPencarian.Text = ""
        TxtPencarian.Focus()
    End Sub

    Private Sub BtnPreview_Click(sender As Object, e As EventArgs) Handles BtnPreview.Click
        Try
            Dim Report As New CRLapStokBarang
            ConnDB()

            CSQL = "select kdbarang, nmbarang, nmjenis, stok from barang join jenis on barang.kdjenis = jenis.kdjenis" &
                " where " & SQLizeKriteria(CboKriteria.Text) & " like '%" & TxtPencarian.Text & "%'"

            DA = New MySqlDataAdapter(CSQL, Conn)
            DT = New DataTable

            DA.Fill(DT)
            Report.SetDataSource(DT)
            Report.Refresh()

            CRViewer.ReportSource = Report
            CRViewer.Refresh()
            CRViewer.Zoom(100)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub
End Class