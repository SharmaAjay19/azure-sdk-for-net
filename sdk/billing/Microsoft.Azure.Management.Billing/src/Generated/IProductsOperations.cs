// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// ProductsOperations operations.
    /// </summary>
    public partial interface IProductsOperations
    {
        /// <summary>
        /// Lists the products for a customer. These don't include products
        /// billed based on usage.The operation is supported only for billing
        /// accounts with agreement type Microsoft Partner Agreement.
        /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
        /// </summary>
        /// <param name='billingAccountName'>
        /// The ID that uniquely identifies a billing account.
        /// </param>
        /// <param name='customerName'>
        /// The ID that uniquely identifies a customer.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<Product>>> ListByCustomerWithHttpMessagesAsync(string billingAccountName, string customerName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the products for a billing account. These don't include
        /// products billed based on usage. The operation is supported for
        /// billing accounts with agreement type Microsoft Customer Agreement
        /// or Microsoft Partner Agreement.
        /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
        /// </summary>
        /// <param name='billingAccountName'>
        /// The ID that uniquely identifies a billing account.
        /// </param>
        /// <param name='filter'>
        /// May be used to filter by product type. The filter supports 'eq',
        /// 'lt', 'gt', 'le', 'ge', and 'and'. It does not currently support
        /// 'ne', 'or', or 'not'. Tag filter is a key value pair string where
        /// key and value are separated by a colon (:).
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<Product>>> ListByBillingAccountWithHttpMessagesAsync(string billingAccountName, string filter = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the products for a billing profile. These don't include
        /// products billed based on usage. The operation is supported for
        /// billing accounts with agreement type Microsoft Customer Agreement
        /// or Microsoft Partner Agreement.
        /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
        /// </summary>
        /// <param name='billingAccountName'>
        /// The ID that uniquely identifies a billing account.
        /// </param>
        /// <param name='billingProfileName'>
        /// The ID that uniquely identifies a billing profile.
        /// </param>
        /// <param name='filter'>
        /// May be used to filter by product type. The filter supports 'eq',
        /// 'lt', 'gt', 'le', 'ge', and 'and'. It does not currently support
        /// 'ne', 'or', or 'not'. Tag filter is a key value pair string where
        /// key and value are separated by a colon (:).
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<Product>>> ListByBillingProfileWithHttpMessagesAsync(string billingAccountName, string billingProfileName, string filter = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the products for an invoice section. These don't include
        /// products billed based on usage. The operation is supported only for
        /// billing accounts with agreement type Microsoft Customer Agreement.
        /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
        /// </summary>
        /// <param name='billingAccountName'>
        /// The ID that uniquely identifies a billing account.
        /// </param>
        /// <param name='billingProfileName'>
        /// The ID that uniquely identifies a billing profile.
        /// </param>
        /// <param name='invoiceSectionName'>
        /// The ID that uniquely identifies an invoice section.
        /// </param>
        /// <param name='filter'>
        /// May be used to filter by product type. The filter supports 'eq',
        /// 'lt', 'gt', 'le', 'ge', and 'and'. It does not currently support
        /// 'ne', 'or', or 'not'. Tag filter is a key value pair string where
        /// key and value are separated by a colon (:).
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<Product>>> ListByInvoiceSectionWithHttpMessagesAsync(string billingAccountName, string billingProfileName, string invoiceSectionName, string filter = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a product by ID. The operation is supported only for billing
        /// accounts with agreement type Microsoft Customer Agreement.
        /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
        /// </summary>
        /// <param name='billingAccountName'>
        /// The ID that uniquely identifies a billing account.
        /// </param>
        /// <param name='productName'>
        /// The ID that uniquely identifies a product.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<Product>> GetWithHttpMessagesAsync(string billingAccountName, string productName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates the properties of a Product. Currently, auto renew can be
        /// updated. The operation is supported only for billing accounts with
        /// agreement type Microsoft Customer Agreement.
        /// </summary>
        /// <param name='billingAccountName'>
        /// The ID that uniquely identifies a billing account.
        /// </param>
        /// <param name='productName'>
        /// The ID that uniquely identifies a product.
        /// </param>
        /// <param name='parameters'>
        /// Request parameters that are provided to the update product
        /// operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<Product>> UpdateWithHttpMessagesAsync(string billingAccountName, string productName, Product parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Moves a product's charges to a new invoice section. The new invoice
        /// section must belong to the same billing profile as the existing
        /// invoice section. This operation is supported only for products that
        /// are purchased with a recurring charge and for billing accounts with
        /// agreement type Microsoft Customer Agreement.
        /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
        /// </summary>
        /// <param name='billingAccountName'>
        /// The ID that uniquely identifies a billing account.
        /// </param>
        /// <param name='productName'>
        /// The ID that uniquely identifies a product.
        /// </param>
        /// <param name='parameters'>
        /// Request parameters that are provided to the move product operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<Product,ProductsMoveHeaders>> MoveWithHttpMessagesAsync(string billingAccountName, string productName, TransferProductRequestProperties parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Validates if a product's charges can be moved to a new invoice
        /// section. This operation is supported only for products that are
        /// purchased with a recurring charge and for billing accounts with
        /// agreement type Microsoft Customer Agreement.
        /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
        /// </summary>
        /// <param name='billingAccountName'>
        /// The ID that uniquely identifies a billing account.
        /// </param>
        /// <param name='productName'>
        /// The ID that uniquely identifies a product.
        /// </param>
        /// <param name='parameters'>
        /// Request parameters that are provided to the validate move
        /// eligibility operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ValidateProductTransferEligibilityResult>> ValidateMoveWithHttpMessagesAsync(string billingAccountName, string productName, TransferProductRequestProperties parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the products for a customer. These don't include products
        /// billed based on usage.The operation is supported only for billing
        /// accounts with agreement type Microsoft Partner Agreement.
        /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
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
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<Product>>> ListByCustomerNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the products for a billing account. These don't include
        /// products billed based on usage. The operation is supported for
        /// billing accounts with agreement type Microsoft Customer Agreement
        /// or Microsoft Partner Agreement.
        /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
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
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<Product>>> ListByBillingAccountNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the products for a billing profile. These don't include
        /// products billed based on usage. The operation is supported for
        /// billing accounts with agreement type Microsoft Customer Agreement
        /// or Microsoft Partner Agreement.
        /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
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
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<Product>>> ListByBillingProfileNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the products for an invoice section. These don't include
        /// products billed based on usage. The operation is supported only for
        /// billing accounts with agreement type Microsoft Customer Agreement.
        /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
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
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<Product>>> ListByInvoiceSectionNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
