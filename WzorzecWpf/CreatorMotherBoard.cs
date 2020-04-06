using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzorzecWpf
{
    class CreatorMotherBoard
    {
        public MotherBoard CreateMotherBoard(EOriginCountry eOriginCountry)
        {
            MotherBoard motherboard = null;
           
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
            }

            return motherboard;
        }


    }
}
