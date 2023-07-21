<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.CmbArt = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Dgv = New System.Windows.Forms.DataGridView()
        Me.BtnArt = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSupp = New System.Windows.Forms.Button()
        Me.cmbCom = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtQte = New System.Windows.Forms.TextBox()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 189)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Zone de rechereche"
        '
        'TxtSearch
        '
        Me.TxtSearch.Location = New System.Drawing.Point(228, 187)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(157, 22)
        Me.TxtSearch.TabIndex = 1
        '
        'CmbArt
        '
        Me.CmbArt.FormattingEnabled = True
        Me.CmbArt.Location = New System.Drawing.Point(630, 29)
        Me.CmbArt.Name = "CmbArt"
        Me.CmbArt.Size = New System.Drawing.Size(148, 24)
        Me.CmbArt.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(557, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Article"
        '
        'Dgv
        '
        Me.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv.Location = New System.Drawing.Point(29, 254)
        Me.Dgv.Name = "Dgv"
        Me.Dgv.RowHeadersWidth = 51
        Me.Dgv.RowTemplate.Height = 24
        Me.Dgv.Size = New System.Drawing.Size(676, 243)
        Me.Dgv.TabIndex = 4
        '
        'BtnArt
        '
        Me.BtnArt.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnArt.Location = New System.Drawing.Point(492, 180)
        Me.BtnArt.Name = "BtnArt"
        Me.BtnArt.Size = New System.Drawing.Size(84, 36)
        Me.BtnArt.TabIndex = 5
        Me.BtnArt.Text = "Article"
        Me.BtnArt.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(630, 90)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(132, 34)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "AJOUTER"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSupp
        '
        Me.btnSupp.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupp.Location = New System.Drawing.Point(711, 254)
        Me.btnSupp.Name = "btnSupp"
        Me.btnSupp.Size = New System.Drawing.Size(159, 42)
        Me.btnSupp.TabIndex = 8
        Me.btnSupp.Text = "SUPPRIMER"
        Me.btnSupp.UseVisualStyleBackColor = True
        '
        'cmbCom
        '
        Me.cmbCom.FormattingEnabled = True
        Me.cmbCom.Location = New System.Drawing.Point(183, 26)
        Me.cmbCom.Name = "cmbCom"
        Me.cmbCom.Size = New System.Drawing.Size(148, 24)
        Me.cmbCom.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(74, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 21)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Commande"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(89, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 21)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Quantité"
        '
        'txtQte
        '
        Me.txtQte.Location = New System.Drawing.Point(183, 103)
        Me.txtQte.Name = "txtQte"
        Me.txtQte.Size = New System.Drawing.Size(146, 22)
        Me.txtQte.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(896, 530)
        Me.Controls.Add(Me.txtQte)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbCom)
        Me.Controls.Add(Me.btnSupp)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.BtnArt)
        Me.Controls.Add(Me.Dgv)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmbArt)
        Me.Controls.Add(Me.TxtSearch)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtSearch As TextBox
    Friend WithEvents CmbArt As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Dgv As DataGridView
    Friend WithEvents BtnArt As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSupp As Button
    Friend WithEvents cmbCom As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtQte As TextBox
End Class
