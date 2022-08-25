using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vincit.Jobscope.Domain.Entities
{
    public class Part : JobscopeEntity
    {
        [JsonProperty("partId")]
        public double? PartId { get; set; }

        [JsonProperty("partNumber")]
        public string? PartNumber { get; set; }

        [JsonProperty("divisionId")]
        public string? DivisionId { get; set; }

        [JsonProperty("alwaysHardAllocate")]
        public bool? AlwaysHardAllocate { get; set; }

        [JsonProperty("abc")]
        public string? Abc { get; set; }

        [JsonProperty("unitCost")]
        public double? UnitCost { get; set; }

        [JsonProperty("buyerCode")]
        public string? BuyerCode { get; set; }

        [JsonProperty("cageCode")]
        public string? CageCode { get; set; }

        [JsonProperty("carcinogenName")]
        public string? CarcinogenName { get; set; }

        [JsonProperty("materialCostCategoryCode")]
        public string? MaterialCostCategoryCode { get; set; }

        [JsonProperty("changedByECN")]
        public string? ChangedByECN { get; set; }

        [JsonProperty("changedByECNLineNumber")]
        public int? ChangedByECNLineNumber { get; set; }

        [JsonProperty("changedByEmployee")]
        public string? ChangedByEmployee { get; set; }

        [JsonProperty("changedDate")]
        public DateTime? ChangedDate { get; set; }

        [JsonProperty("classCode")]
        public string? ClassCode { get; set; }

        [JsonProperty("commodity")]
        public string? Commodity { get; set; }

        [JsonProperty("containsCarcinogens")]
        public bool? ContainsCarcinogens { get; set; }

        [JsonProperty("containsHazardous")]
        public bool? ContainsHazardous { get; set; }

        [JsonProperty("costed")]
        public bool? Costed { get; set; }

        [JsonProperty("costFlag")]
        public bool? CostFlag { get; set; }

        [JsonProperty("currentRevision")]
        public string? CurrentRevision { get; set; }

        [JsonProperty("dateLastPurchasedOrCosted")]
        public DateTime? DateLastPurchasedOrCosted { get; set; }

        [JsonProperty("dateSensitive")]
        public bool? DateSensitive { get; set; }

        [JsonProperty("daysLife")]
        public int? DaysLife { get; set; }

        [JsonProperty("defectOpportunities")]
        public int? DefectOpportunities { get; set; }

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

        [JsonProperty("discountPercent")]
        public double? DiscountPercent { get; set; }

        [JsonProperty("documentationId")]
        public string? DocumentationId { get; set; }

        [JsonProperty("drawingDashNumber")]
        public string? DrawingDashNumber { get; set; }

        [JsonProperty("drawingNumber")]
        public string? DrawingNumber { get; set; }

        [JsonProperty("engineeringConversion")]
        public double? EngineeringConversion { get; set; }

        [JsonProperty("engineeringUOM")]
        public string? EngineeringUOM { get; set; }

        [JsonProperty("estimatedCost")]
        public double? EstimatedCost { get; set; }

        [JsonProperty("expenseAccountId")]
        public double? ExpenseAccountId { get; set; }

        [JsonProperty("futureStandardCost")]
        public double? FutureStandardCost { get; set; }

        [JsonProperty("gauge")]
        public string? Gauge { get; set; }

        [JsonProperty("gtCode")]
        public string? GtCode { get; set; }

        [JsonProperty("hazardName")]
        public string? HazardName { get; set; }

        [JsonProperty("isActive")]
        public bool? IsActive { get; set; }

        [JsonProperty("inspect")]
        public bool? Inspect { get; set; }

        [JsonProperty("isCarcinogenic")]
        public bool? IsCarcinogenic { get; set; }

        [JsonProperty("isHazardous")]
        public bool? IsHazardous { get; set; }

        [JsonProperty("jobNumber")]
        public string? JobNumber { get; set; }

        [JsonProperty("laborCost")]
        public double? LaborCost { get; set; }

        [JsonProperty("lastUnitCost")]
        public double? LastUnitCost { get; set; }

        [JsonProperty("lastUpDate")]
        public DateTime? LastUpDate { get; set; }

        [JsonProperty("lastVendor")]
        public string? LastVendor { get; set; }

        [JsonProperty("latestRevision")]
        public string? LatestRevision { get; set; }

        [JsonProperty("leadTime")]
        public double? LeadTime { get; set; }

        [JsonProperty("leadTimeBuy")]
        public double? LeadTimeBuy { get; set; }

        [JsonProperty("leadTimeMfg")]
        public double? LeadTimeMfg { get; set; }

        [JsonProperty("lotControlled")]
        public bool? LotControlled { get; set; }

        [JsonProperty("manufacturerName")]
        public string? ManufacturerName { get; set; }

        [JsonProperty("manufacturerPartNumber")]
        public string? ManufacturerPartNumber { get; set; }

        [JsonProperty("materialCost")]
        public double? MaterialCost { get; set; }

        [JsonProperty("materialHandlingCode")]
        public string? MaterialHandlingCode { get; set; }

        [JsonProperty("materialCode")]
        public string? MaterialCode { get; set; }

        [JsonProperty("materialNumber")]
        public string? MaterialNumber { get; set; }

        [JsonProperty("materialType")]
        public string? MaterialType { get; set; }

        [JsonProperty("memo")]
        public string? Memo { get; set; }

        [JsonProperty("nationalStockNumber")]
        public string? NationalStockNumber { get; set; }

        [JsonProperty("needingMaterialCertification")]
        public bool? NeedingMaterialCertification { get; set; }

        [JsonProperty("operatorPrompt")]
        public string? OperatorPrompt { get; set; }

        [JsonProperty("outsideDiameter")]
        public double? OutsideDiameter { get; set; }

        [JsonProperty("outSideProcess")]
        public bool? OutSideProcess { get; set; }

        [JsonProperty("outSideProcessCost")]
        public double? OutSideProcessCost { get; set; }

        [JsonProperty("overHeadCost")]
        public double? OverHeadCost { get; set; }

        [JsonProperty("partLeadTimeClassID")]
        public double? PartLeadTimeClassID { get; set; }

        [JsonProperty("partHasBillOfMaterial")]
        public bool? PartHasBillOfMaterial { get; set; }

        [JsonProperty("phantom")]
        public bool? Phantom { get; set; }

        [JsonProperty("phase")]
        public string? Phase { get; set; }

        [JsonProperty("plannerCode")]
        public string? PlannerCode { get; set; }

        [JsonProperty("planningRule")]
        public string? PlanningRule { get; set; }

        [JsonProperty("productLine")]
        public string? ProductLine { get; set; }

        [JsonProperty("promptAtIssue")]
        public bool? PromptAtIssue { get; set; }

        [JsonProperty("promptAtReceiving")]
        public bool? PromptAtReceiving { get; set; }

        [JsonProperty("promptAtUse")]
        public bool? PromptAtUse { get; set; }

        [JsonProperty("psm")]
        public string? Psm { get; set; }

        [JsonProperty("quantityAllocated")]
        public double? QuantityAllocated { get; set; }

        [JsonProperty("quantityOnHand")]
        public double? QuantityOnHand { get; set; }

        [JsonProperty("quantityOnOrder")]
        public double? QuantityOnOrder { get; set; }

        [JsonProperty("reOrderPoint")]
        public double? ReOrderPoint { get; set; }

        [JsonProperty("reOrderQuantity")]
        public double? ReOrderQuantity { get; set; }

        [JsonProperty("repairReplacementFactor")]
        public double? RepairReplacementFactor { get; set; }

        [JsonProperty("retailPrice")]
        public double? RetailPrice { get; set; }

        [JsonProperty("reWorkable")]
        public bool? ReWorkable { get; set; }

        [JsonProperty("rotablePart")]
        public bool? RotablePart { get; set; }

        [JsonProperty("routingCode")]
        public string? RoutingCode { get; set; }

        [JsonProperty("runLabor")]
        public double? RunLabor { get; set; }

        [JsonProperty("runTime")]
        public double? RunTime { get; set; }

        [JsonProperty("safetyInstructions")]
        public string? SafetyInstructions { get; set; }

        [JsonProperty("securePart")]
        public bool? SecurePart { get; set; }

        [JsonProperty("securityGroupId")]
        public string? SecurityGroupId { get; set; }

        [JsonProperty("sellingPrice")]
        public double? SellingPrice { get; set; }

        [JsonProperty("setUpLabor")]
        public double? SetUpLabor { get; set; }

        [JsonProperty("setupTime")]
        public double? SetupTime { get; set; }

        [JsonProperty("shrinkageFactor")]
        public double? ShrinkageFactor { get; set; }

        [JsonProperty("soFlag")]
        public bool? SoFlag { get; set; }

        [JsonProperty("specialCost")]
        public double? SpecialCost { get; set; }

        [JsonProperty("status")]
        public string? Status { get; set; }

        [JsonProperty("subClassCode")]
        public string? SubClassCode { get; set; }

        [JsonProperty("thickness")]
        public int? Thickness { get; set; }

        [JsonProperty("tolerance")]
        public string? Tolerance { get; set; }

        [JsonProperty("totalRunTime")]
        public double? TotalRunTime { get; set; }

        [JsonProperty("totalSetUpTime")]
        public double? TotalSetUpTime { get; set; }

        [JsonProperty("trackByTrackingId")]
        public bool? TrackByTrackingId { get; set; }

        [JsonProperty("transitUnitOfMeasure")]
        public string? TransitUnitOfMeasure { get; set; }

        [JsonProperty("underChangeControl")]
        public bool? UnderChangeControl { get; set; }

        [JsonProperty("unitOfIssue")]
        public string? UnitOfIssue { get; set; }

        [JsonProperty("unitOfPurchase")]
        public string? UnitOfPurchase { get; set; }

        [JsonProperty("employeeNumber")]
        public string? EmployeeNumber { get; set; }

        [JsonProperty("userText")]
        public string? UserText { get; set; }

        [JsonProperty("variable")]
        public bool? Variable { get; set; }

        [JsonProperty("variableDimension")]
        public bool? VariableDimension { get; set; }

        [JsonProperty("vatCode")]
        public string? VatCode { get; set; }

        [JsonProperty("vendorCode1")]
        public string? VendorCode1 { get; set; }

        [JsonProperty("vendorCode2")]
        public string? VendorCode2 { get; set; }

        [JsonProperty("weight")]
        public double? Weight { get; set; }

        [JsonProperty("weightFlag")]
        public bool? WeightFlag { get; set; }

        [JsonProperty("yieldFactor")]
        public double? YieldFactor { get; set; }

        [JsonProperty("weightPerInch")]
        public double? WeightPerInch { get; set; }

        [JsonProperty("width")]
        public double? Width { get; set; }

        [JsonProperty("exportControlClassificationNumber")]
        public string? ExportControlClassificationNumber { get; set; }

        [JsonProperty("exportScheduleBNumber")]
        public string? ExportScheduleBNumber { get; set; }

        [JsonProperty("countryCodeId")]
        public int? CountryCodeId { get; set; }

        [JsonProperty("createJobscopeUserId")]
        public int? CreateJobscopeUserId { get; set; }

        [JsonProperty("createDate")]
        public DateTime? CreateDate { get; set; }

        [JsonProperty("modifyJobscopeUserId")]
        public int? ModifyJobscopeUserId { get; set; }

        [JsonProperty("modifyDate")]
        public DateTime? ModifyDate { get; set; }

        [JsonProperty("userDefinedFields")]
        public List<Part_UserDefinedField>? UserDefinedFields { get; set; }
    }

    public class Part_UserDefinedField
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
