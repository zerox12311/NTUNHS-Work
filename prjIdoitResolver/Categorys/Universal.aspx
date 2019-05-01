<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Universal.aspx.cs" Inherits="prjIdoitResolver.categorys.etc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>其他</h1>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:LeeLabDB %>" SelectCommand="SELECT * FROM [Question] WHERE ([categoryID] = @categoryID)">
        <SelectParameters>
            <asp:QueryStringParameter DefaultValue="1" Name="categoryID" QueryStringField="category" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
    <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1">
        <LayoutTemplate>
            <div class="row">
                <div runat="server" id="itemPlaceholder" />
            </div>
            
        </LayoutTemplate>
        <ItemTemplate>
            <div class='col-12 col-md-4 mb-4 mb-lg-5' runat="server">
                <a href='#'>
                    <img src='/assets/custom/images/cat-larg5.jpg' alt='' class='w-100'>
                </a>
                <h2 class='font-18 semi-font font-18  mt-3'>
                    <a href='#' class='fables-main-text-color fables-second-hover-color'>213123</a>
                </h2>
                <p class='fables-forth-text-color font-14'>testests</p>
                <a href='' class='btn fables-main-text-color fables-second-hover-color p-0 underline mt-2'>Read More</a>
            </div>
        </ItemTemplate>
    </asp:ListView>
</asp:Content>
