<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="myweb.login" %>

<%@ Register Src="~/inc/top.ascx" TagPrefix="uc1" TagName="top" %>


<!DOCTYPE html>



<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <uc1:top runat="server" ID="top" />
            <table width="800" align="center">
                <tr><td>用户名</td><td>
                    <asp:TextBox ID="username" runat="server"></asp:TextBox></td></tr>
                 <tr><td>密码</td><td>
                     <asp:TextBox ID="password" runat="server"></asp:TextBox></td></tr>
                 <tr><td><asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
                     <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="注册" />
                     </td></tr>
                     
               
            </table>
        </div>
    </form>
</body>
</html>
