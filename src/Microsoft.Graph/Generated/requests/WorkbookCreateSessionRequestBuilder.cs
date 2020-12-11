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
    /// The type WorkbookCreateSessionRequestBuilder.
    /// </summary>
    public partial class WorkbookCreateSessionRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookCreateSessionRequest>, IWorkbookCreateSessionRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookCreateSessionRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="persistChanges">A persistChanges parameter for the OData method call.</param>
        public WorkbookCreateSessionRequestBuilder(
            string requestUrl,
            IBaseClient client,
            bool persistChanges)
            : base(requestUrl, client)
        {
            this.SetParameter("persistChanges", persistChanges, false);
            this.SetFunctionParameters();
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookCreateSessionRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookCreateSessionRequest(functionUrl, this.Client, options);

            if (this.HasParameter("persistChanges"))
            {
                request.RequestBody.PersistChanges = this.GetParameter<bool>("persistChanges");
            }

            return request;
        }
    }
}
