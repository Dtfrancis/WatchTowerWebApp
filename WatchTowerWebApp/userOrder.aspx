<%@ Page Title="" Language="C#" MasterPageFile="~/UserSite.Master" AutoEventWireup="true" CodeBehind="userOrder.aspx.cs" Inherits="WatchTowerWebApp.Order" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div class="container-fluid">    
        <div class="row">
            <div class="jumbotron bg-primary" >
                <h1> Orders</h1>
            </div>
            <p>Your order has been made!</p>
            <br />
            <br />
            <div class ="row">
                <div class="jumbotron" align="center">
                    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                </div>
            </div>
        </div>   
        <br />
    </div>
    <div class="row" align="center">
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Assets/logo4.png" Height="366px" Width="359px" />
        <h4>
            Thanks for making your Order!
        </h4>
        <p>Your time is valued here</p>
        <br />
        <p> A invoice will be sent to your email billing information</p>
        <br />
    </div>
    
   
</asp:Content>
