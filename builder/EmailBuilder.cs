using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Builder
{
    // Builder
    public class EmailBuilder
    {
        private readonly Email _email = new Email();

        public EmailBuilder AddFrom(string from)
        {
            // use regex to validate from email address...
            _email.From = from;
            return this;
        }

        public EmailBuilder AddTo(string to)
        {
            // use regex to validate from email address...
            _email.To.Add(to);
            return this;
        }

        public EmailBuilder AddCc(string cc)
        {
            // use regex to validate from email address...
            _email.Cc.Add(cc);
            return this;
        }

        public EmailBuilder AddBcc(string bcc)
        {
            // use regex to validate from email address...
            _email.Bcc.Add(bcc);
            return this;
        }

        public EmailBuilder WithSubject(string subject)
        {
            // check subject length and if illegal characters were used
            _email.Subject = subject;
            return this;
        }

        public EmailBuilder WithBody(string body)
        {
            // check if illegal characters were used
            _email.Body = body;
            return this;
        }


        public EmailBuilder AddAttachment(string attachment)
        {
            // validate attachment/file
            _email.Attachments.Add(attachment);
            return this;
        }

        public Email Build()
        {
            return _email;
        }
    }
}