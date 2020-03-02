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
                    () => PrintTeacherDetails(),
                    () => PrintStudentdetails()
                    );
        }
        private static void PrintTeacherDetails()
        {
            ThreadSafeSingleton fromTeacher = ThreadSafeSingleton.GetInstance;
            fromTeacher.PrintDetails("From Teacher");
        }
        private static void PrintStudentdetails()
        {
            ThreadSafeSingleton fromStudent = ThreadSafeSingleton.GetInstance;
            fromStudent.PrintDetails("From Student");
        }
    }
}

