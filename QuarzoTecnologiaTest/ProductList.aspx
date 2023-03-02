<%@ Page Title="Product List" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="QuarzoTecnologiaTest.ProductList" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="Container">
        <div class="Container__DropCategories">
            <h2>Categories</h2>
            <asp:DropDownList ID="DropCategories" runat="server" OnSelectedIndexChanged="DropCategories_SelectedIndexChanged" AutoPostBack="True" >
           </asp:DropDownList>
        </div>
        <h2>Products in selected category</h2>
        <table id="tblCategories" class="table table-striped table.bordered">
            <thead>
                <tr>
                    <th>ID</th>
                    <th>Nombre</th>
                    <th>Precio</th>
                    <th>Categoria</th>
                </tr>
            </thead>
            <tbody>
                <% foreach (var product in _products){ %>
                       <tr>
                           <td><%: product.IdProduct%></td>
                           <td><%: product.NombProduct%></td>
                           <td><%: product.PrecioProd %></td>
                           <td><%: product.Category %></td>
                       </tr>
                <% } %>
               
            </tbody>
        </table>
    </div>


</asp:Content>
