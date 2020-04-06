using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzorzecWpf
{
    public abstract class MotherBoard
    {
        public int Size { get; set; }
        public double Price { get; set; }

    }

    public class PolandMotherBoard : MotherBoard
    {

    }

    public class ChinaMotherBoard : MotherBoard
    {

    }

    public class GermanyMotherBoard : MotherBoard
    {

    }
}
