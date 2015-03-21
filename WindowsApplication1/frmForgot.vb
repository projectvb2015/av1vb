Imports System.Net.Mail

Public Class frmForgot

    


    Private Sub txtForgot_TextChanged(sender As Object, e As EventArgs)
        txtForgot.Text = ""
    End Sub
    Private Sub btnForgot_Click(sender As Object, e As EventArgs) Handles btnForgot.Click

        Try
            Dim servidorsmtp As New SmtpClient()
            Dim email As New MailMessage()
            servidorsmtp.Credentials = New  _
                Net.NetworkCredential("email", "senha")
            servidorsmtp.Port = 587
            servidorsmtp.Host = "smtp.ig.com.br"
            email = New MailMessage
            email.From = New MailAddress(txtForgot.Text)
            email.To.Add("marcos.p.barbosa@ig.com.br")
            email.Subject = "Senha de Login"
            email.Body = "Conforme solicitado segue abaixo sua senha para login no Sistema. Senha: " + pass
            servidorsmtp.Send(email)
            MsgBox("E-mail enviado com sucesso", vbInformation, "Sucesso")
        Catch ex As Exception
            MsgBox("Ocorreu um Erro.", vbCritical, "Error")

        End Try
    End Sub
End Class