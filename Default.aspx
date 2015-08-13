<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Birthday Votes</title>
    <link href="StyleSheet.css" rel="stylesheet" />
</head>
<body>

    <form id="form1" runat="server">
    <div id="container">

        <div class="left">
            <span class="title">Party Date Selection</span><br />
            Jolanta is having a birthday!<br /><br />
            Please select your preferred date for the party below:<br /><br />
            <asp:Calendar ID="Calendar1" runat="server"
                OnDayRender="DayRender" 
                BorderColor="#6600CC" 
                BorderStyle="Double" 
                OnSelectionChanged="Calendar1_SelectionChanged">
                <TitleStyle BackColor="#E0C2FF" />
            </asp:Calendar><br />
            <asp:Label ID="lblSelection" runat="server"></asp:Label> <br />
            <asp:Button class="button" ID="Button1" runat="server"  Text="Submit Vote" OnClick="btnSubmit_Click" /> <br />
            <asp:CustomValidator ID="dateValidator" runat="server" ErrorMessage="Please select a date" OnServerValidate="dateValidator_ServerValidate"></asp:CustomValidator>
        </div>

        <div class="right"><img alt="Party Ribbons" id="ribbons" src="ribbons.jpg" /></div>

        <div class="clear"></div>
        <div class="footer">Image courtesy of www.clipartbest.co/monkey-party-clipart/</div>
        <div class="clear"></div>
    </div>
    </form>

</body>
</html>
