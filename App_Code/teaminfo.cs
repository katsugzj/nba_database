using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// gamedatainfo 的摘要说明
/// </summary>
public class teaminfo
{
    DBClass dbObj = new DBClass();

    //插入比赛数据
    public int Addteaminfo(string teamname, string arena, int teampartition,string coach,string addtime)
    {
        //连接存储过程
        SqlCommand cmd = dbObj.ChangeProcToCmd("pr_addteam");
        //传参
        cmd.Parameters.AddWithValue("@teamname", teamname);
        cmd.Parameters.AddWithValue("@arena", arena);
        cmd.Parameters.AddWithValue("@teampartition", teampartition);
        cmd.Parameters.AddWithValue("@coach", coach);
        cmd.Parameters.AddWithValue("@addtime", addtime);
        //执行
        int flag = cmd.ExecuteNonQuery();
        dbObj.Close();
        return flag;
    }

    public int Updateteaminfo(string teamname, string arena, int teampartition, string coach, string addtime)
    {
        //连接存储过程
        SqlCommand cmd = dbObj.ChangeProcToCmd("pr_updateteam");
        //传参
        cmd.Parameters.AddWithValue("@teamname", teamname);
        cmd.Parameters.AddWithValue("@arena", arena);
        cmd.Parameters.AddWithValue("@teampartition", teampartition);
        cmd.Parameters.AddWithValue("@coach", coach);
        cmd.Parameters.AddWithValue("@addtime", addtime);
        //执行
        int flag = cmd.ExecuteNonQuery();
        dbObj.Close();
        return flag;
    }

    public DataTable getInfobyName(string name)
    {
        string cmdText = "select * from team where teamname = '" + name + "'";
        return dbObj.RunSQLtoDataTable(cmdText);
    }
}