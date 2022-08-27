<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="UrunAktifYapma.aspx.cs" Inherits="EntityAspProje.Urun.UrunAktifYapma" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form runat="server" class="form-group">

        <asp:TextBox ID="TxtUrunID" runat="server" placeholder="Ürün ID girin..." CssClass="form-control"></asp:TextBox>
        <br />


        <div>
            <asp:Button ID="Button1" runat="server" Text="Ürünü Yeniden Aktifleştir" CssClass="btn btn-warning" OnClick="Button1_Click" />
        </div>

    </form>

</asp:Content>
