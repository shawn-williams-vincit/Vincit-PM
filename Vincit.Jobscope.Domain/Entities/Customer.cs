using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vincit.Jobscope.Domain.Entities
{
    public class Customer : JobscopeEntity
    {
        [JsonProperty("customerId")]
        public double? CustomerId { get; set; }

        [JsonProperty("customerNumber")]
        public string? CustomerNumber { get; set; }

        [JsonProperty("abbreviation")]
        public string? Abbreviation { get; set; }

        [JsonProperty("addressLine1")]
        public string? AddressLine1 { get; set; }

        [JsonProperty("addressLine2")]
        public string? AddressLine2 { get; set; }

        [JsonProperty("addressLine3")]
        public string? AddressLine3 { get; set; }

        [JsonProperty("agreement")]
        public string? Agreement { get; set; }

        [JsonProperty("attention")]
        public string? Attention { get; set; }

        [JsonProperty("billCode")]
        public string? BillCode { get; set; }

        [JsonProperty("canadianTaxExemptFed")]
        public string? CanadianTaxExemptFed { get; set; }

        [JsonProperty("canadianTaxExemptProv")]
        public string? CanadianTaxExemptProv { get; set; }

        [JsonProperty("chargeVAT")]
        public bool? ChargeVAT { get; set; }

        [JsonProperty("city")]
        public string? City { get; set; }

        [JsonProperty("companyCode")]
        public string? CompanyCode { get; set; }

        [JsonProperty("country")]
        public string? Country { get; set; }

        [JsonProperty("creditLimit")]
        public double? CreditLimit { get; set; }

        [JsonProperty("currencyCode")]
        public string? CurrencyCode { get; set; }

        [JsonProperty("customerCreditHoldReasonId")]
        public int? CustomerCreditHoldReasonId { get; set; }

        [JsonProperty("customerName")]
        public string? CustomerName { get; set; }

        [JsonProperty("customerWebsiteURL")]
        public string? CustomerWebsiteURL { get; set; }

        [JsonProperty("customerUserClassificationCode")]
        public string? CustomerUserClassificationCode { get; set; }

        [JsonProperty("discountPercent")]
        public double? DiscountPercent { get; set; }

        [JsonProperty("faxNumber")]
        public string? FaxNumber { get; set; }

        [JsonProperty("fobPoint")]
        public string? FobPoint { get; set; }

        [JsonProperty("groupCode")]
        public string? GroupCode { get; set; }

        [JsonProperty("industryType")]
        public string? IndustryType { get; set; }

        [JsonProperty("isActive")]
        public bool? IsActive { get; set; }

        [JsonProperty("isOnRestrictedList")]
        public bool? IsOnRestrictedList { get; set; }

        [JsonProperty("memo")]
        public string? Memo { get; set; }

        [JsonProperty("onCreditHold")]
        public bool? OnCreditHold { get; set; }

        [JsonProperty("onCreditWatch")]
        public bool? OnCreditWatch { get; set; }

        [JsonProperty("orderEntryHoldFlag")]
        public bool? OrderEntryHoldFlag { get; set; }

        [JsonProperty("paymentTermsCode")]
        public string? PaymentTermsCode { get; set; }

        [JsonProperty("phoneNumber")]
        public string? PhoneNumber { get; set; }

        [JsonProperty("postalCode")]
        public string? PostalCode { get; set; }

        [JsonProperty("prepaidCollect")]
        public string? PrepaidCollect { get; set; }

        [JsonProperty("projectManager")]
        public string? ProjectManager { get; set; }

        [JsonProperty("prospect")]
        public bool? Prospect { get; set; }

        [JsonProperty("reference")]
        public string? Reference { get; set; }

        [JsonProperty("reviewDate")]
        public DateTime? ReviewDate { get; set; }

        [JsonProperty("routing")]
        public string? Routing { get; set; }

        [JsonProperty("salesAgent")]
        public string? SalesAgent { get; set; }

        [JsonProperty("salesAgent2")]
        public string? SalesAgent2 { get; set; }

        [JsonProperty("salesAgent3")]
        public string? SalesAgent3 { get; set; }

        [JsonProperty("serviceChargeFlag")]
        public bool? ServiceChargeFlag { get; set; }

        [JsonProperty("shippingHoldFlag")]
        public bool? ShippingHoldFlag { get; set; }

        [JsonProperty("shipToSameAsBillTo")]
        public bool? ShipToSameAsBillTo { get; set; }

        [JsonProperty("state")]
        public string? State { get; set; }

        [JsonProperty("statementFlag")]
        public string? StatementFlag { get; set; }

        [JsonProperty("taxPercentageCode1")]
        public string? TaxPercentageCode1 { get; set; }

        [JsonProperty("taxPercentageCode2")]
        public string? TaxPercentageCode2 { get; set; }

        [JsonProperty("taxPercentageCode3")]
        public string? TaxPercentageCode3 { get; set; }

        [JsonProperty("taxPercentageCode4")]
        public string? TaxPercentageCode4 { get; set; }

        [JsonProperty("taxExemptNumber1")]
        public string? TaxExemptNumber1 { get; set; }

        [JsonProperty("taxExemptNumber2")]
        public string? TaxExemptNumber2 { get; set; }

        [JsonProperty("vatCodeRegistrationNumber")]
        public string? VatCodeRegistrationNumber { get; set; }

        [JsonProperty("vatCountryCode")]
        public string? VatCountryCode { get; set; }

        [JsonProperty("wipCode")]
        public string? WipCode { get; set; }

        [JsonProperty("workOrderHoldFlag")]
        public bool? WorkOrderHoldFlag { get; set; }

        [JsonProperty("createJobscopeUserId")]
        public int? CreateJobscopeUserId { get; set; }

        [JsonProperty("createDate")]
        public DateTime? CreateDate { get; set; }

        [JsonProperty("modifyJobscopeUserId")]
        public int? ModifyJobscopeUserId { get; set; }

        [JsonProperty("modifyDate")]
        public DateTime? ModifyDate { get; set; }

        [JsonProperty("userDefinedFields")]
        public List<Customer_UserDefinedField>? UserDefinedFields { get; set; }
    }

    public class Customer_UserDefinedField
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
