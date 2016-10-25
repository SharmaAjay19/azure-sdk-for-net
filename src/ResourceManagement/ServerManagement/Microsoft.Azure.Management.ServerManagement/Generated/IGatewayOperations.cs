// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ServerManagement
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// GatewayOperations operations.
    /// </summary>
    public partial interface IGatewayOperations
    {
        /// <summary>
        /// Creates or updates a ManagementService gateway.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name uniquely identifies the resource group
        /// within the user subscriptionId.
        /// </param>
        /// <param name='gatewayName'>
        /// The gateway name (256 characters maximum).
        /// </param>
        /// <param name='location'>
        /// location of the resource
        /// </param>
        /// <param name='tags'>
        /// resource tags
        /// </param>
        /// <param name='upgradeMode'>
        /// The upgradeMode property gives the flexibility to gateway to auto
        /// upgrade itself. If properties value not specified, then we assume
        /// upgradeMode = Automatic. Possible values include: 'Manual',
        /// 'Automatic'
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<GatewayResource>> CreateWithHttpMessagesAsync(string resourceGroupName, string gatewayName, string location = default(string), object tags = default(object), UpgradeMode? upgradeMode = default(UpgradeMode?), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Creates or updates a ManagementService gateway.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name uniquely identifies the resource group
        /// within the user subscriptionId.
        /// </param>
        /// <param name='gatewayName'>
        /// The gateway name (256 characters maximum).
        /// </param>
        /// <param name='location'>
        /// location of the resource
        /// </param>
        /// <param name='tags'>
        /// resource tags
        /// </param>
        /// <param name='upgradeMode'>
        /// The upgradeMode property gives the flexibility to gateway to auto
        /// upgrade itself. If properties value not specified, then we assume
        /// upgradeMode = Automatic. Possible values include: 'Manual',
        /// 'Automatic'
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<GatewayResource>> BeginCreateWithHttpMessagesAsync(string resourceGroupName, string gatewayName, string location = default(string), object tags = default(object), UpgradeMode? upgradeMode = default(UpgradeMode?), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Updates a gateway belonging to a resource group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name uniquely identifies the resource group
        /// within the user subscriptionId.
        /// </param>
        /// <param name='gatewayName'>
        /// The gateway name (256 characters maximum).
        /// </param>
        /// <param name='location'>
        /// location of the resource
        /// </param>
        /// <param name='tags'>
        /// resource tags
        /// </param>
        /// <param name='upgradeMode'>
        /// The upgradeMode property gives the flexibility to gateway to auto
        /// upgrade itself. If properties value not specified, then we assume
        /// upgradeMode = Automatic. Possible values include: 'Manual',
        /// 'Automatic'
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<GatewayResource>> UpdateWithHttpMessagesAsync(string resourceGroupName, string gatewayName, string location = default(string), object tags = default(object), UpgradeMode? upgradeMode = default(UpgradeMode?), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Updates a gateway belonging to a resource group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name uniquely identifies the resource group
        /// within the user subscriptionId.
        /// </param>
        /// <param name='gatewayName'>
        /// The gateway name (256 characters maximum).
        /// </param>
        /// <param name='location'>
        /// location of the resource
        /// </param>
        /// <param name='tags'>
        /// resource tags
        /// </param>
        /// <param name='upgradeMode'>
        /// The upgradeMode property gives the flexibility to gateway to auto
        /// upgrade itself. If properties value not specified, then we assume
        /// upgradeMode = Automatic. Possible values include: 'Manual',
        /// 'Automatic'
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<GatewayResource>> BeginUpdateWithHttpMessagesAsync(string resourceGroupName, string gatewayName, string location = default(string), object tags = default(object), UpgradeMode? upgradeMode = default(UpgradeMode?), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Deletes a gateway from a resource group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name uniquely identifies the resource group
        /// within the user subscriptionId.
        /// </param>
        /// <param name='gatewayName'>
        /// The gateway name (256 characters maximum).
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string gatewayName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Returns a gateway
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name uniquely identifies the resource group
        /// within the user subscriptionId.
        /// </param>
        /// <param name='gatewayName'>
        /// The gateway name (256 characters maximum)
        /// </param>
        /// <param name='expand'>
        /// Gets subscription credentials which uniquely identify Microsoft
        /// Azure subscription. The subscription ID forms part of the URI for
        /// every service call. Possible values include: 'status', 'download'
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<GatewayResource>> GetWithHttpMessagesAsync(string resourceGroupName, string gatewayName, GatewayExpandOption? expand = default(GatewayExpandOption?), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Returns gateways in a subscription
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<GatewayResource>>> ListWithHttpMessagesAsync(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Returns gateways in a resource group
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name uniquely identifies the resource group
        /// within the user subscriptionId.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<GatewayResource>>> ListForResourceGroupWithHttpMessagesAsync(string resourceGroupName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Upgrade a gateway
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name uniquely identifies the resource group
        /// within the user subscriptionId.
        /// </param>
        /// <param name='gatewayName'>
        /// The gateway name (256 characters maximum).
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse> UpgradeWithHttpMessagesAsync(string resourceGroupName, string gatewayName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Upgrade a gateway
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name uniquely identifies the resource group
        /// within the user subscriptionId.
        /// </param>
        /// <param name='gatewayName'>
        /// The gateway name (256 characters maximum).
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse> BeginUpgradeWithHttpMessagesAsync(string resourceGroupName, string gatewayName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Regenerate a gateway's profile
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name uniquely identifies the resource group
        /// within the user subscriptionId.
        /// </param>
        /// <param name='gatewayName'>
        /// The gateway name (256 characters maximum).
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse> RegenerateProfileWithHttpMessagesAsync(string resourceGroupName, string gatewayName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Regenerate a gateway's profile
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name uniquely identifies the resource group
        /// within the user subscriptionId.
        /// </param>
        /// <param name='gatewayName'>
        /// The gateway name (256 characters maximum).
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse> BeginRegenerateProfileWithHttpMessagesAsync(string resourceGroupName, string gatewayName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Gets a gateway profile
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name uniquely identifies the resource group
        /// within the user subscriptionId.
        /// </param>
        /// <param name='gatewayName'>
        /// The gateway name (256 characters maximum).
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<GatewayProfile>> GetProfileWithHttpMessagesAsync(string resourceGroupName, string gatewayName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Gets a gateway profile
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name uniquely identifies the resource group
        /// within the user subscriptionId.
        /// </param>
        /// <param name='gatewayName'>
        /// The gateway name (256 characters maximum).
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<GatewayProfile>> BeginGetProfileWithHttpMessagesAsync(string resourceGroupName, string gatewayName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Returns gateways in a subscription
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<GatewayResource>>> ListNextWithHttpMessagesAsync(string nextPageLink, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Returns gateways in a resource group
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<GatewayResource>>> ListForResourceGroupNextWithHttpMessagesAsync(string nextPageLink, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }
}
