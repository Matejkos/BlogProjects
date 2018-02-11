using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAssertionsPlayGround
{
    public class LogicClass
    {
        public string[] ChopWords(string input)
        {
            return input.Split(' ');
        }

        public ChopData ChopToData(string input)
        {
            string[] data = input.Split(' ');
            return new ChopData() { Words = data, WordsCount = data.Length };
        }

        public void ThrowException()
        {
            throw new NotImplementedException("Invalida argument exception");
        }
    }
}
