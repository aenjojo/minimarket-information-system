Imports MySql.Data.MySqlClient

Public Class FrmLapPenjualan
    Private Sub FrmLapPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DTP_Awal.Value = Format(Date.Now, "1/MM/yyyy")
        DTP_Akhir.Value = Date.Now
    End Sub

    Private Sub BtnPreview_Click(sender As Object, e As EventArgs) Handles BtnPreview.Click
        Try
            Dim Report As New CRLapPenjualan
            ConnDB()

            CSQL = "select penjualan.nofakturjual, date_format(tgljual, '%d-%m-%Y') as `tgljual`, nmkonsumen, " &
                " nmbarang, penjualan_detail.hargajual, subtotal, jumlahjual from penjualan " &
                " join penjualan_detail on penjualan.nofakturjual = penjualan_detail.nofakturjual " &
                " join konsumen on penjualan.kdkonsumen = konsumen.kdkonsumen " &
                " join barang on penjualan_detail.kdbarang = barang.kdbarang " &
                " where tgljual between '" &
                Format(DTP_Awal.Value, "yyyy-MM-dd") & "' and '" &
                Format(DTP_Akhir.Value, "yyyy-MM-dd") & "'"

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