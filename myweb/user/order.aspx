<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="order.aspx.cs" Inherits="myweb.user.order" %>
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
                        <tr align="center"><td>订单编号</td><td>商品详情</td><td>状态</td><td>总价</td><td>日期</td><td>操作</td></tr>

                        <%--写循环：便利购物车--%>
                         <%--  读取数据--%>
                <%
                    //string id = Request.QueryString["id"];
                    //     if (id != null)
                    //     {
                    //         YF.BLL.Shopping.del(int.Parse(id));
                    //         YF.JsHelper.AlertAndRedirect("删除成功", "shopping.aspx");
                    //     }
                    //
                    //订单状态改变
                    if (Request.QueryString["action" ]== "fukuan")//是否付款
                    {
                        string id = Request.QueryString["id"];
                        YF.BLL.Order.update(id, 2);//订单编号变成2 付款
                        YF.JsHelper.AlertAndParentUrl("付款完成", "order.aspx");
                    }
                    else if(Request.QueryString["action" ]== "over")///是否完成
                    {
                        string id = Request.QueryString["id"];
                        YF.BLL.Order.update(id, 4);//订单编号变成4 已经完成
                        YF.JsHelper.AlertAndParentUrl("订单结束", "order.aspx");
                    }
                    YF.Model.User myuser = new YF.Model.User();
                    myuser = (YF.Model.User)YF.SessionHelper.GetSesstion("user");//读取   //强制转 //获取当前用户信息
                    List<YF.Model.Order> list = YF.BLL.Order.list(myuser.Id);//用户id/通过用户id,查询订单信息，
                    for (int i = 0; i < list.Count; i++)
                    {
                        //声明一个字符串
                        string state = "";
                        if (list[i].State == 1)
                        {
                            state = "未付款";
                        }
                        else if (list[i].State == 2)
                        {
                            state = "已付款";
                        }
                        else if (list[i].State == 3)
                        {
                            state = "已发货";
                        }
                        else
                        {
                            state = "已完成";
                        }
                 %>

                        <tr align="center">
                            <td><%=list[i].Id %></td><%--//订单编号--%>
                            <td>
                                <table>
                                    <%
                                        //查询商品详情
                                        //查询购物车信息
                                        List<YF.Model.Shopping> shoppinglist = YF.BLL.Shopping.list(list[i].Id );//根据订单编号查询   //通过订单编号查询关联的购物车信息
                                       //一个循环
                                        for (int j = 0; j < shoppinglist.Count; j++)
                                        {

                                        %>
                                    <tr>
                                        <td><img src="../admin/<%=shoppinglist[j].Goods.Img %>" width="20" height="20"/></td><td><%=shoppinglist[j].Goods.Title %>:</td><td><%=shoppinglist[j].Num %>*</td><td><%=shoppinglist[j].Goods.Price %>=</td><td><%=shoppinglist[j].Num*shoppinglist[j].Goods.Price %></td>
                                    </tr>
                                   
                                    
                                    
                                    
                                    <%} 
                                        %>
                                </table>
                            </td>
                            <td><%=state %></td>
                            <td><%=list[i].Amount %></td>
                            <td><%=list[i].Addate %></td>
                            <td><a href="order.aspx?=<%=list[i].Id %>&action=fukuan">付款</a>|<a href="order.aspx?=<%=list[i].Id %>&action=over">完成</a></td></tr>
                        <%} %>
                    </table>
                    
                    <table width="100%" align="center" border="0">
                        <tr><td align="right">
                            &nbsp;</td></tr>
                    </table>
                </td>
                </tr>
            </table>

            <uc1:down runat="server" ID="down" />
        </div>
    </form>
</body>
</html>
