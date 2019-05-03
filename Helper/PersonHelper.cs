using System.Collections.Generic;
using System.Linq;
using class_vs_struct.Types;

namespace class_vs_struct.Helper
{
    public static class PersonHelper
    {
        public static IList<PersonClass> CreatePersonClasses(int size)
        {
            return Enumerable.Repeat(new PersonClass
            {
                Name = "Name",
                Surname = "Surname"
            }, size).ToList();
        }

        public static IList<PersonStruct> CreatePersonStructs(int size)
        {
            return Enumerable.Repeat(new PersonStruct
            {
                Name = "Name",
                Surname = "Surname"
            }, size).ToList();
        }
    }
}