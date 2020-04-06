using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzorzecWpf
{
    class CreatorCPU
    {
        public CPU CreateCPU(EOriginCountry eOriginCountry)
        {
            CPU cpu = null;

            switch (eOriginCountry)
            {
                case EOriginCountry.Poland:
                    cpu = new PolandFactory().CreateCPU();
                    break;
                case EOriginCountry.China:
                    cpu = new ChinaFactory().CreateCPU();
                    break;
                case EOriginCountry.Germany:
                    cpu = new GermanyFactory().CreateCPU();
                    break;

            }

            return cpu;
        }

    }
}
