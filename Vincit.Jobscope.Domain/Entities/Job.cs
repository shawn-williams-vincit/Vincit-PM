using Newtonsoft.Json;

namespace Vincit.Jobscope.Domain.Entities;

public class Job : JobscopeEntity
{
    [JsonProperty("jobNumber")]
    public string? JobNumber { get; set; }

    [JsonProperty("divisionID")]
    public string? DivisionID { get; set; }

    [JsonProperty("jobID")]
    public double? JobID { get; set; }

    [JsonProperty("customerNumber")]
    public string? CustomerNumber { get; set; }

    [JsonProperty("addressLine1")]
    public string? AddressLine1 { get; set; }

    [JsonProperty("addressLine2")]
    public string? AddressLine2 { get; set; }

    [JsonProperty("addressLine3")]
    public string? AddressLine3 { get; set; }

    [JsonProperty("attention")]
    public string? Attention { get; set; }

    [JsonProperty("billCode")]
    public string? BillCode { get; set; }

    [JsonProperty("billToSite")]
    public string? BillToSite { get; set; }

    [JsonProperty("budgetByRelease")]
    public bool? BudgetByRelease { get; set; }

    [JsonProperty("canadianTaxExemptFed")]
    public string? CanadianTaxExemptFed { get; set; }

    [JsonProperty("canadianTaxExemptProv")]
    public string? CanadianTaxExemptProv { get; set; }

    [JsonProperty("carrierAccount")]
    public string? CarrierAccount { get; set; }

    [JsonProperty("city")]
    public string? City { get; set; }

    [JsonProperty("pendingCloseRestrictStatus")]
    public string? PendingCloseRestrictStatus { get; set; }

    [JsonProperty("commissionRate")]
    public double? CommissionRate { get; set; }

    [JsonProperty("companyCode")]
    public string? CompanyCode { get; set; }

    [JsonProperty("contractJob")]
    public string? ContractJob { get; set; }

    [JsonProperty("contractReleaseLineItemId")]
    public double? ContractReleaseLineItemId { get; set; }

    [JsonProperty("costApplied")]
    public double? CostApplied { get; set; }

    [JsonProperty("costAppliedPeriod")]
    public double? CostAppliedPeriod { get; set; }

    [JsonProperty("costAppliedYTD")]
    public double? CostAppliedYTD { get; set; }

    [JsonProperty("country")]
    public string? Country { get; set; }

    [JsonProperty("cumNumber")]
    public string? CumNumber { get; set; }

    [JsonProperty("currencyCode")]
    public string? CurrencyCode { get; set; }

    [JsonProperty("customerName")]
    public string? CustomerName { get; set; }

    [JsonProperty("customerPoNumber")]
    public string? CustomerPoNumber { get; set; }

    [JsonProperty("customerPOItem")]
    public string? CustomerPOItem { get; set; }

    [JsonProperty("dateComplete")]
    public DateTime? DateComplete { get; set; }

    [JsonProperty("dateDue")]
    public DateTime? DateDue { get; set; }

    [JsonProperty("datePo")]
    public DateTime? DatePo { get; set; }

    [JsonProperty("dateSent")]
    public DateTime? DateSent { get; set; }

    [JsonProperty("description")]
    public string? Description { get; set; }

    [JsonProperty("earnedRevenue")]
    public double? EarnedRevenue { get; set; }

    [JsonProperty("earnedRevenuePeriod")]
    public double? EarnedRevenuePeriod { get; set; }

    [JsonProperty("earnedRevenueYTD")]
    public double? EarnedRevenueYTD { get; set; }

    [JsonProperty("engineeringActual")]
    public double? EngineeringActual { get; set; }

    [JsonProperty("engineeringCostApplied")]
    public double? EngineeringCostApplied { get; set; }

    [JsonProperty("engineeringOverheadActual")]
    public double? EngineeringOverheadActual { get; set; }

    [JsonProperty("engineeringOverheadCostApplied")]
    public double? EngineeringOverheadCostApplied { get; set; }

    [JsonProperty("engrHoursActual")]
    public double? EngrHoursActual { get; set; }

    [JsonProperty("engrHoursEarned")]
    public double? EngrHoursEarned { get; set; }

    [JsonProperty("engrHoursEstimated")]
    public double? EngrHoursEstimated { get; set; }

