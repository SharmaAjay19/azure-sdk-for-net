// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Store
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataLake;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for TrustedIdProvidersOperations.
    /// </summary>
    public static partial class TrustedIdProvidersOperationsExtensions
    {
            /// <summary>
            /// Creates or updates the specified trusted identity provider. During update,
            /// the trusted identity provider with the specified name will be replaced with
            /// this new provider
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group that contains the Data Lake Store
            /// account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Store account to add or replace the trusted
            /// identity provider.
            /// </param>
            /// <param name='trustedIdProviderName'>
            /// The name of the trusted identity provider. This is used for differentiation
            /// of providers in the account.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to create or replace the trusted identity provider.
            /// </param>
            public static TrustedIdProvider CreateOrUpdate(this ITrustedIdProvidersOperations operations, string resourceGroupName, string accountName, string trustedIdProviderName, TrustedIdProvider parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, accountName, trustedIdProviderName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates the specified trusted identity provider. During update,
            /// the trusted identity provider with the specified name will be replaced with
            /// this new provider
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group that contains the Data Lake Store
            /// account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Store account to add or replace the trusted
            /// identity provider.
            /// </param>
            /// <param name='trustedIdProviderName'>
            /// The name of the trusted identity provider. This is used for differentiation
            /// of providers in the account.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to create or replace the trusted identity provider.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TrustedIdProvider> CreateOrUpdateAsync(this ITrustedIdProvidersOperations operations, string resourceGroupName, string accountName, string trustedIdProviderName, TrustedIdProvider parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, accountName, trustedIdProviderName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates the specified trusted identity provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group that contains the Data Lake Store
            /// account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Store account to which to update the trusted
            /// identity provider.
            /// </param>
            /// <param name='trustedIdProviderName'>
            /// The name of the trusted identity provider. This is used for differentiation
            /// of providers in the account.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to update the trusted identity provider.
            /// </param>
            public static TrustedIdProvider Update(this ITrustedIdProvidersOperations operations, string resourceGroupName, string accountName, string trustedIdProviderName, UpdateTrustedIdProviderParameters parameters = default(UpdateTrustedIdProviderParameters))
            {
                return operations.UpdateAsync(resourceGroupName, accountName, trustedIdProviderName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the specified trusted identity provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group that contains the Data Lake Store
            /// account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Store account to which to update the trusted
            /// identity provider.
            /// </param>
            /// <param name='trustedIdProviderName'>
            /// The name of the trusted identity provider. This is used for differentiation
            /// of providers in the account.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to update the trusted identity provider.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TrustedIdProvider> UpdateAsync(this ITrustedIdProvidersOperations operations, string resourceGroupName, string accountName, string trustedIdProviderName, UpdateTrustedIdProviderParameters parameters = default(UpdateTrustedIdProviderParameters), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, accountName, trustedIdProviderName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified trusted identity provider from the specified Data
            /// Lake Store account
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group that contains the Data Lake Store
            /// account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Store account from which to delete the trusted
            /// identity provider.
            /// </param>
            /// <param name='trustedIdProviderName'>
            /// The name of the trusted identity provider to delete.
            /// </param>
            public static void Delete(this ITrustedIdProvidersOperations operations, string resourceGroupName, string accountName, string trustedIdProviderName)
            {
                operations.DeleteAsync(resourceGroupName, accountName, trustedIdProviderName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified trusted identity provider from the specified Data
            /// Lake Store account
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group that contains the Data Lake Store
            /// account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Store account from which to delete the trusted
            /// identity provider.
            /// </param>
            /// <param name='trustedIdProviderName'>
            /// The name of the trusted identity provider to delete.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ITrustedIdProvidersOperations operations, string resourceGroupName, string accountName, string trustedIdProviderName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, accountName, trustedIdProviderName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the specified Data Lake Store trusted identity provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group that contains the Data Lake Store
            /// account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Store account from which to get the trusted
            /// identity provider.
            /// </param>
            /// <param name='trustedIdProviderName'>
            /// The name of the trusted identity provider to retrieve.
            /// </param>
            public static TrustedIdProvider Get(this ITrustedIdProvidersOperations operations, string resourceGroupName, string accountName, string trustedIdProviderName)
            {
                return operations.GetAsync(resourceGroupName, accountName, trustedIdProviderName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the specified Data Lake Store trusted identity provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group that contains the Data Lake Store
            /// account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Store account from which to get the trusted
            /// identity provider.
            /// </param>
            /// <param name='trustedIdProviderName'>
            /// The name of the trusted identity provider to retrieve.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TrustedIdProvider> GetAsync(this ITrustedIdProvidersOperations operations, string resourceGroupName, string accountName, string trustedIdProviderName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, accountName, trustedIdProviderName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the Data Lake Store trusted identity providers within the specified
            /// Data Lake Store account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group that contains the Data Lake Store
            /// account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Store account from which to get the trusted
            /// identity providers.
            /// </param>
            public static IPage<TrustedIdProvider> ListByAccount(this ITrustedIdProvidersOperations operations, string resourceGroupName, string accountName)
            {
                return operations.ListByAccountAsync(resourceGroupName, accountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the Data Lake Store trusted identity providers within the specified
            /// Data Lake Store account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group that contains the Data Lake Store
            /// account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Store account from which to get the trusted
            /// identity providers.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<TrustedIdProvider>> ListByAccountAsync(this ITrustedIdProvidersOperations operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByAccountWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the Data Lake Store trusted identity providers within the specified
            /// Data Lake Store account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<TrustedIdProvider> ListByAccountNext(this ITrustedIdProvidersOperations operations, string nextPageLink)
            {
                return operations.ListByAccountNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the Data Lake Store trusted identity providers within the specified
            /// Data Lake Store account.
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
            public static async Task<IPage<TrustedIdProvider>> ListByAccountNextAsync(this ITrustedIdProvidersOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByAccountNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
