<%@ Page Title="" Language="C#" MasterPageFile="~/Concessionaria.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Concessionaria.WebForm1" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Calcola Preventivo</h2>
    <label for="Auto">Seleziona Auto:</label>
    <asp:DropDownList ID="dropdownAuto" runat="server" AutoPostBack="True" OnSelectedIndexChanged="dropdownAuto_SelectedIndexChanged">
        <asp:ListItem Text="--Seleziona Auto--"></asp:ListItem>
    </asp:DropDownList>
    <img runat="server" id="carImg" />
    <span runat="server" id="prezzoAuto"></span>
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />  
</asp:Content>
