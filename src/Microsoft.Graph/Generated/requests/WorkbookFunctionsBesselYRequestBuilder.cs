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
    /// The type WorkbookFunctionsBesselYRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsBesselYRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsBesselYRequest>, IWorkbookFunctionsBesselYRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsBesselYRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="x">A x parameter for the OData method call.</param>
        /// <param name="n">A n parameter for the OData method call.</param>
        public WorkbookFunctionsBesselYRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Newtonsoft.Json.Linq.JToken x,
            Newtonsoft.Json.Linq.JToken n)
            : base(requestUrl, client)
        {
            this.SetParameter("x", x, true);
            this.SetParameter("n", n, true);
            this.SetFunctionParameters();
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsBesselYRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsBesselYRequest(functionUrl, this.Client, options);

            if (this.HasParameter("x"))
            {
                request.RequestBody.X = this.GetParameter<Newtonsoft.Json.Linq.JToken>("x");
            }

            if (this.HasParameter("n"))
            {
                request.RequestBody.N = this.GetParameter<Newtonsoft.Json.Linq.JToken>("n");
            }

            return request;
        }
    }
}
