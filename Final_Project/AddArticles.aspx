<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddArticles.aspx.cs" Inherits="Final_Project.AddArticles" %>
<asp:Content ID="Content1" ContentPlaceHolderID="maincontent" runat="server">
    <div class="add_ar">
    <h2 class="action_title">Add Article</h2>
    <div class="ar_name_div" >
        <label>Article Name:</label>
        <asp:TextBox runat="server" ID="articleTitle" Class="add_input"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ControlToValidate="articleTitle" ErrorMessage="Please enter article title"></asp:RequiredFieldValidator>
    
            </div>
    <div class="ar_content_div">
        <label>Article Content:</label>
        <asp:TextBox runat="server" ID="articleContent" Class="add_input" TextMode="MultiLine"></asp:TextBox>
       <asp:RequiredFieldValidator runat="server" ControlToValidate="articleContent" ErrorMessage="Please enter article content"></asp:RequiredFieldValidator>
    </div>
    
        <asp:Button Text="Add Article" OnClick="InsertArticle" Class="add_update_btn" runat="server" />
        </div>
        
</asp:Content>
