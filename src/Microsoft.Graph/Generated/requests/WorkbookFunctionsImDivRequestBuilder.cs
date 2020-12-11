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
    /// The type WorkbookFunctionsImDivRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsImDivRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsImDivRequest>, IWorkbookFunctionsImDivRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsImDivRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="inumber1">A inumber1 parameter for the OData method call.</param>
        /// <param name="inumber2">A inumber2 parameter for the OData method call.</param>
        public WorkbookFunctionsImDivRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Newtonsoft.Json.Linq.JToken inumber1,
            Newtonsoft.Json.Linq.JToken inumber2)
            : base(requestUrl, client)
        {
            this.SetParameter("inumber1", inumber1, true);
            this.SetParameter("inumber2", inumber2, true);
            this.SetFunctionParameters();
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsImDivRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsImDivRequest(functionUrl, this.Client, options);

            if (this.HasParameter("inumber1"))
            {
                request.RequestBody.Inumber1 = this.GetParameter<Newtonsoft.Json.Linq.JToken>("inumber1");
            }

            if (this.HasParameter("inumber2"))
            {
                request.RequestBody.Inumber2 = this.GetParameter<Newtonsoft.Json.Linq.JToken>("inumber2");
            }

            return request;
        }
    }
}
