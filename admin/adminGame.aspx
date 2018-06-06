<%@ Page Language="C#" AutoEventWireup="true" CodeFile="adminGame.aspx.cs" Inherits="admin_adminGame" %>

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
                                <img alt="" border="0" name="newsCenter_r2_c1" src="../img/nba-icon.png" style="width: 50px; height: 80px; margin-top: 0px;" /></td>
                            <td>
                                <table align="left" border="0" cellpadding="0" cellspacing="0" style="width: 600px">
                                    <tr>
                                        <td align="right" background="../images/newsCenter_r2_c2.jpg" class="nav" style="height: 45px"
                                            valign="bottom" width="600">
                                            <asp:Button ID="btnLogout" runat="server" onclick="btnLogout_Click" 
                                                Text="注销退出" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr style="font-size: 10pt; color: #000000" >
                  <td valign="top" align="left" background="../images/newsCenter_r4_c1.jpg" width="15%" >
                    <asp:TreeView ID="TreeView1" runat="server">
                        <Nodes>
                            <asp:TreeNode Text="后台管理" Value="后台管理">
                                <asp:TreeNode NavigateUrl="adminIndex.aspx" Text="管理首页" Value="管理首页">
                                </asp:TreeNode>
                                <asp:TreeNode NavigateUrl="adminPwd.aspx" Text="修改密码" Value="修改密码">
                                </asp:TreeNode>
                                <asp:TreeNode NavigateUrl="addadmin.aspx" Text="增加管理员" Value="增加管理员">
                                </asp:TreeNode>
                            </asp:TreeNode>
                            <asp:TreeNode Text="数据管理" Value="数据管理">
                                <asp:TreeNode NavigateUrl="adminTeam.aspx" Text="球队管理" Value="球队管理">
                                </asp:TreeNode>
                                <asp:TreeNode NavigateUrl="adminPlayer.aspx" Text="球员管理" Value="球员管理">
                                </asp:TreeNode>
                                <asp:TreeNode NavigateUrl="adminGame.aspx" Text="赛程管理" Value="赛程管理">
                                </asp:TreeNode>
                                <asp:TreeNode NavigateUrl="adminData.aspx" Text="比赛数据" Value="比赛数据">
                                </asp:TreeNode>
                                <asp:TreeNode NavigateUrl="adminHonour.aspx" Text="荣誉管理" Value="荣誉管理">
                                </asp:TreeNode>
                            </asp:TreeNode>
                        </Nodes>
                    </asp:TreeView>
                </td>
                <td align="center">
                    <table class="style1">
                        <tr>
                            <td class="style2" style="text-align: right">
                                日期：</td>
                            <td style="text-align: left">
                                <asp:TextBox ID="txttime" 
                        runat="server" MaxLength="20" Width="150px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txttime" ErrorMessage="请填写日期！"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="style2" style="text-align: right">
                                主场：</td>
                            <td style="text-align: left">
                                <asp:DropDownList ID="ddlhost" runat="server" DataSourceID="NBA" DataTextField="teamname" DataValueField="teamname">
                                </asp:DropDownList>
                                <asp:SqlDataSource ID="NBA" runat="server" ConnectionString="<%$ ConnectionStrings:NBA %>" SelectCommand="SELECT [teamname] FROM [team]"></asp:SqlDataSource>
                            </td>
                        </tr>
                        <tr>
                            <td class="style2" style="text-align: right">
                                客场：</td>
                            <td style="text-align: left">
                                <asp:DropDownList ID="ddlvisitor" runat="server" DataSourceID="NBA" DataTextField="teamname" DataValueField="teamname">
                                </asp:DropDownList>
                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NBA %>" SelectCommand="SELECT [teamname] FROM [team]"></asp:SqlDataSource>
                            </td>
                        </tr>
                        <tr>
                            <td class="style2">
                                比赛类型</td>
                            <td style="text-align: let">
                                <asp:DropDownList ID="ddltype" runat="server">
                                    <asp:ListItem Value="1">季前赛</asp:ListItem>
                                    <asp:ListItem Value="2">常规赛</asp:ListItem>
                                    <asp:ListItem Value="3">季后赛第一轮</asp:ListItem>
                                    <asp:ListItem Value="4">季后赛第二轮</asp:ListItem>
                                    <asp:ListItem Value="5">分区决赛</asp:ListItem>
                                    <asp:ListItem Value="6">总决赛</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td class="style2">
                                &nbsp;</td>
                            <td style="text-align: left">
                                <asp:Button ID="btnAdd" runat="server" onclick="btnAdd_Click" Text="添加数据" 
                                    ValidationGroup="vg1" />
                                <asp:Label ID="lblMsg" runat="server"></asp:Label>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>