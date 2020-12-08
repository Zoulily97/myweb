<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index2.aspx.cs" Inherits="myweb.index2" %>
<%@ Import Namespace="YF.BLL"%>
<%@ Import Namespace="YF.Model"%>
<%@ Import Namespace="YF.DAL"%>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <tr><td>编号</td><td>用户名</td><td>密码</td></tr>
            <%
                List<YF.Model.User> list = YF.BLL.User.list();
                %>
            <% for (int i = 0; i < list.Count; i++)
                {%>
               <tr><td><% =list[i].Id%></td><td><%=list[i].Username %></td><td><%=list[i].Password %></td></tr>
            <% }%>
             
        </div>
    </form>
</body>
</html>
