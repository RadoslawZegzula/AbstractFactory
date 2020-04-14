
namespace WzorzecWpf
{
    public abstract class Sticker
    {
        public bool Hologram { get; set; }
        public double Price { get; set; }
    }

    public class PolandSticker : Sticker
    {

    }

    public class ChinaSticker : Sticker
    {

    }

    public class GermanySticker : Sticker
    {

    }
}
