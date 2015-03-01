﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.Sql.Security.Model;
using Microsoft.Azure.Commands.Sql.Security.Services;
using Microsoft.Azure.Common.Extensions.Models;

namespace Microsoft.Azure.Commands.Sql.Security.Cmdlet.SecureConnection
{
    /// <summary>
    /// The base class for all Azure Sql Database security Management Cmdlets
    /// </summary>
    public abstract class SqlDatabaseSecureConnectionCmdletBase : SqlDatabaseCmdletBase<DatabaseSecureConnectionPolicyModel, SqlSecureConnectionAdapter>
    {
        /// <summary>
        /// Provides the model element that this cmdlet operates on
        /// </summary>
        /// <returns>A model object</returns>
        protected override DatabaseSecureConnectionPolicyModel GetModel()
        {
            return ModelAdapter.GetDatabaseSecureConnectionPolicy(ResourceGroupName, ServerName, DatabaseName, clientRequestId);
        }

        protected override SqlSecureConnectionAdapter InitModelAdapter(AzureSubscription subscription)
        {
            return new SqlSecureConnectionAdapter(subscription);
        }

        protected override void SendModel(DatabaseSecureConnectionPolicyModel model)
        {
            ModelAdapter.SetDatabaseSecureConnectionPolicy(model, clientRequestId);
        }
    }
}