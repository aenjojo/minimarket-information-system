Public Class FrmTentangProgam
    Private Sub FrmTentangProgam_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call FormKeTengah(FrmMenuUtama, Me)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        Close()
    End Sub
End Class