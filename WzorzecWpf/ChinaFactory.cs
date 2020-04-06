using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzorzecWpf
{




    /// <summary>
    /// ///////creatory!!!!!!!!!!!!!!!!!!!
    /// </summary>
    class ChinaFactory
    {
        public GPU CreateGPU()
        {
            var gpu = new ChinaGPU
            {
                Color = ConsoleColor.Magenta,
                Price = 150.0
            };
            return gpu;
        }

        public MotherBoard CreateMotherBoard()
        {
            var motherboad = new ChinaMotherBoard
            {
                Size = 128,
                Price = 250.0
            };
            return motherboad;
        }

        public CPU CreateCPU()
        {
            var cpu = new ChinaCPU
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
