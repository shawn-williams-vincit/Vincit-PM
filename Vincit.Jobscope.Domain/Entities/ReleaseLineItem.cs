using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vincit.Jobscope.Domain.Entities
{
    public class ReleaseLineItem : JobscopeEntity
    {
        [JsonProperty("divisionID")]
        public string? DivisionID { get; set; }

        [JsonProperty("releaseLineItemId")]
        public double? ReleaseLineItemId { get; set; }

        [JsonProperty("releaseNumber")]
        public string? ReleaseNumber { get; set; }

        [JsonProperty("lineItemNumber")]
        public string? LineItemNumber { get; set; }

        [JsonProperty("mrpStatus")]
        public string? MrpStatus { get; set; }

        [JsonProperty("canadianFedTaxCode")]
        public string? CanadianFedTaxCode { get; set; }

        [JsonProperty("canadianProvTaxCode")]
        public string? CanadianProvTaxCode { get; set; }

        [JsonProperty("comment")]
        public string? Comment { get; set; }

        [JsonProperty("commodityCode")]
        public string? CommodityCode { get; set; }

        [JsonProperty("costAccount")]
        public string? CostAccount { get; set; }

        [JsonProperty("customerNumber")]
        public string? CustomerNumber { get; set; }

        [JsonProperty("customerOrderNumber")]
        public string? CustomerOrderNumber { get; set; }

        [JsonProperty("dateScheduled")]
        public DateTime? DateScheduled { get; set; }

        [JsonProperty("datePromised")]
        public DateTime? DatePromised { get; set; }

        [JsonProperty("dateReceived")]
        public DateTime? DateReceived { get; set; }

        [JsonProperty("dateRequested")]
        public DateTime? DateRequested { get; set; }

        [JsonProperty("deliveryTerms")]
        public string? DeliveryTerms { get; set; }

        [JsonProperty("descriptionLong")]
        public string? DescriptionLong { get; set; }

        [JsonProperty("description1")]
        public string? Description1 { get; set; }

        [JsonProperty("description2")]
        public string? Description2 { get; set; }

        [JsonProperty("description3")]
        public string? Description3 { get; set; }

        [JsonProperty("description4")]
        public string? Description4 { get; set; }

        [JsonProperty("description5")]
        public string? Description5 { get; set; }

        [JsonProperty("dimension")]
        public double? Dimension { get; set; }

        [JsonProperty("discountPercent")]
        public double? DiscountPercent { get; set; }

        [JsonProperty("drawingNumber")]
        public string? DrawingNumber { get; set; }

        [JsonProperty("drawingRevision")]
        public string? DrawingRevision { get; set; }

        [JsonProperty("endUnitSerialNumber")]
        public string? EndUnitSerialNumber { get; set; }

        [JsonProperty("issueComplete")]
        public bool? IssueComplete { get; set; }

        [JsonProperty("languageCode")]
        public string? LanguageCode { get; set; }

        [JsonProperty("locationCode")]
        public string? LocationCode { get; set; }

        [JsonProperty("materialCostAccount")]
        public string? MaterialCostAccount { get; set; }

        [JsonProperty("netPrice")]
        public double? NetPrice { get; set; }

        [JsonProperty("netPriceCurrency")]
        public double? NetPriceCurrency { get; set; }

        [JsonProperty("scheduledOnline")]
        public bool? ScheduledOnline { get; set; }

        [JsonProperty("finishCode")]
        public string? FinishCode { get; set; }

        [JsonProperty("partNumber")]
        public string? PartNumber { get; set; }

        [JsonProperty("positionNumber")]
        public string? PositionNumber { get; set; }

        [JsonProperty("planningHorizonCode")]
        public string? PlanningHorizonCode { get; set; }

        [JsonProperty("priceCategory")]
        public string? PriceCategory { get; set; }

        [JsonProperty("priceCode")]
        public string? PriceCode { get; set; }

        [JsonProperty("productCode")]
        public string? ProductCode { get; set; }

        [JsonProperty("productLine")]
        public string? ProductLine { get; set; }

        [JsonProperty("psm")]
        public string? Psm { get; set; }

        [JsonProperty("quantityAuthorizedReturn")]
        public double? QuantityAuthorizedReturn { get; set; }

        [JsonProperty("quantityReturned")]
        public double? QuantityReturned { get; set; }

        [JsonProperty("quantityShipped")]
        public double? QuantityShipped { get; set; }

        [JsonProperty("quantity")]
        public double? Quantity { get; set; }

        [JsonProperty("quantityIssued")]
        public double? QuantityIssued { get; set; }

        [JsonProperty("quoteDate")]
        public DateTime? QuoteDate { get; set; }

        [JsonProperty("quoteDone")]
        public bool? QuoteDone { get; set; }

        [JsonProperty("receivingPartNumber")]
        public string? ReceivingPartNumber { get; set; }

        [JsonProperty("receivingOrderNumber")]
        public string? ReceivingOrderNumber { get; set; }

        [JsonProperty("releasedBy")]
        public string? ReleasedBy { get; set; }

        [JsonProperty("repairCategory")]
        public string? RepairCategory { get; set; }

        [JsonProperty("partRevision")]
        public string? PartRevision { get; set; }

        [JsonProperty("revisionLevel")]
        public string? RevisionLevel { get; set; }

        [JsonProperty("shipComplete")]
        public bool? ShipComplete { get; set; }

        [JsonProperty("shipDate")]
        public DateTime? ShipDate { get; set; }

        [JsonProperty("suggestedOrderAction")]
        public string? SuggestedOrderAction { get; set; }

        [JsonProperty("taxable")]
        public bool? Taxable { get; set; }

        [JsonProperty("transportCode")]
        public string? TransportCode { get; set; }

        [JsonProperty("unitCostCurrency")]
        public double? UnitCostCurrency { get; set; }

        [JsonProperty("unitPrice")]
        public double? UnitPrice { get; set; }

        [JsonProperty("uom")]
        public string? Uom { get; set; }

        [JsonProperty("userText")]
        public string? UserText { get; set; }

        [JsonProperty("vatCode")]
        public string? VatCode { get; set; }

        [JsonProperty("weight")]
        public double? Weight { get; set; }

        [JsonProperty("workOrder")]
        public string? WorkOrder { get; set; }

        [JsonProperty("isApprovedInterDivisionalItem")]
        public bool? IsApprovedInterDivisionalItem { get; set; }

        [JsonProperty("approvedInterDivisionalItemDate")]
        public DateTime? ApprovedInterDivisionalItemDate { get; set; }

        [JsonProperty("isRejectedInterDivisionalItem")]
        public bool? IsRejectedInterDivisionalItem { get; set; }

        [JsonProperty("rejectedInterDivisionalItemDate")]
        public DateTime? RejectedInterDivisionalItemDate { get; set; }

        [JsonProperty("purchaseOrderItemId")]
        public double? PurchaseOrderItemId { get; set; }

        [JsonProperty("createReleaseLineItemscopeUserId")]
        public int? CreateReleaseLineItemscopeUserId { get; set; }

        [JsonProperty("createDate")]
        public DateTime? CreateDate { get; set; }

        [JsonProperty("modifyReleaseLineItemscopeUserId")]
        public int? ModifyReleaseLineItemscopeUserId { get; set; }

        [JsonProperty("modifyDate")]
        public DateTime? ModifyDate { get; set; }

        [JsonProperty("userDefinedFields")]
        public List<ReleaseLineItem_UserDefinedField>? UserDefinedFields { get; set; }
    }

    public class ReleaseLineItem_UserDefinedField
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

