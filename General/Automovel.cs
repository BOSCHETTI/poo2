using System;
using System.Collections.Generic;
using System.Text;
using POO2.Commons;

namespace POO2.General
{
    public class Automovel : Veiculo
    {

        public ConsoleTools _consoletools = new ConsoleTools();

        public Automovel(string tipo) : base(tipo)
        {
        }
        public override void Mover()
        {
            _consoletools.Escrever("Acelerando o automovel");
        }

        public override void Parar()
        {
            _consoletools.Escrever("Estou parando o automovel");
        }







    }
}
