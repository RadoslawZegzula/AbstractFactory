
namespace WzorzecWpf
{
    internal class Client
    {
        private Cpu _cpu;
        private Gpu _gpu;
        private Motherboard _motherboard;
        private Sticker _sticker;

        public void OrderGpu(EOriginCountry eOriginCountry)
        {
            var creatorGpu = new CreatorGpu();
            _gpu = creatorGpu.CreateGpu(eOriginCountry);
        }

        public void OrderCpu(EOriginCountry eOriginCountry)
        {
            var creatorCpu = new CreatorCPU();
            _cpu = creatorCpu.CreateCPU(eOriginCountry);
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