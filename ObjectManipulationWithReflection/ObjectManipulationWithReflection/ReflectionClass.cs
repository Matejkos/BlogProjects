using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectManipulationWithReflection
{
    public class ReflectionClass
    {
        public string ReadedProperty { get; set; }
        public string ConstructorFilledProperty { get; private set; }

        public int NumericProperty { get; set; }

        public ReflectionClass()
        {
            ReadedProperty = "readed property";
            ConstructorFilledProperty = "Filled by default";
        }

        public ReflectionClass(string propertyValue)
        {
            ReadedProperty = "readed property";
            ConstructorFilledProperty = propertyValue;
        }

        public string ReadBothProperty()
        {
            return ReadedProperty + ConstructorFilledProperty;
        }

        public int InrementNumeric(int value)
        {
            NumericProperty += value;
            return NumericProperty;
        }

    }
}
