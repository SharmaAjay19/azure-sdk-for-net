// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class EntityRecognitionTasksItemProperties
    {
        internal static EntityRecognitionTasksItemProperties DeserializeEntityRecognitionTasksItemProperties(JsonElement element)
        {
            EntitiesResult results = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("results"))
                {
                    results = EntitiesResult.DeserializeEntitiesResult(property.Value);
                    continue;
                }
            }
            return new EntityRecognitionTasksItemProperties(results);
        }
    }
}
