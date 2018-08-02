<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="approving.aspx.cs" Inherits="Assignment.approving" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:connect %>" SelectCommand="SELECT [Id], [requester], [reason], [status] FROM [appr] WHERE (([approver] = @approver) AND ([status] = @status))">
                <SelectParameters>
                    <asp:QueryStringParameter Name="approver" QueryStringField="name" Type="String" />
                    <asp:Parameter DefaultValue="0" Name="status" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:connect %>" SelectCommand="SELECT [Id], [requester], [reason], [status] FROM [appr] WHERE (([approver] = @approver) AND ([status] = @status))">
                <SelectParameters>
                    <asp:QueryStringParameter Name="approver" QueryStringField="name" Type="String" />
                    <asp:Parameter DefaultValue="1" Name="status" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>
        </div>
        <p>
            pending approvals are:</p>
        <p>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                    <asp:BoundField DataField="requester" HeaderText="requester" SortExpression="requester" />
                    <asp:BoundField DataField="reason" HeaderText="reason" SortExpression="reason" />
                    <asp:BoundField DataField="status" HeaderText="status" SortExpression="status" />
                </Columns>
            </asp:GridView>
        </p>
        <p>
            &nbsp;request id :&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p style="margin-left: 40px">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="approve" />
&nbsp;&nbsp;&nbsp;
        </p>
        <p style="margin-left: 40px">
            pending requests are:</p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource2">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                    <asp:BoundField DataField="requester" HeaderText="requester" SortExpression="requester" />
                    <asp:BoundField DataField="reason" HeaderText="reason" SortExpression="reason" />
                    <asp:BoundField DataField="status" HeaderText="status" SortExpression="status" />
                </Columns>
            </asp:GridView>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
