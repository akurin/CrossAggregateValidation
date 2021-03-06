﻿using System;
using System.Diagnostics;
using NUnit.Framework;

namespace CrossAggregateValidation.Tests.Adapters
{
    public static class Eventually
    {
        public static void IsTrue(Func<bool> condition)
        {
            if (condition == null) throw new ArgumentNullException(nameof(condition));

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            while (true)
            {
                var conditionResult = condition();
                if (conditionResult)
                    return;

                if (stopwatch.Elapsed > TimeSpan.FromMilliseconds(500))
                    Assert.Fail();
            }
        }
    }
}