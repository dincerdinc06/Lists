using System;
using System.Collections.Generic;

namespace Lists
{
    class MyList<T>
    {
        T[] array=new T[0];
        T[] temparray;

        public int Count
        {
            get { return array.Length; }
        }

        public void Add(T item)
        {
            temparray = array;
            array = new T[temparray.Length+1];
            for (int i = 0; i < temparray.Length; i++)
            {
                array[i] = temparray[i];
            }
            array[temparray.Length] = item;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Ankara");
            list.Add("Ankara");
            list.Add("Ankara");
            list.Add("Ankara");
            list.Add("Ankara");

            Console.WriteLine(list.Count);

            MyList<string> mylist = new MyList<string>();
            mylist.Add("Ankara");
            mylist.Add("Ankara");
            mylist.Add("Ankara");
            mylist.Add("Ankara");
            mylist.Add("Ankara");
            mylist.Add("Ankara");
            mylist.Add("Ankara");
            mylist.Add("Ankara");
            mylist.Add("Ankara");
            mylist.Add("Ankara");

            Console.WriteLine(mylist.Count);
            

            //int[] array = new int[1];
            //Console.WriteLine(array.Length);
            Console.ReadKey();
        }
    }
}
