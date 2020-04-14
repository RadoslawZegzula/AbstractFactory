using System;
using System.Diagnostics;

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
                    Debug.WriteLine("creator GPU");
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