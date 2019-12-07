using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace Final_Project
{
    //reference: Class examples (https://github.com/christinebittle/HTTP_5101_FALL2019)
    public class ARTICLEDB
    {
        private static string User { get { return "root"; } }
        private static string Password { get { return "root"; } }
        private static string Database { get { return "articles_db"; } }
        private static string Server { get { return "localhost"; } }
        private static string Port { get { return "3306"; } }


        private static string ConnectionString
        {
            get
            {
                return "server = " + Server
                    + "; user = " + User
                    + "; database = " + Database
                    + "; port = " + Port
                    + "; password = " + Password;
            }
        }

        //a dictionary is like a list but with Key:Value pairs

        public List<Dictionary<String, String>> List_Query(string query)
        {
            //initialize connection
            MySqlConnection Connect = new MySqlConnection(ConnectionString);
         
            List<Dictionary<String, String>> ResultSet = new List<Dictionary<String, String>>();

            try
            {
                Debug.WriteLine("Connection Initialized...");
                Debug.WriteLine("Attempting to execute query " + query);
                
                Connect.Open();
                //query is given to the connection
                MySqlCommand cmd = new MySqlCommand(query, Connect);
                // getting resultset
                MySqlDataReader resultset = cmd.ExecuteReader();


               
                while (resultset.Read())
                {
                    Dictionary<String, String> Row = new Dictionary<String, String>();
                    
                    for (int i = 0; i < resultset.FieldCount; i++)
                    {
                        Row.Add(resultset.GetName(i), resultset.GetString(i));

                    }

                    ResultSet.Add(Row);
                }
                resultset.Close();


            }
            catch (Exception ex)
            {
                Debug.WriteLine("Something went wrong in the List_Query method!");
                Debug.WriteLine(ex.ToString());

            }

            Connect.Close();
            Debug.WriteLine("Database Connection Terminated.");

            return ResultSet;
        }
        //function to add new arcticles
        public void AddArticle(Articles new_article)
        {
            string query;
           
            {
                //query to insert new article into database 
                query = "INSERT INTO articles(articletitle,articledate,articlecontent) VALUES ('{0}','{1}','{2}')";
                query = String.Format(query, new_article.GetArticleTitle(), new_article.GetArticleDate().ToString("yyyy-MM-dd H:mm:ss"), new_article.GetArticleContent());
            }

            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            try
            {
                Connect.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Debug.WriteLine("Something went wrong in the AddEditDocument Method!");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();
        }
        //function to search a particular article
        public Articles FindArticle(int aid)
        {
            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            
            Articles result_article = new Articles();

            try
            {
                //query to search the article using article id
                string query = "select * from articles where articleid = " + aid;
                Debug.WriteLine("Connection Initialized...");
               
                Connect.Open();
                MySqlCommand cmd = new MySqlCommand(query, Connect);
                MySqlDataReader resultset = cmd.ExecuteReader();

                List<Articles> articles = new List<Articles>();

                while (resultset.Read())
                {
                    Articles thisarticle = new Articles();

                    for (int i = 0; i < resultset.FieldCount; i++)
                    {
                        string key = resultset.GetName(i);
                        string value = resultset.GetString(i);
                        Debug.WriteLine("Attempting to transfer " + key + " data of " + value);
                        //setting value in article object  
                        switch (key)
                        {
                            case "articletitle":
                                thisarticle.SetArticleTitle(value);
                                break;
                            case "articledate":
                                thisarticle.SetArticleDate(DateTime.Now);
                                break;
                            case "articlecontent":
                                thisarticle.SetArticleContent(value);
                                break;

                        }

                    }
                    
                    articles.Add(thisarticle);
                }

                result_article = articles[0]; 

            }
            catch (Exception ex)
            {
               
                Debug.WriteLine("Something went wrong in the find Article method!");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();
            Debug.WriteLine("Database Connection Terminated.");

            return result_article;
        }
        public void DeleteArticle(int articleid)
        {
            // query to delete a specific article
            string removearticle = "delete from articles where articleid = {0}";
            removearticle = String.Format(removearticle, articleid);
            Debug.WriteLine(removearticle);
            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            
            MySqlCommand cmd_removearticle = new MySqlCommand(removearticle, Connect);
            try
            {
               
                Connect.Open();
                cmd_removearticle.ExecuteNonQuery();
                Debug.WriteLine("Executed query " + cmd_removearticle);
            }
            catch (Exception ex)
            {
                
                Debug.WriteLine("Something went wrong in the delete Article Method!");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();
        }
        public void UpdateArticle(int articleid, Articles new_article)
        {
            // query to update a article
            
            string query = "update articles set articletitle='{0}', articlecontent='{1}' where articleid={2}";
            query = String.Format(query, new_article.GetArticleTitle(), new_article.GetArticleContent(), articleid);
            
            Debug.WriteLine(query);
            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            try
            {
                
                Connect.Open();
                cmd.ExecuteNonQuery();
                Debug.WriteLine("Executed query " + query);
            }
            catch (Exception ex)
            {
               
                Debug.WriteLine("Something went wrong in the Update Article Method!");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();
        }

    }
}