<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Exercice_3
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
        Me.LabelAcad = New System.Windows.Forms.Label()
        Me.ComboBoxAcad = New System.Windows.Forms.ComboBox()
        Me.LabelZone = New System.Windows.Forms.Label()
        Me.TextBoxZone = New System.Windows.Forms.TextBox()
        Me.ButtonFermer = New System.Windows.Forms.Button()
        Me.LabelVacToussain = New System.Windows.Forms.Label()
        Me.LabelVacNoel = New System.Windows.Forms.Label()
        Me.LabelVacPrintemps = New System.Windows.Forms.Label()
        Me.LabelVacHiver = New System.Windows.Forms.Label()
        Me.TextBoxVacToussain = New System.Windows.Forms.TextBox()
        Me.TextBoxVacNoel = New System.Windows.Forms.TextBox()
        Me.TextBoxVacHiver = New System.Windows.Forms.TextBox()
        Me.TextBoxVacPrintemps = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LabelTitre
        '
        Me.LabelTitre.AutoSize = True
        Me.LabelTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitre.Location = New System.Drawing.Point(196, 24)
        Me.LabelTitre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelTitre.Name = "LabelTitre"
        Me.LabelTitre.Size = New System.Drawing.Size(343, 26)
        Me.LabelTitre.TabIndex = 0
        Me.LabelTitre.Text = "Calendrier des vacances scolaires"
        '
        'LabelAcad
        '
        Me.LabelAcad.AutoSize = True
        Me.LabelAcad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAcad.Location = New System.Drawing.Point(100, 154)
        Me.LabelAcad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelAcad.Name = "LabelAcad"
        Me.LabelAcad.Size = New System.Drawing.Size(82, 17)
        Me.LabelAcad.TabIndex = 1
        Me.LabelAcad.Text = "Académie : "
        '
        'ComboBoxAcad
        '
        Me.ComboBoxAcad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxAcad.FormattingEnabled = True
        Me.ComboBoxAcad.Items.AddRange(New Object() {"Aix-Marseille", "Amiens", "Besançon", "Bordeaux", "Caen", "Clermont-Ferrand", "Créteil", "Dijon", "Grenoble", "Lille", "Limoges", "Lyon", "Montpellier", "Nancy-Metz", "Nantes", "Nice", "Orléans-Tours", "Paris", "Poitiers", "Reims", "Rennes", "Rouen", "Strasbourg", "Toulouse", "Versailles"})
        Me.ComboBoxAcad.Location = New System.Drawing.Point(186, 147)
        Me.ComboBoxAcad.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxAcad.MaxDropDownItems = 100
        Me.ComboBoxAcad.MaxLength = 100
        Me.ComboBoxAcad.Name = "ComboBoxAcad"
        Me.ComboBoxAcad.Size = New System.Drawing.Size(162, 24)
        Me.ComboBoxAcad.Sorted = True
        Me.ComboBoxAcad.TabIndex = 0
        Me.ComboBoxAcad.Text = "Sélectionner"
        '
        'LabelZone
        '
        Me.LabelZone.AutoSize = True
        Me.LabelZone.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelZone.Location = New System.Drawing.Point(125, 208)
        Me.LabelZone.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelZone.Name = "LabelZone"
        Me.LabelZone.Size = New System.Drawing.Size(57, 17)
        Me.LabelZone.TabIndex = 3
        Me.LabelZone.Text = "Zone  : "
        '
        'TextBoxZone
        '
        Me.TextBoxZone.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxZone.Location = New System.Drawing.Point(185, 205)
        Me.TextBoxZone.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxZone.Name = "TextBoxZone"
        Me.TextBoxZone.ReadOnly = True
        Me.TextBoxZone.Size = New System.Drawing.Size(57, 23)
        Me.TextBoxZone.TabIndex = 4
        '
        'ButtonFermer
        '
        Me.ButtonFermer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonFermer.Location = New System.Drawing.Point(574, 486)
        Me.ButtonFermer.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonFermer.Name = "ButtonFermer"
        Me.ButtonFermer.Size = New System.Drawing.Size(113, 31)
        Me.ButtonFermer.TabIndex = 5
        Me.ButtonFermer.Text = "Fermer"
        Me.ButtonFermer.UseVisualStyleBackColor = False
        '
        'LabelVacToussain
        '
        Me.LabelVacToussain.AutoSize = True
        Me.LabelVacToussain.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVacToussain.Location = New System.Drawing.Point(45, 245)
        Me.LabelVacToussain.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelVacToussain.Name = "LabelVacToussain"
        Me.LabelVacToussain.Size = New System.Drawing.Size(141, 17)
        Me.LabelVacToussain.TabIndex = 6
        Me.LabelVacToussain.Text = "Vacance Toussaint : "
        '
        'LabelVacNoel
        '
        Me.LabelVacNoel.AutoSize = True
        Me.LabelVacNoel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVacNoel.Location = New System.Drawing.Point(67, 288)
        Me.LabelVacNoel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelVacNoel.Name = "LabelVacNoel"
        Me.LabelVacNoel.Size = New System.Drawing.Size(115, 17)
        Me.LabelVacNoel.TabIndex = 7
        Me.LabelVacNoel.Text = "Vacances Noël : "
        '
        'LabelVacPrintemps
        '
        Me.LabelVacPrintemps.AutoSize = True
        Me.LabelVacPrintemps.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVacPrintemps.Location = New System.Drawing.Point(33, 394)
        Me.LabelVacPrintemps.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelVacPrintemps.Name = "LabelVacPrintemps"
        Me.LabelVacPrintemps.Size = New System.Drawing.Size(149, 17)
        Me.LabelVacPrintemps.TabIndex = 8
        Me.LabelVacPrintemps.Text = "Vacances Printemps : "
        '
        'LabelVacHiver
        '
        Me.LabelVacHiver.AutoSize = True
        Me.LabelVacHiver.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVacHiver.Location = New System.Drawing.Point(63, 336)
        Me.LabelVacHiver.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelVacHiver.Name = "LabelVacHiver"
        Me.LabelVacHiver.Size = New System.Drawing.Size(119, 17)
        Me.LabelVacHiver.TabIndex = 9
        Me.LabelVacHiver.Text = "Vacances Hiver : "
        '
        'TextBoxVacToussain
        '
        Me.TextBoxVacToussain.Location = New System.Drawing.Point(185, 244)
        Me.TextBoxVacToussain.Name = "TextBoxVacToussain"
        Me.TextBoxVacToussain.ReadOnly = True
        Me.TextBoxVacToussain.Size = New System.Drawing.Size(163, 20)
        Me.TextBoxVacToussain.TabIndex = 10
        '
        'TextBoxVacNoel
        '
        Me.TextBoxVacNoel.Location = New System.Drawing.Point(187, 287)
        Me.TextBoxVacNoel.Name = "TextBoxVacNoel"
        Me.TextBoxVacNoel.ReadOnly = True
        Me.TextBoxVacNoel.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxVacNoel.TabIndex = 11
        '
        'TextBoxVacHiver
        '
        Me.TextBoxVacHiver.Location = New System.Drawing.Point(187, 335)
        Me.TextBoxVacHiver.Name = "TextBoxVacHiver"
        Me.TextBoxVacHiver.ReadOnly = True
        Me.TextBoxVacHiver.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxVacHiver.TabIndex = 12
        '
        'TextBoxVacPrintemps
        '
        Me.TextBoxVacPrintemps.Location = New System.Drawing.Point(187, 393)
        Me.TextBoxVacPrintemps.Name = "TextBoxVacPrintemps"
        Me.TextBoxVacPrintemps.ReadOnly = True
        Me.TextBoxVacPrintemps.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxVacPrintemps.TabIndex = 13
        '
        'Exercice_3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 528)
        Me.Controls.Add(Me.TextBoxVacPrintemps)
        Me.Controls.Add(Me.TextBoxVacHiver)
        Me.Controls.Add(Me.TextBoxVacNoel)
        Me.Controls.Add(Me.TextBoxVacToussain)
        Me.Controls.Add(Me.LabelVacHiver)
        Me.Controls.Add(Me.LabelVacPrintemps)
        Me.Controls.Add(Me.LabelVacNoel)
        Me.Controls.Add(Me.LabelVacToussain)
        Me.Controls.Add(Me.ButtonFermer)
        Me.Controls.Add(Me.TextBoxZone)
        Me.Controls.Add(Me.LabelZone)
        Me.Controls.Add(Me.ComboBoxAcad)
        Me.Controls.Add(Me.LabelAcad)
        Me.Controls.Add(Me.LabelTitre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "Exercice_3"
        Me.Text = "Exercice_3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelTitre As Label
    Friend WithEvents LabelAcad As Label
    Friend WithEvents LabelZone As Label
    Friend WithEvents TextBoxZone As TextBox
    Friend WithEvents ButtonFermer As Button
    Friend WithEvents LabelVacToussain As Label
    Friend WithEvents LabelVacNoel As Label
    Friend WithEvents LabelVacPrintemps As Label
    Friend WithEvents LabelVacHiver As Label
    Friend WithEvents ComboBoxAcad As ComboBox
    Friend WithEvents TextBoxVacToussain As TextBox
    Friend WithEvents TextBoxVacNoel As TextBox
    Friend WithEvents TextBoxVacHiver As TextBox
    Friend WithEvents TextBoxVacPrintemps As TextBox
End Class
