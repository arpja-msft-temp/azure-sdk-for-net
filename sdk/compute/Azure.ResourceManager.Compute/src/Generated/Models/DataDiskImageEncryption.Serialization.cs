// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class DataDiskImageEncryption : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("lun");
            writer.WriteNumberValue(Lun);
            if (DiskEncryptionSetId != null)
            {
                writer.WritePropertyName("diskEncryptionSetId");
                writer.WriteStringValue(DiskEncryptionSetId);
            }
            writer.WriteEndObject();
        }

        internal static DataDiskImageEncryption DeserializeDataDiskImageEncryption(JsonElement element)
        {
            int lun = default;
            string diskEncryptionSetId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lun"))
                {
                    lun = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("diskEncryptionSetId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskEncryptionSetId = property.Value.GetString();
                    continue;
                }
            }
            return new DataDiskImageEncryption(diskEncryptionSetId, lun);
        }
    }
}