using System;

namespace WzorzecWpf
{
    internal class CreatorCPU
    {
        public CPU CreateCPU(EOriginCountry eOriginCountry)
        {
            CPU cpu = null;

            switch (eOriginCountry)
            {
                case EOriginCountry.Poland:
                    cpu = new PolandFactory().CreateCpu();
                    break;
                case EOriginCountry.China:
                    cpu = new ChinaFactory().CreateCpu();
                    break;
                case EOriginCountry.Germany:
                    cpu = new GermanyFactory().CreateCPU();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(eOriginCountry), eOriginCountry, null);
            }

            return cpu;
        }
    }
}