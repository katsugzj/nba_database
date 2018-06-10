<%@ Page Language="C#" AutoEventWireup="true" CodeFile="adminPwd.aspx.cs" Inherits="admin_adminPwd" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>NBA</title>
    <link href="../style.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 114px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table border="0" cellpadding="0" cellspacing="0" width="640" align="center">
            <tr>
                <td style="height: 60px" colspan="2">
                    <table align="left" border="0" cellpadding="0" cellspacing="0" width="640">
                        <tr>
                            <td>
                                <img alt="" border="0" height="141px" name="nba" src="../img/nba-icon.png"
                                    width="61"/></td>
                            <td>
                                <table align="left" border="0" cellpadding="0" cellspacing="0" width="600">
                                    <tr>
                                        <td align="right" class="nav" style="height: 45px"
                                            valign="bottom" width="600">
                                            <asp:Button ID="btnLogout" runat="server" onclick="btnLogout_Click" 
                                                Text="注销退出" UseSubmitBehavior="False" />
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
                    <table align="right" cellpadding="0" cellspacing="0" class="style1">
                        <tr>
                            <td class="style2" width="12%">
                                旧密码</td>
                            <td style="text-align: left">
                                <asp:TextBox ID="txtOldPwd" runat="server" MaxLength="10" Width="100px" 
                                    TextMode="Password"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                    ControlToValidate="txtOldPwd" ErrorMessage="请输旧密码！" ValidationGroup="vg1"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="style2">
                                新密码</td>
                            <td style="text-align: left">
                                <asp:TextBox ID="txtNewPwd1" runat="server" MaxLength="10" Width="100px" 
                                    style="margin-left: 0px" TextMode="Password"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                    ControlToValidate="txtNewPwd1" ErrorMessage="请输新密码!" ValidationGroup="vg1"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                    ErrorMessage="长6~10，字母/数字/特殊字符组合" 
                                    ValidationExpression="[-\da-zA-Z`=\\\[\];',./~!@#$%^&*()]{6,10}" 
                                    ControlToValidate="txtNewPwd1" ValidationGroup="vg1"></asp:RegularExpressionValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="style2">
                                重输新密码</td>
                            <td style="text-align: left">
                                <asp:TextBox ID="txtNewPwd2" runat="server" MaxLength="10" Width="100px" 
                                    TextMode="Password"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                    ErrorMessage="重新输入新密码!" ControlToValidate="txtNewPwd2" 
                                    ValidationGroup="vg1"></asp:RequiredFieldValidator>
                                <asp:CompareValidator ID="CompareValidator1" runat="server" 
                                    ControlToCompare="txtNewPwd1" ErrorMessage="两次新密码不一致!" 
                                    ControlToValidate="txtNewPwd2" ValidationGroup="vg1"></asp:CompareValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="style2">
                                &nbsp;</td>
                            <td style="text-align: left">
                                <asp:Button ID="btnChange" runat="server" onclick="btnChange_Click" 
                                    Text="修改密码" ValidationGroup="vg1" />
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
