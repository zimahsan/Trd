<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="Trd._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   

   <div class="wrapper">
  <div class="container">
    <h1>Welcome</h1>
     <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
       <asp:TextBox ID="TextBox2" runat="server" ></asp:TextBox>
       <asp:TextBox ID="TextBox3" runat="server" ></asp:TextBox>
       <asp:TextBox ID="TextBox4" runat="server" ></asp:TextBox>
     <button id="submit" runat="server">Submit</button>
   
  </div>
  
<asp:DataGrid id="DataGridView1"  name="DataGridView" runat="server">

</asp:DataGrid>
</div>
</asp:Content>
