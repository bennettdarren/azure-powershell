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
using System.Collections.Generic;
using System.Management.Automation;
using System.Linq;
using System.Globalization;
using Microsoft.Azure.Commands.Sql.Security.Services;

namespace Microsoft.Azure.Commands.Sql.Security.Cmdlet.DataMasking
{
    /// <summary>
    /// Sets properties for a data masking rule.
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "AzureSqlDatabaseDataMaskingRule")]
    public class SetAzureSqlDatabaseDataMaskingRule : BuildAzureSqlDatabaseDataMaskingRule
    {
        /// <summary>
        /// Gets or sets the masking function
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = "The type of the masking function")]
        [ValidateSet(Constants.NoMasking, Constants.Default, Constants.Text, Constants.Number, Constants.SSN, Constants.CCN, Constants.Email, IgnoreCase = false)]
        public override string MaskingFunction { get; set; } // intentionally overriding the parent's Masking function property, to defined it here as a non mandatory property

        protected override string ValidateOperation(IEnumerable<DatabaseDataMaskingRuleModel> rules)
        {
            if(!rules.Any(r=> r.RuleId == RuleId))
            {
                return string.Format(CultureInfo.InvariantCulture, Microsoft.Azure.Commands.Sql.Properties.Resources.SetDataMaskingRuleIdDoesNotExistError, RuleId);
            }
            return null;
        }

        protected override DatabaseDataMaskingRuleModel GetRule(IEnumerable<DatabaseDataMaskingRuleModel> rules)
        { 
            return rules.First(r=> r.RuleId == RuleId);
        }

        protected override IEnumerable<DatabaseDataMaskingRuleModel> UpdateRuleList(IEnumerable<DatabaseDataMaskingRuleModel> rules, DatabaseDataMaskingRuleModel rule)
        { 
            return rules;
        }
    }
}
