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
    /// The type Administrative Unit.
    /// </summary>
    public partial class AdministrativeUnit : DirectoryObject
    {
    
        ///<summary>
        /// The AdministrativeUnit constructor
        ///</summary>
        public AdministrativeUnit()
        {
            this.ODataType = "microsoft.graph.administrativeUnit";
        }

        /// <summary>
        /// Gets or sets description.
        /// An optional description for the administrative unit.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// Display name for the administrative unit.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets visibility.
        /// Controls whether the administrative unit and its members are hidden or public. Can be set to HiddenMembership or Public. If not set, default behavior is Public. When set to HiddenMembership, only members of the administrative unit can list other members of the administrative unit.
        /// </summary>
        [JsonPropertyName("visibility")]
        public string Visibility { get; set; }
    
        /// <summary>
        /// Gets or sets members.
        /// Users and groups that are members of this Adminsitrative Unit. HTTP Methods: GET (list members), POST (add members), DELETE (remove members).
        /// </summary>
        [JsonPropertyName("members")]
        public IAdministrativeUnitMembersCollectionWithReferencesPage Members { get; set; }

        /// <summary>
        /// Gets or sets membersNextLink.
        /// </summary>
        [JsonPropertyName("members@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string MembersNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets scoped role members.
        /// Scoped-role members of this Administrative Unit.  HTTP Methods: GET (list scopedRoleMemberships), POST (add scopedRoleMembership), DELETE (remove scopedRoleMembership).
        /// </summary>
        [JsonPropertyName("scopedRoleMembers")]
        public IAdministrativeUnitScopedRoleMembersCollectionPage ScopedRoleMembers { get; set; }

        /// <summary>
        /// Gets or sets scopedRoleMembersNextLink.
        /// </summary>
        [JsonPropertyName("scopedRoleMembers@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ScopedRoleMembersNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets extensions.
        /// The collection of open extensions defined for this Administrative Unit. Nullable.
        /// </summary>
        [JsonPropertyName("extensions")]
        public IAdministrativeUnitExtensionsCollectionPage Extensions { get; set; }

        /// <summary>
        /// Gets or sets extensionsNextLink.
        /// </summary>
        [JsonPropertyName("extensions@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ExtensionsNextLink { get; set; }
    
    }
}

