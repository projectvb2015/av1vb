﻿Public Class frmLogin
    
    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        user = "Marcos"
        pass = "123456"
        If txtUser.Text <> user Then
            MsgBox("Usuário não encontrado em nosso banco de dados.", vbCritical, "Error")
            txtUser.Text = ""
            txtPass.Text = ""
        ElseIf txtPass.Text <> pass Then
            MsgBox("Senha inválida.", vbCritical, "Error")
            txtUser.Text = ""
            txtPass.Text = ""
        Else
            frmMenu.Show()
            Me.Finalize()
        End If

    End Sub

    Private Sub lnkForgotPass_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkForgotPass.LinkClicked
        frmProfessor.Show()

    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Dim sair As String

        sair = MsgBox("Deseja Realmente Sair?", MsgBoxStyle.YesNoCancel, "Sair do sistema?")
        If sair = vbYes Then
            Close()
        End If

    End Sub
End Class
