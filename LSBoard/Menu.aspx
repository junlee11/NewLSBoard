<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="LSBoard.Menu" %>
<%@ Register Src="~/Footer.ascx" TagPrefix="uc1" TagName="Footer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>LSBoard</title>
    <link href="~/style.css" rel="stylesheet" />
    <link href="Content/bootstrap.css" rel="stylesheet" />        
    <script defer src="Script.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">        
        <div id="sidebar-wrapper" style="display:inline-block; vertical-align:top;">
            <ul class="sidebar-nav">
                <li>                    
                    <asp:LinkButton ID="link_home" Text="LSBoard" runat="server" 
                        CssClass="base_menu" OnClick="link_home_Click" />
                </li>
        
                <li>                    
                    <asp:LinkButton ID="link_intro" Text="프로그램 소개" runat="server" CssClass="base_menu" OnClick="link_intro_Click"/>
                </li>
                <li>            
                    <asp:LinkButton ID="link_statistics" Text="프로그램 통계" runat="server" CssClass="base_menu" OnClick="link_statistics_Click" />                    
                </li>
                <li>
                    <asp:LinkButton ID="link_bigdata" Text="빅데이터" runat="server" CssClass="base_menu" OnClick="link_bigdata_Click" />
                </li>                
            </ul>
        </div>
        
        <div id="main_content" runat="server" style="display:block; vertical-align:top">

        </div>
        
    </form>
</body>
</html>
