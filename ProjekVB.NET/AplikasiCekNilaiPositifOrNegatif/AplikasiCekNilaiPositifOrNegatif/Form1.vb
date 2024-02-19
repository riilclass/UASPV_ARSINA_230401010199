Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Deklarasikan Textbox1 menjadi typedata integer dengan variabel(Nilai)
        Dim nilai As Integer = Integer.Parse(TextBox1.Text)

        'Cetak angka apakah negatif atau positif
        If nilai >= 0 Then
            Label2.Text = "Nilai Positif"
        Else
            Label2.Text = "Nilai Negatif"
        End If

    End Sub
End Class
