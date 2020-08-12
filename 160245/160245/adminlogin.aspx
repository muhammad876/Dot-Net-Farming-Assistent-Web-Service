<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="adminlogin.aspx.cs" Inherits="_160245.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="StyleSheet1.css" rel="stylesheet" />
    <br /><br /><br /><br />
    <div class="container">
        <div class="row">
    <div class="col-md-3">
        <asp:HyperLink ID="HyperLink1" runat="server">ID:</asp:HyperLink><br /><br />
  <div class="input-group">
    <span class="input-group-addon"><i class="glyphicon glyphicon-user"></i></span>
      <asp:TextBox ID="T1" type="text" class="form-control" runat="server" placeholder="admin" ></asp:TextBox>  
  </div>
        <asp:Label ID="name" runat="server" Text=""></asp:Label>
     </div>
   <div class="col-md-3">
  <asp:HyperLink ID="HyperLink2" runat="server" CssClass="text-primary">Password:</asp:HyperLink><br /><br />
  <div class="input-group">
      
    <span class="input-group-addon"><i class="glyphicon glyphicon-lock"></i>
      </span>
   <asp:TextBox ID="T3" type="passward" class="form-control" runat="server" placeholder="admin123" ></asp:TextBox>
   
  </div>
         <asp:Label ID="password1" runat="server" Text=""></asp:Label>
     </div>

  <div class="col-md-1">
  <div class="btn-group">
      <br /><br />
     <asp:Button ID="Button1" runat="server" class="btn btn-primary" Text="Submit" OnClick="Button1_Click"  />
      <br />
     
      <br />
   </div>
   
   </div>

  <div class="col-md-1">
  <div class="btn-group">
      <br /><br />
       <asp:Button ID="Button2" runat="server" class="btn btn-danger" Text="Register" OnClick="Button2_Click"  />
 
      <br /> <br />
   </div>
   
   </div>
             </div>
            </div>
</asp:Content>

