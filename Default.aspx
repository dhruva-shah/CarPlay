<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Year :&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox_year" runat="server" Height="16px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        Make :&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox_make" runat="server"></asp:TextBox>
        <br />
        <br />
        Speed :&nbsp;&nbsp;
        <asp:TextBox ID="TextBox_speed" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label_info" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button_done" runat="server" OnClick="Button_done_Click" Text="Done" />
        <br />
        <asp:Panel ID="Panel1" runat="server" Visible="False">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button_acc" runat="server" Text="Accelerate" OnClick="Button_acc_Click" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button_brake" runat="server" OnClick="Button_brake_Click" Text="Brake" />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button_restart" runat="server" OnClick="Button_restart_Click" Text="Restart" />
        </asp:Panel>
    </form>
</body>
</html>
