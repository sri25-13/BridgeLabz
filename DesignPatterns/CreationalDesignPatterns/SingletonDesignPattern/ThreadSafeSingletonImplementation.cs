using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalDesignPatterns.Singleton
{
   public class ThreadSafeSingletonImplementation
    {
        public static void Singleton()
        {
            Parallel.Invoke(
                    () => PrintStudentName(),
                    () => PrintStudentId()
                    );
        }
        private static void PrintStudentName()
        {
            ThreadSafeSingleton studentname = ThreadSafeSingleton.GetInstance;
            studentname.PrintDetails("sriharshini");
        }
        private static void PrintStudentId()
        {
            ThreadSafeSingleton studentId = ThreadSafeSingleton.GetInstance;
            studentId.PrintDetails("15");
        }
    }
}

