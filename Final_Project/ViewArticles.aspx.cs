using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;

namespace Final_Project
{
    public partial class ViewArticles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool valid = true;
            string articleid = Request.QueryString["articleid"];
            if (String.IsNullOrEmpty(articleid)) valid = false;

           
            if (valid)
            {
                ARTICLEDB db = new ARTICLEDB();
                Articles ar_record = db.FindArticle(Int32.Parse(articleid));


                v_arTitle.InnerHtml = ar_record.GetArticleTitle();
                v_arDate.InnerHtml = ar_record.GetArticleDate().ToString("yyyy-M-dd");
                v_arContent.InnerHtml = ar_record.GetArticleContent();
            }
            else
            {
                arCheck.InnerHtml = "There was an error finding your article.";

            }
        }
            protected void DeleteArticle(object sender, EventArgs e)
            {
                bool valid = true;
                string articleid = Request.QueryString["articleid"];
                if (String.IsNullOrEmpty(articleid)) valid = false;
            Debug.WriteLine("in delete article");

                ARTICLEDB db = new ARTICLEDB();

                
                if (valid)
                {
                    db.DeleteArticle(Int32.Parse(articleid));
                    Response.Redirect("ListArticles.aspx");
                }
            }


        protected void UpdateArticle(object sender, EventArgs e)
        {
            string articleid = Request.QueryString["articleid"];
            Response.Redirect("EditArticle.aspx?articleid="+articleid);
            
        }


    }
}