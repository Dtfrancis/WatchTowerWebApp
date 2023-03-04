<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WatchTowerWebApp.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid" id="bkg">
       <div class="row">
           <div class="jumbotron" >
               <h1>About Us</h1>
           </div>
       </div>
       <div class="row">
           <asp:Image ID="Image1" runat="server" ImageUrl="~/Assets/logo.PNG" />
           <h4 style="justify-content:center; width: 512px;">
               When dedication meets professionalism a great business is formed. We at Watch Tower strive to achieve this by serving you with quality products and great service
           </h4>
       </div>
   </div>
</asp:Content>
