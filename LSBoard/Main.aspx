<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="LSBoard.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>LSBoard</title>
    <link href="~/style.css" rel="stylesheet" />
    <link href="Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="login_btn" Text="SSO 로그인" runat="server" OnClick="login_btn_Click" CssClass="btn btn-primary"/>
        </div>
    </form>
</body>
</html>
