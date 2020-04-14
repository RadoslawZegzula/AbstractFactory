
namespace WzorzecWpf
{
    public abstract class Motherboard
    {
        public int Size { get; set; }
        public double Price { get; set; }
    }

    public class PolandMotherboard : Motherboard
    {

    }

    public class ChinaMotherboard : Motherboard
    {

    }

    public class GermanyMotherboard : Motherboard
    {

    }
}
