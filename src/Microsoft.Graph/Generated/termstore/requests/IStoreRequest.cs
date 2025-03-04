// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph.TermStore
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IStoreRequest.
    /// </summary>
    public partial interface IStoreRequest : Microsoft.Graph.IBaseRequest
    {
        /// <summary>
        /// Creates the specified Store using POST.
        /// </summary>
        /// <param name="storeToCreate">The Store to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Store.</returns>
        System.Threading.Tasks.Task<Store> CreateAsync(Store storeToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified Store using POST and returns a <see cref="GraphResponse{Store}"/> object.
        /// </summary>
        /// <param name="storeToCreate">The Store to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Store}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Store>> CreateResponseAsync(Store storeToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified Store.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified Store and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Store.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Store.</returns>
        System.Threading.Tasks.Task<Store> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Store and returns a <see cref="GraphResponse{Store}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Store}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Store>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Store using PATCH.
        /// </summary>
        /// <param name="storeToUpdate">The Store to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Store.</returns>
        System.Threading.Tasks.Task<Store> UpdateAsync(Store storeToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Store using PATCH and returns a <see cref="GraphResponse{Store}"/> object.
        /// </summary>
        /// <param name="storeToUpdate">The Store to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Store}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Store>> UpdateResponseAsync(Store storeToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Store using PUT.
        /// </summary>
        /// <param name="storeToUpdate">The Store object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<Store> PutAsync(Store storeToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Store using PUT and returns a <see cref="GraphResponse{Store}"/> object.
        /// </summary>
        /// <param name="storeToUpdate">The Store object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{Store}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<Store>> PutResponseAsync(Store storeToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IStoreRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IStoreRequest Expand(Expression<Func<Store, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IStoreRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IStoreRequest Select(Expression<Func<Store, object>> selectExpression);

    }
}
