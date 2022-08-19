using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vincit.Jobscope.Domain.Entities
{
    public class RoutingOperation : JobscopeEntity
    {
        [JsonProperty("routingCode")]
        public string? RoutingCode { get; set; }

        [JsonProperty("sequenceNumber")]
        public int? SequenceNumber { get; set; }

        [JsonProperty("divisionId")]
        public string? DivisionId { get; set; }

        [JsonProperty("label")]
        public string? Label { get; set; }

        [JsonProperty("isActive")]
        public bool? IsActive { get; set; }

        [JsonProperty("isOutSideProcess")]
        public bool? IsOutSideProcess { get; set; }

        [JsonProperty("vendorNumber")]
        public string? VendorNumber { get; set; }

        [JsonProperty("atDivision")]
        public string? AtDivision { get; set; }

        [JsonProperty("atDepartment")]
        public string? AtDepartment { get; set; }

        [JsonProperty("atWorkCenter")]
        public string? AtWorkCenter { get; set; }

        [JsonProperty("useMachineCode")]
        public string? UseMachineCode { get; set; }

        [JsonProperty("processRevision")]
        public string? ProcessRevision { get; set; }

        [JsonProperty("operation")]
        public string? Operation { get; set; }

        [JsonProperty("standardOperationRevision")]
        public string? StandardOperationRevision { get; set; }

        [JsonProperty("isInspectionOperation")]
        public bool? IsInspectionOperation { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("fromRevision")]
        public string? FromRevision { get; set; }

        [JsonProperty("thruRevision")]
        public string? ThruRevision { get; set; }

        [JsonProperty("setUpLaborGrade")]
        public string? SetUpLaborGrade { get; set; }

        [JsonProperty("runLaborGrade")]
        public string? RunLaborGrade { get; set; }

        [JsonProperty("skillRequired")]
        public string? SkillRequired { get; set; }

        [JsonProperty("standardSetUpLaborRate")]
        public double? StandardSetUpLaborRate { get; set; }

        [JsonProperty("standardRunTime")]
        public double? StandardRunTime { get; set; }

        [JsonProperty("standardSetupTime")]
        public double? StandardSetupTime { get; set; }

        [JsonProperty("standardRunQuantity")]
        public double? StandardRunQuantity { get; set; }

        [JsonProperty("standardTransitTime")]
        public double? StandardTransitTime { get; set; }

        [JsonProperty("transitUnitOfMeasure")]
        public string? TransitUnitOfMeasure { get; set; }

        [JsonProperty("standardPreOpQueueTime")]
        public double? StandardPreOpQueueTime { get; set; }

        [JsonProperty("standardPostOpQueueTime")]
        public double? StandardPostOpQueueTime { get; set; }

        [JsonProperty("standardCrewSize")]
        public double? StandardCrewSize { get; set; }

        [JsonProperty("kitPartNumber")]
        public string? KitPartNumber { get; set; }

        [JsonProperty("kitId")]
        public string? KitId { get; set; }

        [JsonProperty("isReWorkStep")]
        public bool? IsReWorkStep { get; set; }

        [JsonProperty("isCertificationPointFirstPass")]
        public bool? IsCertificationPointFirstPass { get; set; }

        [JsonProperty("isCertificationPointReProcess")]
        public bool? IsCertificationPointReProcess { get; set; }

        [JsonProperty("isControlPoint")]
        public bool? IsControlPoint { get; set; }

        [JsonProperty("isInspectSetUp")]
        public bool? IsInspectSetUp { get; set; }

        [JsonProperty("isInspectRunEnd")]
        public bool? IsInspectRunEnd { get; set; }

        [JsonProperty("referToManual")]
        public string? ReferToManual { get; set; }

        [JsonProperty("referToFigure")]
        public string? ReferToFigure { get; set; }

        [JsonProperty("referToItem")]
        public string? ReferToItem { get; set; }

        [JsonProperty("referToDocument")]
        public string? ReferToDocument { get; set; }

        [JsonProperty("ecn")]
        public string? Ecn { get; set; }

        [JsonProperty("breakInRule")]
        public string? BreakInRule { get; set; }

        [JsonProperty("supplementalOperation")]
        public bool? SupplementalOperation { get; set; }

        [JsonProperty("operationSequenceNumber")]
        public string? OperationSequenceNumber { get; set; }

        [JsonProperty("fromCum")]
        public string? FromCum { get; set; }

        [JsonProperty("thruCum")]
        public string? ThruCum { get; set; }

        [JsonProperty("isAdded")]
        public bool? IsAdded { get; set; }

        [JsonProperty("isRemoved")]
        public bool? IsRemoved { get; set; }

        [JsonProperty("isReplaced")]
        public bool? IsReplaced { get; set; }

        [JsonProperty("applyLearningFactor")]
        public bool? ApplyLearningFactor { get; set; }

        [JsonProperty("addedByECN")]
        public string? AddedByECN { get; set; }

        [JsonProperty("addedECNLineNumber")]
        public int? AddedECNLineNumber { get; set; }

        [JsonProperty("addedByDrawing")]
        public string? AddedByDrawing { get; set; }

        [JsonProperty("addedByDrawingRevision")]
        public string? AddedByDrawingRevision { get; set; }

        [JsonProperty("addedByEmployee")]
        public string? AddedByEmployee { get; set; }

        [JsonProperty("addedDate")]
        public DateTime? AddedDate { get; set; }

        [JsonProperty("replacesOperation")]
        public string? ReplacesOperation { get; set; }

        [JsonProperty("replacesSequenceNumber")]
        public double? ReplacesSequenceNumber { get; set; }

        [JsonProperty("replacedByOperation")]
        public string? ReplacedByOperation { get; set; }

        [JsonProperty("replacedBySequenceNumber")]
        public double? ReplacedBySequenceNumber { get; set; }

        [JsonProperty("replacedByECN")]
        public string? ReplacedByECN { get; set; }

        [JsonProperty("replacedECNLineNumber")]
        public int? ReplacedECNLineNumber { get; set; }

        [JsonProperty("replacedByDrawing")]
        public string? ReplacedByDrawing { get; set; }

        [JsonProperty("replacedByDrawingRevision")]
        public string? ReplacedByDrawingRevision { get; set; }

        [JsonProperty("replacedByEmployee")]
        public string? ReplacedByEmployee { get; set; }

        [JsonProperty("replacedDate")]
        public DateTime? ReplacedDate { get; set; }

        [JsonProperty("removedByECN")]
        public string? RemovedByECN { get; set; }

        [JsonProperty("removedECNLineNumber")]
        public int? RemovedECNLineNumber { get; set; }

        [JsonProperty("removedByDrawing")]
        public string? RemovedByDrawing { get; set; }

        [JsonProperty("removedByDrawingRevision")]
        public string? RemovedByDrawingRevision { get; set; }

        [JsonProperty("removedByEmployee")]
        public string? RemovedByEmployee { get; set; }

        [JsonProperty("removedDate")]
        public DateTime? RemovedDate { get; set; }

        [JsonProperty("conversion")]
        public double? Conversion { get; set; }

        [JsonProperty("isAddedPending")]
        public bool? IsAddedPending { get; set; }

        [JsonProperty("isRemovedPending")]
        public bool? IsRemovedPending { get; set; }

        [JsonProperty("isReplacedPending")]
        public bool? IsReplacedPending { get; set; }

        [JsonProperty("routingOperationProcessCodeID")]
        public double? RoutingOperationProcessCodeID { get; set; }

        [JsonProperty("userDefinedFields")]
        public List<RoutingOperation_UserDefinedField>? UserDefinedFields { get; set; }
    }

    public class RoutingOperation_UserDefinedField
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
