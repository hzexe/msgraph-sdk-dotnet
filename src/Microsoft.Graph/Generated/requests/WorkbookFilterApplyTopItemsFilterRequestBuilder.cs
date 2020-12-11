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
    /// The type WorkbookFilterApplyTopItemsFilterRequestBuilder.
    /// </summary>
    public partial class WorkbookFilterApplyTopItemsFilterRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFilterApplyTopItemsFilterRequest>, IWorkbookFilterApplyTopItemsFilterRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFilterApplyTopItemsFilterRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="count">A count parameter for the OData method call.</param>
        public WorkbookFilterApplyTopItemsFilterRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Int32 count)
            : base(requestUrl, client)
        {
            this.SetParameter("count", count, false);
            this.SetFunctionParameters();
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFilterApplyTopItemsFilterRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFilterApplyTopItemsFilterRequest(functionUrl, this.Client, options);

            if (this.HasParameter("count"))
            {
                request.RequestBody.Count = this.GetParameter<Int32>("count");
            }

            return request;
        }
    }
}
