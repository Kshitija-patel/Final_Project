<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewArticles.aspx.cs" Inherits="Final_Project.ViewArticles" %>
<asp:Content ID="Content1" ContentPlaceHolderID="maincontent" runat="server">
    <h2 class="action_title">Article Details</h2>
    <div class="ar_name_div">
        <div id="arCheck" runat="server">

        </div>
        <label>Article Name</label>
        <span id="v_arTitle" runat="server"></span>
    </div>
    <div class="ar_date_div">
        <label>Article Date</label>
        <span id="v_arDate" runat="server"></span>
    </div>
    <div class="ar_content_div">
        <label>Article Content</label>
        <span id="v_arContent" runat="server"></span>
    </div>
        <ASP:Button id="del_btn" class="v_btn" OnClientClick="if(!confirm('Are you sure you want to delete this?')) return false;" OnClick="DeleteArticle" Text="Delete" runat="server"/>
        <asp:Button id="edit_btn" class="v_btn" OnClick="UpdateArticle" Text="Update" runat="server" />

</asp:Content>
