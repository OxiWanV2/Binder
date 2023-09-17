Imports Microsoft.VisualBasic.Devices
Imports System.IO
Imports Newtonsoft.Json
Imports System.Collections.Generic
Imports System.Reflection.Emit

Public Class Form1
    Private drag As Boolean = True
    Private isDragging As Boolean = False
    Private clickX As Integer
    Private clickY As Integer
    Dim listeFichiers As List(Of FichierWordInfo) = ChargerListeFichiers()
    Private listeFormulaires As New List(Of Form)

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If drag = True Then
            If e.Button = MouseButtons.Left Then
                isDragging = True
                clickX = e.X
                clickY = e.Y
            End If
        End If
    End Sub

    Private Sub PictureBox3_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If drag = True Then
            If isDragging Then
                Me.Location = New Point(Me.Location.X + (e.X - clickX), Me.Location.Y + (e.Y - clickY))
            End If
        End If
    End Sub

    Private Sub PictureBox3_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        If drag = True Then
            If e.Button = MouseButtons.Left Then
                isDragging = False
            End If
        End If
    End Sub

    Private Sub PictureBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseClick
        WindowState = FormWindowState.Maximized
        MettreAJourListeFichiersAffiches()
        drag = False
        Panel4.Visible = False
        Panel3.Visible = False
        Panel2.Visible = False
        PictureBox4.Visible = False
        PictureBox1.Visible = False
        PictureBox3.Visible = True
    End Sub

    Private Sub PictureBox3_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseClick
        WindowState = FormWindowState.Normal
        MettreAJourListeFichiersAffiches()
        drag = True
        Panel4.Visible = True
        Panel3.Visible = True
        Panel2.Visible = True
        PictureBox4.Visible = True
        PictureBox1.Visible = True
        PictureBox3.Visible = False
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox2_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseClick
        Close()
    End Sub
    Private cheminJSON As String = "C:\Users\" + Environment.UserName + "\AppData\Local\Binder\path.json"

    Private Sub BtnChoisirFichier_Click(sender As Object, e As EventArgs) Handles btnChoisirFichier.Click
        loading.Visible = True
        Dim openFileDialog As New OpenFileDialog()

        openFileDialog.Filter = "Fichiers Word (*.docx)|*.docx"
        openFileDialog.Title = "Sélectionner un fichier Word"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim nomFichier As String = Path.GetFileName(openFileDialog.FileName)
            Dim cheminFichier As String = openFileDialog.FileName
            Dim listeFichiers As List(Of FichierWordInfo) = ChargerListeFichiers()

            Dim fichierInfo As New FichierWordInfo()
            fichierInfo.Nom = nomFichier
            fichierInfo.Chemin = cheminFichier
            fichierInfo.Categorie = categorie.Text

            listeFichiers.Add(fichierInfo)

            Dim listeFichiersJSON As String = JsonConvert.SerializeObject(listeFichiers)

            If Directory.Exists("C:\Users\" & Environment.UserName & "\AppData\Local\Binder") Then
                File.WriteAllText(cheminJSON, listeFichiersJSON)
            Else
                Directory.CreateDirectory("C:\Users\" & Environment.UserName & "\AppData\Local\Binder")
                File.WriteAllText(cheminJSON, listeFichiersJSON)
            End If
            MettreAJourListeFichiersAffiches()
        End If
        loading.Visible = False
    End Sub

    Private Function ChargerListeFichiers() As List(Of FichierWordInfo)
        Dim listeFichiers As New List(Of FichierWordInfo)()

        If File.Exists(cheminJSON) Then
            Dim listeFichiersJSON As String = File.ReadAllText(cheminJSON)
            listeFichiers = JsonConvert.DeserializeObject(Of List(Of FichierWordInfo))(listeFichiersJSON)
        End If

        Return listeFichiers
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MettreAJourListeFichiersAffiches()
        loading.Visible = False
    End Sub

    Private Sub SupprimerFichierEtForme(sender As Object, e As MouseEventArgs)
        Dim boutonSupprimer As Button = DirectCast(sender, Button)
        Dim nomFichier As String = boutonSupprimer.Tag.ToString()

        Dim fichierInfo As FichierWordInfo = listeFichiers.FirstOrDefault(Function(f) f.Nom = nomFichier)
        If fichierInfo IsNot Nothing Then
            listeFichiers.Remove(fichierInfo)
            SauvegarderListeFichiers(listeFichiers)
        End If

        Dim formulaireAssocie = listeFormulaires.FirstOrDefault(Function(f) f.Text = nomFichier)
        If formulaireAssocie IsNot Nothing Then
            formulaireAssocie.Close()
            listeFormulaires.Remove(formulaireAssocie)
        End If

        Dim parentPanel As Panel = DirectCast(boutonSupprimer.Parent, Panel)
        FlowLayoutPanel1.Controls.Remove(parentPanel)
    End Sub



    Private Sub SauvegarderListeFichiers(listeFichiers As List(Of FichierWordInfo))
        If listeFichiers IsNot Nothing AndAlso listeFichiers.Count > 0 Then
            Dim cheminJSON As String = "C:\Users\" & Environment.UserName & "\AppData\Local\Binder\path.json"

            Dim listeFichiersDict As New List(Of Dictionary(Of String, String))

            For Each fichierInfo As FichierWordInfo In listeFichiers
                Dim fichierDict As New Dictionary(Of String, String)
                fichierDict("Nom") = fichierInfo.Nom
                fichierDict("Chemin") = fichierInfo.Chemin
                fichierDict("Categorie") = fichierInfo.Categorie
                listeFichiersDict.Add(fichierDict)
            Next

            Dim listeFichiersJSON As String = JsonConvert.SerializeObject(listeFichiersDict)

            File.WriteAllText(cheminJSON, listeFichiersJSON)
        Else
            File.Delete("C:\Users\" & Environment.UserName & "\AppData\Local\Binder\path.json")
        End If
    End Sub


    Private Sub OuvrirFichierWord(sender As Object, e As MouseEventArgs)
        Dim boutonOuvrir As Button = DirectCast(sender, Button)
        Dim nomFichier As String = boutonOuvrir.Tag.ToString()

        Dim fichierInfo As FichierWordInfo = listeFichiers.FirstOrDefault(Function(f) f.Nom = nomFichier)

        If fichierInfo IsNot Nothing Then
            If File.Exists(fichierInfo.Chemin) Then
                Process.Start(fichierInfo.Chemin)
            Else
                MessageBox.Show("Le fichier n'existe pas.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
    Private Sub MettreAJourListeFichiersAffiches()
        loading.Visible = True
        FlowLayoutPanel1.Controls.Clear()

        listeFichiers = ChargerListeFichiers()

        Dim categorieFiltree = listeFichiers.Where(Function(f) f.Categorie = categorie.Text).ToList()

        For Each fichierInfo In categorieFiltree
            Dim nouveauPanel As New Panel()
            nouveauPanel.BorderStyle = Panel6.BorderStyle
            nouveauPanel.Size = Panel6.Size
            nouveauPanel.BackColor = Panel6.BackColor
            nouveauPanel.Location = Panel6.Location

            For Each ctrl As Control In Panel6.Controls
                If TypeOf ctrl Is Button Then
                    Dim nouveauBtn As New Button()
                    Dim originalBtn As Button = DirectCast(ctrl, Button)

                    nouveauBtn.Text = originalBtn.Text
                    nouveauBtn.Size = originalBtn.Size
                    nouveauBtn.BackgroundImageLayout = ImageLayout.Zoom
                    nouveauBtn.BackColor = Color.FromArgb(5, 6, 10)
                    nouveauBtn.ForeColor = Color.FromArgb(5, 6, 10)
                    nouveauBtn.FlatStyle = FlatStyle.Flat
                    nouveauBtn.Location = originalBtn.Location

                    If nouveauPanel.Controls.Count = 0 Then
                        nouveauBtn.BackgroundImage = del_picture.Image

                        AddHandler nouveauBtn.MouseClick, AddressOf SupprimerFichierEtForme
                        nouveauBtn.Tag = fichierInfo.Nom
                    Else
                        nouveauBtn.BackgroundImage = open_picture.Image
                        AddHandler nouveauBtn.MouseClick, AddressOf OuvrirFichierWord
                        nouveauBtn.Tag = fichierInfo.Nom
                    End If

                    nouveauPanel.Controls.Add(nouveauBtn)
                End If
            Next

            Dim originalPanel7 As Panel = Panel6.Controls.OfType(Of Panel)().FirstOrDefault()
            If originalPanel7 IsNot Nothing Then
                Dim nouveauPanel7 As New Panel()
                nouveauPanel7.Size = originalPanel7.Size
                nouveauPanel7.Location = originalPanel7.Location
                nouveauPanel7.BackColor = originalPanel7.BackColor

                nouveauPanel.Controls.Add(nouveauPanel7)
            End If

            Dim textBox As New TextBox()
            textBox.Text = fichierInfo.Nom
            textBox.ReadOnly = True
            textBox.BackColor = Color.FromArgb(5, 6, 10)
            textBox.ForeColor = Color.White
            textBox.BorderStyle = BorderStyle.None
            textBox.Size = New Size(250, 20)
            textBox.Location = New Point(16, 9)
            nouveauPanel.Controls.Add(textBox)

            FlowLayoutPanel1.Controls.Add(nouveauPanel)
        Next
        loading.Visible = False
    End Sub

    Private Sub Button6_MouseClick(sender As Object, e As MouseEventArgs) Handles Button6.MouseClick
        categorie.Text = "Scratch"
        MettreAJourListeFichiersAffiches()
    End Sub

    Private Sub Button4_MouseClick(sender As Object, e As MouseEventArgs) Handles Button4.MouseClick
        categorie.Text = "Binaire"
        MettreAJourListeFichiersAffiches()
    End Sub

    Private Sub Button1_MouseClick(sender As Object, e As MouseEventArgs) Handles Button1.MouseClick
        categorie.Text = "Traitement de texte"
        MettreAJourListeFichiersAffiches()
    End Sub

    Private Sub Button7_MouseClick(sender As Object, e As MouseEventArgs) Handles Button7.MouseClick
        categorie.Text = "Unité centrale"
        MettreAJourListeFichiersAffiches()
    End Sub
End Class
Public Class FichierWordInfo
    Public Property Nom As String
    Public Property Chemin As String
    Public Property Categorie As String
End Class