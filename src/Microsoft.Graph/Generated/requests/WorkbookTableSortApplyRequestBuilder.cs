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
    /// The type WorkbookTableSortApplyRequestBuilder.
    /// </summary>
    public partial class WorkbookTableSortApplyRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookTableSortApplyRequest>, IWorkbookTableSortApplyRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookTableSortApplyRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="matchCase">A matchCase parameter for the OData method call.</param>
        /// <param name="method">A method parameter for the OData method call.</param>
        /// <param name="fields">A fields parameter for the OData method call.</param>
        public WorkbookTableSortApplyRequestBuilder(
            string requestUrl,
            IBaseClient client,
            bool matchCase,
            string method,
            IEnumerable<WorkbookSortField> fields)
            : base(requestUrl, client)
        {
            this.SetParameter("matchCase", matchCase, false);
            this.SetParameter("method", method, false);
            this.SetParameter("fields", fields, true);
            this.SetFunctionParameters();
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookTableSortApplyRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookTableSortApplyRequest(functionUrl, this.Client, options);

            if (this.HasParameter("matchCase"))
            {
                request.RequestBody.MatchCase = this.GetParameter<bool>("matchCase");
            }

            if (this.HasParameter("method"))
            {
                request.RequestBody.Method = this.GetParameter<string>("method");
            }

            if (this.HasParameter("fields"))
            {
                request.RequestBody.Fields = this.GetParameter<IEnumerable<WorkbookSortField>>("fields");
            }

            return request;
        }
    }
}
