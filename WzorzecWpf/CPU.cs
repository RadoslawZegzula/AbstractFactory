
namespace WzorzecWpf
{
    public abstract class Cpu
    {
        public int Cores { get; set; }
        public double Price { get; set; }
    }

    public class PolandCpu : Cpu
    {
    }

    public class ChinaCpu : Cpu
    {
    }

    public class GermanyCpu : Cpu
    {
    }
}