using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzorzecWpf
{
    class Computer
    {

        private GPU _gpu;
        private CPU _cpu;
        private MotherBoard _motherBoard;
        private Sticker _sticker;

        public Computer(MotherBoard motherBoard, GPU gpu, CPU cpu, Sticker sticker)
        {
            this._motherBoard = motherBoard;
            this._gpu = gpu;
            this._cpu = cpu;
            this._sticker = sticker;
        }

        public override string ToString()
        {
            if (_gpu == null || _cpu == null||_motherBoard==null||_sticker==null) return "";
            string details = $"{_cpu.GetType().Name}: {_cpu.Cores} cores, {_cpu.Price}$\n{_gpu.GetType().Name}: {_gpu.Color} color, {_gpu.Price}$\n{_motherBoard.GetType().Name}: {_motherBoard.Size} size, {_motherBoard.Price}$\n{_sticker.GetType().Name}: {_sticker.Hologram} hologram, {_sticker.Price}$";
            return details;
        }

        public string Price()
        {
            if (_gpu == null || _cpu == null || _motherBoard == null || _sticker == null) return "";

            return $"Sum: {_gpu.Price + _cpu.Price + _motherBoard.Price + _sticker.Price}$";
        }
    }
}
