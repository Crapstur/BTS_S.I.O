<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Exercice_7
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
        Me.TextBoxPrenom = New System.Windows.Forms.TextBox()
        Me.TextBoxNom = New System.Windows.Forms.TextBox()
        Me.TextBoxNbHMois = New System.Windows.Forms.TextBox()
        Me.TextBoxSalBase = New System.Windows.Forms.TextBox()
        Me.TextBoxNbH25 = New System.Windows.Forms.TextBox()
        Me.TextBoxNbH50 = New System.Windows.Forms.TextBox()
        Me.TextBoxMtH25 = New System.Windows.Forms.TextBox()
        Me.TextBoxMtH50 = New System.Windows.Forms.TextBox()
        Me.TextBoxSalBrut = New System.Windows.Forms.TextBox()
        Me.ListBoxNom = New System.Windows.Forms.ListBox()
        Me.ListBoxPrenom = New System.Windows.Forms.ListBox()
        Me.ListBoxNbHMois = New System.Windows.Forms.ListBox()
        Me.ListBoxSalBase = New System.Windows.Forms.ListBox()
        Me.ListBoxNbH25 = New System.Windows.Forms.ListBox()
        Me.ListBoxNbH50 = New System.Windows.Forms.ListBox()
        Me.ListBoxMtH25 = New System.Windows.Forms.ListBox()
        Me.ListBoxMtH50 = New System.Windows.Forms.ListBox()
        Me.ListBoxSalBrut = New System.Windows.Forms.ListBox()
        Me.ButtonCalculer = New System.Windows.Forms.Button()
        Me.ListBoxTxHoraire = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBoxSalBrute = New System.Windows.Forms.TextBox()
        Me.TextBoxAffSalBrut = New System.Windows.Forms.TextBox()
        Me.ButtonEffacer = New System.Windows.Forms.Button()
        Me.ButtonFermer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBoxPrenom
        '
        Me.TextBoxPrenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPrenom.Location = New System.Drawing.Point(108, 50)
        Me.TextBoxPrenom.Name = "TextBoxPrenom"
        Me.TextBoxPrenom.ReadOnly = True
        Me.TextBoxPrenom.Size = New System.Drawing.Size(90, 23)
        Me.TextBoxPrenom.TabIndex = 2
        Me.TextBoxPrenom.Text = "Prenom"
        Me.TextBoxPrenom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxNom
        '
        Me.TextBoxNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNom.Location = New System.Drawing.Point(12, 50)
        Me.TextBoxNom.Name = "TextBoxNom"
        Me.TextBoxNom.ReadOnly = True
        Me.TextBoxNom.Size = New System.Drawing.Size(90, 23)
        Me.TextBoxNom.TabIndex = 3
        Me.TextBoxNom.Text = "Nom"
        Me.TextBoxNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxNbHMois
        '
        Me.TextBoxNbHMois.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNbHMois.Location = New System.Drawing.Point(204, 50)
        Me.TextBoxNbHMois.Name = "TextBoxNbHMois"
        Me.TextBoxNbHMois.ReadOnly = True
        Me.TextBoxNbHMois.Size = New System.Drawing.Size(90, 23)
        Me.TextBoxNbHMois.TabIndex = 4
        Me.TextBoxNbHMois.Text = "Nb H / mois"
        Me.TextBoxNbHMois.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxSalBase
        '
        Me.TextBoxSalBase.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSalBase.Location = New System.Drawing.Point(396, 50)
        Me.TextBoxSalBase.Name = "TextBoxSalBase"
        Me.TextBoxSalBase.ReadOnly = True
        Me.TextBoxSalBase.Size = New System.Drawing.Size(90, 23)
        Me.TextBoxSalBase.TabIndex = 5
        Me.TextBoxSalBase.Text = "Salaire base"
        Me.TextBoxSalBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxNbH25
        '
        Me.TextBoxNbH25.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNbH25.Location = New System.Drawing.Point(492, 50)
        Me.TextBoxNbH25.Name = "TextBoxNbH25"
        Me.TextBoxNbH25.ReadOnly = True
        Me.TextBoxNbH25.Size = New System.Drawing.Size(90, 23)
        Me.TextBoxNbH25.TabIndex = 6
        Me.TextBoxNbH25.Text = "Nb H 25%"
        Me.TextBoxNbH25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxNbH50
        '
        Me.TextBoxNbH50.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNbH50.Location = New System.Drawing.Point(588, 50)
        Me.TextBoxNbH50.Name = "TextBoxNbH50"
        Me.TextBoxNbH50.ReadOnly = True
        Me.TextBoxNbH50.Size = New System.Drawing.Size(90, 23)
        Me.TextBoxNbH50.TabIndex = 7
        Me.TextBoxNbH50.Text = "Nb H 50%"
        Me.TextBoxNbH50.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxMtH25
        '
        Me.TextBoxMtH25.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxMtH25.Location = New System.Drawing.Point(684, 50)
        Me.TextBoxMtH25.Name = "TextBoxMtH25"
        Me.TextBoxMtH25.ReadOnly = True
        Me.TextBoxMtH25.Size = New System.Drawing.Size(90, 23)
        Me.TextBoxMtH25.TabIndex = 8
        Me.TextBoxMtH25.Text = "Mt H 25%"
        Me.TextBoxMtH25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxMtH50
        '
        Me.TextBoxMtH50.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxMtH50.Location = New System.Drawing.Point(780, 50)
        Me.TextBoxMtH50.Name = "TextBoxMtH50"
        Me.TextBoxMtH50.ReadOnly = True
        Me.TextBoxMtH50.Size = New System.Drawing.Size(90, 23)
        Me.TextBoxMtH50.TabIndex = 9
        Me.TextBoxMtH50.Text = "Mt H 50%"
        Me.TextBoxMtH50.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxSalBrut
        '
        Me.TextBoxSalBrut.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSalBrut.Location = New System.Drawing.Point(876, 50)
        Me.TextBoxSalBrut.Name = "TextBoxSalBrut"
        Me.TextBoxSalBrut.ReadOnly = True
        Me.TextBoxSalBrut.Size = New System.Drawing.Size(90, 23)
        Me.TextBoxSalBrut.TabIndex = 10
        Me.TextBoxSalBrut.Text = "Salaire Brut"
        Me.TextBoxSalBrut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ListBoxNom
        '
        Me.ListBoxNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxNom.FormattingEnabled = True
        Me.ListBoxNom.ItemHeight = 16
        Me.ListBoxNom.Location = New System.Drawing.Point(12, 79)
        Me.ListBoxNom.Name = "ListBoxNom"
        Me.ListBoxNom.Size = New System.Drawing.Size(90, 84)
        Me.ListBoxNom.TabIndex = 11
        '
        'ListBoxPrenom
        '
        Me.ListBoxPrenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxPrenom.FormattingEnabled = True
        Me.ListBoxPrenom.ItemHeight = 16
        Me.ListBoxPrenom.Location = New System.Drawing.Point(108, 79)
        Me.ListBoxPrenom.Name = "ListBoxPrenom"
        Me.ListBoxPrenom.Size = New System.Drawing.Size(90, 84)
        Me.ListBoxPrenom.TabIndex = 12
        '
        'ListBoxNbHMois
        '
        Me.ListBoxNbHMois.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxNbHMois.FormattingEnabled = True
        Me.ListBoxNbHMois.ItemHeight = 16
        Me.ListBoxNbHMois.Location = New System.Drawing.Point(204, 79)
        Me.ListBoxNbHMois.Name = "ListBoxNbHMois"
        Me.ListBoxNbHMois.Size = New System.Drawing.Size(90, 84)
        Me.ListBoxNbHMois.TabIndex = 13
        '
        'ListBoxSalBase
        '
        Me.ListBoxSalBase.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxSalBase.FormattingEnabled = True
        Me.ListBoxSalBase.ItemHeight = 16
        Me.ListBoxSalBase.Location = New System.Drawing.Point(396, 79)
        Me.ListBoxSalBase.Name = "ListBoxSalBase"
        Me.ListBoxSalBase.Size = New System.Drawing.Size(90, 84)
        Me.ListBoxSalBase.TabIndex = 14
        '
        'ListBoxNbH25
        '
        Me.ListBoxNbH25.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxNbH25.FormattingEnabled = True
        Me.ListBoxNbH25.ItemHeight = 16
        Me.ListBoxNbH25.Location = New System.Drawing.Point(492, 79)
        Me.ListBoxNbH25.Name = "ListBoxNbH25"
        Me.ListBoxNbH25.Size = New System.Drawing.Size(90, 84)
        Me.ListBoxNbH25.TabIndex = 15
        '
        'ListBoxNbH50
        '
        Me.ListBoxNbH50.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxNbH50.FormattingEnabled = True
        Me.ListBoxNbH50.ItemHeight = 16
        Me.ListBoxNbH50.Location = New System.Drawing.Point(588, 79)
        Me.ListBoxNbH50.Name = "ListBoxNbH50"
        Me.ListBoxNbH50.Size = New System.Drawing.Size(90, 84)
        Me.ListBoxNbH50.TabIndex = 16
        '
        'ListBoxMtH25
        '
        Me.ListBoxMtH25.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxMtH25.FormattingEnabled = True
        Me.ListBoxMtH25.ItemHeight = 16
        Me.ListBoxMtH25.Location = New System.Drawing.Point(684, 79)
        Me.ListBoxMtH25.Name = "ListBoxMtH25"
        Me.ListBoxMtH25.Size = New System.Drawing.Size(90, 84)
        Me.ListBoxMtH25.TabIndex = 17
        '
        'ListBoxMtH50
        '
        Me.ListBoxMtH50.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxMtH50.FormattingEnabled = True
        Me.ListBoxMtH50.ItemHeight = 16
        Me.ListBoxMtH50.Location = New System.Drawing.Point(780, 79)
        Me.ListBoxMtH50.Name = "ListBoxMtH50"
        Me.ListBoxMtH50.Size = New System.Drawing.Size(90, 84)
        Me.ListBoxMtH50.TabIndex = 18
        '
        'ListBoxSalBrut
        '
        Me.ListBoxSalBrut.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxSalBrut.FormattingEnabled = True
        Me.ListBoxSalBrut.ItemHeight = 16
        Me.ListBoxSalBrut.Location = New System.Drawing.Point(876, 79)
        Me.ListBoxSalBrut.Name = "ListBoxSalBrut"
        Me.ListBoxSalBrut.Size = New System.Drawing.Size(90, 84)
        Me.ListBoxSalBrut.TabIndex = 19
        '
        'ButtonCalculer
        '
        Me.ButtonCalculer.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonCalculer.Location = New System.Drawing.Point(741, 214)
        Me.ButtonCalculer.Name = "ButtonCalculer"
        Me.ButtonCalculer.Size = New System.Drawing.Size(102, 36)
        Me.ButtonCalculer.TabIndex = 20
        Me.ButtonCalculer.Text = "Calculer"
        Me.ButtonCalculer.UseVisualStyleBackColor = False
        '
        'ListBoxTxHoraire
        '
        Me.ListBoxTxHoraire.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxTxHoraire.FormattingEnabled = True
        Me.ListBoxTxHoraire.ItemHeight = 16
        Me.ListBoxTxHoraire.Location = New System.Drawing.Point(300, 79)
        Me.ListBoxTxHoraire.Name = "ListBoxTxHoraire"
        Me.ListBoxTxHoraire.Size = New System.Drawing.Size(90, 84)
        Me.ListBoxTxHoraire.TabIndex = 22
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(300, 50)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(90, 23)
        Me.TextBox1.TabIndex = 21
        Me.TextBox1.Text = "Tx horaire"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxSalBrute
        '
        Me.TextBoxSalBrute.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSalBrute.Location = New System.Drawing.Point(737, 169)
        Me.TextBoxSalBrute.Name = "TextBoxSalBrute"
        Me.TextBoxSalBrute.ReadOnly = True
        Me.TextBoxSalBrute.Size = New System.Drawing.Size(133, 23)
        Me.TextBoxSalBrute.TabIndex = 23
        Me.TextBoxSalBrute.Text = "Total salaire brut :"
        '
        'TextBoxAffSalBrut
        '
        Me.TextBoxAffSalBrut.BackColor = System.Drawing.Color.White
        Me.TextBoxAffSalBrut.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAffSalBrut.Location = New System.Drawing.Point(876, 169)
        Me.TextBoxAffSalBrut.Name = "TextBoxAffSalBrut"
        Me.TextBoxAffSalBrut.ReadOnly = True
        Me.TextBoxAffSalBrut.Size = New System.Drawing.Size(90, 23)
        Me.TextBoxAffSalBrut.TabIndex = 24
        '
        'ButtonEffacer
        '
        Me.ButtonEffacer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonEffacer.Location = New System.Drawing.Point(864, 214)
        Me.ButtonEffacer.Name = "ButtonEffacer"
        Me.ButtonEffacer.Size = New System.Drawing.Size(102, 36)
        Me.ButtonEffacer.TabIndex = 25
        Me.ButtonEffacer.Text = "Effacer"
        Me.ButtonEffacer.UseVisualStyleBackColor = False
        '
        'ButtonFermer
        '
        Me.ButtonFermer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonFermer.Location = New System.Drawing.Point(864, 300)
        Me.ButtonFermer.Name = "ButtonFermer"
        Me.ButtonFermer.Size = New System.Drawing.Size(102, 36)
        Me.ButtonFermer.TabIndex = 26
        Me.ButtonFermer.Text = "Fermer"
        Me.ButtonFermer.UseVisualStyleBackColor = False
        '
        'Exercice_7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 355)
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
        Me.Name = "Exercice_7"
        Me.Text = "Exercice_7"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxPrenom As TextBox
    Friend WithEvents TextBoxNom As TextBox
    Friend WithEvents TextBoxNbHMois As TextBox
    Friend WithEvents TextBoxSalBase As TextBox
    Friend WithEvents TextBoxNbH25 As TextBox
    Friend WithEvents TextBoxNbH50 As TextBox
    Friend WithEvents TextBoxMtH25 As TextBox
    Friend WithEvents TextBoxMtH50 As TextBox
    Friend WithEvents TextBoxSalBrut As TextBox
    Friend WithEvents ListBoxNom As ListBox
    Friend WithEvents ListBoxPrenom As ListBox
    Friend WithEvents ListBoxNbHMois As ListBox
    Friend WithEvents ListBoxSalBase As ListBox
    Friend WithEvents ListBoxNbH25 As ListBox
    Friend WithEvents ListBoxNbH50 As ListBox
    Friend WithEvents ListBoxMtH25 As ListBox
    Friend WithEvents ListBoxMtH50 As ListBox
    Friend WithEvents ListBoxSalBrut As ListBox
    Friend WithEvents ButtonCalculer As Button
    Friend WithEvents ListBoxTxHoraire As ListBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBoxSalBrute As TextBox
    Friend WithEvents TextBoxAffSalBrut As TextBox
    Friend WithEvents ButtonEffacer As Button
    Friend WithEvents ButtonFermer As Button
End Class
