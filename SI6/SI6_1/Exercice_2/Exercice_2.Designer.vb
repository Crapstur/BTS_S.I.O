<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Exercice_2
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
        Me.ButtonCalculer = New System.Windows.Forms.Button()
        Me.ButtonEffacer = New System.Windows.Forms.Button()
        Me.LabelMtBrut = New System.Windows.Forms.Label()
        Me.TextBoxMtBrut = New System.Windows.Forms.TextBox()
        Me.LabelTitre = New System.Windows.Forms.Label()
        Me.LabelPied = New System.Windows.Forms.Label()
        Me.LabelEuro = New System.Windows.Forms.Label()
        Me.LabelMtBrutHT = New System.Windows.Forms.Label()
        Me.LabelMtRemise = New System.Windows.Forms.Label()
        Me.LabelMtNetHT = New System.Windows.Forms.Label()
        Me.LabelMtTVA = New System.Windows.Forms.Label()
        Me.LabelMtTTC = New System.Windows.Forms.Label()
        Me.TextBoxMtBrutHT = New System.Windows.Forms.TextBox()
        Me.TextBoxMtRemise = New System.Windows.Forms.TextBox()
        Me.TextBoxMtNetHT = New System.Windows.Forms.TextBox()
        Me.TextBoxMtTVA = New System.Windows.Forms.TextBox()
        Me.TextBoxMtTTC = New System.Windows.Forms.TextBox()
        Me.ButtonFermer = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonCalculer
        '
        Me.ButtonCalculer.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonCalculer.Location = New System.Drawing.Point(64, 115)
        Me.ButtonCalculer.Name = "ButtonCalculer"
        Me.ButtonCalculer.Size = New System.Drawing.Size(170, 61)
        Me.ButtonCalculer.TabIndex = 0
        Me.ButtonCalculer.Text = "Calculer"
        Me.ButtonCalculer.UseVisualStyleBackColor = False
        '
        'ButtonEffacer
        '
        Me.ButtonEffacer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonEffacer.Location = New System.Drawing.Point(534, 115)
        Me.ButtonEffacer.Name = "ButtonEffacer"
        Me.ButtonEffacer.Size = New System.Drawing.Size(170, 61)
        Me.ButtonEffacer.TabIndex = 1
        Me.ButtonEffacer.Text = "Effacer"
        Me.ButtonEffacer.UseVisualStyleBackColor = False
        '
        'LabelMtBrut
        '
        Me.LabelMtBrut.AutoSize = True
        Me.LabelMtBrut.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMtBrut.Location = New System.Drawing.Point(39, 65)
        Me.LabelMtBrut.Name = "LabelMtBrut"
        Me.LabelMtBrut.Size = New System.Drawing.Size(101, 17)
        Me.LabelMtBrut.TabIndex = 2
        Me.LabelMtBrut.Text = "Montant Brut : "
        '
        'TextBoxMtBrut
        '
        Me.TextBoxMtBrut.Location = New System.Drawing.Point(144, 65)
        Me.TextBoxMtBrut.Name = "TextBoxMtBrut"
        Me.TextBoxMtBrut.Size = New System.Drawing.Size(102, 20)
        Me.TextBoxMtBrut.TabIndex = 4
        '
        'LabelTitre
        '
        Me.LabelTitre.AutoSize = True
        Me.LabelTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitre.Location = New System.Drawing.Point(201, 18)
        Me.LabelTitre.Name = "LabelTitre"
        Me.LabelTitre.Size = New System.Drawing.Size(383, 26)
        Me.LabelTitre.TabIndex = 5
        Me.LabelTitre.Text = "Facture avec une remise automatique."
        '
        'LabelPied
        '
        Me.LabelPied.AutoSize = True
        Me.LabelPied.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPied.Location = New System.Drawing.Point(61, 224)
        Me.LabelPied.Name = "LabelPied"
        Me.LabelPied.Size = New System.Drawing.Size(643, 17)
        Me.LabelPied.TabIndex = 6
        Me.LabelPied.Text = "-------------------------------------------------- Pied de votre facture --------" &
    "-----------------------------------------"
        '
        'LabelEuro
        '
        Me.LabelEuro.AutoSize = True
        Me.LabelEuro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEuro.Location = New System.Drawing.Point(251, 65)
        Me.LabelEuro.Name = "LabelEuro"
        Me.LabelEuro.Size = New System.Drawing.Size(16, 17)
        Me.LabelEuro.TabIndex = 7
        Me.LabelEuro.Text = "€"
        '
        'LabelMtBrutHT
        '
        Me.LabelMtBrutHT.AutoSize = True
        Me.LabelMtBrutHT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMtBrutHT.Location = New System.Drawing.Point(43, 263)
        Me.LabelMtBrutHT.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelMtBrutHT.Name = "LabelMtBrutHT"
        Me.LabelMtBrutHT.Size = New System.Drawing.Size(128, 17)
        Me.LabelMtBrutHT.TabIndex = 8
        Me.LabelMtBrutHT.Text = "Montant Brut H.T : "
        '
        'LabelMtRemise
        '
        Me.LabelMtRemise.AutoSize = True
        Me.LabelMtRemise.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMtRemise.Location = New System.Drawing.Point(22, 298)
        Me.LabelMtRemise.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelMtRemise.Name = "LabelMtRemise"
        Me.LabelMtRemise.Size = New System.Drawing.Size(152, 17)
        Me.LabelMtRemise.TabIndex = 9
        Me.LabelMtRemise.Text = "Montant de la remise : "
        '
        'LabelMtNetHT
        '
        Me.LabelMtNetHT.AutoSize = True
        Me.LabelMtNetHT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMtNetHT.Location = New System.Drawing.Point(42, 334)
        Me.LabelMtNetHT.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelMtNetHT.Name = "LabelMtNetHT"
        Me.LabelMtNetHT.Size = New System.Drawing.Size(130, 17)
        Me.LabelMtNetHT.TabIndex = 10
        Me.LabelMtNetHT.Text = "Montant NET H.T : "
        '
        'LabelMtTVA
        '
        Me.LabelMtTVA.AutoSize = True
        Me.LabelMtTVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMtTVA.Location = New System.Drawing.Point(61, 367)
        Me.LabelMtTVA.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelMtTVA.Name = "LabelMtTVA"
        Me.LabelMtTVA.Size = New System.Drawing.Size(110, 17)
        Me.LabelMtTVA.TabIndex = 11
        Me.LabelMtTVA.Text = "Montant T.V.A : "
        '
        'LabelMtTTC
        '
        Me.LabelMtTTC.AutoSize = True
        Me.LabelMtTTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMtTTC.Location = New System.Drawing.Point(61, 404)
        Me.LabelMtTTC.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelMtTTC.Name = "LabelMtTTC"
        Me.LabelMtTTC.Size = New System.Drawing.Size(110, 17)
        Me.LabelMtTTC.TabIndex = 12
        Me.LabelMtTTC.Text = "Montant T.T.C : "
        '
        'TextBoxMtBrutHT
        '
        Me.TextBoxMtBrutHT.Location = New System.Drawing.Point(171, 263)
        Me.TextBoxMtBrutHT.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxMtBrutHT.Name = "TextBoxMtBrutHT"
        Me.TextBoxMtBrutHT.Size = New System.Drawing.Size(75, 20)
        Me.TextBoxMtBrutHT.TabIndex = 13
        '
        'TextBoxMtRemise
        '
        Me.TextBoxMtRemise.Location = New System.Drawing.Point(171, 298)
        Me.TextBoxMtRemise.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxMtRemise.Name = "TextBoxMtRemise"
        Me.TextBoxMtRemise.Size = New System.Drawing.Size(75, 20)
        Me.TextBoxMtRemise.TabIndex = 14
        '
        'TextBoxMtNetHT
        '
        Me.TextBoxMtNetHT.Location = New System.Drawing.Point(171, 334)
        Me.TextBoxMtNetHT.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxMtNetHT.Name = "TextBoxMtNetHT"
        Me.TextBoxMtNetHT.Size = New System.Drawing.Size(75, 20)
        Me.TextBoxMtNetHT.TabIndex = 15
        '
        'TextBoxMtTVA
        '
        Me.TextBoxMtTVA.Location = New System.Drawing.Point(171, 367)
        Me.TextBoxMtTVA.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxMtTVA.Name = "TextBoxMtTVA"
        Me.TextBoxMtTVA.Size = New System.Drawing.Size(75, 20)
        Me.TextBoxMtTVA.TabIndex = 16
        '
        'TextBoxMtTTC
        '
        Me.TextBoxMtTTC.Location = New System.Drawing.Point(171, 404)
        Me.TextBoxMtTTC.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxMtTTC.Name = "TextBoxMtTTC"
        Me.TextBoxMtTTC.Size = New System.Drawing.Size(75, 20)
        Me.TextBoxMtTTC.TabIndex = 17
        '
        'ButtonFermer
        '
        Me.ButtonFermer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonFermer.Location = New System.Drawing.Point(534, 359)
        Me.ButtonFermer.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonFermer.Name = "ButtonFermer"
        Me.ButtonFermer.Size = New System.Drawing.Size(170, 61)
        Me.ButtonFermer.TabIndex = 18
        Me.ButtonFermer.Text = "Fermer"
        Me.ButtonFermer.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(251, 263)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 17)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "€"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(251, 298)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 17)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "€"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(251, 334)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 17)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "€"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(251, 367)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 17)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "€"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(251, 404)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 17)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "€"
        '
        'Exercice_2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonFermer)
        Me.Controls.Add(Me.TextBoxMtTTC)
        Me.Controls.Add(Me.TextBoxMtTVA)
        Me.Controls.Add(Me.TextBoxMtNetHT)
        Me.Controls.Add(Me.TextBoxMtRemise)
        Me.Controls.Add(Me.TextBoxMtBrutHT)
        Me.Controls.Add(Me.LabelMtTTC)
        Me.Controls.Add(Me.LabelMtTVA)
        Me.Controls.Add(Me.LabelMtNetHT)
        Me.Controls.Add(Me.LabelMtRemise)
        Me.Controls.Add(Me.LabelMtBrutHT)
        Me.Controls.Add(Me.LabelEuro)
        Me.Controls.Add(Me.LabelPied)
        Me.Controls.Add(Me.LabelTitre)
        Me.Controls.Add(Me.TextBoxMtBrut)
        Me.Controls.Add(Me.LabelMtBrut)
        Me.Controls.Add(Me.ButtonEffacer)
        Me.Controls.Add(Me.ButtonCalculer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Exercice_2"
        Me.Text = "Exercice 2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonCalculer As Button
    Friend WithEvents ButtonEffacer As Button
    Friend WithEvents LabelMtBrut As Label
    Friend WithEvents TextBoxMtBrut As TextBox
    Friend WithEvents LabelTitre As Label
    Friend WithEvents LabelPied As Label
    Friend WithEvents LabelEuro As Label
    Friend WithEvents LabelMtBrutHT As Label
    Friend WithEvents LabelMtRemise As Label
    Friend WithEvents LabelMtNetHT As Label
    Friend WithEvents LabelMtTVA As Label
    Friend WithEvents LabelMtTTC As Label
    Friend WithEvents TextBoxMtBrutHT As TextBox
    Friend WithEvents TextBoxMtRemise As TextBox
    Friend WithEvents TextBoxMtNetHT As TextBox
    Friend WithEvents TextBoxMtTVA As TextBox
    Friend WithEvents TextBoxMtTTC As TextBox
    Friend WithEvents ButtonFermer As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
