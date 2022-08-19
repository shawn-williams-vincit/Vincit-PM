using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vincit.Jobscope.Domain.Entities
{
    public class RoutingHeader : JobscopeEntity
    {
        [JsonProperty("routingHeaderId")]
        public double RoutingHeaderId { get; set; }

        [JsonProperty("routingId")]
        public string? RoutingId { get; set; }

        [JsonProperty("revision")]
        public string? Revision { get; set; }

        [JsonProperty("changedByECN")]
        public string? ChangedByECN { get; set; }

        [JsonProperty("changedByECNLineNumber")]
        public int? ChangedByECNLineNumber { get; set; }

        [JsonProperty("changedByEmployee")]
        public string? ChangedByEmployee { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("divisionId")]
        public string? DivisionId { get; set; }

        [JsonProperty("documentationMEP")]
        public string? DocumentationMEP { get; set; }

        [JsonProperty("enforceInSequenceProcess")]
        public bool? EnforceInSequenceProcess { get; set; }

        [JsonProperty("engineeringReleaseNumber")]
        public string? EngineeringReleaseNumber { get; set; }

        [JsonProperty("engineeringChangeNumber")]
        public string? EngineeringChangeNumber { get; set; }

        [JsonProperty("isReleasedForProduction")]
        public bool? IsReleasedForProduction { get; set; }

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

        [JsonProperty("isServiceCheckList")]
        public bool? IsServiceCheckList { get; set; }

        [JsonProperty("isSpecial")]
        public bool? IsSpecial { get; set; }

        [JsonProperty("isSecureRouting")]
        public bool? IsSecureRouting { get; set; }

        [JsonProperty("isReceivingRouting")]
        public bool? IsReceivingRouting { get; set; }

        [JsonProperty("isPartEvaluation")]
        public bool? IsPartEvaluation { get; set; }

        [JsonProperty("isUnderChangeControl")]
        public bool? IsUnderChangeControl { get; set; }

        [JsonProperty("isCurrentRevision")]
        public bool? IsCurrentRevision { get; set; }

        [JsonProperty("isBackflushed")]
        public bool? IsBackflushed { get; set; }

        [JsonProperty("isActive")]
        public bool? IsActive { get; set; }

        [JsonProperty("leadTime")]
        public double? LeadTime { get; set; }

        [JsonProperty("learningFactor")]
        public double? LearningFactor { get; set; }

        [JsonProperty("mepRevision")]
        public string? MepRevision { get; set; }

        [JsonProperty("processAnySequence")]
        public bool? ProcessAnySequence { get; set; }

        [JsonProperty("specialOrder")]
        public string? SpecialOrder { get; set; }

        [JsonProperty("securityGroupId")]
        public string? SecurityGroupId { get; set; }

        [JsonProperty("spanTime")]
        public double? SpanTime { get; set; }

        [JsonProperty("versionNumber")]
        public int? VersionNumber { get; set; }
    }
}
