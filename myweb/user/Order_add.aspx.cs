using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using YF;

namespace myweb.user
{
    public partial class Order_add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //声明变量 总价
            int zongjia = 0;
            //计算
            //获取当前用户未下单的信息
            YF.Model.User myuser = new YF.Model.User();
            myuser = (YF.Model.User)YF.SessionHelper.GetSesstion("user");//获取当前用户信息
            List<YF.Model.Shopping> list = YF.BLL.Shopping.list(myuser.Id);//用户id/通过用户id,查询购物车信息，算出总价
            //便利
            for (int i = 0; i < list.Count; i++)
            {
                zongjia = zongjia + list[i].Goods.Price * list[i].Num;//i=i+1
            }
            //显示
                this.zongjia.Text = zongjia.ToString();//把总价返回到前台

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //订单信息保存到后台
            //正式下单
            //获取当前用户
            YF.Model.User myuser = new YF.Model.User();//获取当前用户信息
            myuser = (YF.Model.User)YF.SessionHelper.GetSesstion("user");
            //1.生成订单编号，上传商品封面有写过，
            string dingdanbianhao = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString();
            //声明空的订单对象
            YF.Model.Order myorder = new YF.Model.Order(); //声明空的订单对象
            //给订单对象赋值
            myorder.Id = dingdanbianhao;//赋值订单编号
            myorder.User = myuser;//赋值当前用户信息
            myorder.Amount = int.Parse(this.zongjia.Text);//赋值总价
            myorder.State = 1;//订单状态，表示未付款
            myorder.Addate = DateTime.Now;//订单时间
            if (YF.BLL.Order.add(myorder))//把订单对象，调用业务层，插入数据
            {
                //更新购物车
                YF.BLL.Shopping.updateshopping(dingdanbianhao, myuser.Id, 0);//清空购物车，通过updateshopping
                YF.JsHelper.AlertAndRedirect("下单成功", "/user/order.aspx");
            }
            else
            {
                YF.JsHelper.AlertAndRedirect("下单失败", "/user/order.aspx");
            }
           
        
        
        }
    }
}