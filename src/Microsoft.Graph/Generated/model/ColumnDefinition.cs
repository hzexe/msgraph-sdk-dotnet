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
    /// The type Column Definition.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<ColumnDefinition>))]
    public partial class ColumnDefinition : Entity
    {
    
        /// <summary>
        /// Gets or sets boolean.
        /// This column stores boolean values.
        /// </summary>
        [JsonPropertyName("boolean")]
        public BooleanColumn Boolean { get; set; }
    
        /// <summary>
        /// Gets or sets calculated.
        /// This column's data is calculated based on other columns.
        /// </summary>
        [JsonPropertyName("calculated")]
        public CalculatedColumn Calculated { get; set; }
    
        /// <summary>
        /// Gets or sets choice.
        /// This column stores data from a list of choices.
        /// </summary>
        [JsonPropertyName("choice")]
        public ChoiceColumn Choice { get; set; }
    
        /// <summary>
        /// Gets or sets column group.
        /// For site columns, the name of the group this column belongs to. Helps organize related columns.
        /// </summary>
        [JsonPropertyName("columnGroup")]
        public string ColumnGroup { get; set; }
    
        /// <summary>
        /// Gets or sets content approval status.
        /// This column stores content approval status.
        /// </summary>
        [JsonPropertyName("contentApprovalStatus")]
        public ContentApprovalStatusColumn ContentApprovalStatus { get; set; }
    
        /// <summary>
        /// Gets or sets currency.
        /// This column stores currency values.
        /// </summary>
        [JsonPropertyName("currency")]
        public CurrencyColumn Currency { get; set; }
    
        /// <summary>
        /// Gets or sets date time.
        /// This column stores DateTime values.
        /// </summary>
        [JsonPropertyName("dateTime")]
        public DateTimeColumn DateTime { get; set; }
    
        /// <summary>
        /// Gets or sets default value.
        /// The default value for this column.
        /// </summary>
        [JsonPropertyName("defaultValue")]
        public DefaultColumnValue DefaultValue { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// The user-facing description of the column.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The user-facing name of the column.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets enforce unique values.
        /// If true, no two list items may have the same value for this column.
        /// </summary>
        [JsonPropertyName("enforceUniqueValues")]
        public bool? EnforceUniqueValues { get; set; }
    
        /// <summary>
        /// Gets or sets geolocation.
        /// This column stores a geolocation.
        /// </summary>
        [JsonPropertyName("geolocation")]
        public GeolocationColumn Geolocation { get; set; }
    
        /// <summary>
        /// Gets or sets hidden.
        /// Specifies whether the column is displayed in the user interface.
        /// </summary>
        [JsonPropertyName("hidden")]
        public bool? Hidden { get; set; }
    
        /// <summary>
        /// Gets or sets hyperlink or picture.
        /// This column stores hyperlink or picture values.
        /// </summary>
        [JsonPropertyName("hyperlinkOrPicture")]
        public HyperlinkOrPictureColumn HyperlinkOrPicture { get; set; }
    
        /// <summary>
        /// Gets or sets indexed.
        /// Specifies whether the column values can be used for sorting and searching.
        /// </summary>
        [JsonPropertyName("indexed")]
        public bool? Indexed { get; set; }
    
        /// <summary>
        /// Gets or sets is deletable.
        /// Indicates whether this column can be deleted.
        /// </summary>
        [JsonPropertyName("isDeletable")]
        public bool? IsDeletable { get; set; }
    
        /// <summary>
        /// Gets or sets is reorderable.
        /// Indicates whether values in the column can be reordered. Read-only.
        /// </summary>
        [JsonPropertyName("isReorderable")]
        public bool? IsReorderable { get; set; }
    
        /// <summary>
        /// Gets or sets is sealed.
        /// Specifies whether the column can be changed.
        /// </summary>
        [JsonPropertyName("isSealed")]
        public bool? IsSealed { get; set; }
    
        /// <summary>
        /// Gets or sets lookup.
        /// This column's data is looked up from another source in the site.
        /// </summary>
        [JsonPropertyName("lookup")]
        public LookupColumn Lookup { get; set; }
    
        /// <summary>
        /// Gets or sets name.
        /// The API-facing name of the column as it appears in the [fields][] on a [listItem][]. For the user-facing name, see displayName.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets number.
        /// This column stores number values.
        /// </summary>
        [JsonPropertyName("number")]
        public NumberColumn Number { get; set; }
    
        /// <summary>
        /// Gets or sets person or group.
        /// This column stores Person or Group values.
        /// </summary>
        [JsonPropertyName("personOrGroup")]
        public PersonOrGroupColumn PersonOrGroup { get; set; }
    
        /// <summary>
        /// Gets or sets propagate changes.
        /// If 'true', changes to this column will be propagated to lists that implement the column.
        /// </summary>
        [JsonPropertyName("propagateChanges")]
        public bool? PropagateChanges { get; set; }
    
        /// <summary>
        /// Gets or sets read only.
        /// Specifies whether the column values can be modified.
        /// </summary>
        [JsonPropertyName("readOnly")]
        public bool? ReadOnly { get; set; }
    
        /// <summary>
        /// Gets or sets required.
        /// Specifies whether the column value isn't optional.
        /// </summary>
        [JsonPropertyName("required")]
        public bool? Required { get; set; }
    
        /// <summary>
        /// Gets or sets term.
        /// This column stores taxonomy terms.
        /// </summary>
        [JsonPropertyName("term")]
        public TermColumn Term { get; set; }
    
        /// <summary>
        /// Gets or sets text.
        /// This column stores text values.
        /// </summary>
        [JsonPropertyName("text")]
        public TextColumn Text { get; set; }
    
        /// <summary>
        /// Gets or sets thumbnail.
        /// This column stores thumbnail values.
        /// </summary>
        [JsonPropertyName("thumbnail")]
        public ThumbnailColumn Thumbnail { get; set; }
    
        /// <summary>
        /// Gets or sets type.
        /// For site columns, the type of column. Read-only.
        /// </summary>
        [JsonPropertyName("type")]
        public ColumnTypes? Type { get; set; }
    
        /// <summary>
        /// Gets or sets validation.
        /// This column stores validation formula and message for the column.
        /// </summary>
        [JsonPropertyName("validation")]
        public ColumnValidation Validation { get; set; }
    
        /// <summary>
        /// Gets or sets source column.
        /// The source column for the content type column.
        /// </summary>
        [JsonPropertyName("sourceColumn")]
        public ColumnDefinition SourceColumn { get; set; }
    
    }
}

