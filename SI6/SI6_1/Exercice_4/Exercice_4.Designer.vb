<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Exercice_4
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
        Me.LabelTitre = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxAnc = New System.Windows.Forms.TextBox()
        Me.GroupBoxSexe = New System.Windows.Forms.GroupBox()
        Me.RadioButtonSFemme = New System.Windows.Forms.RadioButton()
        Me.RadioButtonSHomme = New System.Windows.Forms.RadioButton()
        Me.GroupBoxConjoin = New System.Windows.Forms.GroupBox()
        Me.RadioButtonConjNon = New System.Windows.Forms.RadioButton()
        Me.RadioButtonConjOui = New System.Windows.Forms.RadioButton()
        Me.ButtonCalculer = New System.Windows.Forms.Button()
        Me.LabelPrime = New System.Windows.Forms.Label()
        Me.TextBoxPrime = New System.Windows.Forms.TextBox()
        Me.LabelPrimeAnuelle = New System.Windows.Forms.Label()
        Me.ButtonFermer = New System.Windows.Forms.Button()
        Me.ButtonEffacer = New System.Windows.Forms.Button()
        Me.GroupBoxSexe.SuspendLayout()
        Me.GroupBoxConjoin.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelTitre
        '
        Me.LabelTitre.AutoSize = True
        Me.LabelTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitre.Location = New System.Drawing.Point(212, 22)
        Me.LabelTitre.Name = "LabelTitre"
        Me.LabelTitre.Size = New System.Drawing.Size(362, 26)
        Me.LabelTitre.TabIndex = 0
        Me.LabelTitre.Text = "Détermination d’une prime annuelle."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(85, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Saisir l'ancienneté (en Mois) : "
        '
        'TextBoxAnc
        '
        Me.TextBoxAnc.Location = New System.Drawing.Point(289, 102)
        Me.TextBoxAnc.Name = "TextBoxAnc"
        Me.TextBoxAnc.Size = New System.Drawing.Size(64, 20)
        Me.TextBoxAnc.TabIndex = 2
        Me.TextBoxAnc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBoxSexe
        '
        Me.GroupBoxSexe.Controls.Add(Me.RadioButtonSFemme)
        Me.GroupBoxSexe.Controls.Add(Me.RadioButtonSHomme)
        Me.GroupBoxSexe.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxSexe.Location = New System.Drawing.Point(61, 150)
        Me.GroupBoxSexe.Name = "GroupBoxSexe"
        Me.GroupBoxSexe.Size = New System.Drawing.Size(200, 66)
        Me.GroupBoxSexe.TabIndex = 3
        Me.GroupBoxSexe.TabStop = False
        Me.GroupBoxSexe.Text = "Sexe"
        '
        'RadioButtonSFemme
        '
        Me.RadioButtonSFemme.AutoSize = True
        Me.RadioButtonSFemme.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonSFemme.Location = New System.Drawing.Point(111, 30)
        Me.RadioButtonSFemme.Name = "RadioButtonSFemme"
        Me.RadioButtonSFemme.Size = New System.Drawing.Size(72, 21)
        Me.RadioButtonSFemme.TabIndex = 1
        Me.RadioButtonSFemme.TabStop = True
        Me.RadioButtonSFemme.Text = "Femme"
        Me.RadioButtonSFemme.UseVisualStyleBackColor = True
        '
        'RadioButtonSHomme
        '
        Me.RadioButtonSHomme.AutoSize = True
        Me.RadioButtonSHomme.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonSHomme.Location = New System.Drawing.Point(15, 30)
        Me.RadioButtonSHomme.Name = "RadioButtonSHomme"
        Me.RadioButtonSHomme.Size = New System.Drawing.Size(74, 21)
        Me.RadioButtonSHomme.TabIndex = 0
        Me.RadioButtonSHomme.Text = "Homme"
        Me.RadioButtonSHomme.UseVisualStyleBackColor = True
        '
        'GroupBoxConjoin
        '
        Me.GroupBoxConjoin.Controls.Add(Me.RadioButtonConjNon)
        Me.GroupBoxConjoin.Controls.Add(Me.RadioButtonConjOui)
        Me.GroupBoxConjoin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxConjoin.Location = New System.Drawing.Point(332, 150)
        Me.GroupBoxConjoin.Name = "GroupBoxConjoin"
        Me.GroupBoxConjoin.Size = New System.Drawing.Size(203, 66)
        Me.GroupBoxConjoin.TabIndex = 4
        Me.GroupBoxConjoin.TabStop = False
        Me.GroupBoxConjoin.Text = "Conjoin dans l'entreprise ?"
        '
        'RadioButtonConjNon
        '
        Me.RadioButtonConjNon.AutoSize = True
        Me.RadioButtonConjNon.Location = New System.Drawing.Point(109, 30)
        Me.RadioButtonConjNon.Name = "RadioButtonConjNon"
        Me.RadioButtonConjNon.Size = New System.Drawing.Size(52, 21)
        Me.RadioButtonConjNon.TabIndex = 1
        Me.RadioButtonConjNon.TabStop = True
        Me.RadioButtonConjNon.Text = "Non"
        Me.RadioButtonConjNon.UseVisualStyleBackColor = True
        '
        'RadioButtonConjOui
        '
        Me.RadioButtonConjOui.AutoSize = True
        Me.RadioButtonConjOui.Location = New System.Drawing.Point(9, 30)
        Me.RadioButtonConjOui.Name = "RadioButtonConjOui"
        Me.RadioButtonConjOui.Size = New System.Drawing.Size(48, 21)
        Me.RadioButtonConjOui.TabIndex = 0
        Me.RadioButtonConjOui.TabStop = True
        Me.RadioButtonConjOui.Text = "Oui"
        Me.RadioButtonConjOui.UseVisualStyleBackColor = True
        '
        'ButtonCalculer
        '
        Me.ButtonCalculer.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonCalculer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCalculer.Location = New System.Drawing.Point(596, 171)
        Me.ButtonCalculer.Name = "ButtonCalculer"
        Me.ButtonCalculer.Size = New System.Drawing.Size(89, 38)
        Me.ButtonCalculer.TabIndex = 5
        Me.ButtonCalculer.Text = "Calculer"
        Me.ButtonCalculer.UseVisualStyleBackColor = False
        '
        'LabelPrime
        '
        Me.LabelPrime.AutoSize = True
        Me.LabelPrime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPrime.Location = New System.Drawing.Point(52, 312)
        Me.LabelPrime.Name = "LabelPrime"
        Me.LabelPrime.Size = New System.Drawing.Size(100, 17)
        Me.LabelPrime.TabIndex = 6
        Me.LabelPrime.Text = "Prime perçue :"
        '
        'TextBoxPrime
        '
        Me.TextBoxPrime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPrime.Location = New System.Drawing.Point(158, 311)
        Me.TextBoxPrime.Name = "TextBoxPrime"
        Me.TextBoxPrime.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxPrime.TabIndex = 7
        '
        'LabelPrimeAnuelle
        '
        Me.LabelPrimeAnuelle.AutoSize = True
        Me.LabelPrimeAnuelle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPrimeAnuelle.Location = New System.Drawing.Point(52, 264)
        Me.LabelPrimeAnuelle.Name = "LabelPrimeAnuelle"
        Me.LabelPrimeAnuelle.Size = New System.Drawing.Size(626, 17)
        Me.LabelPrimeAnuelle.TabIndex = 8
        Me.LabelPrimeAnuelle.Text = "Prime annuelle ------------------------------------------------------------------" &
    "--------------------------------------"
        '
        'ButtonFermer
        '
        Me.ButtonFermer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonFermer.Location = New System.Drawing.Point(669, 401)
        Me.ButtonFermer.Name = "ButtonFermer"
        Me.ButtonFermer.Size = New System.Drawing.Size(119, 37)
        Me.ButtonFermer.TabIndex = 9
        Me.ButtonFermer.Text = "Fermer"
        Me.ButtonFermer.UseVisualStyleBackColor = False
        '
        'ButtonEffacer
        '
        Me.ButtonEffacer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonEffacer.Location = New System.Drawing.Point(382, 312)
        Me.ButtonEffacer.Name = "ButtonEffacer"
        Me.ButtonEffacer.Size = New System.Drawing.Size(111, 32)
        Me.ButtonEffacer.TabIndex = 10
        Me.ButtonEffacer.Text = "Effacer"
        Me.ButtonEffacer.UseVisualStyleBackColor = False
        '
        'Exercice_4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonEffacer)
        Me.Controls.Add(Me.ButtonFermer)
        Me.Controls.Add(Me.LabelPrimeAnuelle)
        Me.Controls.Add(Me.TextBoxPrime)
        Me.Controls.Add(Me.LabelPrime)
        Me.Controls.Add(Me.ButtonCalculer)
        Me.Controls.Add(Me.GroupBoxConjoin)
        Me.Controls.Add(Me.GroupBoxSexe)
        Me.Controls.Add(Me.TextBoxAnc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabelTitre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Exercice_4"
        Me.Text = "Exercice_4"
        Me.GroupBoxSexe.ResumeLayout(False)
        Me.GroupBoxSexe.PerformLayout()
        Me.GroupBoxConjoin.ResumeLayout(False)
        Me.GroupBoxConjoin.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelTitre As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxAnc As TextBox
    Friend WithEvents GroupBoxSexe As GroupBox
    Friend WithEvents RadioButtonSFemme As RadioButton
    Friend WithEvents RadioButtonSHomme As RadioButton
    Friend WithEvents GroupBoxConjoin As GroupBox
    Friend WithEvents RadioButtonConjNon As RadioButton
    Friend WithEvents RadioButtonConjOui As RadioButton
    Friend WithEvents ButtonCalculer As Button
    Friend WithEvents LabelPrime As Label
    Friend WithEvents TextBoxPrime As TextBox
    Friend WithEvents LabelPrimeAnuelle As Label
    Friend WithEvents ButtonFermer As Button
    Friend WithEvents ButtonEffacer As Button
End Class
