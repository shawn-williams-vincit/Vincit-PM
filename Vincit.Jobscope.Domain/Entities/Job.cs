namespace Vincit.Jobscope.Domain.Entities;

public class Job : JobscopeEntity
{
    public string? JobNumber { get; set; }              //
    //public string? DivisionID { get; set; }
    public decimal? JobID { get; set; }                 //
    //public string? CustomerNumber { get; set; }         //
    //public string? AddressLine1 { get; set; }
    //public string? AddressLine2 { get; set; }
    //public string? AddressLine3 { get; set; }
    //public string? Attention { get; set; }
    //public string? BillCode { get; set; }
    //public string? BillToSite { get; set; }
    //public bool BudgetByRelease { get; set; }
    //public string? CanadianTaxExemptFed { get; set; }
    //public string? CanadianTaxExemptProv { get; set; }
    //public string? CarrierAccount { get; set; }
    //public string? City { get; set; }
    //public string? PendingCloseRestrictStatus { get; set; }
    //public decimal? CommissionRate { get; set; }
    //public string? CompanyCode { get; set; }
    //public string? ContractJob { get; set; }
    //public decimal? ContractReleaseLineItemId { get; set; }
    public decimal? CostApplied { get; set; }                   //
    //public decimal? CostAppliedPeriod { get; set; }             //
    //public decimal? CostAppliedYTD { get; set; }
    //public string? Country { get; set; }
    //public string? CumNumber { get; set; }
    //public string? CurrencyCode { get; set; }
    //public string? CustomerName { get; set; }                   //
    //public string? CustomerPoNumber { get; set; }               //
    //public string? CustomerPOItem { get; set; }                 //
    //public DateTime? DateComplete { get; set; }                 //
    //public DateTime? DateDue { get; set; }                      //
    //public DateTime? DatePo { get; set; }                       //
    //public DateTime? DateSent { get; set; }                     //
    //public string? Description { get; set; }                    //
    public decimal? EarnedRevenue { get; set; }                 //
    //public decimal? EarnedRevenuePeriod { get; set; }           //
    //public decimal? EarnedRevenueYTD { get; set; }              //
    //public decimal? EngineeringActual { get; set; }             //
    public decimal? EngineeringCostApplied { get; set; }        //
    //public decimal? EngineeringOverheadActual { get; set; }     //
    //public decimal? EngineeringOverheadCostApplied { get; set; }    //
    //public decimal? EngrHoursActual { get; set; }               //
    //public decimal? EngrHoursEarned { get; set; }               //
    //public decimal? EngrHoursEstimated { get; set; }            //
    //public DateTime? EstimatedCompletionDate { get; set; }      //
    //public string? EstimatedTime { get; set; }                  //
    //public decimal? ExchangeRate { get; set; }
    //public decimal? FobBilling { get; set; }
    //public string? FobPoint { get; set; }
    //public decimal? FreightBilling { get; set; }
    //public string? GovernmentContract { get; set; }
    //public string? GroupCode { get; set; }
    //public bool IsAssembleOpen { get; set; }
    //public bool IsComplete { get; set; }
    //public bool IsDisAssembleOpen { get; set; }
    //public bool IsRepair { get; set; }
    //public bool IsRepairOpen { get; set; }
    //public string? JobReference { get; set; }
    public string? JobTitle { get; set; }
    //public decimal? LaborActual { get; set; }
    //public decimal? LaborBudgetOriginalHourlyHours { get; set; }
    //public decimal? LaborBudgetOriginalSalariedHours { get; set; }
    public decimal? LaborBudgetOriginalHourlyCost { get; set; }
    public decimal? LaborBudgetOriginalSalariedCost { get; set; }
    //public decimal? LaborBudgetRevisedHourlyHours { get; set; }
    //public decimal? LaborBudgetRevisedSalariedHours { get; set; }
    public decimal? LaborBudgetRevisedHourlyCost { get; set; }
    public decimal? LaborBudgetRevisedSalariedCost { get; set; }
    //public string? LaborCostType { get; set; }
    public decimal? LaborCostApplied { get; set; }
    //public decimal? LaborHoursActual { get; set; }
    //public decimal? LaborHoursEarned { get; set; }
    //public decimal? LaborHoursEstimated { get; set; }
    //public decimal? LaborOverheadActual { get; set; }
    public decimal? LaborOverheadCostApplied { get; set; }
    //public string? LanguageCode { get; set; }
    //public decimal? MaterialActual { get; set; }
    public decimal? MaterialCostApplied { get; set; }
    //public decimal? MaterialOverheadActual { get; set; }
    public decimal? MaterialOverheadCostApplied { get; set; }
    //public string? Memo { get; set; }
    //public decimal? MfsEngineeringHoursActual { get; set; }
    //public decimal? MfsLaborHoursActual { get; set; }
    //public string? Model { get; set; }
    //public string? PartNumberSentToCustomer { get; set; }
    //public string? PartNumberToReturn { get; set; }
    public decimal? PercentComplete { get; set; }
    //public string? PercentType { get; set; }
    //public string? PrepaidCollect { get; set; }
    public decimal? PriceActual { get; set; }
    public decimal? CurrentSellingPrice { get; set; }
    public decimal? OriginalSellingPrice { get; set; }
    //public string? ProductLine { get; set; }
    public string? ProjectManager { get; set; }
    //public string? ReceivingOrderNumber { get; set; }
    //public string? RecordType { get; set; }
    //public string? Reference { get; set; }
    public string? Routing { get; set; }
    //public string? SalesAgent1 { get; set; }
    //public decimal? SalesAgent1Percentage { get; set; }
    //public string? SalesAgent2 { get; set; }
    //public decimal? SalesAgent2Percentage { get; set; }
    //public string? SalesAgent3 { get; set; }
    //public decimal? SalesAgent3Percentage { get; set; }
    //public string? SentBy { get; set; }
    //public string? ShipToSite { get; set; }
    //public string? ShipToName { get; set; }
    //public string? ShipToAddressLine1 { get; set; }
    //public string? ShipToAddressLine2 { get; set; }
    //public string? ShipToAddressLine3 { get; set; }
    //public string? ShipToCity { get; set; }
    //public string? ShipToState { get; set; }
    //public string? ShipToPostalCode { get; set; }
    //public string? ShipToCountry { get; set; }
    //public string? State { get; set; }
    //public decimal? SubcontractingActual { get; set; }
    //public decimal? SubcontractingCostApplied { get; set; }
    //public string? TaxExemptNumber1 { get; set; }
    //public string? TaxExemptNumber2 { get; set; }
    //public string? PaymentTermsCode { get; set; }
    public decimal? TotalActual { get; set; }
    public decimal? TotalEngineeringActual { get; set; }
    public decimal? TotalLaborAmountActual { get; set; }
    public decimal? TotalCurrEarned { get; set; }
    //public decimal? TotalPeriods { get; set; }
    //public decimal? TotalSalesScheduled { get; set; }
    //public string? UserText { get; set; }
    //public bool WaitingCustomerReturn { get; set; }
    //public string? WipCode { get; set; }
    //public string? PostalCode { get; set; }
    //public string? Incoterms { get; set; }
    //public int WarrantyMonths { get; set; }
    //public int CreateJobscopeUserId { get; set; }
    //public DateTime? CreateDate { get; set; }
    //public int ModifyJobscopeUserId { get; set; }
    //public DateTime? ModifyDate { get; set; }

}
