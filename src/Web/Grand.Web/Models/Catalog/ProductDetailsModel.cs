﻿using Grand.Business.Core.Utilities.Catalog;
using Grand.Domain.Catalog;
using Grand.Domain.Orders;
using Grand.Infrastructure.ModelBinding;
using Grand.Infrastructure.Models;
using Grand.Web.Models.Media;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Grand.Web.Models.Catalog
{
    public class ProductDetailsModel : BaseEntityModel
    {
        //picture(s)
        public bool DefaultPictureZoomEnabled { get; set; }
        public PictureModel DefaultPictureModel { get; set; } = new();
        public IList<PictureModel> PictureModels { get; set; } = new List<PictureModel>();
        public ProductType ProductType { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
        public string MetaTitle { get; set; }
        public string SeName { get; set; }
        public bool ShowSku { get; set; }
        public string Sku { get; set; }
        public string Flag { get; set; }
        public bool ShowMpn { get; set; }
        public string Mpn { get; set; }
        public bool ShowGtin { get; set; }
        public string Gtin { get; set; }
        public BrandBriefInfoModel BrandModel { get; set; } = new();
        public bool ShowVendor { get; set; }
        public VendorBriefInfoModel VendorModel { get; set; } = new();
        public bool HasSampleDownload { get; set; }
        public GiftVoucherModel GiftVoucher { get; set; } = new();
        public bool IsShipEnabled { get; set; }
        public bool NotReturnable { get; set; }
        public bool IsFreeShipping { get; set; }
        public bool AllowToSelectWarehouse { get; set; }
        public IList<ProductWarehouseModel> ProductWarehouses { get; set; } = new List<ProductWarehouseModel>();
        public double AdditionalShippingCharge { get; set; }
        public string AdditionalShippingChargeStr { get; set; }
        public bool FreeShippingNotificationEnabled { get; set; }
        public string DeliveryDate { get; set; }
        public string DeliveryColorSquaresRgb { get; set; }
        public int Interval { get; set; }
        public IntervalUnit IntervalUnit { get; set; }
        public bool IncBothDate { get; set; }
        public List<SelectListItem> Parameters { get; set; } = new();
        public DateTime StartDate { get; set; }
        public DateTime? RentalStartDateUtc { get; set; }
        public DateTime? RentalEndDateUtc { get; set; }
        public string RentalReservationId { get; set; }
        public string StockAvailability { get; set; }
        public bool DisplayOutOfStockSubscription { get; set; }
        public bool EmailAFriendEnabled { get; set; }
        public bool AskQuestionOnProduct { get; set; }
        public ProductAskQuestionSimpleModel ProductAskQuestion { get; set; }
        public bool CompareProductsEnabled { get; set; }
        public string PageShareCode { get; set; }
        public ProductPriceModel ProductPrice { get; set; } = new();
        public AddToCartModel AddToCart { get; set; } = new();
        public ProductBreadcrumbModel Breadcrumb { get; set; } = new();
        public IList<ProductTagModel> ProductTags { get; set; } = new List<ProductTagModel>();
        public IList<ProductAttributeModel> ProductAttributes { get; set; } = new List<ProductAttributeModel>();
        public IList<ProductSpecificationModel> ProductSpecifications { get; set; } = new List<ProductSpecificationModel>();
        public IList<CollectionModel> ProductCollections { get; set; } = new List<CollectionModel>();
        public ProductReviewOverviewModel ProductReviewOverview { get; set; } = new();

        public IList<TierPriceModel> TierPrices { get; set; } = new List<TierPriceModel>();

        //a list of associated products. For example, "Grouped" products could have several child "simple" products
        public IList<ProductDetailsModel> AssociatedProducts { get; set; } = new List<ProductDetailsModel>();

        //bundle product 
        public IList<ProductBundleModel> ProductBundleModels { get; set; } = new List<ProductBundleModel>();
        public bool DisplayDiscontinuedMessage { get; set; }
        public string CurrentStoreName { get; set; }
        public double StartPrice { get; set; }
        public double HighestBidValue { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime? EndTimeLocalTime { get; set; }
        public bool AuctionEnded { get; set; }
        public bool RenderCaptcha { get; set; }

        #region Nested Classes
        public class ProductBreadcrumbModel : BaseModel
        {
            public int Id { get; set; }
            public bool Enabled { get; set; }
            public string ProductId { get; set; }
            public string ProductName { get; set; }
            public string ProductSeName { get; set; }
            public IList<CategorySimpleModel> CategoryBreadcrumb { get; set; } = new List<CategorySimpleModel>();
        }

        public class AddToCartModel : BaseModel
        {
            public string ProductId { get; set; }
            //qty
            [GrandResourceDisplayName("Products.Qty")]
            public int EnteredQuantity { get; set; }
            public string MinimumQuantityNotification { get; set; }
            public List<SelectListItem> AllowedQuantities { get; set; } = new();

            //price entered by customers
            [GrandResourceDisplayName("Products.EnterProductPrice")]
            public bool EnteredPrice { get; set; }
            [GrandResourceDisplayName("Products.EnterProductPrice")]
            public double CustomerEnteredPrice { get; set; }
            public string CustomerEnteredPriceRange { get; set; }
            public bool DisableBuyButton { get; set; }
            public bool DisableWishlistButton { get; set; }
            //reservation
            public bool IsReservation { get; set; }
            //auction
            public bool IsAuction { get; set; }
            public string MeasureUnit { get; set; }
            //pre-order
            public bool AvailableForPreOrder { get; set; }
            public DateTime? PreOrderDateTimeUtc { get; set; }
            //updating existing shopping cart or wishlist item?
            public string UpdatedShoppingCartItemId { get; set; }
            public ShoppingCartType? UpdateShoppingCartItemType { get; set; }
        }

        public class ProductPriceModel : BaseModel
        {
            /// <summary>
            /// The currency (in 3-letter ISO 4217 format) of the offer price 
            /// </summary>
            public string CurrencyCode { get; set; }
            public string OldPrice { get; set; }
            public string CatalogPrice { get; set; }
            public string Price { get; set; }
            public string PriceWithDiscount { get; set; }
            public double PriceValue { get; set; }
            public bool EnteredPrice { get; set; }
            public bool CallForPrice { get; set; }
            public string ProductId { get; set; }
            public bool HidePrices { get; set; }
            //Reservation
            public bool IsReservation { get; set; }
            public string ReservationPrice { get; set; }
            //Auction
            public bool IsAuction { get; set; }
            public string HighestBid { get; set; }
            public double HighestBidValue { get; set; }
            public string StartPrice { get; set; }
            public double StartPriceValue { get; set; }
            public bool DisableBuyButton { get; set; }

            public string BasePricePAngV { get; set; }

            public List<ApplyDiscount> AppliedDiscounts { get; set; } = new();
            public TierPrice PreferredTierPrice { get; set; }
        }

        public class GiftVoucherModel : BaseModel
        {
            public bool IsGiftVoucher { get; set; }

            [GrandResourceDisplayName("Products.GiftVoucher.RecipientName")]
            public string RecipientName { get; set; }
            [GrandResourceDisplayName("Products.GiftVoucher.RecipientEmail")]
            public string RecipientEmail { get; set; }
            [GrandResourceDisplayName("Products.GiftVoucher.SenderName")]
            public string SenderName { get; set; }
            [GrandResourceDisplayName("Products.GiftVoucher.SenderEmail")]
            public string SenderEmail { get; set; }
            [GrandResourceDisplayName("Products.GiftVoucher.Message")]
            public string Message { get; set; }

            public GiftVoucherType GiftVoucherType { get; set; }
        }

        public class TierPriceModel : BaseModel
        {
            public string Price { get; set; }

            public int Quantity { get; set; }
        }

        public class ProductAttributeModel : BaseEntityModel
        {
            public string ProductId { get; set; }
            public string ProductAttributeId { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string TextPrompt { get; set; }
            public bool IsRequired { get; set; }
            /// <summary>
            /// Default value for textboxes
            /// </summary>
            public string DefaultValue { get; set; }
            /// <summary>
            /// Selected day value for datepicker
            /// </summary>
            public int? SelectedDay { get; set; }
            /// <summary>
            /// Selected month value for datepicker
            /// </summary>
            public int? SelectedMonth { get; set; }
            /// <summary>
            /// Selected year value for datepicker
            /// </summary>
            public int? SelectedYear { get; set; }

            /// <summary>
            /// A value indicating whether this attribute depends on some other attribute
            /// </summary>
            public bool HasCondition { get; set; }

            /// <summary>
            /// Allowed file extensions for customer uploaded files
            /// </summary>
            public IList<string> AllowedFileExtensions { get; set; } = new List<string>();

            public AttributeControlType AttributeControlType { get; set; }
            public IList<ProductAttributeValueModel> Values { get; set; } = new List<ProductAttributeValueModel>();
        }

        public class ProductAttributeValueModel : BaseEntityModel
        {
            public string Name { get; set; }
            public string ColorSquaresRgb { get; set; }
            //picture model is used with "image square" attribute type
            public PictureModel ImageSquaresPictureModel { get; set; } = new();
            public string PriceAdjustment { get; set; }
            public double PriceAdjustmentValue { get; set; }
            public string StockAvailability { get; set; }
            public bool IsPreSelected { get; set; }
            //picture model is used when we want to override a default product picture when some attribute is selected
            public PictureModel PictureModel { get; set; } = new();
        }

        public class ProductBundleModel : BaseModel
        {
            public string ProductId { get; set; }
            public string Name { get; set; }
            public string SeName { get; set; }
            public string ShortDescription { get; set; }
            public string Sku { get; set; }
            public string Mpn { get; set; }
            public string Gtin { get; set; }
            public int Quantity { get; set; }
            public string Price { get; set; }
            public double PriceValue { get; set; }
            public PictureModel DefaultPictureModel { get; set; }
            public IList<ProductAttributeModel> ProductAttributes { get; set; } = new List<ProductAttributeModel>();
        }

        public class ProductWarehouseModel : BaseModel
        {
            public bool Use { get; set; }
            public string WarehouseId { get; set; }
            public string Code { get; set; }
            public string Name { get; set; }
            public int StockQuantity { get; set; }
            public int ReservedQuantity { get; set; }
            public bool Selected { get; set; }
        }
        #endregion
    }
}