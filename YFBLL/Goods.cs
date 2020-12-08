using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YF.Model;
using YF.DAL;
namespace YF.BLL
{
   public class Goods
    {
        public static bool add(YF.Model.Goods goods)
        {
            return YF.DAL.Goods.add(goods);
        }
        public static List<YF.Model.Goods> list()
        {
            return YF.DAL.Goods.list();
        }
        public static YF.Model.Goods GetGoods(int id)
        {
            return YF.DAL.Goods.GetGoods(id);
        }
    }
}
