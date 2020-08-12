<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Advertisment.aspx.cs" Inherits="_160245.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="StyleSheet1.css" rel="stylesheet" />
    <div class="container">
          <div class="row">
                <div class="col-md-2">

               </div>
              <div class="col-md-6"  ><br /><br /><br /><br /><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                   <asp:GridView ID="gv" runat="server" AutoGenerateColumns="false" ssClass="mydatagrid" PagerStyle-CssClass="pager"
                        HeaderStyle-CssClass="header" RowStyle-CssClass="rows" AllowPaging="True" >
                             <Columns>

                                   <asp:TemplateField HeaderText="Image">
                            <ItemTemplate> 
                                <asp:Image ID="img1" runat="server" Width="50px" Height="50px" CssClass="spacing" 
                            ImageUrl='<%#Eval("image") %>'></asp:Image>
                                
                            </ItemTemplate>
                          
                        </asp:TemplateField>


                        <asp:TemplateField HeaderText="Name" >
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%#Eval("name") %>' CssClass="spacing" ></asp:Label>
                                </ItemTemplate>
                          
                        </asp:TemplateField>

                            <asp:TemplateField HeaderText="Quantity" >
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%#Eval("quantity") %>' CssClass="spacing"></asp:Label>
                                </ItemTemplate>
                          
                        </asp:TemplateField>
                    </Columns>
                 </asp:GridView>
              
               </div>
               <div class="col-md-2">

               </div>
          </div>
    </div>
  
</asp:Content>
