Module MdlValidasi
    Dim KeyAscii As Short
    Dim KeyChara As Char

    Public Sub ValidasiAngka(Chara As KeyPressEventArgs)
        KeyChara = Chara.KeyChar
        KeyAscii = Asc(KeyChara)

        If (KeyChara Like "[0-9]" OrElse KeyAscii = Keys.Back) Then
            KeyAscii = 0
        Else
            Chara.Handled = CBool(KeyAscii)
        End If
    End Sub

    Public Function ValidasiTextKosong(TextBoxList As String()()) As Boolean
        For Each TextBoxData In TextBoxList
            If TextBoxData(0) = "" Then
                MsgBox("Silakan isi " & TextBoxData(1) & " dengan baik", MsgBoxStyle.Information, "Data tidak valid")
                Return True
            End If
        Next

        Return False
    End Function
End Module
