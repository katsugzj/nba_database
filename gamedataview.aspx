<%@ Page Language="C#" AutoEventWireup="true" CodeFile="gamedataview.aspx.cs" Inherits="gamedata" %>

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
                      <table>
                        <tr>
                            <td>
                                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><a>得分：</a>
                            </td>
                            <td>
                                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label><a>得分：</a>
                            </td>
                            <td>
                                <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                      </table>
                      <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" Width="100%" AllowPaging="True" DataKeyNames="gameid,playerid,id">
                          <Columns>
                              <asp:HyperLinkField DataNavigateUrlFields="team" HeaderText="队名" SortExpression="team" DataTextField="team" DataNavigateUrlFormatString="team.aspx?team={0}"/>
                              <asp:BoundField DataField="number" HeaderText="号码" SortExpression="number" />
                              <asp:HyperLinkField DataNavigateUrlFields="playerid" HeaderText="球员" SortExpression="playername" DataTextField="playername" DataNavigateUrlFormatString="playerview.aspx?playerid={0}"/>
                              <asp:BoundField DataField="playingtime" HeaderText="上场时间" SortExpression="playingtime" />
                              <asp:BoundField DataField="score" HeaderText="得分" SortExpression="score" />
                              <asp:BoundField DataField="rebound" HeaderText="篮板" SortExpression="rebound" />
                              <asp:BoundField DataField="assist" HeaderText="助攻" SortExpression="assist" />
                              <asp:BoundField DataField="cap" HeaderText="盖帽" SortExpression="cap" />
                              <asp:BoundField DataField="steal" HeaderText="抢断" SortExpression="steal" />
                              <asp:BoundField DataField="hit" HeaderText="命中" SortExpression="hit" />
                              <asp:BoundField DataField="shot" HeaderText="出手" SortExpression="shot" />
                              <asp:BoundField DataField="t_hit" HeaderText="3分命中" SortExpression="t_hit" />
                              <asp:BoundField DataField="t_shot" HeaderText="3分出手" SortExpression="t_shot" />
                              <asp:BoundField DataField="freehit" HeaderText="罚球命中" SortExpression="freehit" />
                              <asp:BoundField DataField="freeshot" HeaderText="罚球" SortExpression="freeshot" />
                              <asp:BoundField DataField="foul" HeaderText="犯规" SortExpression="foul" />
                          </Columns>
                      </asp:GridView>
                      <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NBA %>" SelectCommand="select * from gamedata join player on playerid = id "></asp:SqlDataSource>
                  </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>