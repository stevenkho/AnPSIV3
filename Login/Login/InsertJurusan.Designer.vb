<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class insertjurusan
    Inherits MaterialSkin.Controls.MaterialForm

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MaterialRaisedButton1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.kodejurusan = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.namajurusan = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.kode = New MaterialSkin.Controls.MaterialLabel()
        Me.nama = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialRaisedButton2 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.SuspendLayout()
        '
        'MaterialRaisedButton1
        '
        Me.MaterialRaisedButton1.AutoSize = True
        Me.MaterialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialRaisedButton1.Depth = 0
        Me.MaterialRaisedButton1.Icon = Nothing
        Me.MaterialRaisedButton1.Location = New System.Drawing.Point(270, 141)
        Me.MaterialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton1.Name = "MaterialRaisedButton1"
        Me.MaterialRaisedButton1.Primary = True
        Me.MaterialRaisedButton1.Size = New System.Drawing.Size(68, 36)
        Me.MaterialRaisedButton1.TabIndex = 11
        Me.MaterialRaisedButton1.Text = "insert"
        Me.MaterialRaisedButton1.UseVisualStyleBackColor = True
        '
        'kodejurusan
        '
        Me.kodejurusan.BackColor = System.Drawing.Color.White
        Me.kodejurusan.Depth = 0
        Me.kodejurusan.Hint = ""
        Me.kodejurusan.Location = New System.Drawing.Point(145, 112)
        Me.kodejurusan.MaxLength = 32767
        Me.kodejurusan.MouseState = MaterialSkin.MouseState.HOVER
        Me.kodejurusan.Name = "kodejurusan"
        Me.kodejurusan.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.kodejurusan.SelectedText = ""
        Me.kodejurusan.SelectionLength = 0
        Me.kodejurusan.SelectionStart = 0
        Me.kodejurusan.Size = New System.Drawing.Size(193, 23)
        Me.kodejurusan.TabIndex = 10
        Me.kodejurusan.TabStop = False
        Me.kodejurusan.UseSystemPasswordChar = False
        '
        'namajurusan
        '
        Me.namajurusan.BackColor = System.Drawing.Color.White
        Me.namajurusan.Depth = 0
        Me.namajurusan.Hint = ""
        Me.namajurusan.Location = New System.Drawing.Point(145, 76)
        Me.namajurusan.MaxLength = 32767
        Me.namajurusan.MouseState = MaterialSkin.MouseState.HOVER
        Me.namajurusan.Name = "namajurusan"
        Me.namajurusan.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.namajurusan.SelectedText = ""
        Me.namajurusan.SelectionLength = 0
        Me.namajurusan.SelectionStart = 0
        Me.namajurusan.Size = New System.Drawing.Size(194, 23)
        Me.namajurusan.TabIndex = 9
        Me.namajurusan.TabStop = False
        Me.namajurusan.UseSystemPasswordChar = False
        '
        'kode
        '
        Me.kode.AutoSize = True
        Me.kode.BackColor = System.Drawing.Color.White
        Me.kode.Depth = 0
        Me.kode.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.kode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kode.Location = New System.Drawing.Point(12, 112)
        Me.kode.MouseState = MaterialSkin.MouseState.HOVER
        Me.kode.Name = "kode"
        Me.kode.Size = New System.Drawing.Size(108, 19)
        Me.kode.TabIndex = 8
        Me.kode.Text = "Kode Jurusan :"
        '
        'nama
        '
        Me.nama.AutoSize = True
        Me.nama.BackColor = System.Drawing.Color.White
        Me.nama.Depth = 0
        Me.nama.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.nama.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.nama.Location = New System.Drawing.Point(12, 73)
        Me.nama.MouseState = MaterialSkin.MouseState.HOVER
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(57, 19)
        Me.nama.TabIndex = 7
        Me.nama.Text = "Nama :"
        '
        'MaterialRaisedButton2
        '
        Me.MaterialRaisedButton2.AutoSize = True
        Me.MaterialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialRaisedButton2.Depth = 0
        Me.MaterialRaisedButton2.Icon = Nothing
        Me.MaterialRaisedButton2.Location = New System.Drawing.Point(16, 141)
        Me.MaterialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton2.Name = "MaterialRaisedButton2"
        Me.MaterialRaisedButton2.Primary = True
        Me.MaterialRaisedButton2.Size = New System.Drawing.Size(56, 36)
        Me.MaterialRaisedButton2.TabIndex = 12
        Me.MaterialRaisedButton2.Text = "Back"
        Me.MaterialRaisedButton2.UseVisualStyleBackColor = True
        '
        'insertjurusan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(350, 185)
        Me.Controls.Add(Me.MaterialRaisedButton2)
        Me.Controls.Add(Me.MaterialRaisedButton1)
        Me.Controls.Add(Me.kodejurusan)
        Me.Controls.Add(Me.namajurusan)
        Me.Controls.Add(Me.kode)
        Me.Controls.Add(Me.nama)
        Me.Name = "insertjurusan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InsertJurusan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MaterialRaisedButton1 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents kodejurusan As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents namajurusan As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents kode As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents nama As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialRaisedButton2 As MaterialSkin.Controls.MaterialRaisedButton
End Class
