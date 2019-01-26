Module Module2048
    Public n As Byte = 4
    Public Jeu(n, n) As Short
    Public Score As Short, ScoreAnnuler As Short, ScoreMax As Short, ScoreMaxAnnuler As Short
    Public tabletem(n, n) As Short
    Public scoretem As Short
    Public scoreMaxTem As Integer
    Public JeuAnnuler(n, n) As Short
    Public PointGagne As Integer = 2048
    Public bloquer As Boolean
    Public comparer As Boolean


    Public Sub initialiser()
        ' mettre toutes les variables dans le tableau à zéro
        Dim i As Integer, j As Integer

        For i = 1 To n
            For j = 1 To n
                Jeu(i, j) = 0
            Next
        Next

        Score = 0
        'dans deux cases du jeu, on met une tuile aléatoire de valeur 2 ou 4
        TirerAleatoirement()
        TirerAleatoirement()

    End Sub
    Public Sub TirerAleatoirement()
        'choisir une case par la sélection aléatoire des indices de la table Jeu
        Dim random1 As New Random()
        Dim i As Byte, j As Byte

        i = random1.Next(1, 5)
        j = random1.Next(1, 5)

        'assurer la case choisie est vide, c'est-à-dire, si la case aléatoire n'est pas égale à 0, on resélectionnera une nouvelle case 
        While Jeu(i, j) <> 0
            i = random1.Next(1, 5)
            j = random1.Next(1, 5)
        End While

        'obtenir un paramètre entre 1 to 100 aléatoirement. 
        'si ce paramètre est inférieur à 90, la valeur de cette case aléatoire est égale à 2 , sinon la valeur est égale à 4.
        Dim rand As New Random()
        Dim proba As Integer
        proba = rand.Next(1, 101)
        If proba <= 90 Then
            Jeu(i, j) = 2
        Else
            Jeu(i, j) = 4
        End If

    End Sub
    Public Function tem()
        Dim i As Integer, j As Integer
        'Enregistrer la valeur du bloc et le score de chaque étape
        For i = 1 To n
            For j = 1 To n
                tabletem(i, j) = Jeu(i, j)
            Next
        Next
        scoretem = Score
        scoreMaxTem = ScoreMax
        Return scoretem
        Return scoreMaxTem
    End Function

    Public Sub SubComparer()
        'Les valeurs de la table temporaire et de la table de jeu déjà déplacée sont comparées une par une, et lorsqu'elles sont égales, on compte avec le paramètre k.
        Dim k As Integer
        k = 0
        For i = 1 To n
            For j = 1 To n
                If Jeu(i, j) = tabletem(i, j) Then
                    k = k + 1
                End If
            Next
        Next
        'Lorsque k = 16, cela signifie que les deux tables sont complètement égales, il n'y a pas de changement avant et après le déplacement, et le paramètre comparer est True.
        If k = 16 Then
            comparer = True
        Else
            comparer = False
        End If
    End Sub

    Public Function TableAnnuler()
        'Pour revenir à l'étape précédente, nous obtenons toutes les valeurs qui doivent apparaître dans l'interface du jeu à partir de la table temporaire.
        Dim i As Integer, j As Integer
        For i = 1 To n
            For j = 1 To n
                JeuAnnuler(i, j) = tabletem(i, j)
            Next
        Next
        ScoreAnnuler = scoretem
        ScoreMaxAnnuler = scoreMaxTem
        Return ScoreAnnuler
        Return ScoreMaxAnnuler

    End Function

    Public Function Annuler()
        'La valeur dans la table d'annulation est copiée dans la table de jeu afin d'afficher la valeur de l'étape précédente dans l'interface 
        'et revenir au dernier coup par le bouton Undo.
        For i = 1 To n
            For j = 1 To n
                Jeu(i, j) = JeuAnnuler(i, j)
            Next
        Next
        Score = ScoreAnnuler
        ScoreMax = ScoreMaxAnnuler
        Return Score
        Return ScoreMax

    End Function

    Public Function JeuGagner() As Boolean
        JeuGagner = False
        Dim i As Integer, j As Integer
        'Trouver s'il y a une valeur dans la table de jeu est égale à 2048.Si, le JeuGagner est correcte et on quitte le jugement. Sinon, on continue.
        For i = 1 To n
            For j = 1 To n
                If Jeu(i, j) = PointGagne Then
                    JeuGagner = True
                    Exit Function
                End If
            Next
        Next

    End Function

    Public Function JeuTerminer() As Boolean
        'Le jeu se termine lorsqu'aucune des trois conditions suivantes n'est vraie. Trois conditions sont indispensables.
        'Les trois conditions sont:
        '- chaque valeur de la table est non nulle
        '- Gauche et droite ne peuvent pas bouger
        '- Impossible de monter et descendre
        If Not peutcontinue() And Not peutcolonne() And Not peutligne() Then
            JeuTerminer = True
        Else
            JeuTerminer = False
        End If

        Return JeuTerminer
    End Function

    Public Function peutcontinue() As Boolean
        'Vérifiez que chaque valeur de la table est non nulle
        Dim peutdepalcer As Boolean, NbpasZero As Byte

        NbpasZero = 0
        For i = 1 To n
            For j = 1 To n
                If Jeu(i, j) <> 0 Then  'Lorsque la case n'est pas 0, compter dans le paramètre NbpasZero.
                    NbpasZero = NbpasZero + 1
                End If
            Next
        Next
        'Quand il y a une valeur de 0 dans la table, le jeu peut continuer. Lorsque les valeurs de 16 grilles sont non nulles, 
        'la première condition de fin du jeu est satisfaite. Si aucune direction ne peut bouger après, le jeu se terminera.
        If NbpasZero = 16 Then
            peutdepalcer = False
        Else
            peutdepalcer = True
        End If

        Return peutdepalcer
    End Function

    Public Function peutligne() As Boolean 'Déterminer si la gauche et la droite peuvent bouger
        Dim a As Boolean
        a = False
        For j = 1 To 4
            For i = 1 To 3
                'Quand il y a un nombre égal de valeurs adjacentes, cela signifie que le jeu peut encore bouger.Le jugement est correct, nous quittons la fonction.
                If Jeu(i, j) = Jeu(i + 1, j) Then
                    a = True
                    Return a
                    Exit Function
                End If
            Next
        Next

        Return a
    End Function

    Public Function peutcolonne() As Boolean  'Déterminez si vous pouvez monter et descendre. 
        Dim a As Boolean
        a = False
        For i = 1 To 4
            For j = 1 To 3
                'Quand il y a un nombre égal de valeurs adjacentes, cela signifie que le jeu peut encore bouger.Le jugement est correct, nous quittons la fonction.
                If Jeu(i, j) = Jeu(i, j + 1) Then
                    a = True
                    Return a
                    Exit Function
                End If
            Next
        Next

        Return a
    End Function
   
    Public Sub Deplacer(ByVal mode As Integer)
        Dim TableN() As Short
        Dim i As Integer, j As Integer, k As Integer, t As Integer
        Dim a As Integer, R As Integer, E As Integer, W As Integer
        'En contrôlant un nombre spécifique de paramètres, nous contrôlons un nombre spécifique de conditions pour atteindre l'algorithme 
        'de déplacement vers les différentes directions.
        'Utilisez le paramètre mode pour afficher 4 directions. Gauche 1, Droite 2, Haut 3, Bas 4.

        'étape 1 :Selon différentes directions, utilisez des paramètres différents.
        If mode < 3 Then
            If mode = 1 Then
                a = 1 : W = 0 : R = 1 : E = 4   'Gauche 1
            Else
                a = 4 : W = 5 : R = -1 : E = 1  'Droite 2
            End If

            'étape 2 : Retirer des valeurs non zéro dans jeu() et les enregistrer dans TableN() 
            For i = 1 To n
                ReDim TableN(n)
                k = 0
                For j = a To E Step R
                    If Jeu(i, j) <> 0 Then
                        k = k + 1
                        TableN(k) = Jeu(i, j)
                    End If
                Next

                'étape 3 : Lorsqu'on obtient nez au moins deux valeurs non nulles dans cette ligne ou colonne,Faire les mouvement et calculer des valeurs
                If k > 1 Then
                    For j = 1 To k - 1
                        If TableN(j) = TableN(j + 1) Then
                            TableN(j) = 2 * TableN(j)
                            TableN(j + 1) = 0
                            'compter le score et mise en jour le score maximal
                            Score = Score + TableN(j)
                            If ScoreMax < Score Then
                                ScoreMax = Score
                            Else
                                ScoreMax = ScoreMax
                            End If
                        End If
                    Next
                    'étape 4 : mettre les résultats dans le nouvel ordre
                    t = W
                    For j = 1 To k
                        If TableN(j) <> 0 Then
                            t = t + R
                            Jeu(i, t) = TableN(j)
                        End If
                    Next

                    For j = t + R To E Step R
                        Jeu(i, j) = 0
                    Next

                ElseIf k = 1 Then
                    'Pour les lignes ou colonnes avec une seule valeur différente de zéro, déplacez cette valeur vers la première position dans la direction.
                    Jeu(i, a) = TableN(k)
                    Jeu(i, a + R) = 0
                    Jeu(i, a + R + R) = 0
                    Jeu(i, a + R + R + R) = 0
                End If
            Next
        Else
            'étape 1 :Selon différentes directions, utilisez des paramètres différents.
            If mode = 3 Then
                a = 1 : W = 0 : R = 1 : E = 4   'Haut 3.
            Else
                a = 4 : W = 5 : R = -1 : E = 1  'Bas 4.
            End If
            'étape 2 : Retirer des valeurs non zéro dans jeu() et les enregistrer dans TableN() 
            For i = 1 To n
                ReDim TableN(n)
                k = 0
                For j = a To E Step R
                    If Jeu(j, i) <> 0 Then
                        k = k + 1
                        TableN(k) = Jeu(j, i)

                    End If
                Next
                'étape 3 : Lorsqu'on obtient nez au moins deux valeurs non nulles dans cette ligne ou colonne,Faire les mouvement et calculer des valeurs
                If k > 1 Then
                    For j = 1 To k - 1
                        If TableN(j) = TableN(j + 1) Then
                            TableN(j) = 2 * TableN(j)
                            TableN(j + 1) = 0
                            'compter le score et mise en jour le score maximal
                            Score = Score + TableN(j)
                            If ScoreMax < Score Then
                                ScoreMax = Score
                            Else
                                ScoreMax = ScoreMax
                            End If
                        End If
                    Next
                    'étape 4 : mettre les résultats dans le nouvel ordre
                    t = W
                    For j = 1 To k
                        If TableN(j) <> 0 Then
                            t = t + R
                            Jeu(t, i) = TableN(j)
                        End If
                    Next

                    For j = t + R To E Step R
                        Jeu(j, i) = 0
                    Next

                ElseIf k = 1 Then
                    'Pour les lignes ou colonnes avec une seule valeur différente de zéro, déplacez cette valeur vers la première position dans la direction.
                    Jeu(a, i) = TableN(k)
                    Jeu(a + R, i) = 0
                    Jeu(a + R + R, i) = 0
                    Jeu(a + R + R + R, i) = 0
                End If
            Next
        End If
    End Sub


End Module
