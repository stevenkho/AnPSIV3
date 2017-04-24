<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class insertuser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialRaisedButton1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialRaisedButton2 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.namauser = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.katasandi = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.SuspendLayout()
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(3, 36)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(108, 19)
        Me.MaterialLabel1.TabIndex = 0
        Me.MaterialLabel1.Text = "MaterialLabel1"
        '
        'MaterialRaisedButton1
        '
        Me.MaterialRaisedButton1.AutoSize = True
        Me.MaterialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialRaisedButton1.Depth = 0
        Me.MaterialRaisedButton1.Icon = Nothing
        Me.MaterialRaisedButton1.Location = New System.Drawing.Point(90, 124)
        Me.MaterialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton1.Name = "MaterialRaisedButton1"
        Me.MaterialRaisedButton1.Primary = True
        Me.MaterialRaisedButton1.Size = New System.Drawing.Size(195, 36)
        Me.MaterialRaisedButton1.TabIndex = 1
        Me.MaterialRaisedButton1.Text = "MaterialRaisedButton1"
        Me.MaterialRaisedButton1.UseVisualStyleBackColor = True
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(3, 55)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(108, 19)
        Me.MaterialLabel2.TabIndex = 2
        Me.MaterialLabel2.Text = "MaterialLabel2"
        '
        'MaterialRaisedButton2
        '
        Me.MaterialRaisedButton2.AutoSize = True
        Me.MaterialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialRaisedButton2.Depth = 0
        Me.MaterialRaisedButton2.Icon = Nothing
        Me.MaterialRaisedButton2.Location = New System.Drawing.Point(90, 166)
        Me.MaterialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton2.Name = "MaterialRaisedButton2"
        Me.MaterialRaisedButton2.Primary = True
        Me.MaterialRaisedButton2.Size = New System.Drawing.Size(195, 36)
        Me.MaterialRaisedButton2.TabIndex = 3
        Me.MaterialRaisedButton2.Text = "MaterialRaisedButton2"
        Me.MaterialRaisedButton2.UseVisualStyleBackColor = True
        '
        'namauser
        '
        Me.namauser.Depth = 0
        Me.namauser.Hint = ""
        Me.namauser.Location = New System.Drawing.Point(154, 36)
        Me.namauser.MaxLength = 32767
        Me.namauser.MouseState = MaterialSkin.MouseState.HOVER
        Me.namauser.Name = "namauser"
        Me.namauser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.namauser.SelectedText = ""
        Me.namauser.SelectionLength = 0
        Me.namauser.SelectionStart = 0
        Me.namauser.Size = New System.Drawing.Size(75, 23)
        Me.namauser.TabIndex = 4
        Me.namauser.TabStop = False
        Me.namauser.Text = "MaterialSingleLineTextField1"
        Me.namauser.UseSystemPasswordChar = False
        '
        'katasandi
        '
        Me.katasandi.Depth = 0
        Me.katasandi.Hint = ""
        Me.katasandi.Location = New System.Drawing.Point(154, 55)
        Me.katasandi.MaxLength = 32767
        Me.katasandi.MouseState = MaterialSkin.MouseState.HOVER
        Me.katasandi.Name = "katasandi"
        Me.katasandi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.katasandi.SelectedText = ""
        Me.katasandi.SelectionLength = 0
        Me.katasandi.SelectionStart = 0
        Me.katasandi.Size = New System.Drawing.Size(75, 23)
        Me.katasandi.TabIndex = 5
        Me.katasandi.TabStop = False
        Me.katasandi.Text = "MaterialSingleLineTextField2"
        Me.katasandi.UseSystemPasswordChar = False
        '
        'insertuser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.katasandi)
        Me.Controls.Add(Me.namauser)
        Me.Controls.Add(Me.MaterialRaisedButton2)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.MaterialRaisedButton1)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Name = "insertuser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "insertuser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialRaisedButton1 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialRaisedButton2 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents namauser As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents katasandi As MaterialSkin.Controls.MaterialSingleLineTextField
End Class
