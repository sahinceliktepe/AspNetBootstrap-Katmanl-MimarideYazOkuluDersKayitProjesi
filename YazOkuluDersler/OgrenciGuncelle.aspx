<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="OgrenciGuncelle.aspx.cs" Inherits="YazOkuluDersler.OgrenciGuncelle" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="Form1" runat="server">
        <div class="form-group">
            <div>
                <strong>
                <asp:Label for="txtId" runat="server" Text="Öğrenci Id:"></asp:Label>
                </strong>
                <asp:TextBox ID="txtId" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                <asp:Label for="txtAd" runat="server" Text="Öğrenci Adı:"></asp:Label>
                </strong>
                <asp:TextBox ID="txtAd" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                <asp:Label for="txtSoyad" runat="server" Text="Öğrenci Soyadı:"></asp:Label>
                </strong>
                <asp:TextBox ID="txtSoyad" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                <asp:Label for="txtNumara" runat="server" Text="Öğrenci Numara:"></asp:Label>
                </strong>
                <asp:TextBox ID="txtNumara" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                <asp:Label for="txtSifre" runat="server" Text="Öğrenci Şifre:"></asp:Label>
                </strong>
                <asp:TextBox ID="txtSifre" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                <asp:Label for="txtFoto" runat="server" Text="Öğrenci Fotoğraf:"></asp:Label>
                </strong>
                <asp:TextBox ID="txtFoto" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
        <asp:Button ID="Button1" runat="server" Text="Güncelle" CssClass="btn btn-warning" OnClick="Button1_Click" />
    </form>
</asp:Content>
