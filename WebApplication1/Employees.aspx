<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employees.aspx.cs" Inherits="WebApplication1.Employees" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="gridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id" >
    <Columns>
        <asp:BoundField DataField="id" HeaderText="id" SortExpression="id" />
        <asp:BoundField DataField="first_name" HeaderText="First Name" SortExpression="first_name" />
        <asp:BoundField DataField="last_name" HeaderText="Last Name" SortExpression="last_name" />
        <asp:BoundField DataField="email" HeaderText="Email" SortExpression="email" />
    </Columns>
</asp:GridView>

        
    </form>
</body>
</html>
