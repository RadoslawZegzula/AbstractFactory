using System;

namespace WzorzecWpf
{
    public class CreatorGpu
    {
        public Gpu CreateGpu(EOriginCountry eOriginCountry)
        {
            Gpu gpu = null;

            switch (eOriginCountry)
            {
                case EOriginCountry.Poland:
                    gpu = new PolandFactory().CreateGpu();
                    break;
                case EOriginCountry.China:
                    gpu = new ChinaFactory().CreateGpu();
                    break;
                case EOriginCountry.Germany:
                    gpu = new GermanyFactory().CreateGpu();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(eOriginCountry), eOriginCountry, null);
            }

            return gpu;
        }
    }
}