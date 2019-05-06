using System;

namespace class_vs_struct.Types
{
    [Serializable]
    public class PersonClass
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FullName => $"{Name} {Surname}";
    }
}