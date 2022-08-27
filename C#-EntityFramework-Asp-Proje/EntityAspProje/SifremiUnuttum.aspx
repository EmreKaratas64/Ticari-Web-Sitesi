<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="SifremiUnuttum.aspx.cs" Inherits="EntityAspProje.SifremiUnuttum" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form runat="server" class="form-group">


          <asp:TextBox ID="TxtAdminID" runat="server" CssClass="form-control" placeholder="Kullancı ID..."></asp:TextBox>
        <br />

          <asp:TextBox ID="TxtKullaniciAd" runat="server" CssClass="form-control" placeholder="Kullancı Adınızı giriniz..."></asp:TextBox>
        <br />

        <asp:TextBox ID="TxtSifre1" runat="server" placeholder="Yeni şifre..." CssClass="form-control" TextMode="Password"></asp:TextBox>
        <br />

        <asp:TextBox ID="TxtSifre2" runat="server" placeholder="Yeni şifre tekrar..." CssClass="form-control" TextMode="Password"></asp:TextBox>
        <br />

         <div>
            <asp:Button ID="BtnGuncelle" runat="server" Text="Şifreyi Değiştir" CssClass="btn btn-warning" OnClick="BtnGuncelle_Click"/>
        </div>


         </form>

</asp:Content>
