<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Exercice_6
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
        Me.GroupBoxAffichage = New System.Windows.Forms.GroupBox()
        Me.ButtonRefaire = New System.Windows.Forms.Button()
        Me.TextBoxAffMoy = New System.Windows.Forms.TextBox()
        Me.LabelAffMoy = New System.Windows.Forms.Label()
        Me.TextBoxAffMan = New System.Windows.Forms.TextBox()
        Me.TextBoxAffCult = New System.Windows.Forms.TextBox()
        Me.TextBoxAffSport = New System.Windows.Forms.TextBox()
        Me.TextBoxAffNbrParticipant = New System.Windows.Forms.TextBox()
        Me.LabelAffCult = New System.Windows.Forms.Label()
        Me.LabelAffMan = New System.Windows.Forms.Label()
        Me.LabelAffSport = New System.Windows.Forms.Label()
        Me.LabelNbrParticipant = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBoxQuestionnaire = New System.Windows.Forms.GroupBox()
        Me.ButtonCadreSuivant = New System.Windows.Forms.Button()
        Me.ButtonTerminer = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelQ2Text = New System.Windows.Forms.Label()
        Me.LabelQ1Text = New System.Windows.Forms.Label()
        Me.TextBoxQ2 = New System.Windows.Forms.TextBox()
        Me.LabelQ2 = New System.Windows.Forms.Label()
        Me.ComboBoxQ1 = New System.Windows.Forms.ComboBox()
        Me.LabelQ1 = New System.Windows.Forms.Label()
        Me.ButtonFermer = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBoxAffichage.SuspendLayout()
        Me.GroupBoxQuestionnaire.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxAffichage
        '
        Me.GroupBoxAffichage.Controls.Add(Me.Label5)
        Me.GroupBoxAffichage.Controls.Add(Me.Label4)
        Me.GroupBoxAffichage.Controls.Add(Me.Label2)
        Me.GroupBoxAffichage.Controls.Add(Me.ButtonRefaire)
        Me.GroupBoxAffichage.Controls.Add(Me.TextBoxAffMoy)
        Me.GroupBoxAffichage.Controls.Add(Me.LabelAffMoy)
        Me.GroupBoxAffichage.Controls.Add(Me.TextBoxAffMan)
        Me.GroupBoxAffichage.Controls.Add(Me.TextBoxAffCult)
        Me.GroupBoxAffichage.Controls.Add(Me.TextBoxAffSport)
        Me.GroupBoxAffichage.Controls.Add(Me.TextBoxAffNbrParticipant)
        Me.GroupBoxAffichage.Controls.Add(Me.LabelAffCult)
        Me.GroupBoxAffichage.Controls.Add(Me.LabelAffMan)
        Me.GroupBoxAffichage.Controls.Add(Me.LabelAffSport)
        Me.GroupBoxAffichage.Controls.Add(Me.LabelNbrParticipant)
        Me.GroupBoxAffichage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxAffichage.Location = New System.Drawing.Point(28, 478)
        Me.GroupBoxAffichage.Name = "GroupBoxAffichage"
        Me.GroupBoxAffichage.Size = New System.Drawing.Size(798, 311)
        Me.GroupBoxAffichage.TabIndex = 0
        Me.GroupBoxAffichage.TabStop = False
        Me.GroupBoxAffichage.Visible = False
        '
        'ButtonRefaire
        '
        Me.ButtonRefaire.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonRefaire.Location = New System.Drawing.Point(606, 242)
        Me.ButtonRefaire.Name = "ButtonRefaire"
        Me.ButtonRefaire.Size = New System.Drawing.Size(142, 63)
        Me.ButtonRefaire.TabIndex = 15
        Me.ButtonRefaire.Text = "Refaire"
        Me.ButtonRefaire.UseVisualStyleBackColor = False
        '
        'TextBoxAffMoy
        '
        Me.TextBoxAffMoy.Location = New System.Drawing.Point(428, 225)
        Me.TextBoxAffMoy.Name = "TextBoxAffMoy"
        Me.TextBoxAffMoy.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxAffMoy.TabIndex = 12
        Me.TextBoxAffMoy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelAffMoy
        '
        Me.LabelAffMoy.AutoSize = True
        Me.LabelAffMoy.Location = New System.Drawing.Point(186, 228)
        Me.LabelAffMoy.Name = "LabelAffMoy"
        Me.LabelAffMoy.Size = New System.Drawing.Size(236, 17)
        Me.LabelAffMoy.TabIndex = 9
        Me.LabelAffMoy.Text = "Moyenne dépensée par participant :"
        '
        'TextBoxAffMan
        '
        Me.TextBoxAffMan.Location = New System.Drawing.Point(428, 188)
        Me.TextBoxAffMan.Name = "TextBoxAffMan"
        Me.TextBoxAffMan.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxAffMan.TabIndex = 7
        Me.TextBoxAffMan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxAffCult
        '
        Me.TextBoxAffCult.Location = New System.Drawing.Point(428, 145)
        Me.TextBoxAffCult.Name = "TextBoxAffCult"
        Me.TextBoxAffCult.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxAffCult.TabIndex = 6
        Me.TextBoxAffCult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxAffSport
        '
        Me.TextBoxAffSport.Location = New System.Drawing.Point(428, 101)
        Me.TextBoxAffSport.Name = "TextBoxAffSport"
        Me.TextBoxAffSport.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxAffSport.TabIndex = 5
        Me.TextBoxAffSport.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxAffNbrParticipant
        '
        Me.TextBoxAffNbrParticipant.Location = New System.Drawing.Point(428, 58)
        Me.TextBoxAffNbrParticipant.Name = "TextBoxAffNbrParticipant"
        Me.TextBoxAffNbrParticipant.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxAffNbrParticipant.TabIndex = 4
        Me.TextBoxAffNbrParticipant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelAffCult
        '
        Me.LabelAffCult.AutoSize = True
        Me.LabelAffCult.Location = New System.Drawing.Point(155, 148)
        Me.LabelAffCult.Name = "LabelAffCult"
        Me.LabelAffCult.Size = New System.Drawing.Size(267, 17)
        Me.LabelAffCult.TabIndex = 3
        Me.LabelAffCult.Text = "Personnes faisant une activité culturelle :"
        '
        'LabelAffMan
        '
        Me.LabelAffMan.AutoSize = True
        Me.LabelAffMan.Location = New System.Drawing.Point(155, 191)
        Me.LabelAffMan.Name = "LabelAffMan"
        Me.LabelAffMan.Size = New System.Drawing.Size(267, 17)
        Me.LabelAffMan.TabIndex = 2
        Me.LabelAffMan.Text = "Personnes faisant une activité manuelle :"
        '
        'LabelAffSport
        '
        Me.LabelAffSport.AutoSize = True
        Me.LabelAffSport.Location = New System.Drawing.Point(154, 104)
        Me.LabelAffSport.Name = "LabelAffSport"
        Me.LabelAffSport.Size = New System.Drawing.Size(268, 17)
        Me.LabelAffSport.TabIndex = 1
        Me.LabelAffSport.Text = "Personnes faisant une activitée sportive :"
        '
        'LabelNbrParticipant
        '
        Me.LabelNbrParticipant.AutoSize = True
        Me.LabelNbrParticipant.Location = New System.Drawing.Point(262, 61)
        Me.LabelNbrParticipant.Name = "LabelNbrParticipant"
        Me.LabelNbrParticipant.Size = New System.Drawing.Size(160, 17)
        Me.LabelNbrParticipant.TabIndex = 0
        Me.LabelNbrParticipant.Text = "Nombre de participant : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(327, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(194, 26)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Enquête de cadres"
        '
        'GroupBoxQuestionnaire
        '
        Me.GroupBoxQuestionnaire.Controls.Add(Me.ButtonCadreSuivant)
        Me.GroupBoxQuestionnaire.Controls.Add(Me.ButtonTerminer)
        Me.GroupBoxQuestionnaire.Controls.Add(Me.Label1)
        Me.GroupBoxQuestionnaire.Controls.Add(Me.LabelQ2Text)
        Me.GroupBoxQuestionnaire.Controls.Add(Me.LabelQ1Text)
        Me.GroupBoxQuestionnaire.Controls.Add(Me.TextBoxQ2)
        Me.GroupBoxQuestionnaire.Controls.Add(Me.LabelQ2)
        Me.GroupBoxQuestionnaire.Controls.Add(Me.ComboBoxQ1)
        Me.GroupBoxQuestionnaire.Controls.Add(Me.LabelQ1)
        Me.GroupBoxQuestionnaire.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxQuestionnaire.Location = New System.Drawing.Point(12, 67)
        Me.GroupBoxQuestionnaire.Name = "GroupBoxQuestionnaire"
        Me.GroupBoxQuestionnaire.Size = New System.Drawing.Size(798, 311)
        Me.GroupBoxQuestionnaire.TabIndex = 11
        Me.GroupBoxQuestionnaire.TabStop = False
        Me.GroupBoxQuestionnaire.Visible = False
        '
        'ButtonCadreSuivant
        '
        Me.ButtonCadreSuivant.Location = New System.Drawing.Point(354, 236)
        Me.ButtonCadreSuivant.Name = "ButtonCadreSuivant"
        Me.ButtonCadreSuivant.Size = New System.Drawing.Size(139, 63)
        Me.ButtonCadreSuivant.TabIndex = 12
        Me.ButtonCadreSuivant.Text = "Enregistrer"
        Me.ButtonCadreSuivant.UseVisualStyleBackColor = True
        '
        'ButtonTerminer
        '
        Me.ButtonTerminer.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonTerminer.Location = New System.Drawing.Point(587, 236)
        Me.ButtonTerminer.Name = "ButtonTerminer"
        Me.ButtonTerminer.Size = New System.Drawing.Size(142, 63)
        Me.ButtonTerminer.TabIndex = 12
        Me.ButtonTerminer.Text = "Terminer"
        Me.ButtonTerminer.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(307, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 24)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Questionnaire"
        '
        'LabelQ2Text
        '
        Me.LabelQ2Text.AutoSize = True
        Me.LabelQ2Text.Location = New System.Drawing.Point(149, 146)
        Me.LabelQ2Text.Name = "LabelQ2Text"
        Me.LabelQ2Text.Size = New System.Drawing.Size(85, 17)
        Me.LabelQ2Text.TabIndex = 5
        Me.LabelQ2Text.Text = "Question 2 :"
        '
        'LabelQ1Text
        '
        Me.LabelQ1Text.AutoSize = True
        Me.LabelQ1Text.Location = New System.Drawing.Point(149, 54)
        Me.LabelQ1Text.Name = "LabelQ1Text"
        Me.LabelQ1Text.Size = New System.Drawing.Size(85, 17)
        Me.LabelQ1Text.TabIndex = 4
        Me.LabelQ1Text.Text = "Question 1 :"
        '
        'TextBoxQ2
        '
        Me.TextBoxQ2.Location = New System.Drawing.Point(456, 177)
        Me.TextBoxQ2.Name = "TextBoxQ2"
        Me.TextBoxQ2.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxQ2.TabIndex = 3
        Me.TextBoxQ2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelQ2
        '
        Me.LabelQ2.AutoSize = True
        Me.LabelQ2.Location = New System.Drawing.Point(149, 180)
        Me.LabelQ2.Name = "LabelQ2"
        Me.LabelQ2.Size = New System.Drawing.Size(301, 17)
        Me.LabelQ2.TabIndex = 2
        Me.LabelQ2.Text = "Combien dépensez-vous pour votre activitée ?"
        '
        'ComboBoxQ1
        '
        Me.ComboBoxQ1.FormattingEnabled = True
        Me.ComboBoxQ1.Items.AddRange(New Object() {"Sportive", "Manuelle", "Culturelle"})
        Me.ComboBoxQ1.Location = New System.Drawing.Point(499, 78)
        Me.ComboBoxQ1.Name = "ComboBoxQ1"
        Me.ComboBoxQ1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBoxQ1.TabIndex = 1
        '
        'LabelQ1
        '
        Me.LabelQ1.AutoSize = True
        Me.LabelQ1.Location = New System.Drawing.Point(149, 81)
        Me.LabelQ1.Name = "LabelQ1"
        Me.LabelQ1.Size = New System.Drawing.Size(344, 17)
        Me.LabelQ1.TabIndex = 0
        Me.LabelQ1.Text = "Quelles activitée faite-vous durant votre temps libre ?"
        '
        'ButtonFermer
        '
        Me.ButtonFermer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonFermer.Location = New System.Drawing.Point(683, 398)
        Me.ButtonFermer.Name = "ButtonFermer"
        Me.ButtonFermer.Size = New System.Drawing.Size(107, 42)
        Me.ButtonFermer.TabIndex = 10
        Me.ButtonFermer.Text = "Fermer"
        Me.ButtonFermer.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(534, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 17)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "%"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(534, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 17)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "%"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(534, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 17)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "%"
        '
        'Exercice_6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 857)
        Me.Controls.Add(Me.GroupBoxQuestionnaire)
        Me.Controls.Add(Me.ButtonFermer)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBoxAffichage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Exercice_6"
        Me.Text = "Exercice_6"
        Me.GroupBoxAffichage.ResumeLayout(False)
        Me.GroupBoxAffichage.PerformLayout()
        Me.GroupBoxQuestionnaire.ResumeLayout(False)
        Me.GroupBoxQuestionnaire.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBoxAffichage As GroupBox
    Friend WithEvents TextBoxAffMan As TextBox
    Friend WithEvents TextBoxAffCult As TextBox
    Friend WithEvents TextBoxAffSport As TextBox
    Friend WithEvents TextBoxAffNbrParticipant As TextBox
    Friend WithEvents LabelAffCult As Label
    Friend WithEvents LabelAffMan As Label
    Friend WithEvents LabelAffSport As Label
    Friend WithEvents LabelNbrParticipant As Label
    Friend WithEvents LabelAffMoy As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBoxQuestionnaire As GroupBox
    Friend WithEvents TextBoxQ2 As TextBox
    Friend WithEvents LabelQ2 As Label
    Friend WithEvents ComboBoxQ1 As ComboBox
    Friend WithEvents LabelQ1 As Label
    Friend WithEvents LabelQ2Text As Label
    Friend WithEvents LabelQ1Text As Label
    Friend WithEvents ButtonFermer As Button
    Friend WithEvents TextBoxAffMoy As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonCadreSuivant As Button
    Friend WithEvents ButtonTerminer As Button
    Friend WithEvents ButtonRefaire As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
End Class
