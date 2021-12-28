using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCollectionsDemo
{
    class Cars : IEnumerator<Car>
    {
     

        object IEnumerator.Current => throw new NotImplementedException();

        int position = -1;
        List<Car> carList=new List<Car>();

        //  Indexer Property
        public Car this[int index]
        {
            get
            {
                return carList[index];
            }
            set
            {
                carList.Add(value);
            }
        }


        public Car Current
        {
            get
            {
                if (position < carList.Count)
                {
                    return null;
                }
                else
                {
                    return carList[position];
                }
            }
            set
            {

            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            position++;
            return (position < carList.Count);
        }

        public void Reset()
        {
            position = -1;
        }
    }


    internal class Car
    {
        public int Year { get; set; }

        public string ModelName { get; set; }
    }
}
