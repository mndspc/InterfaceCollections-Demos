using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCollectionsDemo
{
    internal class SmartPhone:IComparable<SmartPhone>
    {
        public string Name { get; set; }

        public double Price { get; set; }

        //1:swap
        //0:retain
        //-1:dont swap
        public int CompareTo(SmartPhone other)
        {
            if (other != null)
            {
                return this.Price.CompareTo(other.Price);
            }
            else
            {
                throw new ArgumentException("object does not have price");
            }
        }
    }
}
