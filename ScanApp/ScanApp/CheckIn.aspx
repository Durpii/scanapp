<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheckIn.aspx.cs" Inherits="ScanApp.CheckIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width: 100%;">
                <caption class="style1">
                    <strong>Login Form</strong>
                </caption>
                <tr>
                    <td class="style2"></td>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td class="style2">Name:</td>
                    <td>
                        <asp:TextBox ID="tb_Name" runat="server" autocomplete="off"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="rfv_NameTb" runat="server"
                            ControlToValidate="tb_Name" ErrorMessage="Please enter your name"
                            ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style2">Rank:</td>
                    <td>
                        <asp:TextBox ID="tb_Rank" runat="server" autocomplete="off"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="rfv_RankTb" runat="server"
                            ControlToValidate="tb_Rank" ErrorMessage="Please enter your rank"
                            ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style2">&nbsp;</td>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td class="style2">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="style2"></td>
                    <td>
                        <asp:Button ID="btnCheckIn" runat="server" Text="Check In" OnClick="btnCheckIn_Click" />
                    </td>
                    <td>
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
