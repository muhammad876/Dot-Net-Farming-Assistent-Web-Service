<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Model.aspx.cs" Inherits="_160245.Model" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="StyleSheet1.css" rel="stylesheet" />
    <br /><br /> 
   
     <br /><br />
    <div class="container">
        &nbsp;<div class="row">
            <div class="col-lg-2">   </div>
               <div class="col-lg-4">
                   
                   <asp:Image ID="Image1" runat="server" Width="100%" Height="200px" />
                   <asp:FileUpload ID="FileUpload1" runat="server" />
                   </div>
               <div class="col-lg-4">
                       <asp:TextBox ID="name" class="form-control mt-2" placeholder="Crop Name" runat="server"  Width="100%"   ></asp:TextBox>
                               <br />
                   <asp:TextBox ID="quantity" class="form-control" placeholder="Quantity" runat="server"  Width="100%" ></asp:TextBox>
                      <br />
                   <asp:TextBox ID="price" class="form-control" placeholder="Price in Rupees" runat="server"  Width="100%" ></asp:TextBox>
                  <br />      <asp:Button ID="Button1" runat="server" Text="Upload Image" OnClick="Button1_Click1" Width="100%" CssClass="btn btn-primary"/>
                <br />    <br />    <asp:Button ID="Button2" runat="server" Text="Save Info"  Width="100%" CssClass="btn btn-danger mt-2 " OnClick="Button2_Click"/>
              
               </div>
             <div class="col-lg-2">   </div>
        </div>
    </div>
</asp:Content>
