<%@ Page Title="" Language="C#" MasterPageFile="~/NoteTaking.Master" AutoEventWireup="true" CodeBehind="wfRegister.aspx.cs" Inherits="NoteTakingApp.wfRegister" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="align-to-middle">
        <div class="header-cont-public">
            <asp:Label runat="server" CssClass="header" Text="Register"></asp:Label>
        </div>
        <table>
            <tr>
                <td>
                    <asp:TextBox CssClass="input" ID="tbxUserNAme" placeholder="username:" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox CssClass="input" ID="tbxEmailAdress" placeholder="Email Address:" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox CssClass="input" ID="tbxPassword" placeholder="Password:" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button Text="Login" ID="accept" OnClick="accept_Click" runat="server" />    
                </td>
                <td>
                    <asp:Label ID="lblResult" runat="server" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
