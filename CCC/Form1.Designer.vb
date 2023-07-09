<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim Animation1 As Guna.UI.Animation.Animation = New Guna.UI.Animation.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.Panel3 = New Guna.UI.WinForms.GunaPanel()
        Me.label4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaCheckBox1 = New Guna.UI.WinForms.GunaCheckBox()
        Me.GunaLinkLabel3 = New Guna.UI.WinForms.GunaLinkLabel()
        Me.GunaLinkLabel4 = New Guna.UI.WinForms.GunaLinkLabel()
        Me.GunaButton2 = New Guna.UI.WinForms.GunaButton()
        Me.textbox7 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.textbox6 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.Panel2 = New Guna.UI.WinForms.GunaPanel()
        Me.checkboxPasswordCreate = New Guna.UI.WinForms.GunaCheckBox()
        Me.GunaLinkLabel2 = New Guna.UI.WinForms.GunaLinkLabel()
        Me.CheckBoxcreate = New Guna.UI.WinForms.GunaCheckBox()
        Me.GunaLinkLabel1 = New Guna.UI.WinForms.GunaLinkLabel()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.Textbox4 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Textbox5 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Textbox3 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Textbox2 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Textbox1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.anima1 = New Guna.UI.WinForms.GunaTransition(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.GunaPanel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaPanel1
        '
        Me.GunaPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.GunaPanel1.Controls.Add(Me.GunaLabel3)
        Me.GunaPanel1.Controls.Add(Me.GunaLabel7)
        Me.GunaPanel1.Controls.Add(Me.GunaLabel6)
        Me.GunaPanel1.Controls.Add(Me.GunaLabel1)
        Me.anima1.SetDecoration(Me.GunaPanel1, Guna.UI.Animation.DecorationType.None)
        Me.GunaPanel1.Location = New System.Drawing.Point(-4, 1)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(330, 609)
        Me.GunaPanel1.TabIndex = 0
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.anima1.SetDecoration(Me.GunaLabel3, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabel3.Font = New System.Drawing.Font("Maiandra GD", 7.0!)
        Me.GunaLabel3.ForeColor = System.Drawing.Color.Silver
        Me.GunaLabel3.Location = New System.Drawing.Point(66, 586)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(164, 12)
        Me.GunaLabel3.TabIndex = 7
        Me.GunaLabel3.Text = "Digital Archiving And Management"
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.anima1.SetDecoration(Me.GunaLabel7, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabel7.Font = New System.Drawing.Font("Segoe UI Symbol", 17.0!)
        Me.GunaLabel7.ForeColor = System.Drawing.Color.Silver
        Me.GunaLabel7.Location = New System.Drawing.Point(139, 272)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(93, 31)
        Me.GunaLabel7.TabIndex = 6
        Me.GunaLabel7.Text = "Cabinet"
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.anima1.SetDecoration(Me.GunaLabel6, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI Symbol", 17.0!)
        Me.GunaLabel6.ForeColor = System.Drawing.Color.Silver
        Me.GunaLabel6.Location = New System.Drawing.Point(139, 295)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(112, 31)
        Me.GunaLabel6.TabIndex = 5
        Me.GunaLabel6.Text = "Chahoudi"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.anima1.SetDecoration(Me.GunaLabel1, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabel1.Font = New System.Drawing.Font("Berlin Sans FB", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter)
        Me.GunaLabel1.ForeColor = System.Drawing.Color.Silver
        Me.GunaLabel1.Location = New System.Drawing.Point(33, 258)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(144, 83)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "CC "
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Panel3.Controls.Add(Me.label4)
        Me.Panel3.Controls.Add(Me.GunaCheckBox1)
        Me.Panel3.Controls.Add(Me.GunaLinkLabel3)
        Me.Panel3.Controls.Add(Me.GunaLinkLabel4)
        Me.Panel3.Controls.Add(Me.GunaButton2)
        Me.Panel3.Controls.Add(Me.textbox7)
        Me.Panel3.Controls.Add(Me.textbox6)
        Me.Panel3.Controls.Add(Me.GunaLabel2)
        Me.anima1.SetDecoration(Me.Panel3, Guna.UI.Animation.DecorationType.None)
        Me.Panel3.Location = New System.Drawing.Point(325, 1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(361, 609)
        Me.Panel3.TabIndex = 16
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.BackColor = System.Drawing.Color.Firebrick
        Me.anima1.SetDecoration(Me.label4, Guna.UI.Animation.DecorationType.None)
        Me.label4.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.label4.ForeColor = System.Drawing.Color.Silver
        Me.label4.Location = New System.Drawing.Point(21, 169)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(0, 19)
        Me.label4.TabIndex = 16
        '
        'GunaCheckBox1
        '
        Me.GunaCheckBox1.BaseColor = System.Drawing.Color.White
        Me.GunaCheckBox1.CheckedOffColor = System.Drawing.Color.Gray
        Me.GunaCheckBox1.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.anima1.SetDecoration(Me.GunaCheckBox1, Guna.UI.Animation.DecorationType.None)
        Me.GunaCheckBox1.FillColor = System.Drawing.Color.White
        Me.GunaCheckBox1.ForeColor = System.Drawing.Color.Silver
        Me.GunaCheckBox1.Location = New System.Drawing.Point(25, 303)
        Me.GunaCheckBox1.Name = "GunaCheckBox1"
        Me.GunaCheckBox1.Size = New System.Drawing.Size(111, 20)
        Me.GunaCheckBox1.TabIndex = 15
        Me.GunaCheckBox1.Text = "Show Password"
        '
        'GunaLinkLabel3
        '
        Me.GunaLinkLabel3.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.GunaLinkLabel3.AutoSize = True
        Me.anima1.SetDecoration(Me.GunaLinkLabel3, Guna.UI.Animation.DecorationType.None)
        Me.GunaLinkLabel3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.GunaLinkLabel3.LinkColor = System.Drawing.Color.Silver
        Me.GunaLinkLabel3.Location = New System.Drawing.Point(339, 1)
        Me.GunaLinkLabel3.Name = "GunaLinkLabel3"
        Me.GunaLinkLabel3.Size = New System.Drawing.Size(19, 20)
        Me.GunaLinkLabel3.TabIndex = 14
        Me.GunaLinkLabel3.TabStop = True
        Me.GunaLinkLabel3.Text = "X"
        '
        'GunaLinkLabel4
        '
        Me.GunaLinkLabel4.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.GunaLinkLabel4.AutoSize = True
        Me.anima1.SetDecoration(Me.GunaLinkLabel4, Guna.UI.Animation.DecorationType.None)
        Me.GunaLinkLabel4.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.GunaLinkLabel4.LinkColor = System.Drawing.Color.Silver
        Me.GunaLinkLabel4.Location = New System.Drawing.Point(109, 515)
        Me.GunaLinkLabel4.Name = "GunaLinkLabel4"
        Me.GunaLinkLabel4.Size = New System.Drawing.Size(110, 20)
        Me.GunaLinkLabel4.TabIndex = 12
        Me.GunaLinkLabel4.TabStop = True
        Me.GunaLinkLabel4.Text = "Create Account"
        '
        'GunaButton2
        '
        Me.GunaButton2.AnimationHoverSpeed = 0.07!
        Me.GunaButton2.AnimationSpeed = 0.03!
        Me.GunaButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.GunaButton2.BorderColor = System.Drawing.Color.Black
        Me.anima1.SetDecoration(Me.GunaButton2, Guna.UI.Animation.DecorationType.None)
        Me.GunaButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton2.ForeColor = System.Drawing.Color.White
        Me.GunaButton2.Image = Nothing
        Me.GunaButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton2.Location = New System.Drawing.Point(25, 386)
        Me.GunaButton2.Name = "GunaButton2"
        Me.GunaButton2.OnHoverBaseColor = System.Drawing.Color.SpringGreen
        Me.GunaButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton2.OnHoverImage = Nothing
        Me.GunaButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton2.Size = New System.Drawing.Size(292, 48)
        Me.GunaButton2.TabIndex = 11
        Me.GunaButton2.Text = "Sign In"
        Me.GunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'textbox7
        '
        Me.textbox7.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.textbox7.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.textbox7.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.textbox7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.anima1.SetDecoration(Me.textbox7, Guna.UI.Animation.DecorationType.None)
        Me.textbox7.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.textbox7.ForeColor = System.Drawing.Color.Silver
        Me.textbox7.HintForeColor = System.Drawing.Color.DimGray
        Me.textbox7.HintText = "Password"
        Me.textbox7.isPassword = True
        Me.textbox7.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.textbox7.LineIdleColor = System.Drawing.Color.Gray
        Me.textbox7.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.textbox7.LineThickness = 3
        Me.textbox7.Location = New System.Drawing.Point(25, 256)
        Me.textbox7.Margin = New System.Windows.Forms.Padding(4)
        Me.textbox7.MaxLength = 32767
        Me.textbox7.Name = "textbox7"
        Me.textbox7.Size = New System.Drawing.Size(292, 33)
        Me.textbox7.TabIndex = 10
        Me.textbox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'textbox6
        '
        Me.textbox6.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.textbox6.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.textbox6.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.textbox6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.anima1.SetDecoration(Me.textbox6, Guna.UI.Animation.DecorationType.None)
        Me.textbox6.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.textbox6.ForeColor = System.Drawing.Color.Silver
        Me.textbox6.HintForeColor = System.Drawing.Color.DimGray
        Me.textbox6.HintText = "Email"
        Me.textbox6.isPassword = False
        Me.textbox6.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.textbox6.LineIdleColor = System.Drawing.Color.Gray
        Me.textbox6.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.textbox6.LineThickness = 3
        Me.textbox6.Location = New System.Drawing.Point(25, 201)
        Me.textbox6.Margin = New System.Windows.Forms.Padding(4)
        Me.textbox6.MaxLength = 32767
        Me.textbox6.Name = "textbox6"
        Me.textbox6.Size = New System.Drawing.Size(292, 37)
        Me.textbox6.TabIndex = 7
        Me.textbox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.anima1.SetDecoration(Me.GunaLabel2, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabel2.Font = New System.Drawing.Font("Doppio One", 17.0!)
        Me.GunaLabel2.ForeColor = System.Drawing.Color.Silver
        Me.GunaLabel2.Location = New System.Drawing.Point(81, 61)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(186, 29)
        Me.GunaLabel2.TabIndex = 4
        Me.GunaLabel2.Text = "Authentification"
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Panel2.Controls.Add(Me.checkboxPasswordCreate)
        Me.Panel2.Controls.Add(Me.GunaLinkLabel2)
        Me.Panel2.Controls.Add(Me.CheckBoxcreate)
        Me.Panel2.Controls.Add(Me.GunaLinkLabel1)
        Me.Panel2.Controls.Add(Me.GunaButton1)
        Me.Panel2.Controls.Add(Me.Textbox4)
        Me.Panel2.Controls.Add(Me.Textbox5)
        Me.Panel2.Controls.Add(Me.Textbox3)
        Me.Panel2.Controls.Add(Me.Textbox2)
        Me.Panel2.Controls.Add(Me.Textbox1)
        Me.Panel2.Controls.Add(Me.GunaLabel5)
        Me.anima1.SetDecoration(Me.Panel2, Guna.UI.Animation.DecorationType.None)
        Me.Panel2.Location = New System.Drawing.Point(325, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(361, 609)
        Me.Panel2.TabIndex = 1
        Me.Panel2.Visible = False
        '
        'checkboxPasswordCreate
        '
        Me.checkboxPasswordCreate.BaseColor = System.Drawing.Color.White
        Me.checkboxPasswordCreate.CheckedOffColor = System.Drawing.Color.Gray
        Me.checkboxPasswordCreate.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.anima1.SetDecoration(Me.checkboxPasswordCreate, Guna.UI.Animation.DecorationType.None)
        Me.checkboxPasswordCreate.FillColor = System.Drawing.Color.White
        Me.checkboxPasswordCreate.ForeColor = System.Drawing.Color.Silver
        Me.checkboxPasswordCreate.Location = New System.Drawing.Point(25, 391)
        Me.checkboxPasswordCreate.Name = "checkboxPasswordCreate"
        Me.checkboxPasswordCreate.Size = New System.Drawing.Size(111, 20)
        Me.checkboxPasswordCreate.TabIndex = 15
        Me.checkboxPasswordCreate.Text = "Show Password"
        '
        'GunaLinkLabel2
        '
        Me.GunaLinkLabel2.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.GunaLinkLabel2.AutoSize = True
        Me.anima1.SetDecoration(Me.GunaLinkLabel2, Guna.UI.Animation.DecorationType.None)
        Me.GunaLinkLabel2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.GunaLinkLabel2.LinkColor = System.Drawing.Color.Silver
        Me.GunaLinkLabel2.Location = New System.Drawing.Point(339, 1)
        Me.GunaLinkLabel2.Name = "GunaLinkLabel2"
        Me.GunaLinkLabel2.Size = New System.Drawing.Size(19, 20)
        Me.GunaLinkLabel2.TabIndex = 14
        Me.GunaLinkLabel2.TabStop = True
        Me.GunaLinkLabel2.Text = "X"
        '
        'CheckBoxcreate
        '
        Me.CheckBoxcreate.BaseColor = System.Drawing.Color.White
        Me.CheckBoxcreate.CheckedOffColor = System.Drawing.Color.Gray
        Me.CheckBoxcreate.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.CheckBoxcreate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.anima1.SetDecoration(Me.CheckBoxcreate, Guna.UI.Animation.DecorationType.None)
        Me.CheckBoxcreate.FillColor = System.Drawing.Color.White
        Me.CheckBoxcreate.ForeColor = System.Drawing.Color.Silver
        Me.CheckBoxcreate.Location = New System.Drawing.Point(25, 417)
        Me.CheckBoxcreate.Name = "CheckBoxcreate"
        Me.CheckBoxcreate.Size = New System.Drawing.Size(247, 20)
        Me.CheckBoxcreate.TabIndex = 13
        Me.CheckBoxcreate.Text = "I'm not a Bot, And I'confirm my informations"
        '
        'GunaLinkLabel1
        '
        Me.GunaLinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.GunaLinkLabel1.AutoSize = True
        Me.anima1.SetDecoration(Me.GunaLinkLabel1, Guna.UI.Animation.DecorationType.None)
        Me.GunaLinkLabel1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.GunaLinkLabel1.LinkColor = System.Drawing.Color.Silver
        Me.GunaLinkLabel1.Location = New System.Drawing.Point(118, 518)
        Me.GunaLinkLabel1.Name = "GunaLinkLabel1"
        Me.GunaLinkLabel1.Size = New System.Drawing.Size(115, 20)
        Me.GunaLinkLabel1.TabIndex = 12
        Me.GunaLinkLabel1.TabStop = True
        Me.GunaLinkLabel1.Text = "Authentification"
        '
        'GunaButton1
        '
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.GunaButton1.BorderColor = System.Drawing.Color.Black
        Me.anima1.SetDecoration(Me.GunaButton1, Guna.UI.Animation.DecorationType.None)
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton1.ForeColor = System.Drawing.Color.White
        Me.GunaButton1.Image = Nothing
        Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton1.Location = New System.Drawing.Point(25, 452)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.SpringGreen
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Size = New System.Drawing.Size(292, 48)
        Me.GunaButton1.TabIndex = 11
        Me.GunaButton1.Text = "Create"
        Me.GunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Textbox4
        '
        Me.Textbox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.Textbox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.Textbox4.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Textbox4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.anima1.SetDecoration(Me.Textbox4, Guna.UI.Animation.DecorationType.None)
        Me.Textbox4.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Textbox4.ForeColor = System.Drawing.Color.Silver
        Me.Textbox4.HintForeColor = System.Drawing.Color.DimGray
        Me.Textbox4.HintText = "Password"
        Me.Textbox4.isPassword = True
        Me.Textbox4.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Textbox4.LineIdleColor = System.Drawing.Color.Gray
        Me.Textbox4.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.Textbox4.LineThickness = 3
        Me.Textbox4.Location = New System.Drawing.Point(25, 305)
        Me.Textbox4.Margin = New System.Windows.Forms.Padding(4)
        Me.Textbox4.MaxLength = 32767
        Me.Textbox4.Name = "Textbox4"
        Me.Textbox4.Size = New System.Drawing.Size(292, 33)
        Me.Textbox4.TabIndex = 10
        Me.Textbox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Textbox5
        '
        Me.Textbox5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.Textbox5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.Textbox5.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Textbox5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.anima1.SetDecoration(Me.Textbox5, Guna.UI.Animation.DecorationType.None)
        Me.Textbox5.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Textbox5.ForeColor = System.Drawing.Color.Silver
        Me.Textbox5.HintForeColor = System.Drawing.Color.DimGray
        Me.Textbox5.HintText = "Password"
        Me.Textbox5.isPassword = True
        Me.Textbox5.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Textbox5.LineIdleColor = System.Drawing.Color.Gray
        Me.Textbox5.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.Textbox5.LineThickness = 3
        Me.Textbox5.Location = New System.Drawing.Point(25, 346)
        Me.Textbox5.Margin = New System.Windows.Forms.Padding(4)
        Me.Textbox5.MaxLength = 32767
        Me.Textbox5.Name = "Textbox5"
        Me.Textbox5.Size = New System.Drawing.Size(292, 37)
        Me.Textbox5.TabIndex = 9
        Me.Textbox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Textbox3
        '
        Me.Textbox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.Textbox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.Textbox3.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Textbox3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.anima1.SetDecoration(Me.Textbox3, Guna.UI.Animation.DecorationType.None)
        Me.Textbox3.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Textbox3.ForeColor = System.Drawing.Color.Silver
        Me.Textbox3.HintForeColor = System.Drawing.Color.DimGray
        Me.Textbox3.HintText = "Email"
        Me.Textbox3.isPassword = False
        Me.Textbox3.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Textbox3.LineIdleColor = System.Drawing.Color.Gray
        Me.Textbox3.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.Textbox3.LineThickness = 3
        Me.Textbox3.Location = New System.Drawing.Point(25, 260)
        Me.Textbox3.Margin = New System.Windows.Forms.Padding(4)
        Me.Textbox3.MaxLength = 32767
        Me.Textbox3.Name = "Textbox3"
        Me.Textbox3.Size = New System.Drawing.Size(292, 37)
        Me.Textbox3.TabIndex = 7
        Me.Textbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Textbox2
        '
        Me.Textbox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.Textbox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.Textbox2.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Textbox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.anima1.SetDecoration(Me.Textbox2, Guna.UI.Animation.DecorationType.None)
        Me.Textbox2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Textbox2.ForeColor = System.Drawing.Color.Silver
        Me.Textbox2.HintForeColor = System.Drawing.Color.DimGray
        Me.Textbox2.HintText = "Last Name"
        Me.Textbox2.isPassword = False
        Me.Textbox2.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Textbox2.LineIdleColor = System.Drawing.Color.Gray
        Me.Textbox2.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.Textbox2.LineThickness = 3
        Me.Textbox2.Location = New System.Drawing.Point(25, 214)
        Me.Textbox2.Margin = New System.Windows.Forms.Padding(4)
        Me.Textbox2.MaxLength = 32767
        Me.Textbox2.Name = "Textbox2"
        Me.Textbox2.Size = New System.Drawing.Size(292, 37)
        Me.Textbox2.TabIndex = 6
        Me.Textbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Textbox1
        '
        Me.Textbox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.Textbox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.Textbox1.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Textbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.anima1.SetDecoration(Me.Textbox1, Guna.UI.Animation.DecorationType.None)
        Me.Textbox1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Textbox1.ForeColor = System.Drawing.Color.Silver
        Me.Textbox1.HintForeColor = System.Drawing.Color.DimGray
        Me.Textbox1.HintText = "First Name"
        Me.Textbox1.isPassword = False
        Me.Textbox1.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Textbox1.LineIdleColor = System.Drawing.Color.Gray
        Me.Textbox1.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.Textbox1.LineThickness = 3
        Me.Textbox1.Location = New System.Drawing.Point(25, 169)
        Me.Textbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.Textbox1.MaxLength = 32767
        Me.Textbox1.Name = "Textbox1"
        Me.Textbox1.Size = New System.Drawing.Size(292, 37)
        Me.Textbox1.TabIndex = 5
        Me.Textbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.anima1.SetDecoration(Me.GunaLabel5, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabel5.Font = New System.Drawing.Font("Doppio One", 17.0!)
        Me.GunaLabel5.ForeColor = System.Drawing.Color.Silver
        Me.GunaLabel5.Location = New System.Drawing.Point(79, 64)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(172, 29)
        Me.GunaLabel5.TabIndex = 4
        Me.GunaLabel5.Text = "Create Account"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'anima1
        '
        Me.anima1.AnimationType = Guna.UI.Animation.AnimationType.Transparent
        Me.anima1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0.0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0.0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0.0!
        Animation1.RotateLimit = 0.0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0.0!
        Animation1.TransparencyCoeff = 1.0!
        Me.anima1.DefaultAnimation = Animation1
        '
        'Timer2
        '
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Nothing
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(685, 609)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GunaPanel1)
        Me.anima1.SetDecoration(Me, Guna.UI.Animation.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login/Inscription"
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents Panel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents Textbox3 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Textbox2 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Textbox1 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Textbox4 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Textbox5 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents CheckBoxcreate As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents GunaLinkLabel1 As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents GunaLinkLabel2 As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents checkboxPasswordCreate As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents Panel3 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaCheckBox1 As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents GunaLinkLabel3 As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents GunaLinkLabel4 As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents GunaButton2 As Guna.UI.WinForms.GunaButton
    Friend WithEvents textbox7 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents textbox6 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents anima1 As Guna.UI.WinForms.GunaTransition
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents ErrorProvider2 As System.Windows.Forms.ErrorProvider
    Friend WithEvents label4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl

End Class
