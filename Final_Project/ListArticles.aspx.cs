using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Diagnostics;

namespace Final_Project
{
    public partial class ListArticles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ar_result.InnerHtml = "";

            var db = new ARTICLEDB();
            string searchbar = "";
            if (Page.IsPostBack)
            {
                searchbar = search_text.Text;
            }

            // query to list all articles
            string query = "select * from articles";

            if (searchbar != "")
            {
                // query to search a particular article using article title
                query += " where articletitle like '%" + searchbar + "%' ";
            }



            List<Dictionary<String, String>> rs = db.List_Query(query);
            foreach (Dictionary<String, String> row in rs)
            {
                ar_result.InnerHtml += "<div class=\"listitem\">";

                string articleId = row["articleid"];

                string articleDate = row["articledate"];
                DateTime articleDateTime = DateTime.Parse(articleDate);
                ar_result.InnerHtml += "<div class=\"ar_date\"><span class=\"date_int\">" + articleDateTime.ToString("dd") + "</span class=\"date_month\"><span>" + articleDateTime.ToString("MMM") + "</span></div>";
                Debug.WriteLine(articleDate);

                string articleTitle = row["articletitle"];
                ar_result.InnerHtml += "<div class=\"ar_title\"><a href=\"ViewArticles.aspx?articleid="+articleId+"\">" + articleTitle + "</a></div>";

               


                ar_result.InnerHtml += "</div>";
            }
        }
        // function called when add article button is clicked
        protected void AddArticle(object sender, EventArgs e)
        {
            Response.Redirect("AddArticles.aspx");

        }
    }
}