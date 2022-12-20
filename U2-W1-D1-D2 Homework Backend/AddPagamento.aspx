<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AddPagamento.aspx.cs" Inherits="U2_W1_D1_D2_Homework_Backend.AddPagamento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container my-5">
        <input type="text" id="TotalePagamento" runat="server" placeholder="Pagamento" class="me-5 my-1"/>
        <asp:CheckBox ID="StipendioAcconto" runat="server" OnCheckedChanged="CheckStipendio" AutoPostBack="true"/>
        <asp:Label ID="StipAcc" runat="server" Text=""></asp:Label>
        <br />
        <input type="date" id="PeriodoPagamento" runat="server" class="my-1"/>
        <br />
        <asp:Button ID="AggiungiPagamento" runat="server" Text="Aggiungi" CssClass="btn btn-primary my-1 bt" OnClick="AggiungiStipendio"/>
    </div>
    <div class="container my-5">
        <asp:Label ID="Error" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
