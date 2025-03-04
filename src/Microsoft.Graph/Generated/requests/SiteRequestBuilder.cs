// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type SiteRequestBuilder.
    /// </summary>
    public partial class SiteRequestBuilder : BaseItemRequestBuilder, ISiteRequestBuilder
    {

        /// <summary>
        /// Constructs a new SiteRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public SiteRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new ISiteRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new ISiteRequest Request(IEnumerable<Option> options)
        {
            return new SiteRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Analytics.
        /// </summary>
        /// <returns>The <see cref="IItemAnalyticsWithReferenceRequestBuilder"/>.</returns>
        public IItemAnalyticsWithReferenceRequestBuilder Analytics
        {
            get
            {
                return new ItemAnalyticsWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl("analytics"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Columns.
        /// </summary>
        /// <returns>The <see cref="ISiteColumnsCollectionRequestBuilder"/>.</returns>
        public ISiteColumnsCollectionRequestBuilder Columns
        {
            get
            {
                return new SiteColumnsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("columns"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ContentTypes.
        /// </summary>
        /// <returns>The <see cref="ISiteContentTypesCollectionRequestBuilder"/>.</returns>
        public ISiteContentTypesCollectionRequestBuilder ContentTypes
        {
            get
            {
                return new SiteContentTypesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("contentTypes"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Drive.
        /// </summary>
        /// <returns>The <see cref="IDriveRequestBuilder"/>.</returns>
        public IDriveRequestBuilder Drive
        {
            get
            {
                return new DriveRequestBuilder(this.AppendSegmentToRequestUrl("drive"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Drives.
        /// </summary>
        /// <returns>The <see cref="ISiteDrivesCollectionRequestBuilder"/>.</returns>
        public ISiteDrivesCollectionRequestBuilder Drives
        {
            get
            {
                return new SiteDrivesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("drives"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ExternalColumns.
        /// </summary>
        /// <returns>The <see cref="ISiteExternalColumnsCollectionWithReferencesRequestBuilder"/>.</returns>
        public ISiteExternalColumnsCollectionWithReferencesRequestBuilder ExternalColumns
        {
            get
            {
                return new SiteExternalColumnsCollectionWithReferencesRequestBuilder(this.AppendSegmentToRequestUrl("externalColumns"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Items.
        /// </summary>
        /// <returns>The <see cref="ISiteItemsCollectionRequestBuilder"/>.</returns>
        public ISiteItemsCollectionRequestBuilder Items
        {
            get
            {
                return new SiteItemsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("items"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Lists.
        /// </summary>
        /// <returns>The <see cref="ISiteListsCollectionRequestBuilder"/>.</returns>
        public ISiteListsCollectionRequestBuilder Lists
        {
            get
            {
                return new SiteListsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("lists"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Permissions.
        /// </summary>
        /// <returns>The <see cref="ISitePermissionsCollectionRequestBuilder"/>.</returns>
        public ISitePermissionsCollectionRequestBuilder Permissions
        {
            get
            {
                return new SitePermissionsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("permissions"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Sites.
        /// </summary>
        /// <returns>The <see cref="ISiteSitesCollectionRequestBuilder"/>.</returns>
        public ISiteSitesCollectionRequestBuilder Sites
        {
            get
            {
                return new SiteSitesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("sites"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for TermStore.
        /// </summary>
        /// <returns>The <see cref="Microsoft.Graph.TermStore.IStoreRequestBuilder"/>.</returns>
        public Microsoft.Graph.TermStore.IStoreRequestBuilder TermStore
        {
            get
            {
                return new Microsoft.Graph.TermStore.StoreRequestBuilder(this.AppendSegmentToRequestUrl("termStore"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for TermStores.
        /// </summary>
        /// <returns>The <see cref="ISiteTermStoresCollectionRequestBuilder"/>.</returns>
        public ISiteTermStoresCollectionRequestBuilder TermStores
        {
            get
            {
                return new SiteTermStoresCollectionRequestBuilder(this.AppendSegmentToRequestUrl("termStores"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Onenote.
        /// </summary>
        /// <returns>The <see cref="IOnenoteRequestBuilder"/>.</returns>
        public IOnenoteRequestBuilder Onenote
        {
            get
            {
                return new OnenoteRequestBuilder(this.AppendSegmentToRequestUrl("onenote"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for SiteGetActivitiesByInterval.
        /// </summary>
        /// <returns>The <see cref="ISiteGetActivitiesByIntervalRequestBuilder"/>.</returns>
        public ISiteGetActivitiesByIntervalRequestBuilder GetActivitiesByInterval()
        {
            return new SiteGetActivitiesByIntervalRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.getActivitiesByInterval"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for SiteGetActivitiesByInterval.
        /// </summary>
        /// <returns>The <see cref="ISiteGetActivitiesByIntervalRequestBuilder"/>.</returns>
        public ISiteGetActivitiesByIntervalRequestBuilder GetActivitiesByInterval(
            string startDateTime = null,
            string endDateTime = null,
            string interval = null)
        {
            return new SiteGetActivitiesByIntervalRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.getActivitiesByInterval"),
                this.Client,
                startDateTime,
                endDateTime,
                interval);
        }

        /// <summary>
        /// Gets the request builder for SiteGetApplicableContentTypesForList.
        /// </summary>
        /// <returns>The <see cref="ISiteGetApplicableContentTypesForListRequestBuilder"/>.</returns>
        public ISiteGetApplicableContentTypesForListRequestBuilder GetApplicableContentTypesForList(
            string listId)
        {
            return new SiteGetApplicableContentTypesForListRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.getApplicableContentTypesForList"),
                this.Client,
                listId);
        }

        /// <summary>
        /// Gets the request builder for SiteGetByPath.
        /// </summary>
        /// <returns>The <see cref="ISiteGetByPathRequestBuilder"/>.</returns>
        public ISiteGetByPathRequestBuilder GetByPath(
            string path = null)
        {
            return new SiteGetByPathRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.getByPath"),
                this.Client,
                path);
        }
    
    }
}
