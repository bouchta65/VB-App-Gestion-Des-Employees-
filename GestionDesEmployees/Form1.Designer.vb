<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nbrEnfant = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txt_villeNais = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txt_prenom = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txt_add = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_cin = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txt_etatfam = New Guna.UI.WinForms.GunaComboBox()
        Me.date_nais = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.txt_nom = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.prenom = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GunaGradientButton3 = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaGradientButton6 = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaGradientButton5 = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaGradientButton4 = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaGradientButton1 = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaGradientButton2 = New Guna.UI.WinForms.GunaGradientButton()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Georgia", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(859, 91)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(263, 43)
        Me.Label10.TabIndex = 92
        Me.Label10.Text = "المعلومات الشخصية"
        Me.Label10.UseMnemonic = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Location = New System.Drawing.Point(-3, -7)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1306, 95)
        Me.Panel2.TabIndex = 73
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Goudy Stout", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(327, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(494, 66)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "المحكمة الإبتدائية طانطان"
        Me.Label2.UseMnemonic = False
        '
        'txt_nbrEnfant
        '
        Me.txt_nbrEnfant.BackColor = System.Drawing.Color.White
        Me.txt_nbrEnfant.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_nbrEnfant.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_nbrEnfant.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_nbrEnfant.LineColor = System.Drawing.Color.Gainsboro
        Me.txt_nbrEnfant.Location = New System.Drawing.Point(61, 336)
        Me.txt_nbrEnfant.Name = "txt_nbrEnfant"
        Me.txt_nbrEnfant.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_nbrEnfant.SelectedText = ""
        Me.txt_nbrEnfant.Size = New System.Drawing.Size(236, 30)
        Me.txt_nbrEnfant.TabIndex = 90
        Me.txt_nbrEnfant.Text = "0"
        '
        'txt_villeNais
        '
        Me.txt_villeNais.BackColor = System.Drawing.Color.White
        Me.txt_villeNais.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_villeNais.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_villeNais.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_villeNais.LineColor = System.Drawing.Color.Gainsboro
        Me.txt_villeNais.Location = New System.Drawing.Point(61, 266)
        Me.txt_villeNais.Name = "txt_villeNais"
        Me.txt_villeNais.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_villeNais.SelectedText = ""
        Me.txt_villeNais.Size = New System.Drawing.Size(236, 30)
        Me.txt_villeNais.TabIndex = 89
        '
        'txt_prenom
        '
        Me.txt_prenom.BackColor = System.Drawing.Color.White
        Me.txt_prenom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_prenom.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_prenom.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_prenom.LineColor = System.Drawing.Color.Gainsboro
        Me.txt_prenom.Location = New System.Drawing.Point(61, 189)
        Me.txt_prenom.Name = "txt_prenom"
        Me.txt_prenom.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_prenom.SelectedText = ""
        Me.txt_prenom.Size = New System.Drawing.Size(236, 30)
        Me.txt_prenom.TabIndex = 88
        '
        'txt_add
        '
        Me.txt_add.BackColor = System.Drawing.Color.White
        Me.txt_add.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_add.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_add.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_add.LineColor = System.Drawing.Color.Gainsboro
        Me.txt_add.Location = New System.Drawing.Point(61, 471)
        Me.txt_add.Name = "txt_add"
        Me.txt_add.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_add.SelectedText = ""
        Me.txt_add.Size = New System.Drawing.Size(825, 38)
        Me.txt_add.TabIndex = 87
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(924, 477)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(118, 22)
        Me.Label9.TabIndex = 86
        Me.Label9.Text = "العنوان الشخصي"
        '
        'txt_cin
        '
        Me.txt_cin.BackColor = System.Drawing.Color.White
        Me.txt_cin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_cin.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_cin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_cin.LineColor = System.Drawing.Color.Gainsboro
        Me.txt_cin.Location = New System.Drawing.Point(650, 399)
        Me.txt_cin.Name = "txt_cin"
        Me.txt_cin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_cin.SelectedText = ""
        Me.txt_cin.Size = New System.Drawing.Size(236, 26)
        Me.txt_cin.TabIndex = 84
        '
        'txt_etatfam
        '
        Me.txt_etatfam.BackColor = System.Drawing.Color.Transparent
        Me.txt_etatfam.BaseColor = System.Drawing.Color.White
        Me.txt_etatfam.BorderColor = System.Drawing.Color.Silver
        Me.txt_etatfam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txt_etatfam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txt_etatfam.FocusedColor = System.Drawing.Color.Empty
        Me.txt_etatfam.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txt_etatfam.ForeColor = System.Drawing.Color.Black
        Me.txt_etatfam.FormattingEnabled = True
        Me.txt_etatfam.Location = New System.Drawing.Point(650, 331)
        Me.txt_etatfam.Name = "txt_etatfam"
        Me.txt_etatfam.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_etatfam.OnHoverItemForeColor = System.Drawing.Color.White
        Me.txt_etatfam.Size = New System.Drawing.Size(236, 26)
        Me.txt_etatfam.TabIndex = 83
        '
        'date_nais
        '
        Me.date_nais.BaseColor = System.Drawing.Color.White
        Me.date_nais.BorderColor = System.Drawing.Color.Silver
        Me.date_nais.CustomFormat = Nothing
        Me.date_nais.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.date_nais.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.date_nais.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.date_nais.ForeColor = System.Drawing.Color.Black
        Me.date_nais.Location = New System.Drawing.Point(650, 247)
        Me.date_nais.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.date_nais.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.date_nais.Name = "date_nais"
        Me.date_nais.OnHoverBaseColor = System.Drawing.Color.White
        Me.date_nais.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.date_nais.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.date_nais.OnPressedColor = System.Drawing.Color.Black
        Me.date_nais.Size = New System.Drawing.Size(236, 40)
        Me.date_nais.TabIndex = 82
        Me.date_nais.Text = "mercredi 24 mai 2023"
        Me.date_nais.Value = New Date(2023, 5, 24, 12, 55, 2, 318)
        '
        'txt_nom
        '
        Me.txt_nom.BackColor = System.Drawing.Color.White
        Me.txt_nom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_nom.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_nom.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_nom.LineColor = System.Drawing.Color.Gainsboro
        Me.txt_nom.Location = New System.Drawing.Point(650, 180)
        Me.txt_nom.Name = "txt_nom"
        Me.txt_nom.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_nom.SelectedText = ""
        Me.txt_nom.Size = New System.Drawing.Size(236, 30)
        Me.txt_nom.TabIndex = 81
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(953, 398)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 22)
        Me.Label7.TabIndex = 80
        Me.Label7.Text = "رقم ب..ت.و"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(947, 336)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 22)
        Me.Label6.TabIndex = 79
        Me.Label6.Text = "الحالة العائلية"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(370, 336)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 22)
        Me.Label5.TabIndex = 78
        Me.Label5.Text = "عدد الأطفال"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(361, 266)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 22)
        Me.Label4.TabIndex = 77
        Me.Label4.Text = "مكان الإزدياد"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(947, 266)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 22)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "تاريخ الإزدياد"
        '
        'prenom
        '
        Me.prenom.AutoSize = True
        Me.prenom.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prenom.Location = New System.Drawing.Point(352, 189)
        Me.prenom.Name = "prenom"
        Me.prenom.Size = New System.Drawing.Size(104, 22)
        Me.prenom.TabIndex = 75
        Me.prenom.Text = "الإسم الشخصي"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(953, 189)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 22)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "الإسم العائلي"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GunaGradientButton6)
        Me.Panel1.Controls.Add(Me.GunaGradientButton5)
        Me.Panel1.Controls.Add(Me.GunaGradientButton4)
        Me.Panel1.Controls.Add(Me.GunaGradientButton1)
        Me.Panel1.Controls.Add(Me.GunaGradientButton2)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Location = New System.Drawing.Point(1128, 84)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(178, 631)
        Me.Panel1.TabIndex = 72
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.GestionDesEmployees.My.Resources.Resources.download_removebg_preview
        Me.PictureBox2.Location = New System.Drawing.Point(1148, 15)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(147, 79)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'GunaGradientButton3
        '
        Me.GunaGradientButton3.AnimationHoverSpeed = 0.07!
        Me.GunaGradientButton3.AnimationSpeed = 0.03!
        Me.GunaGradientButton3.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradientButton3.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.GunaGradientButton3.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.GunaGradientButton3.BorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaGradientButton3.FocusedColor = System.Drawing.Color.Empty
        Me.GunaGradientButton3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGradientButton3.ForeColor = System.Drawing.Color.White
        Me.GunaGradientButton3.Image = CType(resources.GetObject("GunaGradientButton3.Image"), System.Drawing.Image)
        Me.GunaGradientButton3.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaGradientButton3.Location = New System.Drawing.Point(8, 653)
        Me.GunaGradientButton3.Name = "GunaGradientButton3"
        Me.GunaGradientButton3.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaGradientButton3.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaGradientButton3.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton3.OnHoverImage = Nothing
        Me.GunaGradientButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientButton3.Radius = 20
        Me.GunaGradientButton3.Size = New System.Drawing.Size(144, 51)
        Me.GunaGradientButton3.TabIndex = 93
        Me.GunaGradientButton3.Text = "إضافة موظف"
        '
        'GunaGradientButton6
        '
        Me.GunaGradientButton6.AnimationHoverSpeed = 0.07!
        Me.GunaGradientButton6.AnimationSpeed = 0.03!
        Me.GunaGradientButton6.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradientButton6.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.GunaGradientButton6.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.GunaGradientButton6.BorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton6.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaGradientButton6.FocusedColor = System.Drawing.Color.Empty
        Me.GunaGradientButton6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGradientButton6.ForeColor = System.Drawing.Color.Black
        Me.GunaGradientButton6.Image = CType(resources.GetObject("GunaGradientButton6.Image"), System.Drawing.Image)
        Me.GunaGradientButton6.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaGradientButton6.Location = New System.Drawing.Point(13, 469)
        Me.GunaGradientButton6.Name = "GunaGradientButton6"
        Me.GunaGradientButton6.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaGradientButton6.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaGradientButton6.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton6.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton6.OnHoverImage = Nothing
        Me.GunaGradientButton6.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientButton6.Radius = 20
        Me.GunaGradientButton6.Size = New System.Drawing.Size(144, 51)
        Me.GunaGradientButton6.TabIndex = 75
        Me.GunaGradientButton6.Text = "إحصائيات"
        '
        'GunaGradientButton5
        '
        Me.GunaGradientButton5.AnimationHoverSpeed = 0.07!
        Me.GunaGradientButton5.AnimationSpeed = 0.03!
        Me.GunaGradientButton5.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradientButton5.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.GunaGradientButton5.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.GunaGradientButton5.BorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton5.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaGradientButton5.FocusedColor = System.Drawing.Color.Empty
        Me.GunaGradientButton5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGradientButton5.ForeColor = System.Drawing.Color.Black
        Me.GunaGradientButton5.Image = CType(resources.GetObject("GunaGradientButton5.Image"), System.Drawing.Image)
        Me.GunaGradientButton5.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaGradientButton5.Location = New System.Drawing.Point(13, 364)
        Me.GunaGradientButton5.Name = "GunaGradientButton5"
        Me.GunaGradientButton5.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaGradientButton5.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaGradientButton5.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton5.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton5.OnHoverImage = Nothing
        Me.GunaGradientButton5.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientButton5.Radius = 20
        Me.GunaGradientButton5.Size = New System.Drawing.Size(144, 51)
        Me.GunaGradientButton5.TabIndex = 74
        Me.GunaGradientButton5.Text = "معلومات"
        '
        'GunaGradientButton4
        '
        Me.GunaGradientButton4.AnimationHoverSpeed = 0.07!
        Me.GunaGradientButton4.AnimationSpeed = 0.03!
        Me.GunaGradientButton4.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradientButton4.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.GunaGradientButton4.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.GunaGradientButton4.BorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton4.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaGradientButton4.FocusedColor = System.Drawing.Color.Empty
        Me.GunaGradientButton4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGradientButton4.ForeColor = System.Drawing.Color.Black
        Me.GunaGradientButton4.Image = CType(resources.GetObject("GunaGradientButton4.Image"), System.Drawing.Image)
        Me.GunaGradientButton4.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaGradientButton4.Location = New System.Drawing.Point(13, 265)
        Me.GunaGradientButton4.Name = "GunaGradientButton4"
        Me.GunaGradientButton4.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaGradientButton4.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaGradientButton4.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton4.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton4.OnHoverImage = Nothing
        Me.GunaGradientButton4.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientButton4.Radius = 20
        Me.GunaGradientButton4.Size = New System.Drawing.Size(144, 51)
        Me.GunaGradientButton4.TabIndex = 73
        Me.GunaGradientButton4.Text = "الديمومة"
        '
        'GunaGradientButton1
        '
        Me.GunaGradientButton1.AnimationHoverSpeed = 0.07!
        Me.GunaGradientButton1.AnimationSpeed = 0.03!
        Me.GunaGradientButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradientButton1.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.GunaGradientButton1.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.GunaGradientButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaGradientButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaGradientButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGradientButton1.ForeColor = System.Drawing.Color.Black
        Me.GunaGradientButton1.Image = CType(resources.GetObject("GunaGradientButton1.Image"), System.Drawing.Image)
        Me.GunaGradientButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaGradientButton1.Location = New System.Drawing.Point(13, 161)
        Me.GunaGradientButton1.Name = "GunaGradientButton1"
        Me.GunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton1.OnHoverImage = Nothing
        Me.GunaGradientButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientButton1.Radius = 20
        Me.GunaGradientButton1.Size = New System.Drawing.Size(144, 51)
        Me.GunaGradientButton1.TabIndex = 72
        Me.GunaGradientButton1.Text = "الرخص     "
        '
        'GunaGradientButton2
        '
        Me.GunaGradientButton2.AnimationHoverSpeed = 0.07!
        Me.GunaGradientButton2.AnimationSpeed = 0.03!
        Me.GunaGradientButton2.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradientButton2.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.GunaGradientButton2.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.GunaGradientButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaGradientButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaGradientButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGradientButton2.ForeColor = System.Drawing.Color.Black
        Me.GunaGradientButton2.Image = CType(resources.GetObject("GunaGradientButton2.Image"), System.Drawing.Image)
        Me.GunaGradientButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaGradientButton2.Location = New System.Drawing.Point(13, 55)
        Me.GunaGradientButton2.Name = "GunaGradientButton2"
        Me.GunaGradientButton2.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaGradientButton2.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaGradientButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton2.OnHoverImage = Nothing
        Me.GunaGradientButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientButton2.Radius = 20
        Me.GunaGradientButton2.Size = New System.Drawing.Size(144, 51)
        Me.GunaGradientButton2.TabIndex = 70
        Me.GunaGradientButton2.Text = "إضافة موظف"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1303, 709)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GunaGradientButton3)
        Me.Controls.Add(Me.txt_nbrEnfant)
        Me.Controls.Add(Me.txt_villeNais)
        Me.Controls.Add(Me.txt_prenom)
        Me.Controls.Add(Me.txt_add)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_cin)
        Me.Controls.Add(Me.txt_etatfam)
        Me.Controls.Add(Me.date_nais)
        Me.Controls.Add(Me.txt_nom)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.prenom)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label10 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GunaGradientButton1 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GunaGradientButton3 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents txt_nbrEnfant As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txt_villeNais As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txt_prenom As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txt_add As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_cin As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txt_etatfam As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents date_nais As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents txt_nom As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents prenom As Label
    Friend WithEvents GunaGradientButton6 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GunaGradientButton4 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents Label1 As Label
    Friend WithEvents GunaGradientButton5 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GunaGradientButton2 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents Panel1 As Panel
End Class
