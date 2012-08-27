<%@ Page Title="" Language="C#" MasterPageFile="~/Views/ViewMasterPage.Master" Inherits="System.Web.Mvc.ViewPage<Knockout.Models.KnockModel>" %>


<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    KnockView
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript" src="<%= Url.Content("~/Scripts/jquery-1.5.1.min.js") %>"></script>
    <script type="text/javascript" src="<%= Url.Content("~/Scripts/knockout.js") %>"></script>

<script type="text/javascript">

$(document).ready(function () {
    var data = {
        product1: {
            id: 1002,
            itemNumber: "T110",
            model: "Taylor 110",
            salePrice: 699.758
        },
        
        product2: {
            id: ko.observable(1001),
            itemNumber: ko.observable("T314CE"),
            model: ko.observable("Taylor 314ce"),
            salePrice: ko.observable(1199.95)
        }
    };
    
    ko.applyBindings(data);
});

</script>

<h2>KnockView</h2>

<div>
    <h2>Object Literal</h2>
    <span>Item number</span><span data-bind="text: product1.itemNumber"></span>
    <br/>
    <span>Guitar model:</span><input data-bind="value: product1.model"/>
    <span>Sales price:</span><input data-bind="value: product1.salePrice"/>
</div>

<div>
   <h2>Underlying Source Object for Object Literal</h2>
   <span>Item number</span><span data-bind="text: product1.itemNumber"></span>
   <br/>
   <span>Guitar model:</span><span data-bind="text: product1.model"></span>
   <span>Sales price:</span><span data-bind="text: product1.salePrice"></span>
</div>

<div>
    <h2>Observables</h2>
    <span>Item number</span><span data-bind="text: product2.itemNumber"></span>
    <br/>
    <span>Guitar model:</span><input data-bind="value: product2.model"/>
    <span>Sales price:</span><input data-bind="value: product2.salePrice"/>
</div>

<div>
    <h2>Underlying Source Object for Observable Object</h2>
    <span>Item number</span><span data-bind="text: product2.itemNumber"></span>
    <br/>
    <span>Guitar model:</span><span data-bind="text: product2.model"></span>
    <span>Sales price:</span><span data-bind="text: product2.salePrice"></span>
</div>

</asp:Content>
