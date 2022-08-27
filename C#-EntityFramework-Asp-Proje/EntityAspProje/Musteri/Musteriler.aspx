<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Musteriler.aspx.cs" Inherits="EntityAspProje.Musteri.Musteriler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#Modal1">
        Yeni Müşteri Tanımla
    </button>

    <div class="modal" id="Modal1">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h2 class="modal-title">Müşteri Ekleme Paneli</h2>
                </div>

                <form runat="server">
                    <div class="modal-body">
                        <label>
                            Ad
                        </label>
                        <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
                        <br />
                        <label>
                            Soyad
                        </label>
                        <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox>
                        <br />
                        <asp:Button ID="Button1" runat="server" Text="Kaydet" CssClass="btn btn-info" OnClick="Button1_Click"/>
                        <asp:Button ID="Button2" runat="server" Text="Vazgeç" CssClass="btn btn-danger" data-dismiss="modal" />
                    </div>
                </form>

            </div>
        </div>
    </div>


    <table class="table table-bordered" style="margin-top:20px;">

        <tr>
            <th>ID</th>
            <th>AD</th>
            <th>SOAYAD</th>
            <th>SİL</th>
            <th>GÜNCELLE</th>
        </tr>

        <asp:Repeater ID="Repeater1" runat="server">

            <ItemTemplate>

                <tr>
                    <td> <%# Eval("MUSTERIID") %> </td>
                    <td> <%# Eval("MUSTERIAD") %> </td>
                    <td> <%# Eval("MUSTERISOYAD") %> </td>

                    <td><asp:HyperLink NavigateUrl='<%# "~/Musteri/MusteriSil.aspx?MUSTERIID=" + Eval("MUSTERIID") %>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">SİL</asp:HyperLink></td>
                   
                    <td><asp:HyperLink NavigateUrl='<%# "~/Musteri/MusteriGuncelle.aspx?MUSTERIID=" + Eval("MUSTERIID") %>' ID="HyperLink2" runat="server" CssClass="btn btn-warning">GÜNCELLE</asp:HyperLink></td>
                        
                </tr>

            </ItemTemplate>

        </asp:Repeater>

    </table>

    <a href="MusteriAktiflestir.aspx" class="btn btn-success">Müşteri Aktifleştirme</a>

</asp:Content>
