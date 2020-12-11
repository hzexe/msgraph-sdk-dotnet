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
    /// The type UserTranslateExchangeIdsRequestBuilder.
    /// </summary>
    public partial class UserTranslateExchangeIdsRequestBuilder : BaseActionMethodRequestBuilder<IUserTranslateExchangeIdsRequest>, IUserTranslateExchangeIdsRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="UserTranslateExchangeIdsRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="InputIds">A InputIds parameter for the OData method call.</param>
        /// <param name="TargetIdType">A TargetIdType parameter for the OData method call.</param>
        /// <param name="SourceIdType">A SourceIdType parameter for the OData method call.</param>
        public UserTranslateExchangeIdsRequestBuilder(
            string requestUrl,
            IBaseClient client,
            IEnumerable<string> InputIds,
            ExchangeIdFormat TargetIdType,
            ExchangeIdFormat SourceIdType)
            : base(requestUrl, client)
        {
            this.SetParameter("inputIds", InputIds, false);
            this.SetParameter("targetIdType", TargetIdType, false);
            this.SetParameter("sourceIdType", SourceIdType, false);
            this.SetFunctionParameters();
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IUserTranslateExchangeIdsRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new UserTranslateExchangeIdsRequest(functionUrl, this.Client, options);

            if (this.HasParameter("inputIds"))
            {
                request.RequestBody.InputIds = this.GetParameter<IEnumerable<string>>("inputIds");
            }

            if (this.HasParameter("targetIdType"))
            {
                request.RequestBody.TargetIdType = this.GetParameter<ExchangeIdFormat>("targetIdType");
            }

            if (this.HasParameter("sourceIdType"))
            {
                request.RequestBody.SourceIdType = this.GetParameter<ExchangeIdFormat>("sourceIdType");
            }

            return request;
        }
    }
}
