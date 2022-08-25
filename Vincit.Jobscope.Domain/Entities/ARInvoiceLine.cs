using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vincit.Jobscope.Domain.Entities
{
    public class ARInvoiceLine : JobscopeEntity
    {
        [JsonProperty("arInvoiceLineID")]
        public double? ArInvoiceLineID { get; set; }

        [JsonProperty("invoiceNumber")]
        public string? InvoiceNumber { get; set; }

        [JsonProperty("extendedAmount")]
        public double? ExtendedAmount { get; set; }

        [JsonProperty("comment")]
        public string? Comment { get; set; }

        [JsonProperty("itemNumber")]
        public string? ItemNumber { get; set; }

        [JsonProperty("lineItemNumber")]
        public string? LineItemNumber { get; set; }

        [JsonProperty("productLine")]
        public string? ProductLine { get; set; }

        [JsonProperty("quantity")]
        public double? Quantity { get; set; }

        [JsonProperty("shipItem")]
        public string? ShipItem { get; set; }

        [JsonProperty("unitPrice")]
        public double? UnitPrice { get; set; }

        [JsonProperty("vatCode")]
        public string? VatCode { get; set; }

        [JsonProperty("canadianFedTaxCode")]
        public string? CanadianFedTaxCode { get; set; }

        [JsonProperty("canadianProvTaxCode")]
        public string? CanadianProvTaxCode { get; set; }

        [JsonProperty("languageCode")]
        public string? LanguageCode { get; set; }

        [JsonProperty("isTaxable")]
        public bool? IsTaxable { get; set; }

        [JsonProperty("userText")]
        public string? UserText { get; set; }

        [JsonProperty("partNumber")]
        public string? PartNumber { get; set; }

        [JsonProperty("uom")]
        public string? Uom { get; set; }

        [JsonProperty("isComplete")]
        public bool? IsComplete { get; set; }

        [JsonProperty("materialSubledgerId")]
        public double? MaterialSubledgerId { get; set; }

        [JsonProperty("laborSubledgerId")]
        public double? LaborSubledgerId { get; set; }

        [JsonProperty("tamRateCode")]
        public string? TamRateCode { get; set; }

        [JsonProperty("tamSubRateCode")]
        public string? TamSubRateCode { get; set; }

        [JsonProperty("stateTaxAmount")]
        public double? StateTaxAmount { get; set; }

        [JsonProperty("stateTaxAmountNativeCurrency")]
        public double? StateTaxAmountNativeCurrency { get; set; }

        [JsonProperty("countyTaxAmount")]
        public double? CountyTaxAmount { get; set; }

        [JsonProperty("countyTaxAmountNativeCurrency")]
        public double? CountyTaxAmountNativeCurrency { get; set; }

        [JsonProperty("tax3Amount")]
        public double? Tax3Amount { get; set; }

        [JsonProperty("tax3AmountNativeCurrency")]
        public double? Tax3AmountNativeCurrency { get; set; }

        [JsonProperty("tax4Amount")]
        public double? Tax4Amount { get; set; }

        [JsonProperty("tax4AmountNativeCurrency")]
        public double? Tax4AmountNativeCurrency { get; set; }

        [JsonProperty("amountNonTaxable")]
        public double? AmountNonTaxable { get; set; }

        [JsonProperty("amountNonTaxableNativeCurrency")]
        public double? AmountNonTaxableNativeCurrency { get; set; }

        [JsonProperty("amountTaxable")]
        public double? AmountTaxable { get; set; }

        [JsonProperty("amountTaxableNativeCurrency")]
        public double? AmountTaxableNativeCurrency { get; set; }

        [JsonProperty("amountTaxExempt")]
        public double? AmountTaxExempt { get; set; }

        [JsonProperty("amountTaxExemptNativeCurrency")]
        public double? AmountTaxExemptNativeCurrency { get; set; }

        [JsonProperty("stateTaxCode")]
        public string? StateTaxCode { get; set; }

        [JsonProperty("stateTaxRate")]
        public double? StateTaxRate { get; set; }

        [JsonProperty("countyTaxCode")]
        public string? CountyTaxCode { get; set; }

        [JsonProperty("countyTaxRate")]
        public double? CountyTaxRate { get; set; }

        [JsonProperty("tax3Code")]
        public string? Tax3Code { get; set; }

        [JsonProperty("tax3Rate")]
        public double? Tax3Rate { get; set; }

        [JsonProperty("tax4Code")]
        public string? Tax4Code { get; set; }

        [JsonProperty("tax4Rate")]
        public double? Tax4Rate { get; set; }

        [JsonProperty("createJobscopeUserId")]
        public int? CreateJobscopeUserId { get; set; }

        [JsonProperty("createDate")]
        public DateTime? CreateDate { get; set; }

        [JsonProperty("modifyJobscopeUserId")]
        public int? ModifyJobscopeUserId { get; set; }

        [JsonProperty("modifyDate")]
        public DateTime? ModifyDate { get; set; }

    }
}
