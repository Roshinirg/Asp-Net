<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GridView.aspx.cs" Inherits="WebApplication3.GridView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColoums="false" AutoGenerateColumns="False" Height="237px" style="margin-top: 12px" Width="471px">
        <Columns>
            <asp:TemplateField HeaderText="Id"> 
                <EditItemTemplate> 
                    <asp:Label ID="lblId" runat="server" Text='<%# Eval("Id") %>'></asp:Label> 
                </EditItemTemplate> 
                <ItemTemplate> 
                    <asp:Label ID="lblId" runat="server" Text='<%# Eval("Id") %>'></asp:Label> 
                </ItemTemplate> 
            </asp:TemplateField> 
            <asp:TemplateField HeaderText="Name"> 
                <EditItemTemplate> 
                    <asp:TextBox ID="txtName" Text='<%# Eval("Name") %>' runat="server"></asp:TextBox> 
                </EditItemTemplate> 
                <ItemTemplate> 
                    <asp:Label ID="lblName" runat="server" Text='<%# Eval("Name") %>'></asp:Label> 
                </ItemTemplate> 
            </asp:TemplateField> 
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" /> 
        </Columns>
    </asp:GridView>
</asp:Content>
