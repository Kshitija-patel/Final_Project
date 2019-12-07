<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditArticle.aspx.cs" Inherits="Final_Project.EditArticle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="maincontent" runat="server">
    <h2 class="action_title">Update Article <span id="student_title" runat="server"></span></h2>
        
        <div class="u_articleTitle">
            <label>Article Title</label>
            <asp:TextBox runat="server" class="u_field" ID="u_arTitle"></asp:TextBox>
        </div>
        <div class="u_articleDate">
            <label>Article Date</label>
            <asp:TextBox runat="server"  class="u_field" ID="u_arDate" disabled="true"></asp:TextBox>
        </div>
        <div class="u_articleContent">
            <label>Article Content</label>
            <asp:TextBox runat="server" class="u_field" ID="u_arContent" TextMode="MultiLine"></asp:TextBox>
        </div>
        <div id="u_arCheck" runat="server">

        </div>

        <asp:Button Text="Update Article" OnClick="UpdateArticle" runat="server" />
  
</asp:Content>
