Imports System.Net.Mail

Public Class frmForgot
    Private Sub txtForgot_TextChanged(sender As Object, e As EventArgs)
        txtForgot.Text = ""
    End Sub
    Private Sub btnForgot_Click(sender As Object, e As EventArgs) Handles btnForgot.Click

        Try
            Dim servidorsmtp As New SmtpClient()
            Dim email As New MailMessage()
            Dim emailDestino As String
            Dim password As String
            password = pass
            emailDestino = txtForgot.Text
            servidorsmtp.Credentials = New  _
                Net.NetworkCredential("projectvb2015@gmail.com", "yuriviadao")
            servidorsmtp.Port = 587
            servidorsmtp.Host = "smtp.gmail.com"
            email = New MailMessage
            email.From = New MailAddress("projectvb2015@gmail.com")
            email.To.Add("projectvb2015@gmail.com")
            email.Subject = "Senha de Login"
            email.Body = "Conforme solicitado segue sua senha para login no Sistema. Senha: " + password
            servidorsmtp.Send(email)
            MsgBox("E-mail enviado com sucesso", vbInformation, "Sucesso")
        Catch ex As Exception
            MsgBox("Ocorreu um Erro.", vbCritical, "Error")

        End Try
    End Sub

    
End Class