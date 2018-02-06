using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ObjectManipulationWithReflection
{
    public class Program
    {
        public static void Main()
        {
            Type classType = typeof(ReflectionClass);
            
            // create object with default constructor.
            object reflectionClass = Activator.CreateInstance(classType);
            ReflectionClass castedClass = reflectionClass as ReflectionClass;
            if(castedClass!=null)
            {
                Console.WriteLine(castedClass.ConstructorFilledProperty);
            }

            object[] arguments = new object[] { "Parameter class" };
            // create object with paramerized constructor.
            reflectionClass = Activator.CreateInstance(classType, arguments);
            castedClass = reflectionClass as ReflectionClass;
            if (castedClass != null)
            {
                Console.WriteLine(castedClass.ConstructorFilledProperty);
            }

            //Get property information
            PropertyInfo property = classType.GetProperty("ConstructorFilledProperty");
            Console.WriteLine(((ReflectionClass)reflectionClass).ConstructorFilledProperty);

            //set property value  !! private set !!
            property.SetValue(reflectionClass, "new Value");

            // Read property value.
            string propertyValue = (string)property.GetValue(reflectionClass);
            Console.WriteLine(((ReflectionClass)reflectionClass).ConstructorFilledProperty);
            Console.WriteLine(propertyValue);

            //invoke method
            MethodInfo readBothMethod = classType.GetMethod("ReadBothProperty");
            string returnedValue = (string)readBothMethod.Invoke(reflectionClass, new object[0]);
            Console.WriteLine(returnedValue);

            MethodInfo addValueMethod = classType.GetMethod("InrementNumeric");
            int returnedInt = (int)addValueMethod.Invoke(reflectionClass, new object[] { 5});
            Console.WriteLine(returnedInt);
            returnedInt = (int)addValueMethod.Invoke(reflectionClass, new object[] { 5 });
            Console.WriteLine(returnedInt);

            IEnumerable<Attribute> attributes = readBothMethod.GetCustomAttributes();

            Console.ReadLine();
        }
    }
}
