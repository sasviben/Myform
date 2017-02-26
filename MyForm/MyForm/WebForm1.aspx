<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="MyForm.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style ="font-family:Arial">
        <table style="border:1px solid black">
        <tr>
            <td>
                Id drzave:
            </td>
            <td>
                <asp:TextBox ID="txtID" runat="server" AutoPostBack="True" OnTextChanged="txtID_TextChanged"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Ime:
            </td>
            <td>
                <asp:TextBox ID="txtIme" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Glavni grad:
            </td>
            <td>
                <asp:TextBox ID="txtGlavniGrad" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="lblMessage" runat="server" ForeColor ="Red"></asp:Label>
            </td>
        </tr>
        </table>
    </div>
    </form>
</body>
</html>
