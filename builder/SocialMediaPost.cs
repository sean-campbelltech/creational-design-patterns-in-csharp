using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentBuilderCSharp
{
    public class SocialMediaPost
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public DateTime DatePosted { get; set; }
        public List<string> Tags { get; set; }
        public Uri ImageUri { get; set; }
        public List<Uri> Links { get; set; }

        public override string ToString()
        {
            return $"{nameof(Title)}:{Title}, {nameof(Content)}:{Content}, " +
                $"{nameof(Author)}:{Author}, {nameof(DatePosted)}:{DatePosted.ToString()}, " +
                $"{nameof(Tags)}:[{(Tags != null ? string.Join(",", Tags) : string.Empty)}], " +
                $"{nameof(ImageUri)}:{(ImageUri != null ? ImageUri.ToString() : string.Empty)}], " +
                $"{nameof(Links)}:[{(Links != null ? string.Join(",", Links) : string.Empty)}]";
        }
    }
}