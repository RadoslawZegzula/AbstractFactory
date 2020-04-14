using System;

namespace WzorzecWpf
{
    public abstract class Gpu
    {
        public ConsoleColor Color { get; set; }
        public double Price { get; set; }
    }

    public class PolandGpu : Gpu
    {
    }

    public class ChinaGpu : Gpu
    {
    }

    public class GermanyGpu : Gpu
    {
    }
}