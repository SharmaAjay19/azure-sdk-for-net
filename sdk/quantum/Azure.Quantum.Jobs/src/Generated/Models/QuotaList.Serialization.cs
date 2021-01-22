// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Quantum.Jobs.Models
{
    public partial class QuotaList
    {
        internal static QuotaList DeserializeQuotaList(JsonElement element)
        {
            Optional<IReadOnlyList<Quota>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<Quota> array = new List<Quota>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Quota.DeserializeQuota(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new QuotaList(Optional.ToList(value), nextLink.Value);
        }
    }
}
