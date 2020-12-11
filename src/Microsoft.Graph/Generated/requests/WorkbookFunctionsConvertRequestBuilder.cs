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
    /// The type WorkbookFunctionsConvertRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsConvertRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsConvertRequest>, IWorkbookFunctionsConvertRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsConvertRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="number">A number parameter for the OData method call.</param>
        /// <param name="fromUnit">A fromUnit parameter for the OData method call.</param>
        /// <param name="toUnit">A toUnit parameter for the OData method call.</param>
        public WorkbookFunctionsConvertRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Newtonsoft.Json.Linq.JToken number,
            Newtonsoft.Json.Linq.JToken fromUnit,
            Newtonsoft.Json.Linq.JToken toUnit)
            : base(requestUrl, client)
        {
            this.SetParameter("number", number, true);
            this.SetParameter("fromUnit", fromUnit, true);
            this.SetParameter("toUnit", toUnit, true);
            this.SetFunctionParameters();
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsConvertRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsConvertRequest(functionUrl, this.Client, options);

            if (this.HasParameter("number"))
            {
                request.RequestBody.Number = this.GetParameter<Newtonsoft.Json.Linq.JToken>("number");
            }

            if (this.HasParameter("fromUnit"))
            {
                request.RequestBody.FromUnit = this.GetParameter<Newtonsoft.Json.Linq.JToken>("fromUnit");
            }

            if (this.HasParameter("toUnit"))
            {
                request.RequestBody.ToUnit = this.GetParameter<Newtonsoft.Json.Linq.JToken>("toUnit");
            }

            return request;
        }
    }
}
