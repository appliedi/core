//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hotcakes.Commerce.Data.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class hcc_LineItem
    {
        public long Id { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public System.Guid ProductId { get; set; }
        public string VariantId { get; set; }
        public int Quantity { get; set; }
        public System.Guid OrderBvin { get; set; }
        public decimal BasePrice { get; set; }
        public string DiscountDetails { get; set; }
        public decimal AdjustedPrice { get; set; }
        public decimal ShippingPortion { get; set; }
        public decimal TaxPortion { get; set; }
        public decimal LineTotal { get; set; }
        public string CustomProperties { get; set; }
        public int QuantityReturned { get; set; }
        public int QuantityShipped { get; set; }
        public string ProductName { get; set; }
        public string ProductShortDescription { get; set; }
        public string ProductSku { get; set; }
        public string StatusCode { get; set; }
        public string StatusName { get; set; }
        public string SelectionData { get; set; }
        public long StoreId { get; set; }
        public long TaxScheduleId { get; set; }
        public decimal ProductShippingWeight { get; set; }
        public decimal ProductShippingLength { get; set; }
        public decimal ProductShippingWidth { get; set; }
        public decimal ProductShippingHeight { get; set; }
        public string ShipFromAddress { get; set; }
        public int ShipFromMode { get; set; }
        public string ShipFromNotificationId { get; set; }
        public bool ShipSeparately { get; set; }
        public decimal ExtraShipCharge { get; set; }
        public int IsNonShipping { get; set; }
        public bool IsUserSuppliedPrice { get; set; }
        public decimal TaxRate { get; set; }
        public decimal ShippingTaxRate { get; set; }
        public bool IsBundle { get; set; }
        public int QuantityReserved { get; set; }
        public bool IsGiftCard { get; set; }
        public bool IsRecurring { get; set; }
        public Nullable<int> RecurringInterval { get; set; }
        public Nullable<int> RecurringIntervalType { get; set; }
        public int ShippingCharge { get; set; }
        public bool IsRecurringCancelled { get; set; }
        public int FreeQuantity { get; set; }
        public string PromotionIds { get; set; }
    
        public virtual hcc_Order hcc_Order { get; set; }
    }
}