using class_vs_struct.Infrastructure;
using class_vs_struct.Types;

namespace class_vs_struct.Scenarios
{
    public class PassAsParameter : TimedTestScenario
    {
        public PassAsParameter(int iterations) : base("Pass as parameter time comparison", iterations)
        {
        }

        protected override void RunClassTest()
        {
            for (var i = 0; i <= iterations; i++)
            {
                var f = ClassPass(new PersonClass
                {
                    Name = "Name",
                    Surname = "Surname"
                });
            }
        }

        protected override void RunStructTest()
        {
            for (var i = 0; i <= iterations; i++)
            {
                var f = StructPass(new PersonStruct
                {
                    Name = "Name",
                    Surname = "Surname"
                });
            }
        }

        protected override void RunSimpleStructTest()
        {
            for (var i = 0; i <= iterations; i++)
            {
                var f = SimplePersonPass(new SimplePersonStruct
                {
                    Name = "Name",
                    Surname = "Surname"
                });
            }
        }

        private PersonClass ClassPass(PersonClass person)
        {
            return person;
        }

        private PersonStruct StructPass(PersonStruct person)
        {
            return person;
        }

        private SimplePersonStruct SimplePersonPass(SimplePersonStruct person)
        {
            return person;
        }

    }
}