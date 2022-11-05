using Model;
using MySqlX.XDevAPI.Common;
using SQLite;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Service
{
    
    public class SqliteHelper
    {
        /// <summary>
        /// 数据库连接
        /// </summary>
        public SQLiteConnection db;
        private SqliteHelper()
        {
        }

        /// <summary>
        /// 初始化数据库连接
        /// </summary>
        /// <param name="DbPath">数据库文件路径</param>
        /// <param name="Password">密码</param>
        public void Init(string DbPath,string Password)
        {
            db = new SQLiteConnection(new SQLiteConnectionString(DbPath, true, key: Password));
            db.CreateTable<Admin>();//表已存在不会重复创建
            db.CreateTable<Position_Data>();
            db.CreateTable<Employee_Data>();
        }

        /// <summary>
        /// 初始化数据库连接
        /// </summary>
        /// <param name="DbPath">数据库文件路径</param>
        public void Init(string DbPath)
        {
            db = new SQLiteConnection(DbPath);
            db.CreateTable<Admin>();//表已存在不会重复创建
            db.CreateTable<Position_Data>();
            db.CreateTable<Employee_Data>();
        }

        private static readonly Lazy<SqliteHelper> sqliteHelper = new Lazy<SqliteHelper>(() => new SqliteHelper());

        public static SqliteHelper Instance
        {
            get
            {
                return sqliteHelper.Value;
            }
        }


        public int Add<T>(T model)
        {
            return db.Insert(model);
        }

        public int Update<T>(T model)
        {
            return db.Update(model);
        }

        public int Delete<T>(T model)
        {
            return db.Update(model);
        }
        public List<T> Query<T>(string sql) where T : new()
        {
            return db.Query<T>(sql);
        }
        public int Execute(string sql)
        {
            return db.Execute(sql);
        }

    }
}
