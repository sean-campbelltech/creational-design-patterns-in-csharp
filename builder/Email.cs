using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Builder
{
    // Product
    public class Email
    {
        public Email()
        {
            To = new List<string>();
            Cc = new List<string>();
            Bcc = new List<string>();
            Attachments = new List<string>();
        }

        public string From { get; set; }
        public List<string> To { get; set; }
        public List<string> Cc { get; set; }
        public List<string> Bcc { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public List<string> Attachments { get; set; }

        public void Send()
        {
            Console.WriteLine($"Email was successfully sent from {From} to {string.Join(", ", To)} with subject: {Subject}.");
        }
    }
}