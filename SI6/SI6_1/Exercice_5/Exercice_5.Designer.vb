<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Exercice_5
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
        Me.LabelTitre = New System.Windows.Forms.Label()
        Me.LabelNom = New System.Windows.Forms.Label()
        Me.LabelAncRepr = New System.Windows.Forms.Label()
        Me.LabelCARepr = New System.Windows.Forms.Label()
        Me.TextBoxNom = New System.Windows.Forms.TextBox()
        Me.ButtonCalculer = New System.Windows.Forms.Button()
        Me.TextBoxNomAff = New System.Windows.Forms.TextBox()
        Me.LabelNomAff = New System.Windows.Forms.Label()
        Me.LabelFixe = New System.Windows.Forms.Label()
        Me.TextBoxFixe = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxCaPrime = New System.Windows.Forms.TextBox()
        Me.TextBoxRemBrut = New System.Windows.Forms.TextBox()
        Me.ButtonFermer = New System.Windows.Forms.Button()
        Me.GroupBoxRemu = New System.Windows.Forms.GroupBox()
        Me.TextBoxPrimeAnc = New System.Windows.Forms.TextBox()
        Me.LabelPrimeAnc = New System.Windows.Forms.Label()
        Me.ComboBoxCARepr = New System.Windows.Forms.ComboBox()
        Me.ComboBoxAnc = New System.Windows.Forms.ComboBox()
        Me.GroupBoxRemu.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelTitre
        '
        Me.LabelTitre.AutoSize = True
        Me.LabelTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitre.Location = New System.Drawing.Point(258, 9)
        Me.LabelTitre.Name = "LabelTitre"
        Me.LabelTitre.Size = New System.Drawing.Size(272, 26)
        Me.LabelTitre.TabIndex = 0
        Me.LabelTitre.Text = "Calcul d’une rémunération."
        '
        'LabelNom
        '
        Me.LabelNom.AutoSize = True
        Me.LabelNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNom.Location = New System.Drawing.Point(105, 60)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(150, 17)
        Me.LabelNom.TabIndex = 1
        Me.LabelNom.Text = "Nom du représentant :"
        '
        'LabelAncRepr
        '
        Me.LabelAncRepr.AutoSize = True
        Me.LabelAncRepr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAncRepr.Location = New System.Drawing.Point(63, 93)
        Me.LabelAncRepr.Name = "LabelAncRepr"
        Me.LabelAncRepr.Size = New System.Drawing.Size(192, 17)
        Me.LabelAncRepr.TabIndex = 2
        Me.LabelAncRepr.Text = "Ancienneté du représentant :"
        '
        'LabelCARepr
        '
        Me.LabelCARepr.AutoSize = True
        Me.LabelCARepr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCARepr.Location = New System.Drawing.Point(38, 125)
        Me.LabelCARepr.Name = "LabelCARepr"
        Me.LabelCARepr.Size = New System.Drawing.Size(224, 17)
        Me.LabelCARepr.TabIndex = 3
        Me.LabelCARepr.Text = "Chiffre d'affaires du représentant :"
        '
        'TextBoxNom
        '
        Me.TextBoxNom.Location = New System.Drawing.Point(263, 59)
        Me.TextBoxNom.Name = "TextBoxNom"
        Me.TextBoxNom.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNom.TabIndex = 4
        '
        'ButtonCalculer
        '
        Me.ButtonCalculer.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonCalculer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCalculer.Location = New System.Drawing.Point(642, 118)
        Me.ButtonCalculer.Name = "ButtonCalculer"
        Me.ButtonCalculer.Size = New System.Drawing.Size(97, 30)
        Me.ButtonCalculer.TabIndex = 7
        Me.ButtonCalculer.Text = "Calculer"
        Me.ButtonCalculer.UseVisualStyleBackColor = False
        '
        'TextBoxNomAff
        '
        Me.TextBoxNomAff.Location = New System.Drawing.Point(222, 31)
        Me.TextBoxNomAff.Name = "TextBoxNomAff"
        Me.TextBoxNomAff.ReadOnly = True
        Me.TextBoxNomAff.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxNomAff.TabIndex = 14
        '
        'LabelNomAff
        '
        Me.LabelNomAff.AutoSize = True
        Me.LabelNomAff.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNomAff.Location = New System.Drawing.Point(172, 34)
        Me.LabelNomAff.Name = "LabelNomAff"
        Me.LabelNomAff.Size = New System.Drawing.Size(45, 17)
        Me.LabelNomAff.TabIndex = 11
        Me.LabelNomAff.Text = "Nom :"
        '
        'LabelFixe
        '
        Me.LabelFixe.AutoSize = True
        Me.LabelFixe.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFixe.Location = New System.Drawing.Point(176, 63)
        Me.LabelFixe.Name = "LabelFixe"
        Me.LabelFixe.Size = New System.Drawing.Size(41, 17)
        Me.LabelFixe.TabIndex = 17
        Me.LabelFixe.Text = "Fixe :"
        '
        'TextBoxFixe
        '
        Me.TextBoxFixe.Location = New System.Drawing.Point(222, 60)
        Me.TextBoxFixe.Name = "TextBoxFixe"
        Me.TextBoxFixe.ReadOnly = True
        Me.TextBoxFixe.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxFixe.TabIndex = 18
        Me.TextBoxFixe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(116, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 17)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Prime sur CA :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(79, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 17)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Rémunération Brut :"
        '
        'TextBoxCaPrime
        '
        Me.TextBoxCaPrime.Location = New System.Drawing.Point(222, 119)
        Me.TextBoxCaPrime.Name = "TextBoxCaPrime"
        Me.TextBoxCaPrime.ReadOnly = True
        Me.TextBoxCaPrime.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxCaPrime.TabIndex = 21
        Me.TextBoxCaPrime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxRemBrut
        '
        Me.TextBoxRemBrut.Location = New System.Drawing.Point(222, 149)
        Me.TextBoxRemBrut.Name = "TextBoxRemBrut"
        Me.TextBoxRemBrut.ReadOnly = True
        Me.TextBoxRemBrut.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxRemBrut.TabIndex = 22
        Me.TextBoxRemBrut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ButtonFermer
        '
        Me.ButtonFermer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonFermer.Location = New System.Drawing.Point(683, 404)
        Me.ButtonFermer.Name = "ButtonFermer"
        Me.ButtonFermer.Size = New System.Drawing.Size(105, 34)
        Me.ButtonFermer.TabIndex = 23
        Me.ButtonFermer.Text = "Fermer"
        Me.ButtonFermer.UseVisualStyleBackColor = False
        '
        'GroupBoxRemu
        '
        Me.GroupBoxRemu.Controls.Add(Me.TextBoxPrimeAnc)
        Me.GroupBoxRemu.Controls.Add(Me.LabelPrimeAnc)
        Me.GroupBoxRemu.Controls.Add(Me.LabelNomAff)
        Me.GroupBoxRemu.Controls.Add(Me.TextBoxNomAff)
        Me.GroupBoxRemu.Controls.Add(Me.TextBoxRemBrut)
        Me.GroupBoxRemu.Controls.Add(Me.LabelFixe)
        Me.GroupBoxRemu.Controls.Add(Me.Label3)
        Me.GroupBoxRemu.Controls.Add(Me.TextBoxCaPrime)
        Me.GroupBoxRemu.Controls.Add(Me.Label2)
        Me.GroupBoxRemu.Controls.Add(Me.TextBoxFixe)
        Me.GroupBoxRemu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxRemu.Location = New System.Drawing.Point(41, 187)
        Me.GroupBoxRemu.Name = "GroupBoxRemu"
        Me.GroupBoxRemu.Size = New System.Drawing.Size(627, 228)
        Me.GroupBoxRemu.TabIndex = 24
        Me.GroupBoxRemu.TabStop = False
        Me.GroupBoxRemu.Text = "Rémunération :"
        Me.GroupBoxRemu.Visible = False
        '
        'TextBoxPrimeAnc
        '
        Me.TextBoxPrimeAnc.Location = New System.Drawing.Point(222, 89)
        Me.TextBoxPrimeAnc.Name = "TextBoxPrimeAnc"
        Me.TextBoxPrimeAnc.ReadOnly = True
        Me.TextBoxPrimeAnc.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxPrimeAnc.TabIndex = 24
        Me.TextBoxPrimeAnc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelPrimeAnc
        '
        Me.LabelPrimeAnc.AutoSize = True
        Me.LabelPrimeAnc.Location = New System.Drawing.Point(88, 92)
        Me.LabelPrimeAnc.Name = "LabelPrimeAnc"
        Me.LabelPrimeAnc.Size = New System.Drawing.Size(126, 17)
        Me.LabelPrimeAnc.TabIndex = 23
        Me.LabelPrimeAnc.Text = "Prime ancienneté :"
        '
        'ComboBoxCARepr
        '
        Me.ComboBoxCARepr.FormattingEnabled = True
        Me.ComboBoxCARepr.Items.AddRange(New Object() {"Inférieur à 100 000 €", "Compris entre 100 000 € et 200 000 € (non compris)", "Supérieur ou égal à 200 000 €"})
        Me.ComboBoxCARepr.Location = New System.Drawing.Point(263, 125)
        Me.ComboBoxCARepr.Name = "ComboBoxCARepr"
        Me.ComboBoxCARepr.Size = New System.Drawing.Size(282, 21)
        Me.ComboBoxCARepr.TabIndex = 25
        '
        'ComboBoxAnc
        '
        Me.ComboBoxAnc.FormattingEnabled = True
        Me.ComboBoxAnc.Items.AddRange(New Object() {"Inférieur à 3 ans", "Entre 3 et 10 ans (Non compris)", "Plus de 10 ans"})
        Me.ComboBoxAnc.Location = New System.Drawing.Point(263, 92)
        Me.ComboBoxAnc.Name = "ComboBoxAnc"
        Me.ComboBoxAnc.Size = New System.Drawing.Size(282, 21)
        Me.ComboBoxAnc.TabIndex = 26
        '
        'Exercice_5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ComboBoxAnc)
        Me.Controls.Add(Me.ComboBoxCARepr)
        Me.Controls.Add(Me.GroupBoxRemu)
        Me.Controls.Add(Me.ButtonFermer)
        Me.Controls.Add(Me.ButtonCalculer)
        Me.Controls.Add(Me.TextBoxNom)
        Me.Controls.Add(Me.LabelCARepr)
        Me.Controls.Add(Me.LabelAncRepr)
        Me.Controls.Add(Me.LabelNom)
        Me.Controls.Add(Me.LabelTitre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Exercice_5"
        Me.Text = "Exercice_5"
        Me.GroupBoxRemu.ResumeLayout(False)
        Me.GroupBoxRemu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelTitre As Label
    Friend WithEvents LabelNom As Label
    Friend WithEvents LabelAncRepr As Label
    Friend WithEvents LabelCARepr As Label
    Friend WithEvents TextBoxNom As TextBox
    Friend WithEvents ButtonCalculer As Button
    Friend WithEvents TextBoxNomAff As TextBox
    Friend WithEvents LabelNomAff As Label
    Friend WithEvents LabelFixe As Label
    Friend WithEvents TextBoxFixe As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxCaPrime As TextBox
    Friend WithEvents TextBoxRemBrut As TextBox
    Friend WithEvents ButtonFermer As Button
    Friend WithEvents GroupBoxRemu As GroupBox
    Friend WithEvents ComboBoxCARepr As ComboBox
    Friend WithEvents ComboBoxAnc As ComboBox
    Friend WithEvents LabelPrimeAnc As Label
    Friend WithEvents TextBoxPrimeAnc As TextBox
End Class
