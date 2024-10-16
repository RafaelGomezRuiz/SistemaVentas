﻿using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;
using SistemaVentas.Core.Application.Dtos.Email;
using SistemaVentas.Core.Application.Interfaces.Services;
using SistemaVentas.Core.Domain.Settings;


namespace SistemaVentas.Infrastructure.Shared.Services
{
    public class EmailService : IEmailService
    {
        private MailSettings _mailSettings { get; }
        public EmailService(IOptions<MailSettings> _mailSettings)
        {
            this._mailSettings= _mailSettings.Value;
        }

        public async Task SendAsync(EmailRequest request)
        {
            try
            {
                MimeMessage email = new();
                email.Sender = MailboxAddress.Parse($"{_mailSettings.DisplayName} <{_mailSettings}>");
                email.To.Add(MailboxAddress.Parse(request.To));
                email.Subject = request.Subject;

                BodyBuilder builder = new();
                builder.HtmlBody = $"<h1>{request.Body}</h1>";
                email.Body = builder.ToMessageBody();

                using SmtpClient smtp = new SmtpClient();
                smtp.Connect(_mailSettings.SmtpHost, _mailSettings.SmtpPort, SecureSocketOptions.StartTls);

                smtp.Authenticate(_mailSettings.SmtpUser, _mailSettings.SmtpPassword);
                await smtp.SendAsync(email);
                smtp.Disconnect(true);
            }
            catch (Exception ex) { }
        }
    }
}
