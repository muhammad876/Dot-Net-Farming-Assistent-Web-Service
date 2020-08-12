<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SupplierHome.aspx.cs" Inherits="_160245.SupplierHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="StyleSheet1.css" rel="stylesheet" />
    <br /><br /><br /><br />
     
    <div class="container">
        <div class="row">
    <div class="col-lg-4">
      
            <asp:ImageButton ID="ImageButton1" runat="server" OnClick="ImageButton1_Click"   ImageUrl="adver.jpg" Height="185px" Width="259px"  />
           <br />    <asp:Button ID="Button3" runat="server" Text=" Add Advertisment " Width="259px" CssClass="btn btn-success" OnClick="Advertisment" />
            </div>
             <div class="col-lg-4">
             <asp:ImageButton ID="ImageButton2" runat="server" OnClick="ImageButton2_Click" ImageUrl="adver.jpg" Height="185px" Width="259px" />
             <br />   <asp:Button ID="Button1" runat="server" Text=" View Crop Model "  Width="259px" CssClass="btn btn-success" OnClick="Models" />
            </div>
             <div class="col-lg-4">
             <asp:ImageButton ID="ImageButton3" runat="server" OnClick="ImageButton3_Click" ImageUrl="logout.jpg" Height="185px" Width="259px" />
             <br />           
                    <asp:Button ID="Button2" runat="server" Text=" Logout "  Width="259px" CssClass="btn btn-success" OnClick="Logout"/>
           
             </div>
         
            </div>
            </div>

</asp:Content>
