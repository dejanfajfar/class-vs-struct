namespace class_vs_struct.Infrastructure
{
    public struct TestResult
    {
        public const string CLASS =         "class         : ";
        public const string STRUCT =        "struct        : ";
        public const string SIMPLE_STRUCT = "simple struct : ";
        
        public string Description { get; set; }
        public (string result, string resultValue) ClassResult { get; set; }
        public (string result, string resultValue) StructResult { get; set; }
        public (string result, string resultValue) SimpleStructResult { get; set; }
    }
}