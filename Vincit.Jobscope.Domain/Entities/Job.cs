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
    public double? CostApplied { get; set; }                //Cost Applied to Job

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
    public string? CustomerPoNumber { get; set; }       //Customer PO#

    [JsonProperty("customerPOItem")]
    public string? CustomerPOItem { get; set; }

    [JsonProperty("dateComplete")]
    public DateTime? DateComplete { get; set; }

    [JsonProperty("dateDue")]
    public DateTime? DateDue { get; set; }

    [JsonProperty("datePo")]
    public DateTime? DatePo { get; set; }           //Date PO Issued


    [JsonProperty("dateSent")]
    public DateTime? DateSent { get; set; }

    [JsonProperty("description")]
    public string? Description { get; set; }

    [JsonProperty("earnedRevenue")]
    public double? EarnedRevenue { get; set; }          //Currently Invoiced

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
    public double? EngrHoursActual { get; set; }            //Actual Engineering Hours

    [JsonProperty("engrHoursEarned")]
    public double? EngrHoursEarned { get; set; }            //?

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
    public double? LaborBudgetOriginalHourlyHours { get; set; }     // Sales Original Budget - Hourly Labor Hours

    [JsonProperty("laborBudgetOriginalSalariedHours")]
    public double? LaborBudgetOriginalSalariedHours { get; set; }   // Sales Original Budget - Salaried Labor Hours

    [JsonProperty("laborBudgetOriginalHourlyCost")]
    public double? LaborBudgetOriginalHourlyCost { get; set; }      // Sales Original Budget - Hourly Labor Cost

    [JsonProperty("laborBudgetOriginalSalariedCost")]
    public double? LaborBudgetOriginalSalariedCost { get; set; }    // Sales Original Budget - Salaried Labor Cost

    [JsonProperty("laborBudgetRevisedHourlyHours")]
    public double? LaborBudgetRevisedHourlyHours { get; set; }      // Current Budget - Hourly Labor Hours

    [JsonProperty("laborBudgetRevisedSalariedHours")]
    public double? LaborBudgetRevisedSalariedHours { get; set; }    // Current Budget - Salaried Labor Hours

    [JsonProperty("laborBudgetRevisedHourlyCost")]
    public double? LaborBudgetRevisedHourlyCost { get; set; }       // Current Budget - Hourly Labor Cost

    [JsonProperty("laborBudgetRevisedSalariedCost")]
    public double? LaborBudgetRevisedSalariedCost { get; set; }     // Current Budget - Salaried Labor Cost

    [JsonProperty("laborCostType")]
    public string? LaborCostType { get; set; }

    [JsonProperty("laborCostApplied")]
    public double? LaborCostApplied { get; set; }

    [JsonProperty("laborHoursActual")]
    public double? LaborHoursActual { get; set; }                   // Actual - Hourly Labor Hours

    [JsonProperty("laborHoursEarned")]
    public double? LaborHoursEarned { get; set; }

    [JsonProperty("laborHoursEstimated")]
    public double? LaborHoursEstimated { get; set; }                // Hours Issued

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
    public double? PriceActual { get; set; }                // Actual - Selling Price

    [JsonProperty("currentSellingPrice")]
    public double? CurrentSellingPrice { get; set; }        // Current Budget - Selling Price

    [JsonProperty("originalSellingPrice")]
    public double? OriginalSellingPrice { get; set; }       // Original Budget - Selling Price

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
    public double? TotalActual { get; set; }            // Actual - Total Cost

    [JsonProperty("totalEngineeringActual")]
    public double? TotalEngineeringActual { get; set; } // Actual - Engineering Cost

    [JsonProperty("totalLaborAmountActual")]
    public double? TotalLaborAmountActual { get; set; } // Actual - Labor Cost

    [JsonProperty("totalCurrEarned")]
    public double? TotalCurrEarned { get; set; }        // Current - Total Cost

    [JsonProperty("totalPeriods")]
    public double? TotalPeriods { get; set; }

    [JsonProperty("totalSalesScheduled")]
    public double? TotalSalesScheduled { get; set; }    // Original - Total Cost 

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

public class JobBudget
{

    public JobBudget(Job J)
    {
        //Original
        Original_HourlyLaborCost = J.LaborBudgetOriginalHourlyCost;
        Original_HourlyLaborHours = J.LaborBudgetOriginalHourlyHours;
        
        Original_EngineeringCost = J.LaborBudgetOriginalSalariedCost;
        Original_EngineeringHours = J.LaborBudgetOriginalSalariedHours;

        Original_TotalCost = J.TotalSalesScheduled;
        Original_SellPrice = J.OriginalSellingPrice;

        //Current
        Current_HourlyLaborCost = J.LaborBudgetRevisedHourlyCost;
        Current_HourlyLaborHours = J.LaborBudgetRevisedHourlyHours;

        Current_EngineeringCost = J.LaborBudgetRevisedSalariedCost;
        Current_EngineeringHours = J.LaborBudgetRevisedSalariedHours;
        
        Current_TotalCost = J.TotalCurrEarned;
        Current_SellPrice = J.CurrentSellingPrice;

        //Actual
        Actual_HourlyLaborCost = J.TotalLaborAmountActual;
        Actual_HourlyLaborHours = J.LaborHoursActual;

        Actual_EngineeringCost = J.TotalEngineeringActual;
        Actual_EngineeringHours = J.EngrHoursActual;

        Actual_TotalCost = J.TotalActual;
        Actual_SellPrice = J.PriceActual;

        //Summary
        TotalCostApplied = J.CostApplied;
        TotalInvoiced = J.EarnedRevenue;
        HoursIssued = J.LaborHoursEstimated;


    }

