using System;

namespace class_vs_struct.Types
{
    [Serializable]
    public struct SimplePersonStruct
    {
        public string Name;
        public string Surname;
        public string FullName => $"{Name} {Surname}";
    }
}