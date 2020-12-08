<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Goods.aspx.cs" Inherits="myweb.admin.Goods" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table width="1000" align="center" border="1">
                <tr border="1" align="center"><td>编号</td><td>商品</td><td>封面</td><td>价格</td><td>数量</td><td>时间</td><td>操作</td></tr>
              <%--  读取数据--%>
                <%
                    List<YF.Model.Goods> list = YF.BLL.Goods.list();
                    for (int i = 0; i < list.Count; i++)
                    {



               %>
                <tr border="1" align="center"><td><%=i + 1 %></td><td><%=list[i].Title %></td><td><img src="../admin/<%=list[i].Img %>" width="50" height="100"/></td><td><%=list[i].Price %></td><td><%=list[i].Num %></td><td><%=list[i].Addate %></td><td>查看</td></tr>
                <%} %>
            </table>
        </div>
    </form>
</body>
</html>
