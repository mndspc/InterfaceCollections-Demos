using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCollectionsDemo
{
    class SortDisplay : IComparer<Display>
    {
        public int Compare(Display x, Display y)
        {
            return x.PPI.CompareTo(y.PPI);
        }
    }



    internal class Display
    {
        //  Pixel Per Inches
        public int PPI { get; set; }

        public string Resolution { get; set; }

        public string Size { get; set; }
    }
}
