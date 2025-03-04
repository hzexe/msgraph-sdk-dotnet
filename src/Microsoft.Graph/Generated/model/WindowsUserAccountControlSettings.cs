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
    /// The enum WindowsUserAccountControlSettings.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum WindowsUserAccountControlSettings
    {
    
        /// <summary>
        /// User Defined
        /// </summary>
        UserDefined = 0,
	
        /// <summary>
        /// Always Notify
        /// </summary>
        AlwaysNotify = 1,
	
        /// <summary>
        /// Notify On App Changes
        /// </summary>
        NotifyOnAppChanges = 2,
	
        /// <summary>
        /// Notify On App Changes Without Dimming
        /// </summary>
        NotifyOnAppChangesWithoutDimming = 3,
	
        /// <summary>
        /// Never Notify
        /// </summary>
        NeverNotify = 4,
	
    }
}
