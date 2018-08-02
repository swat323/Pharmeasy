<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="insert_into_users.aspx.cs" Inherits="Assignment.insert_into_users" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            username :<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            password:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            type:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Show users" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="cleardb" />
        </div>
    </form>
</body>
</html>
