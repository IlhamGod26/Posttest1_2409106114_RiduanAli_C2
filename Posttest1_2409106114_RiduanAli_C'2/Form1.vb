Public Class Form1
    Dim totalIP As Double = 0
    Dim jumlahSemester As Integer = 0

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim inputIP As Double

        If Double.TryParse(txtInputIP.Text, inputIP) Then

            If inputIP < 0 Or inputIP > 4 Then
                MessageBox.Show("IP harus di antara 0.0 - 4.0!")
                Return
            End If

            totalIP = totalIP + inputIP
            jumlahSemester = jumlahSemester + 1
            Dim hasilIPK As Double = totalIP / jumlahSemester

            txtHasilIPK.Text = hasilIPK.ToString("N2")

            If hasilIPK >= 2.0 And hasilIPK <= 2.75 Then
                lblPredikat.Text = "Cukup"
            ElseIf hasilIPK > 2.75 And hasilIPK <= 3.0 Then
                lblPredikat.Text = "Memuaskan"
            ElseIf hasilIPK > 3.0 Then
                lblPredikat.Text = "Sangat Memuaskan"
            Else
                lblPredikat.Text = "-"
            End If

            txtInputIP.Clear()
            txtInputIP.Focus()
        Else
            MessageBox.Show("Masukkan angka IP yang valid!")
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        totalIP = 0
        jumlahSemester = 0
        txtInputIP.Clear()
        txtHasilIPK.Clear()
        lblPredikat.Text = "-"
        MessageBox.Show("Data berhasil direset.")
    End Sub
End Class