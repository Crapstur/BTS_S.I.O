﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Exercice_8_stocks1
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
        Me.DataGridViewProd = New System.Windows.Forms.DataGridView()
        Me.ColumnRef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnDesi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnPUHT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnTTVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnQTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabelTitre = New System.Windows.Forms.Label()
        Me.ButtonFermer = New System.Windows.Forms.Button()
        Me.ButtonRafraichir = New System.Windows.Forms.Button()
        CType(Me.DataGridViewProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewProd
        '
        Me.DataGridViewProd.AllowUserToAddRows = False
        Me.DataGridViewProd.AllowUserToDeleteRows = False
        Me.DataGridViewProd.AllowUserToResizeColumns = False
        Me.DataGridViewProd.AllowUserToResizeRows = False
        Me.DataGridViewProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewProd.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnRef, Me.ColumnDesi, Me.ColumnPUHT, Me.ColumnTTVA, Me.ColumnQTE})
        Me.DataGridViewProd.Location = New System.Drawing.Point(12, 42)
        Me.DataGridViewProd.Name = "DataGridViewProd"
        Me.DataGridViewProd.Size = New System.Drawing.Size(690, 227)
        Me.DataGridViewProd.TabIndex = 4
        '
        'ColumnRef
        '
        Me.ColumnRef.HeaderText = "Référence"
        Me.ColumnRef.Name = "ColumnRef"
        Me.ColumnRef.ReadOnly = True
        '
        'ColumnDesi
        '
        Me.ColumnDesi.HeaderText = "Désignation"
        Me.ColumnDesi.Name = "ColumnDesi"
        Me.ColumnDesi.ReadOnly = True
        Me.ColumnDesi.Width = 200
        '
        'ColumnPUHT
        '
        Me.ColumnPUHT.HeaderText = "Prix unitaire HT"
        Me.ColumnPUHT.Name = "ColumnPUHT"
        Me.ColumnPUHT.ReadOnly = True
        '
        'ColumnTTVA
        '
        Me.ColumnTTVA.HeaderText = "Taux de TVA"
        Me.ColumnTTVA.Name = "ColumnTTVA"
        Me.ColumnTTVA.ReadOnly = True
        '
        'ColumnQTE
        '
        Me.ColumnQTE.HeaderText = "Quantité en stock"
        Me.ColumnQTE.Name = "ColumnQTE"
        Me.ColumnQTE.ReadOnly = True
        '
        'LabelTitre
        '
        Me.LabelTitre.AutoSize = True
        Me.LabelTitre.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitre.Location = New System.Drawing.Point(12, 9)
        Me.LabelTitre.Name = "LabelTitre"
        Me.LabelTitre.Size = New System.Drawing.Size(140, 18)
        Me.LabelTitre.TabIndex = 6
        Me.LabelTitre.Text = "Liste des produits :"
        '
        'ButtonFermer
        '
        Me.ButtonFermer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonFermer.Location = New System.Drawing.Point(619, 4)
        Me.ButtonFermer.Name = "ButtonFermer"
        Me.ButtonFermer.Size = New System.Drawing.Size(75, 23)
        Me.ButtonFermer.TabIndex = 5
        Me.ButtonFermer.Text = "Fermer"
        Me.ButtonFermer.UseVisualStyleBackColor = False
        '
        'ButtonRafraichir
        '
        Me.ButtonRafraichir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonRafraichir.Location = New System.Drawing.Point(538, 4)
        Me.ButtonRafraichir.Name = "ButtonRafraichir"
        Me.ButtonRafraichir.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRafraichir.TabIndex = 7
        Me.ButtonRafraichir.Text = "Rafraichir"
        Me.ButtonRafraichir.UseVisualStyleBackColor = False
        '
        'Exercice_8_stocks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 287)
        Me.Controls.Add(Me.ButtonRafraichir)
        Me.Controls.Add(Me.DataGridViewProd)
        Me.Controls.Add(Me.LabelTitre)
        Me.Controls.Add(Me.ButtonFermer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Exercice_8_stocks"
        Me.Text = "Exercice_8_stocks"
        CType(Me.DataGridViewProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewProd As DataGridView
    Friend WithEvents ColumnRef As DataGridViewTextBoxColumn
    Friend WithEvents ColumnDesi As DataGridViewTextBoxColumn
    Friend WithEvents ColumnPUHT As DataGridViewTextBoxColumn
    Friend WithEvents ColumnTTVA As DataGridViewTextBoxColumn
    Friend WithEvents ColumnQTE As DataGridViewTextBoxColumn
    Friend WithEvents LabelTitre As Label
    Friend WithEvents ButtonFermer As Button
    Friend WithEvents ButtonRafraichir As Button
End Class
