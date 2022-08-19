using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vincit.Jobscope.Domain.Entities
{
    public class GLAccount
    {
        [JsonProperty("account")]
        public string? Account { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("accountType")]
        public string? AccountType { get; set; }

        [JsonProperty("accountLevelCode")]
        public string? AccountLevelCode { get; set; }

        [JsonProperty("divisionCode")]
        public string? DivisionCode { get; set; }

        [JsonProperty("companyCode")]
        public string? CompanyCode { get; set; }

        [JsonProperty("department")]
        public string? Department { get; set; }

        [JsonProperty("fixedFormulaCode")]
        public string? FixedFormulaCode { get; set; }

        [JsonProperty("subtotal")]
        public string? Subtotal { get; set; }

        [JsonProperty("currentBalanceNative")]
        public double? CurrentBalanceNative { get; set; }

        [JsonProperty("currentBalanceCurrency")]
        public double? CurrentBalanceCurrency { get; set; }

        [JsonProperty("fiscalYearNative01")]
        public double? FiscalYearNative01 { get; set; }

        [JsonProperty("fiscalYearNative02")]
        public double? FiscalYearNative02 { get; set; }

        [JsonProperty("fiscalYearNative03")]
        public double? FiscalYearNative03 { get; set; }

        [JsonProperty("fiscalYearNative04")]
        public double? FiscalYearNative04 { get; set; }

        [JsonProperty("fiscalYearNative05")]
        public double? FiscalYearNative05 { get; set; }

        [JsonProperty("fiscalYearNative06")]
        public double? FiscalYearNative06 { get; set; }

        [JsonProperty("fiscalYearNative07")]
        public double? FiscalYearNative07 { get; set; }

        [JsonProperty("fiscalYearNative08")]
        public double? FiscalYearNative08 { get; set; }

        [JsonProperty("fiscalYearNative09")]
        public double? FiscalYearNative09 { get; set; }

        [JsonProperty("fiscalYearNative10")]
        public double? FiscalYearNative10 { get; set; }

        [JsonProperty("fiscalYearNative11")]
        public double? FiscalYearNative11 { get; set; }

        [JsonProperty("fiscalYearNative12")]
        public double? FiscalYearNative12 { get; set; }

        [JsonProperty("fiscalYearNative13")]
        public double? FiscalYearNative13 { get; set; }

        [JsonProperty("fiscalYearCurrency01")]
        public double? FiscalYearCurrency01 { get; set; }

        [JsonProperty("fiscalYearCurrency02")]
        public double? FiscalYearCurrency02 { get; set; }

        [JsonProperty("fiscalYearCurrency03")]
        public double? FiscalYearCurrency03 { get; set; }

        [JsonProperty("fiscalYearCurrency04")]
        public double? FiscalYearCurrency04 { get; set; }

        [JsonProperty("fiscalYearCurrency05")]
        public double? FiscalYearCurrency05 { get; set; }

        [JsonProperty("fiscalYearCurrency06")]
        public double? FiscalYearCurrency06 { get; set; }

        [JsonProperty("fiscalYearCurrency07")]
        public double? FiscalYearCurrency07 { get; set; }

        [JsonProperty("fiscalYearCurrency08")]
        public double? FiscalYearCurrency08 { get; set; }

        [JsonProperty("fiscalYearCurrency09")]
        public double? FiscalYearCurrency09 { get; set; }

        [JsonProperty("fiscalYearCurrency10")]
        public double? FiscalYearCurrency10 { get; set; }

        [JsonProperty("fiscalYearCurrency11")]
        public double? FiscalYearCurrency11 { get; set; }

        [JsonProperty("fiscalYearCurrency12")]
        public double? FiscalYearCurrency12 { get; set; }

        [JsonProperty("fiscalYearCurrency13")]
        public double? FiscalYearCurrency13 { get; set; }
    }
}
