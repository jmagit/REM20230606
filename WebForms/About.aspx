<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebForms.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>.</h2>
        <h3>Your application description page.<asp:LinkButton ID="LinkButton1" runat="server" CssClass="bg-danger">LinkButton</asp:LinkButton>
            <asp:Table ID="Table1" runat="server">
            </asp:Table>
    </h3>
        <p>Use this area to provide additional information.</p>
    </main>
</asp:Content>
