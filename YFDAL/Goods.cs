using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YF.MsSqlHelper;
using System.Data;

namespace YF.DAL//数据库访问层
{
  public  class Goods
    {
        public static bool add(YF.Model.Goods goods) 
        {
            bool result = false;
            string strsql = "insert into t_goods(title,price,num,img,detail,state,addate) values('"+goods.Title+ "'," + goods.Price + "," + goods.Num + ",'" + goods.Img + "','" + goods.Detail + "'," + goods.State + ",'" + goods.Addate + "')";
            int i = 0;
            i = YF.MsSqlHelper.YFMsSqlHelper.ExecuteSql(strsql);
            if (i > 0)
            {
                result= true;
            }
            return result;
        }
        public static  List<YF.Model.Goods> list() //泛型
        {
            string strsql = "select * from t_goods";//查询数据
            DataTable dt = YF.MsSqlHelper.YFMsSqlHelper.Query(strsql).Tables[0];//获得一张表
            return Dotolist(dt);//转换成list
        }
        public static List<YF.Model.Goods> Dotolist(DataTable dt)
        {
            List<YF.Model.Goods> list = new List<Model.Goods>();//空的泛型对象  转换
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                YF.Model.Goods goods = new Model.Goods();//空对象
                goods.Id = int.Parse(dt.Rows[i]["id"].ToString());
                goods.Title = dt.Rows[i]["title"].ToString();
                goods.Price = int.Parse(dt.Rows[i]["price"].ToString());
                goods.Num = int.Parse(dt.Rows[i]["num"].ToString());
                goods.Img = dt.Rows[i]["img"].ToString();
                goods.Detail = dt.Rows[i]["detail"].ToString();
                goods.State = int.Parse(dt.Rows[i]["state"].ToString());
                goods.Addate = DateTime.Parse(dt.Rows[i]["addate"].ToString());
                list.Add(goods); //空的泛型对象+数据

            }
            return list;
        }
        public static YF.Model.Goods GetGoods(int id)
        {
            string strsql = "select * from t_goods where id="+id+""; //查询数据
            DataTable dt = YF.MsSqlHelper.YFMsSqlHelper.Query(strsql).Tables[0];
            List<YF.Model.Goods> list = Dotolist(dt);
            return list[0];
        }

    }
}
