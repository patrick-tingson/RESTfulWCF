<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HowToConsume.aspx.cs" Inherits="RESTfulWCF_And_HowToConsume.HowToConsume" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Profile ID:
        <asp:TextBox ID="txtProfileID" runat="server" Width="205px"></asp:TextBox>
        <br />
        <asp:Button ID="btnCheckProfile" runat="server" Text="Check Profile ID" OnClick="btnCheckProfile_Click"/>
        <br />
        <br />
        <br />
        Profile ID:
        <asp:TextBox ID="txtProfileID0" runat="server" Width="205px"></asp:TextBox>
        <br />
        Profile Name:
        <asp:TextBox ID="txtProfileName" runat="server" Width="205px"></asp:TextBox>
        <br />
        <asp:Button ID="btnAddProfile" runat="server" Text="Add Profile" OnClick="btnAddProfile_Click" />
        <br />
        <br />
        <br />
        <br />
        Response:
        <br />
        <asp:TextBox ID="txtResponse" runat="server" Height="226px" Width="359px" TextMode="MultiLine"></asp:TextBox>
    
    </div>
    </form>
</body>
</html>
