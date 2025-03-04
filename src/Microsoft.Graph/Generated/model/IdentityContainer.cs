// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Identity Container.
    /// </summary>
    public partial class IdentityContainer : Entity
    {
    
        /// <summary>
        /// Gets or sets conditional access.
        /// the entry point for the Conditional Access (CA) object model.
        /// </summary>
        [JsonPropertyName("conditionalAccess")]
        public ConditionalAccessRoot ConditionalAccess { get; set; }
    
        /// <summary>
        /// Gets or sets api connectors.
        /// Represents entry point for API connectors.
        /// </summary>
        [JsonPropertyName("apiConnectors")]
        public IIdentityContainerApiConnectorsCollectionPage ApiConnectors { get; set; }

        /// <summary>
        /// Gets or sets apiConnectorsNextLink.
        /// </summary>
        [JsonPropertyName("apiConnectors@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ApiConnectorsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets b2x user flows.
        /// Represents entry point for B2X/self-service sign-up identity userflows.
        /// </summary>
        [JsonPropertyName("b2xUserFlows")]
        public IIdentityContainerB2xUserFlowsCollectionPage B2xUserFlows { get; set; }

        /// <summary>
        /// Gets or sets b2xUserFlowsNextLink.
        /// </summary>
        [JsonPropertyName("b2xUserFlows@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string B2xUserFlowsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets identity providers.
        /// Represents entry point for identity provider base.
        /// </summary>
        [JsonPropertyName("identityProviders")]
        public IIdentityContainerIdentityProvidersCollectionPage IdentityProviders { get; set; }

        /// <summary>
        /// Gets or sets identityProvidersNextLink.
        /// </summary>
        [JsonPropertyName("identityProviders@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string IdentityProvidersNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets user flow attributes.
        /// Represents entry point for identity userflow attributes.
        /// </summary>
        [JsonPropertyName("userFlowAttributes")]
        public IIdentityContainerUserFlowAttributesCollectionPage UserFlowAttributes { get; set; }

        /// <summary>
        /// Gets or sets userFlowAttributesNextLink.
        /// </summary>
        [JsonPropertyName("userFlowAttributes@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string UserFlowAttributesNextLink { get; set; }
    
    }
}

