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
    /// The type WorkbookFunctionsImLog10RequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsImLog10RequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsImLog10Request>, IWorkbookFunctionsImLog10RequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsImLog10RequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="inumber">A inumber parameter for the OData method call.</param>
        public WorkbookFunctionsImLog10RequestBuilder(
            string requestUrl,
            IBaseClient client,
            Newtonsoft.Json.Linq.JToken inumber)
            : base(requestUrl, client)
        {
            this.SetParameter("inumber", inumber, true);
            this.SetFunctionParameters();
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsImLog10Request CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsImLog10Request(functionUrl, this.Client, options);

            if (this.HasParameter("inumber"))
            {
                request.RequestBody.Inumber = this.GetParameter<Newtonsoft.Json.Linq.JToken>("inumber");
            }

            return request;
        }
    }
}
