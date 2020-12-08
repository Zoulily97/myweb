using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace YF.DAL//数据库访问层与实体类关联
{
    /// <summary>
    /// 用户数据访问类
    /// </summary>
   public class User
    {
        //添加数据方法。静态方法，不用实例化，直接调用
        /// <summary>
        /// 添加用户方法
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static bool add(YF.Model.User user)
            
        {
            bool result = false;
            //插入
            string strsql = "insert into t_user ( username,password,name,adress,sex,mobile,email,qq,state,addate) values('"+user.Username+"','"+user.Password+"','"+user.Name+"','"+user.Adress+"',"+user.Sex+",'"+user.Mobile+"','"+user.Email+"','"+user.Qq+"',"+user.State+ ",'"+user.Addate+"')";
            //执行
            int i = YF.MsSqlHelper.YFMsSqlHelper.ExecuteSql(strsql);
            if (i > 0)
            {
                result = true; 
            }
            return result;
        }
        public static bool Search( string username)
        {
            bool result = false;
            string strsql = "select * from t_user where username='" + username + "'";
            DataTable dataTable = YF.MsSqlHelper.YFMsSqlHelper.Query(strsql).Tables[0];
            if (dataTable.Rows.Count == 0)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result; 
        }
        public static bool login(string username,string password)
        {
            bool result = false;
            string strsql = "select * from t_user where username='" + username + "' and password='"+password+"'";
            DataTable dataTable = YF.MsSqlHelper.YFMsSqlHelper.Query(strsql).Tables[0];
            //查到记录
            if (dataTable.Rows.Count != 0)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
        public static YF.Model.User GetUser(string username)
        {
            //通过id 查询 返回一个实体对象user
            YF.Model.User user = new YF.Model.User();
            string strsql = "select * from t_user where username='"+ username + "'";
            DataTable dataTable = YF.MsSqlHelper.YFMsSqlHelper.Query(strsql).Tables[0];//一张表
            if (dataTable.Rows.Count != 0)
            {
                user.Id = int.Parse(dataTable.Rows[0]["id"].ToString());
                user.Username = dataTable.Rows[0]["Username"].ToString();
                user.Password = dataTable.Rows[0]["Password"].ToString();
                user.Name = dataTable.Rows[0]["Name"].ToString();
                user.Adress = dataTable.Rows[0]["Adress"].ToString();
                user.Sex = int.Parse(dataTable.Rows[0]["Sex"].ToString());
                user.Mobile = dataTable.Rows[0]["Mobile"].ToString();
                user.Email = dataTable.Rows[0]["Email"].ToString();
                user.Qq = dataTable.Rows[0]["Qq"].ToString();
                user.State = int.Parse(dataTable.Rows[0]["State"].ToString());
                user.Addate = DateTime.Parse(dataTable.Rows[0]["Addate"].ToString());

            }
            return user;
        }
        //用户管理，删除
        public static YF.Model.User GetUser(int id)
        {
            //通过id 查询 返回一个实体对象user
            YF.Model.User user = new YF.Model.User();
            string strsql = "select * from t_user where id=" + id + "";
            DataTable dataTable = YF.MsSqlHelper.YFMsSqlHelper.Query(strsql).Tables[0];//一张表
            if (dataTable.Rows.Count != 0)
            {
                user.Id = int.Parse(dataTable.Rows[0]["id"].ToString());
                user.Username = dataTable.Rows[0]["Username"].ToString();
                user.Password = dataTable.Rows[0]["Password"].ToString();
                user.Name = dataTable.Rows[0]["Name"].ToString();
                user.Adress = dataTable.Rows[0]["Adress"].ToString();
                user.Sex = int.Parse(dataTable.Rows[0]["Sex"].ToString());
                user.Mobile = dataTable.Rows[0]["Mobile"].ToString();
                user.Email = dataTable.Rows[0]["Email"].ToString();
                user.Qq = dataTable.Rows[0]["Qq"].ToString();
                user.State = int.Parse(dataTable.Rows[0]["State"].ToString());
                user.Addate = DateTime.Parse(dataTable.Rows[0]["Addate"].ToString());

            }
            return user;
        }
        public static List<YF.Model.User> List()    //泛型
        {
            string strsql = "select * from t_user order by id desc";//查询数据
            DataTable dt = YF.MsSqlHelper.YFMsSqlHelper.Query(strsql).Tables[0];//获得一张表
            return Dttolist(dt);//转换成list
        }
        public static List<YF.Model.User>Dttolist( DataTable dt)
        {
            List<YF.Model.User> list = new List<YF.Model.User>();  //空的泛型对象  转换
            //if (dt.Rows.Count != 0)
            for (int i=0;i<dt.Rows.Count;i++)
            {
                YF.Model.User user = new YF.Model.User();
                //user = GetUser(int.Parse(dt.Rows[i]["id"].ToString()));
                user.Id = int.Parse(dt.Rows[i]["id"].ToString());
                user.Username = dt.Rows[i]["Username"].ToString();
                user.Password = dt.Rows[i]["Password"].ToString();
                user.Name = dt.Rows[i]["Name"].ToString();
                user.Adress = dt.Rows[i]["Adress"].ToString();
                user.Sex = int.Parse(dt.Rows[i]["Sex"].ToString());
                user.Mobile = dt.Rows[i]["Mobile"].ToString();
                user.Email = dt.Rows[i]["Email"].ToString();
                user.Qq = dt.Rows[i]["Qq"].ToString();
                user.State = int.Parse(dt.Rows[i]["State"].ToString());
                user.Addate = DateTime.Parse(dt.Rows[i]["Addate"].ToString());
                list.Add(user); //空的泛型对象+数据
            }
            return list; 
        }
        //删除
        public static bool del(int id)
        {
            bool result = false;
            string strsql = "delete from t_user where id= " + id + "";
            int i = YF.MsSqlHelper.YFMsSqlHelper.ExecuteSql(strsql);
            if (i > 0)
            {
                result = true;
            }
            return result;


        }
        //更新
        public static bool update(YF.Model.User user)
        {
            bool result = false;
            string strsql = "update t_user set Username='"+user.Username+ "',password='" + user.Password + "',Name='" + user.Name + "',Adress='" + user.Adress + "',Sex=" + user.Sex + ",Mobile='" + user.Mobile + "',Email='" + user.Email + "',State=" + user.State + " where id= " + user.Id+ "";
            int i = YF.MsSqlHelper.YFMsSqlHelper.ExecuteSql(strsql);
            if (i > 0)
            {
                result = true;
            }
            return result;

        }
    }
}
