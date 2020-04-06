using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzorzecWpf
{
    public abstract class CPU
    {
        public int Cores { get; set; }
        public double Price { get; set; }
    }

    public class PolandCPU : CPU
    {

    }

    public class ChinaCPU : CPU
    {

    }

    public class GermanyCPU : CPU
    {

    }

}
