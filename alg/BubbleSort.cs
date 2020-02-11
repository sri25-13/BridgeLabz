using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class BubbleSort
    {
        public static void Bubble()
        {
            int temp;
            
            List<int> MyList = new List<int>() { 1, 6, 9, 3 };
           
            
            
        
            for (int i = 0; i <= MyList.Count; i++)
            {
                for (int j = 1; j <= MyList.Count-1; j++)
                {
                    if (MyList[j - 1] > MyList[j])
                    {
                        temp = MyList[j - 1];
                        MyList[j - 1] = MyList[j];
                        MyList[j] = temp;
                    }
                }
            }
            Console.WriteLine("after sorting");
            for (int p = 0; p < MyList.Count; p++)
            {
                
                Console.WriteLine(MyList[p]+"");
               
            }
            
        }
    }
}

