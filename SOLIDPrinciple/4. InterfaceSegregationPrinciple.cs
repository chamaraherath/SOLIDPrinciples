using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciple
{
    public interface IPrinter
    {
        void Print();
    }

    public interface IScanner
    {
        void Scan();
    }

    public interface IFaxMachine
    {
        void Fax();
    }

    public class BasicPrinter : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Printing Document...");
        }

    }

    public class IntermediatePrinter : BasicPrinter, IScanner
    {

        public void Scan()
        {
            Console.WriteLine("Scanning document...");
        }
    }

    public class AdvancePrinter : IntermediatePrinter, IFaxMachine
    {
        public void Fax()
        {
            Console.WriteLine("Sending fax...");
        }
    }
}
