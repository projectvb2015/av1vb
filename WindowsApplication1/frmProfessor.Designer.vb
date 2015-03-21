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
        Me.cmbDay = New System.Windows.Forms.ComboBox()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.cmbMonth = New System.Windows.Forms.ComboBox()
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
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(12, 37)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Nome:"
        '
        'lblSname
        '
        Me.lblSname.AutoSize = True
        Me.lblSname.Location = New System.Drawing.Point(12, 61)
        Me.lblSname.Name = "lblSname"
        Me.lblSname.Size = New System.Drawing.Size(64, 13)
        Me.lblSname.TabIndex = 1
        Me.lblSname.Text = "Sobrenome:"
        '
        'txtName
        '
        Me.txtName.AccessibleDescription = ""
        Me.txtName.AccessibleName = ""
        Me.txtName.Location = New System.Drawing.Point(77, 34)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(201, 20)
        Me.txtName.TabIndex = 2
        Me.txtName.UseWaitCursor = True
        '
        'txtSname
        '
        Me.txtSname.Location = New System.Drawing.Point(77, 58)
        Me.txtSname.Name = "txtSname"
        Me.txtSname.Size = New System.Drawing.Size(201, 20)
        Me.txtSname.TabIndex = 3
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Location = New System.Drawing.Point(15, 94)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(34, 13)
        Me.lblSexo.TabIndex = 4
        Me.lblSexo.Text = "Sexo:"
        '
        'lblcpf
        '
        Me.lblcpf.AutoSize = True
        Me.lblcpf.Location = New System.Drawing.Point(15, 124)
        Me.lblcpf.Name = "lblcpf"
        Me.lblcpf.Size = New System.Drawing.Size(30, 13)
        Me.lblcpf.TabIndex = 5
        Me.lblcpf.Text = "CPF:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(15, 178)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(109, 13)
        Me.lblDate.TabIndex = 6
        Me.lblDate.Text = "Data De Nascimento:"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton1.Location = New System.Drawing.Point(162, 95)
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
        Me.RadioButton2.Location = New System.Drawing.Point(77, 94)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(79, 18)
        Me.RadioButton2.TabIndex = 8
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Masculino"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'txtCpf
        '
        Me.txtCpf.Location = New System.Drawing.Point(77, 121)
        Me.txtCpf.Name = "txtCpf"
        Me.txtCpf.Size = New System.Drawing.Size(152, 20)
        Me.txtCpf.TabIndex = 9
        '
        'cmbDay
        '
        Me.cmbDay.FormattingEnabled = True
        Me.cmbDay.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17"})
        Me.cmbDay.Location = New System.Drawing.Point(134, 175)
        Me.cmbDay.Name = "cmbDay"
        Me.cmbDay.Size = New System.Drawing.Size(41, 21)
        Me.cmbDay.TabIndex = 10
        '
        'cmbYear
        '
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Location = New System.Drawing.Point(228, 175)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(64, 21)
        Me.cmbYear.TabIndex = 11
        '
        'cmbMonth
        '
        Me.cmbMonth.FormattingEnabled = True
        Me.cmbMonth.Location = New System.Drawing.Point(181, 175)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(41, 21)
        Me.cmbMonth.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "RG:"
        '
        'txtRg
        '
        Me.txtRg.Location = New System.Drawing.Point(77, 146)
        Me.txtRg.Name = "txtRg"
        Me.txtRg.Size = New System.Drawing.Size(154, 20)
        Me.txtRg.TabIndex = 14
        '
        'lblCep
        '
        Me.lblCep.AutoSize = True
        Me.lblCep.Location = New System.Drawing.Point(15, 316)
        Me.lblCep.Name = "lblCep"
        Me.lblCep.Size = New System.Drawing.Size(31, 13)
        Me.lblCep.TabIndex = 15
        Me.lblCep.Text = "CEP:"
        '
        'txtCep
        '
        Me.txtCep.Location = New System.Drawing.Point(77, 313)
        Me.txtCep.Name = "txtCep"
        Me.txtCep.Size = New System.Drawing.Size(100, 20)
        Me.txtCep.TabIndex = 16
        '
        'lblRua
        '
        Me.lblRua.AutoSize = True
        Me.lblRua.Location = New System.Drawing.Point(16, 343)
        Me.lblRua.Name = "lblRua"
        Me.lblRua.Size = New System.Drawing.Size(30, 13)
        Me.lblRua.TabIndex = 17
        Me.lblRua.Text = "Rua:"
        '
        'txtRua
        '
        Me.txtRua.Location = New System.Drawing.Point(77, 340)
        Me.txtRua.Name = "txtRua"
        Me.txtRua.Size = New System.Drawing.Size(182, 20)
        Me.txtRua.TabIndex = 18
        '
        'txtBairro
        '
        Me.txtBairro.Location = New System.Drawing.Point(77, 396)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(100, 20)
        Me.txtBairro.TabIndex = 19
        '
        'lblBairro
        '
        Me.lblBairro.AutoSize = True
        Me.lblBairro.Location = New System.Drawing.Point(16, 399)
        Me.lblBairro.Name = "lblBairro"
        Me.lblBairro.Size = New System.Drawing.Size(37, 13)
        Me.lblBairro.TabIndex = 20
        Me.lblBairro.Text = "Bairro:"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(276, 340)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(36, 20)
        Me.txtNumero.TabIndex = 21
        '
        'lblComp
        '
        Me.lblComp.AutoSize = True
        Me.lblComp.Location = New System.Drawing.Point(16, 370)
        Me.lblComp.Name = "lblComp"
        Me.lblComp.Size = New System.Drawing.Size(40, 13)
        Me.lblComp.TabIndex = 22
        Me.lblComp.Text = "Comp.:"
        '
        'txtComp
        '
        Me.txtComp.Location = New System.Drawing.Point(77, 367)
        Me.txtComp.Name = "txtComp"
        Me.txtComp.Size = New System.Drawing.Size(182, 20)
        Me.txtComp.TabIndex = 23
        '
        'lblCidade
        '
        Me.lblCidade.AutoSize = True
        Me.lblCidade.Location = New System.Drawing.Point(16, 426)
        Me.lblCidade.Name = "lblCidade"
        Me.lblCidade.Size = New System.Drawing.Size(43, 13)
        Me.lblCidade.TabIndex = 24
        Me.lblCidade.Text = "Cidade:"
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(77, 423)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(100, 20)
        Me.txtCidade.TabIndex = 25
        '
        'lblUf
        '
        Me.lblUf.AutoSize = True
        Me.lblUf.Location = New System.Drawing.Point(182, 426)
        Me.lblUf.Name = "lblUf"
        Me.lblUf.Size = New System.Drawing.Size(24, 13)
        Me.lblUf.TabIndex = 26
        Me.lblUf.Text = "UF:"
        '
        'cmbUf
        '
        Me.cmbUf.FormattingEnabled = True
        Me.cmbUf.Location = New System.Drawing.Point(212, 423)
        Me.cmbUf.Name = "cmbUf"
        Me.cmbUf.Size = New System.Drawing.Size(47, 21)
        Me.cmbUf.TabIndex = 27
        '
        'frmProfessor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 515)
        Me.Controls.Add(Me.cmbUf)
        Me.Controls.Add(Me.lblUf)
        Me.Controls.Add(Me.txtCidade)
        Me.Controls.Add(Me.lblCidade)
        Me.Controls.Add(Me.txtComp)
        Me.Controls.Add(Me.lblComp)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.lblBairro)
        Me.Controls.Add(Me.txtBairro)
        Me.Controls.Add(Me.txtRua)
        Me.Controls.Add(Me.lblRua)
        Me.Controls.Add(Me.txtCep)
        Me.Controls.Add(Me.lblCep)
        Me.Controls.Add(Me.txtRg)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbMonth)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.cmbDay)
        Me.Controls.Add(Me.txtCpf)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblcpf)
        Me.Controls.Add(Me.lblSexo)
        Me.Controls.Add(Me.txtSname)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblSname)
        Me.Controls.Add(Me.lblName)
        Me.Name = "frmProfessor"
        Me.Text = "Cadastro Professor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents cmbDay As System.Windows.Forms.ComboBox
    Friend WithEvents cmbYear As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMonth As System.Windows.Forms.ComboBox
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
End Class
