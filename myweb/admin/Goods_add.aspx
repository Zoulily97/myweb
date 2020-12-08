<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Goods_add.aspx.cs" Inherits="myweb.admin.Goods_add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 333px;
        }
    </style>
</head>
<body style="width: 1331px">
    <form id="form1" runat="server">
        <div>
            <table border="1" width="60%">
                <tr><td class="auto-style1">名称：</td><td>
                    <asp:TextBox ID="title" runat="server"></asp:TextBox>
                    </td></tr>
                 <tr><td class="auto-style1">价格：</td><td>
                     <asp:TextBox ID="price" runat="server"></asp:TextBox>
                     </td></tr>
                <tr><td class="auto-style1">数量：</td><td>
                    <asp:TextBox ID="num" runat="server"></asp:TextBox>
                    </td></tr>
                <tr><td class="auto-style1">图片：</td><td>
                    <asp:FileUpload ID="img" runat="server" />
                    </td></tr>
                <tr><td>详情：</td><td>
                    <asp:TextBox ID="detail" runat="server" Height="80px" TextMode="MultiLine" Width="200px"></asp:TextBox>
                    </td></tr>
                 <tr><td>状态：</td><td>
                     <asp:DropDownList ID="state" runat="server">
                         <asp:ListItem Value="1">上线</asp:ListItem>
                         <asp:ListItem Value="0">下线</asp:ListItem>
                     </asp:DropDownList>
                     </td></tr>
            </table>

        </div> 
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="发布" />
    </form> </body> </html> 