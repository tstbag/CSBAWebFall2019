<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Site.Master" AutoEventWireup="true" CodeBehind="Trading.aspx.cs" Inherits="CSBANet.Trade.Trading" %>

<%@ Register Src="~/Common/WebControls/ucTrade.ascx" TagPrefix="uc1" TagName="ucTrade" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>


<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <%--    <uc1:ucTrade runat="server" id="ucTrade" />--%>


    <telerik:RadSkinManager ID="RadSkinManager1" runat="server" ShowChooser="true" />
    <div class="demo-container size-wide">

        <telerik:RadDockLayout runat="server" ID="RadDockLayout1" EnableLayoutPersistence="true"
            LayoutPersistenceRepositoryType="Cookies" LayoutRepositoryID="DockLayout">

            <telerik:RadDockZone runat="server" ID="RadDockZone1" Width="300" MinHeight="200"
                Style="float: left; margin-right: 20px;">
                <telerik:RadDock RenderMode="Lightweight" runat="server" ID="RadDock1" Title="RadDock 1" Width="300" Height="100"
                    CssClass="higherZIndex">
                </telerik:RadDock>
            </telerik:RadDockZone>

            <telerik:RadDockZone Width="300" MinHeight="400" runat="server" ID="RadDockZone2"
                Style="float: left;">

                <telerik:RadDock RenderMode="Lightweight" runat="server" ID="RadDock2" Title="RadDock 2" Width="300" Height="100"
                    CssClass="higherZIndex">
                    <ContentTemplate>
                        <asp:label ID="lblxx" runat="server" Text="Test133"></asp:label>
                    </ContentTemplate>
                </telerik:RadDock>
            </telerik:RadDockZone>

            <telerik:RadDockZone Width="300" MinHeight="400" runat="server" ID="RadDockZone3"
                Style="float: right;">
                <telerik:RadDock RenderMode="Lightweight" runat="server" ID="RadDock3" Title="RadDock 3" Width="300" Height="100"
                    CssClass="higherZIndex">
                    <ContentTemplate>
                        <asp:label ID="Label1" runat="server" Text="Test133"></asp:label>
                    </ContentTemplate>
                </telerik:RadDock>
            </telerik:RadDockZone>


            <br class="qsf-clear-float" />
        </telerik:RadDockLayout>
    </div>




</asp:Content>
