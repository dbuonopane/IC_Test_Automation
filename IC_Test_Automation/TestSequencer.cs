using System;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using System.Collections.Generic;

namespace IC_Test_Automation
{
    public class TestSequencer
    {
        private readonly List<ITest> tests;
        public List<TestResult> Results { get; } = new();

        public TestSequencer(List<ITest> testList)
        {
            tests = testList;
        }

        public void ExecuteAll()
        {
            TestLogger.Log("Starting Test Sequence...");
            foreach (var test in tests)
            {
                bool result = false;
                try
                {
                    result = test.Run();
                }
                catch (Exception ex)
                {
                    TestLogger.Log($"[ERROR] {test.Name}: {ex.Message}");
                }
                Results.Add(new TestResult(test.Name, result));
            }
            TestLogger.Log("Test Sequence Completed.");
        }
    }
}
