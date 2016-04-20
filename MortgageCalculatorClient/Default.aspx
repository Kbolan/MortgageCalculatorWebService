<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Kevin Bolan&#39;s Simple Mortgage Calculator Web Service<br />
        <br />
        <br />
        Loan Amount:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Label ID="erra" runat="server" ForeColor="#FF3300"></asp:Label>
        <br />
        <br />
        Interest Rate Percent (i.e. enter 5 for 5%):
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Label ID="errb" runat="server" ForeColor="#FF3300"></asp:Label>
        <br />
        <br />
        Years of Loan:
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:Label ID="errc" runat="server" ForeColor="#FF3300"></asp:Label>
        <br />
        <br />
        <asp:Button id="btnSubmit" Text="Submit" OnClick="btnSubmit_Click" Runat="Server" />
        <br />
        <br />
        <asp:Label ID="LabelResult" runat="server" Text=""></asp:Label>
    
    </div>
    </form>
</body>
</html>
