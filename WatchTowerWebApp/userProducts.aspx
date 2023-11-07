<%@ Page Title="" Language="C#" MasterPageFile="~/UserSite.Master" AutoEventWireup="true" CodeBehind="userProducts.aspx.cs" Inherits="WatchTowerWebApp.userProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    &nbsp;
<div class="container-fluid">
    <div class="row">
        <div class="jumbotron bg-primary" >
            <h1> Products</h1>            
                <p> We have a wide range of :</p>
                <div align="center">
                    <asp:HyperLink ID="HyperLink1" runat="server">Smart Watches    </asp:HyperLink>  &nbsp;
                    <asp:HyperLink ID="HyperLink2" runat="server">Fitness bands   </asp:HyperLink> &nbsp;
                    <asp:HyperLink ID="HyperLink3" runat="server">Watch Face Protectors   </asp:HyperLink>&nbsp;
                    <asp:HyperLink ID="HyperLink4" runat="server">Watch Bands</asp:HyperLink>
                </div>                           
    </div>
     <div align="right">
        <asp:Button ID="Button1" runat="server" Text="Veiw Cart"  class="btn btn-primary btn-lg" OnClick="Button1_Click" />&nbsp;
    </div>  
    <div class="row">
       <div class="col">
        <div class="jumbotron text-center">
                   <h4 class="card-title">Most Popular Smart Watches</h4>
                                
                </div>
            </div>
    </div>
 <table class="table table-striped">
              <thead>
                <tr>
                  <th scope="col"></th>
                  <th scope="col" align="center"><asp:Image ID="Image2" runat="server" ImageUrl="~/Assets/Amaze fit.jfif" /></th>
                  <th scope="col"><asp:Image ID="Image5" runat="server" ImageUrl="~/Assets/apple.jfif" /></th>
                  <th scope="col" style="width: 295px"><asp:Image ID="Image6" runat="server" ImageUrl="~/Assets/samsung.jfif" /></th>
                </tr>
              </thead>
              <tbody>
                <tr>
                  <th scope="row"></th>
                  <td>
                      Category : <asp:Label ID="cat1_lb" runat="server" Text="Loading"></asp:Label>
                  </td>
                  <td>
                      Category :  <asp:Label ID="cat2_lb" runat="server" Text="Loading"></asp:Label>
                  </td>
                  <td style="width: 295px">
                      Category :  <asp:Label ID="cat3_lb" runat="server" Text="Loading"></asp:Label>   
                  </td>
                </tr>
                 <tr>
                  <th scope="row"></th>
                  <td>
                      Name : <asp:Label ID="name1_lb" runat="server" Text="Loading"></asp:Label>
                  </td>
                  <td>
                      Name :  <asp:Label ID="name2_lb" runat="server" Text="Loading"></asp:Label>
                  </td>
                  <td style="width: 295px">
                      Name :  <asp:Label ID="name3_lb" runat="server" Text="Loading"></asp:Label>   
                  </td>
                </tr>
                <tr>
                  <th scope="row"></th>
                  <td>
                      Info : <asp:Label ID="info1_lb" runat="server" Text="Loading"></asp:Label>
                  </td>
                  <td>
                      Info :  <asp:Label ID="info2_lb" runat="server" Text="Loading"></asp:Label>
                  </td>
                  <td style="width: 295px">
                      Info :  <asp:Label ID="info3_lb" runat="server" Text="Loading"></asp:Label>   
                  </td>
                </tr>
                <tr>
                  <th scope="row"></th>
                  <td>
                      Price : <asp:Label ID="price1_lb" runat="server" Text="Loading"></asp:Label>
                  </td>
                  <td>
                      Price :  <asp:Label ID="price2_lb" runat="server" Text="Loading"></asp:Label>
                  </td>
                  <td style="width: 295px">
                      Price :  <asp:Label ID="price3_lb" runat="server" Text="Loading"></asp:Label>   
                  </td>
                </tr>
                <tr>
                  <th scope="row"></th>
                  <td>
                      <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" CellSpacing="3" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" RepeatDirection="Horizontal">
                          <asp:ListItem Selected="True">Black </asp:ListItem>
                          <asp:ListItem>Green </asp:ListItem>
                          <asp:ListItem>Red </asp:ListItem>
                      </asp:RadioButtonList>
                  </td>
                  <td>
                      <asp:RadioButtonList ID="RadioButtonList2" runat="server" AutoPostBack="True" CellSpacing="3" RepeatDirection="Horizontal" OnSelectedIndexChanged="RadioButtonList2_SelectedIndexChanged">
                          <asp:ListItem Selected="True">Alpine orange </asp:ListItem>
                          <asp:ListItem>Ocean White </asp:ListItem>
                      </asp:RadioButtonList>
                  </td>
                  <td style="width: 295px">
                      <asp:RadioButtonList ID="RadioButtonList3" runat="server" AutoPostBack="True" CellSpacing="3" RepeatDirection="Horizontal">
                          <asp:ListItem Selected="True">Lavender</asp:ListItem>
                          <asp:ListItem>Black </asp:ListItem>
                          <asp:ListItem>Gold </asp:ListItem>
                      </asp:RadioButtonList>
                  </td>
                </tr>
                 <tr>
                  <th scope="row"></th>
                  <td>
                      <asp:Button ID="Button2" runat="server" Text="+ Cart" align="center" OnClick="Button2_Click"/>
                      <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:WatchTowerConnectionString %>" InsertCommand="amazeIntoCart" InsertCommandType="StoredProcedure" SelectCommand="veiwCart" SelectCommandType="StoredProcedure">
                          <InsertParameters>
                              <asp:Parameter Name="userId" Type="String" />
                              <asp:Parameter Name="grandtotal" Type="Int32" />
                              <asp:Parameter Name="amazeQuant" Type="Int32" />
                              <asp:Parameter Name="amazeSub" Type="Int32" />
                          </InsertParameters>
                          <SelectParameters>
                              <asp:Parameter Name="userId" Type="String" />
                          </SelectParameters>
                      </asp:SqlDataSource>
                  </td>
                  <td>
                      <asp:Button ID="Button3" runat="server" Text="+ Cart"  align="center" OnClick="Button3_Click"/>
                      <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:WatchTowerConnectionString %>" InsertCommand="appleIntoCart" InsertCommandType="StoredProcedure" SelectCommand="veiwCart" SelectCommandType="StoredProcedure">
                          <InsertParameters>
                              <asp:Parameter Name="userId" Type="String" />
                              <asp:Parameter Name="grandtotal" Type="Int32" />
                              <asp:Parameter Name="appleQuant" Type="Int32" />
                              <asp:Parameter Name="appleSub" Type="Int32" />
                          </InsertParameters>
                          <SelectParameters>
                              <asp:Parameter Name="userId" Type="String" />
                          </SelectParameters>
                      </asp:SqlDataSource>
                  </td>
                  <td style="width: 295px"> 
                    <asp:Button ID="Button4" runat="server" Text="+ Cart"  align="center" OnClick="Button4_Click"/> 
                      <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:WatchTowerConnectionString %>" InsertCommand="samsungIntoCart" InsertCommandType="StoredProcedure" SelectCommand="veiwCart" SelectCommandType="StoredProcedure">
                          <InsertParameters>
                              <asp:Parameter Name="userId" Type="String" />
                              <asp:Parameter Name="grandtotal" Type="Int32" />
                              <asp:Parameter Name="samsungQuant" Type="Int32" />
                              <asp:Parameter Name="samsungeSub" Type="Int32" />
                          </InsertParameters>
                          <SelectParameters>
                              <asp:Parameter Name="userId" Type="String" />
                          </SelectParameters>
                      </asp:SqlDataSource>
                  </td>
                </tr>
                  
              </tbody>
            </table>
       
       
    </div>

    </div>
</asp:Content>
