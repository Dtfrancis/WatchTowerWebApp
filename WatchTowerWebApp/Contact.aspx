<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WatchTowerWebApp.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     <div class="container-fluid" id="bkg">
       <div class="row">
           <div class="jumbotron" >
               <h1>Contact Us</h1>               
           </div>
       </div>
       <div class="row">
           <asp:Image ID="Image1" runat="server" ImageUrl="~/Assets/logo.PNG" />
           <h4 style="justify-content:center; width: 512px;">
               <p>You can reach us at:</p>
           </h4>
           <address>
               <strong>Support:</strong>   <a href="mailto:DanielFrancis.email@gmail.com">WatchTower.org</a><br />
               <strong>Whatsapp:</strong> <a href="https://wa.me/<8765226063>">WTWhatsapp</a>
           </address>
       </div>
   </div>

    
</asp:Content>
