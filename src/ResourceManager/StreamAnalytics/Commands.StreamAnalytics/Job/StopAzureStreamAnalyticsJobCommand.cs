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

using System;
using System.Globalization;
using System.Management.Automation;
using System.Net;
using System.Security.Permissions;
using Microsoft.Azure.Commands.StreamAnalytics.Models;
using Microsoft.Azure.Commands.StreamAnalytics.Properties;

namespace Microsoft.Azure.Commands.StreamAnalytics
{
    [Cmdlet(VerbsLifecycle.Stop, Constants.StreamAnalyticsJob)]
    public class StopAzureStreamAnalyticsJobCommand : StreamAnalyticsResourceProviderBaseCmdlet
    {
        [Parameter(Position = 1, Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The azure stream analytics job name.")]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        [EnvironmentPermission(SecurityAction.Demand, Unrestricted = true)]
        public override void ExecuteCmdlet()
        {
            if (ResourceGroupName != null && string.IsNullOrWhiteSpace(ResourceGroupName))
            {
                throw new PSArgumentNullException("ResourceGroupName");
            }

            JobParametersBase parameter = new JobParametersBase()
            {
                ResourceGroupName = ResourceGroupName,
                JobName = Name
            };

            try
            {
                HttpStatusCode statusCode = StreamAnalyticsClient.StopPSJob(parameter);
                if (statusCode == HttpStatusCode.OK)
                {
                    WriteObject(true);
                }
                else if (statusCode == HttpStatusCode.NoContent)
                {
                    WriteWarning(string.Format(CultureInfo.InvariantCulture, Resources.JobNotFound, Name, ResourceGroupName));
                }
                else
                {
                    WriteObject(false);
                }
            }
            catch
            {
                WriteObject(false);
            }
        }
    }
}