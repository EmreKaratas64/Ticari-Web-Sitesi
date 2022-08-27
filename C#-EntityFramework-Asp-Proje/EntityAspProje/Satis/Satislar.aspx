<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Satislar.aspx.cs" Inherits="EntityAspProje.Satis.Satislar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

     <table class="table table-bordered">
        <tr>
            <th>SATIŞ ID</th>
            <th>URUN</th>
            <th>PERSONEL</th>
            <th>MUSTERİ</th>
            <th>FİYAT</th>
            <th>SİL</th>
            <th>GÜNCELLE</th>

        </tr>

        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                   
                    <td><%#Eval("SATISID")%></td>
                    <td><%#Eval("URUNAD")%></td>
                    <td><%#Eval("PERSONELADSOYAD")%></td>
                    <td><%#Eval("MUSTERI")%></td>
                    <td><%#Eval("FIYAT")%></td>

                    <td><asp:HyperLink NavigateUrl='<%# "~/Satis/SatisSil.aspx?SATISID=" + Eval("SATISID") %>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">SİL</asp:HyperLink></td>
                   
                    <td><asp:HyperLink NavigateUrl='<%# "~/Satis/SatisGuncelle.aspx?SATISID=" + Eval("SATISID") %>' ID="HyperLink2" runat="server" CssClass="btn btn-warning">GÜNCELLE</asp:HyperLink></td>     
                

                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>

    <a href="YeniSatis.aspx" class="btn btn-info">Yeni Satış</a>

</asp:Content>
