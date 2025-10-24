using NUnit.Framework;
using System;

namespace IC_Test_Automation.Tests
{
    public class PowerSupplyTests
    {
        [Test]
        public void SetVoltage_ShouldThrow_WhenOutOfRange()
        {
            var ps = new PowerSupply();
            Assert.Throws<ArgumentOutOfRangeException>(() => ps.SetVoltage(10));
        }

        [Test]
        public void MeasureCurrent_ShouldReturnWithinRange()
        {
            var ps = new PowerSupply();
            ps.SetVoltage(3.3);
            var current = ps.MeasureCurrent();
            Assert.That(current, Is.InRange(0.0, 0.05));
        }
    }
}
