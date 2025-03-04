// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type WindowsMinimumOperatingSystem.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<WindowsMinimumOperatingSystem>))]
    public partial class WindowsMinimumOperatingSystem
    {

        /// <summary>
        /// Gets or sets v10_0.
        /// Windows version 10.0 or later.
        /// </summary>
        [JsonPropertyName("v10_0")]
        public bool? V10_0 { get; set; }
    
        /// <summary>
        /// Gets or sets v8_0.
        /// Windows version 8.0 or later.
        /// </summary>
        [JsonPropertyName("v8_0")]
        public bool? V8_0 { get; set; }
    
        /// <summary>
        /// Gets or sets v8_1.
        /// Windows version 8.1 or later.
        /// </summary>
        [JsonPropertyName("v8_1")]
        public bool? V8_1 { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