    [JsonProperty("estimatedCompletionDate")]
    public DateTime? EstimatedCompletionDate { get; set; }

    [JsonProperty("estimatedTime")]
    public string? EstimatedTime { get; set; }

    [JsonProperty("exchangeRate")]
    public double? ExchangeRate { get; set; }

    [JsonProperty("fobBilling")]
    public double? FobBilling { get; set; }

    [JsonProperty("fobPoint")]
    public string? FobPoint { get; set; }

    [JsonProperty("freightBilling")]
    public double? FreightBilling { get; set; }

    [JsonProperty("governmentContract")]
    public string? GovernmentContract { get; set; }

    [JsonProperty("groupCode")]
    public string? GroupCode { get; set; }

    [JsonProperty("isAssembleOpen")]
    public bool? IsAssembleOpen { get; set; }

    [JsonProperty("isComplete")]
    public bool? IsComplete { get; set; }

    [JsonProperty("isDisAssembleOpen")]
    public bool? IsDisAssembleOpen { get; set; }

    [JsonProperty("isRepair")]
    public bool? IsRepair { get; set; }

    [JsonProperty("isRepairOpen")]
    public bool? IsRepairOpen { get; set; }

    [JsonProperty("jobReference")]
    public string? JobReference { get; set; }

    [JsonProperty("jobTitle")]
    public string? JobTitle { get; set; }

    [JsonProperty("laborActual")]
    public double? LaborActual { get; set; }

    [JsonProperty("laborBudgetOriginalHourlyHours")]
    public double? LaborBudgetOriginalHourlyHours { get; set; }

    [JsonProperty("laborBudgetOriginalSalariedHours")]
    public double? LaborBudgetOriginalSalariedHours { get; set; }

    [JsonProperty("laborBudgetOriginalHourlyCost")]
    public double? LaborBudgetOriginalHourlyCost { get; set; }

    [JsonProperty("laborBudgetOriginalSalariedCost")]
    public double? LaborBudgetOriginalSalariedCost { get; set; }

    [JsonProperty("laborBudgetRevisedHourlyHours")]
    public double? LaborBudgetRevisedHourlyHours { get; set; }

    [JsonProperty("laborBudgetRevisedSalariedHours")]
    public double? LaborBudgetRevisedSalariedHours { get; set; }

    [JsonProperty("laborBudgetRevisedHourlyCost")]
    public double? LaborBudgetRevisedHourlyCost { get; set; }

    [JsonProperty("laborBudgetRevisedSalariedCost")]
    public double? LaborBudgetRevisedSalariedCost { get; set; }

    [JsonProperty("laborCostType")]
    public string? LaborCostType { get; set; }

    [JsonProperty("laborCostApplied")]
    public double? LaborCostApplied { get; set; }

    [JsonProperty("laborHoursActual")]
    public double? LaborHoursActual { get; set; }

    [JsonProperty("laborHoursEarned")]
    public double? LaborHoursEarned { get; set; }

    [JsonProperty("laborHoursEstimated")]
    public double? LaborHoursEstimated { get; set; }

    [JsonProperty("laborOverheadActual")]
    public double? LaborOverheadActual { get; set; }

    [JsonProperty("laborOverheadCostApplied")]
    public double? LaborOverheadCostApplied { get; set; }

    [JsonProperty("languageCode")]
    public string? LanguageCode { get; set; }

    [JsonProperty("materialActual")]
    public double? MaterialActual { get; set; }

    [JsonProperty("materialCostApplied")]
    public double? MaterialCostApplied { get; set; }

    [JsonProperty("materialOverheadActual")]
    public double? MaterialOverheadActual { get; set; }

    [JsonProperty("materialOverheadCostApplied")]
    public double? MaterialOverheadCostApplied { get; set; }

    [JsonProperty("memo")]
    public string? Memo { get; set; }

    [JsonProperty("mfsEngineeringHoursActual")]
    public double? MfsEngineeringHoursActual { get; set; }

    [JsonProperty("mfsLaborHoursActual")]
    public double? MfsLaborHoursActual { get; set; }

    [JsonProperty("model")]
    public string? Model { get; set; }

    [JsonProperty("partNumberSentToCustomer")]
    public string? PartNumberSentToCustomer { get; set; }

