<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="PersonelGuncelle.aspx.cs" Inherits="EntityAspProje.PersonelGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

     <form runat="server" class="form-group">


          <asp:TextBox ID="TxtPersonelID" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
        <br />


        <asp:TextBox ID="TxtPersonelAdSoyad" runat="server" placeholder="Personel ad ve soyad..." CssClass="form-control"></asp:TextBox>
        <br />

         <div>
            <asp:Button ID="BtnGuncelle" runat="server" Text="Personel Güncelle" CssClass="btn btn-warning" OnClick="BtnGuncelle_Click"/>
        </div>


         </form>

</asp:Content>
