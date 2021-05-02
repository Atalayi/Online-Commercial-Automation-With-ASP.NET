﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MainMasterPage.Master" AutoEventWireup="true" CodeBehind="KategoriEkle.aspx.cs" Inherits="Project.Web.Kategori.KategoriEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <head>
        <link href="../Content/bootstrap.min.css" rel="stylesheet" />
        <title></title>
    </head>
</asp:Content>

<asp:Content ID="Content5" ContentPlaceHolderID="kategoriEkle" runat="server">
    <br />
    <h2>Yeni Kategori Sayfası</h2>
    <br />
    <form id="form1" runat="server" class="form-group" method="post">
        <div>

            <asp:label id="lblKategori" runat="server" text="Kategori Adı"></asp:label>
            <asp:textbox id="txtKategoriAd" runat="server" class="form-control"></asp:textbox>
            <br />
            <asp:button id="btnAddCat" runat="server" text="Kaydet" class="btn btn-info " OnClick="btnAddCat_Click"/>

        </div>
    </form>
</asp:Content>