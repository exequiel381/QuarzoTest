<%@ Page Title="Categories Management" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AbmCategories.aspx.cs" Inherits="QuarzoTecnologiaTest.AbmCategories" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div class="container_page">
            <h2>Update Category</h2>
            <asp:DropDownList ID="DropCategories" runat="server" AutoPostBack="True" OnSelectedIndexChanged="CategoryIndexChangue"></asp:DropDownList>

            <asp:Label ID="LabelId" runat="server" Text="Label">Id</asp:Label>
            <asp:TextBox Enabled="false" ID="txtId" runat="server"></asp:TextBox>

            <asp:Label ID="LabelName" runat="server" Text="Label">Name</asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>

            <div class="Container_CheckBox">
                <asp:Label ID="Label2" runat="server" Text="Label">Active</asp:Label>
                <asp:CheckBox ID="cbxActive" runat="server" />
            </div>

            <asp:Button class="btn btn-primary" ID="UpdateButton" runat="server" Text="Update" OnClick="UpdateCategory" />
            <asp:Button class="btn btn-success" ID="Button1" runat="server" Text="Create new" OnClick="goToNewCategory" />
            <asp:Button class="btn btn-danger" ID="Button2" runat="server" Text="Delete" OnClick="DeleteCategory" />
            <asp:Label ID="Message" runat="server" Text=""></asp:Label>
        </div>
</asp:Content>

