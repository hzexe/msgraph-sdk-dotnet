// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionReferencesRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The interface IUserManagedAppRegistrationsCollectionReferencesRequest.
    /// </summary>
    public partial interface IUserManagedAppRegistrationsCollectionReferencesRequest : IBaseRequest
    {
        /// <summary>
        /// Adds the specified ManagedAppRegistration to the collection via POST.
        /// </summary>
        /// <param name="managedAppRegistration">The ManagedAppRegistration to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        System.Threading.Tasks.Task AddAsync(ManagedAppRegistration managedAppRegistration, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified ManagedAppRegistration to the collection via POST and returns a <see cref="GraphResponse{ManagedAppRegistration}"/> object of the request.
        /// </summary>
        /// <param name="managedAppRegistration">The ManagedAppRegistration to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        System.Threading.Tasks.Task<GraphResponse> AddResponseAsync(ManagedAppRegistration managedAppRegistration, CancellationToken cancellationToken = default);

    }
}
