<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class adminInsertSekolah
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
        Me.MaterialRaisedButton2 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialRaisedButton1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.alamatsekolah = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.namasekolah = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.kode = New MaterialSkin.Controls.MaterialLabel()
        Me.nama = New MaterialSkin.Controls.MaterialLabel()
        Me.SuspendLayout()
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
        Me.MaterialRaisedButton2.TabIndex = 24
        Me.MaterialRaisedButton2.Text = "Back"
        Me.MaterialRaisedButton2.UseVisualStyleBackColor = True
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
        Me.MaterialRaisedButton1.TabIndex = 23
        Me.MaterialRaisedButton1.Text = "insert"
        Me.MaterialRaisedButton1.UseVisualStyleBackColor = True
        '
        'alamatsekolah
        '
        Me.alamatsekolah.BackColor = System.Drawing.Color.White
        Me.alamatsekolah.Depth = 0
        Me.alamatsekolah.Hint = ""
        Me.alamatsekolah.Location = New System.Drawing.Point(145, 112)
        Me.alamatsekolah.MaxLength = 32767
        Me.alamatsekolah.MouseState = MaterialSkin.MouseState.HOVER
        Me.alamatsekolah.Name = "alamatsekolah"
        Me.alamatsekolah.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.alamatsekolah.SelectedText = ""
        Me.alamatsekolah.SelectionLength = 0
        Me.alamatsekolah.SelectionStart = 0
        Me.alamatsekolah.Size = New System.Drawing.Size(193, 23)
        Me.alamatsekolah.TabIndex = 22
        Me.alamatsekolah.TabStop = False
        Me.alamatsekolah.UseSystemPasswordChar = False
        '
        'namasekolah
        '
        Me.namasekolah.BackColor = System.Drawing.Color.White
        Me.namasekolah.Depth = 0
        Me.namasekolah.Hint = ""
        Me.namasekolah.Location = New System.Drawing.Point(145, 76)
        Me.namasekolah.MaxLength = 32767
        Me.namasekolah.MouseState = MaterialSkin.MouseState.HOVER
        Me.namasekolah.Name = "namasekolah"
        Me.namasekolah.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.namasekolah.SelectedText = ""
        Me.namasekolah.SelectionLength = 0
        Me.namasekolah.SelectionStart = 0
        Me.namasekolah.Size = New System.Drawing.Size(194, 23)
        Me.namasekolah.TabIndex = 21
        Me.namasekolah.TabStop = False
        Me.namasekolah.UseSystemPasswordChar = False
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
        Me.kode.Size = New System.Drawing.Size(65, 19)
        Me.kode.TabIndex = 20
        Me.kode.Text = "Alamat :"
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
        Me.nama.TabIndex = 19
        Me.nama.Text = "Nama :"
        '
        'adminInsertSekolah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(350, 185)
        Me.Controls.Add(Me.MaterialRaisedButton2)
        Me.Controls.Add(Me.MaterialRaisedButton1)
        Me.Controls.Add(Me.alamatsekolah)
        Me.Controls.Add(Me.namasekolah)
        Me.Controls.Add(Me.kode)
        Me.Controls.Add(Me.nama)
        Me.Name = "adminInsertSekolah"
        Me.Text = "AdminInsertSekolah"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialRaisedButton2 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialRaisedButton1 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents alamatsekolah As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents namasekolah As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents kode As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents nama As MaterialSkin.Controls.MaterialLabel
End Class
