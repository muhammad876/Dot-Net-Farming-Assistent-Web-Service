<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CurrentlyComplained.aspx.cs" Inherits="_160245.CurrentlyComplained" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="StyleSheet1.css" rel="stylesheet" />
     <div class="container">
          <div class="row">
                <div class="col-md-2"></div>

               <div class="col-md-6"  ><br /><br /><br /><br /><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                   <asp:GridView ID="gv" runat="server" AutoGenerateColumns="false" ssClass="mydatagrid" PagerStyle-CssClass="pager"
                        HeaderStyle-CssClass="header" RowStyle-CssClass="rows" AllowPaging="True" >

                       <Columns>
                        <asp:TemplateField HeaderText="Id" >
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%#Eval("Id") %>' CssClass="spacing" ></asp:Label>
                                </ItemTemplate>
                          
                        </asp:TemplateField>

                            <asp:TemplateField HeaderText="Name" >
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%#Eval("farmerName") %>' CssClass="spacing"></asp:Label>
                                </ItemTemplate>
                          
                        </asp:TemplateField>

                             <asp:TemplateField HeaderText="Description" >
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%#Eval("description") %>' CssClass="spacing"></asp:Label>
                                </ItemTemplate>
                          
                        </asp:TemplateField>
                          
                           <asp:TemplateField HeaderText="Status">
                            <ItemTemplate>
                             
                                <asp:LinkButton ID="LinkButton1" runat="server" Text='<%#Eval("status") %>' OnClick="MyButtonClick"></asp:LinkButton>
                            </ItemTemplate>
                          
                        </asp:TemplateField>
                        
                       </Columns>
                 </asp:GridView>
                  </div>

               <div class="col-md-2"></div>
          </div>
    </div>
  

</asp:Content>
