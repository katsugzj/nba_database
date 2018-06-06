using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// AdminInfo 的摘要说明
/// </summary>
public class AdminInfo
{
    DBClass dbObj = new DBClass();  // 创建（实例化）一个数据访问层类的对象dbObj

    // 输入“管理员名”和“密码”，判断该管理员是否存在，如存在返回true，否则返回false。
    public bool AdminExist(string p_AdminName, string p_AdminPassword)
    {     
        string cmdText = "SELECT COUNT(*) FROM admin WHERE username='" + p_AdminName + "' AND pwd='" + p_AdminPassword + "'";
        // 调用数据访问层类的RunSQLtoInt方法 
        int count = dbObj.RunSQLtoInt(cmdText);
        if (count == 1)     // 有满足条件的记录，即管理员存在
            return true;
        else
            return false;
    }

    //输入管理员名看该用户名是否已被占用
    public bool AdminNameExist(string p_AdminName)
    {
        string cmdText = "SELECT COUNT(*) FROM admin WHERE username='" + p_AdminName + "'";
        // 调用数据访问层类的RunSQLtoInt方法 
        int count = dbObj.RunSQLtoInt(cmdText);
        if (count == 1)     // 有满足条件的记录，即管理员存在
            return false;
        else
            return true;
    }

    // 输入“管理员名”和“密码”、“新密码”
    // 返回1，密码修改成功；返回2，旧密码错误；返回3，修改密码失败
    public int AdminChangePwd(string p_AdminName, string p_AdminPassword, string p_AdminPasswordNew)
    {
        DBClass dbObj = new DBClass();
        int result = 3;       
        string cmdText1 = "SELECT COUNT(*) FROM admin WHERE username='" + p_AdminName + "' AND pwd='" + p_AdminPassword + "'";
        // 调用数据访问层类的RunSQLtoInt方法 
        int count1 = dbObj.RunSQLtoInt(cmdText1);
        if (count1 == 1)     // 有满足条件的记录，即管理员存在
        {
            string cmdText2 = "update admin set pwd='" + p_AdminPasswordNew + "' where username= '" + p_AdminName + "'";
            int count2 = dbObj.RunCmd(cmdText2);
            if (count2 == 1)
                result = 1;
            else
                result = 3;
        }
        else
            result = 2; ; //密码错误
        return result;
    }

    //插入新管理员
    public int AdminNew(string p_AdminName,string p_AdminPassword)
    {
        DBClass dbObj = new DBClass();
        int result = 0;
        string cmdText1 = "insert into admin values('" + p_AdminName + "','" + p_AdminPassword + "')";
        result = dbObj.RunCmd(cmdText1);
        return result;
    }
}