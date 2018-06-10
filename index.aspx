<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

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
                      <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" Width="100%" AllowPaging="True">
                          <Columns>
                              <asp:HyperLinkField DataNavigateUrlFields="id" HeaderText="比赛时间" SortExpression="gametime" DataTextField="gametime" DataNavigateUrlFormatString="gamedataview.aspx?id={0}">
                              <ItemStyle HorizontalAlign="Center" />
                              </asp:HyperLinkField>
                              <asp:HyperLinkField DataNavigateUrlFields="host" HeaderText="主场" SortExpression="host" DataNavigateUrlFormatString="team.aspx?team={0}" DataTextField="host">
                              <ItemStyle HorizontalAlign="Center" />
                              </asp:HyperLinkField>
                              <asp:HyperLinkField DataNavigateUrlFields="visitor" HeaderText="客场" SortExpression="visitor" DataNavigateUrlFormatString="team.aspx?team={0}" DataTextField="visitor">
                              <ItemStyle HorizontalAlign="Center" />
                              </asp:HyperLinkField>
                          </Columns>
                      </asp:GridView>
                      <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NBA %>" SelectCommand="SELECT id,[gametime], [host], [visitor] FROM [game] ORDER BY gametime DESC"></asp:SqlDataSource>
                  </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>