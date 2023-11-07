<%@ Page Title="" Language="C#" MasterPageFile="~/UserSite.Master" AutoEventWireup="true" CodeBehind="userHome.aspx.cs" Inherits="WatchTowerWebApp.userHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid" style="background-image:url('~/Assets/background.jpg')">
        <div class="row">        
            <div class="jumbotron bg-success">
               <h1> Welcome To Watch Tower </h1> 
                <p> Enjoy your time with us !</p>
            </div>             
           
            <div class="card-columns">
            <div class="col-sm-4 mb-4 mb-sm-0">           
                <div class="card" align="center">                
                    <asp:Image ID="Image1" runat="server" imageUrl="~/Assets/apple2.jfif" ImageAlign="Middle" />
                    <div class="card-body">
                        <h4 class="card-title text-center">Apple watch series</h4>
                        <p class="card-text text-center">The Iphone series slick design and top class interface speaks for its self.</p>
                        <asp:Button ID="ApplePage" runat="server" Text="Explore" class="btn btn-primary" OnClick="toApplePage_Click" />
                    </div>
                </div>            
            </div>
            <div class="col-sm-3 mb-3 ">
                <div class="card" align="center">
                    <asp:Image ID="Image2" runat="server" imageUrl="~/Assets/Amaze4.jfif" ImageAlign="Middle" Height="183px" Width="188px"/>
                     <h4 class="card-title text-center">Amazfit BIP watch series</h4>
                        <div class="card-body">                           
                            <p class="card-text text-center">The Amazfit are some of the best smart watches we offer .</p>
                            <asp:Button ID="ToAmazePage" runat="server" Text="Explore" class="btn btn-primary" OnClick="ToAmazePage_Click" />
                        </div>
                 </div>
            </div>          
            <div class="col-sm-4 mb-4 ">
                <div class="card" align="center">                
                    <asp:Image ID="Image3" runat="server" imageUrl="~/Assets/Samsung2.jfif" Height="168px"  Width="292px"/>
                       <h4 class=" card-title text-center">Samsung Galaxy watches</h4>
                        <div class="card-body" align="center">                            
                            <p class="card-text text-center">The Samsung watches are some of the best and comfortable around.</p>
                            <asp:Button ID="ToSamsungPage" runat="server" Text="Explore" class="btn btn-primary" OnClick="ToSamsungPage_Click" />
                        </div>
                </div>
            </div> 
        </div>
            
        </div>
         <div class="row" style="justify-content:center">
             <div class="col-sm-6">
                 <div class="jumbotron">
                     <h2 class="text-center"><strong> What we do</strong></h2>
                     <div class="card">                         
                         <asp:Image ID="Image4" runat="server" ImageUrl="~/Assets/logo4.png" Height="7.6em" Width="14.2em" />
                         <div class="card-body">
                         <p> Is a online store that supplies you, our valued customers with the latest and greatest in smart watches.
</p>
                     </div>
                     </div>
                     

                 </div>
                 <div class="col">
                 <div class="jumbotron" >
                      <br />
                      <h3 class="text-center"><strong>We provide news and updates</strong></h3>
                     <br />
                     <div align="center">
                         <asp:Image ID="Image9" runat="server" ImageUrl="~/Assets/home2.jfif" />
                     </div>
                 </div>
              </div>
             </div>              
             <div class="col-sm-6" align="center">
                 <div class="">
                   <br />
                     <h2><strong>What we provide</strong></h2>
                        <br />
                        <asp:Image ID="Image7" runat="server" ImageUrl="~/Assets/Amaze2.jfif"/>
                        <h4>Smart Watches</h4>
                        <br />
                        <asp:Image ID="Image5" runat="server" ImageUrl="~/Assets/fit6.png" />
                        <h4>Fitness Trackers</h4>
                        <br />
                        <asp:Image ID="Image6" runat="server" ImageUrl="~/Assets/sc.jfif" />
                        <h4>Watch Face Protectors</h4>

                        <asp:Image ID="Image8" runat="server" ImageUrl="~/Assets/band6.jpg" Height="261px" Width="254px" />
                        <h4>Watch Bands</h4>
                 </div>
             </div>

         </div>
        <div class="row">        
            <div class="body" align="center">
                <div class="jumbotron" style="background-color: #E0F0FF;">
                <h1>Check Out Our Products !</h1>
                <asp:Button ID="product_btn" runat="server" Text="Go" class="btn btn-primary" OnClick="Button1_Click1" />
               </div>
            </div>
       </div>
        <div class="row"> 
            <div class="col-sm-6">
                <div class="body" align="center">
                <div class="jumbotron">                              
                <h1>About Us!</h1>
                <asp:Button ID="abt_btn" runat="server" Text="Go" class="btn btn-primary" OnClick="Button2_Click" />
               </div>
            </div>
            </div>
            <div class="col-sm-6">
              <div class="body" align="center">
                <div class="jumbotron">                                 
                    <h1 class ="text-center">Contact Us!</h1>
                    <asp:Button ID="contact_btn" runat="server" Text="Go" class="btn btn-primary" OnClick="Button3_Click" />
               </div>
             </div>
            </div>
            
       </div>
                          
    </div>
</asp:Content>
