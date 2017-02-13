﻿// Copyright (c) Allan Hardy. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using App.Metrics.Core.Abstractions;
using App.Metrics.Tagging;

namespace App.Metrics.Counter
{
    /// <summary>
    ///     Combines the value for a counter with the defined unit for the value.
    /// </summary>
    public sealed class CounterValueSource : MetricValueSourceBase<CounterValue>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="CounterValueSource" /> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        /// <param name="unit">The unit.</param>
        /// <param name="tags">The tags.</param>
        /// <param name="resetOnReporting">if set to <c>true</c> [reset on reporting]. Defaults to <c>false</c>.</param>
        /// <param name="reportItemPercentages">if set to <c>true</c> [report item percentages]. Defaults to <c>true</c></param>
        /// <param name="reportSetItems">if set to <c>true</c> [report set items]. Defaults to <c>true</c></param>
        public CounterValueSource(
            string name,
            IMetricValueProvider<CounterValue> value,
            Unit unit,
            MetricTags tags,
            bool resetOnReporting = false,
            bool reportItemPercentages = true,
            bool reportSetItems = true)
            : base(name, value, unit, tags)
        {
            ResetOnReporting = resetOnReporting;
            ReportItemPercentages = reportItemPercentages;
            ReportSetItems = reportSetItems;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="CounterValueSource" /> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="group">The group.</param>
        /// <param name="value">The value.</param>
        /// <param name="unit">The unit.</param>
        /// <param name="tags">The tags.</param>
        /// <param name="resetOnReporting">if set to <c>true</c> [reset on reporting]. Defaults to <c>false</c>.</param>
        /// <param name="reportItemPercentages">if set to <c>true</c> [report item percentages]. Defaults to <c>true</c></param>
        /// <param name="reportSetItems">if set to <c>true</c> [report set items]. Defaults to <c>true</c></param>
        public CounterValueSource(
            string name,
            string group,
            IMetricValueProvider<CounterValue> value,
            Unit unit,
            MetricTags tags,
            bool resetOnReporting = false,
            bool reportItemPercentages = true,
            bool reportSetItems = true)
            : base(name, group, value, unit, tags)
        {
            ResetOnReporting = resetOnReporting;
            ReportItemPercentages = reportItemPercentages;
            ReportSetItems = reportSetItems;
        }

        public bool ReportItemPercentages { get; }

        public bool ReportSetItems { get; }

        public bool ResetOnReporting { get; }
    }
}