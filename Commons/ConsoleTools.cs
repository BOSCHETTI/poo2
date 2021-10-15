using System;
using System.Collections.Generic;
using System.Text;

namespace POO2.Commons
{
    public class ConsoleTools
    {
        public void Escrever(string value)
        {
            Console.WriteLine(value);
        }

        public string Ler()
        {
            return Console.ReadLine();
        }
    }

}
