using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WzorzecWpf
{
    class Client
    {
        private CPU _cpu;
        private GPU _gpu;      
        private MotherBoard _motherboard;
        private Sticker _sticker;

        public void OrderGPU(EOriginCountry eOriginCountry)
        {
            var creatorGPU = new CreatorGPU();
            _gpu = creatorGPU.CreateGPU(eOriginCountry);

        }

        public void OrderCPU(EOriginCountry eOriginCountry)
        {
            var creatorCPU = new CreatorCPU();
            _cpu = creatorCPU.CreateCPU(eOriginCountry);
        }

        public void OrderMotherBoard(EOriginCountry eOriginCountry)
        {
            var creatorMotherBoard = new CreatorMotherBoard();
            _motherboard = creatorMotherBoard.CreateMotherBoard(eOriginCountry);
        }


        public void OrderSticker(EOriginCountry eOriginCountry)
        {
            var creatorSticker = new CreatorSticker();
            _sticker = creatorSticker.CreateSticker(eOriginCountry);
        }


        public Computer CreateComputer()
        {
            return new Computer(_motherboard, _gpu, _cpu, _sticker);
        }
    }
}
