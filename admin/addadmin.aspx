<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addadmin.aspx.cs" Inherits="newAdmin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>NBA</title>
    <link href="../style.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 243px;
        }
    </style>
</head>
<body>
   <form id="form1" runat="server">
    <div>
        <table border="0" cellpadding="0" cellspacing="0" width="640" align="center">
            <tr>
                <td style="height: 60px">
                    <table align="left" border="0" cellpadding="0" cellspacing="0" width="640">
                        <tr>
                            <td>
                                <img alt="" border="0" name="newsCenter_r2_c1" src="../img/nba-icon.png" style="width: 50px; height: 80px" /></td>
                            <td>
                                <table align="left" border="0" cellpadding="0" cellspacing="0" style="width: 586px">
                                    <tr>
                                        <td align="right" class="nav" height="45" valign="bottom" width="600">
                                            <img align="absMiddle" src="../img/board_mark_list.gif" />
                                            <a class="nav" href="../news.aspx">主页</a> &nbsp;&nbsp;</td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr style="font-size: 12pt; color: #000000">
                <td align="center">
                    <table class="style1">
                        <tr>
                            <td class="style2" style="text-align: right">
                用户名：</td>
                            <td style="text-align: left">
                                <asp:TextBox ID="txtUsername" 
                        runat="server" MaxLength="20" Width="150px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtUsername" ErrorMessage="请填写用户名！"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="style2" style="text-align: right">
                                密码：</td>
                            <td style="text-align: left">
                                <asp:TextBox 
                        ID="txtPwd" runat="server" MaxLength="20" TextMode="Password" Width="150px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="txtPwd" ErrorMessage="请输入密码！"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="style2" style="text-align: right">
                                确认密码：</td>
                            <td style="text-align: left">
                                <asp:TextBox 
                        ID="txtrePwd" runat="server" MaxLength="20" TextMode="Password" Width="150px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="txtrePwd" ErrorMessage="请再次输入密码！"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="style2">
                                &nbsp;</td>
                            <td style="text-align: left">
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="注册" />
                    <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
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
