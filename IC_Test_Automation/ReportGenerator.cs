
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace IC_Test_Automation
{
    public static class ReportGenerator
    {
        public static void Generate(List<TestResult> results)
        {
            string reportFile = "FinalReport.txt";
            int passCount = results.Count(r => r.Passed);
            int total = results.Count;

            var lines = new List<string>
            {
                "=== TEST SUMMARY REPORT ===",
                $"Total Tests: {total}",
                $"Passed: {passCount}",
                $"Failed: {total - passCount}",
                "",
                "Detailed Results:"
            };

            foreach (var result in results)
                lines.Add($"{result.Name}: {(result.Passed ? "PASS" : "FAIL")}");

            File.WriteAllLines(reportFile, lines);
            Console.WriteLine($"Report saved to {reportFile}");
        }
    }
}
