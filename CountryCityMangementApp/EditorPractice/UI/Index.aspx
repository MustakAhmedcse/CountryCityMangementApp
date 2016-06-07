<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="EditorPractice.DAL.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="countryAddButton" runat="server" Text="Country Add" OnClick="countryAddButton_Click" />
        <asp:Button ID="cityAddButton" runat="server" Text="City Add" OnClick="cityAddButton_Click" />

        <asp:Button ID="cityViewButton" runat="server" OnClick="cityViewButton_Click" Text="City View" />

    </div>
    </form>
</body>
</html>
