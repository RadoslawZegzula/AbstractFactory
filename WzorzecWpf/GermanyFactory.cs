using System;

namespace WzorzecWpf
{
    internal class GermanyFactory
    {
        public Gpu CreateGpu()
        {
            var gpu = new GermanyGpu
            {
                Color = ConsoleColor.Magenta,
                Price = 88.0
            };
            return gpu;
        }

        public Motherboard CreateMotherBoard()
        {
            var motherboad = new GermanyMotherboard
            {
                Size = 150,
                Price = 88.0
            };
            return motherboad;
        }

        public Cpu CreateCPU()
        {
            var cpu = new GermanyCpu
            {
                Cores = 12,
                Price = 88.0
            };
            return cpu;
        }

        public Sticker CreateSticker()
        {
            var sticker = new GermanySticker
            {
                Hologram = true,
                Price = 88.0
            };
            return sticker;
        }
    }
}