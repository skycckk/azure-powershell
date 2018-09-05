﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.WindowsAzure.Commands.Common.Attributes;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Microsoft.Azure.Commands.Network.Models
{
    public class PSFlowLogProperties
    {
        [JsonProperty(Order = 2)]
        [Ps1Xml(Target = ViewControl.Table)]
        public bool Enabled { get; set; }

        [JsonProperty(Order = 2)]
        public PSRetentionPolicyParameters RetentionPolicy { get; set; }

        [JsonProperty(Order = 2)]
        public string StorageId { get; set; }

        [JsonIgnore]
        public string RetentionPolicyText
        {
            get { return JsonConvert.SerializeObject(RetentionPolicy, Formatting.Indented, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore }); }
        }
    }
}
