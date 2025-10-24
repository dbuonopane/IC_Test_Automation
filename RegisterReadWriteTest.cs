using System;

namespace IC_Test_Automation
{
    public class RegisterReadWriteTest : ITest
    {
        private readonly SpiInterface spi;
        public string Name => "Register Read/Write Test";

        public RegisterReadWriteTest(SpiInterface spiInterface) => spi = spiInterface;

        public bool Run()
        {
            int address = 0x10;
            byte value = 0xAB;

            spi.WriteRegister(address, value);
            byte readValue = spi.ReadRegister(address);

            bool pass = value == readValue;
            TestLogger.Log($"{Name}: {(pass ? "PASS" : "FAIL")} - Expected 0x{value:X2}, Got 0x{readValue:X2}");
            return pass;
        }
    }
}
