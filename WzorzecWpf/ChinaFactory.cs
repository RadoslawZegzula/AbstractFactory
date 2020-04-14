using System;

namespace WzorzecWpf
{
    internal class ChinaFactory
    {
        public Gpu CreateGpu()
        {
            var gpu = new ChinaGpu
            {
                Color = ConsoleColor.Magenta,
                Price = 150.0
            };
            return gpu;
        }

        public Motherboard CreateMotherBoard()
        {
            var motherboard = new ChinaMotherboard
            {
                Size = 128,
                Price = 250.0
            };
            return motherboard;
        }

        public Cpu CreateCpu()
        {
            var cpu = new ChinaCpu
            {
                Cores = 128,
                Price = 250.0
            };
            return cpu;
        }

        public Sticker CreateSticker()
        {
            var sticker = new ChinaSticker
            {
                Hologram = true,
                Price = 1
            };
            return sticker;
        }
    }
}