using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YF.Model
{
    public class Shopping
    {
        private int id;
        private YF.Model.Goods goods;
        private YF.Model.User user;
        private int num;
        private int state;
        private DateTime addate;
        private YF.Model.Order order;
        
        /// <summary>
        /// ID
        /// </summary>

        public int Id { get => id; set => id = value; }
        /// <summary>
        /// 关联商品
        /// </summary>
        public Goods Goods { get => goods; set => goods = value; }
        /// <summary>
        /// 关联用户
        /// </summary>
        public User User { get => user; set => user = value; }
        /// <summary>
        /// 数量
        /// </summary>
        public int Num { get => num; set => num = value; }
        /// <summary>
        /// 状态
        /// </summary>
        public int State { get => state; set => state = value; }
        /// <summary>
        /// 时间
        /// </summary>
        public DateTime Addate { get => addate; set => addate = value; }
        /// <summary>
        /// 关联用户订单
        /// </summary>
        public Order Order { get => order; set => order = value; }
    }
}
