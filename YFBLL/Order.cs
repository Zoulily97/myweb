using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YF.DAL;

namespace YF.BLL
{
    public class Order
    {
        //把订单对象，调用数据库访问层，插入数据
        public static bool add(YF.Model.Order order)
        {
            return YF.DAL.Order.add(order);
        }
        public static List<YF.Model.Order> list(int user)//通过用户查询通过用户id,查询订单信息，
        {

            return YF.DAL.Order.list(user);
        }
        //修改状态
        /// <summary>
        /// 更改订单状态
        /// </summary>
        /// <param name="dingdanbianhao">订单编号</param>
        /// <param name="state">状态值</param>
        /// <returns></returns>
        public static bool update(string dingdanbianhao, int state)
        {
            return YF.DAL.Order.update(dingdanbianhao, state);
        }


    }
}
