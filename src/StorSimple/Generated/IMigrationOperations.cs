// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Management.StorSimple.Models;

namespace Microsoft.WindowsAzure.Management.StorSimple
{
    /// <summary>
    /// Migration of Legacy Appliance
    /// </summary>
    public partial interface IMigrationOperations
    {
        /// <summary>
        /// Hydra spec for update data container statusThe rest api updates the
        /// status of volume container migration from target device to service
        /// for all volume container in the specified config
        /// </summary>
        /// <param name='configId'>
        /// Unique identifier for config specified while importing the config
        /// to service
        /// </param>
        /// <param name='customRequestHeaders'>
        /// The Custom Request Headers which client must use.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// This is the Task Response for all Async Calls
        /// </returns>
        Task<TaskResponse> BeginUpdateDataContainerMigrationStatusAsync(string configId, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Hydra spec for update confirm migration statusThe rest api updates
        /// the confirm (commit/rollback) status from target appliance to
        /// service for all data container in the specified config
        /// </summary>
        /// <param name='configId'>
        /// Unique identifier for config specified while importing the config
        /// to service
        /// </param>
        /// <param name='customRequestHeaders'>
        /// The Custom Request Headers which client must use.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// This is the Task Response for all Async Calls
        /// </returns>
        Task<TaskResponse> BeginUpdateMigrationConfirmStatusAsync(string configId, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Hydra spec update migration plan rest apiThe rest api updates the
        /// migration plan from target appliance to service for all volume
        /// container(s) in the specified config
        /// </summary>
        /// <param name='configId'>
        /// Unique identifier for config specified while importing the config
        /// to service
        /// </param>
        /// <param name='customRequestHeaders'>
        /// The Custom Request Headers which client must use.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// This is the Task Response for all Async Calls
        /// </returns>
        Task<TaskResponse> BeginUpdateMigrationPlanAsync(string configId, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Hydra spec for confirm migration rest apiThe rest api confirms the
        /// commit or rollback of the migrated data containers for all data
        /// container in the specified config
        /// </summary>
        /// <param name='configId'>
        /// Unique identifier for config specified while importing the config
        /// to service
        /// </param>
        /// <param name='confirmMigrationRequest'>
        /// The confirm migration request specifies the list of volume
        /// containers and rollback/commit operation to be performed
        /// </param>
        /// <param name='customRequestHeaders'>
        /// The Custom Request Headers which client must use.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for migration job status.
        /// </returns>
        Task<MigrationJobStatus> ConfirmMigrationAsync(string configId, MigrationConfirmStatusRequest confirmMigrationRequest, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Hydra spec for Get all migration rest apiThe rest api returns the
        /// config ids for all configs imported against the selected
        /// storsimple resource
        /// </summary>
        /// <param name='customRequestHeaders'>
        /// The Custom Request Headers which client must use.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body for get migration plan rest api.
        /// </returns>
        Task<MigrationPlanList> GetAllMigrationPlanAsync(CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Hydra spec for Get data container migration statusThe rest api
        /// returns the status of volume container migration status from
        /// service for all volume container in the specified config
        /// </summary>
        /// <param name='configId'>
        /// Unique identifier for config specified while importing the config
        /// to service
        /// </param>
        /// <param name='customRequestHeaders'>
        /// The Custom Request Headers which client must use.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body for get data container migration status.
        /// </returns>
        Task<MigrationDataContainerStatusList> GetDataContainerMigrationStatusAsync(string configId, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Hydra spec for get confirm migration status rest apiThe rest api
        /// gets the confirm (commit/rollback) status from service for all
        /// volume container in the specified config
        /// </summary>
        /// <param name='configId'>
        /// Unique identifier for config specified while importing the config
        /// to service
        /// </param>
        /// <param name='customRequestHeaders'>
        /// The Custom Request Headers which client must use.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body of migration confirm status rest api.
        /// </returns>
        Task<MigrationConfirmStatus> GetMigrationConfirmStatusAsync(string configId, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Hydra spec for get migration planThe rest api get the migration
        /// plan from service for all volume container(s) in the specified
        /// config
        /// </summary>
        /// <param name='configId'>
        /// Unique identifier for config specified while importing the config
        /// to service
        /// </param>
        /// <param name='customRequestHeaders'>
        /// The Custom Request Headers which client must use.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body for get migration plan rest api.
        /// </returns>
        Task<MigrationPlanList> GetMigrationPlanAsync(string configId, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Hydra spec for import legacy appliance config rest api.The rest api
        /// imports the legacy config to the service
        /// </summary>
        /// <param name='configId'>
        /// Unique id for config being imported
        /// </param>
        /// <param name='request'>
        /// Legacy appliance config to be imported
        /// </param>
        /// <param name='customRequestHeaders'>
        /// The Custom Request Headers which client must use.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> ImportLegacyApplianceConfigAsync(string configId, LegacyApplianceConfig request, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Hydra spec for import data container rest apiThe rest api initiates
        /// the migration of volume containers for all/specific data
        /// container(s) in the given config
        /// </summary>
        /// <param name='configId'>
        /// Unique identifier for config specified while importing the config
        /// to service
        /// </param>
        /// <param name='importDCRequest'>
        /// Import data container request which specifies the list of data
        /// containers to be migrated
        /// </param>
        /// <param name='customRequestHeaders'>
        /// The Custom Request Headers which client must use.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for migration job status.
        /// </returns>
        Task<MigrationJobStatus> MigrationImportDataContainerAsync(string configId, MigrationImportDataContainerRequest importDCRequest, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Hydra spec for start migration plan rest APIThe rest api starts the
        /// estimation of time taken by migration for all/specific volume
        /// container(s) in the given config
        /// </summary>
        /// <param name='startPlanRequest'>
        /// Start migration plan request model. The object passes the list of
        /// volume container(s) whose migration ETA needs to calculated
        /// </param>
        /// <param name='customRequestHeaders'>
        /// The Custom Request Headers which client must use.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for migration job status.
        /// </returns>
        Task<MigrationJobStatus> StartMigrationPlanAsync(MigrationPlanStartRequest startPlanRequest, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <param name='configId'>
        /// configId
        /// </param>
        /// <param name='customRequestHeaders'>
        /// The Custom Request Headers which client must use.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Info about the async task
        /// </returns>
        Task<TaskStatusInfo> UpdateDataContainerMigrationStatusAsync(string configId, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <param name='configId'>
        /// The legacy config id for which migration confirm status needs to be
        /// updated
        /// </param>
        /// <param name='customRequestHeaders'>
        /// The Custom Request Headers which client must use.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Info about the async task
        /// </returns>
        Task<TaskStatusInfo> UpdateMigrationConfirmStatusAsync(string configId, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <param name='configId'>
        /// configId
        /// </param>
        /// <param name='customRequestHeaders'>
        /// The Custom Request Headers which client must use.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Info about the async task
        /// </returns>
        Task<TaskStatusInfo> UpdateMigrationPlanAsync(string configId, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
    }
}
