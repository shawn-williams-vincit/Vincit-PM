using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vincit.Jobscope.Domain.Entities
{
    public class APInvoice : JobscopeEntity
    {
        [JsonProperty("apInvoiceId")]
        public double? ApInvoiceId { get; set; }

        [JsonProperty("invoiceNumber")]
        public string? InvoiceNumber { get; set; }

        [JsonProperty("paymentStatusCode")]
        public string? PaymentStatusCode { get; set; }

        [JsonProperty("purchaseOrderNumber")]
        public string? PurchaseOrderNumber { get; set; }

        [JsonProperty("vendorNumber")]
        public string? VendorNumber { get; set; }

        [JsonProperty("account")]
        public string? Account { get; set; }

        [JsonProperty("amountInvoiced")]
        public double? AmountInvoiced { get; set; }

        [JsonProperty("bankCode")]
        public string? BankCode { get; set; }

        [JsonProperty("currencyCode")]
        public string? CurrencyCode { get; set; }

        [JsonProperty("dueDate")]
        public DateTime? DueDate { get; set; }

        [JsonProperty("invoiceDate")]
        public DateTime? InvoiceDate { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("paymentTermsCode")]
        public string? PaymentTermsCode { get; set; }

        [JsonProperty("companyCode")]
        public string? CompanyCode { get; set; }

        [JsonProperty("checkNumber")]
        public string? CheckNumber { get; set; }

        [JsonProperty("accountCredit")]
        public string? AccountCredit { get; set; }

        [JsonProperty("amountDiscount")]
        public double? AmountDiscount { get; set; }

        [JsonProperty("amountPaid")]
        public double? AmountPaid { get; set; }

        [JsonProperty("amountDiscountCurrency")]
        public double? AmountDiscountCurrency { get; set; }

        [JsonProperty("amountDiscountable")]
        public double? AmountDiscountable { get; set; }

        [JsonProperty("amountInvoicedCurrency")]
        public double? AmountInvoicedCurrency { get; set; }

        [JsonProperty("amountPaidCurrency")]
        public double? AmountPaidCurrency { get; set; }

        [JsonProperty("batchItem")]
        public string? BatchItem { get; set; }

        [JsonProperty("batchNumber")]
        public int? BatchNumber { get; set; }

        [JsonProperty("countryOrigin")]
        public string? CountryOrigin { get; set; }

        [JsonProperty("csPeriod")]
        public string? CsPeriod { get; set; }

        [JsonProperty("checkDate")]
        public DateTime? CheckDate { get; set; }

        [JsonProperty("dateEntered")]
        public DateTime? DateEntered { get; set; }

        [JsonProperty("paidDate")]
        public DateTime? PaidDate { get; set; }

        [JsonProperty("voucheredDate")]
        public DateTime? VoucheredDate { get; set; }

        [JsonProperty("deliveryTerms")]
        public string? DeliveryTerms { get; set; }

        [JsonProperty("amountDiscountableCurrency")]
        public double? AmountDiscountableCurrency { get; set; }

        [JsonProperty("employeeNumberPaid")]
        public string? EmployeeNumberPaid { get; set; }

        [JsonProperty("employeeNumberVouchered")]
        public string? EmployeeNumberVouchered { get; set; }

        [JsonProperty("exchangeRate")]
        public double? ExchangeRate { get; set; }

        [JsonProperty("purchaseOrderItem")]
        public string? PurchaseOrderItem { get; set; }

        [JsonProperty("netAmountDue")]
        public double? NetAmountDue { get; set; }

        [JsonProperty("netAmountDueCurrency")]
        public double? NetAmountDueCurrency { get; set; }

        [JsonProperty("periodYYYYMM")]
        public string? PeriodYYYYMM { get; set; }

        [JsonProperty("invoiceStatus")]
        public string? InvoiceStatus { get; set; }

        [JsonProperty("timeEntered")]
        public string? TimeEntered { get; set; }

        [JsonProperty("transactionCode")]
        public string? TransactionCode { get; set; }

        [JsonProperty("transportCode")]
        public string? TransportCode { get; set; }

        [JsonProperty("isMatchedReceiving")]
        public bool IsMatchedReceiving { get; set; }

        [JsonProperty("batchNumberPaid")]
        public int? BatchNumberPaid { get; set; }

        [JsonProperty("batchItemPaid")]
        public string? BatchItemPaid { get; set; }

        [JsonProperty("is1099Required")]
        public bool Is1099Required { get; set; }

        [JsonProperty("apWithholdPaymentReasonId")]
        public int? ApWithholdPaymentReasonId { get; set; }

        [JsonProperty("withHoldPayment")]
        public bool WithHoldPayment { get; set; }

        [JsonProperty("statusDate")]
        public DateTime? StatusDate { get; set; }

        [JsonProperty("checkPaymentStatus")]
        public string? CheckPaymentStatus { get; set; }

        [JsonProperty("checkAmountPaid")]
        public double? CheckAmountPaid { get; set; }

        [JsonProperty("bankReconciliationId")]
        public int? BankReconciliationId { get; set; }

        [JsonProperty("reconciliationStatus")]
        public string? ReconciliationStatus { get; set; }

        [JsonProperty("payToName")]
        public string? PayToName { get; set; }

        [JsonProperty("payToAddressLine1")]
        public string? PayToAddressLine1 { get; set; }

        [JsonProperty("payToAddressLine2")]
        public string? PayToAddressLine2 { get; set; }

        [JsonProperty("payToAddressLine3")]
        public string? PayToAddressLine3 { get; set; }

        [JsonProperty("payToCity")]
        public string? PayToCity { get; set; }

        [JsonProperty("payToCountry")]
        public string? PayToCountry { get; set; }

        [JsonProperty("payToPostalCode")]
        public string? PayToPostalCode { get; set; }

        [JsonProperty("payToState")]
        public string? PayToState { get; set; }

        [JsonProperty("ipcheckId")]
        public int? IpcheckId { get; set; }

        [JsonProperty("createJobscopeUserId")]
        public int? CreateJobscopeUserId { get; set; }

        [JsonProperty("createDate")]
        public DateTime? CreateDate { get; set; }

        [JsonProperty("modifyJobscopeUserId")]
        public int? ModifyJobscopeUserId { get; set; }

        [JsonProperty("modifyDate")]
        public DateTime? ModifyDate { get; set; }

        [JsonProperty("userDefinedFields")]
        public List<APInvoice_UserDefinedField>? UserDefinedFields { get; set; }
    }

    public class APInvoice_UserDefinedField
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
