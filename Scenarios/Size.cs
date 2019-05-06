using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using class_vs_struct.Infrastructure;
using class_vs_struct.Types;

namespace class_vs_struct.Scenarios
{
    public class Size : GenericTestScenario
    {
        public Size() : base("Binary serialized size", 0)
        {
        }

        protected override string RunClassTest()
        {
            var o = new PersonClass
            {
                Name = "Name",
                Surname = "Surname"
            };
            using (Stream s = new MemoryStream()) {
                var formatter = new BinaryFormatter();
                formatter.Serialize(s, o);
                return $"{s.Length:N2} bytes" ;
            }
            
        }

        protected override string RunStructTest()
        {
            var o = new PersonStruct
            {
                Name = "Name",
                Surname = "Surname"
            };
            using (Stream s = new MemoryStream()) {
                var formatter = new BinaryFormatter();
                formatter.Serialize(s, o);
                return $"{s.Length:N2} bytes" ;
            }

            // var size = System.Runtime.InteropServices.Marshal.SizeOf(o);
            //return $"{size:N2} bytes" ;
        }

        protected override string RunSimpleStructTest()
        {
            var o = new SimplePersonStruct
            {
                Name = "Name",
                Surname = "Surname"
            };
            using (Stream s = new MemoryStream()) {
                var formatter = new BinaryFormatter();
                formatter.Serialize(s, o);
                return $"{s.Length:N2} bytes" ;
            }
        }
    }
}