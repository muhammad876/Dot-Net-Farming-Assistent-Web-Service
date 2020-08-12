<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="complainform.aspx.cs" Inherits="_160245.complainform" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="text-primary;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Complain Form</h1>
      <br /><br />  <br /><br />
    <div class="container">
        <div class="row">
            <div class="col-lg-3">
               <asp:HyperLink id="hyper" runat="server" >Farmer Name:</asp:HyperLink>
               
                <br /> <br /> <asp:TextBox ID="name" runat="server" class="form-control" Type="text" placeholder="Crop Id:"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Please Enter name" ControlToValidate="name"></asp:RequiredFieldValidator>
              <br /> <br />  <asp:HyperLink id="HyperLink2" runat="server" >Complain:</asp:HyperLink>
               
                <br /> <br /> <asp:TextBox ID="complain" runat="server" class="form-control" Type="text" rows="5" placeholder="Crop Name:" OnTextChanged="t3_TextChanged">

                              </asp:TextBox>
                
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please Enter name" ControlToValidate="complain"></asp:RequiredFieldValidator>
              
                <br/> <asp:Button ID="Button1" runat="server" class="btn btn-success" Text="Submit" OnClick="Button1_Click" />
            </div>
        </div>
    </div>
</asp:Content>
