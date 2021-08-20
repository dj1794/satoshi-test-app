#pragma checksum "D:\Sample Projects\Git\SatoshiTestApp\SatoshiTestApp\Components\SalesOrder.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ffb9d06c8b41d1cbc69cdc7b6a7c34ad2415129"
// <auto-generated/>
#pragma warning disable 1591
namespace SatoshiTestApp.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Sample Projects\Git\SatoshiTestApp\SatoshiTestApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Sample Projects\Git\SatoshiTestApp\SatoshiTestApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Sample Projects\Git\SatoshiTestApp\SatoshiTestApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Sample Projects\Git\SatoshiTestApp\SatoshiTestApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Sample Projects\Git\SatoshiTestApp\SatoshiTestApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Sample Projects\Git\SatoshiTestApp\SatoshiTestApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Sample Projects\Git\SatoshiTestApp\SatoshiTestApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Sample Projects\Git\SatoshiTestApp\SatoshiTestApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Sample Projects\Git\SatoshiTestApp\SatoshiTestApp\_Imports.razor"
using SatoshiTestApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Sample Projects\Git\SatoshiTestApp\SatoshiTestApp\_Imports.razor"
using SatoshiTestApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Sample Projects\Git\SatoshiTestApp\SatoshiTestApp\Components\SalesOrder.razor"
using Blazorise.DataGrid;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Sample Projects\Git\SatoshiTestApp\SatoshiTestApp\Components\SalesOrder.razor"
using Satoshi.Domain.Sales;

#line default
#line hidden
#nullable disable
    public partial class SalesOrder : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Sales Order</h2>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 4 "D:\Sample Projects\Git\SatoshiTestApp\SatoshiTestApp\Components\SalesOrder.razor"
                 salesOrderModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
#nullable restore
#line 5 "D:\Sample Projects\Git\SatoshiTestApp\SatoshiTestApp\Components\SalesOrder.razor"
     if (salesOrderModel != null)
    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "form-group col-md-4");
                __builder2.AddMarkupContent(6, "<label>Customer Name</label>\r\n            ");
                __builder2.OpenElement(7, "input");
                __builder2.AddAttribute(8, "id", "txtCustomerName");
                __builder2.AddAttribute(9, "class", "form-control");
                __builder2.AddAttribute(10, "type", "text");
                __builder2.AddAttribute(11, "required");
                __builder2.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "D:\Sample Projects\Git\SatoshiTestApp\SatoshiTestApp\Components\SalesOrder.razor"
                                                                                       salesOrderModel.customerName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => salesOrderModel.customerName = __value, salesOrderModel.customerName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n        ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "form-group col-md-4");
                __builder2.AddMarkupContent(17, "<label>Product Name</label>\r\n            ");
                __builder2.OpenElement(18, "select");
                __builder2.AddAttribute(19, "class", "form-control");
                __builder2.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "D:\Sample Projects\Git\SatoshiTestApp\SatoshiTestApp\Components\SalesOrder.razor"
                           salesOrderModel.productID

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => salesOrderModel.productID = __value, salesOrderModel.productID));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.OpenElement(22, "option");
                __builder2.AddAttribute(23, "value", "0");
                __builder2.AddContent(24, "Select Product");
                __builder2.CloseElement();
