using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OperationsOnXML
{
    class Program
    {
        static void Main(string[] args)
        {
            var serialize = new XmlSerializer(typeof(TransferData));
            TransferData testObject = new TransferData();
            testObject.UserName = "Mateusz Stanek";
            testObject.TimeStamp = DateTime.Now;
            testObject.DataSet = new List<KeyValueData>();
            testObject.DataSet.Add(new KeyValueData { Key = "Path" , Value="Some path"});
            testObject.DataSet.Add(new KeyValueData { Key = "Reference number", Value = "1287394" });
            testObject.DataSet.Add(new KeyValueData { Key = "TestObject", Value = "Object123" });

            using (var stream = new StreamWriter("SerializedObject.xml", false))
            {
                serialize.Serialize(stream, testObject);
            }

            TransferData readedData = null;

            using (var stream = new StreamReader("SerializedObject.xml"))
            {
                readedData = (TransferData) serialize.Deserialize(stream);
            }

            Console.ReadLine();
        }
    }
}
