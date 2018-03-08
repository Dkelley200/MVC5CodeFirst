<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MVC5CodeFirst.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
                    <asp:BoundField DataField="DocName" HeaderText="DocName" SortExpression="DocName" />
                    <asp:BoundField DataField="Location" HeaderText="Location" SortExpression="Location" />
                </Columns>
            </asp:GridView>
        </div>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetDocType" TypeName="MVC5CodeFirst.TradingPartnerRespository"></asp:ObjectDataSource>
    </form>
</body>
</html>
