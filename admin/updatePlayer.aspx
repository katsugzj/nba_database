<%@ Page Language="C#" AutoEventWireup="true" CodeFile="updatePlayer.aspx.cs" Inherits="admin_updatePlayer" %>

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
                                <img alt="" border="0" name="nba" src="../img/nba-icon.png" style="width: 50px; height: 100%; margin-top: 0px;" /></td>
                            <td>
                                <table align="left" border="0" cellpadding="0" cellspacing="0" style="width: 600px">
                                    <tr>
                                        <td align="right" class="nav" style="height: 45px"
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
                                <asp:TreeNode NavigateUrl="adminRetire.aspx" Text="退役" Value="退役">
                                </asp:TreeNode>
                            </asp:TreeNode>
                        </Nodes>
                    </asp:TreeView>
                </td>
                <td align="center">
                    <table class="style1">
                        <tr>
                            <td class="style2" style="text-align: right">
                                姓名：</td>
                            <td style="text-align: left">
                                <asp:TextBox ID="txtname" 
                        runat="server" MaxLength="20" Width="150px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtname" ErrorMessage="请填写姓名！"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="style2" style="text-align: right">
                                所属球队：</td>
                            <td style="text-align: left">
                                <asp:DropDownList ID="ddlteamname" runat="server" DataSourceID="NBA" DataTextField="teamname" DataValueField="teamname">
                                </asp:DropDownList>
                                <asp:SqlDataSource ID="NBA" runat="server" ConnectionString="<%$ ConnectionStrings:NBA %>" SelectCommand="SELECT [teamname] FROM [team]"></asp:SqlDataSource>
                            </td>
                        </tr>
                        <tr>
                            <td class="style2">
                                身高</td>
                            <td style="text-align: left">
                                <asp:TextBox ID="txtHeight" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style2">
                                体重</td>
                            <td style="text-align: left">
                                <asp:TextBox ID="txtWeight" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style2">
                                号码</td>
                            <td style="text-align: left">
                                <asp:TextBox ID="num" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style2">
                                国籍</td>
                            <td style="text-align: left">
                                <asp:TextBox ID="country" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style2">
                                选秀年</td>
                            <td style="text-align: left">
                                <asp:TextBox ID="rk" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style2">
                                选秀排名</td>
                            <td style="text-align: left">
                                <asp:TextBox ID="ra" runat="server"></asp:TextBox>
                            </td>
                        </tr><tr>
                            <td class="style2">
                                是否现役</td>
                            <td style="text-align: left">
                                <asp:RadioButtonList ID="isActive" runat="server">
                                    <asp:ListItem Value="0">否</asp:ListItem>
                                    <asp:ListItem Value="1">是</asp:ListItem>
                                </asp:RadioButtonList>
                            </td>
                        </tr>
                        <tr>
                            <td class="style2">
                                &nbsp;</td>
                            <td style="text-align: left">
                                <asp:Button ID="btnChange" runat="server" onclick="btnChange_Click" Text="修改数据" 
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