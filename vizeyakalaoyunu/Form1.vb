Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Interval = 800
        Dim RastgeleSayi As New Random
        Dim konumX As Integer = RastgeleSayi.Next(0, 495)
        Dim konumY As Integer = RastgeleSayi.Next(45, 450)

        pbStar.Top = konumY
        pbStar.Left = konumX
    End Sub
    Dim sayac As Integer
    Dim sure As Integer
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ProgressBar1.Value += 10
        sure -= 1
        Label3.Text = "Kalan Süre: " + sure.ToString()
        If ProgressBar1.Value = 100 Then
            Timer1.Enabled = False
            Timer2.Enabled = False
            MessageBox.Show("Puanınız: " + sayac.ToString(), "Oyun bitti!")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True
        Timer2.Enabled = True
        sayac = 0
        sure = 10
        ProgressBar1.Value = 0
        Label2.Text = "Puan: 0"
    End Sub

    Private Sub pbStar_Click(sender As Object, e As EventArgs) Handles pbStar.Click
        If Timer1.Enabled = True Then
            sayac += 1
            Label2.Text = "Puan: " + sayac.ToString()
        End If
    End Sub
End Class
