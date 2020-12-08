using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace YF.DAL
{
   public class Shopping
    {
        //添加
        public static bool add(YF.Model.Shopping shopping)
        {
            bool result = false;
            string strsql = "insert into t_shopping(goodsid,userid,num,state,addate,orderid) values(" + shopping.Goods.Id + "," + shopping.User.Id + "," + shopping.Num + "," + shopping.State + ",'" + shopping.Addate + "','')";
            int i = 0;
            i = YF.MsSqlHelper.YFMsSqlHelper.ExecuteSql(strsql);
            if (i > 0)
            {
                result = true;
            }
            return result;

        }
        //删除
        public static bool del(int id)
        {
            bool result = false;
            string strsql = "delete from t_shopping where id= " + id + "";
            int i = YF.MsSqlHelper.YFMsSqlHelper.ExecuteSql(strsql);
            if (i > 0)
            {
                result = true;
            }
            return result;


        }
        //查询
        public static List<YF.Model.Shopping> list(int user) //泛型   /通过用户id,查询购物车信息
        {
            string strsql = "select * from t_shopping where userid="+user+" and state=0";//查询数据//查询当前用户，并且没有下单.state=0
            DataTable dt = YF.MsSqlHelper.YFMsSqlHelper.Query(strsql).Tables[0];//获得一张表
            return Dotolist(dt);//转换成list
        }
        public static List<YF.Model.Shopping> Dotolist(DataTable dt)
        {
            List<YF.Model.Shopping> list = new List<Model.Shopping>();//空的泛型对象  转换
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                YF.Model.Shopping shopping = new Model.Shopping();//空对象

                shopping.Id = int.Parse(dt.Rows[i]["id"].ToString());
                
                //当前商品
                YF.Model.Goods goods = YF.DAL.Goods.GetGoods(int.Parse(dt.Rows[i]["goodsid"].ToString()));//通过id 得到商品实列对象
                shopping.Goods = goods;//商品赋值=上面的goods

                //当前用户
                YF.Model.User user = YF.DAL.User.GetUser(int.Parse(dt.Rows[i]["userid"].ToString()));//通过id 得到用户实列对象
                shopping.User = user;//商品赋值=上面的user

                shopping.Num = int.Parse(dt.Rows[i]["num"].ToString());
                shopping.State = int.Parse(dt.Rows[i]["state"].ToString());
                shopping.Addate = DateTime.Parse(dt.Rows[i]["addate"].ToString());
                list.Add(shopping); //空的泛型对象+数据

            }
            return list;
        }

        // 更新
        public static bool updatenum(int goodsid, int user, int state)
        {
            bool result = false;
            string strsql = "update t_shopping set num=num+1 where goodsid=" + goodsid + " and userid=" + user + " and state= " + state + "";//每点击购物一次，同样商品+1
            int i = YF.MsSqlHelper.YFMsSqlHelper.ExecuteSql(strsql);
            if (i > 0)
            {
                result = true;
            }
            return result;

        }
        //  下单成功，更新shopping，//更新购物车
        /// <summary>
        ///  //清空更新购物车 返回state=1
        /// </summary>
        /// <param name="dingdanbianhao">购物车信息和订单编号关联</param>
        /// <param name="user">购物用户</param>
        /// <param name="state">购物车状态</param>
        /// <returns></returns>
        public static bool updateshopping( string dingdanbianhao ,int user, int state)//用户，状态.订单编号
        {
            bool result = false;
            string strsql = "update t_shopping set orderid='"+ dingdanbianhao + "',state=1 where userid=" + user + " and state= " + state + "";//每点击购物一次，同样商品+1 state=1表示已经下单，清空购物车
            int i = YF.MsSqlHelper.YFMsSqlHelper.ExecuteSql(strsql);
            if (i > 0)
            {
                result = true;
            }
            return result;

        }
        //查询
        public static List<YF.Model.Shopping> list(int goodsid,int user, int state)//商品 用户 状态
        {
            string strsql = "select * from t_shopping where goodsid="+ goodsid + " and userid="+ user + " and state= "+state+"";//查询数据
            DataTable dt = YF.MsSqlHelper.YFMsSqlHelper.Query(strsql).Tables[0];//获得一张表
            return Dotolist(dt);//转换成list

        }
        //通过订单查询购物车信息
        /// <summary>
        /// 通过订单编号查询关联的购物车信息
        /// </summary>
        /// <param name="dingdanbianhao">订单编号</param>
        /// <returns></returns>
        public static List<YF.Model.Shopping> list(string dingdanbianhao)//通过订单编号查询关联的购物车信息
        {
            string strsql = "select * from t_shopping where orderid='" + dingdanbianhao + " 'and state=1 ";//查询数据
            DataTable dt = YF.MsSqlHelper.YFMsSqlHelper.Query(strsql).Tables[0];//获得一张表
            return Dotolist(dt);//转换成list

        }

    }
}
