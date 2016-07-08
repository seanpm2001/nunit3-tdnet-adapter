﻿namespace NUnitTDNet.Adapter.Examples.Expected
{
    using NUnit.Framework;
    using TestDriven.Framework;

    public class InconclusiveTests
    {
        [Test, ExpectTestRun(TestRunState.Success, IgnoredCount = 1)]
        public void AssumeThat()
        {
            Assume.That(false);
        }
    }
}
