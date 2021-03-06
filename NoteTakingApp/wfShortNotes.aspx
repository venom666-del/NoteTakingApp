<%@ Page Title="" Language="C#" MasterPageFile="~/NoteTaking.Master" AutoEventWireup="true" CodeBehind="wfShortNotes.aspx.cs" Inherits="NoteTakingApp.wfHomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="header">Stay Focused, Take Some Notes.</div>
    <div class="notesWrapperWrapper">
        <div class="notesWrapper">
            <div class="notesCont">
                <%=publicNotes %>
            </div>
            <div class="column-flex">
                <asp:TextBox ID="tbxNoteValue" class="addNoteInput" placeholder="Add Note:" runat="server" />
                <asp:TextBox ID="tbxNoteDescription" class="addDescriptionInput" placeholder="Add Note Description:" runat="server" />
                <asp:Button Text="Add" OnClick="btnSubmit_Click" ID="btnSubmit" class="addNoteButton" runat="server" />
            </div>
        </div>
    </div>
</asp:Content>