﻿using Grand.Infrastructure.ModelBinding;
using Grand.Infrastructure.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Grand.Web.Admin.Models.Orders
{
    public class ShipmentListModel : BaseModel
    {
        [GrandResourceDisplayName("Admin.Orders.Shipments.List.StartDate")]
        [UIHint("DateNullable")]
        public DateTime? StartDate { get; set; }

        [GrandResourceDisplayName("Admin.Orders.Shipments.List.EndDate")]
        [UIHint("DateNullable")]
        public DateTime? EndDate { get; set; }

        [GrandResourceDisplayName("Admin.Orders.Shipments.List.TrackingNumber")]
        
        public string TrackingNumber { get; set; }
        
        public IList<SelectListItem> AvailableCountries { get; set; } = new List<SelectListItem>();

        [GrandResourceDisplayName("Admin.Orders.Shipments.List.Country")]
        public string CountryId { get; set; }

        public IList<SelectListItem> AvailableStates { get; set; } = new List<SelectListItem>();

        [GrandResourceDisplayName("Admin.Orders.Shipments.List.StateProvince")]
        public int StateProvinceId { get; set; }

        [GrandResourceDisplayName("Admin.Orders.Shipments.List.City")]
        
        public string City { get; set; }

        [GrandResourceDisplayName("Admin.Orders.Shipments.List.LoadNotShipped")]
        public bool LoadNotShipped { get; set; }


        [GrandResourceDisplayName("Admin.Orders.Shipments.List.Warehouse")]
        public string WarehouseId { get; set; }
        public IList<SelectListItem> AvailableWarehouses { get; set; } = new List<SelectListItem>();

        public string StoreId { get; set; }
        public string VendorId { get; set; }
    }
}