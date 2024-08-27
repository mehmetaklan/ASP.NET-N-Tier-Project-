<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OgrenciListesi.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <table class="table table-responsive table-bordered table-hover">
        <tr>
            <th class="text-center">Id</th>
            <th class="text-center">Ad</th>
            <th class="text-center">Soyad</th>
            <th class="text-center">Numara</th>
            <th class="text-center">Fotoğraf</th>
            <th class="text-center">Bakiye</th>
            <th class="text-center">İşlemler</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <itemtemplate>
                    <tr>
                        <td class="text-center"><%#Eval("ID")%></td>
                        <td class="text-center"><%#Eval("AD")%></td>
                        <td class="text-center"><%#Eval("SOYAD")%></td>
                        <td class="text-center"><%#Eval("NUMARA")%></td>
                        <td class="text-center"><%#Eval("FOTOGRAF")%></td>
                        <td class="text-center"><%#Eval("BAKIYE")%></td>

                        <td>
                            <asp:HyperLink ID="HyperLink1" NavigateUrl='<%#"~/OgrenciGuncelle.aspx?OGRID=" + Eval("ID") %>' CssClass="btn btn-warning text-center" runat="server">Güncelle</asp:HyperLink>
                            <asp:HyperLink ID="HyperLink2" NavigateUrl='<%#"~/OgrenciSil.aspx?OGRID=" + Eval("ID") %>' cssClass="btn btn-danger text-center" runat="server">Sil</asp:HyperLink>
                        </td>

                    </tr>

                </itemtemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>

