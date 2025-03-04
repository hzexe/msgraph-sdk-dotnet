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
    /// The type Planner Task Details.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<PlannerTaskDetails>))]
    public partial class PlannerTaskDetails : Entity
    {
    
        /// <summary>
        /// Gets or sets checklist.
        /// The collection of checklist items on the task.
        /// </summary>
        [JsonPropertyName("checklist")]
        public PlannerChecklistItems Checklist { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// Description of the task
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets preview type.
        /// This sets the type of preview that shows up on the task. The possible values are: automatic, noPreview, checklist, description, reference. When set to automatic the displayed preview is chosen by the app viewing the task.
        /// </summary>
        [JsonPropertyName("previewType")]
        public PlannerPreviewType? PreviewType { get; set; }
    
        /// <summary>
        /// Gets or sets references.
        /// The collection of references on the task.
        /// </summary>
        [JsonPropertyName("references")]
        public PlannerExternalReferences References { get; set; }
    
    }
}

