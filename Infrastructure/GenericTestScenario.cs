namespace class_vs_struct.Infrastructure
{
    public abstract class GenericTestScenario : ITestScenario
    {
        protected GenericTestScenario(string description, int iterations)
        {
            this.description = description;
            this.iterations = iterations;
        }
        
        public TestResult Run()
        {
            return new TestResult
            {
                Description = description,
                ClassResult = (TestResult.CLASS, RunClassTest()),
                StructResult = (TestResult.STRUCT, RunStructTest()),
                SimpleStructResult = (TestResult.SIMPLE_STRUCT, RunSimpleStructTest())
            };
        }
        
        protected int iterations { get; }

        private string description { get; }
        
        protected abstract string RunClassTest();

        protected abstract string RunStructTest();

        protected abstract string RunSimpleStructTest();
    }
}