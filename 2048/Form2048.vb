Public Class Form2048

    Public lbl(16) As Label
    Public button1 As Image
    Public button2 As Image

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
        'definir les styles différents de button 'undo' quand il est bloqué ou pas
        Call buttonstyle()
        ' Au début, mettre toutes les variables dans le tableau à zéro et randomize 2 chiffres de 2 (de probabilité 90%) ou 4(de probabilité 10%)
        Call initialiser()
        Call Affiche()
        ' Au début, on ne peut pas faire 'undo' car il n'y pas encore un mouvement
        btnUndo.Enabled = False
        'definir les styles différents de button 'undo' quand il est bloqué ou pas
        Me.KeyPreview = True

    End Sub

    Private Sub Affiche()
        'preparer des images différent pour des labels avec des valeurs différentes

        Dim image1 As Image
        Dim image2 As Image
        Dim image3 As Image
        Dim image4 As Image
        Dim image5 As Image
        Dim image6 As Image
        Dim image7 As Image
        Dim image8 As Image
        Dim image9 As Image
        Dim image10 As Image
        Dim image11 As Image
        Dim image13 As Image

        'extraire des images dans le ficher (path relative)
        image1 = Image.FromFile("..\..\images\01.png")
        image2 = Image.FromFile("..\..\images\02.png")
        image3 = Image.FromFile("..\..\images\03.png")
        image4 = Image.FromFile("..\..\images\04.png")
        image5 = Image.FromFile("..\..\images\05.png")
        image6 = Image.FromFile("..\..\images\06.png")
        image7 = Image.FromFile("..\..\images\07.png")
        image8 = Image.FromFile("..\..\images\08.png")
        image9 = Image.FromFile("..\..\images\09.png")
        image10 = Image.FromFile("..\..\images\10.png")
        image11 = Image.FromFile("..\..\images\11.png")
        image13 = Image.FromFile("..\..\images\13.png")
        button1 = Image.FromFile("..\..\images\button1.png")
        button2 = Image.FromFile("..\..\images\button2.png")

        ' Connecter les labels dans l'interface et les labels dans Form2048
        controlelabel()

        ' Connecter les textes de labels dans le form et les variables de jeu() dans la module et les afficher
        Dim i As Integer, j As Integer, l As Byte
        ' Les différentes valeurs sont correspondantes à différentes images
        For i = 1 To n
            For j = 1 To n
                l = (i - 1) * n + j
                If Jeu(i, j) <> 0 Then
                    lbl(l).Text = CStr(Jeu(i, j))
                    Select Case lbl(l).Text = CStr(Jeu(i, j))
                        Case lbl(l).Text = 2
                            lbl(l).Text = ""
                            lbl(l).Image = image1
                        Case lbl(l).Text = 4
                            lbl(l).Text = ""
                            lbl(l).Image = image2
                        Case lbl(l).Text = 8
                            lbl(l).Text = ""
                            lbl(l).Image = image3
                        Case lbl(l).Text = 16
                            lbl(l).Text = ""
                            lbl(l).Image = image4
                        Case lbl(l).Text = 32
                            lbl(l).Text = ""
                            lbl(l).Image = image5
                        Case lbl(l).Text = 64
                            lbl(l).Text = ""
                            lbl(l).Image = image6
                        Case lbl(l).Text = 128
                            lbl(l).Text = ""
                            lbl(l).Image = image7
                        Case lbl(l).Text = 256
                            lbl(l).Text = ""
                            lbl(l).Image = image8
                        Case lbl(l).Text = 512
                            lbl(l).Text = ""
                            lbl(l).Image = image9
                        Case lbl(l).Text = 1024
                            lbl(l).Text = ""
                            lbl(l).Image = image10
                        Case lbl(l).Text = 2048
                            lbl(l).Text = ""
                            lbl(l).Image = image11
                    End Select
                Else
                    lbl(l).Text = ""

                    lbl(l).Image = image13

                End If

            Next
        Next

        'definir les styles différents de button 'undo' quand il est bloqué ou pas
        Call buttonstyle()
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
        Call buttonstyle()
    End Sub

    Private Sub btnLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLeft.Click
        ' gère le déplacement à gauche
        'If e.KeyCode = Keys.Left Then
        ' enregistrer les variables dans la table temporaire tem() avant le deplacement (Pour 'undo')
        btnUndo.Enabled = True
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
        ' après chaque deplacement, on peut annuler qu'un coup



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

    Private Sub buttonstyle()
        'definir les styles différents de button 'undo' quand il est bloqué ou pas
        If btnUndo.Enabled = True Then
            btnUndo.BackgroundImage = button1
            btnUndo.ForeColor = Color.RoyalBlue
        ElseIf btnUndo.Enabled = False Then
            btnUndo.BackgroundImage = button2
            btnUndo.ForeColor = Color.Red
        End If
    End Sub


End Class
