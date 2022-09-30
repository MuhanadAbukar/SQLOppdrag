<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="webAPPSQL.Default"  %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <link rel="stylesheet" href="style.css"/>
    <title></title>
</head>
<body>
    <ul>
  <li><a class="active" href="Default.aspx">View people</a></li>
  <li><a href="create.aspx">Create a person</a></li>
</ul>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="FornavnLabel" runat="server" Text="Søk med fornavn"></asp:Label><br /><asp:TextBox ID="FornavnTextbox" runat="server" AutoPostBack="true" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            <br />
             <asp:Label ID="IDLabel" runat="server" Text="Søk med ID"></asp:Label> <br />
                <asp:TextBox ID="IDTextbox" runat="server" AutoPostBack="true" OnTextChanged="IDSearch"></asp:TextBox>
            <br />
            <br /><asp:GridView ID="DataGridView" runat="server" AutoGenerateColumns="False" AllowPaging="True" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" OnPageIndexChanging="DataGridView_PageIndexChanging1"  PageSize="5">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Personnummer" />
                    <asp:BoundField DataField="Fornavn" HeaderText="Fornavn" />
                    <asp:BoundField DataField="Etternavn" HeaderText="Etternavn" />
                    <asp:BoundField DataField="Adresse" HeaderText="Adresse" />
                    <asp:BoundField DataField="Postnummer" HeaderText="Postnummer" />
                    <asp:BoundField DataField="Poststed" HeaderText="Poststed" />
                    <asp:BoundField DataField="Alder" HeaderText="Alder" />
                    <asp:BoundField DataField="Inntekt" HeaderText="Inntekt" />
                    <asp:TemplateField HeaderText="    ">
                        <ItemTemplate>
                            <asp:Button ID="Edit" runat="server" Text="Edit" CommandName='<%# Eval("Id") %>' OnClick="edit"/>
                            <asp:Button ID="Delete" runat="server" Text="Delete" CommandName='<%# Eval("Id") %>' OnClick="delete"/>
                        </ItemTemplate>
                    </asp:TemplateField>    
                </Columns>
                 
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                <RowStyle BackColor="White" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#808080" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
                 
            </asp:GridView>
        </div>
    </form>
</body>
</html>
