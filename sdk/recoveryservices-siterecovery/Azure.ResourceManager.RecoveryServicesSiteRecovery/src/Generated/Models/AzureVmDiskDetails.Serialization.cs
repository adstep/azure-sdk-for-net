// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class AzureVmDiskDetails
    {
        internal static AzureVmDiskDetails DeserializeAzureVmDiskDetails(JsonElement element)
        {
            Optional<string> vhdType = default;
            Optional<string> vhdId = default;
            Optional<string> diskId = default;
            Optional<string> vhdName = default;
            Optional<string> maxSizeMB = default;
            Optional<string> targetDiskLocation = default;
            Optional<string> targetDiskName = default;
            Optional<string> lunId = default;
            Optional<string> diskEncryptionSetId = default;
            Optional<string> customTargetDiskName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vhdType"))
                {
                    vhdType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vhdId"))
                {
                    vhdId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskId"))
                {
                    diskId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vhdName"))
                {
                    vhdName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxSizeMB"))
                {
                    maxSizeMB = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetDiskLocation"))
                {
                    targetDiskLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetDiskName"))
                {
                    targetDiskName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lunId"))
                {
                    lunId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskEncryptionSetId"))
                {
                    diskEncryptionSetId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("customTargetDiskName"))
                {
                    customTargetDiskName = property.Value.GetString();
                    continue;
                }
            }
            return new AzureVmDiskDetails(vhdType.Value, vhdId.Value, diskId.Value, vhdName.Value, maxSizeMB.Value, targetDiskLocation.Value, targetDiskName.Value, lunId.Value, diskEncryptionSetId.Value, customTargetDiskName.Value);
        }
    }
}
