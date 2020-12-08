using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YF.BLL//业户层，前台访问业务层，业务层访问数据库访问层
{
     public class User
    {
        public static YF.Model.User GetUser(int id)
        {
            return YF.DAL.User.GetUser(id);
        }
        public static YF.Model.User GetUser(string username)
        {
            return YF.DAL.User.GetUser(username);
        }
        public static bool update(YF.Model.User user)
        {
            return YF.DAL.User.update(user);
        }
        public static bool del(int id)
        {
            return YF.DAL.User.del(id);
        }
        public static List<YF.Model.User> list()
        {
            return YF.DAL.User.List();
        }
        public static bool add(YF.Model.User user) {
        return YF.DAL.User.add(user); }
        public static bool Search(string username)
        {
            return YF.DAL.User.Search(username);
        }
        public static bool login(string username, string password)
        {
            return YF.DAL.User.login(username, password);
        }
    }
}
