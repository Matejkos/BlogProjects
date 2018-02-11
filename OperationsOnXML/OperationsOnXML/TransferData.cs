using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OperationsOnXML
{
    [XmlRoot(ElementName ="Data")]
    public class TransferData
    {
        [XmlAttribute(AttributeName ="Name")]
        public string UserName { get; set; }

        [XmlAttribute(AttributeName = "Date")]
        public DateTime TimeStamp { get; set; }

        [XmlElement("DataObject")]
        public List<KeyValueData> DataSet { get; set; }

        [XmlElement(ElementName ="ElementsCount")]
        public int DataCount
        {
            get { return DataElementsCount; }
            set { 
                    //noithing to do
                }
        }

        [XmlIgnore]
        public int DataElementsCount
        {
            get { return DataSet?.Count ?? 0; }
        }
    }
}
