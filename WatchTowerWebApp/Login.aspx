<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WatchTowerWebApp.Login2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div align="Center">
            <div class="jumbotron" style="background-color:aliceblue">
                <div align="Center">
                    
                    <asp:Image ID="Image1" runat="server" ImageUrl="~/Assets/logo.PNG" />
                </div>
                <table>
                    <tr>
                        <td>
                             <asp:Label ID="Label2" runat="server" Text="Email :"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Not an email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                     <tr>
                        <td>
                            <asp:Label ID="Label3" runat="server" Text="Password :"></asp:Label>
                        </td>
                         <td>
                              <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                              <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="Required"></asp:RequiredFieldValidator>
                         </td>
                    </tr> 
                    <tr>
                        <td>
                            <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text="" ForeColor="Red"></asp:Label>
                        </td>
                    </tr>
                </table>
                
                <br />
                 
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:WatchTowerConnectionString %>" SelectCommand="veiwCart" SelectCommandType="StoredProcedure" InsertCommand="insertIntoCart" InsertCommandType="StoredProcedure">
                    <InsertParameters>
                        <asp:Parameter Name="userId" Type="String" />
                        <asp:Parameter Name="grandtotal" Type="Int32" />
                        <asp:Parameter Name="amazeQuant" Type="Int32" />
                        <asp:Parameter Name="appleQuant" Type="Int32" />
                        <asp:Parameter Name="samsungQuant" Type="Int32" />
                        <asp:Parameter Name="amazeSub" Type="Int32" />
                        <asp:Parameter Name="appleSub" Type="Int32" />
                        <asp:Parameter Name="samsungSub" Type="Int32" />
                    </InsertParameters>
                    <SelectParameters>
                        <asp:Parameter Name="userId" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
                 
                <br />
                
                <br />
                
            </div>
        </div>
</asp:Content>
