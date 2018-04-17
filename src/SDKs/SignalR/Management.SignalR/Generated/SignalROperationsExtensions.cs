// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SignalR
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SignalrOperations.
    /// </summary>
    public static partial class SignalrOperationsExtensions
    {
            /// <summary>
            /// Lists all of the available REST API operations of the
            /// Microsoft.SignalRService provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<Operation> ListOperations(this ISignalrOperations operations)
            {
                return operations.ListOperationsAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all of the available REST API operations of the
            /// Microsoft.SignalRService provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Operation>> ListOperationsAsync(this ISignalrOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListOperationsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Checks that the SignalR name is valid and is not already in use.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the operation.
            /// </param>
            public static NameAvailability CheckNameAvailability(this ISignalrOperations operations, NameAvailabilityParameters parameters = default(NameAvailabilityParameters))
            {
                return operations.CheckNameAvailabilityAsync(parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Checks that the SignalR name is valid and is not already in use.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NameAvailability> CheckNameAvailabilityAsync(this ISignalrOperations operations, NameAvailabilityParameters parameters = default(NameAvailabilityParameters), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CheckNameAvailabilityWithHttpMessagesAsync(parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Handles requests to list all resources in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<SignalRResource> ListBySubscription(this ISignalrOperations operations)
            {
                return operations.ListBySubscriptionAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Handles requests to list all resources in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SignalRResource>> ListBySubscriptionAsync(this ISignalrOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Handles requests to list all resources in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            public static IPage<SignalRResource> ListByResourceGroup(this ISignalrOperations operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Handles requests to list all resources in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SignalRResource>> ListByResourceGroupAsync(this ISignalrOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the access keys of the SignalR resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the SignalR resource.
            /// </param>
            public static SignalRKeys ListKeys(this ISignalrOperations operations, string resourceGroupName, string resourceName)
            {
                return operations.ListKeysAsync(resourceGroupName, resourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the access keys of the SignalR resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the SignalR resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SignalRKeys> ListKeysAsync(this ISignalrOperations operations, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListKeysWithHttpMessagesAsync(resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Regenerate SignalR service access key. PrimaryKey and SecondaryKey cannot
            /// be regenerated at the same time.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the SignalR resource.
            /// </param>
            /// <param name='parameters'>
            /// Parameter that describes the Regenerate Key Operation.
            /// </param>
            public static SignalRKeys RegenerateKey(this ISignalrOperations operations, string resourceGroupName, string resourceName, RegenerateKeyParameters parameters = default(RegenerateKeyParameters))
            {
                return operations.RegenerateKeyAsync(resourceGroupName, resourceName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Regenerate SignalR service access key. PrimaryKey and SecondaryKey cannot
            /// be regenerated at the same time.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the SignalR resource.
            /// </param>
            /// <param name='parameters'>
            /// Parameter that describes the Regenerate Key Operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SignalRKeys> RegenerateKeyAsync(this ISignalrOperations operations, string resourceGroupName, string resourceName, RegenerateKeyParameters parameters = default(RegenerateKeyParameters), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RegenerateKeyWithHttpMessagesAsync(resourceGroupName, resourceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the SignalR service and its properties.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the SignalR resource.
            /// </param>
            public static SignalRResource Get(this ISignalrOperations operations, string resourceGroupName, string resourceName)
            {
                return operations.GetAsync(resourceGroupName, resourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the SignalR service and its properties.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the SignalR resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SignalRResource> GetAsync(this ISignalrOperations operations, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create a new SignalR service and update an exiting SignalR service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the SignalR resource.
            /// </param>
            /// <param name='parameters'>
            /// Parameters for the create or update operation
            /// </param>
            public static SignalRResource CreateOrUpdate(this ISignalrOperations operations, string resourceGroupName, string resourceName, SignalRCreateParameters parameters = default(SignalRCreateParameters))
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, resourceName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a new SignalR service and update an exiting SignalR service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the SignalR resource.
            /// </param>
            /// <param name='parameters'>
            /// Parameters for the create or update operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SignalRResource> CreateOrUpdateAsync(this ISignalrOperations operations, string resourceGroupName, string resourceName, SignalRCreateParameters parameters = default(SignalRCreateParameters), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, resourceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Operation to delete a SignalR service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the SignalR resource.
            /// </param>
            public static void Delete(this ISignalrOperations operations, string resourceGroupName, string resourceName)
            {
                operations.DeleteAsync(resourceGroupName, resourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Operation to delete a SignalR service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the SignalR resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ISignalrOperations operations, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Operation to update an exiting SignalR service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the SignalR resource.
            /// </param>
            /// <param name='parameters'>
            /// Parameters for the update operation
            /// </param>
            public static SignalRResource Update(this ISignalrOperations operations, string resourceGroupName, string resourceName, SignalRUpdateParameters parameters = default(SignalRUpdateParameters))
            {
                return operations.UpdateAsync(resourceGroupName, resourceName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Operation to update an exiting SignalR service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the SignalR resource.
            /// </param>
            /// <param name='parameters'>
            /// Parameters for the update operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SignalRResource> UpdateAsync(this ISignalrOperations operations, string resourceGroupName, string resourceName, SignalRUpdateParameters parameters = default(SignalRUpdateParameters), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, resourceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Regenerate SignalR service access key. PrimaryKey and SecondaryKey cannot
            /// be regenerated at the same time.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the SignalR resource.
            /// </param>
            /// <param name='parameters'>
            /// Parameter that describes the Regenerate Key Operation.
            /// </param>
            public static SignalRKeys BeginRegenerateKey(this ISignalrOperations operations, string resourceGroupName, string resourceName, RegenerateKeyParameters parameters = default(RegenerateKeyParameters))
            {
                return operations.BeginRegenerateKeyAsync(resourceGroupName, resourceName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Regenerate SignalR service access key. PrimaryKey and SecondaryKey cannot
            /// be regenerated at the same time.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the SignalR resource.
            /// </param>
            /// <param name='parameters'>
            /// Parameter that describes the Regenerate Key Operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SignalRKeys> BeginRegenerateKeyAsync(this ISignalrOperations operations, string resourceGroupName, string resourceName, RegenerateKeyParameters parameters = default(RegenerateKeyParameters), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginRegenerateKeyWithHttpMessagesAsync(resourceGroupName, resourceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create a new SignalR service and update an exiting SignalR service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the SignalR resource.
            /// </param>
            /// <param name='parameters'>
            /// Parameters for the create or update operation
            /// </param>
            public static SignalRResource BeginCreateOrUpdate(this ISignalrOperations operations, string resourceGroupName, string resourceName, SignalRCreateParameters parameters = default(SignalRCreateParameters))
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, resourceName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a new SignalR service and update an exiting SignalR service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the SignalR resource.
            /// </param>
            /// <param name='parameters'>
            /// Parameters for the create or update operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SignalRResource> BeginCreateOrUpdateAsync(this ISignalrOperations operations, string resourceGroupName, string resourceName, SignalRCreateParameters parameters = default(SignalRCreateParameters), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, resourceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Operation to delete a SignalR service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the SignalR resource.
            /// </param>
            public static void BeginDelete(this ISignalrOperations operations, string resourceGroupName, string resourceName)
            {
                operations.BeginDeleteAsync(resourceGroupName, resourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Operation to delete a SignalR service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the SignalR resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this ISignalrOperations operations, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Operation to update an exiting SignalR service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the SignalR resource.
            /// </param>
            /// <param name='parameters'>
            /// Parameters for the update operation
            /// </param>
            public static SignalRResource BeginUpdate(this ISignalrOperations operations, string resourceGroupName, string resourceName, SignalRUpdateParameters parameters = default(SignalRUpdateParameters))
            {
                return operations.BeginUpdateAsync(resourceGroupName, resourceName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Operation to update an exiting SignalR service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the SignalR resource.
            /// </param>
            /// <param name='parameters'>
            /// Parameters for the update operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SignalRResource> BeginUpdateAsync(this ISignalrOperations operations, string resourceGroupName, string resourceName, SignalRUpdateParameters parameters = default(SignalRUpdateParameters), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, resourceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all of the available REST API operations of the
            /// Microsoft.SignalRService provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Operation> ListOperationsNext(this ISignalrOperations operations, string nextPageLink)
            {
                return operations.ListOperationsNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all of the available REST API operations of the
            /// Microsoft.SignalRService provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Operation>> ListOperationsNextAsync(this ISignalrOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListOperationsNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Handles requests to list all resources in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<SignalRResource> ListBySubscriptionNext(this ISignalrOperations operations, string nextPageLink)
            {
                return operations.ListBySubscriptionNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Handles requests to list all resources in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SignalRResource>> ListBySubscriptionNextAsync(this ISignalrOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Handles requests to list all resources in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<SignalRResource> ListByResourceGroupNext(this ISignalrOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Handles requests to list all resources in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SignalRResource>> ListByResourceGroupNextAsync(this ISignalrOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
