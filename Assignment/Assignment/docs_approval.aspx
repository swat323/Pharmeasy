<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="docs_approval.aspx.cs" Inherits="Assignment.docs_approval" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:connect %>" SelectCommand="SELECT [Id], [approver], [reason], [status] FROM [appr] WHERE ([requester] = @requester)">
            <SelectParameters>
                <asp:QueryStringParameter Name="requester" QueryStringField="name" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
        the data is:<br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" InsertVisible="False" />
                <asp:BoundField DataField="approver" HeaderText="approver" SortExpression="approver" />
                <asp:BoundField DataField="reason" HeaderText="reason" SortExpression="reason" />
                <asp:BoundField DataField="status" HeaderText="status" SortExpression="status" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
