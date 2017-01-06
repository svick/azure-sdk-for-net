// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// MachineKey of Azure web site
    /// </summary>
    public partial class SiteMachineKey
    {
        /// <summary>
        /// Initializes a new instance of the SiteMachineKey class.
        /// </summary>
        public SiteMachineKey() { }

        /// <summary>
        /// Initializes a new instance of the SiteMachineKey class.
        /// </summary>
        public SiteMachineKey(string validation = default(string), string validationKey = default(string), string decryption = default(string), string decryptionKey = default(string))
        {
            Validation = validation;
            ValidationKey = validationKey;
            Decryption = decryption;
            DecryptionKey = decryptionKey;
        }

        /// <summary>
        /// MachineKeyValidation
        /// </summary>
        [JsonProperty(PropertyName = "validation")]
        public string Validation { get; set; }

        /// <summary>
        /// ValidationKey
        /// </summary>
        [JsonProperty(PropertyName = "validationKey")]
        public string ValidationKey { get; set; }

        /// <summary>
        /// Decryption
        /// </summary>
        [JsonProperty(PropertyName = "decryption")]
        public string Decryption { get; set; }

        /// <summary>
        /// DecryptionKey
        /// </summary>
        [JsonProperty(PropertyName = "decryptionKey")]
        public string DecryptionKey { get; set; }

    }
}