using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vincit.Jobscope.Domain.Entities
{
    public class PartRouting : JobscopeEntity
    {
        [JsonProperty("partNumber")]
        public string? PartNumber { get; set; }

        [JsonProperty("lineNumber")]
        public double? LineNumber { get; set; }

        [JsonProperty("divisionId")]
        public string? DivisionId { get; set; }

        [JsonProperty("partRevision")]
        public string? PartRevision { get; set; }

        [JsonProperty("repairCategory")]
        public string? RepairCategory { get; set; }

        [JsonProperty("routingId")]
        public string? RoutingId { get; set; }

        [JsonProperty("routingRevision")]
        public string? RoutingRevision { get; set; }

        [JsonProperty("version")]
        public int? Version { get; set; }

        [JsonProperty("isDefaultRouting")]
        public bool? IsDefaultRouting { get; set; }

        [JsonProperty("isAssembly")]
        public bool? IsAssembly { get; set; }

        [JsonProperty("isReWork")]
        public bool? IsReWork { get; set; }

        [JsonProperty("isRepair")]
        public bool? IsRepair { get; set; }

        [JsonProperty("isEngineering")]
        public bool? IsEngineering { get; set; }

        [JsonProperty("isTearDown")]
        public bool? IsTearDown { get; set; }

        [JsonProperty("isReceiving")]
        public bool? IsReceiving { get; set; }

        [JsonProperty("alternateRoutingId")]
        public string? AlternateRoutingId { get; set; }

        [JsonProperty("alternateRoutingRevision")]
        public string? AlternateRoutingRevision { get; set; }

        [JsonProperty("comments")]
        public string? Comments { get; set; }

        [JsonProperty("fromCum")]
        public string? FromCum { get; set; }

        [JsonProperty("thruCum")]
        public string? ThruCum { get; set; }

        [JsonProperty("isPartEvaluation")]
        public bool? IsPartEvaluation { get; set; }

        [JsonProperty("isCurrentForType")]
        public bool? IsCurrentForType { get; set; }

        [JsonProperty("isServiceCheckList")]
        public bool? IsServiceCheckList { get; set; }

        [JsonProperty("isSpecial")]
        public bool? IsSpecial { get; set; }

        [JsonProperty("addedByECN")]
        public string? AddedByECN { get; set; }

        [JsonProperty("addedByECNLineNumber")]
        public int? AddedByECNLineNumber { get; set; }

        [JsonProperty("addedByEmployee")]
        public string? AddedByEmployee { get; set; }

        [JsonProperty("addedDate")]
        public DateTime? AddedDate { get; set; }

        [JsonProperty("removedByECN")]
        public string? RemovedByECN { get; set; }

        [JsonProperty("removedByECNLineNumber")]
        public int? RemovedByECNLineNumber { get; set; }

        [JsonProperty("removedByEmployee")]
        public string? RemovedByEmployee { get; set; }

        [JsonProperty("removedDate")]
        public DateTime? RemovedDate { get; set; }

        [JsonProperty("isAddedPending")]
        public bool? IsAddedPending { get; set; }

        [JsonProperty("isRemovedPending")]
        public bool? IsRemovedPending { get; set; }

    }
}
