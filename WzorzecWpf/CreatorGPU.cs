using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;//

namespace WzorzecWpf
{
    public class CreatorGPU
    {
        public GPU CreateGPU(EOriginCountry eOriginCountry)
        {
            GPU gpu = null;

            switch (eOriginCountry)
            {
                case EOriginCountry.Poland:
                    gpu = new PolandFactory().CreateGPU();
                    break;
                case EOriginCountry.China:
                    gpu = new ChinaFactory().CreateGPU();
                    Debug.WriteLine("creator GPU");
                    break;
                case EOriginCountry.Germany:
                    gpu = new GermanyFactory().CreateGPU();
                    break;

            }

            return gpu;
        }
    }
}
