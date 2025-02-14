<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="zalogowanie.aspx.cs" Inherits="WebApplication1.zalogowanie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>logowanie</h1>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="Test" OnTextChanged="Test">
                <asp:ListItem Text="stolik1" Value="1"> </asp:ListItem>
                <asp:ListItem Text="stolik2" Value="2"> </asp:ListItem>
                <asp:ListItem Text="stolik3" Value="3"> </asp:ListItem>
            </asp:DropDownList>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
