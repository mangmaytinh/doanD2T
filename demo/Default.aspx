<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="demo.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lbntb" runat="server" Font-Size="XX-Large" ForeColor="Red"></asp:Label>

    <br />
    <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click"> Xác thực </asp:LinkButton>

</asp:Content>
