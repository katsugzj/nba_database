using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// gamedatainfo 的摘要说明
/// </summary>
public class retireinfo
{
    DBClass dbObj = new DBClass();

    //插入比赛数据
    public int Addretireinfo(int retireyear, string teamname, int retirenumber)
    {
        //连接存储过程
        SqlCommand cmd = dbObj.ChangeProcToCmd("pr_addhonour");
        //传参
        cmd.Parameters.AddWithValue("@retireyear", retireyear);
        cmd.Parameters.AddWithValue("@teamname", teamname);
        cmd.Parameters.AddWithValue("@retirenumber", retirenumber);
        //执行
        int flag = cmd.ExecuteNonQuery();
        dbObj.Close();
        return flag;
    }
}