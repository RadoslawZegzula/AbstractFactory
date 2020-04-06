using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzorzecWpf
{
    class GermanyFactory
    {

        public GPU CreateGPU()
        {
            var gpu = new GermanyGPU
            {
                Color = ConsoleColor.Magenta,
                Price = 88.0
            };
            return gpu;
        }

        public MotherBoard CreateMotherBoard()
        {
            var motherboad = new GermanyMotherBoard
            {
                Size = 150,
                Price = 88.0
            };
            return motherboad;
        }

        public CPU CreateCPU()
        {
            var cpu = new GermanyCPU
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
