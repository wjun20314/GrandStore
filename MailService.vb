Imports System.Net.Mail.SmtpClient
Imports System.Net.Mail

Public Class MailService
    Public smtpServer As String
    Public userName As String
    Public password As String

    Public Sub New(ByVal _smtpServer As String, ByVal _userName As String, ByVal _password As String)
        smtpServer = _smtpServer
        userName = _userName
        password = _password
    End Sub

    Private Shared Function ServerCertificateValidationCallback(ByVal sender As Object, _
                                                               ByVal cert As System.Security.Cryptography.X509Certificates.X509Certificate, _
                                                               ByVal chain As System.Security.Cryptography.X509Certificates.X509Chain, _
                                                               ByVal sslPolicyErrors As Net.Security.SslPolicyErrors) As Boolean
        Return sslPolicyErrors = Net.Security.SslPolicyErrors.None
    End Function

    Public Function sendMail(ByVal fromAddress As String, ByVal toAddress As String,
                                ByVal subject As String, ByVal body As String,
                                Optional ByVal fromEmailName As String = "GrandSell",
                                Optional ByVal useSSL As Boolean = True,
                                Optional ByRef errMsg As String = "Mail Service Error") As Boolean
        Dim mm As New MailMessage()
        Dim client As New SmtpClient()
        Dim emailFrom As New MailAddress(fromAddress, fromEmailName)
        Dim NetworkCred As New System.Net.NetworkCredential()

        Try
            NetworkCred.UserName = userName
            NetworkCred.Password = password

            With mm
                .[To].Add(New MailAddress(toAddress))
                .From = emailFrom
                .Subject = subject
                .Body = body
                .IsBodyHtml = True
            End With

            With client
                .Host = smtpServer ' "smtp.gmail.com"
                .EnableSsl = useSSL ' You can also add this in the webconfig
                .UseDefaultCredentials = True
                .Credentials = NetworkCred
                .Port = 587
                .Send(mm)
            End With

        Catch ex As Exception
            errMsg = "Send Mail Error Exception : " + ex.Message
            Return False
        End Try

        Return True
    End Function
End Class
