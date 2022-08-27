<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Personel.aspx.cs" Inherits="EntityAspProje.Personel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">


     <table class="table table-bordered">
        <tr>
            <th>PERSONEL ID</th>
            <th>PERSONEL AD SOYAD</th>
            <th>SİL</th>
            <th>GÜNCELLE</th>
        </tr>

        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("PERSONELID")%></td>
                    <td><%#Eval("PERSONELADSOYAD")%></td>

                    <td><asp:HyperLink NavigateUrl='<%# "~/PersonelSil.aspx?PERSONELID=" + Eval("PERSONELID") %>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink></td>
                    <td><asp:HyperLink NavigateUrl='<%# "~/PersonelGuncelle.aspx?PERSONELID=" + Eval("PERSONELID") %>' ID="HyperLink2" runat="server" CssClass="btn btn-warning">Güncelle</asp:HyperLink></td>
                        
                </tr>
            </ItemTemplate>
        </asp:Repeater>



    </table>

    <a href="PersonelEkle.aspx" class="btn btn-info">Yeni Personel</a>

    <a href="PersonelAktiflestirme.aspx" class="btn btn-success">Personel Aktifleştir</a>

</asp:Content>
