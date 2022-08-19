using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vincit.Jobscope.Domain.Entities
{
    public class Release : JobscopeEntity
    {
        [JsonProperty("releaseId")]
        public double? ReleaseId { get; set; }

        [JsonProperty("divisionID")]
        public string? DivisionID { get; set; }

        [JsonProperty("releaseNumber")]
        public string? ReleaseNumber { get; set; }

        [JsonProperty("jobNumber")]
        public string? JobNumber { get; set; }

        [JsonProperty("billToSite")]
        public string? BillToSite { get; set; }

        [JsonProperty("burdenDollars")]
        public double? BurdenDollars { get; set; }

        [JsonProperty("canadianTaxExemptFed")]
        public string? CanadianTaxExemptFed { get; set; }

        [JsonProperty("canadianTaxExemptProv")]
        public string? CanadianTaxExemptProv { get; set; }

        [JsonProperty("carrierAccount")]
        public string? CarrierAccount { get; set; }

        [JsonProperty("companyCode")]
        public string? CompanyCode { get; set; }

        [JsonProperty("cumNumber")]
        public string? CumNumber { get; set; }

        [JsonProperty("customerNumber")]
        public string? CustomerNumber { get; set; }

        [JsonProperty("customerName")]
        public string? CustomerName { get; set; }

        [JsonProperty("dateActivity")]
        public DateTime? DateActivity { get; set; }

        [JsonProperty("dateComplete")]
        public DateTime? DateComplete { get; set; }

        [JsonProperty("dateMovedToProduction")]
        public DateTime? DateMovedToProduction { get; set; }

        [JsonProperty("dateScheduleBegun")]
        public DateTime? DateScheduleBegun { get; set; }

        [JsonProperty("dateScheduleComplete")]
        public DateTime? DateScheduleComplete { get; set; }

        [JsonProperty("dateSent")]
        public DateTime? DateSent { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("estimateNumber")]
        public string? EstimateNumber { get; set; }

        [JsonProperty("estimateMasterId")]
        public double? EstimateMasterId { get; set; }

        [JsonProperty("estimatedCompletionDate")]
        public DateTime? EstimatedCompletionDate { get; set; }

        [JsonProperty("estimatedTime")]
        public string? EstimatedTime { get; set; }

        [JsonProperty("highestWorkOrder")]
        public string? HighestWorkOrder { get; set; }

        [JsonProperty("hoursExtraOperations")]
        public double? HoursExtraOperations { get; set; }

        [JsonProperty("hoursEstimated")]
        public double? HoursEstimated { get; set; }

        [JsonProperty("isActive")]
        public bool? IsActive { get; set; }

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

        [JsonProperty("laborDollars")]
        public double? LaborDollars { get; set; }

        [JsonProperty("memo")]
        public string? Memo { get; set; }

        [JsonProperty("model")]
        public string? Model { get; set; }

        [JsonProperty("partNumberSentToCustomer")]
        public string? PartNumberSentToCustomer { get; set; }

        [JsonProperty("partNumberToReturn")]
        public string? PartNumberToReturn { get; set; }

        [JsonProperty("priority")]
        public string? Priority { get; set; }

        [JsonProperty("productLine")]
        public string? ProductLine { get; set; }

        [JsonProperty("receivingOrderNumber")]
        public string? ReceivingOrderNumber { get; set; }

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

        [JsonProperty("soldToSiteID")]
        public double? SoldToSiteID { get; set; }

        [JsonProperty("totalHoursEarned")]
        public double? TotalHoursEarned { get; set; }

        [JsonProperty("totalHoursWorked")]
        public double? TotalHoursWorked { get; set; }

        [JsonProperty("weight")]
        public double? Weight { get; set; }

        [JsonProperty("wipCode")]
        public string? WipCode { get; set; }

        [JsonProperty("userText")]
        public string? UserText { get; set; }

        [JsonProperty("createJobscopeUserId")]
        public int? CreateJobscopeUserId { get; set; }

        [JsonProperty("createDate")]
        public DateTime? CreateDate { get; set; }

        [JsonProperty("modifyJobscopeUserId")]
        public int? ModifyJobscopeUserId { get; set; }

        [JsonProperty("modifyDate")]
        public DateTime? ModifyDate { get; set; }

        [JsonProperty("userDefinedFields")]
        public List<Release_UserDefinedField>? UserDefinedFields { get; set; }
    }

    public class Release_UserDefinedField
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
