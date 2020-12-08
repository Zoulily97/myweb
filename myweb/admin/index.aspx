<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="myweb.admin.index" %>

<%@ Register src="../inc/top.ascx" tagname="top" tagprefix="uc1" %>
<%@ Register src="../inc/down.ascx" tagname="down" tagprefix="uc2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:top ID="top" runat="server" />
            <div style="width:1000px;margin:0 auto;">
                <ul style="list-style:none;margin:0;padding:0;">
                 <%--  读取数据--%>
                <%
                    List<YF.Model.Goods> list = YF.BLL.Goods.list();
                    for (int i = 0; i < list.Count; i++)
                    { 
                 %>
                    <li style="float:left;height:180px;width:238px;text-align:center; border:#808080 solid 1px;margin:10px 10px 10px 0"><a href="../goods.aspx?id=<%=list[i].Id %>" target=""><img  src="../admin/<%=list[i].Img %>" width="50" height="100"/><br /><%=list[i].Title %><br /><%=list[i].Price %></a></li>
                   <%} %>

                </ul>
            </div>
            
        </div>
        <uc2:down ID="down1" runat="server" />
    </form>
</body>
</html>
