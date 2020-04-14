using System;

namespace WzorzecWpf
{
    internal class CreatorSticker
    {
        public Sticker CreateSticker(EOriginCountry eOriginCountry)
        {
            Sticker sticker = null;

            switch (eOriginCountry)
            {
                case EOriginCountry.Poland:
                    sticker = new PolandFactory().CreateSticker();
                    break;
                case EOriginCountry.China:
                    sticker = new ChinaFactory().CreateSticker();
                    break;
                case EOriginCountry.Germany:
                    sticker = new GermanyFactory().CreateSticker();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(eOriginCountry), eOriginCountry, null);
            }

            return sticker;
        }
    }
}