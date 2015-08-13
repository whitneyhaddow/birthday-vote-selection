<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Results.aspx.cs" Inherits="Results" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Voting Results</title>
    <link href="StyleSheet.css" rel="stylesheet" />
</head>
<body>

    <form id="form1" runat="server">
    <div id="container">
        <div class="left">
            <span class="title">Voting Results</span><br />
            How often each day was voted for:<br /><br />
            <asp:Label ID="lblDay1" class="resultLabel" runat="server"></asp:Label><br /><br /> 
            <asp:Label ID="lblDay2" class="resultLabel" runat="server"></asp:Label><br /><br /> 
            <asp:Label ID="lblDay3" class="resultLabel" runat="server"></asp:Label><br /><br /> 
            <asp:Button class="button" ID="btnReturn" runat="server" PostBackUrl="~/default.aspx" Text="Go Back" />
        </div>
        <div class="right"><img alt="Party Ribbons" id="ribbons" src="ribbons.jpg" /></div>
        <div class="clear"> </div>
        <div class="footer">Image courtesy of www.clipartbest.co/monkey-party-clipart/</div>
        <div class="clear"></div>
    </div>
    </form>

</body>
</html>
