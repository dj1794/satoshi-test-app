﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Satoshi.Domain.Sales;
using SatoshiTestApp.Services;
using Blazorise.DataGrid;

namespace SatoshiTestApp.Components
{
    public partial class SalesOrder
    {
        [Inject]
        IApiService apiService { get; set; }
        SalesOrderModel salesOrderModel = new SalesOrderModel();
        List<SalesOrderModel> salesorderList = new List<SalesOrderModel>();
        List<ProductsModel> productsList = new List<ProductsModel>();
        private SalesOrderModel selectedOrder;
        string statusMessage;
        protected override async Task OnInitializedAsync()
        {
            productsList = await apiService.Get<List<ProductsModel>>("api/Sales/GetProducts");
           await BindGrid();
            StateHasChanged();
        }
        public async Task SaveSalesOrder()
        {
            statusMessage = string.Empty;
            Console.WriteLine("Save Clicked !!!");
            bool status = false;
            await apiService.Post<SalesOrderModel>("api/Sales/SaveOrders",salesOrderModel);
            status = true;
            if(status)
            {
                statusMessage = "Order has been placed !!!";
                await BindGrid();
            }
            else
            {
                statusMessage = "Action failed.";
            }
            StateHasChanged();
        }
        public async Task BindGrid()
        {
            salesorderList = await apiService.Get<List<SalesOrderModel>>("api/Sales/GetOrders");
        }
        public void ClearFields()
        {
            salesOrderModel.customerName = string.Empty;
            salesOrderModel.productID = 0;
            salesOrderModel.price = 0;
            statusMessage = string.Empty;
            StateHasChanged();
        }

    }
}
