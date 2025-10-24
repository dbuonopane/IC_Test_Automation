using System;

namespace IC_Test_Automation
{
    public class VoltageStabilityTest : ITest
    {
        private readonly PowerSupply ps;
        public string Name => "Voltage Stability Test";

        public VoltageStabilityTest(PowerSupply powerSupply) => ps = powerSupply;

        public bool Run()
        {
            ps.SetVoltage(3.3);
            double current = ps.MeasureCurrent();
            bool pass = current < 0.04;

            TestLogger.Log($"{Name}: {(pass ? "PASS" : "FAIL")} - Current={current}A");
            return pass;
        }
    }
}
