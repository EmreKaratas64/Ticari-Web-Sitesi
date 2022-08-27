<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="PersonelEkle.aspx.cs" Inherits="EntityAspProje.PersonelEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form runat="server" class="form-group">

        <asp:TextBox ID="TxtAdSoyad" runat="server" placeholder="Personel adı ve soyadı..." CssClass="form-control"></asp:TextBox>
        <br />

        <div>
            <asp:Button ID="Button1" runat="server" Text="Personel Ekle" CssClass="btn btn-primary" OnClick="Button1_Click"/>
        </div>

    </form>

</asp:Content>
