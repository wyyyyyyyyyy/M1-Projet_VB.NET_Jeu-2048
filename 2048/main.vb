Public Class main
  
    Private Sub playmusic()
        'joue en boucle 
        My.Computer.Audio.Play("..\..\images\dragonBall.wav", AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub stopmusic()
        'Arrêt de la lecture de sons 
        My.Computer.Audio.Stop()
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'Cliquer ce boutons pour choisir la version classique
        Form2048_1.Show()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        'Cliquer ce boutons pour choisir la version classique Dragon Ball
        Form2048.Show()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        'joue en boucle par cliquer le bouton
        Call playmusic()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Call stopmusic()
    End Sub

    Private Sub main_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'joue en boucle en arrière-plan
        Call playmusic()
    End Sub
End Class