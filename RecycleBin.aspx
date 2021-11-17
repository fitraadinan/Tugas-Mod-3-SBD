<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RecycleBin.aspx.cs" Inherits="Tugas3_SBD34.RecycleBin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin: 20px"> <h3>Restore Data Anggota CERC 2021</h3>
            <asp:GridView ID="GridViewJoin" runat="server" OnSelectedIndexChanged="GridViewJoin_SelectedIndexChanged">
            </asp:GridView>
            <table style="padding-top: 10px">
                 <tr>
                     <td>NIM :</td>
                     <td><asp:TextBox ID="txtnim" runat="server"></asp:TextBox></td>
                 </tr>
                 <tr>
                    <td></td>
                    <td>
                     <asp:Button ID="btnrestore" runat="server" Text="RESTORE"
                        OnClick="btnrestore_Click" />
                         <asp:Button ID="btnDelete" runat="server"
                        Text="DELETE" OnClick="btnDelete_Click"/>
                         <asp:Button ID="Button3" runat="server"
                        Text="CLEAR" OnClick="btnClear_Click" />
                     </td>
                 </tr>
             </table>
         </div>
        <div style="margin: 30px 0 0 20px"> 
            <a href="Home.aspx">Home Page</a>
            <a href="FullData.aspx"><p>Data Lengkap Anggota CERC 2021</p></a>
        </div>

    </form>
</body>
</html>
