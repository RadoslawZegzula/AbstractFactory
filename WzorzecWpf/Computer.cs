
namespace WzorzecWpf
{
    internal class Computer
    {
        private readonly Cpu _cpu;
        private readonly Gpu _gpu;
        private readonly Motherboard _motherboard;
        private readonly Sticker _sticker;

        public Computer(Motherboard motherboard, Gpu gpu, Cpu cpu, Sticker sticker)
        {
            _motherboard = motherboard;
            _gpu = gpu;
            _cpu = cpu;
            _sticker = sticker;
        }

        public override string ToString()
        {
            if (_gpu == null || _cpu == null || _motherboard == null || _sticker == null) return "";
            var details =
                $"{_cpu.GetType().Name}: {_cpu.Cores} cores, {_cpu.Price}$\n{_gpu.GetType().Name}: {_gpu.Color} color, {_gpu.Price}$\n{_motherboard.GetType().Name}: {_motherboard.Size} size, {_motherboard.Price}$\n{_sticker.GetType().Name}: {_sticker.Hologram} hologram, {_sticker.Price}$";
            return details;
        }

        public string Price()
        {
            if (_gpu == null || _cpu == null || _motherboard == null || _sticker == null) return "";

            return $"Sum: {_gpu.Price + _cpu.Price + _motherboard.Price + _sticker.Price}$";
        }
    }
}