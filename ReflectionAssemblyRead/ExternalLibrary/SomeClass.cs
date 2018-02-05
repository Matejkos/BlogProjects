using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExternalLibrary
{
    public class SomeClass
    {
        public string SomeProperty { get; set; }
        public int SomeIntegerProperty { get; set; }

        public int Field;

        public SomeClass()
        {
            SomeProperty = "Default constructor";
            Field = 1;
        }

        public SomeClass(string propertyValue)
        {
            SomeProperty = propertyValue;
        }

        public int AddFieldToProperty()
        {
            return Field + SomeIntegerProperty;
        }

        public int AddValueToField(int value)
        {
            Field += value;
            return Field;
        }
    }
}