    [JsonProperty("partNumberToReturn")]
    public string? PartNumberToReturn { get; set; }

    [JsonProperty("percentComplete")]
    public double? PercentComplete { get; set; }

    [JsonProperty("percentType")]
    public string? PercentType { get; set; }

    [JsonProperty("prepaidCollect")]
    public string? PrepaidCollect { get; set; }

    [JsonProperty("priceActual")]
    public double? PriceActual { get; set; }

    [JsonProperty("currentSellingPrice")]
    public double? CurrentSellingPrice { get; set; }

    [JsonProperty("originalSellingPrice")]
    public double? OriginalSellingPrice { get; set; }

    [JsonProperty("productLine")]
    public string? ProductLine { get; set; }

    [JsonProperty("projectManager")]
    public string? ProjectManager { get; set; }

    [JsonProperty("receivingOrderNumber")]
    public string? ReceivingOrderNumber { get; set; }

    [JsonProperty("recordType")]
    public string? RecordType { get; set; }

    [JsonProperty("reference")]
    public string? Reference { get; set; }

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

    [JsonProperty("sentBy")]
    public string? SentBy { get; set; }

    [JsonProperty("shipToSite")]
    public string? ShipToSite { get; set; }

    [JsonProperty("shipToName")]
    public string? ShipToName { get; set; }

    [JsonProperty("shipToAddressLine1")]
    public string? ShipToAddressLine1 { get; set; }

    [JsonProperty("shipToAddressLine2")]
    public string? ShipToAddressLine2 { get; set; }

    [JsonProperty("shipToAddressLine3")]
    public string? ShipToAddressLine3 { get; set; }

    [JsonProperty("shipToCity")]
    public string? ShipToCity { get; set; }

    [JsonProperty("shipToState")]
    public string? ShipToState { get; set; }

    [JsonProperty("shipToPostalCode")]
    public string? ShipToPostalCode { get; set; }

    [JsonProperty("shipToCountry")]
    public string? ShipToCountry { get; set; }

    [JsonProperty("state")]
    public string? State { get; set; }

    [JsonProperty("subcontractingActual")]
    public double? SubcontractingActual { get; set; }

    [JsonProperty("subcontractingCostApplied")]
    public double? SubcontractingCostApplied { get; set; }

    [JsonProperty("taxExemptNumber1")]
    public string? TaxExemptNumber1 { get; set; }

    [JsonProperty("taxExemptNumber2")]
    public string?TaxExemptNumber2 { get; set; }

    [JsonProperty("paymentTermsCode")]
    public string?PaymentTermsCode { get; set; }

    [JsonProperty("totalActual")]
    public double? TotalActual { get; set; }

    [JsonProperty("totalEngineeringActual")]
    public double? TotalEngineeringActual { get; set; }

    [JsonProperty("totalLaborAmountActual")]
    public double? TotalLaborAmountActual { get; set; }

    [JsonProperty("totalCurrEarned")]
    public double? TotalCurrEarned { get; set; }

    [JsonProperty("totalPeriods")]
    public double? TotalPeriods { get; set; }

    [JsonProperty("totalSalesScheduled")]
    public double? TotalSalesScheduled { get; set; }

    [JsonProperty("userText")]
    public string?UserText { get; set; }

    [JsonProperty("waitingCustomerReturn")]
    public bool? WaitingCustomerReturn { get; set; }

    [JsonProperty("wipCode")]
    public string? WipCode { get; set; }

    [JsonProperty("postalCode")]
    public string? PostalCode { get; set; }

    [JsonProperty("incoterms")]
    public string? Incoterms { get; set; }

    [JsonProperty("warrantyMonths")]
    public int? WarrantyMonths { get; set; }

    [JsonProperty("createJobscopeUserId")]
    public int? CreateJobscopeUserId { get; set; }

    [JsonProperty("createDate")]
    public DateTime? CreateDate { get; set; }

    [JsonProperty("modifyJobscopeUserId")]
    public int? ModifyJobscopeUserId { get; set; }

    [JsonProperty("modifyDate")]
    public DateTime? ModifyDate { get; set; }

    [JsonProperty("userDefinedFields")]
    public List<Job_UserDefinedField>? UserDefinedFields { get; set; }

}
public class Job_UserDefinedField
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

