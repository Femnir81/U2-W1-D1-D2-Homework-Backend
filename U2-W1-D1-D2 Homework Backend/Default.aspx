<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="U2_W1_D1_D2_Homework_Backend.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container my-5">
        <asp:GridView ID="GrigliaDipendente" runat="server" AutoGenerateColumns="false" ItemType="U2_W1_D1_D2_Homework_Backend.Dipendenti" CssClass="table table-striped table-hover">
            <Columns>
                <asp:TemplateField HeaderText="Dipendente">
                    <ItemTemplate>
                        <asp:Label ID="NomeDipendente" runat="server" Text=""><%# Item.Cognome %>&nbsp<%# Item.Nome %></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Coniugato">
                    <ItemTemplate>
                        <asp:CheckBox ID="Coniugato" runat="server" Checked="<%# Item.Coniugato %>" Enabled="false"/>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Figli">
                    <ItemTemplate>
                        <asp:Label ID="NumeroFigli" runat="server" Text="<%# Item.NumeroFigli %>"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Codice Fiscale">
                    <ItemTemplate>
                        <asp:Label ID="CodiceFiscale" runat="server" Text="<%# Item.CodiceFiscale %>"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Indirizzo">
                    <ItemTemplate>
                        <asp:Label ID="Indirizzo" runat="server" Text="<%# Item.Indirizzo %>"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Mansione">
                    <ItemTemplate>
                        <asp:Label ID="Mansione" runat="server" Text="<%# Item.Mansione %>"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField>
                    <ItemTemplate>
                        <a href="/ShowPagamenti.aspx?iddipendente=<%# Item.IDDipendente %>" class="btn btn-primary">Mostra Pagamenti</a>
                        <a href="/AddPagamento.aspx?iddipendente=<%# Item.IDDipendente %>" class="btn btn-primary">Aggiungi Pagamenti</a>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
