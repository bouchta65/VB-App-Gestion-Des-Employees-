<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class daymoma
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(daymoma))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txt_prenom = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txt_nom = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.prenom = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaGradientButton9 = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaGradientButton6 = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaGradientButton5 = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaGradientButton4 = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaGradientButton1 = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaGradientButton2 = New Guna.UI.WinForms.GunaGradientButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GunaDataGridView1 = New Guna.UI.WinForms.GunaDataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_semain = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txt_national = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_nbrJours = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaGradientButton8 = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaGradientButton7 = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaGradientButton3 = New Guna.UI.WinForms.GunaGradientButton()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.GunaDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Georgia", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(859, 91)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(263, 43)
        Me.Label10.TabIndex = 114
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
        Me.Panel2.TabIndex = 95
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
        'txt_prenom
        '
        Me.txt_prenom.BackColor = System.Drawing.Color.White
        Me.txt_prenom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_prenom.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_prenom.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_prenom.LineColor = System.Drawing.Color.Gainsboro
        Me.txt_prenom.Location = New System.Drawing.Point(144, 181)
        Me.txt_prenom.Name = "txt_prenom"
        Me.txt_prenom.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_prenom.SelectedText = ""
        Me.txt_prenom.Size = New System.Drawing.Size(236, 30)
        Me.txt_prenom.TabIndex = 110
        '
        'txt_nom
        '
        Me.txt_nom.BackColor = System.Drawing.Color.White
        Me.txt_nom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_nom.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_nom.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_nom.LineColor = System.Drawing.Color.Gainsboro
        Me.txt_nom.Location = New System.Drawing.Point(648, 181)
        Me.txt_nom.Name = "txt_nom"
        Me.txt_nom.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_nom.SelectedText = ""
        Me.txt_nom.Size = New System.Drawing.Size(236, 30)
        Me.txt_nom.TabIndex = 103
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(890, 248)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 22)
        Me.Label3.TabIndex = 98
        Me.Label3.Text = "تاريخ العطل الاسبوعية"
        '
        'prenom
        '
        Me.prenom.AutoSize = True
        Me.prenom.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prenom.Location = New System.Drawing.Point(513, 189)
        Me.prenom.Name = "prenom"
        Me.prenom.Size = New System.Drawing.Size(104, 22)
        Me.prenom.TabIndex = 97
        Me.prenom.Text = "الإسم الشخصي"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(953, 189)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 22)
        Me.Label1.TabIndex = 96
        Me.Label1.Text = "الإسم العائلي"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GunaGradientButton9)
        Me.Panel1.Controls.Add(Me.GunaGradientButton6)
        Me.Panel1.Controls.Add(Me.GunaGradientButton5)
        Me.Panel1.Controls.Add(Me.GunaGradientButton4)
        Me.Panel1.Controls.Add(Me.GunaGradientButton1)
        Me.Panel1.Controls.Add(Me.GunaGradientButton2)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Location = New System.Drawing.Point(1128, 84)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(178, 631)
        Me.Panel1.TabIndex = 94
        '
        'GunaGradientButton9
        '
        Me.GunaGradientButton9.AnimationHoverSpeed = 0.07!
        Me.GunaGradientButton9.AnimationSpeed = 0.03!
        Me.GunaGradientButton9.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradientButton9.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.GunaGradientButton9.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.GunaGradientButton9.BorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton9.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaGradientButton9.FocusedColor = System.Drawing.Color.Empty
        Me.GunaGradientButton9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGradientButton9.ForeColor = System.Drawing.Color.Black
        Me.GunaGradientButton9.Image = CType(resources.GetObject("GunaGradientButton9.Image"), System.Drawing.Image)
        Me.GunaGradientButton9.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaGradientButton9.Location = New System.Drawing.Point(13, 281)
        Me.GunaGradientButton9.Name = "GunaGradientButton9"
        Me.GunaGradientButton9.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaGradientButton9.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaGradientButton9.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton9.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton9.OnHoverImage = Nothing
        Me.GunaGradientButton9.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientButton9.Radius = 20
        Me.GunaGradientButton9.Size = New System.Drawing.Size(144, 51)
        Me.GunaGradientButton9.TabIndex = 76
        Me.GunaGradientButton9.Text = "التنقيط"
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
        Me.GunaGradientButton6.Location = New System.Drawing.Point(13, 435)
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
        Me.GunaGradientButton5.Location = New System.Drawing.Point(13, 356)
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
        Me.GunaGradientButton4.Location = New System.Drawing.Point(13, 132)
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
        Me.GunaGradientButton1.Location = New System.Drawing.Point(13, 210)
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(411, 245)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(208, 22)
        Me.Label4.TabIndex = 116
        Me.Label4.Text = "تاريخ الأعياد الوطنية او الدينية"
        '
        'GunaDataGridView1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.GunaDataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GunaDataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.GunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GunaDataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GunaDataGridView1.ColumnHeadersHeight = 40
        Me.GunaDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GunaDataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.GunaDataGridView1.EnableHeadersVisualStyles = False
        Me.GunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.GunaDataGridView1.Location = New System.Drawing.Point(8, 349)
        Me.GunaDataGridView1.Name = "GunaDataGridView1"
        Me.GunaDataGridView1.RowHeadersVisible = False
        Me.GunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GunaDataGridView1.Size = New System.Drawing.Size(1114, 298)
        Me.GunaDataGridView1.TabIndex = 118
        Me.GunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.WetAsphalt
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.GunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.Height = 40
        Me.GunaDataGridView1.ThemeStyle.ReadOnly = False
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.Height = 22
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'Column1
        '
        Me.Column1.HeaderText = "عدد الايام"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "تاريخ الأعياد الوطنية او الدينية "
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "تاريخ العطل الاسبوعية"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "الإطار"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "رقم البطاقة الوطنية للتعريف"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "رقم التأجير"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "الاسم الشخصي"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "الاسم العائلي"
        Me.Column8.Name = "Column8"
        '
        'txt_semain
        '
        Me.txt_semain.BackColor = System.Drawing.Color.White
        Me.txt_semain.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_semain.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_semain.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_semain.LineColor = System.Drawing.Color.Gainsboro
        Me.txt_semain.Location = New System.Drawing.Point(648, 237)
        Me.txt_semain.Name = "txt_semain"
        Me.txt_semain.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_semain.SelectedText = ""
        Me.txt_semain.Size = New System.Drawing.Size(236, 30)
        Me.txt_semain.TabIndex = 119
        '
        'txt_national
        '
        Me.txt_national.BackColor = System.Drawing.Color.White
        Me.txt_national.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_national.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_national.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_national.LineColor = System.Drawing.Color.Gainsboro
        Me.txt_national.Location = New System.Drawing.Point(144, 237)
        Me.txt_national.Name = "txt_national"
        Me.txt_national.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_national.SelectedText = ""
        Me.txt_national.Size = New System.Drawing.Size(236, 30)
        Me.txt_national.TabIndex = 120
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(973, 306)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 22)
        Me.Label5.TabIndex = 121
        Me.Label5.Text = "عدد الايام"
        '
        'txt_nbrJours
        '
        Me.txt_nbrJours.BackColor = System.Drawing.Color.White
        Me.txt_nbrJours.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_nbrJours.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_nbrJours.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_nbrJours.LineColor = System.Drawing.Color.Gainsboro
        Me.txt_nbrJours.Location = New System.Drawing.Point(648, 306)
        Me.txt_nbrJours.Name = "txt_nbrJours"
        Me.txt_nbrJours.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_nbrJours.SelectedText = ""
        Me.txt_nbrJours.Size = New System.Drawing.Size(236, 30)
        Me.txt_nbrJours.TabIndex = 122
        '
        'GunaGradientButton8
        '
        Me.GunaGradientButton8.AnimationHoverSpeed = 0.07!
        Me.GunaGradientButton8.AnimationSpeed = 0.03!
        Me.GunaGradientButton8.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradientButton8.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.GunaGradientButton8.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.GunaGradientButton8.BorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton8.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaGradientButton8.FocusedColor = System.Drawing.Color.Empty
        Me.GunaGradientButton8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGradientButton8.ForeColor = System.Drawing.Color.White
        Me.GunaGradientButton8.Image = CType(resources.GetObject("GunaGradientButton8.Image"), System.Drawing.Image)
        Me.GunaGradientButton8.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaGradientButton8.Location = New System.Drawing.Point(23, 653)
        Me.GunaGradientButton8.Name = "GunaGradientButton8"
        Me.GunaGradientButton8.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaGradientButton8.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaGradientButton8.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton8.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton8.OnHoverImage = Nothing
        Me.GunaGradientButton8.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientButton8.Radius = 20
        Me.GunaGradientButton8.Size = New System.Drawing.Size(144, 51)
        Me.GunaGradientButton8.TabIndex = 124
        Me.GunaGradientButton8.Text = "طباعة"
        '
        'GunaGradientButton7
        '
        Me.GunaGradientButton7.AnimationHoverSpeed = 0.07!
        Me.GunaGradientButton7.AnimationSpeed = 0.03!
        Me.GunaGradientButton7.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradientButton7.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.GunaGradientButton7.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.GunaGradientButton7.BorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton7.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaGradientButton7.FocusedColor = System.Drawing.Color.Empty
        Me.GunaGradientButton7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGradientButton7.ForeColor = System.Drawing.Color.White
        Me.GunaGradientButton7.Image = CType(resources.GetObject("GunaGradientButton7.Image"), System.Drawing.Image)
        Me.GunaGradientButton7.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaGradientButton7.Location = New System.Drawing.Point(200, 653)
        Me.GunaGradientButton7.Name = "GunaGradientButton7"
        Me.GunaGradientButton7.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaGradientButton7.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaGradientButton7.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton7.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton7.OnHoverImage = Nothing
        Me.GunaGradientButton7.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientButton7.Radius = 20
        Me.GunaGradientButton7.Size = New System.Drawing.Size(144, 51)
        Me.GunaGradientButton7.TabIndex = 123
        Me.GunaGradientButton7.Text = "إضافة "
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
        Me.GunaGradientButton3.Location = New System.Drawing.Point(381, 653)
        Me.GunaGradientButton3.Name = "GunaGradientButton3"
        Me.GunaGradientButton3.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaGradientButton3.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaGradientButton3.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton3.OnHoverImage = Nothing
        Me.GunaGradientButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientButton3.Radius = 20
        Me.GunaGradientButton3.Size = New System.Drawing.Size(144, 51)
        Me.GunaGradientButton3.TabIndex = 115
        Me.GunaGradientButton3.Text = "حذف  "
        '
        'daymoma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1303, 709)
        Me.Controls.Add(Me.GunaGradientButton8)
        Me.Controls.Add(Me.GunaGradientButton7)
        Me.Controls.Add(Me.txt_nbrJours)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_national)
        Me.Controls.Add(Me.txt_semain)
        Me.Controls.Add(Me.GunaDataGridView1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GunaGradientButton3)
        Me.Controls.Add(Me.txt_prenom)
        Me.Controls.Add(Me.txt_nom)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.prenom)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "daymoma"
        Me.Text = "daymoma"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.GunaDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label10 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GunaGradientButton5 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GunaGradientButton4 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GunaGradientButton6 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GunaGradientButton3 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents txt_prenom As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txt_nom As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents prenom As Label
    Friend WithEvents GunaGradientButton1 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents Label1 As Label
    Friend WithEvents GunaGradientButton2 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents GunaDataGridView1 As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents txt_semain As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txt_national As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_nbrJours As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaGradientButton7 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GunaGradientButton8 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GunaGradientButton9 As Guna.UI.WinForms.GunaGradientButton
End Class
