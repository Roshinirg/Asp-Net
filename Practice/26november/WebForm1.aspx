<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_26november.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
  

    <table style="width: 100%; margin-top: 30px">
    <tr>
        <td style="width: 375px">Product Name</td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 375px">&nbsp;</td>
        <td>
            <asp:Button ID="Button1" runat="server" Text="Save" OnClick="Button1_Click" />
        </td>
    </tr>
    <tr>
        <td style="height: 20px; width: 375px">Delete Product</td>
        <td style="height: 20px">
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 375px">&nbsp;</td>
        <td>
            <asp:Button ID="Button2" runat="server" Text="Delete" OnClick="Button2_Click" />
        </td>
    </tr>
    <tr>
        <td style="width: 375px; height: 20px">Update Product</td>
        <td style="height: 20px">
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 375px">&nbsp;</td>
        <td>
            <asp:Button ID="Button3" runat="server" Text="Update" OnClick="Button3_Click" />
        </td>
    </tr>
</table>
  

</asp:Content>
