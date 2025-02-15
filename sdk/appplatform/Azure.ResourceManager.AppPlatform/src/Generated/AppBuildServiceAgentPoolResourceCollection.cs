// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.AppPlatform
{
    /// <summary>
    /// A class representing a collection of <see cref="AppBuildServiceAgentPoolResource" /> and their operations.
    /// Each <see cref="AppBuildServiceAgentPoolResource" /> in the collection will belong to the same instance of <see cref="AppBuildServiceResource" />.
    /// To get an <see cref="AppBuildServiceAgentPoolResourceCollection" /> instance call the GetAppBuildServiceAgentPoolResources method from an instance of <see cref="AppBuildServiceResource" />.
    /// </summary>
    public partial class AppBuildServiceAgentPoolResourceCollection : ArmCollection, IEnumerable<AppBuildServiceAgentPoolResource>, IAsyncEnumerable<AppBuildServiceAgentPoolResource>
    {
        private readonly ClientDiagnostics _appBuildServiceAgentPoolResourceBuildServiceAgentPoolClientDiagnostics;
        private readonly BuildServiceAgentPoolRestOperations _appBuildServiceAgentPoolResourceBuildServiceAgentPoolRestClient;

        /// <summary> Initializes a new instance of the <see cref="AppBuildServiceAgentPoolResourceCollection"/> class for mocking. </summary>
        protected AppBuildServiceAgentPoolResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AppBuildServiceAgentPoolResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AppBuildServiceAgentPoolResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _appBuildServiceAgentPoolResourceBuildServiceAgentPoolClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppPlatform", AppBuildServiceAgentPoolResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AppBuildServiceAgentPoolResource.ResourceType, out string appBuildServiceAgentPoolResourceBuildServiceAgentPoolApiVersion);
            _appBuildServiceAgentPoolResourceBuildServiceAgentPoolRestClient = new BuildServiceAgentPoolRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, appBuildServiceAgentPoolResourceBuildServiceAgentPoolApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AppBuildServiceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AppBuildServiceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update build service agent pool.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/agentPools/{agentPoolName}
        /// Operation Id: BuildServiceAgentPool_UpdatePut
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="agentPoolName"> The name of the build service agent pool resource. </param>
        /// <param name="data"> Parameters for the update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="agentPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="agentPoolName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AppBuildServiceAgentPoolResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string agentPoolName, AppBuildServiceAgentPoolResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(agentPoolName, nameof(agentPoolName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appBuildServiceAgentPoolResourceBuildServiceAgentPoolClientDiagnostics.CreateScope("AppBuildServiceAgentPoolResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _appBuildServiceAgentPoolResourceBuildServiceAgentPoolRestClient.UpdatePutAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, agentPoolName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppPlatformArmOperation<AppBuildServiceAgentPoolResource>(new AppBuildServiceAgentPoolResourceOperationSource(Client), _appBuildServiceAgentPoolResourceBuildServiceAgentPoolClientDiagnostics, Pipeline, _appBuildServiceAgentPoolResourceBuildServiceAgentPoolRestClient.CreateUpdatePutRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, agentPoolName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update build service agent pool.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/agentPools/{agentPoolName}
        /// Operation Id: BuildServiceAgentPool_UpdatePut
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="agentPoolName"> The name of the build service agent pool resource. </param>
        /// <param name="data"> Parameters for the update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="agentPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="agentPoolName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AppBuildServiceAgentPoolResource> CreateOrUpdate(WaitUntil waitUntil, string agentPoolName, AppBuildServiceAgentPoolResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(agentPoolName, nameof(agentPoolName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appBuildServiceAgentPoolResourceBuildServiceAgentPoolClientDiagnostics.CreateScope("AppBuildServiceAgentPoolResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _appBuildServiceAgentPoolResourceBuildServiceAgentPoolRestClient.UpdatePut(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, agentPoolName, data, cancellationToken);
                var operation = new AppPlatformArmOperation<AppBuildServiceAgentPoolResource>(new AppBuildServiceAgentPoolResourceOperationSource(Client), _appBuildServiceAgentPoolResourceBuildServiceAgentPoolClientDiagnostics, Pipeline, _appBuildServiceAgentPoolResourceBuildServiceAgentPoolRestClient.CreateUpdatePutRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, agentPoolName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get build service agent pool.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/agentPools/{agentPoolName}
        /// Operation Id: BuildServiceAgentPool_Get
        /// </summary>
        /// <param name="agentPoolName"> The name of the build service agent pool resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="agentPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="agentPoolName"/> is null. </exception>
        public virtual async Task<Response<AppBuildServiceAgentPoolResource>> GetAsync(string agentPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(agentPoolName, nameof(agentPoolName));

            using var scope = _appBuildServiceAgentPoolResourceBuildServiceAgentPoolClientDiagnostics.CreateScope("AppBuildServiceAgentPoolResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _appBuildServiceAgentPoolResourceBuildServiceAgentPoolRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, agentPoolName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppBuildServiceAgentPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get build service agent pool.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/agentPools/{agentPoolName}
        /// Operation Id: BuildServiceAgentPool_Get
        /// </summary>
        /// <param name="agentPoolName"> The name of the build service agent pool resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="agentPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="agentPoolName"/> is null. </exception>
        public virtual Response<AppBuildServiceAgentPoolResource> Get(string agentPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(agentPoolName, nameof(agentPoolName));

            using var scope = _appBuildServiceAgentPoolResourceBuildServiceAgentPoolClientDiagnostics.CreateScope("AppBuildServiceAgentPoolResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _appBuildServiceAgentPoolResourceBuildServiceAgentPoolRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, agentPoolName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppBuildServiceAgentPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List build service agent pool.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/agentPools
        /// Operation Id: BuildServiceAgentPool_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AppBuildServiceAgentPoolResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AppBuildServiceAgentPoolResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<AppBuildServiceAgentPoolResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _appBuildServiceAgentPoolResourceBuildServiceAgentPoolClientDiagnostics.CreateScope("AppBuildServiceAgentPoolResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _appBuildServiceAgentPoolResourceBuildServiceAgentPoolRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AppBuildServiceAgentPoolResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<AppBuildServiceAgentPoolResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _appBuildServiceAgentPoolResourceBuildServiceAgentPoolClientDiagnostics.CreateScope("AppBuildServiceAgentPoolResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _appBuildServiceAgentPoolResourceBuildServiceAgentPoolRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AppBuildServiceAgentPoolResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// List build service agent pool.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/agentPools
        /// Operation Id: BuildServiceAgentPool_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AppBuildServiceAgentPoolResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AppBuildServiceAgentPoolResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<AppBuildServiceAgentPoolResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _appBuildServiceAgentPoolResourceBuildServiceAgentPoolClientDiagnostics.CreateScope("AppBuildServiceAgentPoolResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _appBuildServiceAgentPoolResourceBuildServiceAgentPoolRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AppBuildServiceAgentPoolResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<AppBuildServiceAgentPoolResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _appBuildServiceAgentPoolResourceBuildServiceAgentPoolClientDiagnostics.CreateScope("AppBuildServiceAgentPoolResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _appBuildServiceAgentPoolResourceBuildServiceAgentPoolRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AppBuildServiceAgentPoolResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/agentPools/{agentPoolName}
        /// Operation Id: BuildServiceAgentPool_Get
        /// </summary>
        /// <param name="agentPoolName"> The name of the build service agent pool resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="agentPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="agentPoolName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string agentPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(agentPoolName, nameof(agentPoolName));

            using var scope = _appBuildServiceAgentPoolResourceBuildServiceAgentPoolClientDiagnostics.CreateScope("AppBuildServiceAgentPoolResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _appBuildServiceAgentPoolResourceBuildServiceAgentPoolRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, agentPoolName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/agentPools/{agentPoolName}
        /// Operation Id: BuildServiceAgentPool_Get
        /// </summary>
        /// <param name="agentPoolName"> The name of the build service agent pool resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="agentPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="agentPoolName"/> is null. </exception>
        public virtual Response<bool> Exists(string agentPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(agentPoolName, nameof(agentPoolName));

            using var scope = _appBuildServiceAgentPoolResourceBuildServiceAgentPoolClientDiagnostics.CreateScope("AppBuildServiceAgentPoolResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _appBuildServiceAgentPoolResourceBuildServiceAgentPoolRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, agentPoolName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AppBuildServiceAgentPoolResource> IEnumerable<AppBuildServiceAgentPoolResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AppBuildServiceAgentPoolResource> IAsyncEnumerable<AppBuildServiceAgentPoolResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
