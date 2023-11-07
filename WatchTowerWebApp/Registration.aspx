<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="WatchTowerWebApp.Registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">    
    <div class="row">
        <div class="jumbotron bg-primary" >
            <h1> Register here</h1>
        </div>
    </div> 
        <div align ="center">
            <asp:Label ID="UserCreated" runat="server" ForeColor="Lime"></asp:Label>
        </div>
    <div class="row">
                    <table class="table table-striped">
                    <tr>
                        <td>
                            <h4 class ="">
                                <asp:Label ID="userFnameLabel" runat="server" Text="First name :"></asp:Label>
                            </h4>
                            
                        </td>
                        <td>
                            <div class ="">
                                <asp:TextBox ID="userFname" runat="server" Height="22px" Width="135px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="userFname" ErrorMessage="*Required"></asp:RequiredFieldValidator>
                            </div>
                            
                        </td>
                     <tr>
                        <td>
                            <h4 class ="">
                                <asp:Label ID="Label1" runat="server" Text="Last name :"></asp:Label>
                            </h4>
                            
                        </td>
                        <td>
                            <div class ="">
                                <asp:TextBox ID="userLastname" runat="server" Width="135px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="userLastname" ErrorMessage="*Required"></asp:RequiredFieldValidator>
                            </div>
                            
                        </td>
                    </tr>
                     <tr>
                        <td>
                            <h4 class ="">
                                <asp:Label ID="Label2" runat="server" Text="Username :"></asp:Label>
                            </h4>
                            
                        </td>
                        <td>
                            <div class ="">
                                <asp:TextBox ID="username" runat="server" Width="135px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="username" ErrorMessage="*Required"></asp:RequiredFieldValidator>
                            </div>
                            
                        </td>
                    </tr>
                     <tr>
                        <td>
                            <h4 class ="">
                                <asp:Label ID="Label3" runat="server" Text="Password :"></asp:Label>
                            </h4>
                            
                        </td>
                        <td>
                            <div class ="">
                                <asp:TextBox ID="password" runat="server" Width="135px" TextMode="Password"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="password" ErrorMessage="*Required"></asp:RequiredFieldValidator>
                            </div>
                            
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <h4 class ="">
                                <asp:Label ID="Label4" runat="server" Text="Confirm Password :"></asp:Label>
                            </h4>
                            
                        </td>
                        <td>
                            <div class ="">
                                <asp:TextBox ID="confirmPassword" runat="server" Width="135px" TextMode="Password"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="confirmPassword" ErrorMessage="*Required"></asp:RequiredFieldValidator>
                                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="password" ControlToValidate="confirmPassword" ErrorMessage="Passwords don't match"></asp:CompareValidator>
                            </div>
                            
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <h4 class ="">
                                <asp:Label ID="Label5" runat="server" Text="Age :"></asp:Label>
                            </h4>
                            
                        </td>
                        <td>
                            <div class ="">
                                <asp:TextBox ID="userage" runat="server" Width="135px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="userage" ErrorMessage="*Required"></asp:RequiredFieldValidator>
                            </div>
                            
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <h4 class ="">
                                <asp:Label ID="Label6" runat="server" Text="Email :"></asp:Label>
                            </h4>
                            
                        </td>
                        <td>
                            <div class ="">
                                <asp:TextBox ID="userEmail" runat="server" Width="135px"></asp:TextBox>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="userEmail" ErrorMessage="*Not an Email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                            </div>
                            
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <h4 class ="">
                                <asp:Label ID="Label7" runat="server" Text="Confirm Email :"></asp:Label>
                            </h4>
                            
                        </td>
                        <td>
                            <div class ="">
                                <asp:TextBox ID="confirmEmail" runat="server" Width="135px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="confirmEmail" ErrorMessage="*Required"></asp:RequiredFieldValidator>
                                <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToCompare="userEmail" ControlToValidate="confirmEmail" ErrorMessage="*Email don't match"></asp:CompareValidator>
                            </div>
                            
                        </td>
                    </tr>
                </table>
        <br />
        <asp:Button ID="register" runat="server" Text="Register" OnClick="register_Click" Width="84px" />
        <br />
        <div align="center">
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:WatchTowerConnectionString %>" InsertCommand="insertUser" InsertCommandType="StoredProcedure" SelectCommand="selectUsers" SelectCommandType="StoredProcedure">
                <InsertParameters>
                    <asp:Parameter Name="userId" Type="String" />
                    <asp:Parameter Name="username" Type="String" />
                    <asp:Parameter Name="email" Type="String" />
                    <asp:Parameter Name="userPassword" Type="String" />
                    <asp:Parameter Name="firstname" Type="String" />
                    <asp:Parameter Name="lastname" Type="String" />
                    <asp:Parameter Name="age" Type="Int32" />
                    <asp:Parameter Name="type" Type="String" />
                </InsertParameters>
            </asp:SqlDataSource>
            
            <asp:Label ID="Label8" runat="server" ForeColor="Red"></asp:Label>
        </div>
        
    </div>
</div>
</asp:Content>
