using MailKit.Net.Smtp;
using MimeKit;
using MimeKit.Text;
using System;
using System.Threading.Tasks;

namespace RoutingDemo.Infrastructure
{
    public class MailSender
    {
        public static async Task<bool> Send(string bodyHtml)
        {
            var message = new MimeMessage
            {
                Sender = new MailboxAddress("WU18 Demos", "wu18@example.com"),
                Subject = "Using Razor as an Email template engine",
                Body = new TextPart(TextFormat.Html)
                {
                    Text = bodyHtml,
                    ContentTransferEncoding = ContentEncoding.QuotedPrintable
                },
            };

            message.To.Add(new MailboxAddress("patrik@xiento.se"));

            using (var client = new SmtpClient())
            {
                try
                {
                    client.Connect("localhost", 25, false);

                    await client.SendAsync(message);
                    client.Disconnect(true);
                    return true;
                }
                catch (Exception ex)
                {
                    //TODO: Logging
                    return false;
                }
            }
        }
    }
}
