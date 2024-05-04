﻿using AutoMapper;
using Grand.Business.Core.Dto;
using Grand.Domain.Catalog;
using Grand.Infrastructure.Mapper;

namespace Grand.Business.Catalog.Services.ExportImport.Mapper;

public class ProductProfile : Profile, IAutoMapperProfile
{
    public ProductProfile()
    {
        CreateMap<ProductDto, Product>()
            .ForMember(x => x.UpdatedOnUtc, opt => opt.MapFrom(o => DateTime.UtcNow))
            .ForMember(x => x.ProductTypeId, opt => opt.Condition(z => z.ProductTypeId.HasValue))
            .ForMember(x => x.VisibleIndividually, opt => opt.Condition(z => z.VisibleIndividually.HasValue))
            .ForMember(x => x.ShowOnHomePage, opt => opt.Condition(z => z.ShowOnHomePage.HasValue))
            .ForMember(x => x.BestSeller, opt => opt.Condition(z => z.BestSeller.HasValue))
            .ForMember(x => x.AllowCustomerReviews, opt => opt.Condition(z => z.AllowCustomerReviews.HasValue))
            .ForMember(x => x.ApprovedRatingSum, opt => opt.Condition(z => z.ApprovedRatingSum.HasValue))
            .ForMember(x => x.NotApprovedRatingSum, opt => opt.Condition(z => z.NotApprovedRatingSum.HasValue))
            .ForMember(x => x.ApprovedTotalReviews, opt => opt.Condition(z => z.ApprovedTotalReviews.HasValue))
            .ForMember(x => x.NotApprovedTotalReviews, opt => opt.Condition(z => z.NotApprovedTotalReviews.HasValue))
            .ForMember(x => x.IsGiftVoucher, opt => opt.Condition(z => z.IsGiftVoucher.HasValue))
            .ForMember(x => x.GiftVoucherTypeId, opt => opt.Condition(z => z.GiftVoucherTypeId.HasValue))
            .ForMember(x => x.OverGiftAmount, opt => opt.Condition(z => z.OverGiftAmount.HasValue))
            .ForMember(x => x.RequireOtherProducts, opt => opt.Condition(z => z.RequireOtherProducts.HasValue))
            .ForMember(x => x.AutoAddRequiredProducts, opt => opt.Condition(z => z.AutoAddRequiredProducts.HasValue))
            .ForMember(x => x.IsDownload, opt => opt.Condition(z => z.IsDownload.HasValue))
            .ForMember(x => x.UnlimitedDownloads, opt => opt.Condition(z => z.UnlimitedDownloads.HasValue))
            .ForMember(x => x.MaxNumberOfDownloads, opt => opt.Condition(z => z.MaxNumberOfDownloads.HasValue))
            .ForMember(x => x.DownloadExpirationDays, opt => opt.Condition(z => z.DownloadExpirationDays.HasValue))
            .ForMember(x => x.DownloadActivationTypeId, opt => opt.Condition(z => z.DownloadActivationTypeId.HasValue))
            .ForMember(x => x.HasSampleDownload, opt => opt.Condition(z => z.HasSampleDownload.HasValue))
            .ForMember(x => x.HasUserAgreement, opt => opt.Condition(z => z.HasUserAgreement.HasValue))
            .ForMember(x => x.IsRecurring, opt => opt.Condition(z => z.IsRecurring.HasValue))
            .ForMember(x => x.RecurringCycleLength, opt => opt.Condition(z => z.RecurringCycleLength.HasValue))
            .ForMember(x => x.RecurringCyclePeriodId, opt => opt.Condition(z => z.RecurringCyclePeriodId.HasValue))
            .ForMember(x => x.RecurringTotalCycles, opt => opt.Condition(z => z.RecurringTotalCycles.HasValue))
            .ForMember(x => x.IncBothDate, opt => opt.Condition(z => z.IncBothDate.HasValue))
            .ForMember(x => x.Interval, opt => opt.Condition(z => z.Interval.HasValue))
            .ForMember(x => x.IntervalUnitId, opt => opt.Condition(z => z.IntervalUnitId.HasValue))
            .ForMember(x => x.IsFreeShipping, opt => opt.Condition(z => z.IsFreeShipping.HasValue))
            .ForMember(x => x.ShipSeparately, opt => opt.Condition(z => z.ShipSeparately.HasValue))
            .ForMember(x => x.AdditionalShippingCharge, opt => opt.Condition(z => z.AdditionalShippingCharge.HasValue))
            .ForMember(x => x.IsTaxExempt, opt => opt.Condition(z => z.IsTaxExempt.HasValue))
            .ForMember(x => x.IsTele, opt => opt.Condition(z => z.IsTele.HasValue))
            .ForMember(x => x.ManageInventoryMethodId, opt => opt.Condition(z => z.ManageInventoryMethodId.HasValue))
            .ForMember(x => x.UseMultipleWarehouses, opt => opt.Condition(z => z.UseMultipleWarehouses.HasValue))
            .ForMember(x => x.StockQuantity, opt => opt.Condition(z => z.StockQuantity.HasValue))
            .ForMember(x => x.ReservedQuantity, opt => opt.Condition(z => z.ReservedQuantity.HasValue))
            .ForMember(x => x.StockAvailability, opt => opt.Condition(z => z.StockAvailability.HasValue))
            .ForMember(x => x.DisplayStockQuantity, opt => opt.Condition(z => z.DisplayStockQuantity.HasValue))
            .ForMember(x => x.MinStockQuantity, opt => opt.Condition(z => z.MinStockQuantity.HasValue))
            .ForMember(x => x.LowStock, opt => opt.Condition(z => z.LowStock.HasValue))
            .ForMember(x => x.LowStockActivityId, opt => opt.Condition(z => z.LowStockActivityId.HasValue))
            .ForMember(x => x.NotifyAdminForQuantityBelow,
                opt => opt.Condition(z => z.NotifyAdminForQuantityBelow.HasValue))
            .ForMember(x => x.BackorderModeId, opt => opt.Condition(z => z.BackorderModeId.HasValue))
            .ForMember(x => x.AllowOutOfStockSubscriptions,
                opt => opt.Condition(z => z.AllowOutOfStockSubscriptions.HasValue))
            .ForMember(x => x.OrderMinimumQuantity, opt => opt.Condition(z => z.OrderMinimumQuantity.HasValue))
            .ForMember(x => x.OrderMaximumQuantity, opt => opt.Condition(z => z.OrderMaximumQuantity.HasValue))
            .ForMember(x => x.NotReturnable, opt => opt.Condition(z => z.NotReturnable.HasValue))
            .ForMember(x => x.DisableBuyButton, opt => opt.Condition(z => z.DisableBuyButton.HasValue))
            .ForMember(x => x.DisableWishlistButton, opt => opt.Condition(z => z.DisableWishlistButton.HasValue))
            .ForMember(x => x.AvailableForPreOrder, opt => opt.Condition(z => z.AvailableForPreOrder.HasValue))
            .ForMember(x => x.PreOrderDateTimeUtc, opt => opt.Condition(z => z.PreOrderDateTimeUtc.HasValue))
            .ForMember(x => x.CallForPrice, opt => opt.Condition(z => z.CallForPrice.HasValue))
            .ForMember(x => x.Price, opt => opt.Condition(z => z.Price.HasValue))
            .ForMember(x => x.OldPrice, opt => opt.Condition(z => z.OldPrice.HasValue))
            .ForMember(x => x.CatalogPrice, opt => opt.Condition(z => z.CatalogPrice.HasValue))
            .ForMember(x => x.ProductCost, opt => opt.Condition(z => z.ProductCost.HasValue))
            .ForMember(x => x.EnteredPrice, opt => opt.Condition(z => z.EnteredPrice.HasValue))
            .ForMember(x => x.MinEnteredPrice, opt => opt.Condition(z => z.MinEnteredPrice.HasValue))
            .ForMember(x => x.MaxEnteredPrice, opt => opt.Condition(z => z.MaxEnteredPrice.HasValue))
            .ForMember(x => x.BasepriceEnabled, opt => opt.Condition(z => z.BasePriceEnabled.HasValue))
            .ForMember(x => x.BasepriceAmount, opt => opt.Condition(z => z.BasePriceAmount.HasValue))
            .ForMember(x => x.BasepriceBaseAmount, opt => opt.Condition(z => z.BasePriceBaseAmount.HasValue))
            .ForMember(x => x.MarkAsNew, opt => opt.Condition(z => z.MarkAsNew.HasValue))
            .ForMember(x => x.MarkAsNewStartDateTimeUtc,
                opt => opt.Condition(z => z.MarkAsNewStartDateTimeUtc.HasValue))
            .ForMember(x => x.MarkAsNewEndDateTimeUtc, opt => opt.Condition(z => z.MarkAsNewEndDateTimeUtc.HasValue))
            .ForMember(x => x.Weight, opt => opt.Condition(z => z.Weight.HasValue))
            .ForMember(x => x.Length, opt => opt.Condition(z => z.Length.HasValue))
            .ForMember(x => x.Width, opt => opt.Condition(z => z.Width.HasValue))
            .ForMember(x => x.Height, opt => opt.Condition(z => z.Height.HasValue))
            .ForMember(x => x.AvailableStartDateTimeUtc,
                opt => opt.Condition(z => z.AvailableStartDateTimeUtc.HasValue))
            .ForMember(x => x.AvailableEndDateTimeUtc, opt => opt.Condition(z => z.AvailableEndDateTimeUtc.HasValue))
            .ForMember(x => x.DisplayOrder, opt => opt.Condition(z => z.DisplayOrder.HasValue))
            .ForMember(x => x.DisplayOrderCategory, opt => opt.Condition(z => z.DisplayOrderCategory.HasValue))
            .ForMember(x => x.DisplayOrderBrand, opt => opt.Condition(z => z.DisplayOrderBrand.HasValue))
            .ForMember(x => x.DisplayOrderCollection, opt => opt.Condition(z => z.DisplayOrderCollection.HasValue))
            .ForMember(x => x.Sold, opt => opt.Condition(z => z.Sold.HasValue))
            .ForMember(x => x.Viewed, opt => opt.Condition(z => z.Viewed.HasValue))
            .ForMember(x => x.OnSale, opt => opt.Condition(z => z.OnSale.HasValue))
            .ForMember(x => x.Published, opt => opt.Condition(z => z.Published.HasValue))
            .ForMember(x => x.IsShipEnabled, opt => opt.Condition(z => z.IsShipEnabled.HasValue))
            .ForMember(x => x.Name, opt => opt.Condition(z => z.Name != null))
            .ForMember(x => x.ShortDescription, opt => opt.Condition(z => z.ShortDescription != null))
            .ForMember(x => x.FullDescription, opt => opt.Condition(z => z.FullDescription != null))
            .ForMember(x => x.ExternalId, opt => opt.Condition(z => z.ExternalId != null))
            .ForMember(x => x.MetaDescription, opt => opt.Condition(z => z.MetaDescription != null))
            .ForMember(x => x.MetaKeywords, opt => opt.Condition(z => z.MetaKeywords != null))
            .ForMember(x => x.MetaTitle, opt => opt.Condition(z => z.MetaTitle != null))
            .ForMember(x => x.SeName, opt => opt.Condition(z => z.SeName != null))
            .ForMember(x => x.BrandId, opt => opt.Condition(z => z.BrandId != null))
            .ForMember(x => x.ProductLayoutId, opt => opt.Condition(z => z.ProductLayoutId != null))
            .ForMember(x => x.AdminComment, opt => opt.Condition(z => z.AdminComment != null))
            .ForMember(x => x.VendorId, opt => opt.Condition(z => z.VendorId != null))
            .ForMember(x => x.Sku, opt => opt.Condition(z => z.Sku != null))
            .ForMember(x => x.Mpn, opt => opt.Condition(z => z.Mpn != null))
            .ForMember(x => x.Gtin, opt => opt.Condition(z => z.Gtin != null))
            .ForMember(x => x.AllowedQuantities, opt => opt.Condition(z => z.AllowedQuantities != null))
            .ForMember(x => x.BasepriceBaseUnitId, opt => opt.Condition(z => z.BasePriceBaseUnitId != null))
            .ForMember(x => x.BasepriceUnitId, opt => opt.Condition(z => z.BasePriceUnitId != null))
            .ForMember(x => x.CourseId, opt => opt.Condition(z => z.CourseId != null))
            .ForMember(x => x.DeliveryDateId, opt => opt.Condition(z => z.DeliveryDateId != null))
            .ForMember(x => x.TaxCategoryId, opt => opt.Condition(z => z.TaxCategoryId != null))
            .ForMember(x => x.WarehouseId, opt => opt.Condition(z => z.WarehouseId != null))
            .ForMember(x => x.UnitId, opt => opt.Condition(z => z.UnitId != null))
            .ForMember(x => x.Flag, opt => opt.Condition(z => z.Flag != null))
            .ForMember(x => x.RequiredProductIds, opt => opt.Condition(z => z.RequiredProductIds != null))
            .ForMember(x => x.ParentGroupedProductId, opt => opt.Condition(z => z.ParentGroupedProductId != null))
            .ForMember(x => x.UserAgreementText, opt => opt.Condition(z => z.UserAgreementText != null));
    }

    public int Order => 0;
}