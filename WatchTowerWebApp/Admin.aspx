<%@ Page Title="" Language="C#" MasterPageFile="~/AdminSite.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="WatchTowerWebApp.Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <div class ="jumbotron">
            <div align="center">
                <h1>
                    Administrator
                </h1>
            </div>
            <div align="left">
                <h4>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    
                </h4>
            </div>
            <div align="right">
                <h4>
                    <asp:Button ID="Button4" runat="server" Text="Logout" OnClick="Button4_Click" />
                </h4>
            </div>
        </div>
        <p> Functions below are respective to their buttons. fill in the neccessary information and click the required button</p>
        <div class="row" align="center">
            <h4>
                Orders
            </h4>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            <br />
            <asp:Label ID="Label11" runat="server" ForeColor="Lime"></asp:Label>
        </div>


            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Id :"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                     <td>
                         <asp:Button ID="Button1" runat="server" Text="Add Product" OnClick="Button1_Click" />
                         <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:WatchTowerConnectionString %>" InsertCommand="insertProduct" InsertCommandType="StoredProcedure" SelectCommand="selectProducts" SelectCommandType="StoredProcedure">
                             <InsertParameters>
                                 <asp:Parameter Name="Id" Type="String" />
                                 <asp:Parameter Name="name" Type="String" />
                                 <asp:Parameter Name="category" Type="String" />
                                 <asp:Parameter Name="description" Type="String" />
                                 <asp:Parameter Name="price" Type="Int32" />
                             </InsertParameters>
                         </asp:SqlDataSource>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label7" runat="server" Text="Name :"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label8" runat="server" Text="Category :"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="Button3" runat="server" Text="Update Product" OnClick="Button3_Click" />
                        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:WatchTowerConnectionString %>" SelectCommand="selectProducts" SelectCommandType="StoredProcedure" UpdateCommand="updateProduct" UpdateCommandType="StoredProcedure" InsertCommand="insertProduct" InsertCommandType="StoredProcedure">
                            <InsertParameters>
                                <asp:Parameter Name="Id" Type="String" />
                                <asp:Parameter Name="name" Type="String" />
                                <asp:Parameter Name="category" Type="String" />
                                <asp:Parameter Name="description" Type="String" />
                                <asp:Parameter Name="price" Type="Int32" />
                            </InsertParameters>
                            <UpdateParameters>
                                <asp:Parameter Name="productId" Type="String" />
                                <asp:Parameter Name="productName" Type="String" />
                                <asp:Parameter Name="category" Type="String" />
                                <asp:Parameter Name="description" Type="String" />
                                <asp:Parameter Name="price" Type="String" />
                            </UpdateParameters>
                        </asp:SqlDataSource>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label9" runat="server" Text="Description :"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label10" runat="server" Text="Price :"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="Button2" runat="server" Text="Delete Product" OnClick="Button2_Click" />
                        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:WatchTowerConnectionString %>" DeleteCommand="deleteProduct" DeleteCommandType="StoredProcedure" SelectCommand="selectProducts" SelectCommandType="StoredProcedure">
                            <DeleteParameters>
                                <asp:Parameter Name="productId" Type="String" />
                            </DeleteParameters>
                        </asp:SqlDataSource>
                    </td>
                </tr>

            </table>
        <br />
        <div class="row" align="center">
            <h4>
                Products
            </h4>
            <asp:GridView ID="GridView2" runat="server"></asp:GridView>
        </div>
</div>

            
</asp:Content>
