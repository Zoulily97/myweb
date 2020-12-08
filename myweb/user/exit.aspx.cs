using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using YF;

namespace myweb.user
{
    public partial class exit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //当前保存对象清空
            YF.SessionHelper.SetSession("user", null);//记住对象，保存
            YF.JsHelper.Redirect("/login.aspx");

        }
    }
}