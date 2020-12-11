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
    /// The type WorkbookFunctionsXirrRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsXirrRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsXirrRequest>, IWorkbookFunctionsXirrRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsXirrRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="values">A values parameter for the OData method call.</param>
        /// <param name="dates">A dates parameter for the OData method call.</param>
        /// <param name="guess">A guess parameter for the OData method call.</param>
        public WorkbookFunctionsXirrRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Newtonsoft.Json.Linq.JToken values,
            Newtonsoft.Json.Linq.JToken dates,
            Newtonsoft.Json.Linq.JToken guess)
            : base(requestUrl, client)
        {
            this.SetParameter("values", values, true);
            this.SetParameter("dates", dates, true);
            this.SetParameter("guess", guess, true);
            this.SetFunctionParameters();
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsXirrRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsXirrRequest(functionUrl, this.Client, options);

            if (this.HasParameter("values"))
            {
                request.RequestBody.Values = this.GetParameter<Newtonsoft.Json.Linq.JToken>("values");
            }

            if (this.HasParameter("dates"))
            {
                request.RequestBody.Dates = this.GetParameter<Newtonsoft.Json.Linq.JToken>("dates");
            }

            if (this.HasParameter("guess"))
            {
                request.RequestBody.Guess = this.GetParameter<Newtonsoft.Json.Linq.JToken>("guess");
            }

            return request;
        }
    }
}
