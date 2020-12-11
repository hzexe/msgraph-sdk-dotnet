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
    /// The type WorkbookFunctionsErfRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsErfRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsErfRequest>, IWorkbookFunctionsErfRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsErfRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="lowerLimit">A lowerLimit parameter for the OData method call.</param>
        /// <param name="upperLimit">A upperLimit parameter for the OData method call.</param>
        public WorkbookFunctionsErfRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Newtonsoft.Json.Linq.JToken lowerLimit,
            Newtonsoft.Json.Linq.JToken upperLimit)
            : base(requestUrl, client)
        {
            this.SetParameter("lowerLimit", lowerLimit, true);
            this.SetParameter("upperLimit", upperLimit, true);
            this.SetFunctionParameters();
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsErfRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsErfRequest(functionUrl, this.Client, options);

            if (this.HasParameter("lowerLimit"))
            {
                request.RequestBody.LowerLimit = this.GetParameter<Newtonsoft.Json.Linq.JToken>("lowerLimit");
            }

            if (this.HasParameter("upperLimit"))
            {
                request.RequestBody.UpperLimit = this.GetParameter<Newtonsoft.Json.Linq.JToken>("upperLimit");
            }

            return request;
        }
    }
}
