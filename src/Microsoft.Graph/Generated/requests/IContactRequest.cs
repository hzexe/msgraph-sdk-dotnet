// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IContactRequest.
    /// </summary>
    public partial interface IContactRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Contact using POST.
        /// </summary>
        /// <param name="contactToCreate">The Contact to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Contact.</returns>
        System.Threading.Tasks.Task<Contact> CreateAsync(Contact contactToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified Contact using POST and returns a <see cref="GraphResponse{Contact}"/> object.
        /// </summary>
        /// <param name="contactToCreate">The Contact to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Contact}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Contact>> CreateResponseAsync(Contact contactToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified Contact.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified Contact and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Contact.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Contact.</returns>
        System.Threading.Tasks.Task<Contact> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Contact and returns a <see cref="GraphResponse{Contact}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Contact}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Contact>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Contact using PATCH.
        /// </summary>
        /// <param name="contactToUpdate">The Contact to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Contact.</returns>
        System.Threading.Tasks.Task<Contact> UpdateAsync(Contact contactToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Contact using PATCH and returns a <see cref="GraphResponse{Contact}"/> object.
        /// </summary>
        /// <param name="contactToUpdate">The Contact to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Contact}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Contact>> UpdateResponseAsync(Contact contactToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Contact using PUT.
        /// </summary>
        /// <param name="contactToUpdate">The Contact object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<Contact> PutAsync(Contact contactToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Contact using PUT and returns a <see cref="GraphResponse{Contact}"/> object.
        /// </summary>
        /// <param name="contactToUpdate">The Contact object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{Contact}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<Contact>> PutResponseAsync(Contact contactToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IContactRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IContactRequest Expand(Expression<Func<Contact, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IContactRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IContactRequest Select(Expression<Func<Contact, object>> selectExpression);

    }
}
