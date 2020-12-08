using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using YF;

namespace myweb
{
    public partial class reg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //用户类，业务层加到前台
            //实力化用户对象
            YF.Model.User user = new YF.Model.User();
            user.Username = this.username.Text;
            user.Password = this.password.Text;
            user.Name = this.name.Text;
            user.Adress = this.adress.Text;
            user.Sex = int.Parse(this.sex.Text);
            user.Mobile = this.mobile.Text;
            user.Email = this.email.Text;
            user.Qq = this.qq.Text;
            user.State = 1;
            user.Addate = DateTime.Now;
            if (YF.BLL.User.Search(this.username.Text) == false)
            {
                YF.JsHelper.AlertAndRedirect("用户名已存在", "reg.aspx");
            }
            if (YF.BLL.User.add(user) == true)
            {
                YF.JsHelper.AlertAndRedirect("注册成功","reg.aspx");
            }
            else
            {
                YF.JsHelper.AlertAndRedirect("注册成功", "index.aspx");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            YF.JsHelper.Redirect("login.aspx");
        }
    }
}