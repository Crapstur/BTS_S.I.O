<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Exercice_7_bis
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ButtonFermer = New System.Windows.Forms.Button()
        Me.ButtonEffacer = New System.Windows.Forms.Button()
        Me.TextBoxAffSalBrut = New System.Windows.Forms.TextBox()
        Me.TextBoxSalBrute = New System.Windows.Forms.TextBox()
        Me.ListBoxTxHoraire = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ButtonCalculer = New System.Windows.Forms.Button()
        Me.ListBoxSalBrut = New System.Windows.Forms.ListBox()
        Me.ListBoxMtH50 = New System.Windows.Forms.ListBox()
        Me.ListBoxMtH25 = New System.Windows.Forms.ListBox()
        Me.ListBoxNbH50 = New System.Windows.Forms.ListBox()
        Me.ListBoxNbH25 = New System.Windows.Forms.ListBox()
        Me.ListBoxSalBase = New System.Windows.Forms.ListBox()
        Me.ListBoxNbHMois = New System.Windows.Forms.ListBox()
        Me.ListBoxPrenom = New System.Windows.Forms.ListBox()
        Me.ListBoxNom = New System.Windows.Forms.ListBox()
        Me.TextBoxSalBrut = New System.Windows.Forms.TextBox()
        Me.TextBoxMtH50 = New System.Windows.Forms.TextBox()
        Me.TextBoxMtH25 = New System.Windows.Forms.TextBox()
        Me.TextBoxNbH50 = New System.Windows.Forms.TextBox()
        Me.TextBoxNbH25 = New System.Windows.Forms.TextBox()
        Me.TextBoxSalBase = New System.Windows.Forms.TextBox()
        Me.TextBoxNbHMois = New System.Windows.Forms.TextBox()
        Me.TextBoxNom = New System.Windows.Forms.TextBox()
        Me.TextBoxPrenom = New System.Windows.Forms.TextBox()
        Me.GroupBox1Debut = New System.Windows.Forms.GroupBox()
        Me.LabelPrenomRepr = New System.Windows.Forms.Label()
        Me.LabelNomRepr = New System.Windows.Forms.Label()
        Me.LabelRepr = New System.Windows.Forms.Label()
        Me.ButtonAfficher = New System.Windows.Forms.Button()
        Me.ButtonEnregistrer = New System.Windows.Forms.Button()
        Me.TextBoxNbrH50 = New System.Windows.Forms.TextBox()
        Me.TextBoxNbrH25 = New System.Windows.Forms.TextBox()
        Me.LabelNbrH50 = New System.Windows.Forms.Label()
        Me.LabelNbrH25 = New System.Windows.Forms.Label()
        Me.GroupBox1Debut.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonFermer
        '
        Me.ButtonFermer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonFermer.Location = New System.Drawing.Point(866, 300)
        Me.ButtonFermer.Name = "ButtonFermer"
        Me.ButtonFermer.Size = New System.Drawing.Size(102, 36)
        Me.ButtonFermer.TabIndex = 51
        Me.ButtonFermer.Text = "Fermer"
        Me.ButtonFermer.UseVisualStyleBackColor = False
        '
        'ButtonEffacer
        '
        Me.ButtonEffacer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonEffacer.Location = New System.Drawing.Point(866, 214)
        Me.ButtonEffacer.Name = "ButtonEffacer"
        Me.ButtonEffacer.Size = New System.Drawing.Size(102, 36)
        Me.ButtonEffacer.TabIndex = 50
        Me.ButtonEffacer.Text = "Effacer"
        Me.ButtonEffacer.UseVisualStyleBackColor = False
        '
        'TextBoxAffSalBrut
        '
        Me.TextBoxAffSalBrut.BackColor = System.Drawing.Color.White
        Me.TextBoxAffSalBrut.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAffSalBrut.Location = New System.Drawing.Point(878, 169)
        Me.TextBoxAffSalBrut.Name = "TextBoxAffSalBrut"
        Me.TextBoxAffSalBrut.ReadOnly = True
        Me.TextBoxAffSalBrut.Size = New System.Drawing.Size(90, 23)
        Me.TextBoxAffSalBrut.TabIndex = 49
        '
        'TextBoxSalBrute
        '
        Me.TextBoxSalBrute.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSalBrute.Location = New System.Drawing.Point(739, 169)
        Me.TextBoxSalBrute.Name = "TextBoxSalBrute"
        Me.TextBoxSalBrute.ReadOnly = True
        Me.TextBoxSalBrute.Size = New System.Drawing.Size(133, 23)
        Me.TextBoxSalBrute.TabIndex = 48
        Me.TextBoxSalBrute.Text = "Total salaire brut :"
        '
        'ListBoxTxHoraire
        '
        Me.ListBoxTxHoraire.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxTxHoraire.FormattingEnabled = True
        Me.ListBoxTxHoraire.ItemHeight = 16
        Me.ListBoxTxHoraire.Location = New System.Drawing.Point(302, 79)
        Me.ListBoxTxHoraire.Name = "ListBoxTxHoraire"
        Me.ListBoxTxHoraire.Size = New System.Drawing.Size(90, 84)
        Me.ListBoxTxHoraire.TabIndex = 47
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(302, 50)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(90, 23)
        Me.TextBox1.TabIndex = 46
        Me.TextBox1.Text = "Tx horaire"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ButtonCalculer
        '
        Me.ButtonCalculer.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonCalculer.Location = New System.Drawing.Point(743, 214)
        Me.ButtonCalculer.Name = "ButtonCalculer"
        Me.ButtonCalculer.Size = New System.Drawing.Size(102, 36)
        Me.ButtonCalculer.TabIndex = 45
        Me.ButtonCalculer.Text = "Calculer"
        Me.ButtonCalculer.UseVisualStyleBackColor = False
        '
        'ListBoxSalBrut
        '
        Me.ListBoxSalBrut.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxSalBrut.FormattingEnabled = True
        Me.ListBoxSalBrut.ItemHeight = 16
        Me.ListBoxSalBrut.Location = New System.Drawing.Point(878, 79)
        Me.ListBoxSalBrut.Name = "ListBoxSalBrut"
        Me.ListBoxSalBrut.Size = New System.Drawing.Size(90, 84)
        Me.ListBoxSalBrut.TabIndex = 44
        '
        'ListBoxMtH50
        '
        Me.ListBoxMtH50.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxMtH50.FormattingEnabled = True
        Me.ListBoxMtH50.ItemHeight = 16
        Me.ListBoxMtH50.Location = New System.Drawing.Point(782, 79)
        Me.ListBoxMtH50.Name = "ListBoxMtH50"
        Me.ListBoxMtH50.Size = New System.Drawing.Size(90, 84)
        Me.ListBoxMtH50.TabIndex = 43
        '
        'ListBoxMtH25
        '
        Me.ListBoxMtH25.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxMtH25.FormattingEnabled = True
        Me.ListBoxMtH25.ItemHeight = 16
        Me.ListBoxMtH25.Location = New System.Drawing.Point(686, 79)
        Me.ListBoxMtH25.Name = "ListBoxMtH25"
        Me.ListBoxMtH25.Size = New System.Drawing.Size(90, 84)
        Me.ListBoxMtH25.TabIndex = 42
        '
        'ListBoxNbH50
        '
        Me.ListBoxNbH50.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxNbH50.FormattingEnabled = True
        Me.ListBoxNbH50.ItemHeight = 16
        Me.ListBoxNbH50.Location = New System.Drawing.Point(590, 79)
        Me.ListBoxNbH50.Name = "ListBoxNbH50"
        Me.ListBoxNbH50.Size = New System.Drawing.Size(90, 84)
        Me.ListBoxNbH50.TabIndex = 41
        '
        'ListBoxNbH25
        '
        Me.ListBoxNbH25.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxNbH25.FormattingEnabled = True
        Me.ListBoxNbH25.ItemHeight = 16
        Me.ListBoxNbH25.Location = New System.Drawing.Point(494, 79)
        Me.ListBoxNbH25.Name = "ListBoxNbH25"
        Me.ListBoxNbH25.Size = New System.Drawing.Size(90, 84)
        Me.ListBoxNbH25.TabIndex = 40
        '
        'ListBoxSalBase
        '
        Me.ListBoxSalBase.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxSalBase.FormattingEnabled = True
        Me.ListBoxSalBase.ItemHeight = 16
        Me.ListBoxSalBase.Location = New System.Drawing.Point(398, 79)
        Me.ListBoxSalBase.Name = "ListBoxSalBase"
        Me.ListBoxSalBase.Size = New System.Drawing.Size(90, 84)
        Me.ListBoxSalBase.TabIndex = 39
        '
        'ListBoxNbHMois
        '
        Me.ListBoxNbHMois.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxNbHMois.FormattingEnabled = True
        Me.ListBoxNbHMois.ItemHeight = 16
        Me.ListBoxNbHMois.Location = New System.Drawing.Point(206, 79)
        Me.ListBoxNbHMois.Name = "ListBoxNbHMois"
        Me.ListBoxNbHMois.Size = New System.Drawing.Size(90, 84)
        Me.ListBoxNbHMois.TabIndex = 38
        '
        'ListBoxPrenom
        '
        Me.ListBoxPrenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxPrenom.FormattingEnabled = True
        Me.ListBoxPrenom.ItemHeight = 16
        Me.ListBoxPrenom.Location = New System.Drawing.Point(110, 79)
        Me.ListBoxPrenom.Name = "ListBoxPrenom"
        Me.ListBoxPrenom.Size = New System.Drawing.Size(90, 84)
        Me.ListBoxPrenom.TabIndex = 37
        '
        'ListBoxNom
        '
        Me.ListBoxNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxNom.FormattingEnabled = True
        Me.ListBoxNom.ItemHeight = 16
        Me.ListBoxNom.Location = New System.Drawing.Point(14, 79)
        Me.ListBoxNom.Name = "ListBoxNom"
        Me.ListBoxNom.Size = New System.Drawing.Size(90, 84)
        Me.ListBoxNom.TabIndex = 36
        '
        'TextBoxSalBrut
        '
        Me.TextBoxSalBrut.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSalBrut.Location = New System.Drawing.Point(878, 50)
        Me.TextBoxSalBrut.Name = "TextBoxSalBrut"
        Me.TextBoxSalBrut.ReadOnly = True
        Me.TextBoxSalBrut.Size = New System.Drawing.Size(90, 23)
        Me.TextBoxSalBrut.TabIndex = 35
        Me.TextBoxSalBrut.Text = "Salaire Brut"
        Me.TextBoxSalBrut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxMtH50
        '
        Me.TextBoxMtH50.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxMtH50.Location = New System.Drawing.Point(782, 50)
        Me.TextBoxMtH50.Name = "TextBoxMtH50"
        Me.TextBoxMtH50.ReadOnly = True
        Me.TextBoxMtH50.Size = New System.Drawing.Size(90, 23)
        Me.TextBoxMtH50.TabIndex = 34
        Me.TextBoxMtH50.Text = "Mt H 50%"
        Me.TextBoxMtH50.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxMtH25
        '
        Me.TextBoxMtH25.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxMtH25.Location = New System.Drawing.Point(686, 50)
        Me.TextBoxMtH25.Name = "TextBoxMtH25"
        Me.TextBoxMtH25.ReadOnly = True
        Me.TextBoxMtH25.Size = New System.Drawing.Size(90, 23)
        Me.TextBoxMtH25.TabIndex = 33
        Me.TextBoxMtH25.Text = "Mt H 25%"
        Me.TextBoxMtH25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxNbH50
        '
        Me.TextBoxNbH50.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNbH50.Location = New System.Drawing.Point(590, 50)
        Me.TextBoxNbH50.Name = "TextBoxNbH50"
        Me.TextBoxNbH50.ReadOnly = True
        Me.TextBoxNbH50.Size = New System.Drawing.Size(90, 23)
        Me.TextBoxNbH50.TabIndex = 32
        Me.TextBoxNbH50.Text = "Nb H 50%"
        Me.TextBoxNbH50.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxNbH25
        '
        Me.TextBoxNbH25.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNbH25.Location = New System.Drawing.Point(494, 50)
        Me.TextBoxNbH25.Name = "TextBoxNbH25"
        Me.TextBoxNbH25.ReadOnly = True
        Me.TextBoxNbH25.Size = New System.Drawing.Size(90, 23)
        Me.TextBoxNbH25.TabIndex = 31
        Me.TextBoxNbH25.Text = "Nb H 25%"
        Me.TextBoxNbH25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxSalBase
        '
        Me.TextBoxSalBase.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSalBase.Location = New System.Drawing.Point(398, 50)
        Me.TextBoxSalBase.Name = "TextBoxSalBase"
        Me.TextBoxSalBase.ReadOnly = True
        Me.TextBoxSalBase.Size = New System.Drawing.Size(90, 23)
        Me.TextBoxSalBase.TabIndex = 30
        Me.TextBoxSalBase.Text = "Salaire base"
        Me.TextBoxSalBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxNbHMois
        '
        Me.TextBoxNbHMois.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNbHMois.Location = New System.Drawing.Point(206, 50)
        Me.TextBoxNbHMois.Name = "TextBoxNbHMois"
        Me.TextBoxNbHMois.ReadOnly = True
        Me.TextBoxNbHMois.Size = New System.Drawing.Size(90, 23)
        Me.TextBoxNbHMois.TabIndex = 29
        Me.TextBoxNbHMois.Text = "Nb H / mois"
        Me.TextBoxNbHMois.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxNom
        '
        Me.TextBoxNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNom.Location = New System.Drawing.Point(14, 50)
        Me.TextBoxNom.Name = "TextBoxNom"
        Me.TextBoxNom.ReadOnly = True
        Me.TextBoxNom.Size = New System.Drawing.Size(90, 23)
        Me.TextBoxNom.TabIndex = 28
        Me.TextBoxNom.Text = "Nom"
        Me.TextBoxNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxPrenom
        '
        Me.TextBoxPrenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPrenom.Location = New System.Drawing.Point(110, 50)
        Me.TextBoxPrenom.Name = "TextBoxPrenom"
        Me.TextBoxPrenom.ReadOnly = True
        Me.TextBoxPrenom.Size = New System.Drawing.Size(90, 23)
        Me.TextBoxPrenom.TabIndex = 27
        Me.TextBoxPrenom.Text = "Prenom"
        Me.TextBoxPrenom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1Debut
        '
        Me.GroupBox1Debut.Controls.Add(Me.LabelPrenomRepr)
        Me.GroupBox1Debut.Controls.Add(Me.LabelNomRepr)
        Me.GroupBox1Debut.Controls.Add(Me.LabelRepr)
        Me.GroupBox1Debut.Controls.Add(Me.ButtonAfficher)
        Me.GroupBox1Debut.Controls.Add(Me.ButtonEnregistrer)
        Me.GroupBox1Debut.Controls.Add(Me.TextBoxNbrH50)
        Me.GroupBox1Debut.Controls.Add(Me.TextBoxNbrH25)
        Me.GroupBox1Debut.Controls.Add(Me.LabelNbrH50)
        Me.GroupBox1Debut.Controls.Add(Me.LabelNbrH25)
        Me.GroupBox1Debut.Location = New System.Drawing.Point(53, 361)
        Me.GroupBox1Debut.Name = "GroupBox1Debut"
        Me.GroupBox1Debut.Size = New System.Drawing.Size(886, 419)
        Me.GroupBox1Debut.TabIndex = 52
        Me.GroupBox1Debut.TabStop = False
        Me.GroupBox1Debut.Visible = False
        '
        'LabelPrenomRepr
        '
        Me.LabelPrenomRepr.AutoSize = True
        Me.LabelPrenomRepr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPrenomRepr.Location = New System.Drawing.Point(432, 57)
        Me.LabelPrenomRepr.Name = "LabelPrenomRepr"
        Me.LabelPrenomRepr.Size = New System.Drawing.Size(57, 17)
        Me.LabelPrenomRepr.TabIndex = 59
        Me.LabelPrenomRepr.Text = "Prenom"
        '
        'LabelNomRepr
        '
        Me.LabelNomRepr.AutoSize = True
        Me.LabelNomRepr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNomRepr.Location = New System.Drawing.Point(375, 57)
        Me.LabelNomRepr.Name = "LabelNomRepr"
        Me.LabelNomRepr.Size = New System.Drawing.Size(37, 17)
        Me.LabelNomRepr.TabIndex = 58
        Me.LabelNomRepr.Text = "Nom"
        '
        'LabelRepr
        '
        Me.LabelRepr.AutoSize = True
        Me.LabelRepr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRepr.Location = New System.Drawing.Point(253, 57)
        Me.LabelRepr.Name = "LabelRepr"
        Me.LabelRepr.Size = New System.Drawing.Size(116, 17)
        Me.LabelRepr.TabIndex = 57
        Me.LabelRepr.Text = "Représentant :"
        '
        'ButtonAfficher
        '
        Me.ButtonAfficher.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonAfficher.Location = New System.Drawing.Point(537, 189)
        Me.ButtonAfficher.Name = "ButtonAfficher"
        Me.ButtonAfficher.Size = New System.Drawing.Size(102, 36)
        Me.ButtonAfficher.TabIndex = 56
        Me.ButtonAfficher.Text = "Afficher"
        Me.ButtonAfficher.UseVisualStyleBackColor = False
        '
        'ButtonEnregistrer
        '
        Me.ButtonEnregistrer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonEnregistrer.Location = New System.Drawing.Point(400, 189)
        Me.ButtonEnregistrer.Name = "ButtonEnregistrer"
        Me.ButtonEnregistrer.Size = New System.Drawing.Size(102, 36)
        Me.ButtonEnregistrer.TabIndex = 55
        Me.ButtonEnregistrer.Text = "Enregistrer"
        Me.ButtonEnregistrer.UseVisualStyleBackColor = False
        '
        'TextBoxNbrH50
        '
        Me.TextBoxNbrH50.Location = New System.Drawing.Point(375, 127)
        Me.TextBoxNbrH50.Name = "TextBoxNbrH50"
        Me.TextBoxNbrH50.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNbrH50.TabIndex = 54
        '
        'TextBoxNbrH25
        '
        Me.TextBoxNbrH25.Location = New System.Drawing.Point(375, 87)
        Me.TextBoxNbrH25.Name = "TextBoxNbrH25"
        Me.TextBoxNbrH25.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNbrH25.TabIndex = 53
        '
        'LabelNbrH50
        '
        Me.LabelNbrH50.AutoSize = True
        Me.LabelNbrH50.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNbrH50.Location = New System.Drawing.Point(81, 128)
        Me.LabelNbrH50.Name = "LabelNbrH50"
        Me.LabelNbrH50.Size = New System.Drawing.Size(288, 17)
        Me.LabelNbrH50.TabIndex = 1
        Me.LabelNbrH50.Text = "Saisir le nombre d'heure majorées de 50 % :"
        '
        'LabelNbrH25
        '
        Me.LabelNbrH25.AutoSize = True
        Me.LabelNbrH25.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNbrH25.Location = New System.Drawing.Point(81, 88)
        Me.LabelNbrH25.Name = "LabelNbrH25"
        Me.LabelNbrH25.Size = New System.Drawing.Size(288, 17)
        Me.LabelNbrH25.TabIndex = 0
        Me.LabelNbrH25.Text = "Saisir le nombre d'heure majorées de 25 % :"
        '
        'Exercice_7_bis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1157, 806)
        Me.Controls.Add(Me.GroupBox1Debut)
        Me.Controls.Add(Me.ButtonFermer)
        Me.Controls.Add(Me.ButtonEffacer)
        Me.Controls.Add(Me.TextBoxAffSalBrut)
        Me.Controls.Add(Me.TextBoxSalBrute)
        Me.Controls.Add(Me.ListBoxTxHoraire)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ButtonCalculer)
        Me.Controls.Add(Me.ListBoxSalBrut)
        Me.Controls.Add(Me.ListBoxMtH50)
        Me.Controls.Add(Me.ListBoxMtH25)
        Me.Controls.Add(Me.ListBoxNbH50)
        Me.Controls.Add(Me.ListBoxNbH25)
        Me.Controls.Add(Me.ListBoxSalBase)
        Me.Controls.Add(Me.ListBoxNbHMois)
        Me.Controls.Add(Me.ListBoxPrenom)
        Me.Controls.Add(Me.ListBoxNom)
        Me.Controls.Add(Me.TextBoxSalBrut)
        Me.Controls.Add(Me.TextBoxMtH50)
        Me.Controls.Add(Me.TextBoxMtH25)
        Me.Controls.Add(Me.TextBoxNbH50)
        Me.Controls.Add(Me.TextBoxNbH25)
        Me.Controls.Add(Me.TextBoxSalBase)
        Me.Controls.Add(Me.TextBoxNbHMois)
        Me.Controls.Add(Me.TextBoxNom)
        Me.Controls.Add(Me.TextBoxPrenom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Exercice_7_bis"
        Me.Text = "Exercice_7_bis"
        Me.GroupBox1Debut.ResumeLayout(False)
        Me.GroupBox1Debut.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonFermer As Button
    Friend WithEvents ButtonEffacer As Button
    Friend WithEvents TextBoxAffSalBrut As TextBox
    Friend WithEvents TextBoxSalBrute As TextBox
    Friend WithEvents ListBoxTxHoraire As ListBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ButtonCalculer As Button
    Friend WithEvents ListBoxSalBrut As ListBox
    Friend WithEvents ListBoxMtH50 As ListBox
    Friend WithEvents ListBoxMtH25 As ListBox
    Friend WithEvents ListBoxNbH50 As ListBox
    Friend WithEvents ListBoxNbH25 As ListBox
    Friend WithEvents ListBoxSalBase As ListBox
    Friend WithEvents ListBoxNbHMois As ListBox
    Friend WithEvents ListBoxPrenom As ListBox
    Friend WithEvents ListBoxNom As ListBox
    Friend WithEvents TextBoxSalBrut As TextBox
    Friend WithEvents TextBoxMtH50 As TextBox
    Friend WithEvents TextBoxMtH25 As TextBox
    Friend WithEvents TextBoxNbH50 As TextBox
    Friend WithEvents TextBoxNbH25 As TextBox
    Friend WithEvents TextBoxSalBase As TextBox
    Friend WithEvents TextBoxNbHMois As TextBox
    Friend WithEvents TextBoxNom As TextBox
    Friend WithEvents TextBoxPrenom As TextBox
    Friend WithEvents GroupBox1Debut As GroupBox
    Friend WithEvents TextBoxNbrH50 As TextBox
    Friend WithEvents TextBoxNbrH25 As TextBox
    Friend WithEvents LabelNbrH50 As Label
    Friend WithEvents LabelNbrH25 As Label
    Friend WithEvents ButtonAfficher As Button
    Friend WithEvents ButtonEnregistrer As Button
    Friend WithEvents LabelRepr As Label
    Friend WithEvents LabelNomRepr As Label
    Friend WithEvents LabelPrenomRepr As Label
End Class
