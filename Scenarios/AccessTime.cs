using System.Collections.Generic;
using class_vs_struct.Infrastructure;
using class_vs_struct.Types;

namespace class_vs_struct.Scenarios
{
    public class AccessTime : TimedTestScenario
    {
        public AccessTime(int iterations) : base("Access time in a Dictionary", iterations)
        {
        }

        protected override void RunClassTest()
        {
            var dictionary = new Dictionary<int, PersonClass>
            {
                {
                    1, new PersonClass
                    {
                        Name = "Name",
                        Surname = "Surname"
                    }
                }
            };

            for (var i = 0; i < iterations; i++)
            {
                var foo = dictionary[1];
            }
        }

        protected override void RunStructTest()
        {
            var dictionary = new Dictionary<int, PersonStruct>
            {
                {
                    1, new PersonStruct
                    {
                        Name = "Name",
                        Surname = "Surname"
                    }
                }
            };

            for (var i = 0; i < iterations; i++)
            {
                var foo = dictionary[1];
            }
        }

        protected override void RunSimpleStructTest()
        {
            var dictionary = new Dictionary<int, SimplePersonStruct>
            {
                {
                    1, new SimplePersonStruct
                    {
                        Name = "Name",
                        Surname = "Surname"
                    }
                }
            };

            for (var i = 0; i < iterations; i++)
            {
                var foo = dictionary[1];
            }
        }
    }
}