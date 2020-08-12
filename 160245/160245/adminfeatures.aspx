<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="adminfeatures.aspx.cs" Inherits="_160245.adminfeatures" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="StyleSheet1.css" rel="stylesheet" />

     <br /><br /><br /><br />
     
    <div class="container">
        <div class="row">

    <div class="col-md-3">
       <asp:ImageButton ID="ImageButton1" runat="server" OnClick="ImageButton1_Click"  ImageUrl="adver.jpg" Height="185px" Width="259px"  />
       <br /> <asp:Button ID="Button1"  runat="server" Text=" See Advertisment" OnClick="Advertisment"  Width="259px" CssClass="btn btn-success"  />
    </div>

             <div class="col-md-3">
              <asp:ImageButton ID="ImageButton3" runat="server" OnClick="ImageButton3_Click" ImageUrl="complaint.jpg" Height="185px" Width="259px" />
              <br /> 
             </div>

          <div class="col-md-3">
          <asp:ImageButton ID="ImageButton4" runat="server" OnClick="ImageButton4_Click" ImageUrl="adver.jpg" Height="185px" Width="259px" /> <br />
          <asp:Button ID="Button4"  runat="server" Text=" View Crop Model" OnClick="CropModel"  Width="259px" CssClass="btn btn-success"  />
          </div>


          <div class="col-md-3">
            <asp:ImageButton ID="ImageButton2" runat="server" OnClick="ImageButton2_Click" ImageUrl="logout.jpg" Height="185px" Width="259px" />
             <br />  <asp:Button ID="Button2"  runat="server" Text=" Logout" OnClick="Logout"  Width="259px" CssClass="btn btn-success"  />
          </div>

            </div>
            </div>


</asp:Content>
