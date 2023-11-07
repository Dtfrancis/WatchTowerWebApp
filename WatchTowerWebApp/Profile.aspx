<%@ Page Title="" Language="C#" MasterPageFile="~/UserSite.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="WatchTowerWebApp.UserCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <div class ="jumbotron">
            <h1>
                User Profile
            </h1>
            <h4>
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            </h4>           
            
            <div align="right">
                <h4>
                    <asp:Button ID="Button4" runat="server" Text="Logout" OnClick="Button4_Click" />
                </h4>
            </div>
        </div>
        <div class="row">
            <h4>
                Cart Info
            </h4>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:WatchTowerConnectionString %>" SelectCommand="veiwCart" SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:SessionParameter DefaultValue="0" Name="userId" SessionField="currentUser" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
        </div>
        
   
    </div>
</asp:Content>
