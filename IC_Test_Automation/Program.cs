using System;
using System.Collections.Generic;

namespace IC_Test_Automation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== IC Test Automation Framework ===");

            // Initialize Drivers
            var ps = new PowerSupply();
            var spi = new SpiInterface();

            // Define Tests
            var tests = new List<ITest>
            {
                new VoltageStabilityTest(ps),
                new RegisterReadWriteTest(spi)
            };

            // Run Tests
            var sequencer = new TestSequencer(tests);
            sequencer.ExecuteAll();

            // Generate Final Report
            ReportGenerator.Generate(sequencer.Results);
        }
    }
}
