<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Order_add.aspx.cs" Inherits="myweb.user.Order_add" %>

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

                    <table width="100%" align="center" border="1">
                        <tr align="center"><td>编号</td><td>商品</td><td>封面</td><td>价格</td><td>数量</td><td>合计</td><td>选择</td></tr>

                        <%--写循环：便利购物车--%>
                         <%--  读取数据--%>
                <%
                      string id = Request.QueryString["id"];
                           if (id != null)
                           {
                               YF.BLL.Shopping.del(int.Parse(id));
                               YF.JsHelper.AlertAndRedirect("删除成功", "shopping.aspx");
                           }
                           //获取当前用户信息
                           YF.Model.User myuser = new YF.Model.User();
                           myuser = (YF.Model.User)YF.SessionHelper.GetSesstion("user");//读取   //强制转
                    List<YF.Model.Shopping> list = YF.BLL.Shopping.list(myuser.Id);//通过用户id,查询购物车信息
                    //循环遍历，信息打印出来
                    for (int i = 0; i < list.Count; i++)
                    {
                 %>

                        <tr align="center"><td><%=list[i].Id %></td><td><%=list[i].Goods.Title %></td><td><img src="../admin/<%=list[i].Goods.Img %>" width="50" height="50"/></td><td><%=list[i].Goods.Price %></td><td><%=list[i].Num %></td><td><%=list[i].Goods.Price*list[i].Num %></td><td>&nbsp;</td></tr>
                        <%} %>
                    </table>
                    
                    <table width="100%" align="center" border="0">
                        <tr><td align="center">
                           总价：
                             
                            <asp:Label ID="zongjia" runat="server" Text="Label"></asp:Label>
                            </td>
                            <td>
                                <asp:Button ID="Button1" runat="server" Text="正式下单" OnClick="Button1_Click" />
                            </td>
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
