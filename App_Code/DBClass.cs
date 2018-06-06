using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

/// <summary>
/// DBClass 的摘要说明
/// </summary>
public class DBClass
{
    private SqlConnection conn = null;
    //从web.config文件中取连接字符串
    private static string SQLConnectionString = ConfigurationManager.ConnectionStrings["NBA"].ConnectionString;

    // 打开数据库连接
    public void Open()
    {
        if (conn == null)   // 判断连接是否已经创建
            conn = new SqlConnection(SQLConnectionString);
        if (conn.State == ConnectionState.Closed)     // 判断连接状态是否已打开
            conn.Open();
    }

    // 关闭数据库连接      
    public void Close()
    {
        if (conn != null && (conn.State == ConnectionState.Open))
            conn.Close();
    }

    // 释放资源
    public void Dispose()
    {
        if (conn != null)
        {
            conn.Dispose();
            conn = null;
        }
    }

    // 带入并执行SQL语句，将查询结果以DataReader对象返回
    public SqlDataReader RunSQLtoDataReader(string sqlText)
    {
        SqlDataReader dr = null;  // 定义DataReader对象dr，并初始化        
        try
        {
            Open();   // 打开数据库连接
            SqlCommand cmd = new SqlCommand(sqlText, conn); // 创建Command对象cmd
            dr = cmd.ExecuteReader(); // 将查询结果填入阅读器对象中
        }
        catch
        {
            dr = null;
        }
        finally
        {
            Close(); // 关闭数据库连接
        }
        return dr;   // 返回阅读器对象
    }

    // 带入并执行SQL语句，将查询结果以DataTable对象返回
    public DataTable RunSQLtoDataTable(string sqlText)
    {
        DataTable dt = null;
        try
        {
            // 打开数据库连接
            Open();
            // 创建DataAdapter对象adap, 并关联要执行的查询命令和Connection对象
            SqlDataAdapter adap = new SqlDataAdapter(sqlText, conn);
            // 创建DataSet对象ds
            DataSet ds = new DataSet();
            // 将查询结果填入数据集对象的tempTab表中
            adap.Fill(ds, "tempTab");
            dt = ds.Tables["tempTab"];
        }
        catch
        {
            dt = null;
        }
        finally
        {
            Close(); // 关闭数据库连接
        }
        return dt; // 返回数据表对象
    }

    // 带入并执行SQL语句，将查询结果以string对象返回
    public string RunSQLtoString(string sqlText)
    {
        string str = null;
        try
        {
            Open();
            SqlCommand cmd = new SqlCommand(sqlText, conn);
            str = cmd.ExecuteScalar().ToString(); //将查询结果转换为串类型           
        }
        catch
        {
            str = null;
        }
        finally
        {
            Close();
        }
        return str;
    }

    // 带入并执行SQL语句，将查询结果以int对象返回
    public int RunSQLtoInt(string sqlText)
    {
        int n;
        try
        {
            Open();
            SqlCommand cmd = new SqlCommand(sqlText, conn);
            n = Convert.ToInt16(cmd.ExecuteScalar());
        }
        catch
        {
            n = -1;
        }
        finally
        {
            Close();
        }
        return n;
    }



    // 带入并执行SQL语句，一般用于update和insert语句,返回所影响的行数
    public int RunCmd(string cmdText)
    {
        int n;
        try
        {
            Open();
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            n = cmd.ExecuteNonQuery();
        }
        catch
        {
            n = -1;
        }
        finally
        {
            Close();
        }
        return n;
    }

    // 将存储过程与SqlCommand对象关联,并返回
    public SqlCommand ChangeProcToCmd(string procName)
    {
        SqlCommand cmd = new SqlCommand();
        Open();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = conn;
        cmd.CommandText = procName;
        return cmd;
    }
}