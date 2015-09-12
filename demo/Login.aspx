<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="demo.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style3 {
            width: 155px;
        }
        .auto-style4 {
            width: 128px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div style="width: 275px; margin-left: 308px; margin-right: 74px;">
        <table>
            <tr>
                <td colspan="2">
                    <img  src="it.png" height="150" style="margin-left: 71px"  />
                   </td>
                
            </tr>
            <tr>
                <th class="auto-style3" >
                    Tên Đăng Nhập
                </th>
                <td class="auto-style4" >
                    <asp:TextBox ID="txtusername" runat="server"></asp:TextBox>
                </td>
            </tr>
            
            <tr>
                <th class="auto-style3" >
                    Mật khẩu
                </th>
                <td class="auto-style4">
                    <asp:TextBox ID="txtpass" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            
            <tr>
                <th class="auto-style3" >
                    <asp:Button ID="btnlogin" runat="server" Text="Đăng Nhập"  Width=100% Font-Bold OnClick="btnlogin_Click"/>
                </th>
                <td class="auto-style4">
                    <asp:Button ID="btncancel" runat="server" Text="Bỏ Qua"  Font-Bold OnClick="btncancel_Click"/>
                </td>
            </tr>
        </table>
    </div>
    </div>
    </form>
</body>
</html>
