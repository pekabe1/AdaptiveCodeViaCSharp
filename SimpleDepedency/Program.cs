using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessagePrinter;

namespace SimpleDepedency
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new PrintService();
            service.PrintMessage();
            Console.Read();
        }
    }
}
// REMEMBER THAT POORLY MANAGED DEPENDECNIES QUCIK ESCALATE TO BIG ARCHITECTURAL PROBLEMS