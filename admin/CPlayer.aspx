<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CPlayer.aspx.cs" Inherits="admin_CPlayer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>NBA</title>
    <link href="../style.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style4 {
            width: 1295px;
        }
        .auto-style5 {
            height: 293px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table border="0" cellpadding="0" cellspacing="0" width="600" align="center" class="auto-style5">
            <tr>
                <td style="height: 60px" colspan="2">
                    <table align="left" border="0" cellpadding="0" cellspacing="0" width="600" style="height: 89px">
                        <tr>
                            <td>
                                <img alt="" border="0" name="nba" src="../img/nba-icon.png" style="width: 61px; height: 141px; margin-top: 0px;" /></td>
                            <td class="auto-style4">
                                <table align="left" border="0" cellpadding="0" cellspacing="0" style="width: 600px">
                                    <tr>
                                        <td align="right" class="nav" style="height: 45px"
                                            valign="bottom" width="100%">
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
                  <td valign="top" align="left" width="15%" >
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
                                <asp:TreeNode Text="球队" Value="球队">
                                    <asp:TreeNode NavigateUrl="adminTeam.aspx" Text="球队添加" Value="球队添加">
                                    </asp:TreeNode>
                                    <asp:TreeNode NavigateUrl="CTeam.aspx" Text="球队管理" Value="球队管理">
                                    </asp:TreeNode>
                                </asp:TreeNode>
                                <asp:TreeNode Text="球员" Value="球员">
                                    <asp:TreeNode NavigateUrl="adminPlayer.aspx" Text="球员添加" Value="球员添加">
                                    </asp:TreeNode>
                                    <asp:TreeNode NavigateUrl="CPlayer.aspx" Text="球员管理" Value="球员管理">
                                    </asp:TreeNode>
                                </asp:TreeNode>
                                <asp:TreeNode Text="赛程" Value="赛程">
                                    <asp:TreeNode NavigateUrl="adminGame.aspx" Text="赛程添加" Value="赛程添加">
                                    </asp:TreeNode>
                                    <asp:TreeNode NavigateUrl="CGame.aspx" Text="赛程管理" Value="赛程管理">
                                    </asp:TreeNode>
                                </asp:TreeNode>
                                <asp:TreeNode Text="比赛数据" Value="比赛数据">
                                    <asp:TreeNode NavigateUrl="adminData.aspx" Text="比赛数据添加" Value="比赛数据添加">
                                    </asp:TreeNode>
                                    <asp:TreeNode NavigateUrl="CData.aspx" Text="比赛数据管理" Value="比赛数据管理">
                                    </asp:TreeNode>
                                </asp:TreeNode>
                                <asp:TreeNode Text="荣誉" Value="荣誉">
                                    <asp:TreeNode NavigateUrl="adminHonour.aspx" Text="荣誉添加" Value="荣誉添加">
                                    </asp:TreeNode>
                                    <asp:TreeNode NavigateUrl="CHonour.aspx" Text="荣誉管理" Value="荣誉管理">
                                    </asp:TreeNode>
                                </asp:TreeNode>
                                <asp:TreeNode Text="退役" Value="退役">
                                    <asp:TreeNode NavigateUrl="adminRetire.aspx" Text="退役添加" Value="退役添加">
                                    </asp:TreeNode>
                                    <asp:TreeNode NavigateUrl="CRetire.aspx" Text="退役管理" Value="退役管理">
                                    </asp:TreeNode>
                                </asp:TreeNode>
                            </asp:TreeNode>
                        </Nodes>
                    </asp:TreeView>
                </td>
                <td align="center">
                    
                    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" Width="100%" Height="100%" DataKeyNames="id">
                        <Columns>
                            <asp:BoundField DataField="id" HeaderText="id" SortExpression="id" ReadOnly="True" Visible="False" />
                            <asp:BoundField DataField="playername" HeaderText="球员" SortExpression="playername" />
                            <asp:HyperLinkField DataNavigateUrlFields="id" DataNavigateUrlFormatString="updatePlayer.aspx?id={0}" Text="修改" HeaderText="修改" />
                            <asp:CommandField HeaderText="删除" ShowDeleteButton="True" ShowHeader="True" />
                        </Columns>
                    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NBA %>" DeleteCommand =" delete from player where id = @id" SelectCommand="SELECT [id], [playername] FROM [player]"></asp:SqlDataSource>
                    
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>