using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vincit.Jobscope.Domain.Entities
{
    public class CustomerInquiryLine : JobscopeEntity
    {
        [JsonProperty("customerInquiryLineId")]
        public double? CustomerInquiryLineId { get; set; }

        [JsonProperty("divisionId")]
        public string? DivisionId { get; set; }

        [JsonProperty("customerInquiryNumber")]
        public string? CustomerInquiryNumber { get; set; }

        [JsonProperty("customerInquiryLine")]
        public int? CustomerInquiryLineInt { get; set; }

        [JsonProperty("partNumber")]
        public string? PartNumber { get; set; }

        [JsonProperty("partRevision")]
        public string? PartRevision { get; set; }

        [JsonProperty("partDescription")]
        public string? PartDescription { get; set; }

        [JsonProperty("releaseNumber")]
        public string? ReleaseNumber { get; set; }

        [JsonProperty("releaseLineNumber")]
        public string? ReleaseLineNumber { get; set; }

        [JsonProperty("isClosed")]
        public bool? IsClosed { get; set; }

        [JsonProperty("inquiryStatus")]
        public string? InquiryStatus { get; set; }

        [JsonProperty("inquiryCloseReason")]
        public string? InquiryCloseReason { get; set; }

        [JsonProperty("dateClosed")]
        public DateTime? DateClosed { get; set; }

        [JsonProperty("quantity")]
        public double? Quantity { get; set; }

        [JsonProperty("uom")]
        public string? Uom { get; set; }

        [JsonProperty("length")]
        public double? Length { get; set; }

        [JsonProperty("width")]
        public double? Width { get; set; }

        [JsonProperty("priceCategory")]
        public string? PriceCategory { get; set; }

        [JsonProperty("priceCode")]
        public string? PriceCode { get; set; }

        [JsonProperty("priceDescription")]
        public string? PriceDescription { get; set; }

        [JsonProperty("basePartSellingPrice")]
        public double? BasePartSellingPrice { get; set; }

        [JsonProperty("actualPartSellingPrice")]
        public double? ActualPartSellingPrice { get; set; }

        [JsonProperty("reference")]
        public string? Reference { get; set; }

        [JsonProperty("productLine")]
        public string? ProductLine { get; set; }

        [JsonProperty("locationCode")]
        public string? LocationCode { get; set; }

        [JsonProperty("isTaxable")]
        public bool? IsTaxable { get; set; }

        [JsonProperty("unitCost")]
        public double? UnitCost { get; set; }

        [JsonProperty("totalCost")]
        public double? TotalCost { get; set; }

        [JsonProperty("unitWeight")]
        public double? UnitWeight { get; set; }

        [JsonProperty("lineItemQuantity")]
        public double? LineItemQuantity { get; set; }

        [JsonProperty("lineItemWeight")]
        public double? LineItemWeight { get; set; }

        [JsonProperty("itemTotal")]
        public double? ItemTotal { get; set; }

        [JsonProperty("discountPercent")]
        public double? DiscountPercent { get; set; }

        [JsonProperty("netSellingPriceBfAdjustments")]
        public double? NetSellingPriceBfAdjustments { get; set; }

        [JsonProperty("totalPriceAdjustmentsSelected")]
        public double? TotalPriceAdjustmentsSelected { get; set; }

        [JsonProperty("totalCostAdjustmentsSelected")]
        public double? TotalCostAdjustmentsSelected { get; set; }

        [JsonProperty("lineItemTotal")]
        public double? LineItemTotal { get; set; }

        [JsonProperty("shipDate")]
        public DateTime? ShipDate { get; set; }

        [JsonProperty("promisedDate")]
        public DateTime? PromisedDate { get; set; }

        [JsonProperty("requestedDate")]
        public DateTime? RequestedDate { get; set; }

        [JsonProperty("revisedPromisedDate")]
        public DateTime? RevisedPromisedDate { get; set; }

        [JsonProperty("comments")]
        public string? Comments { get; set; }

        [JsonProperty("vatCode")]
        public string? VatCode { get; set; }

        [JsonProperty("vatRate")]
        public double? VatRate { get; set; }

        [JsonProperty("deliveryTerms")]
        public string? DeliveryTerms { get; set; }

        [JsonProperty("modeOfTransport")]
        public string? ModeOfTransport { get; set; }

        [JsonProperty("commodityCode")]
        public string? CommodityCode { get; set; }

        [JsonProperty("useCostPlusQuoting")]
        public bool? UseCostPlusQuoting { get; set; }

        [JsonProperty("setInquiryUOMAsDefault")]
        public bool? SetInquiryUOMAsDefault { get; set; }

        [JsonProperty("inquiryUOM")]
        public string? InquiryUOM { get; set; }

        [JsonProperty("inquiryLineItemQty")]
        public double? InquiryLineItemQty { get; set; }

        [JsonProperty("conversion")]
        public double? Conversion { get; set; }

        [JsonProperty("userText")]
        public string? UserText { get; set; }

        [JsonProperty("productCode")]
        public string? ProductCode { get; set; }

        [JsonProperty("positionNumber")]
        public string? PositionNumber { get; set; }

        [JsonProperty("basePartSellingPriceNative")]
        public double? BasePartSellingPriceNative { get; set; }

        [JsonProperty("actualPartSellingPriceNative")]
        public double? ActualPartSellingPriceNative { get; set; }

        [JsonProperty("itemTotalNative")]
        public double? ItemTotalNative { get; set; }

        [JsonProperty("netSellingPriceBfAdjustmentsNative")]
        public double? NetSellingPriceBfAdjustmentsNative { get; set; }

        [JsonProperty("totalPriceAdjustmentsSelectedNative")]
        public double? TotalPriceAdjustmentsSelectedNative { get; set; }

        [JsonProperty("lineItemTotalNative")]
        public double? LineItemTotalNative { get; set; }

        [JsonProperty("finishCode")]
        public string? FinishCode { get; set; }

        [JsonProperty("psm")]
        public string? Psm { get; set; }

        [JsonProperty("createCustomerInquiryLinescopeUserId")]
        public int? CreateCustomerInquiryLinescopeUserId { get; set; }

        [JsonProperty("createDate")]
        public DateTime? CreateDate { get; set; }

        [JsonProperty("modifyCustomerInquiryLinescopeUserId")]
        public int? ModifyCustomerInquiryLinescopeUserId { get; set; }

        [JsonProperty("modifyDate")]
        public DateTime? ModifyDate { get; set; }

        [JsonProperty("userDefinedFields")]
        public List<CustomerInquiryLine_UserDefinedField>? UserDefinedFields { get; set; }
    }

    public class CustomerInquiryLine_UserDefinedField
    {
        [JsonProperty("userDefinedFieldId")]
        public string? UserDefinedFieldId { get; set; }

        [JsonProperty("definitionId")]
        public string? DefinitionId { get; set; }

        [JsonProperty("languageCode")]
        public string? LanguageCode { get; set; }

        [JsonProperty("typeCode")]
        public string? TypeCode { get; set; }

        [JsonProperty("tableNumber")]
        public string? TableNumber { get; set; }

        [JsonProperty("value")]
        public string? Value { get; set; }

    }
}