#nullable restore
#line 15 "D:\Sample Projects\Git\SatoshiTestApp\SatoshiTestApp\Components\SalesOrder.razor"
                 if (productsList != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Sample Projects\Git\SatoshiTestApp\SatoshiTestApp\Components\SalesOrder.razor"
                     foreach (var product in productsList)
                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(25, "option");
                __builder2.AddAttribute(26, "value", 
#nullable restore
#line 19 "D:\Sample Projects\Git\SatoshiTestApp\SatoshiTestApp\Components\SalesOrder.razor"
                                       product.id

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(27, 
#nullable restore
#line 19 "D:\Sample Projects\Git\SatoshiTestApp\SatoshiTestApp\Components\SalesOrder.razor"
                                                   product.productName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 20 "D:\Sample Projects\Git\SatoshiTestApp\SatoshiTestApp\Components\SalesOrder.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\Sample Projects\Git\SatoshiTestApp\SatoshiTestApp\Components\SalesOrder.razor"
                     
                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n        ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "form-group col-md-2");
                __builder2.AddMarkupContent(31, "<label>Price $</label>\r\n            ");
                __builder2.OpenElement(32, "input");
                __builder2.AddAttribute(33, "id", "txtPrice");
                __builder2.AddAttribute(34, "class", "form-control");
                __builder2.AddAttribute(35, "type", "text");
                __builder2.AddAttribute(36, "required");
                __builder2.AddAttribute(37, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "D:\Sample Projects\Git\SatoshiTestApp\SatoshiTestApp\Components\SalesOrder.razor"
                                                                               salesOrderModel.price

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => salesOrderModel.price = __value, salesOrderModel.price));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n        ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "form-group col-md-2");
                __builder2.OpenElement(42, "input");
                __builder2.AddAttribute(43, "type", "button");
                __builder2.AddAttribute(44, "class", "btn btn-primary");
                __builder2.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "D:\Sample Projects\Git\SatoshiTestApp\SatoshiTestApp\Components\SalesOrder.razor"
                                                                   SaveSalesOrder

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(46, "value", "Save");
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 33 "D:\Sample Projects\Git\SatoshiTestApp\SatoshiTestApp\Components\SalesOrder.razor"
         if (!string.IsNullOrWhiteSpace(statusMessage))
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "form-group oi-bold col-md-2");
                __builder2.OpenElement(49, "label");
                __builder2.AddContent(50, 
#nullable restore
#line 36 "D:\Sample Projects\Git\SatoshiTestApp\SatoshiTestApp\Components\SalesOrder.razor"
                        statusMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 38 "D:\Sample Projects\Git\SatoshiTestApp\SatoshiTestApp\Components\SalesOrder.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "D:\Sample Projects\Git\SatoshiTestApp\SatoshiTestApp\Components\SalesOrder.razor"
         
    }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 42 "D:\Sample Projects\Git\SatoshiTestApp\SatoshiTestApp\Components\SalesOrder.razor"
 if (salesorderList == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(51, "<p> Loading.....</p>");
#nullable restore
#line 45 "D:\Sample Projects\Git\SatoshiTestApp\SatoshiTestApp\Components\SalesOrder.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Blazorise.DataGrid.DataGrid<SalesOrderModel>>(52);
            __builder.AddAttribute(53, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<SalesOrderModel>>(
#nullable restore
#line 49 "D:\Sample Projects\Git\SatoshiTestApp\SatoshiTestApp\Components\SalesOrder.razor"
                 salesorderList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(54, "UseInternalEditing", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 49 "D:\Sample Projects\Git\SatoshiTestApp\SatoshiTestApp\Components\SalesOrder.razor"
                                                     true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(55, "EditMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.DataGrid.DataGridEditMode>(
#nullable restore
#line 50 "D:\Sample Projects\Git\SatoshiTestApp\SatoshiTestApp\Components\SalesOrder.razor"
                                                       DataGridEditMode.Inline

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(56, "Editable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 50 "D:\Sample Projects\Git\SatoshiTestApp\SatoshiTestApp\Components\SalesOrder.razor"
                                                                                          true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "SelectedRow", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<SalesOrderModel>(
#nullable restore
#line 50 "D:\Sample Projects\Git\SatoshiTestApp\SatoshiTestApp\Components\SalesOrder.razor"
                              selectedOrder

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(58, "SelectedRowChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<SalesOrderModel>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<SalesOrderModel>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedOrder = __value, selectedOrder))));
            __builder.AddAttribute(59, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Blazorise.DataGrid.DataGridColumn<SalesOrderModel>>(60);
                __builder2.AddAttribute(61, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 57 "D:\Sample Projects\Git\SatoshiTestApp\SatoshiTestApp\Components\SalesOrder.razor"
                                                    nameof(SalesOrderModel.id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(62, "Caption", "#");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(63, "\r\n    ");
                __builder2.OpenComponent<Blazorise.DataGrid.DataGridColumn<SalesOrderModel>>(64);
                __builder2.AddAttribute(65, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 58 "D:\Sample Projects\Git\SatoshiTestApp\SatoshiTestApp\Components\SalesOrder.razor"
                                                    nameof(SalesOrderModel.customerName)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(66, "Caption", "Customer Name");
                __builder2.AddAttribute(67, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 58 "D:\Sample Projects\Git\SatoshiTestApp\SatoshiTestApp\Components\SalesOrder.razor"
                                                                                                                            true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(68, "\r\n    ");
                __builder2.OpenComponent<Blazorise.DataGrid.DataGridColumn<SalesOrderModel>>(69);
                __builder2.AddAttribute(70, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 59 "D:\Sample Projects\Git\SatoshiTestApp\SatoshiTestApp\Components\SalesOrder.razor"
                                                    nameof(SalesOrderModel.productID)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(71, "Caption", "Product Name");
                __builder2.AddAttribute(72, "DisplayTemplate", (Microsoft.AspNetCore.Components.RenderFragment<SalesOrderModel>)((context) => (__builder3) => {
                    __builder3.AddContent(73, 
#nullable restore
#line 61 "D:\Sample Projects\Git\SatoshiTestApp\SatoshiTestApp\Components\SalesOrder.razor"
             productsList.Where(x => x.id == context.productID).Select(x => x.productName).FirstOrDefault()

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(74, "\r\n    ");
                __builder2.OpenComponent<Blazorise.DataGrid.DataGridColumn<SalesOrderModel>>(75);
                __builder2.AddAttribute(76, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 64 "D:\Sample Projects\Git\SatoshiTestApp\SatoshiTestApp\Components\SalesOrder.razor"
                                                    nameof(SalesOrderModel.price)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(77, "Caption", "Sold Price");
                __builder2.AddAttribute(78, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 64 "D:\Sample Projects\Git\SatoshiTestApp\SatoshiTestApp\Components\SalesOrder.razor"
                                                                                                                  true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(79, "DisplayTemplate", (Microsoft.AspNetCore.Components.RenderFragment<SalesOrderModel>)((context) => (__builder3) => {
                    __builder3.AddContent(80, 
#nullable restore
#line 66 "D:\Sample Projects\Git\SatoshiTestApp\SatoshiTestApp\Components\SalesOrder.razor"
             context.price

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(81, " $\r\n        ");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 70 "D:\Sample Projects\Git\SatoshiTestApp\SatoshiTestApp\Components\SalesOrder.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
