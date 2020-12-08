using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using YF.DAL;
using YF;

namespace myweb.user
{
    public partial class Shopping_add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //向后台数据库加入记录，点击购买，购物车加
            YF.Model.User myuser = new YF.Model.User();
            myuser = (YF.Model.User)YF.SessionHelper.GetSesstion("user");//读取当前用户信息  //强制转
            if (myuser != null)
            {
                YF.Model.Shopping shopping = new YF.Model.Shopping();//1，声明空的购物车对象
                int id = int.Parse(Request.QueryString["id"].ToString());//通过id查询，传过来的，转化数字
                YF.Model.Goods goods = YF.BLL.Goods.GetGoods(id);////4，声明一个商品对象，通过id查询
                //5，空对象赋值
                shopping.Goods = goods;
                shopping.User = myuser;//等于当前用户
                shopping.Num = 1;
                shopping.State = 0;
                shopping.Addate = DateTime.Now;

                if (YF.BLL.Shopping.list(goods.Id, myuser.Id, 0).Count > 0)//查询商品是否是第一次，，不是第一次，已经存在之前有添加，则修改数量
                {
                    YF.BLL.Shopping.updatenum(goods.Id, myuser.Id, 0);//修改数量
                    YF.JsHelper.AlertAndRedirect("添加成功", "/user/shopping.aspx");//3，添加成功返回购物车页面

                }
                else
                {
                    if (YF.BLL.Shopping.add(shopping))//2，调用业务类，判断逻辑。真，操作成功//第一次
                    {
                        YF.JsHelper.AlertAndRedirect("操作成功", "/user/shopping.aspx");//3，返回购物车页面
                    }
                    else
                    {
                        YF.JsHelper.AlertAndRedirect("操作失败", "/user/shopping.aspx");//不成功购物，失败
                    }
                }
            }
            else
            {
                YF.JsHelper.AlertAndRedirect("尚未登录", "/login.aspx");
            }


        }
    }
}