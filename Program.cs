using System;
using System.Diagnostics;
using class_vs_struct.Helper;
using class_vs_struct.Types;

namespace class_vs_struct
{
    class Program
    {
        static void Main(string[] args)
        {
            var iterationCount = 10000000;
            
            // Initialization time
            var classTimer = new Stopwatch();
            var structTimer = new Stopwatch();
            
            classTimer.Start();
            for (var i = 0; i <= iterationCount; i++)
            {
                new PersonClass
                {
                    Name = "Name",
                    Surname = "Surname"
                };
            }
            classTimer.Stop();
            
            structTimer.Start();
            for (var i = 0; i <= iterationCount; i++)
            {
                new PersonStruct
                {
                    Name = "Name",
                    Surname = "Surname"
                };
            }
            structTimer.Stop();

            Console.WriteLine($"struct : {structTimer.ElapsedMilliseconds} ms");
            Console.WriteLine($"class  : {classTimer.ElapsedMilliseconds} ms");
            
            // Pass as parameters
            classTimer.Reset();
            structTimer.Reset();
            
            


            // Memory footprint


            // Pass as parameter
        }
    }
}
