<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Exercice_8
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
        Me.GroupBoxType = New System.Windows.Forms.GroupBox()
        Me.RadioButtonSortie = New System.Windows.Forms.RadioButton()
        Me.RadioButtonEntrée = New System.Windows.Forms.RadioButton()
        Me.ComboBoxProduit = New System.Windows.Forms.ComboBox()
        Me.LabelProduit = New System.Windows.Forms.Label()
        Me.LabelTitre = New System.Windows.Forms.Label()
        Me.ButtonFermer = New System.Windows.Forms.Button()
        Me.ButtonValider = New System.Windows.Forms.Button()
        Me.TextBoxQuantitée = New System.Windows.Forms.TextBox()
        Me.LabelQuantitée = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.LabelDate = New System.Windows.Forms.Label()
        Me.ButtonAffStock = New System.Windows.Forms.Button()
        Me.GroupBoxType.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxType
        '
        Me.GroupBoxType.Controls.Add(Me.RadioButtonSortie)
        Me.GroupBoxType.Controls.Add(Me.RadioButtonEntrée)
        Me.GroupBoxType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxType.Location = New System.Drawing.Point(47, 195)
        Me.GroupBoxType.Name = "GroupBoxType"
        Me.GroupBoxType.Size = New System.Drawing.Size(153, 58)
        Me.GroupBoxType.TabIndex = 13
        Me.GroupBoxType.TabStop = False
        Me.GroupBoxType.Text = "Type"
        '
        'RadioButtonSortie
        '
        Me.RadioButtonSortie.AutoSize = True
        Me.RadioButtonSortie.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonSortie.Location = New System.Drawing.Point(84, 22)
        Me.RadioButtonSortie.Name = "RadioButtonSortie"
        Me.RadioButtonSortie.Size = New System.Drawing.Size(63, 21)
        Me.RadioButtonSortie.TabIndex = 1
        Me.RadioButtonSortie.TabStop = True
        Me.RadioButtonSortie.Text = "Sortie"
        Me.RadioButtonSortie.UseVisualStyleBackColor = True
        '
        'RadioButtonEntrée
        '
        Me.RadioButtonEntrée.AutoSize = True
        Me.RadioButtonEntrée.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonEntrée.Location = New System.Drawing.Point(6, 22)
        Me.RadioButtonEntrée.Name = "RadioButtonEntrée"
        Me.RadioButtonEntrée.Size = New System.Drawing.Size(68, 21)
        Me.RadioButtonEntrée.TabIndex = 0
        Me.RadioButtonEntrée.Text = "Entrée"
        Me.RadioButtonEntrée.UseVisualStyleBackColor = True
        '
        'ComboBoxProduit
        '
        Me.ComboBoxProduit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxProduit.FormattingEnabled = True
        Me.ComboBoxProduit.Location = New System.Drawing.Point(103, 108)
        Me.ComboBoxProduit.Name = "ComboBoxProduit"
        Me.ComboBoxProduit.Size = New System.Drawing.Size(153, 21)
        Me.ComboBoxProduit.TabIndex = 12
        '
        'LabelProduit
        '
        Me.LabelProduit.AutoSize = True
        Me.LabelProduit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProduit.Location = New System.Drawing.Point(44, 108)
        Me.LabelProduit.Name = "LabelProduit"
        Me.LabelProduit.Size = New System.Drawing.Size(53, 17)
        Me.LabelProduit.TabIndex = 11
        Me.LabelProduit.Text = "Produit"
        '
        'LabelTitre
        '
        Me.LabelTitre.AutoSize = True
        Me.LabelTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitre.Location = New System.Drawing.Point(236, 23)
        Me.LabelTitre.Name = "LabelTitre"
        Me.LabelTitre.Size = New System.Drawing.Size(332, 26)
        Me.LabelTitre.TabIndex = 10
        Me.LabelTitre.Text = "Saisie des mouvements de stock"
        '
        'ButtonFermer
        '
        Me.ButtonFermer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonFermer.Location = New System.Drawing.Point(461, 368)
        Me.ButtonFermer.Name = "ButtonFermer"
        Me.ButtonFermer.Size = New System.Drawing.Size(245, 57)
        Me.ButtonFermer.TabIndex = 19
        Me.ButtonFermer.Text = "Fermer"
        Me.ButtonFermer.UseVisualStyleBackColor = False
        '
        'ButtonValider
        '
        Me.ButtonValider.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonValider.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonValider.Location = New System.Drawing.Point(47, 368)
        Me.ButtonValider.Name = "ButtonValider"
        Me.ButtonValider.Size = New System.Drawing.Size(245, 57)
        Me.ButtonValider.TabIndex = 18
        Me.ButtonValider.Text = "Valider"
        Me.ButtonValider.UseVisualStyleBackColor = False
        '
        'TextBoxQuantitée
        '
        Me.TextBoxQuantitée.Location = New System.Drawing.Point(167, 295)
        Me.TextBoxQuantitée.Name = "TextBoxQuantitée"
        Me.TextBoxQuantitée.Size = New System.Drawing.Size(80, 20)
        Me.TextBoxQuantitée.TabIndex = 17
        '
        'LabelQuantitée
        '
        Me.LabelQuantitée.AutoSize = True
        Me.LabelQuantitée.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelQuantitée.Location = New System.Drawing.Point(44, 296)
        Me.LabelQuantitée.Name = "LabelQuantitée"
        Me.LabelQuantitée.Size = New System.Drawing.Size(70, 17)
        Me.LabelQuantitée.TabIndex = 16
        Me.LabelQuantitée.Text = "Quantité :"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(556, 219)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(201, 20)
        Me.DateTimePicker1.TabIndex = 15
        '
        'LabelDate
        '
        Me.LabelDate.AutoSize = True
        Me.LabelDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDate.Location = New System.Drawing.Point(415, 219)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(135, 17)
        Me.LabelDate.TabIndex = 14
        Me.LabelDate.Text = "Date de Mouvement"
        '
        'ButtonAffStock
        '
        Me.ButtonAffStock.Location = New System.Drawing.Point(262, 108)
        Me.ButtonAffStock.Name = "ButtonAffStock"
        Me.ButtonAffStock.Size = New System.Drawing.Size(86, 23)
        Me.ButtonAffStock.TabIndex = 20
        Me.ButtonAffStock.Text = "Voir les stocks"
        Me.ButtonAffStock.UseVisualStyleBackColor = True
        '
        'Exercice_8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonAffStock)
        Me.Controls.Add(Me.GroupBoxType)
        Me.Controls.Add(Me.ComboBoxProduit)
        Me.Controls.Add(Me.LabelProduit)
        Me.Controls.Add(Me.LabelTitre)
        Me.Controls.Add(Me.ButtonFermer)
        Me.Controls.Add(Me.ButtonValider)
        Me.Controls.Add(Me.TextBoxQuantitée)
        Me.Controls.Add(Me.LabelQuantitée)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.LabelDate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Exercice_8"
        Me.Text = "Exercice_8"
        Me.GroupBoxType.ResumeLayout(False)
        Me.GroupBoxType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBoxType As GroupBox
    Friend WithEvents RadioButtonSortie As RadioButton
    Friend WithEvents RadioButtonEntrée As RadioButton
    Friend WithEvents ComboBoxProduit As ComboBox
    Friend WithEvents LabelProduit As Label
    Friend WithEvents LabelTitre As Label
    Friend WithEvents ButtonFermer As Button
    Friend WithEvents ButtonValider As Button
    Friend WithEvents TextBoxQuantitée As TextBox
    Friend WithEvents LabelQuantitée As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents LabelDate As Label
    Friend WithEvents ButtonAffStock As Button
End Class
