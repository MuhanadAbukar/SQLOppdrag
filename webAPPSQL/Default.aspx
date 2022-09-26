﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="webAPPSQL.Default"  %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Søk med fornavn"></asp:Label><asp:TextBox ID="TextBox1" runat="server" AutoPostBack="true" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" AllowPaging="True" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" OnPageIndexChanging="GridView1_PageIndexChanging1"  PageSize="5">
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
