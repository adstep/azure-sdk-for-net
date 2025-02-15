// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> A list of rules results. </summary>
    internal partial class RulesResults
    {
        /// <summary> Initializes a new instance of RulesResults. </summary>
        internal RulesResults()
        {
            Value = new ChangeTrackingList<SqlVulnerabilityAssessmentBaselineRuleData>();
        }

        /// <summary> Initializes a new instance of RulesResults. </summary>
        /// <param name="value"> List of rule results. </param>
        internal RulesResults(IReadOnlyList<SqlVulnerabilityAssessmentBaselineRuleData> value)
        {
            Value = value;
        }

        /// <summary> List of rule results. </summary>
        public IReadOnlyList<SqlVulnerabilityAssessmentBaselineRuleData> Value { get; }
    }
}
