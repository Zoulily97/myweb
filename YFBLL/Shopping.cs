using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YF.BLL
{
   public class Shopping
    {

        public static List<YF.Model.Shopping> list(int goodsid, int user, int state)
        {
            return YF.DAL.Shopping.list(goodsid, user, state);
        }
        public static bool updatenum(int goodsid, int user, int state)
        {
            return YF.DAL.Shopping.updatenum(goodsid, user, state);
        }
        /// <summary>
        ///  //清空更新购物车
        /// </summary>
        /// <param name="dingdanbianhao">购物车信息和订单编号关联</param>
        /// <param name="user">购物用户</param>
        /// <param name="state">购物车状态</param>
        /// <returns></returns>
        public static bool updateshopping(string dingdanbianhao, int user, int state)//用户，状态.订单编号
        {
            return YF.DAL.Shopping.updateshopping(dingdanbianhao, user, state);
        }
        public static bool add(YF.Model.Shopping shopping)
        {
            return YF.DAL.Shopping.add(shopping);
                
        }
        public static bool del(int id)
        {
            return YF.DAL.Shopping.del(id);
        }

        //查询
        public static List<YF.Model.Shopping> list(int user)///通过用户id,查询购物车信息 
        {
            return YF.DAL.Shopping.list(user);
        }
        //订单编号查询
        public static List<YF.Model.Shopping> list(string dingdanbianhao)//通过订单编号查询关联的购物车信息
        {
            return YF.DAL.Shopping.list(dingdanbianhao);
        }
    }
}
