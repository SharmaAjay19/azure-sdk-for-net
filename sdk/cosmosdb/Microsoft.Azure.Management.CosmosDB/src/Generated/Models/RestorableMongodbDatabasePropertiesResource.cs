// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class RestorableMongodbDatabasePropertiesResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// RestorableMongodbDatabasePropertiesResource class.
        /// </summary>
        public RestorableMongodbDatabasePropertiesResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// RestorableMongodbDatabasePropertiesResource class.
        /// </summary>
        /// <param name="_rid">A system generated property. A unique
        /// identifier.</param>
        /// <param name="operationType">The operation type of this database
        /// event. Possible values include: 'Create', 'Replace', 'Delete',
        /// 'SystemOperation'</param>
        /// <param name="eventTimestamp">The timestamp of this database
        /// event.</param>
        /// <param name="ownerId">The name of this restorable MongoDB
        /// database.</param>
        /// <param name="ownerResourceId">The resource Id of this restorable
        /// MongoDB database.</param>
        public RestorableMongodbDatabasePropertiesResource(string _rid = default(string), string operationType = default(string), string eventTimestamp = default(string), string ownerId = default(string), string ownerResourceId = default(string))
        {
            this._rid = _rid;
            OperationType = operationType;
            EventTimestamp = eventTimestamp;
            OwnerId = ownerId;
            OwnerResourceId = ownerResourceId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets a system generated property. A unique identifier.
        /// </summary>
        [JsonProperty(PropertyName = "_rid")]
        public string _rid { get; private set; }

        /// <summary>
        /// Gets the operation type of this database event. Possible values
        /// include: 'Create', 'Replace', 'Delete', 'SystemOperation'
        /// </summary>
        [JsonProperty(PropertyName = "operationType")]
        public string OperationType { get; private set; }

        /// <summary>
        /// Gets the timestamp of this database event.
        /// </summary>
        [JsonProperty(PropertyName = "eventTimestamp")]
        public string EventTimestamp { get; private set; }

        /// <summary>
        /// Gets the name of this restorable MongoDB database.
        /// </summary>
        [JsonProperty(PropertyName = "ownerId")]
        public string OwnerId { get; private set; }

        /// <summary>
        /// Gets the resource Id of this restorable MongoDB database.
        /// </summary>
        [JsonProperty(PropertyName = "ownerResourceId")]
        public string OwnerResourceId { get; private set; }

    }
}
