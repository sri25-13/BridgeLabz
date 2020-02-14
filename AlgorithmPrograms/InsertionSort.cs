using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class InsertionSort
    {
        public static void Insertion()
        {

            List<string> MyList = new List<string>() { "harshini", "amulya", "lucky", "teju" };
            int n = MyList.Count;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (MyList[i].CompareTo(MyList[j]) > 0)
                    {
                        string temp = MyList[i];
                        MyList[i] = MyList[j];
                        MyList[j] = temp;
                    }
                }
                Console.WriteLine(MyList[i]);

            }
        }
    }
}
