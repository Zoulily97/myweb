using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace myweb
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = this.username.Text;
            string password = this.password.Text;
            if (YF.BLL.User.login(username, password) == true)
            {
                YF.Model.User user = YF.BLL.User.GetUser(username);
                if (user.State == 1)
                {
                    YF.SessionHelper.SetSession("user", user);//记住对象，保存当前用户登录身份信息
                    YF.JsHelper.AlertAndRedirect("登录成功", "/user/index.aspx");
                }
                else
                {
                    YF.JsHelper.AlertAndRedirect("账号关闭", "index.aspx");
                }
                
            }
            else
            {
                YF.JsHelper.AlertAndRedirect("登录失败", "login.aspx");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            YF.JsHelper.Redirect( "reg.aspx");
        }
        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    string username = this.
        //    string password = this.password.Text;
        //    if (YF.BLL.User.login(username, password) == true)
        //    {
        //        YF.JsHelper.AlertAndRedirect("登录成功", "index.aspx");
        //    }
        //    else
        //    {
        //        YF.JsHelper.AlertAndRedirect("登录失败", "login.aspx");
        //    }
        //}
    }
}