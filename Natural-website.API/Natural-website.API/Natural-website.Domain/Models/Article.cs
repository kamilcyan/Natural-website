using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Natural_website.Domain.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string TemplateName { get; set; }

        public string Header { get; set; }

        public string MainText { get; set; }

        public string Paragraph { get; set; }

        public string MainImage { get; set; }

        public string BackgroundImage { get; set; }
    }
}
