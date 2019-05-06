using System.Diagnostics;

namespace class_vs_struct.Infrastructure
{
    public abstract class TimedTestScenario : ITestScenario
    {
        protected TimedTestScenario(string description, int iterations)
        {
            this.description = description;
            this.iterations = iterations;
        }

        protected int iterations { get; }

        private string description { get; }

        public TestResult Run()
        {
            var classTimer = new Stopwatch();
            var structTimer = new Stopwatch();
            var simpleStructTimer = new Stopwatch();
            
            classTimer.Start();
            RunClassTest();
            classTimer.Stop();
            
            structTimer.Start();
            RunStructTest();
            structTimer.Stop();
            
            simpleStructTimer.Start();
            RunSimpleStructTest();
            simpleStructTimer.Stop();

            return new TestResult
            {
                Description = description,
                ClassResult = (TestResult.CLASS, $"{classTimer.ElapsedMilliseconds:N} ms"),
                StructResult = (TestResult.STRUCT, $"{structTimer.ElapsedMilliseconds:N} ms"),
                SimpleStructResult = (TestResult.SIMPLE_STRUCT, $"{simpleStructTimer.ElapsedMilliseconds:N} ms")
            };
        }

        protected abstract void RunClassTest();

        protected abstract void RunStructTest();

        protected abstract void RunSimpleStructTest();
    }
}