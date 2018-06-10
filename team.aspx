<%@ Page Language="C#" AutoEventWireup="true" CodeFile="team.aspx.cs" Inherits="teamview" %>

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
                      <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" Width="100%" AllowPaging="True" DataKeyNames="teamname">
                          <Columns>
                              <asp:BoundField DataField="part" HeaderText="分区" ReadOnly="True" SortExpression="part" />
                              <asp:HyperLinkField DataNavigateUrlFields="teamname" HeaderText="队名" SortExpression="teamname" DataTextField="teamname" DataNavigateUrlFormatString="team.aspx?team={0}"/>
                              <asp:BoundField DataField="arena" HeaderText="球馆" SortExpression="arena" />
                              <asp:BoundField DataField="coach" HeaderText="教练" SortExpression="coach" />
                              <asp:BoundField DataField="addtime" HeaderText="加入时间" SortExpression="addtime" />
                          </Columns>
                      </asp:GridView>
                      <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NBA %>" SelectCommand="SELECT * FROM [V_team] ORDER BY [part], [teamname]"></asp:SqlDataSource>
                      <asp:GridView ID="GridView2" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource2" Width="100%">
                          <Columns>
                              <asp:HyperLinkField DataNavigateUrlFields="id" HeaderText="球员" SortExpression="playername" DataTextField="playername" DataNavigateUrlFormatString="playerview.aspx?playerid={0}">
                              <ItemStyle HorizontalAlign="Center" />
                              </asp:HyperLinkField>
                              <asp:BoundField DataField="number" HeaderText="球衣号码" SortExpression="number" >
                              <ItemStyle HorizontalAlign="Center" />
                              </asp:BoundField>
                          </Columns>
                      </asp:GridView>
                      <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:NBA %>" SelectCommand="SELECT [playername], [number],id FROM [player]"></asp:SqlDataSource>
                  </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
