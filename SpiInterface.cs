using System;
using System.Collections.Generic;

namespace IC_Test_Automation
{
    public class SpiInterface
    {
        private readonly Dictionary<int, byte> registers = new();

        public void WriteRegister(int address, byte value)
        {
            registers[address] = value;
            TestLogger.Log($"[SPI] Wrote value 0x{value:X2} to address 0x{address:X2}");
        }

        public byte ReadRegister(int address)
        {
            if (registers.TryGetValue(address, out var value))
            {
                TestLogger.Log($"[SPI] Read value 0x{value:X2} from address 0x{address:X2}");
                return value;
            }
            throw new Exception($"[SPI] Register 0x{address:X2} not initialized");
        }
    }
}
