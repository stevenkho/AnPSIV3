<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminNilaiTest
    Inherits MaterialSkin.Controls.MaterialForm

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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.MaterialLabel10 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialRaisedButton4 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialRaisedButton5 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialLabel9 = New MaterialSkin.Controls.MaterialLabel()
        Me.namajurusan = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.MaterialRaisedButton1 = New MaterialSkin.Controls.MaterialRaisedButton()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {""})
        Me.ComboBox1.Location = New System.Drawing.Point(86, 110)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(476, 21)
        Me.ComboBox1.TabIndex = 45
        '
        'MaterialLabel10
        '
        Me.MaterialLabel10.AutoSize = True
        Me.MaterialLabel10.BackColor = System.Drawing.Color.White
        Me.MaterialLabel10.Depth = 0
        Me.MaterialLabel10.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel10.Location = New System.Drawing.Point(10, 109)
        Me.MaterialLabel10.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel10.Name = "MaterialLabel10"
        Me.MaterialLabel10.Size = New System.Drawing.Size(70, 19)
        Me.MaterialLabel10.TabIndex = 44
        Me.MaterialLabel10.Text = "Jurusan :"
        '
        'MaterialRaisedButton4
        '
        Me.MaterialRaisedButton4.AutoSize = True
        Me.MaterialRaisedButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialRaisedButton4.Depth = 0
        Me.MaterialRaisedButton4.Icon = Nothing
        Me.MaterialRaisedButton4.Location = New System.Drawing.Point(14, 137)
        Me.MaterialRaisedButton4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton4.Name = "MaterialRaisedButton4"
        Me.MaterialRaisedButton4.Primary = True
        Me.MaterialRaisedButton4.Size = New System.Drawing.Size(56, 36)
        Me.MaterialRaisedButton4.TabIndex = 43
        Me.MaterialRaisedButton4.Text = "BACK"
        Me.MaterialRaisedButton4.UseVisualStyleBackColor = True
        '
        'MaterialRaisedButton5
        '
        Me.MaterialRaisedButton5.AutoSize = True
        Me.MaterialRaisedButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialRaisedButton5.Depth = 0
        Me.MaterialRaisedButton5.Icon = Nothing
        Me.MaterialRaisedButton5.Location = New System.Drawing.Point(489, 137)
        Me.MaterialRaisedButton5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton5.Name = "MaterialRaisedButton5"
        Me.MaterialRaisedButton5.Primary = True
        Me.MaterialRaisedButton5.Size = New System.Drawing.Size(73, 36)
        Me.MaterialRaisedButton5.TabIndex = 42
        Me.MaterialRaisedButton5.Text = "Search"
        Me.MaterialRaisedButton5.UseVisualStyleBackColor = True
        '
        'MaterialLabel9
        '
        Me.MaterialLabel9.AutoSize = True
        Me.MaterialLabel9.BackColor = System.Drawing.Color.White
        Me.MaterialLabel9.Depth = 0
        Me.MaterialLabel9.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel9.Location = New System.Drawing.Point(10, 75)
        Me.MaterialLabel9.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel9.Name = "MaterialLabel9"
        Me.MaterialLabel9.Size = New System.Drawing.Size(57, 19)
        Me.MaterialLabel9.TabIndex = 41
        Me.MaterialLabel9.Text = "Nama :"
        '
        'namajurusan
        '
        Me.namajurusan.BackColor = System.Drawing.Color.White
        Me.namajurusan.Depth = 0
        Me.namajurusan.Hint = ""
        Me.namajurusan.Location = New System.Drawing.Point(86, 75)
        Me.namajurusan.MaxLength = 32767
        Me.namajurusan.MouseState = MaterialSkin.MouseState.HOVER
        Me.namajurusan.Name = "namajurusan"
        Me.namajurusan.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.namajurusan.SelectedText = ""
        Me.namajurusan.SelectionLength = 0
        Me.namajurusan.SelectionStart = 0
        Me.namajurusan.Size = New System.Drawing.Size(476, 23)
        Me.namajurusan.TabIndex = 40
        Me.namajurusan.TabStop = False
        Me.namajurusan.UseSystemPasswordChar = False
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(12, 179)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.Size = New System.Drawing.Size(550, 186)
        Me.DataGridView2.TabIndex = 39
        '
        'MaterialRaisedButton1
        '
        Me.MaterialRaisedButton1.AutoSize = True
        Me.MaterialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialRaisedButton1.Depth = 0
        Me.MaterialRaisedButton1.Icon = Nothing
        Me.MaterialRaisedButton1.Location = New System.Drawing.Point(76, 137)
        Me.MaterialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton1.Name = "MaterialRaisedButton1"
        Me.MaterialRaisedButton1.Primary = True
        Me.MaterialRaisedButton1.Size = New System.Drawing.Size(68, 36)
        Me.MaterialRaisedButton1.TabIndex = 38
        Me.MaterialRaisedButton1.Text = "Insert"
        Me.MaterialRaisedButton1.UseVisualStyleBackColor = True
        '
        'adminNilaiTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 377)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.MaterialLabel10)
        Me.Controls.Add(Me.MaterialRaisedButton4)
        Me.Controls.Add(Me.MaterialRaisedButton5)
        Me.Controls.Add(Me.MaterialLabel9)
        Me.Controls.Add(Me.namajurusan)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.MaterialRaisedButton1)
        Me.Name = "adminNilaiTest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminNilaiTest"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents MaterialLabel10 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialRaisedButton4 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialRaisedButton5 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialLabel9 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents namajurusan As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents MaterialRaisedButton1 As MaterialSkin.Controls.MaterialRaisedButton
End Class
