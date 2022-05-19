<%@ Page Title="" Language="C#" MasterPageFile="~/NoteTaking.Master" AutoEventWireup="true" CodeBehind="wfHomePage.aspx.cs" Inherits="NoteTakingApp.wfHomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="header">Stay Focused, Take Some Notes.</div>
    <div class="notesWrapperWrapper">
        <div class="notesWrapper">
            <div class="notesCont">

            </div>
            <div class="addNoteInputAndButtonSection">
                <asp:TextBox ID="tbxNoteValue" class="addNoteInput" placeholder="Add Note:" runat="server" />
                <asp:Button Text="Add" ID="btnSubmit" class="addNoteButton" runat="server" />
            </div>
        </div>
    </div>
</asp:Content>