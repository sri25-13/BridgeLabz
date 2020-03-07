// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ThreadSafeSingletonImplementation.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.CreationalDesignPatterns.Singleton
{
    using System.Threading.Tasks;

    /// <summary>
    /// class for implementing ThreadSafeImplementation
    /// </summary>
    public class ThreadSafeSingletonImplementation
    {
        /// <summary>
        /// Singletons this instance.
        /// </summary>
        public static void Singleton()
        {
            Parallel.Invoke(
                    () => PrintStudentId(),
            () => PrintStudentName());
        }

        /// <summary>
        /// Prints the name of the student.
        /// </summary>
        private static void PrintStudentName()
        {
            ThreadSafeSingleton studentname = ThreadSafeSingleton.GetInstance;
            studentname.PrintDetails("StudentName is sriharshini");
        }

        /// <summary>
        /// Prints the student identifier.
        /// </summary>
        private static void PrintStudentId()
        {
            ThreadSafeSingleton studentId = ThreadSafeSingleton.GetInstance;
            studentId.PrintDetails("StudentId is 15");
        }
    }
}