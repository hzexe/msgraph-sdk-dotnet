// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionResponse.cs.tt
namespace Microsoft.Graph
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type GroupPhotosCollectionResponse.
    /// </summary>
    public class GroupPhotosCollectionResponse
    {
        /// <summary>
        /// Gets or sets the <see cref="IGroupPhotosCollectionPage"/> value.
        /// </summary>
        [JsonPropertyName("value")]
        public IGroupPhotosCollectionPage Value { get; set; }

        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Initializes the NextPageRequest from the AdditionalData if possible
        /// and copies the Additional data to the CollectionPage instance
        /// </summary>
        internal void InitializeCollectionProperties(IBaseClient client)
        {
            if(AdditionalData != null)
            {
                if(AdditionalData.TryGetValue("@odata.nextLink", out var nextPageLink))
                {
                    // Ensure it is a non empty JsonElement string
                    if (nextPageLink is System.Text.Json.JsonElement element
                        && element.ValueKind == System.Text.Json.JsonValueKind.String
                        && !string.IsNullOrEmpty(element.GetString()))
                    {
                        Value.InitializeNextPageRequest(
                            client,
                            element.GetString());
                    }
                }
                // Copy the additional data collection to the page itself so that information is not lost
                Value.AdditionalData = AdditionalData;
            }
        }
    }
}
