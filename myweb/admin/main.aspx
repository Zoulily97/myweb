<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="main.aspx.cs" Inherits="myweb.admin.main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>小白购物系统</title>
</head>
  <frameset rows="100,*" cols="*"frameborder="no" border="0" framespacing="0">
  <frame src="top.aspx" name="topFrame" scrolling="No" noresize="noresize" id="topFrame"/>
  <frameset  cols="200,*"frameborder="no" border="0" framespacing="0" >
  <frame src="meun.aspx" name="leftFrame" scrolling="No" noresize="noresize" id="leftFrame" />
  <frame src="" name="shopping" id="mainFrame" />
</frameset>
</frameset>
    <noframes>
    </noframes>
</html>
