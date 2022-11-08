using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model;

namespace Service
{
    public class AdminService
    {
        private SqliteHelper Sservice =SqliteHelper.Instance;
        public Admin UserLogin(Admin objIn)
        {

            //string sql = "SELECT Id,Password,UserName FROM salary.users where UserName=@UserName and Password=@Password";
            //MySqlParameter[] param = new MySqlParameter[]
            //    {
            //        new MySqlParameter("@UserName",objIn.UserName),
            //        new MySqlParameter("@Password",objIn.Password)
            //    };
            //MySqlDataReader objReader = Sservice.GetReader(sql, param);
            //Admin obj = null;
            //if(objReader.Read())
            //{
            //    obj = new Admin()
            //    {
            //        UserName = objReader["UserName"].ToString(),
            //        Password=objReader["Password"].ToString()
            //    };

            //}
            //objReader.Close();
            Admin obj = null;
            List<Admin> lobj = Sservice.Query<Admin>("select * from admin");
            foreach(Admin item in lobj)
            {
                if(item.UserName==objIn.UserName)
                {
                    if (item.Password == objIn.Password)
                    {
                        obj = new Admin
                        {
                            UserName = objIn.UserName,
                            Password = objIn.Password
                        };
                        return obj;
                    }
                }
            }
            return obj;
        }
    }
}
