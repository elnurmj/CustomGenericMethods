using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MyList
{
    public class MyList<T>/*:IEnumerable<T>*/
    {
        
        public T[] List;
        public int count;
        public string list;
        public MyList()
        {
            List = new T[10];
        }
        public void ArrayResize()
        {
            Array.Resize(ref List, List.Length + 10);


        }



        public void Clear(T obj)
        {
            var count = 0;
            for (int i = 0; i < List.Length; i++)
            {
                List[count] = List[List.Length - 1];
                count++;
            }
            Console.Clear();

        }


        public void Add(T item)
        {
           
            {
                ArrayResize();
            }
            List[count] = item;
            count++;
            Console.WriteLine(item);


        }


        public void AddRange(T List)
        {
            Add(List);
        }

        public void FindList(string val)
        {

            foreach (var item in List)
            {
                Console.WriteLine(item);




            }

        }

    }

}