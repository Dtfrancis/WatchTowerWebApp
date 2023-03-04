<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="WatchTowerWebApp.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">    
    <div class="row">
        <div class="jumbotron bg-primary" >
            <h1> Cart</h1>
        </div>
    </div>
    <div class="row" align="right">        
            <asp:Button ID="toCheckout" runat="server" Text="Checkout Cart"  class="btn btn-primary btn-lg" OnClick="toCheckout_Click" />&nbsp;
            <asp:Button ID="deleteAll" runat="server" Text="Empty Cart" class="btn btn-danger btn-lg" OnClick="deleteAll_Click" />&nbsp
            <asp:Button ID="toProductPage" runat="server" Text="Keep Shopping" class="btn btn-success btn-lg" OnClick="toProductPage_Click" />&nbsp

    </div> 
    <br /><br /><br />
    <div class="row" align="center">        
    <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"></asp:GridView>    
        <h4>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label> 
            <br />
            <asp:Label ID="Label13" runat="server" Text=""></asp:Label>
            <br />
        </h4>
    </div> 

    </div>
</asp:Content>
