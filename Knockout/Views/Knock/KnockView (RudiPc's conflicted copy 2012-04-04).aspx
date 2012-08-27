<%@ Page Title="" Language="C#" MasterPageFile="~/Views/ViewMasterPage.Master" Inherits="System.Web.Mvc.ViewPage<Knockout.Models.KnockModel>" %>


<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    KnockView
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript" src="<%= Url.Content("~/Scripts/jquery-1.5.1.min.js") %>"></script>
    <script type="text/javascript" src="<%= Url.Content("~/Scripts/knockout.js") %>"></script>

<script type="text/javascript">

    $(document).ready(function () {
        var product = {
            itemNumber: "T314CE",
            model: "Taylor 314ce",
            salePrice: 11099.95
        };
         //without Knockout
//        $("#gitarItemNumber").text(product.itemNumber);
//        $("#gitarModel").val(product.model);
        //        $("#gitarSalePrice").val(product.salePrice);
        ko.applyBindings(product);
    });

</script>

<h2>KnockView</h2>

<%--<h2>Without Knockout</h2>
<span>Item number:</span><span id="gitarItemNumber"></span>
    <br/>
    <span>Guitar model:</span><input id="gitarModel"/>
    <span>Sales price:</span><input id="gitarSalePrice"/>--%>
    
 <h2>With Knockout</h2>
 <span>Item number:</span><span data-bind="text: itemNumber"></span>
 <br/>
 <span>Guitar model:</span><input data-bind="value: model"/>
 <span>Sales price:</span><input data-bind="value: salePrice"/>


</asp:Content>
