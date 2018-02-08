using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OperationsOnXML
{
    [XmlRoot(ElementName ="Data")]
    public class KeyValueData
    {
        [XmlElement(ElementName ="Key")]
        public string Key { get; set; }

        [XmlElement(ElementName = "Value")]
        public string Value { get; set; }
    }
}
