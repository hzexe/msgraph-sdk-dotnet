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
    /// The type DriveItemRestoreRequestBuilder.
    /// </summary>
    public partial class DriveItemRestoreRequestBuilder : BaseActionMethodRequestBuilder<IDriveItemRestoreRequest>, IDriveItemRestoreRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="DriveItemRestoreRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="parentReference">A parentReference parameter for the OData method call.</param>
        /// <param name="name">A name parameter for the OData method call.</param>
        public DriveItemRestoreRequestBuilder(
            string requestUrl,
            IBaseClient client,
            ItemReference parentReference,
            string name)
            : base(requestUrl, client)
        {
            this.SetParameter("parentReference", parentReference, true);
            this.SetParameter("name", name, true);
            this.SetFunctionParameters();
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IDriveItemRestoreRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new DriveItemRestoreRequest(functionUrl, this.Client, options);

            if (this.HasParameter("parentReference"))
            {
                request.RequestBody.ParentReference = this.GetParameter<ItemReference>("parentReference");
            }

            if (this.HasParameter("name"))
            {
                request.RequestBody.Name = this.GetParameter<string>("name");
            }

            return request;
        }
    }
}
