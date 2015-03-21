<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.lnkForgotPass = New System.Windows.Forms.LinkLabel()
        Me.btnEntrar = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txtPass)
        Me.Panel1.Controls.Add(Me.txtUser)
        Me.Panel1.Controls.Add(Me.lblPass)
        Me.Panel1.Controls.Add(Me.lblUser)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Location = New System.Drawing.Point(59, 54)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(183, 124)
        Me.Panel1.TabIndex = 1
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPass.Location = New System.Drawing.Point(10, 91)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(125, 20)
        Me.txtPass.TabIndex = 3
        '
        'txtUser
        '
        Me.txtUser.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtUser.Location = New System.Drawing.Point(10, 46)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(125, 20)
        Me.txtUser.TabIndex = 2
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblPass.Location = New System.Drawing.Point(6, 68)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(78, 20)
        Me.lblPass.TabIndex = 1
        Me.lblPass.Text = "Password"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblUser.Location = New System.Drawing.Point(6, 23)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(48, 20)
        Me.lblUser.TabIndex = 0
        Me.lblUser.Text = "Login"
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.BackColor = System.Drawing.Color.Transparent
        Me.lblLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Bold)
        Me.lblLogin.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblLogin.Location = New System.Drawing.Point(64, 28)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(106, 39)
        Me.lblLogin.TabIndex = 4
        Me.lblLogin.Text = "Login"
        '
        'lnkForgotPass
        '
        Me.lnkForgotPass.ActiveLinkColor = System.Drawing.Color.Transparent
        Me.lnkForgotPass.AutoSize = True
        Me.lnkForgotPass.BackColor = System.Drawing.Color.Transparent
        Me.lnkForgotPass.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.lnkForgotPass.LinkColor = System.Drawing.Color.Transparent
        Me.lnkForgotPass.Location = New System.Drawing.Point(2, 218)
        Me.lnkForgotPass.Name = "lnkForgotPass"
        Me.lnkForgotPass.Size = New System.Drawing.Size(111, 13)
        Me.lnkForgotPass.TabIndex = 5
        Me.lnkForgotPass.TabStop = True
        Me.lnkForgotPass.Text = "Esqueci Minha Senha"
        '
        'btnEntrar
        '
        Me.btnEntrar.BackColor = System.Drawing.Color.DarkRed
        Me.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEntrar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnEntrar.FlatAppearance.BorderSize = 0
        Me.btnEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEntrar.ForeColor = System.Drawing.Color.White
        Me.btnEntrar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEntrar.Location = New System.Drawing.Point(59, 184)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(86, 31)
        Me.btnEntrar.TabIndex = 6
        Me.btnEntrar.Text = "Entrar"
        Me.btnEntrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnEntrar.UseVisualStyleBackColor = False
        '
        'btnSair
        '
        Me.btnSair.BackColor = System.Drawing.Color.Transparent
        Me.btnSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSair.FlatAppearance.BorderSize = 0
        Me.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSair.ForeColor = System.Drawing.Color.White
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSair.Location = New System.Drawing.Point(156, 184)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(86, 31)
        Me.btnSair.TabIndex = 8
        Me.btnSair.Text = "Sair"
        Me.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSair.UseVisualStyleBackColor = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(301, 240)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnEntrar)
        Me.Controls.Add(Me.lnkForgotPass)
        Me.Controls.Add(Me.lblLogin)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.HelpButton = True
        Me.Name = "frmLogin"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblPass As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents lblLogin As System.Windows.Forms.Label
    Friend WithEvents lnkForgotPass As System.Windows.Forms.LinkLabel
    Friend WithEvents btnEntrar As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button

End Class
