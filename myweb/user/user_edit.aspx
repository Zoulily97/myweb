﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="user_edit.aspx.cs" Inherits="myweb.user.user_edit" %>

<%@ Register src="../inc/top.ascx" tagname="top" tagprefix="uc1" %>
<%@ Register Src="~/inc/down.ascx" TagPrefix="uc1" TagName="down" %>
<%@ Register Src="~/inc/meun.ascx" TagPrefix="uc1" TagName="meun" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style4 {
            width: 221px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:top ID="top" runat="server" />
            <table border="0" align="center"   width="1000">
                <tr>
                    <td class="auto-style4">
                        <uc1:meun runat="server" ID="meun" />
                    </td>
                <td align="center">
                    
                     <table align="center" width="100%">
        <tr>
             <td><asp:Label ID="Label1" runat="server" Text="用户名"></asp:Label></td>
             <td><asp:TextBox ID="username" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
             <td> <asp:Label ID="Label2" runat="server" Text="密  码"></asp:Label></td>
             <td><asp:TextBox ID="password" runat="server"></asp:TextBox></td>
        </tr>    
        <tr>
             <td><asp:Label ID="Label3" runat="server" Text="姓名"></asp:Label></td>
             <td><asp:TextBox ID="name" runat="server"></asp:TextBox></td>
         </tr>
         <tr>
             <td><asp:Label ID="Label4" runat="server" Text="地址"></asp:Label></td>
             <td> <asp:TextBox ID="adress" runat="server"></asp:TextBox></td>
         </tr>
         <tr>
             <td><asp:Label ID="Label5" runat="server" Text="性别"></asp:Label></td>
             <td><asp:DropDownList ID="sex" runat="server" Width="193px">
                <asp:ListItem Value="1">男</asp:ListItem>
                <asp:ListItem Value="2">女</asp:ListItem>
            </asp:DropDownList></td>
          </tr>
       <tr>
            <td><asp:Label ID="Label6" runat="server" Text="手机"></asp:Label></td>
            <td><asp:TextBox ID="mobile" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
             <td> <asp:Label ID="Label7" runat="server" Text="邮箱"></asp:Label></td>
            <td><asp:TextBox ID="email" runat="server"></asp:TextBox></td>
        </tr>
       <tr>
           <td> <asp:Label ID="Label8" runat="server" Text="QQ"></asp:Label></td>
           <td> <asp:TextBox ID="qq" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button3" runat="server" Text="保存信息" OnClick="Button3_Click" />
            </td>
           <td> 
               &nbsp;</td>
        </tr>
           </table>
                </td>
                </tr>
            </table>
            <uc1:down runat="server" ID="down" />
        </div>
    </form>
</body>
</html>

