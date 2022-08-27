<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="PersonelAktiflestirme.aspx.cs" Inherits="EntityAspProje.PersonelAktiflestirme" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form runat="server" class="form-group">

        <asp:TextBox ID="TxtPersonelID" runat="server" placeholder="Personel ID girin..." CssClass="form-control"></asp:TextBox>
        <br />


        <div>
            <asp:Button ID="Button1" runat="server" Text="Personeli Yeniden Aktifleştir" CssClass="btn btn-warning" OnClick="Button1_Click"/>
        </div>

    </form>

</asp:Content>
