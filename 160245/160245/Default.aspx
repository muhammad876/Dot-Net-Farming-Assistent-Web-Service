<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_160245._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   
    <div class="jumbotron">
        <h1 class="text_primary">Farming Assistent Web Service</h1>
      
       
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Main Aim</h2>
            <p>
              The Main Aim is to help Farmers when they need Any help Regarding Irrigation and Harvesting their Crops
            </p>
          
        </div>
        <div class="col-md-4">
            <h2>About</h2>
            <p>This Web Service has been Designed for the farmers to help them in doing their business and to sell their products.</p>
          
        </div>
         <h2>Getting Started</h2>
        <div class="col-md-4">
            <asp:Button ID="Button1" runat="server" class="btn btn-warning"  Text="Lets Begin" OnClick="Button1_Click" Width="192px" />
        </div>
       
    </div>

</asp:Content>
