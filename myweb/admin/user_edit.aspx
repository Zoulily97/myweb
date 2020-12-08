<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="user_edit.aspx.cs" Inherits="myweb.user_edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
   <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td></td>
                </tr>
            </table>
        </div>
        <asp:Label ID="Label1" runat="server" Text="用户名"></asp:Label>
        <asp:TextBox ID="username" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="密  码"></asp:Label>
&nbsp;<asp:TextBox ID="password" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="姓名"></asp:Label>
            <asp:TextBox ID="name" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="地址"></asp:Label>
            <asp:TextBox ID="adress" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="性别"></asp:Label>
            <asp:DropDownList ID="sex" runat="server" Width="193px">
                <asp:ListItem Value="1">男</asp:ListItem>
                <asp:ListItem Value="2">女</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
            <asp:Label ID="Label6" runat="server" Text="手机"></asp:Label>
            <asp:TextBox ID="mobile" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label7" runat="server" Text="邮箱"></asp:Label>
            <asp:TextBox ID="email" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label8" runat="server" Text="QQ"></asp:Label>
            <asp:TextBox ID="qq" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label9" runat="server" Text="性别"></asp:Label>
            <asp:DropDownList ID="state" runat="server" Width="193px">
                <asp:ListItem Value="1">正在</asp:ListItem>
                <asp:ListItem Value="2">下线</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="保存" OnClick="Button1_Click" />
            <asp:HiddenField ID="id" runat="server" />
        </p>
    </form>
</body>
</html>
