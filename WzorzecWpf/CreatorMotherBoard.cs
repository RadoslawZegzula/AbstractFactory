using System;

namespace WzorzecWpf
{
    internal class CreatorMotherBoard
    {
        public Motherboard CreateMotherBoard(EOriginCountry eOriginCountry)
        {
            Motherboard motherboard = null;

            switch (eOriginCountry)
            {
                case EOriginCountry.Poland:
                    motherboard = new PolandFactory().CreateMotherBoard();
                    break;
                case EOriginCountry.China:
                    motherboard = new ChinaFactory().CreateMotherBoard();
                    break;
                case EOriginCountry.Germany:
                    motherboard = new GermanyFactory().CreateMotherBoard();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(eOriginCountry), eOriginCountry, null);
            }

            return motherboard;
        }
    }
}