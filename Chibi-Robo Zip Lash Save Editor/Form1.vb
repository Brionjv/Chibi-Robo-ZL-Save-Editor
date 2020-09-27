Imports PackageIO
Public Class Form1
    Dim filepath As String
    Dim fdialog As New Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim open As New OpenFileDialog
        open.Title = "Open save C3_SAVEDATA_X"
        If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
            fdialog.Label1.Text = "Open C3_SAVEDATA_0, C3_SAVEDATA_1" & vbNewLine & "or C3_SAVEDATA_2" & vbNewLine & "Backup your save before use" & vbNewLine & "Chibi-Robo Zip Lash Save Editor"
            fdialog.ShowDialog()
        End If
        If ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
            fdialog.Label1.Text = "Ouvrir C3_SAVEDATA_0, C3_SAVEDATA_1" & vbNewLine & "ou C3_SAVEDATA_2" & vbNewLine & "Faites une copie de votre sauvegarde" & vbNewLine & "avant d'utiliser" & vbNewLine & "Chibi-Robo Zip Lash Save Editor"
            fdialog.ShowDialog()
        End If
        open.ShowDialog()
        filepath = open.FileName
        Readfile()
    End Sub
    Private Sub Readfile()
        Try
            Dim Reader As New PackageIO.Reader(filepath, PackageIO.Endian.Little)
            Reader.Position = &H2A5C
            NumericUpDown1.Value = Reader.ReadInt32
            Reader.Position = &H11E8
            NumericUpDown3.Value = Reader.ReadSingle
            Reader.Position = &H2A60
            NumericUpDown2.Value = Reader.ReadUInt16
            Reader.Position = &H424
            NumericUpDown4.Value = Reader.ReadInt8
            Reader.Position = &H428
            NumericUpDown5.Value = Reader.ReadInt8
            Reader.Position = &H2438
            NumericUpDown6.Value = Reader.ReadInt8
            Reader.Position = &H244C
            NumericUpDown7.Value = Reader.ReadInt8
            Reader.Position = &H2460
            NumericUpDown8.Value = Reader.ReadInt8
            Reader.Position = &H2474
            NumericUpDown9.Value = Reader.ReadInt8
            Reader.Position = &H1D80
            NumericUpDown10.Value = Reader.ReadInt8
            Reader.Position = &H1F60
            NumericUpDown11.Value = Reader.ReadInt8
            If ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
                If NumericUpDown4.Value = 0 And NumericUpDown5.Value = 0 Then
                    Label1.Text = "0 - 0"
                    Label5.Text = "En route pour la Terre"
                End If
                If NumericUpDown4.Value = 1 And NumericUpDown5.Value = 1 Then
                    Label1.Text = "1 - 1"
                    Label5.Text = "Bienvenue en Océanie"
                End If
                If NumericUpDown4.Value = 1 And NumericUpDown5.Value = 2 Then
                    Label1.Text = "1 - 2"
                    Label5.Text = "La mine mystérieuse"
                End If
                If NumericUpDown4.Value = 1 And NumericUpDown5.Value = 3 Then
                    Label1.Text = "1 - 3"
                    Label5.Text = "Chaud, chaud, le robot !"
                End If
                If NumericUpDown4.Value = 1 And NumericUpDown5.Value = 4 Then
                    Label1.Text = "1 - 4"
                    Label5.Text = "Plastimonstres en pagaille"
                End If
                If NumericUpDown4.Value = 1 And NumericUpDown5.Value = 5 Then
                    Label1.Text = "1 - 5"
                    Label5.Text = "Dans les cieux périlleux"
                End If
                If NumericUpDown4.Value = 1 And NumericUpDown5.Value = 6 Then
                    Label1.Text = "1 - 6"
                    Label5.Text = "Cavalcade au crépuscule"
                End If
                If NumericUpDown4.Value = 1 And NumericUpDown5.Value = 7 Then
                    Label1.Text = "1 - B"
                    Label5.Text = "Kangourobot, le boxeur sauteur"
                End If
                If NumericUpDown4.Value = 2 And NumericUpDown5.Value = 1 Then
                    Label1.Text = "2 - 1"
                    Label5.Text = "De l'ordre dans le chaos brûlant"
                End If
                If NumericUpDown4.Value = 2 And NumericUpDown5.Value = 2 Then
                    Label1.Text = "2 - 2"
                    Label5.Text = "Les rivières du désert"
                End If
                If NumericUpDown4.Value = 2 And NumericUpDown5.Value = 3 Then
                    Label1.Text = "2 - 3"
                    Label5.Text = "Aventure en skateboard"
                End If
                If NumericUpDown4.Value = 2 And NumericUpDown5.Value = 4 Then
                    Label1.Text = "2 - 4"
                    Label5.Text = "Et que ça saute"
                End If
                If NumericUpDown4.Value = 2 And NumericUpDown5.Value = 5 Then
                    Label1.Text = "2 - 5"
                    Label5.Text = "La voie ferrée des sables"
                End If
                If NumericUpDown4.Value = 2 And NumericUpDown5.Value = 6 Then
                    Label1.Text = "2 - 6"
                    Label5.Text = "Progression en ascension"
                End If
                If NumericUpDown4.Value = 2 And NumericUpDown5.Value = 7 Then
                    Label1.Text = "2 - B"
                    Label5.Text = "Cobrakhamon, le pharaon doré"
                End If
                If NumericUpDown4.Value = 3 And NumericUpDown5.Value = 1 Then
                    Label1.Text = "3 - 1"
                    Label5.Text = "Ennuis sous les tropiques"
                End If
                If NumericUpDown4.Value = 3 And NumericUpDown5.Value = 2 Then
                    Label1.Text = "3 - 2"
                    Label5.Text = "Surf sur les vagues"
                End If
                If NumericUpDown4.Value = 3 And NumericUpDown5.Value = 3 Then
                    Label1.Text = "3 - 3"
                    Label5.Text = "Randonnée spéléo glaciale"
                End If
                If NumericUpDown4.Value = 3 And NumericUpDown5.Value = 4 Then
                    Label1.Text = "3 - 4"
                    Label5.Text = "Exploration sous-marine"
                End If
                If NumericUpDown4.Value = 3 And NumericUpDown5.Value = 5 Then
                    Label1.Text = "3 - 5"
                    Label5.Text = "Coquillages et ricochets"
                End If
                If NumericUpDown4.Value = 3 And NumericUpDown5.Value = 6 Then
                    Label1.Text = "3 - 6"
                    Label5.Text = "Le mouvement des marées"
                End If
                If NumericUpDown4.Value = 3 And NumericUpDown5.Value = 7 Then
                    Label1.Text = "3 - B"
                    Label5.Text = "Léviartithan, le monstre abyssal"
                End If
                If NumericUpDown4.Value = 4 And NumericUpDown5.Value = 1 Then
                    Label1.Text = "4 - 1"
                    Label5.Text = "Sortie en forêt épineuse"
                End If
                If NumericUpDown4.Value = 4 And NumericUpDown5.Value = 2 Then
                    Label1.Text = "4 - 2"
                    Label5.Text = "À l'assaut de la forteresse"
                End If
                If NumericUpDown4.Value = 4 And NumericUpDown5.Value = 3 Then
                    Label1.Text = "4 - 3"
                    Label5.Text = "Balade nocturne en sous-bois"
                End If
                If NumericUpDown4.Value = 4 And NumericUpDown5.Value = 4 Then
                    Label1.Text = "4 - 4"
                    Label5.Text = "En ballons sous les étoiles"
                End If
                If NumericUpDown4.Value = 4 And NumericUpDown5.Value = 5 Then
                    Label1.Text = "4 - 5"
                    Label5.Text = "Les ruines des boulibombes"
                End If
                If NumericUpDown4.Value = 4 And NumericUpDown5.Value = 6 Then
                    Label1.Text = "4 - 6"
                    Label5.Text = "Swing entre les branches"
                End If
                If NumericUpDown4.Value = 4 And NumericUpDown5.Value = 7 Then
                    Label1.Text = "4 - B"
                    Label5.Text = "Crockinero, comte de la nuit"
                End If
                If NumericUpDown4.Value = 5 And NumericUpDown5.Value = 1 Then
                    Label1.Text = "5 - 1"
                    Label5.Text = "Révolution industrielle"
                End If
                If NumericUpDown4.Value = 5 And NumericUpDown5.Value = 2 Then
                    Label1.Text = "5 - 2"
                    Label5.Text = "Fuite de l'usine infernale"
                End If
                If NumericUpDown4.Value = 5 And NumericUpDown5.Value = 3 Then
                    Label1.Text = "5 - 3"
                    Label5.Text = "Périls à la chaîne"
                End If
                If NumericUpDown4.Value = 5 And NumericUpDown5.Value = 4 Then
                    Label1.Text = "5 - 4"
                    Label5.Text = "Le labyrinthe des pictoclefs"
                End If
                If NumericUpDown4.Value = 5 And NumericUpDown5.Value = 5 Then
                    Label1.Text = "5 - 5"
                    Label5.Text = "Odyssée à roulettes"
                End If
                If NumericUpDown4.Value = 5 And NumericUpDown5.Value = 6 Then
                    Label1.Text = "5 - 6"
                    Label5.Text = "Dédale des tapis roulants"
                End If
                If NumericUpDown4.Value = 5 And NumericUpDown5.Value = 7 Then
                    Label1.Text = "5 - B"
                    Label5.Text = "Brikolator, la tête de briques"
                End If
                If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 1 Then
                    Label1.Text = "6 - 1"
                    Label5.Text = "Expédition sur la banquise"
                End If
                If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 2 Then
                    Label1.Text = "6 - 2"
                    Label5.Text = "De l'ordre dans le chaos givré"
                End If
                If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 3 Then
                    Label1.Text = "6 - 3"
                    Label5.Text = "Glisse entre les glaces"
                End If
                If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 4 Then
                    Label1.Text = "6 - 4"
                    Label5.Text = "Riposte des plastimonstres"
                End If
                If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 5 Then
                    Label1.Text = "6 - 5"
                    Label5.Text = "Grotte gla-gla-glaciale"
                End If
                If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 6 Then
                    Label1.Text = "6 - 6"
                    Label5.Text = "Alliance du froid et du feu"
                End If
                If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 7 Then
                    Label1.Text = "6 - B"
                    Label5.Text = "Vaisseau amiral, l'ultime défi"
                End If
                If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 8 Then
                    Label1.Text = "6 - F"
                    Label5.Text = "Chibi-Robo contre Méga-Gyoros"
                End If
                If NumericUpDown4.Value = 7 And NumericUpDown5.Value = 1 Then
                    Label1.Text = "7 - 1"
                    Label5.Text = "Visite au château de karakuri"
                End If
                If NumericUpDown4.Value = 7 And NumericUpDown5.Value = 2 Then
                    Label1.Text = "7 - 2"
                    Label5.Text = "Rebonds entre les bonsaïs"
                End If
                If NumericUpDown4.Value = 7 And NumericUpDown5.Value = 3 Then
                    Label1.Text = "7 - 3"
                    Label5.Text = "La maison des plafonds mobiles"
                End If
                If NumericUpDown4.Value = 7 And NumericUpDown5.Value = 4 Then
                    Label1.Text = "7 - 4"
                    Label5.Text = "Ascension du Magmayama"
                End If
                If NumericUpDown4.Value = 7 And NumericUpDown5.Value = 5 Then
                    Label1.Text = "7 - 5"
                    Label5.Text = "Léviartithan 2.0, la bête d'Asie"
                End If
                If NumericUpDown4.Value = 7 And NumericUpDown5.Value = 6 Then
                    Label1.Text = "7 - 6"
                    Label5.Text = "Brikolator 2.0, la nouvelle tête"
                End If
            End If
            If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
                If NumericUpDown4.Value = 0 And NumericUpDown5.Value = 0 Then
                    Label1.Text = "0 - 0"
                    Label5.Text = "Shipping Out From the Station"
                End If
                If NumericUpDown4.Value = 1 And NumericUpDown5.Value = 1 Then
                    Label1.Text = "1 - 1"
                    Label5.Text = "Welcome to Oceania"
                End If
                If NumericUpDown4.Value = 1 And NumericUpDown5.Value = 2 Then
                    Label1.Text = "1 - 2"
                    Label5.Text = "The Mysterious Mine"
                End If
                If NumericUpDown4.Value = 1 And NumericUpDown5.Value = 3 Then
                    Label1.Text = "1 - 3"
                    Label5.Text = "Feeling the Burn"
                End If
                If NumericUpDown4.Value = 1 And NumericUpDown5.Value = 4 Then
                    Label1.Text = "1 - 4"
                    Label5.Text = "Invasion of the Plastic Pests"
                End If
                If NumericUpDown4.Value = 1 And NumericUpDown5.Value = 5 Then
                    Label1.Text = "1 - 5"
                    Label5.Text = "Treacherous Skies"
                End If
                If NumericUpDown4.Value = 1 And NumericUpDown5.Value = 6 Then
                    Label1.Text = "1 - 6"
                    Label5.Text = "A Terror Lurks at Twilight"
                End If
                If NumericUpDown4.Value = 1 And NumericUpDown5.Value = 7 Then
                    Label1.Text = "1 - B"
                    Label5.Text = "Robo-Roo, the Bouncing Batter"
                End If
                If NumericUpDown4.Value = 2 And NumericUpDown5.Value = 1 Then
                    Label1.Text = "2 - 1"
                    Label5.Text = "Finding Order in the Fiery Chaos"
                End If
                If NumericUpDown4.Value = 2 And NumericUpDown5.Value = 2 Then
                    Label1.Text = "2 - 2"
                    Label5.Text = "Desert Daze"
                End If
                If NumericUpDown4.Value = 2 And NumericUpDown5.Value = 3 Then
                    Label1.Text = "2 - 3"
                    Label5.Text = "The Adventures of Skater-Bot"
                End If
                If NumericUpDown4.Value = 2 And NumericUpDown5.Value = 4 Then
                    Label1.Text = "2 - 4"
                    Label5.Text = "Bring On the Bomb Squad"
                End If
                If NumericUpDown4.Value = 2 And NumericUpDown5.Value = 5 Then
                    Label1.Text = "2 - 5"
                    Label5.Text = "Riding the Rails"
                End If
                If NumericUpDown4.Value = 2 And NumericUpDown5.Value = 6 Then
                    Label1.Text = "2 - 6"
                    Label5.Text = "Onward and Upward"
                End If
                If NumericUpDown4.Value = 2 And NumericUpDown5.Value = 7 Then
                    Label1.Text = "2 - B"
                    Label5.Text = "King Kabombra, the Golden Legend"
                End If
                If NumericUpDown4.Value = 3 And NumericUpDown5.Value = 1 Then
                    Label1.Text = "3 - 1"
                    Label5.Text = "Trouble in Paradise"
                End If
                If NumericUpDown4.Value = 3 And NumericUpDown5.Value = 2 Then
                    Label1.Text = "3 - 2"
                    Label5.Text = "Chibi-Robo Hits the Waves"
                End If
                If NumericUpDown4.Value = 3 And NumericUpDown5.Value = 3 Then
                    Label1.Text = "3 - 3"
                    Label5.Text = "Keeping Cool in the Caverns"
                End If
                If NumericUpDown4.Value = 3 And NumericUpDown5.Value = 4 Then
                    Label1.Text = "3 - 4"
                    Label5.Text = "All Aboard the Chibi-Sub"
                End If
                If NumericUpDown4.Value = 3 And NumericUpDown5.Value = 5 Then
                    Label1.Text = "3 - 5"
                    Label5.Text = "Shellfish Shore"
                End If
                If NumericUpDown4.Value = 3 And NumericUpDown5.Value = 6 Then
                    Label1.Text = "3 - 6"
                    Label5.Text = "Tilting with the Tides"
                End If
                If NumericUpDown4.Value = 3 And NumericUpDown5.Value = 7 Then
                    Label1.Text = "3 - B"
                    Label5.Text = "Old Ironhide, the Terror of the Deep"
                End If
                If NumericUpDown4.Value = 4 And NumericUpDown5.Value = 1 Then
                    Label1.Text = "4 - 1"
                    Label5.Text = "Bramblewood Forest"
                End If
                If NumericUpDown4.Value = 4 And NumericUpDown5.Value = 2 Then
                    Label1.Text = "4 - 2"
                    Label5.Text = "Storm the Castle, Chibi-Robo!"
                End If
                If NumericUpDown4.Value = 4 And NumericUpDown5.Value = 3 Then
                    Label1.Text = "4 - 3"
                    Label5.Text = "Twilight among the Trees"
                End If
                If NumericUpDown4.Value = 4 And NumericUpDown5.Value = 4 Then
                    Label1.Text = "4 - 4"
                    Label5.Text = "A Menacing Midnight Flight"
                End If
                If NumericUpDown4.Value = 4 And NumericUpDown5.Value = 5 Then
                    Label1.Text = "4 - 5"
                    Label5.Text = "The Bomball Ruins"
                End If
                If NumericUpDown4.Value = 4 And NumericUpDown5.Value = 6 Then
                    Label1.Text = "4 - 6"
                    Label5.Text = "Sylvan Swing"
                End If
                If NumericUpDown4.Value = 4 And NumericUpDown5.Value = 7 Then
                    Label1.Text = "4 - B"
                    Label5.Text = "Count Umbrahla, the Moonlit Menace"
                End If
                If NumericUpDown4.Value = 5 And NumericUpDown5.Value = 1 Then
                    Label1.Text = "5 - 1"
                    Label5.Text = "Industrial Revolution"
                End If
                If NumericUpDown4.Value = 5 And NumericUpDown5.Value = 2 Then
                    Label1.Text = "5 - 2"
                    Label5.Text = "Escape from the Frantic Factory"
                End If
                If NumericUpDown4.Value = 5 And NumericUpDown5.Value = 3 Then
                    Label1.Text = "5 - 3"
                    Label5.Text = "Adventure on the Assembly Line"
                End If
                If NumericUpDown4.Value = 5 And NumericUpDown5.Value = 4 Then
                    Label1.Text = "5 - 4"
                    Label5.Text = "Hunting for Pictokeys"
                End If
                If NumericUpDown4.Value = 5 And NumericUpDown5.Value = 5 Then
                    Label1.Text = "5 - 5"
                    Label5.Text = "Breakneck Boarding"
                End If
                If NumericUpDown4.Value = 5 And NumericUpDown5.Value = 6 Then
                    Label1.Text = "5 - 6"
                    Label5.Text = "Chaotic Conveyor Belts"
                End If
                If NumericUpDown4.Value = 5 And NumericUpDown5.Value = 7 Then
                    Label1.Text = "5 - B"
                    Label5.Text = "Construktor, the Block Head"
                End If
                If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 1 Then
                    Label1.Text = "6 - 1"
                    Label5.Text = "An Icy Expedition"
                End If
                If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 2 Then
                    Label1.Text = "6 - 2"
                    Label5.Text = "Finding Order in the Icy Chaos"
                End If
                If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 3 Then
                    Label1.Text = "6 - 3"
                    Label5.Text = "Boarding in a Winter Wonderland"
                End If
                If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 4 Then
                    Label1.Text = "6 - 4"
                    Label5.Text = "Superheated Showdown"
                End If
                If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 5 Then
                    Label1.Text = "6 - 5"
                    Label5.Text = "Glacial Grotto"
                End If
                If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 6 Then
                    Label1.Text = "6 - 6"
                    Label5.Text = "The Harmony of Frost and Fire"
                End If
                If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 7 Then
                    Label1.Text = "6 - B"
                    Label5.Text = "Mothership Mayhem"
                End If
                If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 8 Then
                    Label1.Text = "6 - F"
                    Label5.Text = "Chibi-Robo vs. the Mega-Mech Menace"
                End If
                If NumericUpDown4.Value = 7 And NumericUpDown5.Value = 1 Then
                    Label1.Text = "7 - 1"
                    Label5.Text = "Karakuri Castle"
                End If
                If NumericUpDown4.Value = 7 And NumericUpDown5.Value = 2 Then
                    Label1.Text = "7 - 2"
                    Label5.Text = "The Bonsai Bounce"
                End If
                If NumericUpDown4.Value = 7 And NumericUpDown5.Value = 3 Then
                    Label1.Text = "7 - 3"
                    Label5.Text = "Hanging Out in an Elegant Estate"
                End If
                If NumericUpDown4.Value = 7 And NumericUpDown5.Value = 4 Then
                    Label1.Text = "7 - 4"
                    Label5.Text = "Vexing Volcanic Climb"
                End If
                If NumericUpDown4.Value = 7 And NumericUpDown5.Value = 5 Then
                    Label1.Text = "7 - 5"
                    Label5.Text = "Ironhide Mk. ||, the Beast in Asia's Abyss"
                End If
                If NumericUpDown4.Value = 7 And NumericUpDown5.Value = 6 Then
                    Label1.Text = "7 - 6"
                    Label5.Text = "Construktor Mk. ||, the Remodeled Rival"
                End If
            End If
        Catch ex As Exception
            If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
                fdialog.Label1.Text = "C3_SAVEDATA_0, C3_SAVEDATA_1 or" & vbNewLine & "C3_SAVEDATA_2 not load successfully" & vbNewLine & "Save file is probably corrupted or" & vbNewLine & "not a Chibi-Robo Zip Lash save"
                fdialog.ShowDialog()
            End If
            If ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
                fdialog.Label1.Text = "L'ouverture de C3_SAVEDATA_0, C3_SAVEDATA_1" & vbNewLine & "ou C3_SAVEDATA_2 a échoué" & vbNewLine & "La sauvegarde est probablement corrompue" & vbNewLine & "ou n'est pas une sauvegarde de Chibi-Robo Zip Lash"
                fdialog.ShowDialog()
            End If
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedItem = ComboBox1.Items.Item(0)
        ComboBox3.SelectedItem = ComboBox3.Items.Item(0)
        ComboBox1.Text = My.Settings.Langue
    End Sub
    Private Sub Form1_FormClosing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        My.Settings.Langue = ComboBox1.Text
        My.Settings.Save()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
            Button1.Text = "Open"
            Button2.Text = "Save"
            TabPage1.Text = "Main"
            TabPage3.Text = "Worlds Edit"
            Label7.Text = "Inventory"
            Label7.Location = New Point(39, 10)
            CheckBox1.Text = "Access to the floor unlocked"
            CheckBox2.Text = "Unlock all figurines info."
            CheckBox3.Text = "Unlock all figurines"
            CheckBox4.Text = "Unlock level 1"
            CheckBox5.Text = "Unlock all levels"
            CheckBox6.Text = "Delete all levels"
            CheckBox7.Text = "All levels with all Chibi-tot and coins"
            If NumericUpDown4.Value = 0 And NumericUpDown5.Value = 0 Then
                Label1.Text = "0 - 0"
                Label5.Text = "Shipping Out From the Station"
            End If
            If NumericUpDown4.Value = 1 And NumericUpDown5.Value = 1 Then
                Label1.Text = "1 - 1"
                Label5.Text = "Welcome to Oceania"
            End If
            If NumericUpDown4.Value = 1 And NumericUpDown5.Value = 2 Then
                Label1.Text = "1 - 2"
                Label5.Text = "The Mysterious Mine"
            End If
            If NumericUpDown4.Value = 1 And NumericUpDown5.Value = 3 Then
                Label1.Text = "1 - 3"
                Label5.Text = "Feeling the Burn"
            End If
            If NumericUpDown4.Value = 1 And NumericUpDown5.Value = 4 Then
                Label1.Text = "1 - 4"
                Label5.Text = "Invasion of the Plastic Pests"
            End If
            If NumericUpDown4.Value = 1 And NumericUpDown5.Value = 5 Then
                Label1.Text = "1 - 5"
                Label5.Text = "Treacherous Skies"
            End If
            If NumericUpDown4.Value = 1 And NumericUpDown5.Value = 6 Then
                Label1.Text = "1 - 6"
                Label5.Text = "A Terror Lurks at Twilight"
            End If
            If NumericUpDown4.Value = 1 And NumericUpDown5.Value = 7 Then
                Label1.Text = "1 - B"
                Label5.Text = "Robo-Roo, the Bouncing Batter"
            End If
            If NumericUpDown4.Value = 2 And NumericUpDown5.Value = 1 Then
                Label1.Text = "2 - 1"
                Label5.Text = "Finding Order in the Fiery Chaos"
            End If
            If NumericUpDown4.Value = 2 And NumericUpDown5.Value = 2 Then
                Label1.Text = "2 - 2"
                Label5.Text = "Desert Daze"
            End If
            If NumericUpDown4.Value = 2 And NumericUpDown5.Value = 3 Then
                Label1.Text = "2 - 3"
                Label5.Text = "The Adventures of Skater-Bot"
            End If
            If NumericUpDown4.Value = 2 And NumericUpDown5.Value = 4 Then
                Label1.Text = "2 - 4"
                Label5.Text = "Bring On the Bomb Squad"
            End If
            If NumericUpDown4.Value = 2 And NumericUpDown5.Value = 5 Then
                Label1.Text = "2 - 5"
                Label5.Text = "Riding the Rails"
            End If
            If NumericUpDown4.Value = 2 And NumericUpDown5.Value = 6 Then
                Label1.Text = "2 - 6"
                Label5.Text = "Onward and Upward"
            End If
            If NumericUpDown4.Value = 2 And NumericUpDown5.Value = 7 Then
                Label1.Text = "2 - B"
                Label5.Text = "King Kabombra, the Golden Legend"
            End If
            If NumericUpDown4.Value = 3 And NumericUpDown5.Value = 1 Then
                Label1.Text = "3 - 1"
                Label5.Text = "Trouble in Paradise"
            End If
            If NumericUpDown4.Value = 3 And NumericUpDown5.Value = 2 Then
                Label1.Text = "3 - 2"
                Label5.Text = "Chibi-Robo Hits the Waves"
            End If
            If NumericUpDown4.Value = 3 And NumericUpDown5.Value = 3 Then
                Label1.Text = "3 - 3"
                Label5.Text = "Keeping Cool in the Caverns"
            End If
            If NumericUpDown4.Value = 3 And NumericUpDown5.Value = 4 Then
                Label1.Text = "3 - 4"
                Label5.Text = "All Aboard the Chibi-Sub"
            End If
            If NumericUpDown4.Value = 3 And NumericUpDown5.Value = 5 Then
                Label1.Text = "3 - 5"
                Label5.Text = "Shellfish Shore"
            End If
            If NumericUpDown4.Value = 3 And NumericUpDown5.Value = 6 Then
                Label1.Text = "3 - 6"
                Label5.Text = "Tilting with the Tides"
            End If
            If NumericUpDown4.Value = 3 And NumericUpDown5.Value = 7 Then
                Label1.Text = "3 - B"
                Label5.Text = "Old Ironhide, the Terror of the Deep"
            End If
            If NumericUpDown4.Value = 4 And NumericUpDown5.Value = 1 Then
                Label1.Text = "4 - 1"
                Label5.Text = "Bramblewood Forest"
            End If
            If NumericUpDown4.Value = 4 And NumericUpDown5.Value = 2 Then
                Label1.Text = "4 - 2"
                Label5.Text = "Storm the Castle, Chibi-Robo!"
            End If
            If NumericUpDown4.Value = 4 And NumericUpDown5.Value = 3 Then
                Label1.Text = "4 - 3"
                Label5.Text = "Twilight among the Trees"
            End If
            If NumericUpDown4.Value = 4 And NumericUpDown5.Value = 4 Then
                Label1.Text = "4 - 4"
                Label5.Text = "A Menacing Midnight Flight"
            End If
            If NumericUpDown4.Value = 4 And NumericUpDown5.Value = 5 Then
                Label1.Text = "4 - 5"
                Label5.Text = "The Bomball Ruins"
            End If
            If NumericUpDown4.Value = 4 And NumericUpDown5.Value = 6 Then
                Label1.Text = "4 - 6"
                Label5.Text = "Sylvan Swing"
            End If
            If NumericUpDown4.Value = 4 And NumericUpDown5.Value = 7 Then
                Label1.Text = "4 - B"
                Label5.Text = "Count Umbrahla, the Moonlit Menace"
            End If
            If NumericUpDown4.Value = 5 And NumericUpDown5.Value = 1 Then
                Label1.Text = "5 - 1"
                Label5.Text = "Industrial Revolution"
            End If
            If NumericUpDown4.Value = 5 And NumericUpDown5.Value = 2 Then
                Label1.Text = "5 - 2"
                Label5.Text = "Escape from the Frantic Factory"
            End If
            If NumericUpDown4.Value = 5 And NumericUpDown5.Value = 3 Then
                Label1.Text = "5 - 3"
                Label5.Text = "Adventure on the Assembly Line"
            End If
            If NumericUpDown4.Value = 5 And NumericUpDown5.Value = 4 Then
                Label1.Text = "5 - 4"
                Label5.Text = "Hunting for Pictokeys"
            End If
            If NumericUpDown4.Value = 5 And NumericUpDown5.Value = 5 Then
                Label1.Text = "5 - 5"
                Label5.Text = "Breakneck Boarding"
            End If
            If NumericUpDown4.Value = 5 And NumericUpDown5.Value = 6 Then
                Label1.Text = "5 - 6"
                Label5.Text = "Chaotic Conveyor Belts"
            End If
            If NumericUpDown4.Value = 5 And NumericUpDown5.Value = 7 Then
                Label1.Text = "5 - B"
                Label5.Text = "Construktor, the Block Head"
            End If
            If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 1 Then
                Label1.Text = "6 - 1"
                Label5.Text = "An Icy Expedition"
            End If
            If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 2 Then
                Label1.Text = "6 - 2"
                Label5.Text = "Finding Order in the Icy Chaos"
            End If
            If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 3 Then
                Label1.Text = "6 - 3"
                Label5.Text = "Boarding in a Winter Wonderland"
            End If
            If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 4 Then
                Label1.Text = "6 - 4"
                Label5.Text = "Superheated Showdown"
            End If
            If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 5 Then
                Label1.Text = "6 - 5"
                Label5.Text = "Glacial Grotto"
            End If
            If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 6 Then
                Label1.Text = "6 - 6"
                Label5.Text = "The Harmony of Frost and Fire"
            End If
            If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 7 Then
                Label1.Text = "6 - B"
                Label5.Text = "Mothership Mayhem"
            End If
            If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 8 Then
                Label1.Text = "6 - F"
                Label5.Text = "Chibi-Robo vs. the Mega-Mech Menace"
            End If
            If NumericUpDown4.Value = 7 And NumericUpDown5.Value = 1 Then
                Label1.Text = "7 - 1"
                Label5.Text = "Karakuri Castle"
            End If
            If NumericUpDown4.Value = 7 And NumericUpDown5.Value = 2 Then
                Label1.Text = "7 - 2"
                Label5.Text = "The Bonsai Bounce"
            End If
            If NumericUpDown4.Value = 7 And NumericUpDown5.Value = 3 Then
                Label1.Text = "7 - 3"
                Label5.Text = "Hanging Out in an Elegant Estate"
            End If
            If NumericUpDown4.Value = 7 And NumericUpDown5.Value = 4 Then
                Label1.Text = "7 - 4"
                Label5.Text = "Vexing Volcanic Climb"
            End If
            If NumericUpDown4.Value = 7 And NumericUpDown5.Value = 5 Then
                Label1.Text = "7 - 5"
                Label5.Text = "Ironhide Mk. ||, the Beast in Asia's Abyss"
            End If
            If NumericUpDown4.Value = 7 And NumericUpDown5.Value = 6 Then
                Label1.Text = "7 - 6"
                Label5.Text = "Construktor Mk. ||, the Remodeled Rival"
            End If
            ComboBox3.Items.Item(0) = "World 1"
            ComboBox3.Items.Item(1) = "World 2"
            ComboBox3.Items.Item(2) = "World 3"
            ComboBox3.Items.Item(3) = "World 4"
            ComboBox3.Items.Item(4) = "World 5"
            ComboBox3.Items.Item(5) = "World 6"
            ComboBox3.Items.Item(6) = "World 7"
        End If
        If ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
            Button1.Text = "Ouvrir"
            Button2.Text = "Enregistrer"
            TabPage1.Text = "Principal"
            TabPage3.Text = "Edition Mondes"
            Label7.Text = "Inventaire"
            Label7.Location = New Point(37, 10)
            CheckBox1.Text = "Débloquer l'accès à l'étage"
            CheckBox2.Text = "Débloquer toutes les infos des figurines"
            CheckBox3.Text = "Débloquer toutes les figurines"
            CheckBox4.Text = "Débloquer Niveau 1"
            CheckBox5.Text = "Débloquer les niveaux"
            CheckBox6.Text = "Supprimer les niveaux"
            CheckBox7.Text = "Débloquer les niveaux avec Chibi-tot et pièces"
            If NumericUpDown4.Value = 0 And NumericUpDown5.Value = 0 Then
                Label1.Text = "0 - 0"
                Label5.Text = "En route pour la Terre"
            End If
            If NumericUpDown4.Value = 1 And NumericUpDown5.Value = 1 Then
                Label1.Text = "1 - 1"
                Label5.Text = "Bienvenue en Océanie"
            End If
            If NumericUpDown4.Value = 1 And NumericUpDown5.Value = 2 Then
                Label1.Text = "1 - 2"
                Label5.Text = "La mine mystérieuse"
            End If
            If NumericUpDown4.Value = 1 And NumericUpDown5.Value = 3 Then
                Label1.Text = "1 - 3"
                Label5.Text = "Chaud, chaud, le robot !"
            End If
            If NumericUpDown4.Value = 1 And NumericUpDown5.Value = 4 Then
                Label1.Text = "1 - 4"
                Label5.Text = "Plastimonstres en pagaille"
            End If
            If NumericUpDown4.Value = 1 And NumericUpDown5.Value = 5 Then
                Label1.Text = "1 - 5"
                Label5.Text = "Dans les cieux périlleux"
            End If
            If NumericUpDown4.Value = 1 And NumericUpDown5.Value = 6 Then
                Label1.Text = "1 - 6"
                Label5.Text = "Cavalcade au crépuscule"
            End If
            If NumericUpDown4.Value = 1 And NumericUpDown5.Value = 7 Then
                Label1.Text = "1 - B"
                Label5.Text = "Kangourobot, le boxeur sauteur"
            End If
            If NumericUpDown4.Value = 2 And NumericUpDown5.Value = 1 Then
                Label1.Text = "2 - 1"
                Label5.Text = "De l'ordre dans le chaos brûlant"
            End If
            If NumericUpDown4.Value = 2 And NumericUpDown5.Value = 2 Then
                Label1.Text = "2 - 2"
                Label5.Text = "Les rivières du désert"
            End If
            If NumericUpDown4.Value = 2 And NumericUpDown5.Value = 3 Then
                Label1.Text = "2 - 3"
                Label5.Text = "Aventure en skateboard"
            End If
            If NumericUpDown4.Value = 2 And NumericUpDown5.Value = 4 Then
                Label1.Text = "2 - 4"
                Label5.Text = "Et que ça saute"
            End If
            If NumericUpDown4.Value = 2 And NumericUpDown5.Value = 5 Then
                Label1.Text = "2 - 5"
                Label5.Text = "La voie ferrée des sables"
            End If
            If NumericUpDown4.Value = 2 And NumericUpDown5.Value = 6 Then
                Label1.Text = "2 - 6"
                Label5.Text = "Progression en ascension"
            End If
            If NumericUpDown4.Value = 2 And NumericUpDown5.Value = 7 Then
                Label1.Text = "2 - B"
                Label5.Text = "Cobrakhamon, le pharaon doré"
            End If
            If NumericUpDown4.Value = 3 And NumericUpDown5.Value = 1 Then
                Label1.Text = "3 - 1"
                Label5.Text = "Ennuis sous les tropiques"
            End If
            If NumericUpDown4.Value = 3 And NumericUpDown5.Value = 2 Then
                Label1.Text = "3 - 2"
                Label5.Text = "Surf sur les vagues"
            End If
            If NumericUpDown4.Value = 3 And NumericUpDown5.Value = 3 Then
                Label1.Text = "3 - 3"
                Label5.Text = "Randonnée spéléo glaciale"
            End If
            If NumericUpDown4.Value = 3 And NumericUpDown5.Value = 4 Then
                Label1.Text = "3 - 4"
                Label5.Text = "Exploration sous-marine"
            End If
            If NumericUpDown4.Value = 3 And NumericUpDown5.Value = 5 Then
                Label1.Text = "3 - 5"
                Label5.Text = "Coquillages et ricochets"
            End If
            If NumericUpDown4.Value = 3 And NumericUpDown5.Value = 6 Then
                Label1.Text = "3 - 6"
                Label5.Text = "Le mouvement des marées"
            End If
            If NumericUpDown4.Value = 3 And NumericUpDown5.Value = 7 Then
                Label1.Text = "3 - B"
                Label5.Text = "Léviartithan, le monstre abyssal"
            End If
            If NumericUpDown4.Value = 4 And NumericUpDown5.Value = 1 Then
                Label1.Text = "4 - 1"
                Label5.Text = "Sortie en forêt épineuse"
            End If
            If NumericUpDown4.Value = 4 And NumericUpDown5.Value = 2 Then
                Label1.Text = "4 - 2"
                Label5.Text = "À l'assaut de la forteresse"
            End If
            If NumericUpDown4.Value = 4 And NumericUpDown5.Value = 3 Then
                Label1.Text = "4 - 3"
                Label5.Text = "Balade nocturne en sous-bois"
            End If
            If NumericUpDown4.Value = 4 And NumericUpDown5.Value = 4 Then
                Label1.Text = "4 - 4"
                Label5.Text = "En ballons sous les étoiles"
            End If
            If NumericUpDown4.Value = 4 And NumericUpDown5.Value = 5 Then
                Label1.Text = "4 - 5"
                Label5.Text = "Les ruines des boulibombes"
            End If
            If NumericUpDown4.Value = 4 And NumericUpDown5.Value = 6 Then
                Label1.Text = "4 - 6"
                Label5.Text = "Swing entre les branches"
            End If
            If NumericUpDown4.Value = 4 And NumericUpDown5.Value = 7 Then
                Label1.Text = "4 - B"
                Label5.Text = "Crockinero, comte de la nuit"
            End If
            If NumericUpDown4.Value = 5 And NumericUpDown5.Value = 1 Then
                Label1.Text = "5 - 1"
                Label5.Text = "Révolution industrielle"
            End If
            If NumericUpDown4.Value = 5 And NumericUpDown5.Value = 2 Then
                Label1.Text = "5 - 2"
                Label5.Text = "Fuite de l'usine infernale"
            End If
            If NumericUpDown4.Value = 5 And NumericUpDown5.Value = 3 Then
                Label1.Text = "5 - 3"
                Label5.Text = "Périls à la chaîne"
            End If
            If NumericUpDown4.Value = 5 And NumericUpDown5.Value = 4 Then
                Label1.Text = "5 - 4"
                Label5.Text = "Le labyrinthe des pictoclefs"
            End If
            If NumericUpDown4.Value = 5 And NumericUpDown5.Value = 5 Then
                Label1.Text = "5 - 5"
                Label5.Text = "Odyssée à roulettes"
            End If
            If NumericUpDown4.Value = 5 And NumericUpDown5.Value = 6 Then
                Label1.Text = "5 - 6"
                Label5.Text = "Dédale des tapis roulants"
            End If
            If NumericUpDown4.Value = 5 And NumericUpDown5.Value = 7 Then
                Label1.Text = "5 - B"
                Label5.Text = "Brikolator, la tête de briques"
            End If
            If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 1 Then
                Label1.Text = "6 - 1"
                Label5.Text = "Expédition sur la banquise"
            End If
            If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 2 Then
                Label1.Text = "6 - 2"
                Label5.Text = "De l'ordre dans le chaos givré"
            End If
            If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 3 Then
                Label1.Text = "6 - 3"
                Label5.Text = "Glisse entre les glaces"
            End If
            If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 4 Then
                Label1.Text = "6 - 4"
                Label5.Text = "Riposte des plastimonstres"
            End If
            If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 5 Then
                Label1.Text = "6 - 5"
                Label5.Text = "Grotte gla-gla-glaciale"
            End If
            If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 6 Then
                Label1.Text = "6 - 6"
                Label5.Text = "Alliance du froid et du feu"
            End If
            If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 7 Then
                Label1.Text = "6 - B"
                Label5.Text = "Vaisseau amiral, l'ultime défi"
            End If
            If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 8 Then
                Label1.Text = "6 - F"
                Label5.Text = "Chibi-Robo contre Méga-Gyoros"
            End If
            If NumericUpDown4.Value = 7 And NumericUpDown5.Value = 1 Then
                Label1.Text = "7 - 1"
                Label5.Text = "Visite au château de karakuri"
            End If
            If NumericUpDown4.Value = 7 And NumericUpDown5.Value = 2 Then
                Label1.Text = "7 - 2"
                Label5.Text = "Rebonds entre les bonsaïs"
            End If
            If NumericUpDown4.Value = 7 And NumericUpDown5.Value = 3 Then
                Label1.Text = "7 - 3"
                Label5.Text = "La maison des plafonds mobiles"
            End If
            If NumericUpDown4.Value = 7 And NumericUpDown5.Value = 4 Then
                Label1.Text = "7 - 4"
                Label5.Text = "Ascension du Magmayama"
            End If
            If NumericUpDown4.Value = 7 And NumericUpDown5.Value = 5 Then
                Label1.Text = "7 - 5"
                Label5.Text = "Léviartithan 2.0, la bête d'Asie"
            End If
            If NumericUpDown4.Value = 7 And NumericUpDown5.Value = 6 Then
                Label1.Text = "7 - 6"
                Label5.Text = "Brikolator 2.0, la nouvelle tête"
            End If
            ComboBox3.Items.Item(0) = "Monde 1"
            ComboBox3.Items.Item(1) = "Monde 2"
            ComboBox3.Items.Item(2) = "Monde 3"
            ComboBox3.Items.Item(3) = "Monde 4"
            ComboBox3.Items.Item(4) = "Monde 5"
            ComboBox3.Items.Item(5) = "Monde 6"
            ComboBox3.Items.Item(6) = "Monde 7"
        End If
    End Sub

    Private Sub NumericUpDown4_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown4.ValueChanged
        If ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
            If NumericUpDown4.Value = 0 And NumericUpDown5.Value = 0 Then
                Label1.Text = "0 - 0"
                Label5.Text = "En route pour la Terre"
            End If
            If NumericUpDown4.Value = 1 And NumericUpDown5.Value = 1 Then
                Label1.Text = "1 - 1"
                Label5.Text = "Bienvenue en Océanie"
            End If
            If NumericUpDown4.Value = 1 And NumericUpDown5.Value = 2 Then
                Label1.Text = "1 - 2"
                Label5.Text = "La mine mystérieuse"
            End If
            If NumericUpDown4.Value = 1 And NumericUpDown5.Value = 3 Then
                Label1.Text = "1 - 3"
                Label5.Text = "Chaud, chaud, le robot !"
            End If
            If NumericUpDown4.Value = 1 And NumericUpDown5.Value = 4 Then
                Label1.Text = "1 - 4"
                Label5.Text = "Plastimonstres en pagaille"
            End If
            If NumericUpDown4.Value = 1 And NumericUpDown5.Value = 5 Then
                Label1.Text = "1 - 5"
                Label5.Text = "Dans les cieux périlleux"
            End If
            If NumericUpDown4.Value = 1 And NumericUpDown5.Value = 6 Then
                Label1.Text = "1 - 6"
                Label5.Text = "Cavalcade au crépuscule"
            End If
            If NumericUpDown4.Value = 1 And NumericUpDown5.Value = 7 Then
                Label1.Text = "1 - B"
                Label5.Text = "Kangourobot, le boxeur sauteur"
            End If
            If NumericUpDown4.Value = 2 And NumericUpDown5.Value = 1 Then
                Label1.Text = "2 - 1"
                Label5.Text = "De l'ordre dans le chaos brûlant"
            End If
            If NumericUpDown4.Value = 2 And NumericUpDown5.Value = 2 Then
                Label1.Text = "2 - 2"
                Label5.Text = "Les rivières du désert"
            End If
            If NumericUpDown4.Value = 2 And NumericUpDown5.Value = 3 Then
                Label1.Text = "2 - 3"
                Label5.Text = "Aventure en skateboard"
            End If
            If NumericUpDown4.Value = 2 And NumericUpDown5.Value = 4 Then
                Label1.Text = "2 - 4"
                Label5.Text = "Et que ça saute"
            End If
            If NumericUpDown4.Value = 2 And NumericUpDown5.Value = 5 Then
                Label1.Text = "2 - 5"
                Label5.Text = "La voie ferrée des sables"
            End If
            If NumericUpDown4.Value = 2 And NumericUpDown5.Value = 6 Then
                Label1.Text = "2 - 6"
                Label5.Text = "Progression en ascension"
            End If
            If NumericUpDown4.Value = 2 And NumericUpDown5.Value = 7 Then
                Label1.Text = "2 - B"
                Label5.Text = "Cobrakhamon, le pharaon doré"
            End If
            If NumericUpDown4.Value = 3 And NumericUpDown5.Value = 1 Then
                Label1.Text = "3 - 1"
                Label5.Text = "Ennuis sous les tropiques"
            End If
            If NumericUpDown4.Value = 3 And NumericUpDown5.Value = 2 Then
                Label1.Text = "3 - 2"
                Label5.Text = "Surf sur les vagues"
            End If
            If NumericUpDown4.Value = 3 And NumericUpDown5.Value = 3 Then
                Label1.Text = "3 - 3"
                Label5.Text = "Randonnée spéléo glaciale"
            End If
            If NumericUpDown4.Value = 3 And NumericUpDown5.Value = 4 Then
                Label1.Text = "3 - 4"
                Label5.Text = "Exploration sous-marine"
            End If
            If NumericUpDown4.Value = 3 And NumericUpDown5.Value = 5 Then
                Label1.Text = "3 - 5"
                Label5.Text = "Coquillages et ricochets"
            End If
            If NumericUpDown4.Value = 3 And NumericUpDown5.Value = 6 Then
                Label1.Text = "3 - 6"
                Label5.Text = "Le mouvement des marées"
            End If
            If NumericUpDown4.Value = 3 And NumericUpDown5.Value = 7 Then
                Label1.Text = "3 - B"
                Label5.Text = "Léviartithan, le monstre abyssal"
            End If
            If NumericUpDown4.Value = 4 And NumericUpDown5.Value = 1 Then
                Label1.Text = "4 - 1"
                Label5.Text = "Sortie en forêt épineuse"
            End If
            If NumericUpDown4.Value = 4 And NumericUpDown5.Value = 2 Then
                Label1.Text = "4 - 2"
                Label5.Text = "À l'assaut de la forteresse"
            End If
            If NumericUpDown4.Value = 4 And NumericUpDown5.Value = 3 Then
                Label1.Text = "4 - 3"
                Label5.Text = "Balade nocturne en sous-bois"
            End If
            If NumericUpDown4.Value = 4 And NumericUpDown5.Value = 4 Then
                Label1.Text = "4 - 4"
                Label5.Text = "En ballons sous les étoiles"
            End If
            If NumericUpDown4.Value = 4 And NumericUpDown5.Value = 5 Then
                Label1.Text = "4 - 5"
                Label5.Text = "Les ruines des boulibombes"
            End If
            If NumericUpDown4.Value = 4 And NumericUpDown5.Value = 6 Then
                Label1.Text = "4 - 6"
                Label5.Text = "Swing entre les branches"
            End If
            If NumericUpDown4.Value = 4 And NumericUpDown5.Value = 7 Then
                Label1.Text = "4 - B"
                Label5.Text = "Crockinero, comte de la nuit"
            End If
            If NumericUpDown4.Value = 5 And NumericUpDown5.Value = 1 Then
                Label1.Text = "5 - 1"
                Label5.Text = "Révolution industrielle"
            End If
            If NumericUpDown4.Value = 5 And NumericUpDown5.Value = 2 Then
                Label1.Text = "5 - 2"
                Label5.Text = "Fuite de l'usine infernale"
            End If
            If NumericUpDown4.Value = 5 And NumericUpDown5.Value = 3 Then
                Label1.Text = "5 - 3"
                Label5.Text = "Périls à la chaîne"
            End If
            If NumericUpDown4.Value = 5 And NumericUpDown5.Value = 4 Then
                Label1.Text = "5 - 4"
                Label5.Text = "Le labyrinthe des pictoclefs"
            End If
            If NumericUpDown4.Value = 5 And NumericUpDown5.Value = 5 Then
                Label1.Text = "5 - 5"
                Label5.Text = "Odyssée à roulettes"
            End If
            If NumericUpDown4.Value = 5 And NumericUpDown5.Value = 6 Then
                Label1.Text = "5 - 6"
                Label5.Text = "Dédale des tapis roulants"
            End If
            If NumericUpDown4.Value = 5 And NumericUpDown5.Value = 7 Then
                Label1.Text = "5 - B"
                Label5.Text = "Brikolator, la tête de briques"
            End If
            If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 1 Then
                Label1.Text = "6 - 1"
                Label5.Text = "Expédition sur la banquise"
            End If
            If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 2 Then
                Label1.Text = "6 - 2"
                Label5.Text = "De l'ordre dans le chaos givré"
            End If
            If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 3 Then
                Label1.Text = "6 - 3"
                Label5.Text = "Glisse entre les glaces"
            End If
            If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 4 Then
                Label1.Text = "6 - 4"
                Label5.Text = "Riposte des plastimonstres"
            End If
            If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 5 Then
                Label1.Text = "6 - 5"
                Label5.Text = "Grotte gla-gla-glaciale"
            End If
            If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 6 Then
                Label1.Text = "6 - 6"
                Label5.Text = "Alliance du froid et du feu"
            End If
            If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 7 Then
                Label1.Text = "6 - B"
                Label5.Text = "Vaisseau amiral, l'ultime défi"
            End If
            If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 8 Then
                Label1.Text = "6 - F"
                Label5.Text = "Chibi-Robo contre Méga-Gyoros"
            End If
            If NumericUpDown4.Value = 7 And NumericUpDown5.Value = 1 Then
                Label1.Text = "7 - 1"
                Label5.Text = "Visite au château de karakuri"
            End If
            If NumericUpDown4.Value = 7 And NumericUpDown5.Value = 2 Then
                Label1.Text = "7 - 2"
                Label5.Text = "Rebonds entre les bonsaïs"
            End If
            If NumericUpDown4.Value = 7 And NumericUpDown5.Value = 3 Then
                Label1.Text = "7 - 3"
                Label5.Text = "La maison des plafonds mobiles"
            End If
            If NumericUpDown4.Value = 7 And NumericUpDown5.Value = 4 Then
                Label1.Text = "7 - 4"
                Label5.Text = "Ascension du Magmayama"
            End If
            If NumericUpDown4.Value = 7 And NumericUpDown5.Value = 5 Then
                Label1.Text = "7 - 5"
                Label5.Text = "Léviartithan 2.0, la bête d'Asie"
            End If
            If NumericUpDown4.Value = 7 And NumericUpDown5.Value = 6 Then
                Label1.Text = "7 - 6"
                Label5.Text = "Brikolator 2.0, la nouvelle tête"
            End If
        End If
        If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
            If NumericUpDown4.Value = 0 And NumericUpDown5.Value = 0 Then
                Label1.Text = "0 - 0"
                Label5.Text = "Shipping Out From the Station"
            End If
            If NumericUpDown4.Value = 1 And NumericUpDown5.Value = 1 Then
                Label1.Text = "1 - 1"
                Label5.Text = "Welcome to Oceania"
            End If
            If NumericUpDown4.Value = 1 And NumericUpDown5.Value = 2 Then
                Label1.Text = "1 - 2"
                Label5.Text = "The Mysterious Mine"
            End If
            If NumericUpDown4.Value = 1 And NumericUpDown5.Value = 3 Then
                Label1.Text = "1 - 3"
                Label5.Text = "Feeling the Burn"
            End If
            If NumericUpDown4.Value = 1 And NumericUpDown5.Value = 4 Then
                Label1.Text = "1 - 4"
                Label5.Text = "Invasion of the Plastic Pests"
            End If
            If NumericUpDown4.Value = 1 And NumericUpDown5.Value = 5 Then
                Label1.Text = "1 - 5"
                Label5.Text = "Treacherous Skies"
            End If
            If NumericUpDown4.Value = 1 And NumericUpDown5.Value = 6 Then
                Label1.Text = "1 - 6"
                Label5.Text = "A Terror Lurks at Twilight"
            End If
            If NumericUpDown4.Value = 1 And NumericUpDown5.Value = 7 Then
                Label1.Text = "1 - B"
                Label5.Text = "Robo-Roo, the Bouncing Batter"
            End If
            If NumericUpDown4.Value = 2 And NumericUpDown5.Value = 1 Then
                Label1.Text = "2 - 1"
                Label5.Text = "Finding Order in the Fiery Chaos"
            End If
            If NumericUpDown4.Value = 2 And NumericUpDown5.Value = 2 Then
                Label1.Text = "2 - 2"
                Label5.Text = "Desert Daze"
            End If
            If NumericUpDown4.Value = 2 And NumericUpDown5.Value = 3 Then
                Label1.Text = "2 - 3"
                Label5.Text = "The Adventures of Skater-Bot"
            End If
            If NumericUpDown4.Value = 2 And NumericUpDown5.Value = 4 Then
                Label1.Text = "2 - 4"
                Label5.Text = "Bring On the Bomb Squad"
            End If
            If NumericUpDown4.Value = 2 And NumericUpDown5.Value = 5 Then
                Label1.Text = "2 - 5"
                Label5.Text = "Riding the Rails"
            End If
            If NumericUpDown4.Value = 2 And NumericUpDown5.Value = 6 Then
                Label1.Text = "2 - 6"
                Label5.Text = "Onward and Upward"
            End If
            If NumericUpDown4.Value = 2 And NumericUpDown5.Value = 7 Then
                Label1.Text = "2 - B"
                Label5.Text = "King Kabombra, the Golden Legend"
            End If
            If NumericUpDown4.Value = 3 And NumericUpDown5.Value = 1 Then
                Label1.Text = "3 - 1"
                Label5.Text = "Trouble in Paradise"
            End If
            If NumericUpDown4.Value = 3 And NumericUpDown5.Value = 2 Then
                Label1.Text = "3 - 2"
                Label5.Text = "Chibi-Robo Hits the Waves"
            End If
            If NumericUpDown4.Value = 3 And NumericUpDown5.Value = 3 Then
                Label1.Text = "3 - 3"
                Label5.Text = "Keeping Cool in the Caverns"
            End If
            If NumericUpDown4.Value = 3 And NumericUpDown5.Value = 4 Then
                Label1.Text = "3 - 4"
                Label5.Text = "All Aboard the Chibi-Sub"
            End If
            If NumericUpDown4.Value = 3 And NumericUpDown5.Value = 5 Then
                Label1.Text = "3 - 5"
                Label5.Text = "Shellfish Shore"
            End If
            If NumericUpDown4.Value = 3 And NumericUpDown5.Value = 6 Then
                Label1.Text = "3 - 6"
                Label5.Text = "Tilting with the Tides"
            End If
            If NumericUpDown4.Value = 3 And NumericUpDown5.Value = 7 Then
                Label1.Text = "3 - B"
                Label5.Text = "Old Ironhide, the Terror of the Deep"
            End If
            If NumericUpDown4.Value = 4 And NumericUpDown5.Value = 1 Then
                Label1.Text = "4 - 1"
                Label5.Text = "Bramblewood Forest"
            End If
            If NumericUpDown4.Value = 4 And NumericUpDown5.Value = 2 Then
                Label1.Text = "4 - 2"
                Label5.Text = "Storm the Castle, Chibi-Robo!"
            End If
            If NumericUpDown4.Value = 4 And NumericUpDown5.Value = 3 Then
                Label1.Text = "4 - 3"
                Label5.Text = "Twilight among the Trees"
            End If
            If NumericUpDown4.Value = 4 And NumericUpDown5.Value = 4 Then
                Label1.Text = "4 - 4"
                Label5.Text = "A Menacing Midnight Flight"
            End If
            If NumericUpDown4.Value = 4 And NumericUpDown5.Value = 5 Then
                Label1.Text = "4 - 5"
                Label5.Text = "The Bomball Ruins"
            End If
            If NumericUpDown4.Value = 4 And NumericUpDown5.Value = 6 Then
                Label1.Text = "4 - 6"
                Label5.Text = "Sylvan Swing"
            End If
            If NumericUpDown4.Value = 4 And NumericUpDown5.Value = 7 Then
                Label1.Text = "4 - B"
                Label5.Text = "Count Umbrahla, the Moonlit Menace"
            End If
            If NumericUpDown4.Value = 5 And NumericUpDown5.Value = 1 Then
                Label1.Text = "5 - 1"
                Label5.Text = "Industrial Revolution"
            End If
            If NumericUpDown4.Value = 5 And NumericUpDown5.Value = 2 Then
                Label1.Text = "5 - 2"
                Label5.Text = "Escape from the Frantic Factory"
            End If
            If NumericUpDown4.Value = 5 And NumericUpDown5.Value = 3 Then
                Label1.Text = "5 - 3"
                Label5.Text = "Adventure on the Assembly Line"
            End If
            If NumericUpDown4.Value = 5 And NumericUpDown5.Value = 4 Then
                Label1.Text = "5 - 4"
                Label5.Text = "Hunting for Pictokeys"
            End If
            If NumericUpDown4.Value = 5 And NumericUpDown5.Value = 5 Then
                Label1.Text = "5 - 5"
                Label5.Text = "Breakneck Boarding"
            End If
            If NumericUpDown4.Value = 5 And NumericUpDown5.Value = 6 Then
                Label1.Text = "5 - 6"
                Label5.Text = "Chaotic Conveyor Belts"
            End If
            If NumericUpDown4.Value = 5 And NumericUpDown5.Value = 7 Then
                Label1.Text = "5 - B"
                Label5.Text = "Construktor, the Block Head"
            End If
            If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 1 Then
                Label1.Text = "6 - 1"
                Label5.Text = "An Icy Expedition"
            End If
            If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 2 Then
                Label1.Text = "6 - 2"
                Label5.Text = "Finding Order in the Icy Chaos"
            End If
            If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 3 Then
                Label1.Text = "6 - 3"
                Label5.Text = "Boarding in a Winter Wonderland"
            End If
            If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 4 Then
                Label1.Text = "6 - 4"
                Label5.Text = "Superheated Showdown"
            End If
            If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 5 Then
                Label1.Text = "6 - 5"
                Label5.Text = "Glacial Grotto"
            End If
            If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 6 Then
                Label1.Text = "6 - 6"
                Label5.Text = "The Harmony of Frost and Fire"
            End If
            If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 7 Then
                Label1.Text = "6 - B"
                Label5.Text = "Mothership Mayhem"
            End If
            If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 8 Then
                Label1.Text = "6 - F"
                Label5.Text = "Chibi-Robo vs. the Mega-Mech Menace"
            End If
            If NumericUpDown4.Value = 7 And NumericUpDown5.Value = 1 Then
                Label1.Text = "7 - 1"
                Label5.Text = "Karakuri Castle"
            End If
            If NumericUpDown4.Value = 7 And NumericUpDown5.Value = 2 Then
                Label1.Text = "7 - 2"
                Label5.Text = "The Bonsai Bounce"
            End If
            If NumericUpDown4.Value = 7 And NumericUpDown5.Value = 3 Then
                Label1.Text = "7 - 3"
                Label5.Text = "Hanging Out in an Elegant Estate"
            End If
            If NumericUpDown4.Value = 7 And NumericUpDown5.Value = 4 Then
                Label1.Text = "7 - 4"
                Label5.Text = "Vexing Volcanic Climb"
            End If
            If NumericUpDown4.Value = 7 And NumericUpDown5.Value = 5 Then
                Label1.Text = "7 - 5"
                Label5.Text = "Ironhide Mk. ||, the Beast in Asia's Abyss"
            End If
            If NumericUpDown4.Value = 7 And NumericUpDown5.Value = 6 Then
                Label1.Text = "7 - 6"
                Label5.Text = "Construktor Mk. ||, the Remodeled Rival"
            End If
        End If
    End Sub

    Private Sub NumericUpDown5_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown5.ValueChanged
        If ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
            If NumericUpDown4.Value = 0 And NumericUpDown5.Value = 0 Then
                Label1.Text = "0 - 0"
                Label5.Text = "En route pour la Terre"
            End If
            If NumericUpDown4.Value = 1 And NumericUpDown5.Value = 1 Then
                Label1.Text = "1 - 1"
                Label5.Text = "Bienvenue en Océanie"
            End If
            If NumericUpDown4.Value = 1 And NumericUpDown5.Value = 2 Then
                Label1.Text = "1 - 2"
                Label5.Text = "La mine mystérieuse"
            End If
            If NumericUpDown4.Value = 1 And NumericUpDown5.Value = 3 Then
                Label1.Text = "1 - 3"
                Label5.Text = "Chaud, chaud, le robot !"
            End If
            If NumericUpDown4.Value = 1 And NumericUpDown5.Value = 4 Then
                Label1.Text = "1 - 4"
                Label5.Text = "Plastimonstres en pagaille"
            End If
            If NumericUpDown4.Value = 1 And NumericUpDown5.Value = 5 Then
                Label1.Text = "1 - 5"
                Label5.Text = "Dans les cieux périlleux"
            End If
            If NumericUpDown4.Value = 1 And NumericUpDown5.Value = 6 Then
                Label1.Text = "1 - 6"
                Label5.Text = "Cavalcade au crépuscule"
            End If
            If NumericUpDown4.Value = 1 And NumericUpDown5.Value = 7 Then
                Label1.Text = "1 - B"
                Label5.Text = "Kangourobot, le boxeur sauteur"
            End If
            If NumericUpDown4.Value = 2 And NumericUpDown5.Value = 1 Then
                Label1.Text = "2 - 1"
                Label5.Text = "De l'ordre dans le chaos brûlant"
            End If
            If NumericUpDown4.Value = 2 And NumericUpDown5.Value = 2 Then
                Label1.Text = "2 - 2"
                Label5.Text = "Les rivières du désert"
            End If
            If NumericUpDown4.Value = 2 And NumericUpDown5.Value = 3 Then
                Label1.Text = "2 - 3"
                Label5.Text = "Aventure en skateboard"
            End If
            If NumericUpDown4.Value = 2 And NumericUpDown5.Value = 4 Then
                Label1.Text = "2 - 4"
                Label5.Text = "Et que ça saute"
            End If
            If NumericUpDown4.Value = 2 And NumericUpDown5.Value = 5 Then
                Label1.Text = "2 - 5"
                Label5.Text = "La voie ferrée des sables"
            End If
            If NumericUpDown4.Value = 2 And NumericUpDown5.Value = 6 Then
                Label1.Text = "2 - 6"
                Label5.Text = "Progression en ascension"
            End If
            If NumericUpDown4.Value = 2 And NumericUpDown5.Value = 7 Then
                Label1.Text = "2 - B"
                Label5.Text = "Cobrakhamon, le pharaon doré"
            End If
            If NumericUpDown4.Value = 3 And NumericUpDown5.Value = 1 Then
                Label1.Text = "3 - 1"
                Label5.Text = "Ennuis sous les tropiques"
            End If
            If NumericUpDown4.Value = 3 And NumericUpDown5.Value = 2 Then
                Label1.Text = "3 - 2"
                Label5.Text = "Surf sur les vagues"
            End If
            If NumericUpDown4.Value = 3 And NumericUpDown5.Value = 3 Then
                Label1.Text = "3 - 3"
                Label5.Text = "Randonnée spéléo glaciale"
            End If
            If NumericUpDown4.Value = 3 And NumericUpDown5.Value = 4 Then
                Label1.Text = "3 - 4"
                Label5.Text = "Exploration sous-marine"
            End If
            If NumericUpDown4.Value = 3 And NumericUpDown5.Value = 5 Then
                Label1.Text = "3 - 5"
                Label5.Text = "Coquillages et ricochets"
            End If
            If NumericUpDown4.Value = 3 And NumericUpDown5.Value = 6 Then
                Label1.Text = "3 - 6"
                Label5.Text = "Le mouvement des marées"
            End If
            If NumericUpDown4.Value = 3 And NumericUpDown5.Value = 7 Then
                Label1.Text = "3 - B"
                Label5.Text = "Léviartithan, le monstre abyssal"
            End If
            If NumericUpDown4.Value = 4 And NumericUpDown5.Value = 1 Then
                Label1.Text = "4 - 1"
                Label5.Text = "Sortie en forêt épineuse"
            End If
            If NumericUpDown4.Value = 4 And NumericUpDown5.Value = 2 Then
                Label1.Text = "4 - 2"
                Label5.Text = "À l'assaut de la forteresse"
            End If
            If NumericUpDown4.Value = 4 And NumericUpDown5.Value = 3 Then
                Label1.Text = "4 - 3"
                Label5.Text = "Balade nocturne en sous-bois"
            End If
            If NumericUpDown4.Value = 4 And NumericUpDown5.Value = 4 Then
                Label1.Text = "4 - 4"
                Label5.Text = "En ballons sous les étoiles"
            End If
            If NumericUpDown4.Value = 4 And NumericUpDown5.Value = 5 Then
                Label1.Text = "4 - 5"
                Label5.Text = "Les ruines des boulibombes"
            End If
            If NumericUpDown4.Value = 4 And NumericUpDown5.Value = 6 Then
                Label1.Text = "4 - 6"
                Label5.Text = "Swing entre les branches"
            End If
            If NumericUpDown4.Value = 4 And NumericUpDown5.Value = 7 Then
                Label1.Text = "4 - B"
                Label5.Text = "Crockinero, comte de la nuit"
            End If
            If NumericUpDown4.Value = 5 And NumericUpDown5.Value = 1 Then
                Label1.Text = "5 - 1"
                Label5.Text = "Révolution industrielle"
            End If
            If NumericUpDown4.Value = 5 And NumericUpDown5.Value = 2 Then
                Label1.Text = "5 - 2"
                Label5.Text = "Fuite de l'usine infernale"
            End If
            If NumericUpDown4.Value = 5 And NumericUpDown5.Value = 3 Then
                Label1.Text = "5 - 3"
                Label5.Text = "Périls à la chaîne"
            End If
            If NumericUpDown4.Value = 5 And NumericUpDown5.Value = 4 Then
                Label1.Text = "5 - 4"
                Label5.Text = "Le labyrinthe des pictoclefs"
            End If
            If NumericUpDown4.Value = 5 And NumericUpDown5.Value = 5 Then
                Label1.Text = "5 - 5"
                Label5.Text = "Odyssée à roulettes"
            End If
            If NumericUpDown4.Value = 5 And NumericUpDown5.Value = 6 Then
                Label1.Text = "5 - 6"
                Label5.Text = "Dédale des tapis roulants"
            End If
            If NumericUpDown4.Value = 5 And NumericUpDown5.Value = 7 Then
                Label1.Text = "5 - B"
                Label5.Text = "Brikolator, la tête de briques"
            End If
            If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 1 Then
                Label1.Text = "6 - 1"
                Label5.Text = "Expédition sur la banquise"
            End If
            If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 2 Then
                Label1.Text = "6 - 2"
                Label5.Text = "De l'ordre dans le chaos givré"
            End If
            If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 3 Then
                Label1.Text = "6 - 3"
                Label5.Text = "Glisse entre les glaces"
            End If
            If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 4 Then
                Label1.Text = "6 - 4"
                Label5.Text = "Riposte des plastimonstres"
            End If
            If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 5 Then
                Label1.Text = "6 - 5"
                Label5.Text = "Grotte gla-gla-glaciale"
            End If
            If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 6 Then
                Label1.Text = "6 - 6"
                Label5.Text = "Alliance du froid et du feu"
            End If
            If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 7 Then
                Label1.Text = "6 - B"
                Label5.Text = "Vaisseau amiral, l'ultime défi"
            End If
            If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 8 Then
                Label1.Text = "6 - F"
                Label5.Text = "Chibi-Robo contre Méga-Gyoros"
            End If
            If NumericUpDown4.Value = 7 And NumericUpDown5.Value = 1 Then
                Label1.Text = "7 - 1"
                Label5.Text = "Visite au château de karakuri"
            End If
            If NumericUpDown4.Value = 7 And NumericUpDown5.Value = 2 Then
                Label1.Text = "7 - 2"
                Label5.Text = "Rebonds entre les bonsaïs"
            End If
            If NumericUpDown4.Value = 7 And NumericUpDown5.Value = 3 Then
                Label1.Text = "7 - 3"
                Label5.Text = "La maison des plafonds mobiles"
            End If
            If NumericUpDown4.Value = 7 And NumericUpDown5.Value = 4 Then
                Label1.Text = "7 - 4"
                Label5.Text = "Ascension du Magmayama"
            End If
            If NumericUpDown4.Value = 7 And NumericUpDown5.Value = 5 Then
                Label1.Text = "7 - 5"
                Label5.Text = "Léviartithan 2.0, la bête d'Asie"
            End If
            If NumericUpDown4.Value = 7 And NumericUpDown5.Value = 6 Then
                Label1.Text = "7 - 6"
                Label5.Text = "Brikolator 2.0, la nouvelle tête"
            End If
        End If
        If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
            If NumericUpDown4.Value = 0 And NumericUpDown5.Value = 0 Then
                Label1.Text = "0 - 0"
                Label5.Text = "Shipping Out From the Station"
            End If
            If NumericUpDown4.Value = 1 And NumericUpDown5.Value = 1 Then
                Label1.Text = "1 - 1"
                Label5.Text = "Welcome to Oceania"
            End If
            If NumericUpDown4.Value = 1 And NumericUpDown5.Value = 2 Then
                Label1.Text = "1 - 2"
                Label5.Text = "The Mysterious Mine"
            End If
            If NumericUpDown4.Value = 1 And NumericUpDown5.Value = 3 Then
                Label1.Text = "1 - 3"
                Label5.Text = "Feeling the Burn"
            End If
            If NumericUpDown4.Value = 1 And NumericUpDown5.Value = 4 Then
                Label1.Text = "1 - 4"
                Label5.Text = "Invasion of the Plastic Pests"
            End If
            If NumericUpDown4.Value = 1 And NumericUpDown5.Value = 5 Then
                Label1.Text = "1 - 5"
                Label5.Text = "Treacherous Skies"
            End If
            If NumericUpDown4.Value = 1 And NumericUpDown5.Value = 6 Then
                Label1.Text = "1 - 6"
                Label5.Text = "A Terror Lurks at Twilight"
            End If
            If NumericUpDown4.Value = 1 And NumericUpDown5.Value = 7 Then
                Label1.Text = "1 - B"
                Label5.Text = "Robo-Roo, the Bouncing Batter"
            End If
            If NumericUpDown4.Value = 2 And NumericUpDown5.Value = 1 Then
                Label1.Text = "2 - 1"
                Label5.Text = "Finding Order in the Fiery Chaos"
            End If
            If NumericUpDown4.Value = 2 And NumericUpDown5.Value = 2 Then
                Label1.Text = "2 - 2"
                Label5.Text = "Desert Daze"
            End If
            If NumericUpDown4.Value = 2 And NumericUpDown5.Value = 3 Then
                Label1.Text = "2 - 3"
                Label5.Text = "The Adventures of Skater-Bot"
            End If
            If NumericUpDown4.Value = 2 And NumericUpDown5.Value = 4 Then
                Label1.Text = "2 - 4"
                Label5.Text = "Bring On the Bomb Squad"
            End If
            If NumericUpDown4.Value = 2 And NumericUpDown5.Value = 5 Then
                Label1.Text = "2 - 5"
                Label5.Text = "Riding the Rails"
            End If
            If NumericUpDown4.Value = 2 And NumericUpDown5.Value = 6 Then
                Label1.Text = "2 - 6"
                Label5.Text = "Onward and Upward"
            End If
            If NumericUpDown4.Value = 2 And NumericUpDown5.Value = 7 Then
                Label1.Text = "2 - B"
                Label5.Text = "King Kabombra, the Golden Legend"
            End If
            If NumericUpDown4.Value = 3 And NumericUpDown5.Value = 1 Then
                Label1.Text = "3 - 1"
                Label5.Text = "Trouble in Paradise"
            End If
            If NumericUpDown4.Value = 3 And NumericUpDown5.Value = 2 Then
                Label1.Text = "3 - 2"
                Label5.Text = "Chibi-Robo Hits the Waves"
            End If
            If NumericUpDown4.Value = 3 And NumericUpDown5.Value = 3 Then
                Label1.Text = "3 - 3"
                Label5.Text = "Keeping Cool in the Caverns"
            End If
            If NumericUpDown4.Value = 3 And NumericUpDown5.Value = 4 Then
                Label1.Text = "3 - 4"
                Label5.Text = "All Aboard the Chibi-Sub"
            End If
            If NumericUpDown4.Value = 3 And NumericUpDown5.Value = 5 Then
                Label1.Text = "3 - 5"
                Label5.Text = "Shellfish Shore"
            End If
            If NumericUpDown4.Value = 3 And NumericUpDown5.Value = 6 Then
                Label1.Text = "3 - 6"
                Label5.Text = "Tilting with the Tides"
            End If
            If NumericUpDown4.Value = 3 And NumericUpDown5.Value = 7 Then
                Label1.Text = "3 - B"
                Label5.Text = "Old Ironhide, the Terror of the Deep"
            End If
            If NumericUpDown4.Value = 4 And NumericUpDown5.Value = 1 Then
                Label1.Text = "4 - 1"
                Label5.Text = "Bramblewood Forest"
            End If
            If NumericUpDown4.Value = 4 And NumericUpDown5.Value = 2 Then
                Label1.Text = "4 - 2"
                Label5.Text = "Storm the Castle, Chibi-Robo!"
            End If
            If NumericUpDown4.Value = 4 And NumericUpDown5.Value = 3 Then
                Label1.Text = "4 - 3"
                Label5.Text = "Twilight among the Trees"
            End If
            If NumericUpDown4.Value = 4 And NumericUpDown5.Value = 4 Then
                Label1.Text = "4 - 4"
                Label5.Text = "A Menacing Midnight Flight"
            End If
            If NumericUpDown4.Value = 4 And NumericUpDown5.Value = 5 Then
                Label1.Text = "4 - 5"
                Label5.Text = "The Bomball Ruins"
            End If
            If NumericUpDown4.Value = 4 And NumericUpDown5.Value = 6 Then
                Label1.Text = "4 - 6"
                Label5.Text = "Sylvan Swing"
            End If
            If NumericUpDown4.Value = 4 And NumericUpDown5.Value = 7 Then
                Label1.Text = "4 - B"
                Label5.Text = "Count Umbrahla, the Moonlit Menace"
            End If
            If NumericUpDown4.Value = 5 And NumericUpDown5.Value = 1 Then
                Label1.Text = "5 - 1"
                Label5.Text = "Industrial Revolution"
            End If
            If NumericUpDown4.Value = 5 And NumericUpDown5.Value = 2 Then
                Label1.Text = "5 - 2"
                Label5.Text = "Escape from the Frantic Factory"
            End If
            If NumericUpDown4.Value = 5 And NumericUpDown5.Value = 3 Then
                Label1.Text = "5 - 3"
                Label5.Text = "Adventure on the Assembly Line"
            End If
            If NumericUpDown4.Value = 5 And NumericUpDown5.Value = 4 Then
                Label1.Text = "5 - 4"
                Label5.Text = "Hunting for Pictokeys"
            End If
            If NumericUpDown4.Value = 5 And NumericUpDown5.Value = 5 Then
                Label1.Text = "5 - 5"
                Label5.Text = "Breakneck Boarding"
            End If
            If NumericUpDown4.Value = 5 And NumericUpDown5.Value = 6 Then
                Label1.Text = "5 - 6"
                Label5.Text = "Chaotic Conveyor Belts"
            End If
            If NumericUpDown4.Value = 5 And NumericUpDown5.Value = 7 Then
                Label1.Text = "5 - B"
                Label5.Text = "Construktor, the Block Head"
            End If
            If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 1 Then
                Label1.Text = "6 - 1"
                Label5.Text = "An Icy Expedition"
            End If
            If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 2 Then
                Label1.Text = "6 - 2"
                Label5.Text = "Finding Order in the Icy Chaos"
            End If
            If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 3 Then
                Label1.Text = "6 - 3"
                Label5.Text = "Boarding in a Winter Wonderland"
            End If
            If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 4 Then
                Label1.Text = "6 - 4"
                Label5.Text = "Superheated Showdown"
            End If
            If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 5 Then
                Label1.Text = "6 - 5"
                Label5.Text = "Glacial Grotto"
            End If
            If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 6 Then
                Label1.Text = "6 - 6"
                Label5.Text = "The Harmony of Frost and Fire"
            End If
            If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 7 Then
                Label1.Text = "6 - B"
                Label5.Text = "Mothership Mayhem"
            End If
            If NumericUpDown4.Value = 6 And NumericUpDown5.Value = 8 Then
                Label1.Text = "6 - F"
                Label5.Text = "Chibi-Robo vs. the Mega-Mech Menace"
            End If
            If NumericUpDown4.Value = 7 And NumericUpDown5.Value = 1 Then
                Label1.Text = "7 - 1"
                Label5.Text = "Karakuri Castle"
            End If
            If NumericUpDown4.Value = 7 And NumericUpDown5.Value = 2 Then
                Label1.Text = "7 - 2"
                Label5.Text = "The Bonsai Bounce"
            End If
            If NumericUpDown4.Value = 7 And NumericUpDown5.Value = 3 Then
                Label1.Text = "7 - 3"
                Label5.Text = "Hanging Out in an Elegant Estate"
            End If
            If NumericUpDown4.Value = 7 And NumericUpDown5.Value = 4 Then
                Label1.Text = "7 - 4"
                Label5.Text = "Vexing Volcanic Climb"
            End If
            If NumericUpDown4.Value = 7 And NumericUpDown5.Value = 5 Then
                Label1.Text = "7 - 5"
                Label5.Text = "Ironhide Mk. ||, the Beast in Asia's Abyss"
            End If
            If NumericUpDown4.Value = 7 And NumericUpDown5.Value = 6 Then
                Label1.Text = "7 - 6"
                Label5.Text = "Construktor Mk. ||, the Remodeled Rival"
            End If
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Form3.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Writefile()
    End Sub
    Private Sub Writefile()
        Try
            Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
            Writer.Position = &H2A5C
            Writer.WriteUInt32(NumericUpDown1.Value)
            Writer.Position = &H2A60
            Writer.WriteUInt16(NumericUpDown2.Value)
            Writer.Position = &H11E8
            Writer.WriteSingle(NumericUpDown3.Value)
            Writer.Position = &H424
            Writer.WriteInt8(NumericUpDown4.Value)
            Writer.Position = &H428
            Writer.WriteInt8(NumericUpDown5.Value)
            Writer.Position = &H2438
            Writer.WriteInt8(NumericUpDown6.Value)
            Writer.Position = &H244C
            Writer.WriteInt8(NumericUpDown7.Value)
            Writer.Position = &H2460
            Writer.WriteInt8(NumericUpDown8.Value)
            Writer.Position = &H2474
            Writer.WriteInt8(NumericUpDown9.Value)
            Writer.Position = &H1D80
            Writer.WriteInt8(NumericUpDown10.Value)
            Writer.Position = &H1F60
            Writer.WriteInt8(NumericUpDown11.Value)
            If Label3.Text = "Link" Then
                Writer.Position = &H2E4C
                Writer.WriteInt32(77932602, Endian.Big)
                Writer.Position = &H2E50
                Writer.WriteUInt32(2236186880, Endian.Big)
                Writer.Position = &H2E54
                Writer.WriteInt32(1823, Endian.Big)
                Writer.Position = &H2E6C
                Writer.WriteInt16(3072, Endian.Big)
            End If
            If Label3.Text = "Unlink" Then
                Writer.Position = &H2E4C
                Writer.WriteInt32(0, Endian.Big)
                Writer.Position = &H2E50
                Writer.WriteUInt32(0, Endian.Big)
                Writer.Position = &H2E54
                Writer.WriteInt32(0, Endian.Big)
                Writer.Position = &H2E6C
                Writer.WriteInt16(0, Endian.Big)
            End If
            If Label6.Text = "Extra" Then
                Writer.Position = &H1131
                Writer.WriteUInt16(55040, Endian.Big)
                Writer.Position = &H2E24
                Writer.WriteInt32(142412388, Endian.Big)
                Writer.Position = &H2E28
                Writer.WriteInt32(77932602, Endian.Big)
                Writer.Position = &H2E2C
                Writer.WriteUInt32(2236186880, Endian.Big)
                Writer.Position = &H2E32
                Writer.WriteUInt16(1823, Endian.Big)
                Writer.Position = &H2E48
                Writer.WriteInt16(3584, Endian.Big)
            End If
            If Label6.Text = "Delete" Then
                Writer.Position = &H1131
                Writer.WriteUInt16(192, Endian.Big)
                Writer.Position = &H2E24
                Writer.WriteInt32(0, Endian.Big)
                Writer.Position = &H2E28
                Writer.WriteInt32(0, Endian.Big)
                Writer.Position = &H2E2C
                Writer.WriteUInt32(0, Endian.Big)
                Writer.Position = &H2E32
                Writer.WriteUInt16(0, Endian.Big)
                Writer.Position = &H2E48
                Writer.WriteInt16(0, Endian.Big)
            End If
            If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
                fdialog.Label1.Text = "Save file has been successfully edited"
                fdialog.ShowDialog()
            End If
            If ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
                fdialog.Label1.Text = "La sauvegarde a été edité avec succès"
                fdialog.ShowDialog()
            End If
        Catch ex As Exception
            If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
                fdialog.Label1.Text = "An error has occurred"
                fdialog.ShowDialog()
            End If
            If ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
                fdialog.Label1.Text = "Une erreur est survenue"
                fdialog.ShowDialog()
            End If
        End Try
    End Sub

    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel2.Click
        Form4.Show()
    End Sub

    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click
        Form5.Show()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Form5.Show()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Form6.Show()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Try
            If CheckBox1.Checked = True Then
                Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                Writer.Position = &H10FD
                Writer.WriteInt16(180)
                Writer.Position = &H1109
                Writer.WriteInt8(18)
                Writer.Position = &H1119
                Writer.WriteInt8(32)
                Writer.Position = &H1125
                Writer.WriteInt8(32)
                Writer.Position = &H112D
                Writer.WriteInt8(80)
                If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
                    fdialog.Label1.Text = "Access to the floor has been successfully unlocked" & vbNewLine & "Unlock extras amiibo in the game is needed before"
                    fdialog.ShowDialog()
                End If
                If ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
                    fdialog.Label1.Text = "L'accès à l'étage a été débloqué avec succès" & vbNewLine & "Débloquer les extras amiibo dans le jeu est nécessaire avant"
                    fdialog.ShowDialog()
                End If
            End If
        Catch Ex As Exception
            If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
                fdialog.Label1.Text = "Load a save file first"
                fdialog.ShowDialog()
            End If
            If ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
                fdialog.Label1.Text = "Ouvrez une sauvegarde avant"
                fdialog.ShowDialog()
            End If
            CheckBox1.Checked = False
        End Try
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        Try
            If CheckBox3.Checked = True Then
                Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Big)
                Writer.Position = &H2A63
                Writer.WriteInt16(200)
                Writer.Position = &H2A65
                Writer.WriteInt16(0)
                Writer.Position = &H2A67
                Writer.WriteInt16(1)
                Writer.Position = &H2A69
                Writer.WriteInt16(2)
                Writer.Position = &H2A6B
                Writer.WriteInt16(3)
                Writer.Position = &H2A6D
                Writer.WriteInt16(4)
                Writer.Position = &H2A6F
                Writer.WriteInt16(5)
                Writer.Position = &H2A71
                Writer.WriteInt16(6)
                Writer.Position = &H2A73
                Writer.WriteInt16(7)
                Writer.Position = &H2A75
                Writer.WriteInt16(8)
                Writer.Position = &H2A77
                Writer.WriteInt16(9)
                Writer.Position = &H2A79
                Writer.WriteInt16(10)
                Writer.Position = &H2A7B
                Writer.WriteInt16(11)
                Writer.Position = &H2A7D
                Writer.WriteInt16(12)
                Writer.Position = &H2A7F
                Writer.WriteInt16(13)
                Writer.Position = &H2A81
                Writer.WriteInt16(14)
                Writer.Position = &H2A83
                Writer.WriteInt16(15)
                Writer.Position = &H2A85
                Writer.WriteInt16(16)
                Writer.Position = &H2A87
                Writer.WriteInt16(17)
                Writer.Position = &H2A89
                Writer.WriteInt16(18)
                Writer.Position = &H2A8B
                Writer.WriteInt16(19)
                Writer.Position = &H2A8D
                Writer.WriteInt16(20)
                Writer.Position = &H2A8F
                Writer.WriteInt16(21)
                Writer.Position = &H2A91
                Writer.WriteInt16(22)
                Writer.Position = &H2A93
                Writer.WriteInt16(23)
                Writer.Position = &H2A95
                Writer.WriteInt16(24)
                Writer.Position = &H2A97
                Writer.WriteInt16(25)
                Writer.Position = &H2A99
                Writer.WriteInt16(26)
                Writer.Position = &H2A9B
                Writer.WriteInt16(27)
                Writer.Position = &H2A9D
                Writer.WriteInt16(28)
                Writer.Position = &H2A9F
                Writer.WriteInt16(29)
                Writer.Position = &H2AA1
                Writer.WriteInt16(30)
                Writer.Position = &H2AA3
                Writer.WriteInt16(31)
                Writer.Position = &H2AA5
                Writer.WriteInt16(32)
                Writer.Position = &H2AA7
                Writer.WriteInt16(33)
                Writer.Position = &H2AA9
                Writer.WriteInt16(34)
                Writer.Position = &H2AAB
                Writer.WriteInt16(35)
                Writer.Position = &H2AAD
                Writer.WriteInt16(36)
                Writer.Position = &H2AAF
                Writer.WriteInt16(37)
                Writer.Position = &H2AB1
                Writer.WriteInt16(38)
                Writer.Position = &H2AB3
                Writer.WriteInt16(39)
                Writer.Position = &H2AB5
                Writer.WriteInt16(40)
                Writer.Position = &H2AB7
                Writer.WriteInt16(41)
                Writer.Position = &H2AB9
                Writer.WriteInt16(42)
                Writer.Position = &H2ABB
                Writer.WriteInt16(43)
                Writer.Position = &H2ABD
                Writer.WriteInt16(44)
                Writer.Position = &H2ABF
                Writer.WriteInt16(45)
                Writer.Position = &H2AC1
                Writer.WriteInt16(46)
                Writer.Position = &H2AC3
                Writer.WriteInt16(47)
                Writer.Position = &H2AC5
                Writer.WriteInt16(48)
                Writer.Position = &H2AC7
                Writer.WriteInt16(49)
                Writer.Position = &H2AC9
                Writer.WriteInt16(50)
                Writer.Position = &H2ACB
                Writer.WriteInt16(51)
                Writer.Position = &H2ACD
                Writer.WriteInt16(52)
                Writer.Position = &H2ACF
                Writer.WriteInt16(53)
                Writer.Position = &H2AD1
                Writer.WriteInt16(54)
                Writer.Position = &H2AD3
                Writer.WriteInt16(55)
                Writer.Position = &H2AD5
                Writer.WriteInt16(56)
                Writer.Position = &H2AD7
                Writer.WriteInt16(57)
                Writer.Position = &H2AD9
                Writer.WriteInt16(58)
                Writer.Position = &H2ADB
                Writer.WriteInt16(59)
                Writer.Position = &H2ADD
                Writer.WriteInt16(60)
                Writer.Position = &H2ADF
                Writer.WriteInt16(61)
                Writer.Position = &H2AE1
                Writer.WriteInt16(62)
                Writer.Position = &H2AE3
                Writer.WriteInt16(63)
                Writer.Position = &H2AE5
                Writer.WriteInt16(64)
                Writer.Position = &H2AE7
                Writer.WriteInt16(65)
                Writer.Position = &H2AE9
                Writer.WriteInt16(66)
                Writer.Position = &H2AEB
                Writer.WriteInt16(67)
                Writer.Position = &H2AED
                Writer.WriteInt16(68)
                Writer.Position = &H2AEF
                Writer.WriteInt16(69)
                Writer.Position = &H2AF1
                Writer.WriteInt16(70)
                Writer.Position = &H2AF3
                Writer.WriteInt16(71)
                Writer.Position = &H2AF5
                Writer.WriteInt16(72)
                Writer.Position = &H2AF7
                Writer.WriteInt16(73)
                Writer.Position = &H2AF9
                Writer.WriteInt16(74)
                Writer.Position = &H2AFB
                Writer.WriteInt16(75)
                Writer.Position = &H2AFD
                Writer.WriteInt16(76)
                Writer.Position = &H2AFF
                Writer.WriteInt16(77)
                Writer.Position = &H2B01
                Writer.WriteInt16(78)
                Writer.Position = &H2B03
                Writer.WriteInt16(79)
                Writer.Position = &H2B05
                Writer.WriteInt16(80)
                Writer.Position = &H2B07
                Writer.WriteInt16(81)
                Writer.Position = &H2B09
                Writer.WriteInt16(82)
                Writer.Position = &H2B0B
                Writer.WriteInt16(83)
                Writer.Position = &H2B0D
                Writer.WriteInt16(84)
                Writer.Position = &H2B0F
                Writer.WriteInt16(85)
                Writer.Position = &H2B11
                Writer.WriteInt16(86)
                Writer.Position = &H2B13
                Writer.WriteInt16(87)
                Writer.Position = &H2B15
                Writer.WriteInt16(88)
                Writer.Position = &H2B17
                Writer.WriteInt16(89)
                Writer.Position = &H2B19
                Writer.WriteInt16(90)
                Writer.Position = &H2B1B
                Writer.WriteInt16(91)
                Writer.Position = &H2B1D
                Writer.WriteInt16(92)
                Writer.Position = &H2B1F
                Writer.WriteInt16(93)
                Writer.Position = &H2B21
                Writer.WriteInt16(94)
                Writer.Position = &H2B23
                Writer.WriteInt16(95)
                Writer.Position = &H2B25
                Writer.WriteInt16(96)
                Writer.Position = &H2B27
                Writer.WriteInt16(97)
                Writer.Position = &H2B29
                Writer.WriteInt16(98)
                Writer.Position = &H2B2B
                Writer.WriteInt16(99)
                Writer.Position = &H2B2D
                Writer.WriteInt16(100)
                Writer.Position = &H2B2F
                Writer.WriteInt16(101)
                Writer.Position = &H2B31
                Writer.WriteInt16(102)
                Writer.Position = &H2B33
                Writer.WriteInt16(103)
                Writer.Position = &H2B35
                Writer.WriteInt16(104)
                Writer.Position = &H2B37
                Writer.WriteInt16(105)
                Writer.Position = &H2B39
                Writer.WriteInt16(106)
                Writer.Position = &H2B3B
                Writer.WriteInt16(107)
                Writer.Position = &H2B3D
                Writer.WriteInt16(108)
                Writer.Position = &H2B3F
                Writer.WriteInt16(109)
                Writer.Position = &H2B41
                Writer.WriteInt16(110)
                Writer.Position = &H2B43
                Writer.WriteInt16(111)
                Writer.Position = &H2B45
                Writer.WriteInt16(112)
                Writer.Position = &H2B47
                Writer.WriteInt16(113)
                Writer.Position = &H2B49
                Writer.WriteInt16(114)
                Writer.Position = &H2B4B
                Writer.WriteInt16(115)
                Writer.Position = &H2B4D
                Writer.WriteInt16(116)
                Writer.Position = &H2B4F
                Writer.WriteInt16(117)
                Writer.Position = &H2B51
                Writer.WriteInt16(118)
                Writer.Position = &H2B53
                Writer.WriteInt16(119)
                Writer.Position = &H2B55
                Writer.WriteInt16(120)
                Writer.Position = &H2B57
                Writer.WriteInt16(121)
                Writer.Position = &H2B59
                Writer.WriteInt16(122)
                Writer.Position = &H2B5B
                Writer.WriteInt16(123)
                Writer.Position = &H2B5D
                Writer.WriteInt16(124)
                Writer.Position = &H2B5F
                Writer.WriteInt16(125)
                Writer.Position = &H2B61
                Writer.WriteInt16(126)
                Writer.Position = &H2B63
                Writer.WriteInt16(127)
                Writer.Position = &H2B65
                Writer.WriteInt16(128)
                Writer.Position = &H2B67
                Writer.WriteInt16(129)
                Writer.Position = &H2B69
                Writer.WriteInt16(130)
                Writer.Position = &H2B6B
                Writer.WriteInt16(131)
                Writer.Position = &H2B6D
                Writer.WriteInt16(132)
                Writer.Position = &H2B6F
                Writer.WriteInt16(133)
                Writer.Position = &H2B71
                Writer.WriteInt16(134)
                Writer.Position = &H2B73
                Writer.WriteInt16(135)
                Writer.Position = &H2B75
                Writer.WriteInt16(136)
                Writer.Position = &H2B77
                Writer.WriteInt16(137)
                Writer.Position = &H2B79
                Writer.WriteInt16(138)
                Writer.Position = &H2B7B
                Writer.WriteInt16(139)
                Writer.Position = &H2B7D
                Writer.WriteInt16(140)
                Writer.Position = &H2B7F
                Writer.WriteInt16(141)
                Writer.Position = &H2B81
                Writer.WriteInt16(142)
                Writer.Position = &H2B83
                Writer.WriteInt16(143)
                Writer.Position = &H2B85
                Writer.WriteInt16(144)
                Writer.Position = &H2B87
                Writer.WriteInt16(145)
                Writer.Position = &H2B89
                Writer.WriteInt16(146)
                Writer.Position = &H2B8B
                Writer.WriteInt16(147)
                Writer.Position = &H2B8D
                Writer.WriteInt16(148)
                Writer.Position = &H2B8F
                Writer.WriteInt16(149)
                Writer.Position = &H2B91
                Writer.WriteInt16(150)
                Writer.Position = &H2B93
                Writer.WriteInt16(151)
                Writer.Position = &H2B95
                Writer.WriteInt16(152)
                Writer.Position = &H2B97
                Writer.WriteInt16(153)
                Writer.Position = &H2B99
                Writer.WriteInt16(154)
                Writer.Position = &H2B9B
                Writer.WriteInt16(155)
                Writer.Position = &H2B9D
                Writer.WriteInt16(156)
                Writer.Position = &H2B9F
                Writer.WriteInt16(157)
                Writer.Position = &H2BA1
                Writer.WriteInt16(158)
                Writer.Position = &H2BA3
                Writer.WriteInt16(159)
                Writer.Position = &H2BA5
                Writer.WriteInt16(160)
                Writer.Position = &H2BA7
                Writer.WriteInt16(161)
                Writer.Position = &H2BA9
                Writer.WriteInt16(162)
                Writer.Position = &H2BAB
                Writer.WriteInt16(163)
                Writer.Position = &H2BAD
                Writer.WriteInt16(164)
                Writer.Position = &H2BAF
                Writer.WriteInt16(165)
                Writer.Position = &H2BB1
                Writer.WriteInt16(166)
                Writer.Position = &H2BB3
                Writer.WriteInt16(167)
                Writer.Position = &H2BB5
                Writer.WriteInt16(168)
                Writer.Position = &H2BB7
                Writer.WriteInt16(169)
                Writer.Position = &H2BB9
                Writer.WriteInt16(170)
                Writer.Position = &H2BBB
                Writer.WriteInt16(171)
                Writer.Position = &H2BBD
                Writer.WriteInt16(172)
                Writer.Position = &H2BBF
                Writer.WriteInt16(173)
                Writer.Position = &H2BC1
                Writer.WriteInt16(174)
                Writer.Position = &H2BC3
                Writer.WriteInt16(175)
                Writer.Position = &H2BC5
                Writer.WriteInt16(176)
                Writer.Position = &H2BC7
                Writer.WriteInt16(177)
                Writer.Position = &H2BC9
                Writer.WriteInt16(178)
                Writer.Position = &H2BCB
                Writer.WriteInt16(179)
                Writer.Position = &H2BCD
                Writer.WriteInt16(180)
                Writer.Position = &H2BCF
                Writer.WriteInt16(181)
                Writer.Position = &H2BD1
                Writer.WriteInt16(182)
                Writer.Position = &H2BD3
                Writer.WriteInt16(183)
                Writer.Position = &H2BD5
                Writer.WriteInt16(184)
                Writer.Position = &H2BD7
                Writer.WriteInt16(185)
                Writer.Position = &H2BD9
                Writer.WriteInt16(186)
                Writer.Position = &H2BDB
                Writer.WriteInt16(187)
                Writer.Position = &H2BDD
                Writer.WriteInt16(188)
                Writer.Position = &H2BDF
                Writer.WriteInt16(189)
                Writer.Position = &H2BE1
                Writer.WriteInt16(190)
                Writer.Position = &H2BE3
                Writer.WriteInt16(191)
                Writer.Position = &H2BE5
                Writer.WriteInt16(192)
                Writer.Position = &H2BE7
                Writer.WriteInt16(193)
                Writer.Position = &H2BE9
                Writer.WriteInt16(194)
                Writer.Position = &H2BEB
                Writer.WriteInt16(195)
                Writer.Position = &H2BED
                Writer.WriteInt16(196)
                Writer.Position = &H2BEF
                Writer.WriteInt16(197)
                Writer.Position = &H2BF1
                Writer.WriteInt16(198)
                Writer.Position = &H2BF3
                Writer.WriteInt16(199)
                Writer.Position = &H2BF5
                Writer.WriteInt16(200)
                If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
                    fdialog.Label1.Text = "All figurines has been successfully unlocked"
                    fdialog.ShowDialog()
                End If
                If ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
                    fdialog.Label1.Text = "Toutes les figurines ont été débloquées avec succès"
                    fdialog.ShowDialog()
                End If
            End If
        Catch Ex As Exception
            If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
                fdialog.Label1.Text = "Load a save file first"
                fdialog.ShowDialog()
            End If
            If ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
                fdialog.Label1.Text = "Ouvrez une sauvegarde avant"
                fdialog.ShowDialog()
            End If
            CheckBox3.Checked = False
        End Try
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        Try
            If CheckBox2.Checked = True Then
                Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                For i As Integer = 0 To 74
                    Writer.Position = &H2CBE + i
                    Writer.WriteUInt16(65535)
                Next
                If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
                    fdialog.Label1.Text = "All figurines info. in album has been successfully unlocked"
                    fdialog.ShowDialog()
                End If
                If ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
                    fdialog.Label1.Text = "Toutes les infos des figurines ont été débloquées dans l'album avec succès"
                    fdialog.ShowDialog()
                End If
            End If
        Catch Ex As Exception
            If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
                fdialog.Label1.Text = "Load a save file fist"
                fdialog.ShowDialog()
            End If
            If ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
                fdialog.Label1.Text = "Ouvrez une sauvegarde avant"
                fdialog.ShowDialog()
            End If
            CheckBox2.Checked = False
        End Try
    End Sub
    Private Sub PictureBox3_MouseMove(sender As Object, e As EventArgs) Handles PictureBox3.MouseMove
        If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
            Label8.Text = "Click for traveling (edit spaceship location)"
        End If
        If ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
            Label8.Text = "Cliquez pour voyager (éditer l'emplacement du vaisseau)"
        End If
        Label8.Visible = True
    End Sub

    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox3.MouseLeave
        Label8.Visible = False
    End Sub
    Private Sub PictureBox4_MouseMove(sender As Object, e As EventArgs) Handles PictureBox4.MouseMove, NumericUpDown1.MouseMove
        If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
            Label8.Text = "Money"
        End If
        If ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
            Label8.Text = "Argent"
        End If
        Label8.Visible = True
    End Sub

    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox4.MouseLeave, NumericUpDown1.MouseLeave
        Label8.Visible = False
    End Sub
    Private Sub Label4_MouseMove(sender As Object, e As EventArgs) Handles Label4.MouseMove, NumericUpDown2.MouseMove
        If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
            Label8.Text = "Percentage achievement reached"
        End If
        If ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
            Label8.Text = "Poucentage atteint de la sauvegarde"
        End If
        Label8.Visible = True
    End Sub

    Private Sub Label4_MouseLeave(sender As Object, e As EventArgs) Handles Label4.MouseLeave, NumericUpDown2.MouseLeave
        Label8.Visible = False
    End Sub
    Private Sub PictureBox5_MouseMove(sender As Object, e As EventArgs) Handles PictureBox5.MouseMove
        If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
            Label8.Text = "Click for show credits"
        End If
        If ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
            Label8.Text = "Cliquez pour afficher les crédits"
        End If
        Label8.Visible = True
    End Sub

    Private Sub PictureBox5_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox5.MouseLeave
        Label8.Visible = False
    End Sub
    Private Sub Panel2_MouseMove(sender As Object, e As EventArgs) Handles Panel2.MouseMove
        If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
            Label8.Text = "Click for Unlock extras amiibo or link an amiibo"
        End If
        If ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
            Label8.Text = "Cliquez pour débloquer les extras amiibo ou lier un amiibo"
        End If
        Label8.Visible = True
    End Sub

    Private Sub Panel2_MouseLeave(sender As Object, e As EventArgs) Handles Panel2.MouseLeave
        Label8.Visible = False
    End Sub
    Private Sub Panel3_MouseMove(sender As Object, e As EventArgs) Handles Panel3.MouseMove, Label7.MouseMove
        If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
            Label8.Text = "Click for edit the inventory"
        End If
        If ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
            Label8.Text = "Cliquez pour éditer l'inventaire"
        End If
        Label8.Visible = True
    End Sub

    Private Sub Panel3_MouseLeave(sender As Object, e As EventArgs) Handles Panel3.MouseLeave, Label7.MouseLeave
        Label8.Visible = False
    End Sub
    Private Sub Panel4_MouseMove(sender As Object, e As EventArgs) Handles Panel4.MouseMove, NumericUpDown3.MouseMove
        Label8.Text = "Watt"
        Label8.Visible = True
    End Sub

    Private Sub Panel4_MouseLeave(sender As Object, e As EventArgs) Handles Panel4.MouseLeave, NumericUpDown3.MouseLeave
        Label8.Visible = False
    End Sub
    Private Sub Combobox1_MouseMove(sender As Object, e As EventArgs) Handles ComboBox1.MouseMove
        If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
            Label8.Text = "Click for change Chibi-Robo ZL Save Editor Language"
        End If
        If ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
            Label8.Text = "Cliquez pour changer la langue de Chibi-Robo ZL Save Editor"
        End If
        Label8.Visible = True
    End Sub

    Private Sub Combobox1_MouseLeave(sender As Object, e As EventArgs) Handles ComboBox1.MouseLeave
        Label8.Visible = False
    End Sub
    Private Sub CheckBox4_MouseMove(sender As Object, e As EventArgs) Handles CheckBox4.MouseMove, CheckBox5.MouseMove, CheckBox6.MouseMove, CheckBox7.MouseMove
        If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
            Label8.Text = "Trophies for this/all level(s) will be deleted"
        End If
        If ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
            Label8.Text = "Les trophées pour ce/ces niveau(x) seront supprimés"
        End If
        Label8.Visible = True
    End Sub

    Private Sub CheckBox4_MouseLeave(sender As Object, e As EventArgs) Handles CheckBox4.MouseLeave, CheckBox5.MouseLeave, CheckBox6.MouseLeave, CheckBox7.MouseLeave
        Label8.Visible = False
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        Try
            If CheckBox4.Checked = True Then
                If ComboBox3.SelectedItem = ComboBox3.Items.Item(6) Then
                    Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                    Writer.Position = &H690
                    Writer.WriteUInt16(1)
                    If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
                        fdialog.Label1.Text = "The fisrt level of World 7 has been successfully unlocked"
                        fdialog.ShowDialog()
                    End If
                    If ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
                        fdialog.Label1.Text = "Le premier niveau du Monde 7 a été débloqué avec succès"
                        fdialog.ShowDialog()
                    End If
                    CheckBox4.Checked = False
                End If
                If ComboBox3.SelectedItem = ComboBox3.Items.Item(5) Then
                    Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                    Writer.Position = &H674
                    Writer.WriteUInt16(1)
                    If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
                        fdialog.Label1.Text = "The fisrt level of World 6 has been successfully unlocked"
                        fdialog.ShowDialog()
                    End If
                    If ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
                        fdialog.Label1.Text = "Le premier niveau du Monde 6 a été débloqué avec succès"
                        fdialog.ShowDialog()
                    End If
                    CheckBox4.Checked = False
                End If
                If ComboBox3.SelectedItem = ComboBox3.Items.Item(4) Then
                    Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                    Writer.Position = &H658
                    Writer.WriteUInt16(1)
                    If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
                        fdialog.Label1.Text = "The fisrt level of World 5 has been successfully unlocked"
                        fdialog.ShowDialog()
                    End If
                    If ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
                        fdialog.Label1.Text = "Le premier niveau du Monde 5 a été débloqué avec succès"
                        fdialog.ShowDialog()
                    End If
                    CheckBox4.Checked = False
                End If
                If ComboBox3.SelectedItem = ComboBox3.Items.Item(3) Then
                    Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                    Writer.Position = &H63C
                    Writer.WriteUInt16(1)
                    If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
                        fdialog.Label1.Text = "The fisrt level of World 4 has been successfully unlocked"
                        fdialog.ShowDialog()
                    End If
                    If ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
                        fdialog.Label1.Text = "Le premier niveau du Monde 4 a été débloqué avec succès"
                        fdialog.ShowDialog()
                    End If
                    CheckBox4.Checked = False
                End If
                If ComboBox3.SelectedItem = ComboBox3.Items.Item(2) Then
                    Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                    Writer.Position = &H620
                    Writer.WriteUInt16(1)
                    If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
                        fdialog.Label1.Text = "The fisrt level of World 3 has been successfully unlocked"
                        fdialog.ShowDialog()
                    End If
                    If ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
                        fdialog.Label1.Text = "Le premier niveau du Monde 3 a été débloqué avec succès"
                        fdialog.ShowDialog()
                    End If
                    CheckBox4.Checked = False
                End If
                If ComboBox3.SelectedItem = ComboBox3.Items.Item(1) Then
                    Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                    Writer.Position = &H604
                    Writer.WriteUInt16(1)
                    If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
                        fdialog.Label1.Text = "The fisrt level of World 2 has been successfully unlocked"
                        fdialog.ShowDialog()
                    End If
                    If ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
                        fdialog.Label1.Text = "Le premier niveau du Monde 2 a été débloqué avec succès"
                        fdialog.ShowDialog()
                    End If
                    CheckBox4.Checked = False
                End If
                If ComboBox3.SelectedItem = ComboBox3.Items.Item(0) Then
                    Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                    Writer.Position = &H5E8
                    Writer.WriteUInt16(1)
                    If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
                        fdialog.Label1.Text = "The fisrt level of World 1 has been successfully unlocked"
                        fdialog.ShowDialog()
                    End If
                    If ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
                        fdialog.Label1.Text = "Le premier niveau du Monde 1 a été débloqué avec succès"
                        fdialog.ShowDialog()
                    End If
                    CheckBox4.Checked = False
                End If
            End If
        Catch Ex As Exception
            If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
                fdialog.Label1.Text = "Load a save file first"
                fdialog.ShowDialog()
            End If
            If ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
                fdialog.Label1.Text = "Ouvrez une sauvegarde avant"
                fdialog.ShowDialog()
            End If
            CheckBox4.Checked = False
        End Try
    End Sub

    Private Sub NumericUpDown12_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown12.ValueChanged
        If NumericUpDown12.Value = 1 Then
            PictureBox6.Image = My.Resources.M1

        End If
        If NumericUpDown12.Value = 2 Then
            PictureBox6.Image = My.Resources.M2

        End If
        If NumericUpDown12.Value = 3 Then
            PictureBox6.Image = My.Resources.M3

        End If
        If NumericUpDown12.Value = 4 Then
            PictureBox6.Image = My.Resources.M4

        End If
        If NumericUpDown12.Value = 5 Then
            PictureBox6.Image = My.Resources.M5

        End If
        If NumericUpDown12.Value = 6 Then
            PictureBox6.Image = My.Resources.M6

        End If
        If NumericUpDown12.Value = 7 Then
            PictureBox6.Image = My.Resources.M7

        End If
    End Sub

    Private Sub Panel3_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel3.MouseMove, Label7.MouseMove

    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        Try
            If CheckBox7.Checked = True Then
                If ComboBox3.SelectedItem = ComboBox3.Items.Item(0) Then
                    Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                    For i As Integer = 0 To 20 Step 4
                        Writer.Position = &H5E8 + i
                        Writer.WriteUInt32(6141)
                    Next
                    Writer.Position = &H600
                    Writer.WriteUInt32(1)
                    If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
                        fdialog.Label1.Text = "All levels of World 1 have been successfully unlocked"
                        fdialog.ShowDialog()
                    End If
                    If ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
                        fdialog.Label1.Text = "Tous les niveaux du Monde 1 ont été débloqué avec succès"
                        fdialog.ShowDialog()
                    End If
                    CheckBox7.Checked = False
                End If
                If ComboBox3.SelectedItem = ComboBox3.Items.Item(1) Then
                    Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                    For i As Integer = 0 To 20 Step 4
                        Writer.Position = &H604 + i
                        Writer.WriteUInt32(6141)
                    Next
                    Writer.Position = &H61C
                    Writer.WriteUInt32(1)
                    If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
                        fdialog.Label1.Text = "All levels of World 2 have been successfully unlocked"
                        fdialog.ShowDialog()
                    End If
                    If ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
                        fdialog.Label1.Text = "Tous les niveaux du Monde 2 ont été débloqué avec succès"
                        fdialog.ShowDialog()
                    End If
                    CheckBox7.Checked = False
                End If
                If ComboBox3.SelectedItem = ComboBox3.Items.Item(2) Then
                    Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                    For i As Integer = 0 To 20 Step 4
                        Writer.Position = &H620 + i
                        Writer.WriteUInt32(6141)
                    Next
                    Writer.Position = &H638
                    Writer.WriteUInt32(1)
                    If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
                        fdialog.Label1.Text = "All levels of World 3 have been successfully unlocked"
                        fdialog.ShowDialog()
                    End If
                    If ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
                        fdialog.Label1.Text = "Tous les niveaux du Monde 3 ont été débloqué avec succès"
                        fdialog.ShowDialog()
                    End If
                    CheckBox7.Checked = False
                End If
                If ComboBox3.SelectedItem = ComboBox3.Items.Item(3) Then
                    Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                    For i As Integer = 0 To 20 Step 4
                        Writer.Position = &H63C + i
                        Writer.WriteUInt32(6141)
                    Next
                    Writer.Position = &H654
                    Writer.WriteUInt32(1)
                    If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
                        fdialog.Label1.Text = "All levels of World 4 have been successfully unlocked"
                        fdialog.ShowDialog()
                    End If
                    If ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
                        fdialog.Label1.Text = "Tous les niveaux du Monde 4 ont été débloqué avec succès"
                        fdialog.ShowDialog()
                    End If
                    CheckBox7.Checked = False
                End If
                If ComboBox3.SelectedItem = ComboBox3.Items.Item(4) Then
                    Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                    For i As Integer = 0 To 20 Step 4
                        Writer.Position = &H658 + i
                        Writer.WriteUInt32(6141)
                    Next
                    Writer.Position = &H670
                    Writer.WriteUInt32(1)
                    If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
                        fdialog.Label1.Text = "All levels of World 5 have been successfully unlocked"
                        fdialog.ShowDialog()
                    End If
                    If ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
                        fdialog.Label1.Text = "Tous les niveaux du Monde 5 ont été débloqué avec succès"
                        fdialog.ShowDialog()
                    End If
                    CheckBox7.Checked = False
                End If
                If ComboBox3.SelectedItem = ComboBox3.Items.Item(5) Then
                    Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                    For i As Integer = 0 To 20 Step 4
                        Writer.Position = &H674 + i
                        Writer.WriteUInt32(6141)
                    Next
                    Writer.Position = &H68C
                    Writer.WriteUInt32(1)
                    If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
                        fdialog.Label1.Text = "All levels of World 6 have been successfully unlocked"
                        fdialog.ShowDialog()
                    End If
                    If ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
                        fdialog.Label1.Text = "Tous les niveaux du Monde 6 ont été débloqué avec succès"
                        fdialog.ShowDialog()
                    End If
                    CheckBox7.Checked = False
                End If
                If ComboBox3.SelectedItem = ComboBox3.Items.Item(6) Then
                    Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                    For i As Integer = 0 To 20 Step 4
                        Writer.Position = &H690 + i
                        Writer.WriteUInt32(6141)
                    Next
                    Writer.Position = &H6A8
                    Writer.WriteUInt32(1)
                    If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
                        fdialog.Label1.Text = "All levels of World 7 have been successfully unlocked"
                        fdialog.ShowDialog()
                    End If
                    If ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
                        fdialog.Label1.Text = "Tous les niveaux du Monde 7 ont été débloqué avec succès"
                        fdialog.ShowDialog()
                    End If
                    CheckBox7.Checked = False
                End If
            End If
        Catch ex As Exception
            If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
                fdialog.Label1.Text = "Load a save file first"
                fdialog.ShowDialog()
            End If
            If ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
                fdialog.Label1.Text = "Ouvrez une sauvegarde avant"
                fdialog.ShowDialog()
            End If
            CheckBox7.Checked = False
        End Try
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(0) Then
            NumericUpDown12.Value = 1
        End If
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(1) Then
            NumericUpDown12.Value = 2
        End If
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(2) Then
            NumericUpDown12.Value = 3
        End If
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(3) Then
            NumericUpDown12.Value = 4
        End If
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(4) Then
            NumericUpDown12.Value = 5
        End If
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(5) Then
            NumericUpDown12.Value = 6
        End If
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(6) Then
            NumericUpDown12.Value = 7
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        Try
            If CheckBox5.Checked = True Then
                If ComboBox3.SelectedItem = ComboBox3.Items.Item(0) Then
                    Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                    For i As Integer = 0 To 24 Step 4
                        Writer.Position = &H5E8 + i
                        Writer.WriteUInt32(1)
                    Next
                    If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
                        fdialog.Label1.Text = "All levels of World 1 have been successfully unlocked"
                        fdialog.ShowDialog()
                    End If
                    If ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
                        fdialog.Label1.Text = "Tous les niveaux du Monde 1 ont été débloqué avec succès"
                        fdialog.ShowDialog()
                    End If
                    CheckBox5.Checked = False
                End If
                If ComboBox3.SelectedItem = ComboBox3.Items.Item(1) Then
                    Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                    For i As Integer = 0 To 24 Step 4
                        Writer.Position = &H604 + i
                        Writer.WriteUInt32(1)
                    Next
                    If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
                        fdialog.Label1.Text = "All levels of World 2 have been successfully unlocked"
                        fdialog.ShowDialog()
                    End If
                    If ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
                        fdialog.Label1.Text = "Tous les niveaux du Monde 2 ont été débloqué avec succès"
                        fdialog.ShowDialog()
                    End If
                    CheckBox5.Checked = False
                End If
                If ComboBox3.SelectedItem = ComboBox3.Items.Item(2) Then
                    Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                    For i As Integer = 0 To 24 Step 4
                        Writer.Position = &H620 + i
                        Writer.WriteUInt32(1)
                    Next
                    If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
                        fdialog.Label1.Text = "All levels of World 3 have been successfully unlocked"
                        fdialog.ShowDialog()
                    End If
                    If ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
                        fdialog.Label1.Text = "Tous les niveaux du Monde 3 ont été débloqué avec succès"
                        fdialog.ShowDialog()
                    End If
                    CheckBox5.Checked = False
                End If
                If ComboBox3.SelectedItem = ComboBox3.Items.Item(3) Then
                    Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                    For i As Integer = 0 To 24 Step 4
                        Writer.Position = &H63C + i
                        Writer.WriteUInt32(1)
                    Next
                    If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
                        fdialog.Label1.Text = "All levels of World 4 have been successfully unlocked"
                        fdialog.ShowDialog()
                    End If
                    If ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
                        fdialog.Label1.Text = "Tous les niveaux du Monde 4 ont été débloqué avec succès"
                        fdialog.ShowDialog()
                    End If
                    CheckBox5.Checked = False
                End If
                If ComboBox3.SelectedItem = ComboBox3.Items.Item(4) Then
                    Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                    For i As Integer = 0 To 24 Step 4
                        Writer.Position = &H658 + i
                        Writer.WriteUInt32(1)
                    Next
                    If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
                        fdialog.Label1.Text = "All levels of World 5 have been successfully unlocked"
                        fdialog.ShowDialog()
                    End If
                    If ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
                        fdialog.Label1.Text = "Tous les niveaux du Monde 5 ont été débloqué avec succès"
                        fdialog.ShowDialog()
                    End If
                    CheckBox5.Checked = False
                End If
                If ComboBox3.SelectedItem = ComboBox3.Items.Item(5) Then
                    Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                    For i As Integer = 0 To 24 Step 4
                        Writer.Position = &H674 + i
                        Writer.WriteUInt32(1)
                    Next
                    If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
                        fdialog.Label1.Text = "All levels of World 6 have been successfully unlocked"
                        fdialog.ShowDialog()
                    End If
                    If ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
                        fdialog.Label1.Text = "Tous les niveaux du Monde 6 ont été débloqué avec succès"
                        fdialog.ShowDialog()
                    End If
                    CheckBox5.Checked = False
                End If
                If ComboBox3.SelectedItem = ComboBox3.Items.Item(6) Then
                    Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                    For i As Integer = 0 To 24 Step 4
                        Writer.Position = &H690 + i
                        Writer.WriteUInt32(1)
                    Next
                    If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
                        fdialog.Label1.Text = "All levels of World 7 have been successfully unlocked"
                        fdialog.ShowDialog()
                    End If
                    If ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
                        fdialog.Label1.Text = "Tous les niveaux du Monde 7 ont été débloqué avec succès"
                        fdialog.ShowDialog()
                    End If
                    CheckBox5.Checked = False
                End If
            End If
        Catch ex As Exception
            If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
                fdialog.Label1.Text = "Load a save file first"
                fdialog.ShowDialog()
            End If
            If ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
                fdialog.Label1.Text = "Ouvrez une sauvegarde avant"
                fdialog.ShowDialog()
            End If
            CheckBox5.Checked = False
        End Try
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        Try
            If CheckBox6.Checked = True Then
                If ComboBox3.SelectedItem = ComboBox3.Items.Item(0) Then
                    Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                    For i As Integer = 0 To 24 Step 4
                        Writer.Position = &H5E8 + i
                        Writer.WriteUInt32(0)
                    Next
                    If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
                        fdialog.Label1.Text = "All levels of World 1 have been successfully deleted"
                        fdialog.ShowDialog()
                    End If
                    If ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
                        fdialog.Label1.Text = "Tous les niveaux du Monde 1 ont été supprimer avec succès"
                        fdialog.ShowDialog()
                    End If
                    CheckBox6.Checked = False
                End If
                If ComboBox3.SelectedItem = ComboBox3.Items.Item(1) Then
                    Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                    For i As Integer = 0 To 24 Step 4
                        Writer.Position = &H604 + i
                        Writer.WriteUInt32(0)
                    Next
                    If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
                        fdialog.Label1.Text = "All levels of World 2 have been successfully deleted"
                        fdialog.ShowDialog()
                    End If
                    If ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
                        fdialog.Label1.Text = "Tous les niveaux du Monde 2 ont été supprimer avec succès"
                        fdialog.ShowDialog()
                    End If
                    CheckBox6.Checked = False
                End If
                If ComboBox3.SelectedItem = ComboBox3.Items.Item(2) Then
                    Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                    For i As Integer = 0 To 24 Step 4
                        Writer.Position = &H620 + i
                        Writer.WriteUInt32(0)
                    Next
                    If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
                        fdialog.Label1.Text = "All levels of World 3 have been successfully deleted"
                        fdialog.ShowDialog()
                    End If
                    If ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
                        fdialog.Label1.Text = "Tous les niveaux du Monde 3 ont été supprimer avec succès"
                        fdialog.ShowDialog()
                    End If
                    CheckBox6.Checked = False
                End If
                If ComboBox3.SelectedItem = ComboBox3.Items.Item(3) Then
                    Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                    For i As Integer = 0 To 24 Step 4
                        Writer.Position = &H63C + i
                        Writer.WriteUInt32(0)
                    Next
                    If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
                        fdialog.Label1.Text = "All levels of World 4 have been successfully deleted"
                        fdialog.ShowDialog()
                    End If
                    If ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
                        fdialog.Label1.Text = "Tous les niveaux du Monde 4 ont été supprimer avec succès"
                        fdialog.ShowDialog()
                    End If
                    CheckBox6.Checked = False
                End If
                If ComboBox3.SelectedItem = ComboBox3.Items.Item(4) Then
                    Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                    For i As Integer = 0 To 24 Step 4
                        Writer.Position = &H658 + i
                        Writer.WriteUInt32(0)
                    Next
                    If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
                        fdialog.Label1.Text = "All levels of World 5 have been successfully deleted"
                        fdialog.ShowDialog()
                    End If
                    If ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
                        fdialog.Label1.Text = "Tous les niveaux du Monde 5 ont été supprimer avec succès"
                        fdialog.ShowDialog()
                    End If
                    CheckBox6.Checked = False
                End If
                If ComboBox3.SelectedItem = ComboBox3.Items.Item(5) Then
                    Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                    For i As Integer = 0 To 24 Step 4
                        Writer.Position = &H674 + i
                        Writer.WriteUInt32(0)
                    Next
                    If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
                        fdialog.Label1.Text = "All levels of World 6 have been successfully deleted"
                        fdialog.ShowDialog()
                    End If
                    If ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
                        fdialog.Label1.Text = "Tous les niveaux du Monde 6 ont été supprimer avec succès"
                        fdialog.ShowDialog()
                    End If
                    CheckBox6.Checked = False
                End If
                If ComboBox3.SelectedItem = ComboBox3.Items.Item(6) Then
                    Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                    For i As Integer = 0 To 24 Step 4
                        Writer.Position = &H690 + i
                        Writer.WriteUInt32(0)
                    Next
                    If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
                        fdialog.Label1.Text = "All levels of World 7 have been successfully deleted"
                        fdialog.ShowDialog()
                    End If
                    If ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
                        fdialog.Label1.Text = "Tous les niveaux du Monde 7 ont été supprimer avec succès"
                        fdialog.ShowDialog()
                    End If
                    CheckBox6.Checked = False
                End If
            End If
        Catch ex As Exception
            If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
                fdialog.Label1.Text = "Load a save file first"
                fdialog.ShowDialog()
            End If
            If ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
                fdialog.Label1.Text = "Ouvrez une sauvegarde avant"
                fdialog.ShowDialog()
            End If
            CheckBox6.Checked = False
        End Try
    End Sub
End Class
