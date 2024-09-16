using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic16._09._2024
{
    internal class MyException : ApplicationException
    {
        public DateTime TimeException { get; set; }
        public MyException() : base("Моё исключение") {
            TimeException = DateTime.Now;
        }
    }

    class ExampleProperty
    {
        public string Name { get; set; }
        public ExampleProperty(string nameString)
        {
            if (nameString == null) throw new ArgumentNullException(nameof(nameString));
            Name = nameString;
        }
    }
}
