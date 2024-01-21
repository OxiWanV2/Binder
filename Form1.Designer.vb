<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.categorie = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.open_picture = New System.Windows.Forms.PictureBox()
        Me.del_picture = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.loading = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnChoisirFichier = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.open_picture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.del_picture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(16, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Binder"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(-1, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(844, 1)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(0, 42)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1, 844)
        Me.Panel2.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(112, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "V1.4"
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(-3, 449)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(844, 1)
        Me.Panel3.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(799, 42)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1, 844)
        Me.Panel4.TabIndex = 3
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Panel5.Controls.Add(Me.loading)
        Me.Panel5.Controls.Add(Me.Button7)
        Me.Panel5.Controls.Add(Me.Button6)
        Me.Panel5.Controls.Add(Me.Button4)
        Me.Panel5.Controls.Add(Me.btnChoisirFichier)
        Me.Panel5.Controls.Add(Me.Button1)
        Me.Panel5.Location = New System.Drawing.Point(1, 44)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(799, 49)
        Me.Panel5.TabIndex = 6
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Panel6.Controls.Add(Me.TextBox1)
        Me.Panel6.Controls.Add(Me.Button3)
        Me.Panel6.Controls.Add(Me.Button2)
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Location = New System.Drawing.Point(10, 107)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(780, 29)
        Me.Panel6.TabIndex = 7
        Me.Panel6.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(16, 9)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(300, 13)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "Nom du fichier"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.Location = New System.Drawing.Point(9, 5)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1, 20)
        Me.Panel7.TabIndex = 4
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'categorie
        '
        Me.categorie.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.categorie.AutoSize = True
        Me.categorie.ForeColor = System.Drawing.Color.White
        Me.categorie.Location = New System.Drawing.Point(374, 17)
        Me.categorie.Name = "categorie"
        Me.categorie.Size = New System.Drawing.Size(98, 13)
        Me.categorie.TabIndex = 2
        Me.categorie.Text = "Traitement de texte"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(10, 100)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(777, 347)
        Me.FlowLayoutPanel1.TabIndex = 8
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox4.Image = Global.Binder.My.Resources.Resources.icons8_réduire_la_fenêtre_48
        Me.PictureBox4.Location = New System.Drawing.Point(668, 7)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(36, 33)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 12
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox3.Image = Global.Binder.My.Resources.Resources.icons8_restaurer_la_fenêtre_48
        Me.PictureBox3.Location = New System.Drawing.Point(710, 7)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(36, 33)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 11
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'Button5
        '
        Me.Button5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Button5.BackgroundImage = Global.Binder.My.Resources.Resources.icons8_liste_48
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(346, 12)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(22, 22)
        Me.Button5.TabIndex = 10
        Me.Button5.UseVisualStyleBackColor = False
        '
        'open_picture
        '
        Me.open_picture.Image = Global.Binder.My.Resources.Resources.open
        Me.open_picture.Location = New System.Drawing.Point(405, 12)
        Me.open_picture.Name = "open_picture"
        Me.open_picture.Size = New System.Drawing.Size(25, 14)
        Me.open_picture.TabIndex = 9
        Me.open_picture.TabStop = False
        Me.open_picture.Visible = False
        '
        'del_picture
        '
        Me.del_picture.Image = Global.Binder.My.Resources.Resources.remove__1_
        Me.del_picture.Location = New System.Drawing.Point(374, 12)
        Me.del_picture.Name = "del_picture"
        Me.del_picture.Size = New System.Drawing.Size(25, 14)
        Me.del_picture.TabIndex = 2
        Me.del_picture.TabStop = False
        Me.del_picture.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox2.Image = Global.Binder.My.Resources.Resources.icons8_fermer_48
        Me.PictureBox2.Location = New System.Drawing.Point(752, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(36, 33)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.PictureBox1.Image = Global.Binder.My.Resources.Resources.icons8_maximiser_la_fenêtre_48
        Me.PictureBox1.Location = New System.Drawing.Point(710, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 33)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'loading
        '
        Me.loading.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.loading.BackgroundImage = Global.Binder.My.Resources.Resources.ZZ5H
        Me.loading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.loading.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loading.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.loading.Location = New System.Drawing.Point(706, 4)
        Me.loading.Name = "loading"
        Me.loading.Size = New System.Drawing.Size(45, 40)
        Me.loading.TabIndex = 5
        Me.loading.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackgroundImage = CType(resources.GetObject("Button7.BackgroundImage"), System.Drawing.Image)
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Button7.Location = New System.Drawing.Point(146, 5)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(45, 40)
        Me.Button7.TabIndex = 4
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackgroundImage = Global.Binder.My.Resources.Resources.icons8_bleu_blockly_48
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Button6.Location = New System.Drawing.Point(97, 3)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(43, 42)
        Me.Button6.TabIndex = 3
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.Binder.My.Resources.Resources.icons8_éditeur_de_registre_48
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(50, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(41, 42)
        Me.Button4.TabIndex = 2
        Me.Button4.UseVisualStyleBackColor = False
        '
        'btnChoisirFichier
        '
        Me.btnChoisirFichier.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnChoisirFichier.BackgroundImage = Global.Binder.My.Resources.Resources.icons8_importer_48
        Me.btnChoisirFichier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnChoisirFichier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChoisirFichier.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnChoisirFichier.Location = New System.Drawing.Point(757, 5)
        Me.btnChoisirFichier.Name = "btnChoisirFichier"
        Me.btnChoisirFichier.Size = New System.Drawing.Size(32, 42)
        Me.btnChoisirFichier.TabIndex = 1
        Me.btnChoisirFichier.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(10, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 42)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackgroundImage = Global.Binder.My.Resources.Resources.icons8_effacer_48
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(716, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(22, 22)
        Me.Button3.TabIndex = 9
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackgroundImage = Global.Binder.My.Resources.Resources.icons8_ouvrir_48
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(744, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(29, 22)
        Me.Button2.TabIndex = 1
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.categorie)
        Me.Controls.Add(Me.open_picture)
        Me.Controls.Add(Me.del_picture)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Panel6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Binder"
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.open_picture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.del_picture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnChoisirFichier As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents categorie As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents del_picture As PictureBox
    Friend WithEvents open_picture As PictureBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents loading As Button
End Class
