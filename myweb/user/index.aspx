<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="myweb.user.index" %>

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
                <td align="center">欢迎<asp:Label ID="username" runat="server" Text="Label"></asp:Label>来到网上购物商城</td>

                </tr>
            </table>
            <uc1:down runat="server" ID="down" />
        </div>
    </form>
</body>
</html>
