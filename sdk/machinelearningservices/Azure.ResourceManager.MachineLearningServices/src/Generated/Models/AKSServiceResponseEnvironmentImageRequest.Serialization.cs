// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    public partial class AKSServiceResponseEnvironmentImageRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DriverProgram))
            {
                writer.WritePropertyName("driverProgram");
                writer.WriteStringValue(DriverProgram);
            }
            if (Optional.IsCollectionDefined(Assets))
            {
                writer.WritePropertyName("assets");
                writer.WriteStartArray();
                foreach (var item in Assets)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ModelIds))
            {
                writer.WritePropertyName("modelIds");
                writer.WriteStartArray();
                foreach (var item in ModelIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Models))
            {
                writer.WritePropertyName("models");
                writer.WriteStartArray();
                foreach (var item in Models)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Environment))
            {
                writer.WritePropertyName("environment");
                writer.WriteObjectValue(Environment);
            }
            if (Optional.IsDefined(EnvironmentReference))
            {
                writer.WritePropertyName("environmentReference");
                writer.WriteObjectValue(EnvironmentReference);
            }
            writer.WriteEndObject();
        }

        internal static AKSServiceResponseEnvironmentImageRequest DeserializeAKSServiceResponseEnvironmentImageRequest(JsonElement element)
        {
            Optional<string> driverProgram = default;
            Optional<IList<ImageAsset>> assets = default;
            Optional<IList<string>> modelIds = default;
            Optional<IList<Model>> models = default;
            Optional<EnvironmentImageResponseEnvironment> environment = default;
            Optional<EnvironmentImageResponseEnvironmentReference> environmentReference = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("driverProgram"))
                {
                    driverProgram = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("assets"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ImageAsset> array = new List<ImageAsset>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ImageAsset.DeserializeImageAsset(item));
                    }
                    assets = array;
                    continue;
                }
                if (property.NameEquals("modelIds"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    modelIds = array;
                    continue;
                }
                if (property.NameEquals("models"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<Model> array = new List<Model>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Model.DeserializeModel(item));
                    }
                    models = array;
                    continue;
                }
                if (property.NameEquals("environment"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    environment = EnvironmentImageResponseEnvironment.DeserializeEnvironmentImageResponseEnvironment(property.Value);
                    continue;
                }
                if (property.NameEquals("environmentReference"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    environmentReference = EnvironmentImageResponseEnvironmentReference.DeserializeEnvironmentImageResponseEnvironmentReference(property.Value);
                    continue;
                }
            }
            return new AKSServiceResponseEnvironmentImageRequest(driverProgram.Value, Optional.ToList(assets), Optional.ToList(modelIds), Optional.ToList(models), environment.Value, environmentReference.Value);
        }
    }
}
