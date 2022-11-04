using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace Service
{
    class SqliteService
    {
        /// <summary>
        /// SQL命令执行模块，整个程序只有这里可以联系数据库
        /// </summary>
        public class SqlService
        {
            /// <summary>
            /// 数据库连接字符串    !!!!!!!!!!!!!!!!!!!!这个字符串后续要改，连接用的!!!!!!!!!!!!!!!!!!!!!!!!!!!
            /// </summary>
            private string connString = "server=localhost;port=3306;user=root;pwd=root;database=Salary;"; //ConfigurationManager.ConnectionStrings["server=127.0.0.1:3306;uid=root;pwd=bd1234;database=test;Trusted_Connection=no"].ToString();
            #region 执行格式化SQL语句
            /// <summary>
            /// 增删改操作
            /// </summary>
            /// <param name="sql"></param>
            /// <returns></returns>
            public int Update(string sql)
            {
                SQLiteConnection conn = new SQLiteConnection(connString);
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                try
                {
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
                catch (System.Exception ex)
                {
                    //将错误信息写入日志文件
                    LogService.WriteErrorLog(ex.Message);
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
            /// <summary>
            /// 获取单一结果
            /// </summary>
            /// <param name="sql"></param>
            /// <returns></returns>
            public object GetSingleResult(string sql)
            {
                SQLiteConnection conn = new SQLiteConnection(connString);
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                try
                {
                    conn.Open();
                    return cmd.ExecuteScalar();
                }
                catch (System.Exception ex)
                {
                    //将错误信息写入日志文件
                    LogService.WriteErrorLog(ex.Message);
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
            /// <summary>
            /// 获取结果集（只读）
            /// </summary>
            /// <param name="sql"></param>
            /// <returns></returns>
            public SQLiteDataReader GetReader(string sql)
            {
                Console.WriteLine(sql);
                SQLiteConnection conn = new SQLiteConnection(connString);
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                try
                {
                    conn.Open();
                    return cmd.ExecuteReader(CommandBehavior.CloseConnection);
                }
                catch (System.Exception ex)
                {
                    //将错误信息写入日志文件
                    LogService.WriteErrorLog(ex.Message);
                    Console.WriteLine("数据库连接失败");
                    throw ex;
                }
            }
            /// <summary>
            /// 获取数据集
            /// </summary>
            /// <param name="sql"></param>
            /// <returns></returns>
            public DataSet GetDataSet(string sql)
            {
                SQLiteConnection conn = new SQLiteConnection(connString);
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataSet ds = new DataSet();
                try
                {
                    conn.Open();
                    da.Fill(ds);
                    return ds;
                }
                catch (System.Exception ex)
                {
                    //将错误信息写入日志文件
                    LogService.WriteErrorLog(ex.Message);
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
            /// <summary>
            /// 获取多个数据集，读取时可以根据表的名称访问DataTable
            /// </summary>
            /// <param name="sql">使用HashTable类型的泛型集合封装对应的SQL语句和数据表名称</param>
            /// <returns>返回包含若干个数据表的数据集</returns>
            public DataSet GetDataSet(Dictionary<string, string> sqlDic)
            {
                SQLiteConnection conn = new SQLiteConnection(connString);
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conn;
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataSet ds = new DataSet();
                try
                {
                    conn.Open();
                    foreach (var item in sqlDic)
                    {
                        cmd.CommandText = item.Value;
                        da.Fill(ds, item.Key);//tableName
                    }
                    return ds;
                }
                catch (System.Exception ex)
                {
                    //将错误信息写入日志文件
                    LogService.WriteErrorLog(ex.Message);
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }

            #region 执行事务
            /// <summary>
            /// 基于ADO.NET事务提交多条sql语句
            /// </summary>
            /// <param name="sql"></param>
            /// <returns>返回是否执行成功</returns>
            public bool UpdateByTransaction(List<string> sqlList)
            {
                SQLiteConnection conn = new SQLiteConnection(connString);
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conn;
                try
                {
                    conn.Open();
                    cmd.Transaction = conn.BeginTransaction();//开启事务
                    foreach (var item in sqlList)
                    {
                        cmd.CommandText = item;
                        cmd.ExecuteNonQuery();
                    }
                    cmd.Transaction.Commit();//提交事务（同时自动清除事务）
                    return true;
                }
                catch (System.Exception ex)
                {
                    if (cmd.Transaction != null)
                    {
                        cmd.Transaction.Rollback();//回滚事务
                    }
                    //将错误信息写入日志文件
                    LogService.WriteErrorLog(ex.Message);
                    throw ex;
                }
                finally
                {
                    if (cmd.Transaction != null)
                    {
                        cmd.Transaction = null;
                    }
                    conn.Close();
                }
            }
            #endregion

            #endregion

            #region 执行带参数的SQL语句

            /// <summary>
            /// 增删改操作
            /// </summary>
            /// <param name="sql"></param>
            /// <returns></returns>
            public int Update(string sql, SQLiteParameter[] param)
            {
                SQLiteConnection conn = new SQLiteConnection(connString);
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddRange(param);
                try
                {
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
                catch (System.Exception ex)
                {
                    //将错误信息写入日志文件
                    LogService.WriteErrorLog(ex.Message);
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
            public int InsertNl(string sql, SQLiteParameter[] param)
            {
                SQLiteConnection conn = new SQLiteConnection(connString);
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                SQLiteCommand cmdback = new SQLiteCommand("select LAST_INSERT_ID()", conn);
                if (param != null)
                    cmd.Parameters.AddRange(param);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return Convert.ToInt32(cmdback.ExecuteScalar());
                }
                catch (System.Exception ex)
                {
                    //将错误信息写入日志文件
                    LogService.WriteErrorLog(ex.Message);
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
            /// <summary>
            /// 获取单一结果
            /// </summary>
            /// <param name="sql"></param>
            /// <returns></returns>
            public object GetSingleResult(string sql, SQLiteParameter[] param)
            {
                SQLiteConnection conn = new SQLiteConnection(connString);
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddRange(param);
                try
                {
                    conn.Open();
                    return cmd.ExecuteScalar();
                }
                catch (System.Exception ex)
                {
                    //将错误信息写入日志文件
                    LogService.WriteErrorLog(ex.Message);
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
            /// <summary>
            /// 获取结果集（只读）
            /// </summary>
            /// <param name="sql"></param>
            /// <returns></returns>
            public SQLiteDataReader GetReader(string sql, SQLiteParameter[] param)
            {
                SQLiteConnection conn = new SQLiteConnection(connString);
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddRange(param);
                try
                {
                    conn.Open();
                    return cmd.ExecuteReader(CommandBehavior.CloseConnection);
                }
                catch (System.Exception ex)
                {
                    //将错误信息写入日志文件
                    LogService.WriteErrorLog(ex.Message);
                    throw ex;
                }
            }
            /// <summary>
            /// 获取数据集
            /// </summary>
            /// <param name="sql"></param>
            /// <returns></returns>
            public DataSet GetDataSet(string sql, SQLiteParameter[] param)
            {
                SQLiteConnection conn = new SQLiteConnection(connString);
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                cmd.Parameters.AddRange(param);
                DataSet ds = new DataSet();
                try
                {
                    conn.Open();
                    da.Fill(ds);
                    return ds;
                }
                catch (System.Exception ex)
                {
                    //将错误信息写入日志文件
                    LogService.WriteErrorLog(ex.Message);
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
            ///// <summary>
            ///// 获取多个数据集，读取时可以根据表的名称访问DataTable
            ///// </summary>
            ///// <param name="sql">使用HashTable类型的泛型集合封装对应的SQL语句和数据表名称</param>
            ///// <returns>返回包含若干个数据表的数据集</returns>
            //public   DataSet GetDataSet(List<ArrayList> sqlNameSqlParamDic)
            //{
            //    SQLiteConnection conn = new SQLiteConnection(connString);
            //    SQLiteCommand cmd = new SQLiteCommand();
            //    cmd.Connection = conn;
            //    SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            //    DataSet ds = new DataSet();
            //    try
            //    {
            //        conn.Open();
            //        foreach(var item in sqlNameSqlParamDic)
            //        {
            //            cmd.CommandText = (string)item[1];
            //            cmd.Parameters.AddRange((SQLiteParameter[])item[2]);
            //            da.Fill(ds, (string)item[0]);//tableName
            //        }
            //        return ds;
            //    }
            //    catch(System.Exception ex)
            //    {
            //        //将错误信息写入日志文件
            //        LogService.WriteLog(ex.Message);
            //        throw ex;
            //    }
            //    finally
            //    {
            //        conn.Close();
            //    }
            //}

            #region 执行事务
            /// <summary>
            /// 基于ADO.NET事务提交多条sql语句
            /// </summary>
            /// <param name="sql"></param>
            /// <returns>返回是否执行成功</returns>
            public bool UpdateByTransaction(Dictionary<string, SQLiteParameter[]> sqlParamList)
            {
                SQLiteConnection conn = new SQLiteConnection(connString);
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conn;
                try
                {
                    conn.Open();
                    cmd.Transaction = conn.BeginTransaction();//开启事务
                    foreach (var item in sqlParamList)
                    {
                        cmd.CommandText = item.Key;
                        cmd.Parameters.AddRange(item.Value);
                        cmd.ExecuteNonQuery();
                    }
                    cmd.Transaction.Commit();//提交事务（同时自动清除事务）
                    return true;
                }
                catch (System.Exception ex)
                {
                    if (cmd.Transaction != null)
                    {
                        cmd.Transaction.Rollback();//回滚事务
                    }
                    //将错误信息写入日志文件
                    LogService.WriteErrorLog(ex.Message);
                    throw ex;
                }
                finally
                {
                    if (cmd.Transaction != null)
                    {
                        cmd.Transaction = null;
                    }
                    conn.Close();
                }
            }
            #endregion
            #endregion

            #region 调用存储过程

            /// <summary>
            /// 增删改操作
            /// </summary>
            /// <param name="sql"></param>
            /// <returns>返回受影响的行数</returns>
            public int UpdateByProcedure(string storeProcedureName, SQLiteParameter[] param = null)
            {
                SQLiteConnection conn = new SQLiteConnection(connString);
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;//告诉Commmand对象，当前的操作时执行存储过程
                cmd.CommandText = storeProcedureName;
                if (param != null)
                {
                    cmd.Parameters.AddRange(param);
                }
                try
                {
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
                catch (System.Exception ex)
                {
                    //将错误信息写入日志文件
                    LogService.WriteErrorLog(ex.Message);
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
            /// <summary>
            /// 获取单一结果
            /// </summary>
            /// <param name="sql"></param>
            /// <returns></returns>
            public object GetSingleResultByProcedure(string storeProcedureName, SQLiteParameter[] param = null)
            {
                SQLiteConnection conn = new SQLiteConnection(connString);
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;//告诉Commmand对象，当前的操作时执行存储过程
                cmd.CommandText = storeProcedureName;
                if (param != null)
                {
                    cmd.Parameters.AddRange(param);
                }
                try
                {
                    conn.Open();
                    return cmd.ExecuteScalar();
                }
                catch (System.Exception ex)
                {
                    //将错误信息写入日志文件
                    LogService.WriteErrorLog(ex.Message);
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
            /// <summary>
            /// 获取结果集（只读）
            /// </summary>
            /// <param name="sql"></param>
            /// <returns></returns>
            public SQLiteDataReader GetReaderByProcedure(string storeProcedureName, SQLiteParameter[] param = null)
            {
                SQLiteConnection conn = new SQLiteConnection(connString);
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;//告诉Commmand对象，当前的操作时执行存储过程
                cmd.CommandText = storeProcedureName;
                if (param != null)
                {
                    cmd.Parameters.AddRange(param);
                }
                try
                {
                    conn.Open();
                    return cmd.ExecuteReader(CommandBehavior.CloseConnection);
                }
                catch (System.Exception ex)
                {
                    //将错误信息写入日志文件
                    LogService.WriteErrorLog(ex.Message);
                    throw ex;
                }
            }
            /// <summary>
            /// 获取数据集
            /// </summary>
            /// <param name="sql"></param>
            /// <returns></returns>
            public DataSet GetDataSetByProcedure(string storeProcedureName, SQLiteParameter[] param = null)
            {
                SQLiteConnection conn = new SQLiteConnection(connString);
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;//告诉Commmand对象，当前的操作时执行存储过程
                cmd.CommandText = storeProcedureName;
                if (param != null)
                {
                    cmd.Parameters.AddRange(param);
                }
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataSet ds = new DataSet();
                try
                {
                    conn.Open();
                    da.Fill(ds);
                    return ds;
                }
                catch (System.Exception ex)
                {
                    //将错误信息写入日志文件
                    LogService.WriteErrorLog(ex.Message);
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
            #endregion

            #region 获取数据库服务器时间、将错误信息写入日志
            /// <summary>
            /// 获取数据库服务器时间
            /// </summary>
            /// <returns></returns>
            public DateTime GetServerTime()
            {
                string sql = "select getdate()";
                return Convert.ToDateTime(GetSingleResult(sql));
            }
            #endregion
        }
    }
}
