<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSaisieMouvements
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
        Me.LabelProduit = New System.Windows.Forms.Label()
        Me.ComboBoxProduit = New System.Windows.Forms.ComboBox()
        Me.GroupBoxType = New System.Windows.Forms.GroupBox()
        Me.RadioButtonSortie = New System.Windows.Forms.RadioButton()
        Me.RadioButtonEntrée = New System.Windows.Forms.RadioButton()
        Me.LabelDate = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.LabelQuantitée = New System.Windows.Forms.Label()
        Me.TextBoxQuantitée = New System.Windows.Forms.TextBox()
        Me.ButtonOK = New System.Windows.Forms.Button()
        Me.ButtonAnnuler = New System.Windows.Forms.Button()
        Me.GroupBoxType.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelTitre
        '
        Me.LabelTitre.AutoSize = True
        Me.LabelTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitre.Location = New System.Drawing.Point(269, 9)
        Me.LabelTitre.Name = "LabelTitre"
        Me.LabelTitre.Size = New System.Drawing.Size(245, 26)
        Me.LabelTitre.TabIndex = 0
        Me.LabelTitre.Text = "Saisie des mouvements"
        '
        'LabelProduit
        '
        Me.LabelProduit.AutoSize = True
        Me.LabelProduit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProduit.Location = New System.Drawing.Point(58, 91)
        Me.LabelProduit.Name = "LabelProduit"
        Me.LabelProduit.Size = New System.Drawing.Size(53, 17)
        Me.LabelProduit.TabIndex = 1
        Me.LabelProduit.Text = "Produit"
        '
        'ComboBoxProduit
        '
        Me.ComboBoxProduit.FormattingEnabled = True
        Me.ComboBoxProduit.Location = New System.Drawing.Point(117, 91)
        Me.ComboBoxProduit.Name = "ComboBoxProduit"
        Me.ComboBoxProduit.Size = New System.Drawing.Size(153, 21)
        Me.ComboBoxProduit.TabIndex = 2
        '
        'GroupBoxType
        '
        Me.GroupBoxType.Controls.Add(Me.RadioButtonSortie)
        Me.GroupBoxType.Controls.Add(Me.RadioButtonEntrée)
        Me.GroupBoxType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxType.Location = New System.Drawing.Point(61, 178)
        Me.GroupBoxType.Name = "GroupBoxType"
        Me.GroupBoxType.Size = New System.Drawing.Size(153, 58)
        Me.GroupBoxType.TabIndex = 3
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
        'LabelDate
        '
        Me.LabelDate.AutoSize = True
        Me.LabelDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDate.Location = New System.Drawing.Point(429, 202)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(135, 17)
        Me.LabelDate.TabIndex = 4
        Me.LabelDate.Text = "Date de Mouvement"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(570, 202)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(201, 20)
        Me.DateTimePicker1.TabIndex = 5
        '
        'LabelQuantitée
        '
        Me.LabelQuantitée.AutoSize = True
        Me.LabelQuantitée.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelQuantitée.Location = New System.Drawing.Point(58, 279)
        Me.LabelQuantitée.Name = "LabelQuantitée"
        Me.LabelQuantitée.Size = New System.Drawing.Size(70, 17)
        Me.LabelQuantitée.TabIndex = 6
        Me.LabelQuantitée.Text = "Quantité :"
        '
        'TextBoxQuantitée
        '
        Me.TextBoxQuantitée.Location = New System.Drawing.Point(181, 278)
        Me.TextBoxQuantitée.Name = "TextBoxQuantitée"
        Me.TextBoxQuantitée.Size = New System.Drawing.Size(80, 20)
        Me.TextBoxQuantitée.TabIndex = 7
        '
        'ButtonOK
        '
        Me.ButtonOK.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOK.Location = New System.Drawing.Point(61, 351)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(245, 57)
        Me.ButtonOK.TabIndex = 8
        Me.ButtonOK.Text = "OK"
        Me.ButtonOK.UseVisualStyleBackColor = False
        '
        'ButtonAnnuler
        '
        Me.ButtonAnnuler.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonAnnuler.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAnnuler.Location = New System.Drawing.Point(475, 351)
        Me.ButtonAnnuler.Name = "ButtonAnnuler"
        Me.ButtonAnnuler.Size = New System.Drawing.Size(245, 57)
        Me.ButtonAnnuler.TabIndex = 9
        Me.ButtonAnnuler.Text = "Annuler"
        Me.ButtonAnnuler.UseVisualStyleBackColor = False
        '
        'FormSaisieMouvements
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 452)
        Me.Controls.Add(Me.ButtonAnnuler)
        Me.Controls.Add(Me.ButtonOK)
        Me.Controls.Add(Me.TextBoxQuantitée)
        Me.Controls.Add(Me.LabelQuantitée)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.LabelDate)
        Me.Controls.Add(Me.GroupBoxType)
        Me.Controls.Add(Me.ComboBoxProduit)
        Me.Controls.Add(Me.LabelProduit)
        Me.Controls.Add(Me.LabelTitre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FormSaisieMouvements"
        Me.Text = "Saisie des mouvements"
        Me.GroupBoxType.ResumeLayout(False)
        Me.GroupBoxType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelTitre As Label
    Friend WithEvents LabelProduit As Label
    Friend WithEvents ComboBoxProduit As ComboBox
    Friend WithEvents GroupBoxType As GroupBox
    Friend WithEvents RadioButtonSortie As RadioButton
    Friend WithEvents RadioButtonEntrée As RadioButton
    Friend WithEvents LabelDate As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents LabelQuantitée As Label
    Friend WithEvents TextBoxQuantitée As TextBox
    Friend WithEvents ButtonOK As Button
    Friend WithEvents ButtonAnnuler As Button
End Class
