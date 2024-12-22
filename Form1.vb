Public Class Form1
    ' Deklarasi array untuk menyimpan data nama karyawan dan gaji pokok
    Private namaKaryawan(4) As String ' Maksimum 5 karyawan (index 0-4)
    Private gajiPokok(4) As Double

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Tampilkan popup message pertama kali aplikasi dijalankan
        MessageBox.Show("Nama: Muhammad Arifin Habibi" & vbNewLine &
                        "NIM: 240401010178" & vbNewLine &
                        "Kelas: IF106",
                        "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Inisialisasi data array
        namaKaryawan(0) = "Karyawan 1"
        gajiPokok(0) = 3000000
        namaKaryawan(1) = "Karyawan 2"
        gajiPokok(1) = 4000000

        ' Set Gaji Total sebagai read-only
        txtGajiTotal.ReadOnly = True
    End Sub

    Private Sub ButtonHitung_Click(sender As Object, e As EventArgs) Handles ButtonHitung.Click
        ' Validasi input
        If txtNama.Text = "" Or txtGajiPokok.Text = "" Or txtJumlahAnak.Text = "" Then
            MessageBox.Show("Harap isi semua field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Parsing input
        Dim inputNama As String = txtNama.Text
        Dim inputGajiPokok As Double
        Dim jumlahAnak As Integer

        If Not Double.TryParse(txtGajiPokok.Text, inputGajiPokok) Or Not Integer.TryParse(txtJumlahAnak.Text, jumlahAnak) Then
            MessageBox.Show("Masukkan angka yang valid untuk Gaji Pokok dan Jumlah Anak!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Validasi jumlah anak
        If jumlahAnak > 3 Then
            MessageBox.Show("Jumlah Anak yang diberi tunjangan hanya sampai anak ke-3", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            jumlahAnak = 3
        End If

        ' Perhitungan Gaji Total
        Dim gajiTotal As Double = inputGajiPokok + (50000 * jumlahAnak)

        ' Cari slot kosong di array
        Dim indexKosong As Integer = Array.IndexOf(namaKaryawan, Nothing)
        If indexKosong <> -1 Then
            namaKaryawan(indexKosong) = inputNama
            gajiPokok(indexKosong) = inputGajiPokok
        Else
            MessageBox.Show("Data karyawan sudah penuh!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Tampilkan hasil
        txtGajiTotal.Text = gajiTotal.ToString("C") ' Format mata uang
    End Sub

    Private Sub ButtonTampilkanData_Click(sender As Object, e As EventArgs) Handles ButtonTampilkanData.Click
        ' Menampilkan semua data karyawan
        Dim hasil As String = "Data Karyawan:" & vbNewLine
        For i As Integer = 0 To namaKaryawan.Length - 1
            If namaKaryawan(i) IsNot Nothing Then
                hasil &= "Nama: " & namaKaryawan(i) & vbNewLine & "Gaji Pokok: " & gajiPokok(i).ToString("C") & vbNewLine & vbNewLine
            End If
        Next
        MessageBox.Show(hasil, "Data Karyawan", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
