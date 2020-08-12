<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="_160245.RegisterAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="StyleSheet1.css" rel="stylesheet" />
    
    <br /><br />  <br /><br />
    <div class="container">
        <div class="row">
            <div class="col-lg-3">
                </div>
            <div class="col-lg-6">
                    <h1  class="text-white">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Registration</h1>
                <br /> <br /> <asp:TextBox ID="t1" runat="server" class="form-control" Type="text" placeholder="name" Width="100%"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Please Enter name" ControlToValidate="t1"></asp:RequiredFieldValidator>
                
                    <br /> <br /> <asp:TextBox ID="TextBox1" runat="server" class="form-control" type="password"  placeholder="passward" Width="100%"></asp:TextBox>
               <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Passward Needs to be entered" ControlToValidate="TextBox1"  ></asp:RequiredFieldValidator>
                
              <br /> <br /> <asp:TextBox ID="TextBox2" runat="server" class="form-control" type="password" placeholder="confirm passward" Width="100%"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Passward Not Matched" ControlToValidate="TextBox2" ControlToCompare="TextBox1"></asp:CompareValidator>
                
               
                <br /> <br /> <asp:TextBox ID="TextBox3" runat="server" class="form-control" Type="email" placeholder="abc@gmail.com" Width="100%"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Email Required" ControlToValidate="TextBox3"></asp:RequiredFieldValidator>
                 <br /> <br/> <asp:Button ID="Button1" runat="server" class="btn btn-success" Text="Submit" OnClick="Button1_Click" Width="100%" />
            </div>
            <div class="col-lg-3">
                </div>
           
        </div>
    </div>





</asp:Content>
