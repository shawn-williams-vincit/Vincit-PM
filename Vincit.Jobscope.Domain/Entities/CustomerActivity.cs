using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vincit.Jobscope.Domain.Entities
{
    public class CustomerActivity : JobscopeEntity
    {
        [JsonProperty("customerActivityId")]
        public double? CustomerActivityId { get; set; }

        [JsonProperty("customerId")]
        public double? CustomerId { get; set; }

        [JsonProperty("customerContactId")]
        public double? CustomerContactId { get; set; }

        [JsonProperty("customerActivityTypeId")]
        public double? CustomerActivityTypeId { get; set; }

        [JsonProperty("customerContactMethodId")]
        public double? CustomerContactMethodId { get; set; }

        [JsonProperty("sender")]
        public string? Sender { get; set; }

        [JsonProperty("recipient")]
        public string? Recipient { get; set; }

        [JsonProperty("subjectText")]
        public string? SubjectText { get; set; }

        [JsonProperty("isClosed")]
        public bool? IsClosed { get; set; }

        [JsonProperty("isInbound")]
        public bool? IsInbound { get; set; }

        [JsonProperty("priority")]
        public int? Priority { get; set; }

        [JsonProperty("phoneNumber")]
        public string? PhoneNumber { get; set; }

        [JsonProperty("emailAddress")]
        public string? EmailAddress { get; set; }

        [JsonProperty("address1")]
        public string? Address1 { get; set; }

        [JsonProperty("address2")]
        public string? Address2 { get; set; }

        [JsonProperty("city")]
        public string? City { get; set; }

        [JsonProperty("stateCode")]
        public string? StateCode { get; set; }

        [JsonProperty("postalCode")]
        public string? PostalCode { get; set; }

        [JsonProperty("countryCode")]
        public string? CountryCode { get; set; }

        [JsonProperty("dueDate")]
        public DateTime? DueDate { get; set; }

        [JsonProperty("releaseId")]
        public int? ReleaseId { get; set; }

        [JsonProperty("estimateMasterId")]
        public int? EstimateMasterId { get; set; }

        [JsonProperty("customerInquiryMasterId")]
        public int? CustomerInquiryMasterId { get; set; }

        [JsonProperty("activityJobscopeUserId")]
        public int? ActivityJobscopeUserId { get; set; }

        [JsonProperty("arInvoiceId")]
        public double? ArInvoiceId { get; set; }

        [JsonProperty("endDate")]
        public DateTime? EndDate { get; set; }

        [JsonProperty("isAllDayEvent")]
        public bool? IsAllDayEvent { get; set; }

        [JsonProperty("outlookIdentifier")]
        public string? OutlookIdentifier { get; set; }

        [JsonProperty("outlookSequence")]
        public int? OutlookSequence { get; set; }

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
