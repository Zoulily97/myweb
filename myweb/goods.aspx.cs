using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using YF;


namespace myweb
{
    public partial class goods : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //获取id
            string id = Request["id"];
            YF.Model.Goods goods = YF.BLL.Goods.GetGoods(int.Parse(id));
            this.title.Text = goods.Title;
            this.price.Text = goods.Price.ToString();
            this.num.Text = goods.Num.ToString();
            this.detail.Text = goods.Detail.ToString();
            this.img.ImageUrl =" .. / admin / +goods.Img.ToString()";
            this.img.Width = 180;



        }
    }
}