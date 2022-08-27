<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="MusteriGuncelle.aspx.cs" Inherits="EntityAspProje.Musteri.MusteriGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

     <form runat="server" class="form-group">


          <asp:TextBox ID="TxtMusteriID" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
        <br />


        <asp:TextBox ID="TxtMusteriAd" runat="server" placeholder="Müşteri adı..." CssClass="form-control"></asp:TextBox>
        <br />

          <asp:TextBox ID="TxtMusteriSoyad" runat="server" placeholder="Müşteri soyad..." CssClass="form-control"></asp:TextBox>
        <br />

         <div>
            <asp:Button ID="BtnGuncelle" runat="server" Text="Müşteri Güncelle" CssClass="btn btn-warning" OnClick="BtnGuncelle_Click"/>
        </div>


         </form>

</asp:Content>
