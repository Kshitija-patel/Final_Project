using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;

namespace Final_Project
{
    public partial class AddArticles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("In add page");
        }
        //function to insert new article
        protected void InsertArticle(object sender, EventArgs e)
        {
            Debug.WriteLine("In add");
            ARTICLEDB db = new ARTICLEDB();
  
            Articles new_article = new Articles();
            //setting values to database
            new_article.SetArticleTitle(articleTitle.Text);
            new_article.SetArticleDate(DateTime.Now);
            new_article.SetArticleContent(articleContent.Text);
            Debug.WriteLine(new_article.GetArticleTitle());

            db.AddArticle(new_article);

            // redirecting to list page after completing adding process
            Response.Redirect("ListArticles.aspx");
        }
    }
}