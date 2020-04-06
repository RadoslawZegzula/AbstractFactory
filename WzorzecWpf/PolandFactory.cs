using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzorzecWpf
{
    class PolandFactory
    {
        public GPU CreateGPU()
        {
            var gpu = new PolandGPU
            {
                Color = ConsoleColor.Magenta,
                Price = 123.0
            };
            return gpu;
        }

        public MotherBoard CreateMotherBoard()
        {
            var motherBoard = new PolandMotherBoard
            {
                Size = 128,
                Price = 55.0
            };
            return motherBoard;
        }

        public CPU CreateCPU()
        {
            var cpu = new PolandCPU
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
