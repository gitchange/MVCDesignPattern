<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DJView.aspx.cs" Inherits="MVCDesignPattern.View.DJView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblBPMOutput" runat="server" Text="BPM :"></asp:Label>
        <br />
        <asp:TextBox ID="txtBar" runat="server"></asp:TextBox>
    
    </div>
    </form>
</body>
</html>
