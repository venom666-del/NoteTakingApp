<%@ Page Title="" Language="C#" MasterPageFile="~/NoteTaking.Master" AutoEventWireup="true" CodeBehind="wfHomePage.aspx.cs" Inherits="NoteTakingApp.wfHomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="header">Stay Focused, Take Some Notes.</div>
    <div>
        <div class="notesCont"></div>
        <asp:TextBox ID="tbxNoteValue" placeholder="add note:" runat="server" />
    </div>
</asp:Content>