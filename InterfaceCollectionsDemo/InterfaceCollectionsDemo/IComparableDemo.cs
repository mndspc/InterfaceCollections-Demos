using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCollectionsDemo
{
    internal class IComparableDemo
    {
        static void Main()
        {
            //List<int> intList = new List<int> { 11, 4, 6, 1, 33 };
            //intList.Sort();
            //foreach (var num in intList)
            //{
            //    Console.WriteLine(num);
            //}

            List<SmartPhone> smartPhones = new List<SmartPhone>
            {
                new SmartPhone{Name="MI-Note10",Price=20000 },
                new SmartPhone{Name="Samsung-Galaxy",Price=18000 },
                new SmartPhone{Name="Oppo-F10",Price=10000 }
            };

           
            smartPhones.Sort();

            foreach (var smarphone in smartPhones)
            {
                Console.WriteLine($"Name={smarphone.Name}\t Price={smarphone.Price}");
            }
            Console.ReadLine();
        }
    }
}
