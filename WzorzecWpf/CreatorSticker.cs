using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzorzecWpf
{
    class CreatorSticker
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
            }

            return sticker;
        }
    }

}
