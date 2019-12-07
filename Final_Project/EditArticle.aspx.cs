using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_Project
{
    public partial class EditArticle : System.Web.UI.Page
    {
        ARTICLEDB db = new ARTICLEDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //to show the current data available 
                ShowArticleDetails(db);
            }
        }
        protected void UpdateArticle(object sender, EventArgs e)
        {


            bool valid = true;
            string articleid = Request.QueryString["articleid"];
            if (String.IsNullOrEmpty(articleid)) valid = false;
            if (valid)
            {
                Articles new_article = new Articles();
                // setting the updated data
                new_article.SetArticleTitle(u_arTitle.Text);
                new_article.SetArticleContent(u_arContent.Text);
                try
                {
                    //adding data to database
                    db.UpdateArticle(Int32.Parse(articleid), new_article);
                    Response.Redirect("ListArticles.aspx?articleid=" + articleid);
                }
                catch
                {
                    valid = false;
                }

            }

            if (!valid)
            {
                u_arCheck.InnerHtml = "There was an error updating that article.";
            }

        }
        protected void ShowArticleDetails(ARTICLEDB db)
        {
            bool valid = true;
            string articleid = Request.QueryString["articleid"];
            if (String.IsNullOrEmpty(articleid)) valid = false;

            if (valid)
            {
                Articles ar_record = db.FindArticle(Int32.Parse(articleid));

                // getting data from databse
                u_arTitle.Text = ar_record.GetArticleTitle();
                u_arDate.Text = ar_record.GetArticleDate().ToString("yyyy-M-dd");
                u_arContent.Text = ar_record.GetArticleContent();
            }
            else
            {
                u_arCheck.InnerHtml = "There was an error finding your article.";

            }

        }
    }
}