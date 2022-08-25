using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vincit.Jobscope.Domain.Entities
{
    public class ComponentModel : JobscopeEntity
    {
        [JsonProperty("divisionId")]
        public string? DivisionId { get; set; }

        [JsonProperty("usage")]
        public string? Usage { get; set; }

        [JsonProperty("modelSeries")]
        public string? ModelSeries { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("isActive")]
        public bool? IsActive { get; set; }

        [JsonProperty("createJobscopeUserId")]
        public int? CreateJobscopeUserId { get; set; }

        [JsonProperty("createDate")]
        public DateTime? CreateDate { get; set; }

        [JsonProperty("modifyJobscopeUserId")]
        public int? ModifyJobscopeUserId { get; set; }

        [JsonProperty("modifyDate")]
        public DateTime? ModifyDate { get; set; }

    }
}
