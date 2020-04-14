
namespace WzorzecWpf
{
    public abstract class CPU
    {
        public int Cores { get; set; }
        public double Price { get; set; }
    }

    public class PolandCpu : CPU
    {
    }

    public class ChinaCpu : CPU
    {
    }

    public class GermanyCpu : CPU
    {
    }
}