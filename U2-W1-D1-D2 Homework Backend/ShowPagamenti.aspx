<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ShowPagamenti.aspx.cs" Inherits="U2_W1_D1_D2_Homework_Backend.ShowPagamenti" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container my-5">
        <asp:GridView ID="GrigliaPagamenti" runat="server" AutoGenerateColumns="false" ItemType="U2_W1_D1_D2_Homework_Backend.Pagamenti" CssClass="table table-striped table-hover">
            <Columns>
                <asp:TemplateField HeaderText="Dipendente">
                    <ItemTemplate>
                        <asp:Label ID="NomeDipendente" runat="server" Text=""><%# Item.IDDipendente.Cognome %>&nbsp<%# Item.IDDipendente.Nome %></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Mansione">
                    <ItemTemplate>
                        <asp:Label ID="Mansione" runat="server" Text="<%# Item.IDDipendente.Mansione %>"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Stipendio">
                    <ItemTemplate>
                        <asp:CheckBox ID="Stipendio" runat="server" Checked="<%# Item.StipendioAcconto %>" Enabled="false" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Totale">
                    <ItemTemplate>
                        <asp:Label ID="TotalePagamento" runat="server" Text="<%# Item.TotalePagamento %>"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Data">
                    <ItemTemplate>
                        <asp:Label ID="Data" runat="server" Text="<%# Item.PeriodoPagamento %>"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
