<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListArticles.aspx.cs" Inherits="Final_Project.ListArticles" %>


<asp:Content ID="Content1" ContentPlaceHolderID="maincontent" runat="server">
     <h1 class="title_text">Articles</h1>
        <div class="search_form">
            <div class="search_div">
                <asp:TextBox ID="search_text" class="search_bar" runat="server" placeholder="Search articles"></asp:TextBox>
            </div>
            <div class="btn_div">
                <asp:Button class="search_btn" runat="server" Text="Search" />
            </div>
            <div class="btn_div1">
                <asp:Button class="search_btn" OnClick="AddArticle" runat="server" Text="Add" />
            </div>

        </div>
        
            <div class="ar_list" runat="server">
             <div id="ar_result" runat="server"></div>
           </div>
</asp:Content>
