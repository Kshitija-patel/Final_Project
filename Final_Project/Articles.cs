using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final_Project
{
    public class Articles
    {
        private string ArticleTitle;
        private DateTime ArticleDate = DateTime.Now;
        private string ArticleContent;


        public string GetArticleTitle()
        {
            return ArticleTitle;
        }
        public DateTime GetArticleDate()
        {
            return ArticleDate;
        }
        public string GetArticleContent()
        {
            return ArticleContent;
        }

      

        public void SetArticleTitle(string value)
        {
            ArticleTitle = value;
        }
        public void SetArticleDate(DateTime value)
        {
            ArticleDate = value;
        }

        public void SetArticleContent(string value)
        {
            ArticleContent = value;
        }
    }
}