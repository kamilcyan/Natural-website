using Natural_website.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Natural_website.Application
{
    public interface IArticleService
    {
        public IList<Article> GetFirst(int number);
    }
    internal class ArticleService : IArticleService
    {
        public IList<Article> GetFirst(int number)
        {
            var articles = new List<Article>();

            var a1 = new Article()
            {
                Id = 1,
                BackgroundImage = "https://placekitten.com/g/800/600",
                Header = "this is my header",
                MainImage = "",
                MainText = "this is my main text",
                Paragraph = "alfijsdglihdgk slg hskf hdskfhldsfj",
                TemplateName = "hero"
            };
            articles.Add(a1);
            a1 = new Article()
            {
                Id = 1,
                BackgroundImage = "https://scontent-fra5-2.xx.fbcdn.net/v/t39.30808-6/330772266_1265601007633498_8723478000557767086_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=5hZf3w8ceuMAX82Dnr3&tn=VWqX6ZWc2Wj0ZUBq&_nc_ht=scontent-fra5-2.xx&oh=00_AfAV5BSy4fSEhCsP0xy7QveqeG6DOiuC_WYBjqKJ_n8cUA&oe=63ED1AEE",
                Header = "Witamina C na zimę",
                MainImage = "",
                MainText = "Najwięcej witaminy C na zimę",
                Paragraph = "Owoce róży Karpatia mają nawet 1250 mg witaminy C w 100 g owoców!",
                TemplateName = "partial"
            };
            articles.Add(a1);
            a1 = new Article()
            {
                Id = 1,
                BackgroundImage = "https://placekitten.com/g/800/600",
                Header = "this is my header",
                MainImage = "",
                MainText = "this is my main text",
                Paragraph = "alfijsdglihdgk slg hskf hdskfhldsfj",
                TemplateName = "partial"
            };
            articles.Add(a1);

            a1 = new Article()
            {
                Id = 1,
                BackgroundImage = "https://placekitten.com/g/800/600",
                Header = "this is my header",
                MainImage = "",
                MainText = "this is my main text",
                Paragraph = "alfijsdglihdgk slg hskf hdskfhldsfj",
                TemplateName = "hero"
            };
            articles.Add(a1);
            return articles;
        }
    }
}
