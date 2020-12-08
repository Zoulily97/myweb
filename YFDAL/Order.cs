using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YF.DAL
{
  public  class Order

    {
        /// <summary>
        /// 更改订单状态
        /// </summary>
        /// <param name="dingdanbianhao">订单编号</param>
        /// <param name="state">状态值</param>
        /// <returns></returns>
        public static bool update(string dingdanbianhao ,int state)
        {
            bool result = false;
            string strsql = "update  t_order set state=" + state+" where id='"+ dingdanbianhao + "'";
            int i = YF.MsSqlHelper.YFMsSqlHelper.ExecuteSql(strsql);
            if (i > 0)
            {
                result = true;
            }
            return result;

        }


       //添加
       public static bool add(YF.Model.Order order)//添加订单数据

        {
            bool result = false;
            //插入
            string strsql = "insert into t_order (id, userid,amount,state,addate) values("+order.Id+"," +order.User.Id+ "," + order.Amount + "," + order.State + ",'" + order.Addate + "')";
            //执行
            int i = YF.MsSqlHelper.YFMsSqlHelper.ExecuteSql(strsql);
            if (i > 0)
            {
                result = true;
            }
            return result;
        }
        //查询 通过用户id,查询订单信息，
        public static List<YF.Model.Order> list( int user)//通过用户查询订单信息
        {
            string strsql = "select * from t_order where  userid=" + user + "  order by addate desc";//查询数据
            DataTable dt = YF.MsSqlHelper.YFMsSqlHelper.Query(strsql).Tables[0];//获得一张表
            return Dotolist(dt);//转换成list

        }
        public static List<YF.Model.Order> Dotolist(DataTable dt)
        {
            List<YF.Model.Order> list = new List<Model.Order>();//空的泛型对象  转换
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                YF.Model.Order order = new Model.Order();//空对象

                order.Id =dt.Rows[i]["id"].ToString();

                

                //当前用户
                YF.Model.User user = YF.DAL.User.GetUser(int.Parse(dt.Rows[i]["userid"].ToString()));//通过id 得到用户实列对象
                order.User = user;//商品赋值=上面的user

                order.Amount = int.Parse(dt.Rows[i]["amount"].ToString());
                order.State = int.Parse(dt.Rows[i]["state"].ToString());
                order.Addate = DateTime.Parse(dt.Rows[i]["addate"].ToString());
                list.Add(order); //空的泛型对象+数据

            }
            return list;
        } 
    }
}
