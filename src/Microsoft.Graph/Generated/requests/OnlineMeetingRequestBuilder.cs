// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type OnlineMeetingRequestBuilder.
    /// </summary>
    public partial class OnlineMeetingRequestBuilder : EntityRequestBuilder, IOnlineMeetingRequestBuilder
    {

        /// <summary>
        /// Constructs a new OnlineMeetingRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public OnlineMeetingRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IOnlineMeetingRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IOnlineMeetingRequest Request(IEnumerable<Option> options)
        {
            return new OnlineMeetingRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for AttendeeReport.
        /// </summary>
        /// <returns>The <see cref="IOnlineMeetingAttendeeReportRequestBuilder"/>.</returns>
        public IOnlineMeetingAttendeeReportRequestBuilder AttendeeReport
        {
            get
            {
                return new OnlineMeetingAttendeeReportRequestBuilder(this.AppendSegmentToRequestUrl("attendeeReport"), this.Client);
            }
        }
    
        
    
    }
}
