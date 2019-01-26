Public Class Form2048_1

    Public lbl(16) As Label

    Public Sub controlelabel()
        ' Connecter les labels dans l'interface et les labels dans Form2048

        lbl(1) = lbl1
        lbl(2) = lbl2
        lbl(3) = lbl3
        lbl(4) = lbl4
        lbl(5) = lbl5
        lbl(6) = lbl6
        lbl(7) = lbl7
        lbl(8) = lbl8
        lbl(9) = lbl9
        lbl(10) = lbl10
        lbl(11) = lbl11
        lbl(12) = lbl12
        lbl(13) = lbl13
        lbl(14) = lbl14
        lbl(15) = lbl15
        lbl(16) = lbl16

    End Sub
    Protected Overrides Function processdialogkey(keydata As System.Windows.Forms.Keys) As Boolean
        'detecter si les touches de direction sont pressées
        If keydata = Keys.Up Or keydata = Keys.Down Or keydata = Keys.Left Or keydata = Keys.Right Then
            Return False
        Else
            Return MyBase.ProcessDialogKey(keydata)
        End If
    End Function
    Private Sub Form2048_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ' Connecter des boutons de clavier avec les boutons sur interface
        ' touches ←, →, ↑, ↓
        Select Case e.KeyCode
            Case Keys.Down
                btnDown_Click(sender, e)
            Case Keys.Up
                btnUp_Click(sender, e)
            Case Keys.Left
                btnLeft_Click(sender, e)
            Case Keys.Right
                btnRight_Click(sender, e)
        End Select

        'touches Q D Z S
        Select Case Chr(e.KeyValue)
            Case "S"
                btnDown_Click(sender, e)
            Case "Z"
                btnUp_Click(sender, e)
            Case "Q"
                btnLeft_Click(sender, e)
            Case "D"
                btnRight_Click(sender, e)
        End Select
    End Sub

    Private Sub Form2048_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' initialise la form

        ' Au début, mettre toutes les variables dans le tableau à zéro et randomize 2 chiffres de 2 (de probabilité 90%) ou 4(de probabilité 10%)
        Call initialiser()
        Call Affiche()

        ' Au début, on ne peut pas faire 'undo' car il n'y pas encore un mouvement
        btnUndo.Enabled = False

        Me.KeyPreview = True

    End Sub


    Private Sub Affiche()
        ' Connecter les labels dans l'interface et les labels dans Form2048
        controlelabel()

        ' Connecter les textes de labels dans le form et les variables de jeu() dans la module et les afficher
        Dim i As Integer, j As Integer, l As Byte
        ' Les différentes valeurs sont correspondantes à différentes couleurs
        For i = 1 To n
            For j = 1 To n
                l = (i - 1) * n + j
                If Jeu(i, j) <> 0 Then
                    lbl(l).Text = CStr(Jeu(i, j))
                    Select Case lbl(l).Text = CStr(Jeu(i, j))
                        Case lbl(l).Text = 2
                            lbl(l).BackColor = Color.FromArgb(255, 234, 131)
                        Case lbl(l).Text = 4
                            lbl(l).BackColor = Color.FromArgb(249, 212, 36)
                        Case lbl(l).Text = 8
                            lbl(l).BackColor = Color.FromArgb(248, 152, 69)
                        Case lbl(l).Text = 16
                            lbl(l).BackColor = Color.FromArgb(252, 119, 5)
                        Case lbl(l).Text = 32
                            lbl(l).BackColor = Color.FromArgb(248, 142, 119)
                        Case lbl(l).Text = 64
                            lbl(l).BackColor = Color.FromArgb(251, 47, 26)
                        Case lbl(l).Text = 128
                            lbl(l).BackColor = Color.FromArgb(221, 99, 254)
                        Case lbl(l).Text = 256
                            lbl(l).BackColor = Color.FromArgb(145, 55, 169)
                        Case lbl(l).Text = 512
                            lbl(l).BackColor = Color.FromArgb(73, 198, 244)
                        Case lbl(l).Text = 1024
                            lbl(l).BackColor = Color.FromArgb(34, 163, 118)
                        Case lbl(l).Text = 2048
                            lbl(l).BackColor = Color.FromArgb(243, 13, 1)
                    End Select
                Else
                    lbl(l).Text = ""
                    lbl(l).BackColor = Color.FromArgb(150, 150, 150)
                End If

            Next
        Next

        ' Afficher le score et le score maximum historique
        lblScore.Text = CStr(Score)
        lblScoreMax.Text = CStr(ScoreMax)

        ' vérifiez que le jeu est terminé
        Call JeuBloquer()

    End Sub

    Private Sub btnRestart_Click(sender As System.Object, e As System.EventArgs) Handles btnRestart.Click
        ' gère le redémarrage d'une partie
        ' Afin de faire face à une mauvaise opération inattendue, nous ajoutons un MsgBox pour demander si nous devons redémarrer le jeu.
        Dim restart As Byte
        restart = MsgBox("Vous êtes sûr?", 1, "Restart?????")

        If restart = vbOK Then
            Call initialiser()
            Call Affiche()
            btnLeft.Enabled = True
            btnRight.Enabled = True
            btnUp.Enabled = True
            btnDown.Enabled = True
            btnUndo.Enabled = False
        End If

        If restart = vbCancel Then

        End If
    End Sub

    Private Sub btnUndo_Click(sender As System.Object, e As System.EventArgs) Handles btnUndo.Click
        ' gère l'annulation du coup qui vient dêtre joué (on ne peut annuler qu'un coup)
        Annuler()   'Obtenez la valeur dont nous avons besoin pour afficher
        Affiche()   ', et après les affichez

        btnUndo.Enabled = False

    End Sub

    Private Sub btnLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLeft.Click
        ' gère le déplacement à gauche

        ' Après chaque déplacement, le bouton UNDO est disponible pour annuler ce coup
        btnUndo.Enabled = True
        'If e.KeyCode = Keys.Left Then
        ' enregistrer les variables dans la table temporaire tem() avant le deplacement (Pour 'undo')
        Call tem()
        ' faire le deplacement à gauche
        Call Deplacer(1)
        ' comparer les valeurs avant et après
        Call SubComparer()
        ' Lorsque les valeurs avant et après ne sont pas exactement les même, le jeu peut générer un nombre aléatoire après le déplacement, 
        'et mettre à jour la valeur de la table d'annulation JeuAnnuler (Pour 'UnDo').
        If comparer = False Then
            ' randomize un nouveau chiffre dans le tableau jeu()
            Call TirerAleatoirement()
            Call TableAnnuler()
        End If
        'Lorsque les valeurs du jeu ne changent pas après le coup, le jeu ne génère pas de nouveaux nombres aléatoires. 
        'En même temps, la valeur de la table d'annulation pour UNDO ne sera pas mise à jour. 
        'Cela évite que si le mouvement est effectué plusieurs fois mais que les valeurs ne changent pas, cliquer sur UNDO ne retournera pas 
        'au résultat de l'étape qui changent les valeurs du jeu. C'est pourquoi nous avons d'abord stocké les valeurs du jeu dans la table 
        'temporaire tabletem() puis l'avons comparée, au lieu de les stocker directement dans la table d'annulation JeuAnnuler().
        ' afficher le résultat de deplacement 
        Call Affiche()

    End Sub

    Private Sub btnRight_Click(sender As System.Object, e As System.EventArgs) Handles btnRight.Click
        ' gère le déplacement à droite
        ' Les étapes sont les mêmes que les étapes vers la gauche
        btnUndo.Enabled = True
        Call tem()
        Call Deplacer(2)
        Call SubComparer()
        If comparer = False Then
            Call TirerAleatoirement()
            Call TableAnnuler()
        End If
        Call Affiche()


    End Sub

    Private Sub btnUp_Click(sender As System.Object, e As System.EventArgs) Handles btnUp.Click
        ' gère le déplacement vers le haut
        ' Les étapes sont les mêmes que les étapes vers la gauche
        btnUndo.Enabled = True
        Call tem()
        Call Deplacer(3)
        Call SubComparer()
        If comparer = False Then
            Call TirerAleatoirement()
            Call TableAnnuler()
        End If
        Call Affiche()

    End Sub

    Private Sub btnDown_Click(sender As System.Object, e As System.EventArgs) Handles btnDown.Click
        ' gère le déplacement vers le bas
        ' Les étapes sont les mêmes que les étapes vers la gauche
        btnUndo.Enabled = True
        Call tem()
        Call Deplacer(4)
        Call SubComparer()
        If comparer = False Then
            Call TirerAleatoirement()
            Call TableAnnuler()
        End If
        Call Affiche()


    End Sub

    Private Sub JeuBloquer()
        'quand le Jeu termine, tous les boutons seront être bloqués sauf de bouton 'Restart'
        'Lorsque une valeur est égale à 2048, le jeu gagne et le jeu se termine.
        If JeuGagner() Then
            MsgBox("Vous avez bien atteint 2048 ! Le score est de " & lblScore.Text & " !")
            btnLeft.Enabled = False
            btnRight.Enabled = False
            btnUp.Enabled = False
            btnDown.Enabled = False
            btnUndo.Enabled = False
        End If
        'Quand il n'y a aucune possibilité de continuer à bouger, le jeu se termine.
        If JeuTerminer() Then
            MsgBox("Pas de mouvement possible ! Le score est de " & lblScore.Text & " !")
            btnLeft.Enabled = False
            btnRight.Enabled = False
            btnUndo.Enabled = False
            btnUp.Enabled = False
            btnDown.Enabled = False

        End If
    End Sub



End Class
