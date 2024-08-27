<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="DerslerListesi.aspx.cs" Inherits="DerslerListesi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <table class="table table-responsive table-bordered table-hover">
        <tr>
            <th class="text-center">DersId</th>
            <th class="text-center">Ders Adı</th>
            <th class="text-center">Minimum Kontenjan</th>
            <th class="text-center">Maksimum Kontenjan</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td class="text-center"><%#Eval("ID")%></td>
                        <td class="text-center"><%#Eval("DERSAD")%></td>
                        <td class="text-center"><%#Eval("MIN")%></td>
                        <td class="text-center"><%#Eval("MAX")%></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>

