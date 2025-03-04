// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type WorkbookChartAddRequestBuilder.
    /// </summary>
    public partial class WorkbookChartAddRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookChartAddRequest>, IWorkbookChartAddRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookChartAddRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="type">A type parameter for the OData method call.</param>
        /// <param name="seriesBy">A seriesBy parameter for the OData method call.</param>
        /// <param name="sourceData">A sourceData parameter for the OData method call.</param>
        public WorkbookChartAddRequestBuilder(
            string requestUrl,
            IBaseClient client,
            string type,
            string seriesBy,
            System.Text.Json.JsonDocument sourceData)
            : base(requestUrl, client)
        {
            this.SetParameter("type", type, false);
            this.SetParameter("seriesBy", seriesBy, false);
            this.SetParameter("sourceData", sourceData, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookChartAddRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookChartAddRequest(functionUrl, this.Client, options);

            if (this.HasParameter("type"))
            {
                request.RequestBody.Type = this.GetParameter<string>("type");
            }

            if (this.HasParameter("seriesBy"))
            {
                request.RequestBody.SeriesBy = this.GetParameter<string>("seriesBy");
            }

            if (this.HasParameter("sourceData"))
            {
                request.RequestBody.SourceData = this.GetParameter<System.Text.Json.JsonDocument>("sourceData");
            }

            return request;
        }
    }
}
