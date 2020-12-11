// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type WorkbookTableAddRequestBuilder.
    /// </summary>
    public partial class WorkbookTableAddRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookTableAddRequest>, IWorkbookTableAddRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookTableAddRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="hasHeaders">A hasHeaders parameter for the OData method call.</param>
        /// <param name="address">A address parameter for the OData method call.</param>
        public WorkbookTableAddRequestBuilder(
            string requestUrl,
            IBaseClient client,
            bool hasHeaders,
            string address)
            : base(requestUrl, client)
        {
            this.SetParameter("hasHeaders", hasHeaders, false);
            this.SetParameter("address", address, true);
            this.SetFunctionParameters();
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookTableAddRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookTableAddRequest(functionUrl, this.Client, options);

            if (this.HasParameter("hasHeaders"))
            {
                request.RequestBody.HasHeaders = this.GetParameter<bool>("hasHeaders");
            }

            if (this.HasParameter("address"))
            {
                request.RequestBody.Address = this.GetParameter<string>("address");
            }

            return request;
        }
    }
}
