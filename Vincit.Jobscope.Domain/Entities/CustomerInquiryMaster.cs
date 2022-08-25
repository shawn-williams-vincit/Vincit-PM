using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vincit.Jobscope.Domain.Entities
{
    public class CustomerInquiryMaster : JobscopeEntity
    {
        [JsonProperty("customerInquiryMasterId")]
        public double? CustomerInquiryMasterId { get; set; }

        [JsonProperty("divisionId")]
        public string? DivisionId { get; set; }

        [JsonProperty("customerInquiryNumber")]
        public string? CustomerInquiryNumber { get; set; }

        [JsonProperty("billCode")]
        public string? BillCode { get; set; }

        [JsonProperty("billToAddressLine1")]
        public string? BillToAddressLine1 { get; set; }

        [JsonProperty("billToAddressLine2")]
        public string? BillToAddressLine2 { get; set; }

        [JsonProperty("billToAddressLine3")]
        public string? BillToAddressLine3 { get; set; }

        [JsonProperty("billToCity")]
        public string? BillToCity { get; set; }

        [JsonProperty("billToCountry")]
        public string? BillToCountry { get; set; }

        [JsonProperty("billToName")]
        public string? BillToName { get; set; }

        [JsonProperty("billToPostalCode")]
        public string? BillToPostalCode { get; set; }

        [JsonProperty("billToState")]
        public string? BillToState { get; set; }

        [JsonProperty("comment")]
        public string? Comment { get; set; }

        [JsonProperty("commission")]
        public double? Commission { get; set; }

        [JsonProperty("companyCode")]
        public string? CompanyCode { get; set; }

        [JsonProperty("contact")]
        public string? Contact { get; set; }

        [JsonProperty("currencyCode")]
        public string? CurrencyCode { get; set; }

        [JsonProperty("customerBillToSite")]
        public string? CustomerBillToSite { get; set; }

        [JsonProperty("customerName")]
        public string? CustomerName { get; set; }

        [JsonProperty("customerNumber")]
        public string? CustomerNumber { get; set; }

        [JsonProperty("customerPurchaseOrder")]
        public string? CustomerPurchaseOrder { get; set; }

        [JsonProperty("customerShipToSite")]
        public string? CustomerShipToSite { get; set; }

        [JsonProperty("dateClosed")]
        public DateTime? DateClosed { get; set; }

        [JsonProperty("dueDate")]
        public DateTime? DueDate { get; set; }

        [JsonProperty("eMailAddress")]
        public string? EMailAddress { get; set; }

        [JsonProperty("exchangeRate")]
        public double? ExchangeRate { get; set; }

        [JsonProperty("expectedOrderDate")]
        public DateTime? ExpectedOrderDate { get; set; }

        [JsonProperty("faxNumber")]
        public string? FaxNumber { get; set; }

        [JsonProperty("firstName")]
        public string? FirstName { get; set; }

        [JsonProperty("groupCode")]
        public string? GroupCode { get; set; }

        [JsonProperty("inquiryCloseReason")]
        public string? InquiryCloseReason { get; set; }

        [JsonProperty("inquiryDate")]
        public DateTime? InquiryDate { get; set; }

        [JsonProperty("inquiryStatus")]
        public string? InquiryStatus { get; set; }

        [JsonProperty("inquiryTitle")]
        public string? InquiryTitle { get; set; }

        [JsonProperty("isClosed")]
        public bool? IsClosed { get; set; }

        [JsonProperty("phoneNumber")]
        public string? PhoneNumber { get; set; }

        [JsonProperty("poDate")]
        public DateTime? PoDate { get; set; }

        [JsonProperty("position")]
        public string? Position { get; set; }

        [JsonProperty("probability")]
        public double? Probability { get; set; }

        [JsonProperty("productLine")]
        public string? ProductLine { get; set; }

        [JsonProperty("promisedDate")]
        public DateTime? PromisedDate { get; set; }

        [JsonProperty("quoteCompleteDate")]
        public DateTime? QuoteCompleteDate { get; set; }

        [JsonProperty("reference")]
        public string? Reference { get; set; }

        [JsonProperty("releaseNumber")]
        public string? ReleaseNumber { get; set; }

        [JsonProperty("revisedPromisedDate")]
        public DateTime? RevisedPromisedDate { get; set; }

        [JsonProperty("routing")]
        public string? Routing { get; set; }

        [JsonProperty("salesAgent1")]
        public string? SalesAgent1 { get; set; }

        [JsonProperty("salesAgent1Percentage")]
        public double? SalesAgent1Percentage { get; set; }

        [JsonProperty("salesAgent2")]
        public string? SalesAgent2 { get; set; }

        [JsonProperty("salesAgent2Percentage")]
        public double? SalesAgent2Percentage { get; set; }

        [JsonProperty("salesAgent3")]
        public string? SalesAgent3 { get; set; }

        [JsonProperty("salesAgent3Percentage")]
        public double? SalesAgent3Percentage { get; set; }

        [JsonProperty("shipAddressLine1")]
        public string? ShipAddressLine1 { get; set; }

        [JsonProperty("shipAddressLine2")]
        public string? ShipAddressLine2 { get; set; }

        [JsonProperty("shipAddressLine3")]
        public string? ShipAddressLine3 { get; set; }

        [JsonProperty("shipCity")]
        public string? ShipCity { get; set; }

        [JsonProperty("shipCountry")]
        public string? ShipCountry { get; set; }

        [JsonProperty("shipCustomerName")]
        public string? ShipCustomerName { get; set; }

        [JsonProperty("shipDate")]
        public DateTime? ShipDate { get; set; }

        [JsonProperty("shipPostalCode")]
        public string? ShipPostalCode { get; set; }

        [JsonProperty("shipState")]
        public string? ShipState { get; set; }

        [JsonProperty("soldToSiteID")]
        public double? SoldToSiteID { get; set; }

        [JsonProperty("tax1")]
        public double? Tax1 { get; set; }

        [JsonProperty("tax2")]
        public double? Tax2 { get; set; }

        [JsonProperty("taxableAmount1")]
        public double? TaxableAmount1 { get; set; }

        [JsonProperty("taxableAmount1Native")]
        public double? TaxableAmount1Native { get; set; }

        [JsonProperty("taxableAmount2")]
        public double? TaxableAmount2 { get; set; }

        [JsonProperty("taxableAmount2Native")]
        public double? TaxableAmount2Native { get; set; }

        [JsonProperty("paymentTermsCode")]
        public string? PaymentTermsCode { get; set; }

        [JsonProperty("title")]
        public string? Title { get; set; }

        [JsonProperty("totalInquiryCost")]
        public double? TotalInquiryCost { get; set; }

        [JsonProperty("totalInquiryPrice")]
        public double? TotalInquiryPrice { get; set; }

        [JsonProperty("totalInquiryPriceNative")]
        public double? TotalInquiryPriceNative { get; set; }

        [JsonProperty("totalInquiryWeight")]
        public double? TotalInquiryWeight { get; set; }

        [JsonProperty("userText")]
        public string? UserText { get; set; }

        [JsonProperty("isActive")]
        public bool? IsActive { get; set; }

        [JsonProperty("createJobscopeUserId")]
        public int? CreateJobscopeUserId { get; set; }

        [JsonProperty("createDate")]
        public DateTime? CreateDate { get; set; }

        [JsonProperty("modifyJobscopeUserId")]
        public int? ModifyJobscopeUserId { get; set; }

        [JsonProperty("modifyDate")]
        public DateTime? ModifyDate { get; set; }

        [JsonProperty("userDefinedFields")]
        public List<CustomerInquiryMaster_UserDefinedField>? UserDefinedFields { get; set; }
    }

    public class CustomerInquiryMaster_UserDefinedField
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
