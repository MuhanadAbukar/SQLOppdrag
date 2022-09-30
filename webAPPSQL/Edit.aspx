<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="webAPPSQL.Edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Edit</title>
  <meta charset="UTF-8"/>
</head>
<body>
    <h1>Edit row</h1>
    <form runat="server"><asp:Label ID="FornavnLabel" runat="server" Text="Fornavn"></asp:Label>
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
        <asp:Button ID="Button1" runat="server" Text="Update row" OnClick="Button1_Click" />
    </form>
    
</body>
</html>
