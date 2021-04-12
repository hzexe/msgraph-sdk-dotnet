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
    /// The type FeatureRolloutPolicyRequest.
    /// </summary>
    public partial class FeatureRolloutPolicyRequest : BaseRequest, IFeatureRolloutPolicyRequest
    {
        /// <summary>
        /// Constructs a new FeatureRolloutPolicyRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public FeatureRolloutPolicyRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified FeatureRolloutPolicy using POST.
        /// </summary>
        /// <param name="featureRolloutPolicyToCreate">The FeatureRolloutPolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created FeatureRolloutPolicy.</returns>
        public async System.Threading.Tasks.Task<FeatureRolloutPolicy> CreateAsync(FeatureRolloutPolicy featureRolloutPolicyToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<FeatureRolloutPolicy>(featureRolloutPolicyToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified FeatureRolloutPolicy using POST and returns a <see cref="GraphResponse{FeatureRolloutPolicy}"/> object.
        /// </summary>
        /// <param name="featureRolloutPolicyToCreate">The FeatureRolloutPolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{FeatureRolloutPolicy}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<FeatureRolloutPolicy>> CreateResponseAsync(FeatureRolloutPolicy featureRolloutPolicyToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<FeatureRolloutPolicy>(featureRolloutPolicyToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified FeatureRolloutPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<FeatureRolloutPolicy>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified FeatureRolloutPolicy and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified FeatureRolloutPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The FeatureRolloutPolicy.</returns>
        public async System.Threading.Tasks.Task<FeatureRolloutPolicy> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<FeatureRolloutPolicy>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified FeatureRolloutPolicy and returns a <see cref="GraphResponse{FeatureRolloutPolicy}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{FeatureRolloutPolicy}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<FeatureRolloutPolicy>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<FeatureRolloutPolicy>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified FeatureRolloutPolicy using PATCH.
        /// </summary>
        /// <param name="featureRolloutPolicyToUpdate">The FeatureRolloutPolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated FeatureRolloutPolicy.</returns>
        public async System.Threading.Tasks.Task<FeatureRolloutPolicy> UpdateAsync(FeatureRolloutPolicy featureRolloutPolicyToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<FeatureRolloutPolicy>(featureRolloutPolicyToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified FeatureRolloutPolicy using PATCH and returns a <see cref="GraphResponse{FeatureRolloutPolicy}"/> object.
        /// </summary>
        /// <param name="featureRolloutPolicyToUpdate">The FeatureRolloutPolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{FeatureRolloutPolicy}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<FeatureRolloutPolicy>> UpdateResponseAsync(FeatureRolloutPolicy featureRolloutPolicyToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<FeatureRolloutPolicy>(featureRolloutPolicyToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified FeatureRolloutPolicy using PUT.
        /// </summary>
        /// <param name="featureRolloutPolicyToUpdate">The FeatureRolloutPolicy object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<FeatureRolloutPolicy> PutAsync(FeatureRolloutPolicy featureRolloutPolicyToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<FeatureRolloutPolicy>(featureRolloutPolicyToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified FeatureRolloutPolicy using PUT and returns a <see cref="GraphResponse{FeatureRolloutPolicy}"/> object.
        /// </summary>
        /// <param name="featureRolloutPolicyToUpdate">The FeatureRolloutPolicy object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{FeatureRolloutPolicy}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<FeatureRolloutPolicy>> PutResponseAsync(FeatureRolloutPolicy featureRolloutPolicyToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<FeatureRolloutPolicy>(featureRolloutPolicyToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IFeatureRolloutPolicyRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IFeatureRolloutPolicyRequest Expand(Expression<Func<FeatureRolloutPolicy, object>> expandExpression)
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
        public IFeatureRolloutPolicyRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IFeatureRolloutPolicyRequest Select(Expression<Func<FeatureRolloutPolicy, object>> selectExpression)
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
        /// <param name="featureRolloutPolicyToInitialize">The <see cref="FeatureRolloutPolicy"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(FeatureRolloutPolicy featureRolloutPolicyToInitialize)
        {

            if (featureRolloutPolicyToInitialize != null && featureRolloutPolicyToInitialize.AdditionalData != null)
            {

                if (featureRolloutPolicyToInitialize.AppliesTo != null && featureRolloutPolicyToInitialize.AppliesTo.CurrentPage != null)
                {
                    featureRolloutPolicyToInitialize.AppliesTo.AdditionalData = featureRolloutPolicyToInitialize.AdditionalData;

                    if(featureRolloutPolicyToInitialize.AdditionalData.TryGetValue("appliesTo@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.ToString()))
                        {
                            featureRolloutPolicyToInitialize.AppliesTo.InitializeNextPageRequest(
                                this.Client,
                                element.ToString());
                        }
                    }
                }

            }


        }
    }
}
