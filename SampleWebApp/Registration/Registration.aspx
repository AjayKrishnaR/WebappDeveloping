<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="SampleWebApp.Registration" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 45%;
            border: 4px solid #000000;
            height: 312px;
            margin-left: 429px;
        }
        .auto-style2 {
            width: 152px;
            font-weight: 700;
            text-align: center;
        }
        .auto-style3 {
            width: 546px;
        }
        .auto-style4 {
            width: 248px;
        }
        .auto-style5 {
            width: 546px;
            height: 26px;
        }
        .auto-style6 {
            width: 152px;
            font-weight: 700;
            text-align: center;
            height: 26px;
        }
        .auto-style7 {
            width: 248px;
            height: 26px;
        }
        .auto-style8 {
            height: 26px;
            width: 199px;
        }
        .auto-style9 {
            width: 199px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1 style="text-align: center">REGISTER HERE</h1>
        <br />
        <br />
        <br />
        <br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style9">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2">User Name:</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox1" runat="server" Width="217px" ToolTip="Enter Username"></asp:TextBox>
                </td>
                <td class="auto-style9">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="This is a Required Field" ForeColor="Red" ValidationGroup="a"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2">Password :</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox2" runat="server" Width="218px" TextMode="Password" ToolTip="Make Sure it is Not Easy."></asp:TextBox>
                </td>
                <td class="auto-style9">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="This is a Required Field" ForeColor="Red" ValidationGroup="a"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2">Re-Enter Password :</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox3" runat="server" Width="221px" TextMode="Password"></asp:TextBox>
                </td>
                <td class="auto-style9">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="This is a Required Field" ForeColor="Red" ValidationGroup="a"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox2" ControlToValidate="TextBox3" ErrorMessage="Passsword Must Match" ForeColor="Red" ValidationGroup="a"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </td>
                <td class="auto-style6">Email :</td>
                <td class="auto-style7">
                    <asp:TextBox ID="TextBox4" runat="server" Width="220px"></asp:TextBox>
                </td>
                <td class="auto-style8">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="This is a Required Field" ForeColor="Red" ValidationGroup="a"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox4" ErrorMessage="Enter a Valid Email Id" ForeColor="#FF3300" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="a"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Login</asp:LinkButton>
                </td>
                <td class="auto-style2"></td>
                <td class="auto-style4">
                    <asp:Button ID="Button1" runat="server" Height="30px" Text="Register" Width="155px" OnClick="Button1_Click" ValidationGroup="a" />
                </td>
                <td class="auto-style9"></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
