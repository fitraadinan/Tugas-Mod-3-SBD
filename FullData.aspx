<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FullData.aspx.cs" Inherits="Tugas3_SBD34.FullData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="padding: 10px"> Data Anggota CERC 2021
            <asp:GridView ID="GridViewJoin" runat="server" OnSelectedIndexChanged="GridViewJoin_SelectedIndexChanged">
             </asp:GridView>
         </div>
        <div style="margin: 30px 0 0 20px"> 
            <a href="Home.aspx">Home Page</a>
            <a href="RecycleBin.aspx"><p>Recycle Bin</p></a>
        </div>
    </form>
</body>
</html>
