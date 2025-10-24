using System;

namespace IC_Test_Automation
{
    public class PowerSupply
    {
        private double currentVoltage;

        public void SetVoltage(double voltage)
        {
            if (voltage < 0 || voltage > 5)
                throw new ArgumentOutOfRangeException(nameof(voltage), "Voltage must be between 0 and 5V");

            currentVoltage = voltage;
            TestLogger.Log($"[PowerSupply] Voltage set to {voltage}V");
        }

        public double MeasureCurrent()
        {
            double current = Math.Round(0.02 + new Random().NextDouble() * 0.02, 4);
            TestLogger.Log($"[PowerSupply] Current measured: {current}A");
            return current;
        }
    }
}
