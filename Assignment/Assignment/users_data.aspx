<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="users_data.aspx.cs" Inherits="Assignment.users_data" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:connect %>" SelectCommand="SELECT * FROM [users] ORDER BY [type]"></asp:SqlDataSource>
            <br />
            users info :</div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="userid" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="userid" HeaderText="userid" InsertVisible="False" ReadOnly="True" SortExpression="userid" />
                <asp:BoundField DataField="username" HeaderText="username" SortExpression="username" />
                <asp:BoundField DataField="password" HeaderText="password" SortExpression="password" />
                <asp:BoundField DataField="type" HeaderText="type" SortExpression="type" />
            </Columns>
        </asp:GridView>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="add data" />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;
    </form>
</body>
</html>
