using System;

namespace WzorzecWpf
{
    class PolandFactory
    {
        public Gpu CreateGpu()
        {
            var gpu = new PolandGpu
            {
                Color = ConsoleColor.Magenta,
                Price = 123.0
            };
            return gpu;
        }

        public Motherboard CreateMotherBoard()
        {
            var motherBoard = new PolandMotherboard
            {
                Size = 128,
                Price = 55.0
            };
            return motherBoard;
        }

        public Cpu CreateCpu()
        {
            var cpu = new PolandCpu
            {
                Cores = 12,
                Price = 99.0
            };
            return cpu;
        }

        public Sticker CreateSticker()
        {
            var sticker = new PolandSticker
            {
                Hologram = true,
                Price = 88.0
            };
            return sticker;
        }

    }
}
