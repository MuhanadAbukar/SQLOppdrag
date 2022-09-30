<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="create.aspx.cs" Inherits="webAPPSQL.create" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <link rel="stylesheet" href="style.css"/>
    <title></title>
</head>
<body>
    <ul>
  <li><a  href="Default.aspx">View people</a></li>
  <li><a class="active" href="create.aspx">Create a person</a></li>
</ul>
    <form id="form1" runat="server">
        <div>
        <asp:Label ID="FornavnLabel" runat="server" Text="Fornavn"></asp:Label>
        <br />
        <asp:TextBox ID="Fornavn" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="EtternavnLabel" runat="server" Text="Etternavn"></asp:Label>
        <br />
        <asp:TextBox ID="Etternavn" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="AdresseLabel" runat="server" Text="Adresse"></asp:Label><br />
        <asp:TextBox ID="Adresse" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="PostnummerLabel" runat="server" Text="Postnummer"></asp:Label><br />
        <asp:TextBox ID="Postnummer" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="PoststedLabel" runat="server" Text="Poststed"></asp:Label><br />
        <asp:TextBox ID="Poststed" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="AlderLabel" runat="server" Text="Alder"></asp:Label><br />
        <asp:TextBox ID="Alder" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="InntektLabel" runat="server" Text="Inntekt"></asp:Label><br />
        <asp:TextBox ID="Inntekt" runat="server"></asp:TextBox>
        <br />
        <asp:GridView ID="GridView1" runat="server" Visible="False"></asp:GridView>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Create person" OnClick="Create"  />
        </div>
    </form>
</body>
</html>
