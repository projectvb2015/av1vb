<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProfessor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProfessor))
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblSname = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtSname = New System.Windows.Forms.TextBox()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.lblcpf = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.txtCpf = New System.Windows.Forms.TextBox()
        Me.cmbDia = New System.Windows.Forms.ComboBox()
        Me.cmbAno = New System.Windows.Forms.ComboBox()
        Me.cmbMes = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRg = New System.Windows.Forms.TextBox()
        Me.lblCep = New System.Windows.Forms.Label()
        Me.txtCep = New System.Windows.Forms.TextBox()
        Me.lblRua = New System.Windows.Forms.Label()
        Me.txtRua = New System.Windows.Forms.TextBox()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.lblBairro = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.lblComp = New System.Windows.Forms.Label()
        Me.txtComp = New System.Windows.Forms.TextBox()
        Me.lblCidade = New System.Windows.Forms.Label()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.lblUf = New System.Windows.Forms.Label()
        Me.cmbUf = New System.Windows.Forms.ComboBox()
        Me.lblTituloProfDados = New System.Windows.Forms.Label()
        Me.lblNacionalidade = New System.Windows.Forms.Label()
        Me.cmbNacionalidade = New System.Windows.Forms.ComboBox()
        Me.pnlDadosPessoais = New System.Windows.Forms.Panel()
        Me.txtEmailProf = New System.Windows.Forms.TextBox()
        Me.lblEmailProf = New System.Windows.Forms.Label()
        Me.cmbEtnia = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbOrgaoRg = New System.Windows.Forms.ComboBox()
        Me.lblEmissorRg = New System.Windows.Forms.Label()
        Me.txtNaturalidade = New System.Windows.Forms.TextBox()
        Me.cmbUfNatural = New System.Windows.Forms.ComboBox()
        Me.lblNaturalidade = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblUfRg = New System.Windows.Forms.Label()
        Me.cmbDiaRg = New System.Windows.Forms.ComboBox()
        Me.cmbAnoRg = New System.Windows.Forms.ComboBox()
        Me.cmbMesRg = New System.Windows.Forms.ComboBox()
        Me.lblDataEmissao = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtCelProf = New System.Windows.Forms.TextBox()
        Me.txtDddCelProf = New System.Windows.Forms.TextBox()
        Me.lblCelProf = New System.Windows.Forms.Label()
        Me.txtTelProf = New System.Windows.Forms.TextBox()
        Me.txtDddProf = New System.Windows.Forms.TextBox()
        Me.lblTelProf = New System.Windows.Forms.Label()
        Me.cmbPaisProf = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.pnlDadosPessoais.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(7, 11)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Nome:"
        '
        'lblSname
        '
        Me.lblSname.AutoSize = True
        Me.lblSname.Location = New System.Drawing.Point(7, 35)
        Me.lblSname.Name = "lblSname"
        Me.lblSname.Size = New System.Drawing.Size(64, 13)
        Me.lblSname.TabIndex = 1
        Me.lblSname.Text = "Sobrenome:"
        '
        'txtName
        '
        Me.txtName.AccessibleDescription = ""
        Me.txtName.AccessibleName = ""
        Me.txtName.Location = New System.Drawing.Point(51, 8)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(334, 20)
        Me.txtName.TabIndex = 2
        Me.txtName.UseWaitCursor = True
        '
        'txtSname
        '
        Me.txtSname.Location = New System.Drawing.Point(72, 32)
        Me.txtSname.Name = "txtSname"
        Me.txtSname.Size = New System.Drawing.Size(345, 20)
        Me.txtSname.TabIndex = 3
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Location = New System.Drawing.Point(7, 142)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(34, 13)
        Me.lblSexo.TabIndex = 4
        Me.lblSexo.Text = "Sexo:"
        '
        'lblcpf
        '
        Me.lblcpf.AutoSize = True
        Me.lblcpf.Location = New System.Drawing.Point(7, 63)
        Me.lblcpf.Name = "lblcpf"
        Me.lblcpf.Size = New System.Drawing.Size(30, 13)
        Me.lblcpf.TabIndex = 5
        Me.lblcpf.Text = "CPF:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(7, 117)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(109, 13)
        Me.lblDate.TabIndex = 6
        Me.lblDate.Text = "Data De Nascimento:"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton1.Location = New System.Drawing.Point(132, 141)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(67, 17)
        Me.RadioButton1.TabIndex = 7
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Feminino"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RadioButton2.Location = New System.Drawing.Point(47, 140)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(79, 18)
        Me.RadioButton2.TabIndex = 8
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Masculino"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'txtCpf
        '
        Me.txtCpf.Location = New System.Drawing.Point(40, 60)
        Me.txtCpf.Name = "txtCpf"
        Me.txtCpf.Size = New System.Drawing.Size(152, 20)
        Me.txtCpf.TabIndex = 9
        '
        'cmbDia
        '
        Me.cmbDia.FormattingEnabled = True
        Me.cmbDia.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17"})
        Me.cmbDia.Location = New System.Drawing.Point(126, 114)
        Me.cmbDia.Name = "cmbDia"
        Me.cmbDia.Size = New System.Drawing.Size(41, 21)
        Me.cmbDia.TabIndex = 10
        '
        'cmbAno
        '
        Me.cmbAno.FormattingEnabled = True
        Me.cmbAno.Location = New System.Drawing.Point(220, 114)
        Me.cmbAno.Name = "cmbAno"
        Me.cmbAno.Size = New System.Drawing.Size(64, 21)
        Me.cmbAno.TabIndex = 11
        '
        'cmbMes
        '
        Me.cmbMes.FormattingEnabled = True
        Me.cmbMes.Location = New System.Drawing.Point(173, 114)
        Me.cmbMes.Name = "cmbMes"
        Me.cmbMes.Size = New System.Drawing.Size(41, 21)
        Me.cmbMes.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "RG:"
        '
        'txtRg
        '
        Me.txtRg.Location = New System.Drawing.Point(39, 85)
        Me.txtRg.Name = "txtRg"
        Me.txtRg.Size = New System.Drawing.Size(153, 20)
        Me.txtRg.TabIndex = 14
        '
        'lblCep
        '
        Me.lblCep.AutoSize = True
        Me.lblCep.Location = New System.Drawing.Point(8, 16)
        Me.lblCep.Name = "lblCep"
        Me.lblCep.Size = New System.Drawing.Size(31, 13)
        Me.lblCep.TabIndex = 15
        Me.lblCep.Text = "CEP:"
        '
        'txtCep
        '
        Me.txtCep.Location = New System.Drawing.Point(40, 13)
        Me.txtCep.Name = "txtCep"
        Me.txtCep.Size = New System.Drawing.Size(123, 20)
        Me.txtCep.TabIndex = 16
        '
        'lblRua
        '
        Me.lblRua.AutoSize = True
        Me.lblRua.Location = New System.Drawing.Point(8, 46)
        Me.lblRua.Name = "lblRua"
        Me.lblRua.Size = New System.Drawing.Size(30, 13)
        Me.lblRua.TabIndex = 17
        Me.lblRua.Text = "Rua:"
        '
        'txtRua
        '
        Me.txtRua.Location = New System.Drawing.Point(40, 43)
        Me.txtRua.Name = "txtRua"
        Me.txtRua.Size = New System.Drawing.Size(323, 20)
        Me.txtRua.TabIndex = 18
        '
        'txtBairro
        '
        Me.txtBairro.Location = New System.Drawing.Point(47, 75)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(100, 20)
        Me.txtBairro.TabIndex = 19
        '
        'lblBairro
        '
        Me.lblBairro.AutoSize = True
        Me.lblBairro.Location = New System.Drawing.Point(8, 78)
        Me.lblBairro.Name = "lblBairro"
        Me.lblBairro.Size = New System.Drawing.Size(37, 13)
        Me.lblBairro.TabIndex = 20
        Me.lblBairro.Text = "Bairro:"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(391, 43)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(36, 20)
        Me.txtNumero.TabIndex = 21
        '
        'lblComp
        '
        Me.lblComp.AutoSize = True
        Me.lblComp.Location = New System.Drawing.Point(445, 46)
        Me.lblComp.Name = "lblComp"
        Me.lblComp.Size = New System.Drawing.Size(40, 13)
        Me.lblComp.TabIndex = 22
        Me.lblComp.Text = "Comp.:"
        '
        'txtComp
        '
        Me.txtComp.Location = New System.Drawing.Point(482, 43)
        Me.txtComp.Name = "txtComp"
        Me.txtComp.Size = New System.Drawing.Size(199, 20)
        Me.txtComp.TabIndex = 23
        '
        'lblCidade
        '
        Me.lblCidade.AutoSize = True
        Me.lblCidade.Location = New System.Drawing.Point(158, 78)
        Me.lblCidade.Name = "lblCidade"
        Me.lblCidade.Size = New System.Drawing.Size(43, 13)
        Me.lblCidade.TabIndex = 24
        Me.lblCidade.Text = "Cidade:"
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(207, 75)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(100, 20)
        Me.txtCidade.TabIndex = 25
        '
        'lblUf
        '
        Me.lblUf.AutoSize = True
        Me.lblUf.Location = New System.Drawing.Point(315, 78)
        Me.lblUf.Name = "lblUf"
        Me.lblUf.Size = New System.Drawing.Size(24, 13)
        Me.lblUf.TabIndex = 26
        Me.lblUf.Text = "UF:"
        '
        'cmbUf
        '
        Me.cmbUf.FormattingEnabled = True
        Me.cmbUf.Location = New System.Drawing.Point(345, 75)
        Me.cmbUf.Name = "cmbUf"
        Me.cmbUf.Size = New System.Drawing.Size(47, 21)
        Me.cmbUf.TabIndex = 27
        '
        'lblTituloProfDados
        '
        Me.lblTituloProfDados.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTituloProfDados.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblTituloProfDados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTituloProfDados.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lblTituloProfDados.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblTituloProfDados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTituloProfDados.Location = New System.Drawing.Point(12, 46)
        Me.lblTituloProfDados.Name = "lblTituloProfDados"
        Me.lblTituloProfDados.Size = New System.Drawing.Size(794, 33)
        Me.lblTituloProfDados.TabIndex = 28
        Me.lblTituloProfDados.Text = "Dados Pessoais"
        Me.lblTituloProfDados.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblNacionalidade
        '
        Me.lblNacionalidade.AutoSize = True
        Me.lblNacionalidade.Location = New System.Drawing.Point(204, 63)
        Me.lblNacionalidade.Name = "lblNacionalidade"
        Me.lblNacionalidade.Size = New System.Drawing.Size(78, 13)
        Me.lblNacionalidade.TabIndex = 29
        Me.lblNacionalidade.Text = "Nacionalidade:"
        '
        'cmbNacionalidade
        '
        Me.cmbNacionalidade.FormattingEnabled = True
        Me.cmbNacionalidade.Location = New System.Drawing.Point(279, 60)
        Me.cmbNacionalidade.Name = "cmbNacionalidade"
        Me.cmbNacionalidade.Size = New System.Drawing.Size(136, 21)
        Me.cmbNacionalidade.TabIndex = 30
        '
        'pnlDadosPessoais
        '
        Me.pnlDadosPessoais.BackColor = System.Drawing.Color.Transparent
        Me.pnlDadosPessoais.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlDadosPessoais.Controls.Add(Me.txtEmailProf)
        Me.pnlDadosPessoais.Controls.Add(Me.lblEmailProf)
        Me.pnlDadosPessoais.Controls.Add(Me.cmbEtnia)
        Me.pnlDadosPessoais.Controls.Add(Me.Label3)
        Me.pnlDadosPessoais.Controls.Add(Me.cmbOrgaoRg)
        Me.pnlDadosPessoais.Controls.Add(Me.lblEmissorRg)
        Me.pnlDadosPessoais.Controls.Add(Me.txtNaturalidade)
        Me.pnlDadosPessoais.Controls.Add(Me.cmbUfNatural)
        Me.pnlDadosPessoais.Controls.Add(Me.lblNaturalidade)
        Me.pnlDadosPessoais.Controls.Add(Me.ComboBox1)
        Me.pnlDadosPessoais.Controls.Add(Me.lblUfRg)
        Me.pnlDadosPessoais.Controls.Add(Me.cmbDiaRg)
        Me.pnlDadosPessoais.Controls.Add(Me.cmbAnoRg)
        Me.pnlDadosPessoais.Controls.Add(Me.cmbMesRg)
        Me.pnlDadosPessoais.Controls.Add(Me.lblDataEmissao)
        Me.pnlDadosPessoais.Controls.Add(Me.txtSname)
        Me.pnlDadosPessoais.Controls.Add(Me.cmbNacionalidade)
        Me.pnlDadosPessoais.Controls.Add(Me.lblName)
        Me.pnlDadosPessoais.Controls.Add(Me.lblNacionalidade)
        Me.pnlDadosPessoais.Controls.Add(Me.lblSname)
        Me.pnlDadosPessoais.Controls.Add(Me.txtName)
        Me.pnlDadosPessoais.Controls.Add(Me.lblSexo)
        Me.pnlDadosPessoais.Controls.Add(Me.lblcpf)
        Me.pnlDadosPessoais.Controls.Add(Me.lblDate)
        Me.pnlDadosPessoais.Controls.Add(Me.RadioButton1)
        Me.pnlDadosPessoais.Controls.Add(Me.RadioButton2)
        Me.pnlDadosPessoais.Controls.Add(Me.txtCpf)
        Me.pnlDadosPessoais.Controls.Add(Me.cmbDia)
        Me.pnlDadosPessoais.Controls.Add(Me.cmbAno)
        Me.pnlDadosPessoais.Controls.Add(Me.cmbMes)
        Me.pnlDadosPessoais.Controls.Add(Me.Label1)
        Me.pnlDadosPessoais.Controls.Add(Me.txtRg)
        Me.pnlDadosPessoais.Location = New System.Drawing.Point(12, 66)
        Me.pnlDadosPessoais.Name = "pnlDadosPessoais"
        Me.pnlDadosPessoais.Size = New System.Drawing.Size(794, 170)
        Me.pnlDadosPessoais.TabIndex = 31
        '
        'txtEmailProf
        '
        Me.txtEmailProf.Location = New System.Drawing.Point(330, 139)
        Me.txtEmailProf.Name = "txtEmailProf"
        Me.txtEmailProf.Size = New System.Drawing.Size(314, 20)
        Me.txtEmailProf.TabIndex = 46
        '
        'lblEmailProf
        '
        Me.lblEmailProf.AutoSize = True
        Me.lblEmailProf.Location = New System.Drawing.Point(294, 142)
        Me.lblEmailProf.Name = "lblEmailProf"
        Me.lblEmailProf.Size = New System.Drawing.Size(39, 13)
        Me.lblEmailProf.TabIndex = 45
        Me.lblEmailProf.Text = "E-Mail:"
        '
        'cmbEtnia
        '
        Me.cmbEtnia.FormattingEnabled = True
        Me.cmbEtnia.Location = New System.Drawing.Point(500, 32)
        Me.cmbEtnia.Name = "cmbEtnia"
        Me.cmbEtnia.Size = New System.Drawing.Size(121, 21)
        Me.cmbEtnia.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(429, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Raça/Etnia:"
        '
        'cmbOrgaoRg
        '
        Me.cmbOrgaoRg.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbOrgaoRg.FormattingEnabled = True
        Me.cmbOrgaoRg.Location = New System.Drawing.Point(642, 84)
        Me.cmbOrgaoRg.Name = "cmbOrgaoRg"
        Me.cmbOrgaoRg.Size = New System.Drawing.Size(76, 21)
        Me.cmbOrgaoRg.TabIndex = 42
        '
        'lblEmissorRg
        '
        Me.lblEmissorRg.AutoSize = True
        Me.lblEmissorRg.Location = New System.Drawing.Point(558, 88)
        Me.lblEmissorRg.Name = "lblEmissorRg"
        Me.lblEmissorRg.Size = New System.Drawing.Size(78, 13)
        Me.lblEmissorRg.TabIndex = 41
        Me.lblEmissorRg.Text = "Órgão Emissor:"
        '
        'txtNaturalidade
        '
        Me.txtNaturalidade.Location = New System.Drawing.Point(482, 8)
        Me.txtNaturalidade.Name = "txtNaturalidade"
        Me.txtNaturalidade.Size = New System.Drawing.Size(140, 20)
        Me.txtNaturalidade.TabIndex = 40
        '
        'cmbUfNatural
        '
        Me.cmbUfNatural.FormattingEnabled = True
        Me.cmbUfNatural.Location = New System.Drawing.Point(628, 8)
        Me.cmbUfNatural.Name = "cmbUfNatural"
        Me.cmbUfNatural.Size = New System.Drawing.Size(44, 21)
        Me.cmbUfNatural.TabIndex = 39
        '
        'lblNaturalidade
        '
        Me.lblNaturalidade.AutoSize = True
        Me.lblNaturalidade.Location = New System.Drawing.Point(415, 11)
        Me.lblNaturalidade.Name = "lblNaturalidade"
        Me.lblNaturalidade.Size = New System.Drawing.Size(70, 13)
        Me.lblNaturalidade.TabIndex = 37
        Me.lblNaturalidade.Text = "Naturalidade:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(500, 85)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(43, 21)
        Me.ComboBox1.TabIndex = 36
        '
        'lblUfRg
        '
        Me.lblUfRg.AutoSize = True
        Me.lblUfRg.Location = New System.Drawing.Point(470, 88)
        Me.lblUfRg.Name = "lblUfRg"
        Me.lblUfRg.Size = New System.Drawing.Size(24, 13)
        Me.lblUfRg.TabIndex = 35
        Me.lblUfRg.Text = "UF:"
        '
        'cmbDiaRg
        '
        Me.cmbDiaRg.FormattingEnabled = True
        Me.cmbDiaRg.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17"})
        Me.cmbDiaRg.Location = New System.Drawing.Point(297, 85)
        Me.cmbDiaRg.Name = "cmbDiaRg"
        Me.cmbDiaRg.Size = New System.Drawing.Size(41, 21)
        Me.cmbDiaRg.TabIndex = 32
        '
        'cmbAnoRg
        '
        Me.cmbAnoRg.FormattingEnabled = True
        Me.cmbAnoRg.Location = New System.Drawing.Point(391, 85)
        Me.cmbAnoRg.Name = "cmbAnoRg"
        Me.cmbAnoRg.Size = New System.Drawing.Size(64, 21)
        Me.cmbAnoRg.TabIndex = 33
        '
        'cmbMesRg
        '
        Me.cmbMesRg.FormattingEnabled = True
        Me.cmbMesRg.Location = New System.Drawing.Point(344, 85)
        Me.cmbMesRg.Name = "cmbMesRg"
        Me.cmbMesRg.Size = New System.Drawing.Size(41, 21)
        Me.cmbMesRg.TabIndex = 34
        '
        'lblDataEmissao
        '
        Me.lblDataEmissao.AutoSize = True
        Me.lblDataEmissao.Location = New System.Drawing.Point(204, 88)
        Me.lblDataEmissao.Name = "lblDataEmissao"
        Me.lblDataEmissao.Size = New System.Drawing.Size(92, 13)
        Me.lblDataEmissao.TabIndex = 31
        Me.lblDataEmissao.Text = "Data De Emissão:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txtCelProf)
        Me.Panel1.Controls.Add(Me.txtDddCelProf)
        Me.Panel1.Controls.Add(Me.lblCelProf)
        Me.Panel1.Controls.Add(Me.txtTelProf)
        Me.Panel1.Controls.Add(Me.txtDddProf)
        Me.Panel1.Controls.Add(Me.lblTelProf)
        Me.Panel1.Controls.Add(Me.cmbPaisProf)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtCep)
        Me.Panel1.Controls.Add(Me.lblCep)
        Me.Panel1.Controls.Add(Me.lblRua)
        Me.Panel1.Controls.Add(Me.cmbUf)
        Me.Panel1.Controls.Add(Me.txtRua)
        Me.Panel1.Controls.Add(Me.lblUf)
        Me.Panel1.Controls.Add(Me.txtBairro)
        Me.Panel1.Controls.Add(Me.txtCidade)
        Me.Panel1.Controls.Add(Me.lblBairro)
        Me.Panel1.Controls.Add(Me.lblCidade)
        Me.Panel1.Controls.Add(Me.txtNumero)
        Me.Panel1.Controls.Add(Me.txtComp)
        Me.Panel1.Controls.Add(Me.lblComp)
        Me.Panel1.Location = New System.Drawing.Point(12, 259)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(794, 134)
        Me.Panel1.TabIndex = 32
        '
        'txtCelProf
        '
        Me.txtCelProf.Location = New System.Drawing.Point(306, 104)
        Me.txtCelProf.Name = "txtCelProf"
        Me.txtCelProf.Size = New System.Drawing.Size(124, 20)
        Me.txtCelProf.TabIndex = 36
        '
        'txtDddCelProf
        '
        Me.txtDddCelProf.Location = New System.Drawing.Point(267, 104)
        Me.txtDddCelProf.Name = "txtDddCelProf"
        Me.txtDddCelProf.Size = New System.Drawing.Size(33, 20)
        Me.txtDddCelProf.TabIndex = 35
        '
        'lblCelProf
        '
        Me.lblCelProf.AutoSize = True
        Me.lblCelProf.Location = New System.Drawing.Point(220, 107)
        Me.lblCelProf.Name = "lblCelProf"
        Me.lblCelProf.Size = New System.Drawing.Size(42, 13)
        Me.lblCelProf.TabIndex = 34
        Me.lblCelProf.Text = "Celular:"
        '
        'txtTelProf
        '
        Me.txtTelProf.Location = New System.Drawing.Point(105, 104)
        Me.txtTelProf.Name = "txtTelProf"
        Me.txtTelProf.Size = New System.Drawing.Size(109, 20)
        Me.txtTelProf.TabIndex = 33
        '
        'txtDddProf
        '
        Me.txtDddProf.Location = New System.Drawing.Point(66, 104)
        Me.txtDddProf.Name = "txtDddProf"
        Me.txtDddProf.Size = New System.Drawing.Size(33, 20)
        Me.txtDddProf.TabIndex = 32
        '
        'lblTelProf
        '
        Me.lblTelProf.AutoSize = True
        Me.lblTelProf.Location = New System.Drawing.Point(8, 107)
        Me.lblTelProf.Name = "lblTelProf"
        Me.lblTelProf.Size = New System.Drawing.Size(52, 13)
        Me.lblTelProf.TabIndex = 31
        Me.lblTelProf.Text = "Telefone:"
        '
        'cmbPaisProf
        '
        Me.cmbPaisProf.FormattingEnabled = True
        Me.cmbPaisProf.Location = New System.Drawing.Point(432, 75)
        Me.cmbPaisProf.Name = "cmbPaisProf"
        Me.cmbPaisProf.Size = New System.Drawing.Size(130, 21)
        Me.cmbPaisProf.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(398, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "País:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(370, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Nº"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(12, 240)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(794, 31)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Contato"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(785, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(32, 41)
        Me.btnClose.TabIndex = 33
        Me.ToolTip1.SetToolTip(Me.btnClose, "Fechar?")
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnLimpar
        '
        Me.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimpar.Image = CType(resources.GetObject("btnLimpar.Image"), System.Drawing.Image)
        Me.btnLimpar.Location = New System.Drawing.Point(12, 399)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(39, 35)
        Me.btnLimpar.TabIndex = 38
        Me.ToolTip1.SetToolTip(Me.btnLimpar, "Apagar Dados?")
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalvar.Image = CType(resources.GetObject("btnSalvar.Image"), System.Drawing.Image)
        Me.btnSalvar.Location = New System.Drawing.Point(765, 399)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(41, 36)
        Me.btnSalvar.TabIndex = 39
        Me.ToolTip1.SetToolTip(Me.btnSalvar, "Salvar Dados.")
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'frmProfessor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(818, 443)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlDadosPessoais)
        Me.Controls.Add(Me.lblTituloProfDados)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmProfessor"
        Me.Text = "Cadastro Professor"
        Me.pnlDadosPessoais.ResumeLayout(False)
        Me.pnlDadosPessoais.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblSname As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtSname As System.Windows.Forms.TextBox
    Friend WithEvents lblSexo As System.Windows.Forms.Label
    Friend WithEvents lblcpf As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents txtCpf As System.Windows.Forms.TextBox
    Friend WithEvents cmbDia As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAno As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMes As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRg As System.Windows.Forms.TextBox
    Friend WithEvents lblCep As System.Windows.Forms.Label
    Friend WithEvents txtCep As System.Windows.Forms.TextBox
    Friend WithEvents lblRua As System.Windows.Forms.Label
    Friend WithEvents txtRua As System.Windows.Forms.TextBox
    Friend WithEvents txtBairro As System.Windows.Forms.TextBox
    Friend WithEvents lblBairro As System.Windows.Forms.Label
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents lblComp As System.Windows.Forms.Label
    Friend WithEvents txtComp As System.Windows.Forms.TextBox
    Friend WithEvents lblCidade As System.Windows.Forms.Label
    Friend WithEvents txtCidade As System.Windows.Forms.TextBox
    Friend WithEvents lblUf As System.Windows.Forms.Label
    Friend WithEvents cmbUf As System.Windows.Forms.ComboBox
    Friend WithEvents lblTituloProfDados As System.Windows.Forms.Label
    Friend WithEvents lblNacionalidade As System.Windows.Forms.Label
    Friend WithEvents cmbNacionalidade As System.Windows.Forms.ComboBox
    Friend WithEvents pnlDadosPessoais As System.Windows.Forms.Panel
    Friend WithEvents cmbDiaRg As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAnoRg As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMesRg As System.Windows.Forms.ComboBox
    Friend WithEvents lblDataEmissao As System.Windows.Forms.Label
    Friend WithEvents cmbEtnia As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbOrgaoRg As System.Windows.Forms.ComboBox
    Friend WithEvents lblEmissorRg As System.Windows.Forms.Label
    Friend WithEvents txtNaturalidade As System.Windows.Forms.TextBox
    Friend WithEvents cmbUfNatural As System.Windows.Forms.ComboBox
    Friend WithEvents lblNaturalidade As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents lblUfRg As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtEmailProf As System.Windows.Forms.TextBox
    Friend WithEvents lblEmailProf As System.Windows.Forms.Label
    Friend WithEvents txtCelProf As System.Windows.Forms.TextBox
    Friend WithEvents txtDddCelProf As System.Windows.Forms.TextBox
    Friend WithEvents lblCelProf As System.Windows.Forms.Label
    Friend WithEvents txtTelProf As System.Windows.Forms.TextBox
    Friend WithEvents txtDddProf As System.Windows.Forms.TextBox
    Friend WithEvents lblTelProf As System.Windows.Forms.Label
    Friend WithEvents cmbPaisProf As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
End Class
