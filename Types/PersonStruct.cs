namespace class_vs_struct.Types
{
    public struct PersonStruct
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FullName => $"{Name} {Surname}";
    }
}