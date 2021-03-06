﻿using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace EligibleService.Claim.RealtimeClaimParams
{
    public class ServiceLine
    {
        [JsonProperty("service_date_from")]
        public string ServiceDateFrom { get; set; }

        [JsonProperty("service_date_to")]
        public string ServiceDateTo { get; set; }

        [JsonProperty("place_of_service")]
        public string PlaceOfService { get; set; }

        [JsonProperty("procedure_code")]
        public string ProcedureCode { get; set; }

        [JsonProperty("procedure_modifiers")]
        public Collection<string> ProcedureModifiers { get; set; }

        [JsonProperty("diagnosis_code_pointers")]
        public Collection<string> DiagnosisCodePointers { get; set; }

        [JsonProperty("charge_amount")]
        public string ChargeAmount { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }

        [JsonProperty("rendering_provider")]
        public RenderingProvider RenderingProvider { get; set; }
    }

}
