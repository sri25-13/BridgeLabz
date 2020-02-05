using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class SumofTrip
    {
        public static void Trip()
        {
            
            Console.WriteLine("enter the array elements");
            int[] arr=Utility.readArray();
           
            

            for(int i=0;i<arr.Length-2;i++)
            {
                for(int j=i+1;j<arr.Length-1;j++)
                {
                    for(int k=j+1;k<arr.Length;k++)
                    {
                        if(arr[i]+arr[j]+arr[k]==0)
                        {
                            Console.WriteLine(arr[i] +","+arr[j] +","+ arr[k]);
                        }
                        
                        
                    }

                }
            }
        }
    }
}
