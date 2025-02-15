// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    public partial class DscMetaConfiguration
    {
        internal static DscMetaConfiguration DeserializeDscMetaConfiguration(JsonElement element)
        {
            Optional<int> configurationModeFrequencyMins = default;
            Optional<bool> rebootNodeIfNeeded = default;
            Optional<string> configurationMode = default;
            Optional<string> actionAfterReboot = default;
            Optional<string> certificateId = default;
            Optional<int> refreshFrequencyMins = default;
            Optional<bool> allowModuleOverwrite = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("configurationModeFrequencyMins"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    configurationModeFrequencyMins = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("rebootNodeIfNeeded"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    rebootNodeIfNeeded = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("configurationMode"))
                {
                    configurationMode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("actionAfterReboot"))
                {
                    actionAfterReboot = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("certificateId"))
                {
                    certificateId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("refreshFrequencyMins"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    refreshFrequencyMins = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("allowModuleOverwrite"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    allowModuleOverwrite = property.Value.GetBoolean();
                    continue;
                }
            }
            return new DscMetaConfiguration(Optional.ToNullable(configurationModeFrequencyMins), Optional.ToNullable(rebootNodeIfNeeded), configurationMode.Value, actionAfterReboot.Value, certificateId.Value, Optional.ToNullable(refreshFrequencyMins), Optional.ToNullable(allowModuleOverwrite));
        }
    }
}
