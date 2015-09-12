<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Authencation.aspx.cs" Inherits="demo.Authencation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel runat="server" ID="pn" >
      
          <table>
            <tr>
                <th>
                    Phuong phap xac thuc
                </th>
                <th>
                    <asp:DropDownList ID="ddlotp" runat="server" AutoPostBack="True">
                    <asp:ListItem Value="SMS OTP">SMS OTP</asp:ListItem>
                        <asp:ListItem>EMAIL OTP</asp:ListItem>
                    </asp:DropDownList>
                </th>
                <th>
                    <asp:Button runat="server" ID="btnau" Text="Xac thuc" OnClick="btnau_Click" />
                </th>
            </tr>
        </table>
    </asp:Panel>

    
    <asp:Panel ID="pnotp" runat="server" Visible="false">
        <table>
            <tr>
                <td>
                    OTP code
                </td>
                <td>
                    <asp:TextBox ID="txtotp" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btncheck" runat="server" Text="Gui Ma" OnClick="btncheck_Click" />
                </td>
                
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="Panel1" runat="server" Visible="true" >
        <table>
            <tr>
                <td>
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Trang chủ</asp:LinkButton>
                <asp:Label ID="lbn" runat="server" Text="" ForeColor="Red">
                 </asp:Label>                                    
                </td>
            </tr>                                                   
        </table>
    </asp:Panel>
    
    
</asp:Content>
