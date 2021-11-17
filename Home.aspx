<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Tugas3_SBD34.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-size:20px; margin-bottom:20px; font-weight:bold">Pendataan Anggota CERC 2021</div>
        <div style="float:right; padding-right:20px"><a href="FullData.aspx">Data Lengkap Anggota CERC 2021</a>
            <a href="RecycleBin.aspx"><p>Recycle Bin</p></a></div>
        
        <div style="padding: 10px;"> Data Mahasiswa
            <asp:GridView ID="GridViewJoin" runat="server">
             </asp:GridView>
             <table style="padding-top: 10px">
                 <tr>
                     <td>NIM :</td>
                     <td>
                     <asp:TextBox ID="txtnim" runat="server"></asp:TextBox>
                     </td>
                 </tr>
                 <tr>
                     <td>Nama :</td>
                     <td>
                     <asp:TextBox ID="txtnama_mhs" runat="server"></asp:TextBox>
                     </td>
                 </tr>
                 <tr>
                    <td></td>
                    <td>
                     <asp:Button ID="btnAdd" runat="server" Text="ADD"
                    OnClick="btnAdd_Click" />
                     <asp:Button ID="btnDelete" runat="server"
                     Text="DELETE" OnClick="btnDelete_Click"/>
                     <asp:Button ID="btnUpdate" runat="server"
                     Text="UPDATE" OnClick="btnUpdate_Click"/>
                     <asp:Button ID="btnClear" runat="server"
                     Text="CLEAR" OnClick="btnClear_Click" />
                     </td>
                 </tr>
             </table>
         </div>

        <div style="padding: 10px; "> Data Club CERC
            <asp:GridView ID="GridView1" runat="server">
             </asp:GridView>
         </div>

        <div style="padding: 10px; border-bottom: 1px solid black "> Data Laboratorium 
            <asp:GridView ID="GridView2" runat="server">
             </asp:GridView>
         </div>

        <div style="padding: 10px; font-weight:bold">Input Data Anggota CERC 2021
            <table> 
                 <tr>
                     <td>NIM :</td>
                     <td>
                     <asp:TextBox ID="txtnimmhs" runat="server"></asp:TextBox>
                     </td>
                 </tr>
                 <tr>
                     <td>ID Club :</td>
                     <td>
                     <asp:TextBox ID="txtid_clubmhs" runat="server"></asp:TextBox>
                     </td>
                 </tr>
                 <tr>
                    <td></td>
                    <td>
                     <asp:Button ID="Button1" runat="server" Text="ADD"
                     OnClick="btnAdd_Click3" />
                     <asp:Button ID="Button3" runat="server"
                     Text="CLEAR" OnClick="btnClear_Click3" />
                     </td>
                 </tr>
             </table>
             </div>

        <div style="padding: 10px;"> Pendataan
            <asp:GridView ID="GridView3" runat="server">
             </asp:GridView>
            <table style="padding-top: 10px">
                 <tr>
                     <td>ID Pendataan :</td>
                     <td>
                     <asp:TextBox ID="txtiddata" runat="server"></asp:TextBox>
                     </td>
                 </tr>
                 <tr>
                    <td></td>
                    <td>
                     <asp:Button ID="Button2" runat="server" Text="DELETE"
                    OnClick="btnDelete_Click4" />
                     </td>
                 </tr>
             </table>
        </div>

    </form>

</body>
</html>
