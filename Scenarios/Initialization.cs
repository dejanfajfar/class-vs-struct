using class_vs_struct.Infrastructure;
using class_vs_struct.Types;

namespace class_vs_struct.Scenarios
{
    public class Initialization : TimedTestScenario
    {
        public Initialization(int iterations) : base("Initialization time comparison", iterations) {}

        protected override void RunClassTest()
        {
            for (var i = 0; i <= iterations; i++)
            {
                new PersonClass
                {
                    Name = "Name",
                    Surname = "Surname"
                };
            }
        }

        protected override void RunStructTest()
        {
            for (var i = 0; i <= iterations; i++)
            {
                new PersonStruct
                {
                    Name = "Name",
                    Surname = "Surname"
                };
            }
        }

        protected override void RunSimpleStructTest()
        {
            for (var i = 0; i <= iterations; i++)
            {
                new SimplePersonStruct
                {
                    Name = "Name",
                    Surname = "Surname"
                };
            }
        }
    }
}