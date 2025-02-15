// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    /// <summary> A class representing the MaintenanceWindow data model. </summary>
    public partial class MaintenanceWindowData : ResourceData
    {
        /// <summary> Initializes a new instance of MaintenanceWindowData. </summary>
        public MaintenanceWindowData()
        {
            TimeRanges = new ChangeTrackingList<MaintenanceWindowTimeRange>();
        }

        /// <summary> Initializes a new instance of MaintenanceWindowData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="timeRanges"></param>
        internal MaintenanceWindowData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IList<MaintenanceWindowTimeRange> timeRanges) : base(id, name, resourceType, systemData)
        {
            TimeRanges = timeRanges;
        }

        /// <summary> Gets the time ranges. </summary>
        public IList<MaintenanceWindowTimeRange> TimeRanges { get; }
    }
}
