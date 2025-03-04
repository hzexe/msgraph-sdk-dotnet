// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Report Root.
    /// </summary>
    public partial class ReportRoot : Entity
    {
    
        /// <summary>
        /// Gets or sets daily print usage by printer.
        /// </summary>
        [JsonPropertyName("dailyPrintUsageByPrinter")]
        public IReportRootDailyPrintUsageByPrinterCollectionPage DailyPrintUsageByPrinter { get; set; }

        /// <summary>
        /// Gets or sets dailyPrintUsageByPrinterNextLink.
        /// </summary>
        [JsonPropertyName("dailyPrintUsageByPrinter@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string DailyPrintUsageByPrinterNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets daily print usage by user.
        /// </summary>
        [JsonPropertyName("dailyPrintUsageByUser")]
        public IReportRootDailyPrintUsageByUserCollectionPage DailyPrintUsageByUser { get; set; }

        /// <summary>
        /// Gets or sets dailyPrintUsageByUserNextLink.
        /// </summary>
        [JsonPropertyName("dailyPrintUsageByUser@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string DailyPrintUsageByUserNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets monthly print usage by printer.
        /// </summary>
        [JsonPropertyName("monthlyPrintUsageByPrinter")]
        public IReportRootMonthlyPrintUsageByPrinterCollectionPage MonthlyPrintUsageByPrinter { get; set; }

        /// <summary>
        /// Gets or sets monthlyPrintUsageByPrinterNextLink.
        /// </summary>
        [JsonPropertyName("monthlyPrintUsageByPrinter@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string MonthlyPrintUsageByPrinterNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets monthly print usage by user.
        /// </summary>
        [JsonPropertyName("monthlyPrintUsageByUser")]
        public IReportRootMonthlyPrintUsageByUserCollectionPage MonthlyPrintUsageByUser { get; set; }

        /// <summary>
        /// Gets or sets monthlyPrintUsageByUserNextLink.
        /// </summary>
        [JsonPropertyName("monthlyPrintUsageByUser@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string MonthlyPrintUsageByUserNextLink { get; set; }
    
    }
}

