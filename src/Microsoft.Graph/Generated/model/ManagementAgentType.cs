// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The enum ManagementAgentType.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ManagementAgentType
    {
    
        /// <summary>
        /// Eas
        /// </summary>
        Eas = 1,
	
        /// <summary>
        /// Mdm
        /// </summary>
        Mdm = 2,
	
        /// <summary>
        /// Eas Mdm
        /// </summary>
        EasMdm = 3,
	
        /// <summary>
        /// Intune Client
        /// </summary>
        IntuneClient = 4,
	
        /// <summary>
        /// Eas Intune Client
        /// </summary>
        EasIntuneClient = 5,
	
        /// <summary>
        /// Configuration Manager Client
        /// </summary>
        ConfigurationManagerClient = 8,
	
        /// <summary>
        /// Configuration Manager Client Mdm
        /// </summary>
        ConfigurationManagerClientMdm = 10,
	
        /// <summary>
        /// Configuration Manager Client Mdm Eas
        /// </summary>
        ConfigurationManagerClientMdmEas = 11,
	
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 16,
	
        /// <summary>
        /// Jamf
        /// </summary>
        Jamf = 32,
	
        /// <summary>
        /// Google Cloud Device Policy Controller
        /// </summary>
        GoogleCloudDevicePolicyController = 64,
	
        /// <summary>
        /// Microsoft365Managed Mdm
        /// </summary>
        Microsoft365ManagedMdm = 258,
	
        /// <summary>
        /// Ms Sense
        /// </summary>
        MsSense = 1024,
	
        /// <summary>
        /// Intune Aosp
        /// </summary>
        IntuneAosp = 2048,
	
    }
}
