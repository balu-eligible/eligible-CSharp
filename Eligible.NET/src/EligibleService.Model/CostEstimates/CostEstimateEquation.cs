﻿using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace EligibleService.Model.CostEstimates
{
    public class CostEstimateEquation
    {
        [JsonProperty("deductible")]
        public Collection<EligibleService.Model.Coverage.FinancialFlow> Deductible { get; set; }

        [JsonProperty("coinsurance")]
        public Collection<Coinsurance> Coinsurance { get; set; }

        [JsonProperty("copayment")]
        public Collection<Copayment> Copayment { get; set; }

        [JsonProperty("stop_loss")]
        public Collection<StopLoss> StopLoss { get; set; }
    }

}
