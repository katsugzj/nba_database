<%@ Page Language="C#" AutoEventWireup="true" CodeFile="honour.aspx.cs" Inherits="admin_honouraspx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>NBA</title>
    <link href="../style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table border="0" cellpadding="0" cellspacing="0" width="640" align="center" style="height: 293px">
            <tr>
                <td style="height: 60px" colspan="2">
                    <table align="left" border="0" cellpadding="0" cellspacing="0" width="640" style="height: 89px">
                        <tr>
                            <td>
                                <img alt="" border="0" name="nba" src="./img/nba-icon.png" style="width: 61px; height: 141px; margin-top: 0px;" /></td>
                            <td>
                                <table align="left" border="0" cellpadding="0" cellspacing="0" style="width: 600px">
                                    <tr>
                                        <td align="right" class="nav" style="height: 45px"
                                            valign="bottom" width="600">
                                            <asp:Button ID="btnLogin" runat="server" onclick="btnLogin_Click" 
                                                Text="管理员登陆" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr style="font-size: 10pt; color: #000000" >
                  <td valign="top" align="center" width="15%" >
                      <table style="width:100%;height :30px">
                          <tr>
                              <td align ="center"><a href ="team.aspx">球队</a></td>
                              <td align ="center"><a href ="playerview.aspx">球员</a></td>
                              <td align ="center"><a href ="index.aspx">赛程</a></td>
                              <td align ="center"><a href ="honour.aspx">荣誉</a></td>
                          </tr>
                      </table>
                      <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" Width="100%" AllowPaging="True" DataKeyNames="honouryear,playerid">
                          <Columns>
                              <asp:HyperLinkField DataNavigateUrlFields="honouryear" HeaderText="年份" SortExpression="honouryear" DataTextField="honouryear" DataNavigateUrlFormatString="honour.aspx?honouryear={0}"/>
                              <asp:BoundField DataField="playerid" HeaderText="playerid" ReadOnly="True" SortExpression="playerid" Visible="False" />
                              <asp:HyperLinkField DataNavigateUrlFields="playerid" HeaderText="球员" SortExpression="playername" DataTextField="playername" DataNavigateUrlFormatString="playerview.aspx?playerid={0}"/>
                              <asp:HyperLinkField DataNavigateUrlFields="team" HeaderText="队名" SortExpression="team" DataTextField="team" DataNavigateUrlFormatString="team.aspx?team={0}"/>
                              <asp:BoundField DataField="number" HeaderText="球衣号码" SortExpression="number" />
                              <asp:CheckBoxField DataField="regularseasonmvp" HeaderText="mvp" SortExpression="regularseasonmvp" />
                              <asp:CheckBoxField DataField="playoffmvp" HeaderText="playoffmvp" SortExpression="playoffmvp" />
                              <asp:CheckBoxField DataField="dpoy" HeaderText="dpoy" SortExpression="dpoy" />
                              <asp:BoundField DataField="全明星" HeaderText="全明星" SortExpression="全明星" ReadOnly="True" />
                              <asp:BoundField DataField="最佳阵容" HeaderText="最佳阵容" SortExpression="最佳阵容" ReadOnly="True" />
                              <asp:BoundField DataField="最佳防守阵容" HeaderText="最佳防守阵容" SortExpression="最佳防守阵容" ReadOnly="True" />
                              <asp:CheckBoxField DataField="active" HeaderText="现役" SortExpression="active" />
                          </Columns>
                      </asp:GridView>
                      <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NBA %>" SelectCommand="SELECT * FROM [V_honour] ORDER BY [honouryear] DESC"></asp:SqlDataSource>
                  </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>