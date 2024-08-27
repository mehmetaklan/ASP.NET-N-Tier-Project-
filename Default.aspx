    <%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">

    <form id="form1" runat="server">
        <div class="form-group">

            <div class="row">
                <div class="col-sm-2 text-center">
                    <asp:Label for="TxtAd" runat="server" Text="Öğrenci Adı: "></asp:Label>
                </div>
                <div class="col-sm-8">
                    <asp:TextBox ID="TxtAd" runat="server" CssClass="form-control col-xs-4"></asp:TextBox>
                </div>

            </div>
            <br />
            <div class="row">
                <div class="col-sm-2 text-center">
                    <asp:Label for="TxtSoyad" runat="server" Text="Öğrenci Soyadı: "></asp:Label>
                </div>
                <div class="col-sm-8">
                    <asp:TextBox ID="TxtSoyad" runat="server" CssClass="form-control col-xs-4"></asp:TextBox>
                </div>

            </div>
            <br />
            <div class="row">
                <div class="col-sm-2 text-center">
                    <asp:Label for="TxtNumara" runat="server" Text="Öğrenci Numara: "></asp:Label>
                </div>
                <div class="col-sm-8">
                    <asp:TextBox ID="TxtNumara" runat="server" CssClass="form-control col-xs-4"></asp:TextBox>
                </div>

            </div>
            <br />
            <div class="row">
                <div class="col-sm-2 text-center">
                    <asp:Label for="TxtSıfre" runat="server" Text="Öğrenci Şifre: "></asp:Label>
                </div>
                <div class="col-sm-8">
                    <asp:TextBox ID="TxtSıfre" runat="server" CssClass="form-control col-xs-4"></asp:TextBox>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="col-sm-2 text-center">
                    <asp:Label for="TxtFoto" runat="server" Text="Öğrenci Foto: "></asp:Label>
                </div>
                <div class="col-sm-8">
                    <asp:TextBox ID="TxtFoto" runat="server" CssClass="form-control col-xs-4"></asp:TextBox>
                </div>
            </div>
            <br />
        </div>
        <asp:Button ID="Button1" runat="server" Text="Kaydet" OnClick="Button1_Click" CssClass="btn btn-success btn-block" />
    </form>

</asp:Content>