    #region SALES ORIGINAL BUDGET
    public double? Original_HourlyLaborCost { get; }
    public double? Original_HourlyLaborHours { get; }

    public double? Original_EngineeringCost { get; }
    public double? Original_EngineeringHours { get; }

    public double? Original_TotalCost { get; }
    public double? Original_SellPrice { get; }

    public double? Original_MaterialCost 
    {
        get
        {
            return Original_TotalCost - Original_HourlyLaborCost - Original_EngineeringCost;
        } 
    }
    public double? Original_Margin
    {
        get
        {
            return Original_SellPrice - Original_TotalCost;
        }
    }
    public double? Original_MarginPercent
    {
        get
        {
            if(Original_Margin != null && Original_SellPrice != null)
            {
                //Both values must be real
                decimal ToRound = (decimal)(Original_Margin / Original_SellPrice * 100);
                return (double)Math.Round(ToRound, 3, MidpointRounding.AwayFromZero);
            }
            else
            {
                return null;
            }
        }
    }

    #endregion Sales Original Budget END

    #region SALES CURRENT BUDGET
    public double? Current_HourlyLaborCost { get; }
    public double? Current_HourlyLaborHours { get; }

    public double? Current_EngineeringCost { get; }
    public double? Current_EngineeringHours { get; }

    public double? Current_TotalCost { get; }
    public double? Current_SellPrice { get; }

    public double? Current_MaterialCost
    {
        get
        {
            return Current_TotalCost - Current_HourlyLaborCost - Current_EngineeringCost;
        }
    }
    public double? Current_Margin
    {
        get
        {
            return Current_SellPrice - Current_TotalCost;
        }
    }
    public double? Current_MarginPercent
    {
        get
        {
            if(Current_Margin != null && Current_SellPrice != null)
            {
                //Both values must be real
                decimal ToRound = (decimal)(Current_Margin / Current_SellPrice * 100);
                return (double)Math.Round(ToRound, 2, MidpointRounding.AwayFromZero);
            }
            else
            {
                return null;
            }
        }
    }

    #endregion Sales Current Budget

    #region SALES ACTUAL BUDGET
    public double? Actual_HourlyLaborCost { get; }
    public double? Actual_HourlyLaborHours { get; }

    public double? Actual_EngineeringCost { get; }
    public double? Actual_EngineeringHours { get; }

    public double? Actual_TotalCost { get; }
    public double? Actual_SellPrice { get; }

    public double? Actual_MaterialCost
    {
        get
        {
            return Actual_TotalCost - Actual_HourlyLaborCost - Actual_EngineeringCost;
        }
    }
    public double? Actual_Margin
    {
        get
        {
            return Actual_SellPrice - Actual_TotalCost;
        }
    }
    public double? Actual_MarginPercent
    {
        get
        {
            if(Actual_Margin != null && Actual_SellPrice != null)
            {
                //Both values must be real
                decimal ToRound = (decimal)(Actual_Margin / Actual_SellPrice * 100);
                return (double)Math.Round(ToRound, 2, MidpointRounding.AwayFromZero);
            }
            else
            {
                return null;
            }
        }
    }
    #endregion Sales Actual Budget END

    #region LEFT TO SPEND
    public double? LeftToSpend_HourlyLaborCost { get; set; }
    public double? LeftToSpend_EngineeringCost { get; set; }

    public double? LeftToSpend_MaterialCost { get; set; }

    #endregion Left To Spend

    #region OVER/UNDER BUDGET
    public double? OverUnder_HourlyLaborCost
    {
        get
        {
            return Current_HourlyLaborCost - LeftToSpend_HourlyLaborCost - Actual_HourlyLaborCost;
        }
    }
    public double? OverUnder_HourlyLaborHours
    {
        get
        {
            return Current_HourlyLaborHours - LeftToSpend_EngineeringCost - Actual_HourlyLaborHours;
        }
    }
    public double? OverUnder_MaterialCost
    {
        get
        {
            return Current_MaterialCost - LeftToSpend_MaterialCost - Actual_MaterialCost;
        }
    }

    #endregion Over/Under Budget END

    #region OTHER METRICS
    public double? TotalCostApplied { get; }
    public double? TotalInvoiced { get; }
    public double? HoursIssued { get; }
    #endregion Other Metrics END


}



