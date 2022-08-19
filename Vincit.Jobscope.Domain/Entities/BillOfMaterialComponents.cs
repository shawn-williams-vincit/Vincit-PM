using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vincit.Jobscope.Domain.Entities
{
    public class BillOfMaterialComponent
    {
        [JsonProperty("billOfMaterialComponentId")]
        public double? BillOfMaterialComponentId { get; set; }

        [JsonProperty("assemblyNumber")]
        public string? AssemblyNumber { get; set; }

        [JsonProperty("sequenceNumber")]
        public int? SequenceNumber { get; set; }

        [JsonProperty("componentPartNumber")]
        public string? ComponentPartNumber { get; set; }

        [JsonProperty("bomSequence")]
        public string? BomSequence { get; set; }

        [JsonProperty("divisionId")]
        public string? DivisionId { get; set; }

        [JsonProperty("componentRevision")]
        public string? ComponentRevision { get; set; }

        [JsonProperty("unitOfIssue")]
        public string? UnitOfIssue { get; set; }

        [JsonProperty("quantityPer")]
        public double? QuantityPer { get; set; }

        [JsonProperty("fromRevision")]
        public string? FromRevision { get; set; }

        [JsonProperty("thruRevision")]
        public string? ThruRevision { get; set; }

        [JsonProperty("scrapFactor")]
        public double? ScrapFactor { get; set; }

        [JsonProperty("shrinkageFactor")]
        public double? ShrinkageFactor { get; set; }

        [JsonProperty("repairReplacementFactor")]
        public double? RepairReplacementFactor { get; set; }

        [JsonProperty("phantom")]
        public bool? Phantom { get; set; }

        [JsonProperty("endEffectiveDate")]
        public DateTime? EndEffectiveDate { get; set; }

        [JsonProperty("effectiveDate")]
        public DateTime? EffectiveDate { get; set; }

        [JsonProperty("effectiveAtTrackingId")]
        public string? EffectiveAtTrackingId { get; set; }

        [JsonProperty("partHasTrackingId")]
        public bool? PartHasTrackingId { get; set; }

        [JsonProperty("referToDocument")]
        public string? ReferToDocument { get; set; }

        [JsonProperty("imported")]
        public bool? Imported { get; set; }

        [JsonProperty("importLastUpdate")]
        public DateTime? ImportLastUpdate { get; set; }

        [JsonProperty("importPartnerId")]
        public string? ImportPartnerId { get; set; }

        [JsonProperty("itemNumber")]
        public string? ItemNumber { get; set; }

        [JsonProperty("fromCum")]
        public string? FromCum { get; set; }

        [JsonProperty("thruCum")]
        public string? ThruCum { get; set; }

        [JsonProperty("deleted")]
        public bool? Deleted { get; set; }

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

        [JsonProperty("replacesPartNumber")]
        public string? ReplacesPartNumber { get; set; }

        [JsonProperty("replacesSequenceNumber")]
        public int? ReplacesSequenceNumber { get; set; }

        [JsonProperty("replacedByPartNumber")]
        public string? ReplacedByPartNumber { get; set; }

        [JsonProperty("replacedBySequenceNumber")]
        public int? ReplacedBySequenceNumber { get; set; }

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

        [JsonProperty("removedPartDisposition")]
        public string? RemovedPartDisposition { get; set; }

        [JsonProperty("cageCode")]
        public string? CageCode { get; set; }

        [JsonProperty("isAdded")]
        public bool? IsAdded { get; set; }

        [JsonProperty("isRemoved")]
        public bool? IsRemoved { get; set; }

        [JsonProperty("isReplaced")]
        public bool? IsReplaced { get; set; }

        [JsonProperty("modelUsage")]
        public string? ModelUsage { get; set; }

        [JsonProperty("psm")]
        public string? Psm { get; set; }

        [JsonProperty("isOutsideProcess")]
        public bool? IsOutsideProcess { get; set; }

        [JsonProperty("isShipItem")]
        public bool? IsShipItem { get; set; }

        [JsonProperty("userText")]
        public string? UserText { get; set; }

        [JsonProperty("floorStock")]
        public bool? FloorStock { get; set; }

        [JsonProperty("length")]
        public double? Length { get; set; }

        [JsonProperty("variable")]
        public string? Variable { get; set; }

        [JsonProperty("isAddedPending")]
        public bool? IsAddedPending { get; set; }

        [JsonProperty("isRemovedPending")]
        public bool? IsRemovedPending { get; set; }

        [JsonProperty("isReplacedPending")]
        public bool? IsReplacedPending { get; set; }

        [JsonProperty("employeeNumber")]
        public string? EmployeeNumber { get; set; }

        [JsonProperty("qtyChangeByECN")]
        public string? QtyChangeByECN { get; set; }

        [JsonProperty("pendingQty")]
        public double? PendingQty { get; set; }

        [JsonProperty("recordGUID")]
        public string? RecordGUID { get; set; }

        [JsonProperty("isSameQuantity")]
        public bool? IsSameQuantity { get; set; }

        [JsonProperty("isVariableDimensions")]
        public bool? IsVariableDimensions { get; set; }

        [JsonProperty("isCritialSpare")]
        public bool? IsCritialSpare { get; set; }

        [JsonProperty("critialSpareRecommendedQuantity")]
        public double? CritialSpareRecommendedQuantity { get; set; }

        [JsonProperty("comment")]
        public string? Comment { get; set; }

        [JsonProperty("designation")]
        public string? Designation { get; set; }

        [JsonProperty("externalBOMItem")]
        public string? ExternalBOMItem { get; set; }

        [JsonProperty("userDefinedFields")]
        public List<BillOfMaterialComponents_UserDefinedField>? UserDefinedFields { get; set; }
    }

    public class BillOfMaterialComponents_UserDefinedField
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

