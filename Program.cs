using System;
using System.Collections.Generic;
using class_vs_struct.Infrastructure;
using class_vs_struct.Scenarios;

namespace class_vs_struct
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            const int iterationCount = 100000000;

            var scenarios = new List<ITestScenario>
            {
                new Initialization(iterationCount),
                new PassAsParameter(iterationCount),
                new AccessTime(iterationCount),
                new Size()
            };
            
            Console.WriteLine($"Executing each test {iterationCount:N1} times");
            Console.WriteLine("--------------------");
            
            scenarios.ForEach(s =>
            {
                var result = s.Run();
                Console.WriteLine($">> {result.Description.ToUpper()}");
                Console.WriteLine($"{result.ClassResult.result} {result.ClassResult.resultValue}");
                Console.WriteLine($"{result.StructResult.result} {result.StructResult.resultValue}");
                Console.WriteLine($"{result.SimpleStructResult.result} {result.SimpleStructResult.resultValue}");
            });

            // Memory footprint
        }
    }
}
