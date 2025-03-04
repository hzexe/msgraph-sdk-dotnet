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
    /// The type CertificateAuthority.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<CertificateAuthority>))]
    public partial class CertificateAuthority
    {

        /// <summary>
        /// Gets or sets certificate.
        /// Required. The base64 encoded string representing the public certificate.
        /// </summary>
        [JsonPropertyName("certificate")]
        public byte[] Certificate { get; set; }
    
        /// <summary>
        /// Gets or sets certificateRevocationListUrl.
        /// The URL of the certificate revocation list.
        /// </summary>
        [JsonPropertyName("certificateRevocationListUrl")]
        public string CertificateRevocationListUrl { get; set; }
    
        /// <summary>
        /// Gets or sets deltaCertificateRevocationListUrl.
        /// The URL contains the list of all revoked certificates since the last time a full certificate revocaton list was created.
        /// </summary>
        [JsonPropertyName("deltaCertificateRevocationListUrl")]
        public string DeltaCertificateRevocationListUrl { get; set; }
    
        /// <summary>
        /// Gets or sets isRootAuthority.
        /// Required. true if the trusted certificate is a root authority, false if the trusted certificate is an intermediate authority.
        /// </summary>
        [JsonPropertyName("isRootAuthority")]
        public bool? IsRootAuthority { get; set; }
    
        /// <summary>
        /// Gets or sets issuer.
        /// The issuer of the certificate, calculated from the certificate value. Read-only.
        /// </summary>
        [JsonPropertyName("issuer")]
        public string Issuer { get; set; }
    
        /// <summary>
        /// Gets or sets issuerSki.
        /// The subject key identifier of the certificate, calculated from the certificate value. Read-only.
        /// </summary>
        [JsonPropertyName("issuerSki")]
        public string IssuerSki { get; set; }
    
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
