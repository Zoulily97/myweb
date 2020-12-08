using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using YF;

namespace myweb.user
{
    public partial class user_edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)//一点击页面就加载
        {
            if (!IsPostBack)//刷新内存
            {
                //保存了用户信息，将信息拿过来
                YF.Model.User myuser = new YF.Model.User();//声明空对象
                myuser = (YF.Model.User)YF.SessionHelper.GetSesstion("user");//读取   //强制转
                //将信息赋值
                this.username.Text = myuser.Username;
                this.password.Text = myuser.Password;
                this.name.Text = myuser.Name;
                this.adress.Text = myuser.Adress;
                this.sex.Text = myuser.Sex.ToString();
                this.mobile.Text = myuser.Mobile;
                this.email.Text = myuser.Email;
                this.qq.Text = myuser.Qq;
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //保存
            //当前登录对象
            YF.Model.User user = new YF.Model.User();
            user = (YF.Model.User)YF.SessionHelper.GetSesstion("user");//读取   //强制转
            //新的数据重新赋值赋值
            user.Password = this.password.Text;
            user.Name = this.name.Text;
            user.Adress = this.adress.Text;
            user.Sex = int.Parse(this.sex.Text);
            user.Mobile = this.mobile.Text;
            user.Qq = this.qq.Text;
            //调后台方法更新；
            if (YF.BLL.User.update(user))
            {
                YF.JsHelper.AlertAndRedirect("用户信息修改成功", "index.aspx");

            }
            else
            {
                YF.JsHelper.AlertAndRedirect("用户信息修改失败", "index.aspx");
            }

        }
    }
}