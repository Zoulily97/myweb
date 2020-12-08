using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using YF;

namespace myweb.user
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //获取保存的对象
            //声明对象
            YF.Model.User myuser = new YF.Model.User();
            myuser = (YF.Model.User)YF.SessionHelper.GetSesstion("user");//读取   //强制转
            if (myuser != null)
            {
             this.username.Text = myuser.Username;

            }
            else
            {
                YF.JsHelper.AlertAndRedirect("尚未登录", "login.aspx");
            }
           
        }
    }
}