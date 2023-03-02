<%@ Page Title="Categories Management" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NewCategory.aspx.cs" Inherits="QuarzoTecnologiaTest.NewCategory" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container_page">
        <h2>Create category</h2>
        <asp:Label ID="LabelId" runat="server" Text="Label">Id</asp:Label>
        <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
        
        <asp:Label ID="LabelName" runat="server" Text="Label">Name</asp:Label>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        
        <div class="Container_CheckBox">
            <asp:Label ID="Label2" runat="server" Text="Label">Active</asp:Label>
            <asp:CheckBox ID="cbxActive" runat="server" />
        </div>
        
        <asp:Button class="btn btn-success" ID="Button1" runat="server" Text="Create new" OnClick="CreateCategory" />
        <asp:Label ID="Message" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
