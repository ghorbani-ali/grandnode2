﻿using Grand.Infrastructure.Models;

namespace Grand.Web.Models.Orders
{
    public class CustomerOrderListModel : BaseModel
    {
        public OrderPagingModel PagingContext { get; set; } = new();
        public IList<OrderDetailsModel> Orders { get; set; } = new List<OrderDetailsModel>();

        #region Nested classes

        public class OrderDetailsModel : BaseEntityModel
        {
            public string OrderTotal { get; set; }
            public bool IsMerchandiseReturnAllowed { get; set; }
            public int OrderStatusId { get; set; }
            public string OrderStatus { get; set; }
            public string PaymentStatus { get; set; }
            public string ShippingStatus { get; set; }
            public DateTime CreatedOn { get; set; }
            public int OrderNumber { get; set; }
            public string OrderCode { get; set; }
            public string CustomerEmail { get; set; }
        }
        #endregion
    }
}