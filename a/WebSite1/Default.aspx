<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TxtDisplay" runat="server" Width="334px"></asp:TextBox>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnClear" runat="server" Text="C" Width="156px" OnClick="btnClear_Click" />
        <br />
        <asp:Button ID="btn7" runat="server" Text="7" Width="85px" OnClick="btn7_Click" />
        <asp:Button ID="btn8" runat="server" Text="8" Width="95px" OnClick="btn8_Click" />
        <asp:Button ID="btn9" runat="server" Text="9" Width="97px" OnClick="btn9_Click" />
        &nbsp;
        <asp:Button ID="btnDiv" runat="server" Text="/" Width="55px" OnClick="btnDiv_Click" />
        <br />
        <asp:Button ID="btn4" runat="server" Text="4" Width="85px" OnClick="btn4_Click" />
        <asp:Button ID="btn5" runat="server" Text="5" Width="95px" OnClick="btn5_Click" />
        <asp:Button ID="btn6" runat="server" Text="6" Width="97px" OnClick="btn6_Click" style="height: 26px" />
        &nbsp;
        <asp:Button ID="btnMul" runat="server" Text="*" Width="55px" OnClick="btnMul_Click" />
        <br />
        <asp:Button ID="btn1" runat="server" OnClick="btn1_Click" Text="1" Width="85px" />
        <asp:Button ID="btn2" runat="server" Text="2" Width="95px" OnClick="btn2_Click" />
        <asp:Button ID="btn3" runat="server" Text="3" Width="97px" OnClick="btn3_Click" />
        &nbsp;
        <asp:Button ID="btnMinus" runat="server" Text="-" Width="55px" OnClick="btnMinus_Click" />
        <br />
        <asp:Button ID="btn0" runat="server" Text="0" Width="85px" OnClick="btn0_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" Text="=" Width="96px" />
        &nbsp;
        <asp:Button ID="Button12" runat="server" OnClick="Button12_Click" Text="+" Width="55px" />
    
    </div>
    </form>
</body>
</html>
