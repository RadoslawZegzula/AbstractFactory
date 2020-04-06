using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzorzecWpf
{
    public abstract class GPU
    {
        public ConsoleColor Color { get; set; }
        public double Price { get; set; }

    }

    public class PolandGPU : GPU
    {

    }

    public class ChinaGPU : GPU
    {

    }

    public class GermanyGPU : GPU
    {

    }
}
