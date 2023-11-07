<%@ Page Title="" Language="C#" MasterPageFile="~/UserSite.Master" AutoEventWireup="true" CodeBehind="userCart.aspx.cs" Inherits="WatchTowerWebApp.cartUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">    
    <div class="row">
        <div class="jumbotron bg-primary" >
            <h1> Cart</h1>
        </div>
    </div>   
    <br /><br /><br />

   <div class="row">
       <table class="table table-striped">
              <thead>
                <tr>
                  <th scope="col">Product</th>
                  <th scope="col">Quantity</th>
                  <th scope="col">Price</th>                  
                </tr>
              </thead>
              <tbody>
                <tr>                 
                  <td>
                      <div class="align-self-center">
                          <asp:Image ID="Image1" runat="server" ImageUrl="~/Assets/Amaze fit.jfif" Height="124px" Width="127px" />
                      
                      <div>
                          <asp:Label ID="Label1" runat="server" Text="Amaze1"></asp:Label>
                          <br />
                          <asp:Button ID="Button1" runat="server" Text="Remove" Width="69px" OnClick="Button1_Click" />
                      </div>
                    </div>
                      
                  </td>
                  <td>
                      <asp:Label ID="amaze" runat="server" Text="20"></asp:Label>
                  </td>
                  <td>                    
                      <asp:Label ID="Label2" runat="server" Text="70"></asp:Label>    
                  </td>
                </tr>
                <tr>                  
                  <td>
                      <div>
                          <asp:Image ID="Image3" runat="server" ImageUrl="~/Assets/samsung.jfif" Height="124px" Width="127px"/>
                      </div>
                      <div>
                          <asp:Label ID="Label3" runat="server" Text="Apple Watch Ultra"></asp:Label>
                          <br />
                          <asp:Button ID="Button2" runat="server" Text="Remove" Width="69px" OnClick="Button2_Click" />
                      </div>                      
                  </td>
                  <td>
                       <asp:Label ID="samsung" runat="server" Text="0"></asp:Label>
                      
                  </td>
                  <td>                      
                        <asp:Label ID="Label4" runat="server" Text="350"></asp:Label>
                  </td>
                </tr>
                <tr>
                  <td>
                        <div>
                          <asp:Image ID="Image2" runat="server"  ImageUrl="~/Assets/apple.jfif" Height="102px" Width="167px"/>
                      </div>
                      <div>
                          <asp:Label ID="Label5" runat="server" Text="Samsung Galaxy Watch 5"></asp:Label> <br />
                          <asp:Button ID="Button3" runat="server" Text="Remove" Width="69px" OnClick="Button3_Click" />
                      </div>                      
                  </td>
                  <td>
                      <asp:Label ID="apple" runat="server" Text="0"></asp:Label> 
                  </td>
                  <td>
                       <asp:Label ID="Label6" runat="server" Text="800"></asp:Label>                        
                  </td>
                </tr>
                  
              </tbody>
            </table>

            <div align="right">
                <table class="table table-striped">
                    <tr>
                        <td>
                            <h4 class ="jumbotron">
                                Subtotal
                            </h4>
                            
                        </td>
                        <td>
                            <div class ="jumbotron">
                            <asp:Label ID="Label7" runat="server" Text="0"></asp:Label>
                            </div>
                            
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <h4 class ="jumbotron">
                                Grandtotal
                            </h4>
                        </td>
                        <td>
                            <div class ="jumbotron">
                            <asp:Label ID="Label8" runat="server" Text="0"></asp:Label>
                            </div>
                        </td>
                        
                    </tr>
                </table>
                 <div class="row">        
                    <asp:Button ID="toCheckout" runat="server" Text="Checkout Cart"  class="btn btn-primary btn-lg" OnClick="toCheckout_Click" Width="156px" />&nbsp;
                    <asp:Button ID="deleteAll" runat="server" Text="Empty Cart" class="btn btn-danger btn-lg" OnClick="deleteAll_Click" Width="156px" />&nbsp
                    <asp:Button ID="toProductPage" runat="server" Text="Keep Shopping" class="btn btn-success btn-lg" OnClick="toProductPage_Click" Width="156px" />&nbsp

                 </div> 
            </div>


    </div>
    </div>
</asp:Content>
