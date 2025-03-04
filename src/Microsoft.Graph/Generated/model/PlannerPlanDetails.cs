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
    /// The type Planner Plan Details.
    /// </summary>
    public partial class PlannerPlanDetails : Entity
    {
    
        /// <summary>
        /// Gets or sets category descriptions.
        /// An object that specifies the descriptions of the six categories that can be associated with tasks in the plan
        /// </summary>
        [JsonPropertyName("categoryDescriptions")]
        public PlannerCategoryDescriptions CategoryDescriptions { get; set; }
    
        /// <summary>
        /// Gets or sets shared with.
        /// Set of user ids that this plan is shared with. If you are leveraging Microsoft 365 groups, use the Groups API to manage group membership to share the group's plan. You can also add existing members of the group to this collection though it is not required for them to access the plan owned by the group.
        /// </summary>
        [JsonPropertyName("sharedWith")]
        public PlannerUserIds SharedWith { get; set; }
    
    }
}

