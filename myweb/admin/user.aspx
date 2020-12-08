<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="user.aspx.cs" Inherits="myweb.admin.user" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <table width="800"align="center" border="1">
         <tr><td>编号</td><td>用户名</td><td>密码</td><td>姓名</td><td>地址</td><td>性别</td><td>电话</td><td>邮箱</td><td>qq</td><td>状态</td><td>时间</td><td>操作</td></tr>
                       <%
                           string id = Request.QueryString["id"];
                           if (id != null)
                           {
                               YF.BLL.User.del(int.Parse(id));
                               YF.JsHelper.AlertAndRedirect("删除成功", "user.aspx");
                           }
                           List<YF.Model.User> list = YF.BLL.User.list();
                %>
            <% for (int i = 0; i < list.Count; i++)
                {
                    string sex = "";
                    string state = "";
                    if (list[i].Sex == 1)
                    {
                        sex="帅哥";
                    }
                    else
                    {
                        sex = "美女";
                    }
                       if (list[i].State == 1)
                    {
                        state="正常";
                    }
                    else
                    {
                        state = "离线";
                    }


                    %>
                <tr><td><% =list[i].Id%></td><td><%=list[i].Username %></td><td><%=list[i].Password %></td><td><%=list[i].Name %></td><td><% =list[i].Adress%></td><td><% =sex%></td><td><% =list[i].Mobile%></td><td><% =list[i].Email%></td><td><% =list[i].Qq%></td><td><% =state%></td><td><% =list[i].Addate%></td><td><a href="user.aspx?id=<%=list[i].Id %>" >删除</a><a href="user_edit.aspx?id=<%=list[i].Id %>" >编辑</a></td></tr>
           
            <% }%>
            </table> 
        </div>
    </form>
</body>
</html>
