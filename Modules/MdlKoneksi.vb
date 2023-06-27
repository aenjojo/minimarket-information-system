Imports MySql.Data.MySqlClient

Module MdlKoneksi
    ReadOnly ConString = "Server=localhost; Uid=root; Database=db_minimarket_josua; Pwd=; SslMode=none"

    Public Conn As New MySqlConnection(ConString)
    Public CSQL As String
    Public CMD As MySqlCommand
    Public DA As MySqlDataAdapter
    Public DT As DataTable
    Public DR As MySqlDataReader
    Public User, Cari, Kriteria As String
    Public VStok As Integer
    Public VGrand As Double
    Public VTotal As Double

    Public Sub ConnDB()
        Try
            TutupDB()
            Conn.Open()
        Catch ex As MySqlException
            MsgBox(ex.Message)
            MsgBox("Koneksi tidak berhasil dilakukan. Periksa database!")
        End Try
    End Sub

    Public Sub TutupDB()
        If Conn.State = ConnectionState.Open Then
            Conn.Close()
        End If
    End Sub

    Public Sub FormKeTengah(parent As Form, child As Form)
        Dim frmA As Form = parent
        Dim frmB As Form = child
        Dim x As Integer = (frmA.Width / 2) - (frmB.Width / 2)
        Dim y As Integer = (frmA.Height / 2.4) - (frmB.Height / 2)

        child.Location = New Point(x, y)
    End Sub
End Module
