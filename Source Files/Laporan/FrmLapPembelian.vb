Imports MySql.Data.MySqlClient

Public Class FrmLapPembelian
    Private Sub FrmLapPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DTP_Awal.Value = Format(Date.Now, "1/MM/yyyy")
        DTP_Akhir.Value = Date.Now
    End Sub

    Private Sub BtnPreview_Click(sender As Object, e As EventArgs) Handles BtnPreview.Click
        Try
            Dim Report As New CRLapPembelian
            ConnDB()

            CSQL = "select pembelian.nofakturbeli, date_format(tglbeli, '%d-%m-%Y') as `tglbeli`, nmsupplier, " &
                " nmbarang, pembelian_detail.hargabeli, subtotal, jumlahbeli from pembelian " &
                " join pembelian_detail on pembelian.nofakturbeli = pembelian_detail.nofakturbeli " &
                " join supplier on pembelian.kdsupplier = supplier.kdsupplier " &
                " join barang on pembelian_detail.kdbarang = barang.kdbarang " &
                " where tglbeli between '" &
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