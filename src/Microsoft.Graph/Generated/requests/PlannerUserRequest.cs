// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type PlannerUserRequest.
    /// </summary>
    public partial class PlannerUserRequest : BaseRequest, IPlannerUserRequest
    {
        /// <summary>
        /// Constructs a new PlannerUserRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public PlannerUserRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified PlannerUser using POST.
        /// </summary>
        /// <param name="plannerUserToCreate">The PlannerUser to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PlannerUser.</returns>
        public async System.Threading.Tasks.Task<PlannerUser> CreateAsync(PlannerUser plannerUserToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<PlannerUser>(plannerUserToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified PlannerUser using POST and returns a <see cref="GraphResponse{PlannerUser}"/> object.
        /// </summary>
        /// <param name="plannerUserToCreate">The PlannerUser to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PlannerUser}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<PlannerUser>> CreateResponseAsync(PlannerUser plannerUserToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<PlannerUser>(plannerUserToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified PlannerUser.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<PlannerUser>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified PlannerUser and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified PlannerUser.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The PlannerUser.</returns>
        public async System.Threading.Tasks.Task<PlannerUser> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<PlannerUser>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified PlannerUser and returns a <see cref="GraphResponse{PlannerUser}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PlannerUser}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<PlannerUser>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<PlannerUser>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified PlannerUser using PATCH.
        /// </summary>
        /// <param name="plannerUserToUpdate">The PlannerUser to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated PlannerUser.</returns>
        public async System.Threading.Tasks.Task<PlannerUser> UpdateAsync(PlannerUser plannerUserToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<PlannerUser>(plannerUserToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified PlannerUser using PATCH and returns a <see cref="GraphResponse{PlannerUser}"/> object.
        /// </summary>
        /// <param name="plannerUserToUpdate">The PlannerUser to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{PlannerUser}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<PlannerUser>> UpdateResponseAsync(PlannerUser plannerUserToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<PlannerUser>(plannerUserToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified PlannerUser using PUT.
        /// </summary>
        /// <param name="plannerUserToUpdate">The PlannerUser object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<PlannerUser> PutAsync(PlannerUser plannerUserToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<PlannerUser>(plannerUserToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified PlannerUser using PUT and returns a <see cref="GraphResponse{PlannerUser}"/> object.
        /// </summary>
        /// <param name="plannerUserToUpdate">The PlannerUser object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{PlannerUser}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<PlannerUser>> PutResponseAsync(PlannerUser plannerUserToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<PlannerUser>(plannerUserToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IPlannerUserRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IPlannerUserRequest Expand(Expression<Func<PlannerUser, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IPlannerUserRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IPlannerUserRequest Select(Expression<Func<PlannerUser, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="plannerUserToInitialize">The <see cref="PlannerUser"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(PlannerUser plannerUserToInitialize)
        {

            if (plannerUserToInitialize != null && plannerUserToInitialize.AdditionalData != null)
            {

                if (plannerUserToInitialize.Plans != null && plannerUserToInitialize.Plans.CurrentPage != null)
                {
                    plannerUserToInitialize.Plans.AdditionalData = plannerUserToInitialize.AdditionalData;

                    object nextPageLink;
                    plannerUserToInitialize.AdditionalData.TryGetValue("plans@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        plannerUserToInitialize.Plans.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (plannerUserToInitialize.Tasks != null && plannerUserToInitialize.Tasks.CurrentPage != null)
                {
                    plannerUserToInitialize.Tasks.AdditionalData = plannerUserToInitialize.AdditionalData;

                    object nextPageLink;
                    plannerUserToInitialize.AdditionalData.TryGetValue("tasks@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        plannerUserToInitialize.Tasks.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
