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
    /// The type MobileAppContentFileCommitRequestBuilder.
    /// </summary>
    public partial class MobileAppContentFileCommitRequestBuilder : BaseActionMethodRequestBuilder<IMobileAppContentFileCommitRequest>, IMobileAppContentFileCommitRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="MobileAppContentFileCommitRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="fileEncryptionInfo">A fileEncryptionInfo parameter for the OData method call.</param>
        public MobileAppContentFileCommitRequestBuilder(
            string requestUrl,
            IBaseClient client,
            FileEncryptionInfo fileEncryptionInfo)
            : base(requestUrl, client)
        {
            this.SetParameter("fileEncryptionInfo", fileEncryptionInfo, true);
            this.SetFunctionParameters();
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IMobileAppContentFileCommitRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new MobileAppContentFileCommitRequest(functionUrl, this.Client, options);

            if (this.HasParameter("fileEncryptionInfo"))
            {
                request.RequestBody.FileEncryptionInfo = this.GetParameter<FileEncryptionInfo>("fileEncryptionInfo");
            }

            return request;
        }
    }
}
