<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="UrunGuncelle.aspx.cs" Inherits="EntityAspProje.Urun.UrunGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

     <form runat="server" class="form-group">

        <asp:TextBox ID="TxtUrunAd" runat="server" placeholder="Ürün adını girin..." CssClass="form-control"></asp:TextBox>
        <br />

         <asp:TextBox ID="TxtMarka" runat="server" placeholder="Markayı girin..." CssClass="form-control"></asp:TextBox>
        <br />

         <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>
        <br />

         <asp:TextBox ID="TxtFiyat" runat="server" placeholder="Fiyatı girin..." CssClass="form-control"></asp:TextBox>
        <br />

         <asp:TextBox ID="TxtStok" runat="server" placeholder="Stok sayısını girin..." CssClass="form-control"></asp:TextBox>
        <br />


         
        <div>
            <asp:Button ID="Button1" runat="server" Text="Kategori Güncelle" CssClass="btn btn-warning" OnClick="Button1_Click"/>
        </div>

    </form>

</asp:Content>
