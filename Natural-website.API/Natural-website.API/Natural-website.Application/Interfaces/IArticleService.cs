using Natural_website.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Natural_website.Application.Interfaces
{
    public interface IArticleService
    {
        public IList<Article> GetFirst(int number);
    }
}
